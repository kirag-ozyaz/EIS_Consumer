using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prv.Forms.Reports
{
    public partial class FormActAddEdit : FormLbr.FormBase
    {
        private int ID = -1;

        public FormActAddEdit()
        {
            InitializeComponent();
        }

        public FormActAddEdit(int id)
        {
            InitializeComponent();
            ID = id;
        }


        private void FormActAddEdit_Load(object sender, EventArgs e)
        {
            if (ID > -1)
            {
                LoadAct();

            }
            else
            {
            }
        }

        private void LoadAct()
        {
            this.SelectSqlData(dataSetRep1, dataSetRep1.tPrv_JournalAct, true, " where id = " + ID + " and Deleted = 0");
      
            this.SelectSqlDataTableOther(dataSetRep1, dataSetRep1.tPrv_RepAct2, "tPrv_RepAct",true, " where idJournal = " + ID + " order by id");

            CheckTXT();

            txtNumber.Text = dataSetRep1.tPrv_JournalAct.Rows[0]["NumberAct"].ToString();
            dtActDate.Value = Convert.ToDateTime(dataSetRep1.tPrv_JournalAct.Rows[0]["DateAct"]);
            if (dataSetRep1.tPrv_JournalAct.Rows[0]["DateCheck"] != DBNull.Value) {dtpContCeck.Value = Convert.ToDateTime(dataSetRep1.tPrv_JournalAct.Rows[0]["DateCheck"]);}
            if (dataSetRep1.tPrv_JournalAct.Rows[0]["FIOcontr"] != DBNull.Value) { textBoxContCheck.Text = dataSetRep1.tPrv_JournalAct.Rows[0]["FIOcontr"].ToString(); }

            cbCheck.Checked = true;
        }

        private void CheckTXT()
        {
            int z ;

            for (int i = 0; i < dgvActs.RowCount; i++)
            {
                if (dgvActs.Rows[i].Cells["checked"].Value != DBNull.Value) z = Convert.ToInt16(dgvActs.Rows[i].Cells["checked"].Value); else z = 0;

               if (z == 1)
                {
                    dgvActs.Rows[i].Cells["CheckedTXT"].Value = "Да";
                }
                else
                {
                    dgvActs.Rows[i].Cells["CheckedTXT"].Value = "Нет";
                }
            }
        }

        private void bDateAct_Click(object sender, EventArgs e)
        {
            FormActDate f = new FormActDate(ID);
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadAct();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cbCheck_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbCheck.CheckState)
            {
                case CheckState.Checked:

                    for (int i = 0; i < dgvActs.RowCount; i++)
                    {
                        dgvActs.Rows[i].Cells["check"].Value = true;
                    }

                    break;
                default:
                    for (int i = 0; i < dgvActs.RowCount; i++)
                    {
                        dgvActs.Rows[i].Cells["check"].Value = false;
                    }
                    break;
            }
        }

        private void buttonChecked_Click(object sender, EventArgs e)
        {
            bool ch = false;
            for (int i = 0; i < dgvActs.RowCount; i++)
            {
                ch = (bool)dgvActs.Rows[i].Cells["check"].Value; 

                if (dgvActs.Rows[i].Cells["check"].Value != DBNull.Value && dgvActs.Rows[i].Cells["check"].Value != null) //
                {
                    this.SelectSqlData(dataSetRep1, dataSetRep1.tPrv_RepAct, true, " where id = " + dgvActs.Rows[i].Cells["idDGVTBC"].Value.ToString() + " order by id");
                    dataSetRep1.tPrv_RepAct.Rows[0].BeginEdit();
                    if (ch) //MessageBox.Show("!!!"); else MessageBox.Show("000");
                    { dataSetRep1.tPrv_RepAct.Rows[0]["Checked"] = 1; }
                    else { dataSetRep1.tPrv_RepAct.Rows[0]["Checked"] = 0; }
                    dataSetRep1.tPrv_RepAct.Rows[0].EndEdit();
                    UpdateSqlData(dataSetRep1, dataSetRep1.tPrv_RepAct);

                                 }

            }
            MessageBox.Show("Данные внесены...");
            LoadAct();
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            FormActScan f = new FormActScan(ID);
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadAct();
            }
        }
    }
}
