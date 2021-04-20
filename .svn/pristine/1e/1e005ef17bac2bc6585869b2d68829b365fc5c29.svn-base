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
using ControlsLbr;

namespace Legal.Forms.FormRep
{
    public partial class FormRepAbnObjMeter_Flag : FormLbr.FormBase
    {
        public FormRepAbnObjMeter_Flag()
        {
            InitializeComponent();
        }

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

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            dsRep.vG_AbnObjMeter_Flag.Clear();
            int items = clbFlags.CheckedItems.Count;
            int f = 1;
            string flags = "";

            foreach (object itemChecked in clbFlags.CheckedItems)
            {
                if ((int)(((ItemChecked)itemChecked).Id) == 1) f = 0;
                if ((int)(((ItemChecked)itemChecked).Id) > 1)
                {
                    if (items > 1) flags += ((ItemChecked)itemChecked).Id.ToString() + " , ";
                    if (items == 1) flags += ((ItemChecked)itemChecked).Id.ToString();
                    items--;
                }
            }

            if (flags == "") MessageBox.Show("Не выбран признак!");
            else
            {
                string where = " where idObj in (select idAbnObj from tAbnObjFlags where ";
                if (f == 1) where += " idFlag in ( " + flags + " ) and ";
                where += " Deleted = 0) ";
                string select = "SET LANGUAGE russian select * ";
                select += " from [vG_AbnObjMeter_Flag] obj ";
                where += "Order by CodeAbonent,objName";
                select += where;

                DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
                try
                {
                    sql.OpenConnection(this.SqlSettings);
                    dsRep.Tables["vG_AbnObjMeter_Flag"].Clear();
                    SqlCommand sqlCmd = new SqlCommand(select, sql.Connection);
                    sqlCmd.CommandTimeout = 600;
                    SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);
                    dAdapt.Fill(dsRep, "vG_AbnObjMeter_Flag");
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
            // теперь получаем данные по привязкам объектов
            ElectricModel electricModel = new ElectricModel();
            electricModel.SqlSettings = this.SqlSettings;
            electricModel.LoadSchema(true);

            int idSchmObj = 0;
            int idAbnObj = 0;
            string StrLink = null;
            string[] idLinks;

            string str = "";
            foreach (DataRow row in dsRep.vG_AbnObjMeter_Flag.Rows)
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
                            if (ElectricObject.ElectricSubName != null) str += ElectricObject.ElectricSubName;
                            if (ElectricObject.electricObject is SchemeModelN.ElectricLine)
                            {
                                if (ElectricObject.electricLine != null) str += "/" + ElectricObject.electricLine.ToString();
                            }
                        } 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString() + ": " + idSchmObj.ToString(), "Ошибка", MessageBoxButtons.OK);
                    }
                    str += " ;" + "\n\n";
                }
                row["SchmLink"] = str;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRepAbnObjMeter_Flag_Load(object sender, EventArgs e)
        {
            SelectSqlDataTableOther(dsRep, dsRep.tR_Classifier_GroupFlags, "tR_Classifier", true, "where ParentId = 927 and id != 1354 and IsGroup = 1 and Deleted = 0 ");
            LoadFlags();
            this.rwRep.RefreshReport();
        }

        private void cbGroupFlags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupFlags.SelectedValue != null) LoadFlags();
        }

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

        #region toolStripMain Events

        private void toolStripButtonExportExcel_Click_1(object sender, EventArgs e)
        {
            dgvefAbnFlags.ExportToExcel();
        }

        private void toolStripButtonRefresh_Click_1(object sender, EventArgs e)
        {
            dgvefAbnFlags.Refresh();
        }

        private void toolStripButtonPrint_Click_1(object sender, EventArgs e)
        {
            dgvefAbnFlags.PrintDataGridView();
        }

        private void toolStripButtonFind_Click_1(object sender, EventArgs e)
        {
            dgvefAbnFlags.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxFind.Text);
        }

        private void toolStripButtonFindPrev_Click_1(object sender, EventArgs e)
        {
            dgvefAbnFlags.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxFind.Text);
        }

        private void toolStripButtonFindNext_Click_1(object sender, EventArgs e)
        {
            dgvefAbnFlags.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }

        private void toolStripTextBoxFind_KeyDown_1(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvefAbnFlags.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }

        #endregion








    }
}
