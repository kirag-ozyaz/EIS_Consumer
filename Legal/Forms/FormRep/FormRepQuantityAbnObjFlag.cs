using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SchemeModelN;

namespace Legal.Forms.FormRep 
{
    public partial class FormRepQuantityAbnObjFlag : FormLbr.FormBase
    {
        private class ItemChecked
        {
            public string Name { get; set; }
            public int Id { get; set; }

            public ItemChecked()
            {
            }

            public ItemChecked(string name, int id)
            {
                Name = name;
                Id = id;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        #region toolStripMain Events
        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvefAbnFlags.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxFind.Text);
        }


        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvefAbnFlags.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvefAbnFlags.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvefAbnFlags.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvefAbnFlags.PrintDataGridView();
        }
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvefAbnFlags.ExportToExcel();
        }
        // Обновить
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {

            dgvefAbnFlags.Refresh();

        }
        #endregion

        public FormRepQuantityAbnObjFlag()
        {
            InitializeComponent();

            for (DateTime d_c = System.DateTime.Now; d_c >= new DateTime(2007, 01, 01);
            d_c = d_c.AddMonths(-1))
            {
                cBoxPeriodBeg.Items.Add(d_c);
                cBoxPeriodEnd.Items.Add(d_c);
            }
                cBoxPeriodBeg.SelectedIndex = 0;
                cBoxPeriodEnd.SelectedIndex = 0;

        }

        private void FormRepQuantityAbnObjFlag_Load(object sender, EventArgs e)
        {
            SelectSqlDataTableOther(dsRep, dsRep.tR_Classifier_GroupFlags, "tR_Classifier", true, "where ParentId = 927 and id != 1354 and IsGroup = 1 and Deleted = 0 ");
            LoadFlags();
            this.rwRep.RefreshReport();
        }

        //
        private void LoadFlags()
        {
            SelectSqlDataTableOther(dsRep, dsRep.tR_Classifier_Flags, "tR_Classifier", true, "where (ParentId = " + cbGroupFlags.SelectedValue.ToString() + " or ParentId = 1354) and IsGroup = 0 and Deleted = 0 ");

            clbFlags.Items.Clear();

            ItemChecked item = new ItemChecked("Все", 1);
            clbFlags.Items.Add(item, false);

            foreach (DataRow dr in dsRep.tR_Classifier_Flags.Rows)
            {
                item = new ItemChecked(dr["Name"].ToString(),
                   Convert.ToInt32(dr["Id"]));
                clbFlags.Items.Add(item, false);
            }


        }

        private void cbGroupFlags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupFlags.SelectedValue != null) LoadFlags();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dsRep.vG_AbnObjQuantity_Flag.Clear();

            DateTime PeriodBeg = Convert.ToDateTime(cBoxPeriodBeg.SelectedItem);
            int beg = Convert.ToInt16(PeriodBeg.Year) * 100 + Convert.ToInt16(PeriodBeg.Month);
            DateTime PeriodEnd = Convert.ToDateTime(cBoxPeriodEnd.SelectedItem);
            int end = Convert.ToInt16(PeriodEnd.Year) * 100 + Convert.ToInt16(PeriodEnd.Month);

            int items = clbFlags.CheckedItems.Count;

            int f = 1;
            string flags = "";

            foreach (object itemChecked in clbFlags.CheckedItems)
            {
                if ((int)(((ItemChecked)itemChecked).Id) == 1) f = 0;
                if ((int)(((ItemChecked)itemChecked).Id) > 1)
                {
                    if (items >1) flags += ((ItemChecked)itemChecked).Id.ToString() + " , ";
                    if (items == 1) flags += ((ItemChecked)itemChecked).Id.ToString() ;
                    items--;

                }
            }

            if (flags == "") MessageBox.Show("Не выбран признак!");
            else
            {
                string where = " where YMonth >= " + beg.ToString() + " and  YMonth <= " + end.ToString();
                //this.SelectSqlData(dsRep, dsRep.vG_AbnObjQuantity_Flag, true, where);

                where += " and idObj in (select idAbnObj from tAbnObjFlags where ";
                if (f == 1) where += " idFlag in ( " + flags + " ) and ";
                where += " Deleted = 0) ";

                string select = "SET LANGUAGE russian select * ";

                select += " from [vG_AbnObjQuantity_Flag] obj ";

                where += "Order by CodeAbonent,nameObj,YMonth";

                select += where;

                //        dgvefAbnFlags.AutoGenerateColumns = true;

                DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
                try
                {

                    sql.OpenConnection(this.SqlSettings);

                    dsRep.Tables["vG_AbnObjQuantity_Flag"].Clear();


                    SqlCommand sqlCmd = new SqlCommand(select, sql.Connection);

                    sqlCmd.CommandTimeout = 600;

                    SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                    dAdapt.Fill(dsRep, "vG_AbnObjQuantity_Flag");


                }
                catch (Exception ex) // Если ошибка
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {   // В любом случае коннект надо закрыть
                    sql.CloseConnection();
                }

                UpdateSchmLink();

                rwRep.RefreshReport();
            }
            this.Cursor = Cursors.Default;
                                
        }

        private void UpdateSchmLink()
        {
            // MessageBox.Show(dsRep.vG_AbnObjQuantity_Flag.Rows.Count.ToString());
            // теперь получаем данные по привязкам объектов
            ElectricModel electricModel = new ElectricModel();
            electricModel.SqlSettings = this.SqlSettings;
            electricModel.LoadSchema(true);

            int idSchmObj = 0;
            int idAbnObj = 0;
            string StrLink = null;
            string[] idLinks;

            string str = "";

            // int i = 1;
            //   int rows = dsRep.vG_AbnObjQuantity_Flag.Rows.Count;

            foreach (DataRow row in dsRep.vG_AbnObjQuantity_Flag.Rows)
            {

                str = "";
                idAbnObj = Convert.ToInt32(row["idObj"]);
                StrLink = (row["idSchm"]).ToString();
                idLinks = StrLink.Split(',');

                    foreach (string ln in idLinks)
                    {

                        try
                        {

                            if (int.TryParse(ln, out idSchmObj))
                            {


                                var ElectricObject = electricModel.GetParamsElectricObjectById((int)idSchmObj);
                                // row["TP"] = ElectricObject.ElectricSubName;
                                if (ElectricObject.ElectricSubName != null) str += ElectricObject.ElectricSubName;

                                if (ElectricObject.electricObject is SchemeModelN.ElectricLine)
                                {
                                    // row["TPCell"] = ElectricObject.electricLine.ToString();
                                    if (ElectricObject.electricLine != null) str += "/" + ElectricObject.electricLine.ToString();
                                }


                                //if (row["subid"] != DBNull.Value)
                                //{
                                //    var SubStation = electricModel.GetParamsElectricObjectById((int)row["subid"]);
                                //    row["TP"] = SubStation.ElectricSubName;
                                //}
                                // electricModel.GetParamsElectricObjectById(972609).electricObject is SchemeModelN.ElectricLine

                                //центр питания
                                //var listSchmObj = electricModel.GetCellCP((int)idSchmObj);
                                //if (listSchmObj != null)
                                //    if (listSchmObj.Length > 0)
                                //    {
                                //        if (listSchmObj[0].ElectricSubName != null)
                                //            //row["CPName"] = listSchmObj[0].ElectricSubName;
                                //            str += "/" + listSchmObj[0].ElectricSubName;
                                //        if (listSchmObj[0].electricLine != null)
                                //            //row["CellCPName"] = listSchmObj[0].electricLine.ToString();
                                //            str += "/" + listSchmObj[0].electricLine.ToString();
                                //    }

                            } //if (int.TryParse(ln, out idSchmObj))
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString() + ": " + idSchmObj.ToString(), "Ошибка", MessageBoxButtons.OK);
                        }

                        str += " ;" + "\n\n";

                    }
                    row["SchmLink"] = str;

                }//foreach (DataRow row in dsRep.vG_AbnObjQuantity_Flag.Rows)
        //    }
            //MessageBox.Show("Усе");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
