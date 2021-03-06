using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Meter
{
    public partial class FormASOCAMeters : FormLbr.FormBase
    {

        private int idP = 0;

        #region toolStripMain Events
 
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvAsocaMeters.CopyToExcel(true);
        }
        // Обновить
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            dgvAsocaMeters.Refresh();
        }


        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dGVEFMeters.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxFind.Text);
        }
        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dGVEFMeters.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dGVEFMeters.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dGVEFMeters.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        #endregion

     

        public FormASOCAMeters()
        {
            InitializeComponent();
        }

        public FormASOCAMeters(int point)
        {
            InitializeComponent();
            this.idP = point;
        }


        private void FormASOCAMeters_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbn, dsAbn.tASOCA_Meter, true, " order by id  ");
            if (idP > 0)
            {
                this.SelectSqlData(dsAbn, dsAbn.vAbnObjMeter_All, true, "where idPoint = "+ idP.ToString() +" order by NDog  ");
            } else
            {
                this.SelectSqlData(dsAbn, dsAbn.vAbnObjMeter_All, true, " order by NDog  ");
            };
            tscbTypeAbn.SelectedIndex = 0;
        }

        private void tscbTypeAbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tscbTypeAbn.Text)
            {
                case "Гос.сектор":
                    bsMeters.Filter =" TypeAbn <> 206 ";
                break;
                case "Быт.сектор":
                bsMeters.Filter = " TypeAbn = 206 ";
                break;
                default:
                bsMeters.RemoveFilter();
                break;


            }
        }

        private void dgvObjDoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (dgvAsocaMeters.Rows[e.RowIndex].Cells["idPoint"].Value.ToString() == "0")
                    e.CellStyle.ForeColor = Color.Red;
        }

        private void tsbSearchMeter_Click(object sender, EventArgs e)
        {
            dGVEFMeters.SearchGrid("numberMeter", dgvAsocaMeters.CurrentRow.Cells["serial"].Value.ToString());
        }

        private void tSBUpdate_Click(object sender, EventArgs e)
        {
            var row = dsAbn.tASOCA_Meter.AsEnumerable().Select((r, i) => new { Row = r, Index = i }).Where(x => (int)x.Row["id"] == Convert.ToInt32(dgvAsocaMeters.CurrentRow.Cells["idColumn"].Value)).FirstOrDefault();
            int rowNumber = 0;
            if (row != null)
                rowNumber = row.Index;
           // MessageBox.Show(rowNumber.ToString());

            dsAbn.tASOCA_Meter.Rows[rowNumber].SetField("idPoint", Convert.ToInt32(dGVEFMeters.CurrentRow.Cells["idPointM"].Value));
            dsAbn.tASOCA_Meter.Rows[rowNumber].SetField("idPointReg", Convert.ToInt32(dGVEFMeters.CurrentRow.Cells["idPointRegM"].Value));
            dsAbn.tASOCA_Meter.Rows[rowNumber].EndEdit();
            bool isOk = this.UpdateSqlData(dsAbn, dsAbn.tASOCA_Meter);
            if (isOk)  this.DialogResult = DialogResult.OK;
        }

        private void tSCBAsocaMetersFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tSCBAsocaMetersFilter.Text) 
            {
                case "Откреплены": 
                    bsAsocsMeters.Filter = " idPoint = 0 ";
                    break;
                case "Прикреплены":
                    bsAsocsMeters.Filter = " idPoint <> 0 ";
                    break;
                default:
                    bsAsocsMeters.RemoveFilter();
                    break;


            }
        }

        private void tSBSearchNAsocaMeter_Click(object sender, EventArgs e)
        {
            dgvAsocaMeters.SearchGrid("serial", dGVEFMeters.CurrentRow.Cells["numberMeter"].Value.ToString());
        }

        private void tsbUnFix_Click(object sender, EventArgs e)
        {
                       DialogResult dialogResult = MessageBox.Show("Удалить привязку?", "Удаление", MessageBoxButtons.YesNo);
                       if (dialogResult == DialogResult.Yes)
                       {

                               var row = dsAbn.tASOCA_Meter.AsEnumerable().Select((r, i) => new { Row = r, Index = i }).Where(x => (int)x.Row["id"] == Convert.ToInt32(dgvAsocaMeters.CurrentRow.Cells["idColumn"].Value)).FirstOrDefault();
                               int rowNumber = 0;
                               if (row != null)
                                   rowNumber = row.Index;
                               // MessageBox.Show(rowNumber.ToString());

                               dsAbn.tASOCA_Meter.Rows[rowNumber].SetField("idPoint", 0);
                               dsAbn.tASOCA_Meter.Rows[rowNumber].SetField("idPointReg", 0);
                               dsAbn.tASOCA_Meter.Rows[rowNumber].EndEdit();
                               bool isOk = this.UpdateSqlData(dsAbn, dsAbn.tASOCA_Meter);
                               if (isOk) this.DialogResult = DialogResult.OK;
                           
                       }
        }


    }
}
