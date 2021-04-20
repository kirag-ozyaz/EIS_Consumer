using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contractor.Forms
{
    /// <summary>
    /// Форма добавления/редактирования контрагента
    /// </summary>
    public partial class FormAddEditContracor : FormLbr.FormBase
    {
        int id = -1;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Constants.AbnType TypeAbn
        {
            get 
            {
                return (radioButtonFL.Checked) ? Constants.AbnType.KontragentFL : Constants.AbnType.KontragentLegal;
            }
        }
        public string NameAbn
        {
            get { return txtName.Text; }
        }
        public FormAddEditContracor(int id = -1, Constants.AbnType type = Constants.AbnType.KontragentLegal, string nameKontragent = "NoName")
        {
            InitializeComponent();
            this.Id = id;
            if (type == Constants.AbnType.KontragentFL) radioButtonFL.Checked = true;
            txtName.Text = nameKontragent;
            this.Text = (id == -1) ? "Новый контрагент" : "Редактирование контрагента";
        }

        private void FormAddEditContracor_Load(object sender, EventArgs e)
        {
            if (id == -1)
            {
                DataRow newr = dsContr.tAbn.NewRow();
                newr["CodeAbonent"] = -1;
                newr["name"] = txtName.Text;
                newr["TypeAbn"] = (radioButtonFL.Checked) ? (int)Constants.AbnType.KontragentFL : (int)Constants.AbnType.KontragentLegal;
                newr["idWorker"] = 0;
                newr["deleted"] = 0;
                dsContr.tAbn.Rows.Add(newr);
            }
            else
            {
                this.SelectSqlData(dsContr, dsContr.tAbn, true, "where id = " + id.ToString());
                if (dsContr.tAbn.Rows.Count > 0)
                {
                    txtName.Text = dsContr.tAbn.Rows[0]["Name"].ToString();
                    int type = Convert.ToInt32(dsContr.tAbn.Rows[0]["TypeAbn"]);
                    if (type == (int)Constants.AbnType.KontragentFL || type == (int)Constants.AbnType.Private || type == (int)Constants.AbnType.PrivateNoDog)
                        radioButtonFL.Checked = true;

                    if (type != (int)Constants.AbnType.KontragentFL && type != (int)Constants.AbnType.KontragentLegal)
                        groupBox1.Enabled = false;
                }
            }
        }

        private void FormAddEditContracor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Не введено имя контрагента");
                    e.Cancel = true;
                    return;
                }

                if (dsContr.tAbn.Rows.Count > 0)
                {
                    if (groupBox1.Enabled)
                        dsContr.tAbn.Rows[0]["typeAbn"] = (radioButtonFL.Checked) ? (int)Constants.AbnType.KontragentFL : (int)Constants.AbnType.KontragentLegal;
                    dsContr.tAbn.Rows[0]["name"] = txtName.Text;
                    dsContr.tAbn.Rows[0].EndEdit();

                    if (id == -1)
                        id = InsertSqlDataOneRow(dsContr, dsContr.tAbn);
                    else
                        UpdateSqlData(dsContr, dsContr.tAbn);
                }
            }
        }
    }
}
