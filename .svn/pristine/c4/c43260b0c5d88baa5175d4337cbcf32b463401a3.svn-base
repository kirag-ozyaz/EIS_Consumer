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
    public partial class FormNewPoint : FormLbr.FormBase
    {
        private int IDO;
        private int IDP;

        public FormNewPoint()
        {
            InitializeComponent();
        }

        public FormNewPoint(int idObj)
        {
            InitializeComponent();
            IDO = idObj;
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bIns_Click(object sender, EventArgs e)
        {
            DataRow dr = dsPoint.tPoint.NewRow();
            dr["idAbnObj"] = IDO;
            dr["Name"] = NUDN.Value.ToString();
            dr["DateBegin"] = dateTimePickerBeg.Value;
            dr["Location"] = rtbLocation.Text;
            dr["idPointClass"] = cmbPointClass.SelectedValue;

            dsPoint.tPoint.Rows.Add(dr);
            int id = this.InsertSqlDataOneRow(dsPoint, dsPoint.tPoint);
            if (id > 0)
            {
                IDP = id;
                MessageBox.Show("Создана новая точка учета.");
                Close();
            }
            else
            {
                MessageBox.Show("Не удалось создать точку учета.");
            }            
        }

        private void FormNewPoint_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsPoint, dsPoint.tR_Classifier, true, " where ParentKey = ';SKUEE;PointClass;' and IsGRoup = 0 order by id");

            cmbPointClass.DataSource = dsPoint.tR_Classifier;
            cmbPointClass.DisplayMember = "Name";
            cmbPointClass.ValueMember = "Id";
            cmbPointClass.SelectedIndex = 0;
        }
    }
}
