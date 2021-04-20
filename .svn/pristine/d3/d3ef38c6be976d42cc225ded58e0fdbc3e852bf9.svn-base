using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Legal.Forms.GraphicsInspector
{
    public partial class FormGraphicPointOrder : FormLbr.FormBase
    {

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

        public FormGraphicPointOrder()
        {
            InitializeComponent();
        }

        private void FormGraphicPointOrder_Load(object sender, EventArgs e)
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

            panelWait.Refresh();
            Cursor.Current = Cursors.WaitCursor;

            this.SelectSqlData(dsGraphic, dsGraphic.Tables["vG_GraphicPointOrder_new"], true, "order by CodeAbonent");

            this.SelectSqlData(dsGraphic, dsGraphic.Tables["vWorkerGroup"], true, " where idGRoup = " + Constants.Constants.WorkerGroupMasterUL.ToString() + " and dateEnd is null order by FIO");

            panelWait.Visible = false;
            Cursor.Current = Cursors.Default;
            this.reportViewerOrder.RefreshReport();
        }




    }
}
