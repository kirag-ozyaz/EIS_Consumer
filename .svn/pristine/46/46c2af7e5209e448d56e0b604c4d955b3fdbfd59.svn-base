using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prv.Forms.Reports
{
    public partial class FormActDate : FormLbr.FormBase
    {
        private int ID = -1;
        private DialogResult result;

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

        public FormActDate()
        {
            InitializeComponent();
        }

        public FormActDate(int id)
        {
            InitializeComponent();
            ID = id;

            
        }


        private void FormActDate_Load(object sender, EventArgs e)
        {
            LoadControllers();
        }

        private void LoadControllers()
        {
            this.SelectSqlData(dataSetPrv, dataSetPrv.vWorkerGroup, true, " where idGroup = " + Constants.Constants.WorkerGroupControlerBS.ToString() + " and DateEnd is null order by FIO"); //
            foreach (DataRow dr in dataSetPrv.vWorkerGroup.Rows)
            {
                ItemChecked item = new ItemChecked(dr["FIO"].ToString(), Convert.ToInt32(dr["Id"]));
                checkedListBoxControllers.Items.Add(item, false);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIns_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("Вы действительно хотите внести дату?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string Controllers = "";
                string idControllers = "";
                foreach (ItemChecked item in checkedListBoxControllers.CheckedItems)
                {
                    Controllers += item.Name + ";";
                    idControllers += item.Id + ";";
                }
               // MessageBox.Show(Controllers + "   ID: " + idControllers);

                SelectSqlData(dataSetRep, dataSetRep.tPrv_JournalAct, true, "where id = " + ID.ToString());
                dataSetRep.tPrv_JournalAct.Rows[0].BeginEdit();
                dataSetRep.tPrv_JournalAct.Rows[0]["DateCheck"] = dtpDateCheck.Value;
                dataSetRep.tPrv_JournalAct.Rows[0]["FIOcontr"] = Controllers;
                dataSetRep.tPrv_JournalAct.Rows[0]["IDcontr"] = idControllers;
                dataSetRep.tPrv_JournalAct.Rows[0].EndEdit();
                UpdateSqlData(dataSetRep, dataSetRep.tPrv_JournalAct);
                //MessageBox.Show("Данные внесены ..");
                DialogResult = DialogResult.OK;
                 
            }
        }
    }
}
