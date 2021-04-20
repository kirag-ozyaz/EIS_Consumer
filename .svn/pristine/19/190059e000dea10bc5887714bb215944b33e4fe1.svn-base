using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SchemeModelN;
using System.Threading;

namespace Legal.Forms.GraphicsInspector
{
    public partial class FormGraphicPointOrder_Plomb_Schm: FormLbr.FormBase
    {
        private static ElectricModel electricModel = new ElectricModel();

        #region toolStripOrderMain Events
        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvOrder.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxOrderFind.Text);
        }
        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvOrder.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxOrderFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvOrder.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxOrderFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvOrder.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxOrderFind.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvOrder.PrintDataGridView();
        }
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvOrder.CopyToExcel(true);
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {

            dgvOrder.Refresh();

        }
        #endregion

        private void LoadSchm()
        {
            FormAbn.electricModel.SqlSettings = this.SqlSettings;
            FormAbn.electricModel.LoadSchema(true);

        }

        public FormGraphicPointOrder_Plomb_Schm()
        {
            InitializeComponent();
        }

        private void FormGraphicPointOrder_Plomb_Schm_Load(object sender, EventArgs e)
        {

            panelWait.Visible = false;


            //Cursor.Current = Cursors.WaitCursor;
            //this.SelectSqlData(dsGraphic, dsGraphic.Tables["vG_GraphicPointOrder_new"], true, "order by CodeAbonent");

            //this.SelectSqlData(dsGraphic, dsGraphic.Tables["vWorkerGroup"], true, " where idGRoup = " + Constants.Constants.WorkerGroupMasterUL.ToString() + " and dateEnd is null order by FIO");

            //Cursor.Current = Cursors.Default;
            //this.reportViewerOrder.RefreshReport();
        }

        private void tsbCheckFilter_Click(object sender, EventArgs e)
        {
            bsOrder.Filter    = "check = true";
        }

        private void tsbUncheck_Click(object sender, EventArgs e)
        {
            bsOrder.Filter = null; //.Replace( "check = true","");
        }

        private void dgvOrder_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentCell is DataGridViewCheckBoxCell)
            {
                //dgvOrder.EndEdit();
                dgvOrder.CommitEdit(DataGridViewDataErrorContexts.Commit);

            }
        }

        private void dgvOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgvOrder.CurrentCell = null;
        }

        private void reportViewerOrder_ReportRefresh(object sender, CancelEventArgs e)
        {
            ReportParameter d1 = new ReportParameter("Number", tbOrderN.Text);
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d1 });

            ReportParameter d2 = new ReportParameter("Whom", cbWhom.Text);
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d2 });

            ReportParameter d3 = new ReportParameter("Who", cbWho.Text);
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d3 });
        }

        private void FormGraphicPointOrder_Shown(object sender, EventArgs e)
        {

            panelWait.Visible = true;

            //Thread t = new Thread(new ThreadStart(LoadSchm));
            //t.Start();
            //LoadSchm();

            panelWait.Refresh();
            Cursor.Current = Cursors.WaitCursor;

            this.SelectSqlData(dsGraphic, dsGraphic.Tables["vG_GraphicPointOrder_Plomb_Schm"], true, "order by CodeAbonent");

            this.SelectSqlData(dsGraphic, dsGraphic.Tables["vWorkerGroup"], true, " where idGRoup = " + Constants.Constants.WorkerGroupMasterUL.ToString() + " and dateEnd is null order by FIO");

            labelCreate.Text = "Идет форимрование привязок.";

            panelWait.Refresh();

            UpdateSchmLink();

            panelWait.Visible = false;
            Cursor.Current = Cursors.Default;
            this.reportViewerOrder.RefreshReport();
        }

        private void UpdateSchmLink()
        {
            // MessageBox.Show(dsRep.vG_AbnObjQuantity_Flag.Rows.Count.ToString());
            // теперь получаем данные по привязкам объектов

            electricModel = new ElectricModel();
            electricModel.SqlSettings = this.SqlSettings;
            electricModel.LoadSchema(true); 

            int idSchmObj = 0;
            int idAbnObj = 0;
            string StrLink = null;
            string[] idLinks;

            string str = "";

            // int i = 1;
            //   int rows = dsRep.vG_AbnObjQuantity_Flag.Rows.Count;

            foreach (DataRow row in dsGraphic.vG_GraphicPointOrder_Plomb_Schm.Rows)
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


                                //центр питания
                            
                                var listSchmObj = electricModel.GetCellCP((int)idSchmObj);
                                if (listSchmObj != null)
                                    if (listSchmObj.Length > 0)
                                    {
                                        if (listSchmObj[0].ElectricLineName != null)
                                            str += listSchmObj[0].ElectricLineName;
                                        // если нужен id центра питания 
                                        // listSchmObj[0].electricLine.Id                                
                                    }
                         

                            /*
                            var ElectricObject = electricModel.GetParamsElectricObjectById((int)idSchmObj);
                            // row["TP"] = ElectricObject.ElectricSubName;
                            if (ElectricObject.ElectricSubName != null) str += ElectricObject.ElectricSubName;

                            if (ElectricObject.electricObject is SchemeModelN.ElectricLine)
                            {
                                // row["TPCell"] = ElectricObject.electricLine.ToString();
                                if (ElectricObject.electricLine != null) str += "/" + ElectricObject.electricLine.ToString();
                            }
                            */

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

                    str += " ; "; // +"\n\n";

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

        private void tsbSchmLinks_Click(object sender, EventArgs e)
        {
            UpdateSchmLink();
        }


    }
}
