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
    public partial class FormAddEditCont : FormLbr.FormBase
    {
        private int ID = -1;
        private bool isInsert = false;  // false - update]
        private int idType = -1;

        public FormAddEditCont()
        {
            InitializeComponent();
        }

        public FormAddEditCont(int id, bool insert)
        {
            InitializeComponent();


            ID = id;
            isInsert = insert;
            this.Text = (isInsert) ? "Добавление контрагента" : "Редактирование контрагента";
            if (isInsert)
                txtCode.Enabled = true;
            else
                txtCode.Enabled = false;
        }

        private void FormAddEditCont_Load(object sender, EventArgs e)
        {

           this.SelectSqlData(dsCont, dsCont.tR_Classifier, true, " where ParentId = 205 AND Deleted = 0 "); 

            if (isInsert) // добавление
            {
                tabControlAbn.Visible = false;

                DataRow r = dsCont.tAbn.NewRow();
                r["CodeAbonent"] = 0;
                r["Name"] = "NoName";
                r["TypeAbn"] = 0;
                r["idWorker"] = 0;
                r["Deleted"] = false;
                dsCont.tAbn.Rows.Add(r);
            }
            else //редактирование
            {
           
                this.SelectSqlData(dsCont, dsCont.tAbn, true, " where id = " + ID.ToString());

                idType = Convert.ToInt32(dsCont.tAbn.Rows[0]["TypeAbn"]) ;

                if (idType == Convert.ToInt32(Constants.AbnType.Private))
                {
                    tabControlAbn.Visible = false;
                }
                else
                {
                    LoadAbonentLegal();
                }

            }
        }


        private void LoadAbonentLegal()
        {

            // реквизиты
            this.SelectSqlData(dsCont.vG_AbnInfo, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
            // руководитель
            this.SelectSqlData(dsCont.tG_AbnChief, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
            //адреса
            this.SelectSqlData(dsCont.vG_AbnAddressL, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
            this.SelectSqlData(dsCont.vG_AbnAddressP, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
            //контакты
            this.SelectSqlData(dsCont.tAbnContact, true, " where idAbn = " + ID.ToString() + " order by DateChange desc");

        }

        private bool InsertIntotAbnStatus(int abnid)
        {
            DataRow dr = dsCont.tAbnStatus.NewRow();
            dr["idAbn"] = abnid;
            dr["isactive"] = true;
            dr["DateChange"] = System.DateTime.Now.Date;
            dsCont.tAbnStatus.Rows.Add(dr);
            dsCont.tAbnStatus.Rows[0].EndEdit();
            return this.InsertSqlData(dsCont, dsCont.tAbnStatus);
        }

        private Boolean CheckAbnCode()
        {
            if (txtCode.Text.Length > 0)
            {
                dsCont.tAbn1.Clear();
                this.SelectSqlDataTableOther(dsCont, dsCont.tAbn1, "tAbn", true, " where  CodeAbonent = " + txtCode.Text.ToString());
                if ((int)dsCont.tAbn1.Count > 0)
                {
                    MessageBox.Show("Такой код потребителя уже существует...", "Selection error!");
                    FindCode();
                    return false;
                }
                else
                    return true;
            }
            else
                return false;
        }

        private void FindCode()
        {
            DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
            try
            {
                sql.OpenConnection(this.SqlSettings);
                System.Data.SqlClient.SqlCommand sqlcom2 = new System.Data.SqlClient.SqlCommand("select [dbo].[fn_GetFreeCodeAbonent](" +  txtCode.Text + " ) ", sql.Connection);
                txtCode.Text = sqlcom2.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                sql.CloseConnection();
            }
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (buttonOK.Visible == false)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.Close();
            }
        }

        private void btnFindCode_Click(object sender, EventArgs e)
        {
            FindCode();
            txtCode.Focus();
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            CheckAbnCode();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            if (isInsert)
            {
                if (Convert.ToInt32(comboBoxType.SelectedValue) < 1)
                {
                    MessageBox.Show("Введите тип контрагента.");
                    return;
                }

                if (CheckAbnCode())
                {
                    dsCont.tAbn.Rows[0].EndEdit();
                    ID = this.InsertSqlDataOneRow(dsCont, dsCont.tAbn);
                    if (ID < 0)
                        isOk = false;
                    else
                        isOk = InsertIntotAbnStatus(ID);
                }
            }
            else
            {
                dsCont.tAbn.Rows[0].EndEdit();
                isOk = this.UpdateSqlData(dsCont, dsCont.tAbn);
            }
            if (isOk)
            {
                if (Convert.ToInt32(comboBoxType.SelectedValue) == Convert.ToInt32(Constants.AbnType.Private))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    tabControlAbn.Visible = true;
                    gbCont.Enabled = false;
                    buttonOK.Visible = false;
                
                }

            }
        }


        #region Реквизиты
        //История реквизитов

        private void tsbInfoHistory_Click(object sender, EventArgs e)
        {
            Legal.Forms.FormAbnDetailsHistory fAdd = new Legal.Forms.FormAbnDetailsHistory(ID);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
            }
        }



        //Новые реквизиты

        private void tsbAddAbnInfo_Click(object sender, EventArgs e)
        {
            Legal.Forms.FormAbnDetails fAdd = new Legal.Forms.FormAbnDetails(ID, true);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsCont.vG_AbnInfo, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
            }
        }


        //редактирование текущих реквизитов абонента
        private void tsbEditInfo_Click(object sender, EventArgs e)
        {
            Legal.Forms.FormAbnDetails fAdd = new Legal.Forms.FormAbnDetails(ID, false);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsCont.vG_AbnInfo, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
            }
        }


        #endregion


        #region Руководитель
        //История руководителя

        private void tsbDirectorHistory_Click(object sender, EventArgs e)
        {
            Legal.Forms.FormAbnChiefHistory fAdd = new Legal.Forms.FormAbnChiefHistory(ID);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsCont.tG_AbnChief, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
            }
        }

        //Новый руководитель
        private void tsbDirectorAdd_Click(object sender, EventArgs e)
        {
            Legal.Forms.FormAbnChief fAdd = new Legal.Forms.FormAbnChief(ID, true);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsCont.tG_AbnChief, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
            }
        }


        //Редактирование руководителя

        private void tsbDirectorEdit_Click(object sender, EventArgs e)
        {
            Legal.Forms.FormAbnChief fAdd = new Legal.Forms.FormAbnChief(ID, false);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsCont.tG_AbnChief, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
            }
        }


        #endregion


        #region Адреса
        private void tsbAddressHistory_Click(object sender, EventArgs e)
        {
            Legal.Forms.FormAbnAddressHistory frm = new Legal.Forms.FormAbnAddressHistory(ID);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsCont.vG_AbnAddressL, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
                this.SelectSqlData(dsCont.vG_AbnAddressP, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
            }
        }

        #endregion

        #region Работа с контактами
        private void toolStripButtonNewContact_Click(object sender, EventArgs e)
        {
            Legal.Forms.FormAbnContactAdd fAdd = new Legal.Forms.FormAbnContactAdd(ID, true);

            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsCont, dsCont.tAbnContact, true, " where idAbn = " + ID.ToString() + " order by DateChange desc");
            }
        }

        private void toolStripButtonEditContac_Click(object sender, EventArgs e)
        {
            Legal.Forms.FormAbnContactAdd fAdd = new Legal.Forms.FormAbnContactAdd(Convert.ToInt32(dGVAbnContact.CurrentRow.Cells["idDGVTBC"].Value), false);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsCont, dsCont.tAbnContact, true, " where idAbn = " + ID.ToString() + " order by DateChange desc");
            }
        }

        private void toolStripButtonDelContact_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите удалить контакт?", "Удаление",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteSqlDataById(dsCont.tAbnContact, Convert.ToInt32(dGVAbnContact.CurrentRow.Cells["idDGVTBC"].Value));
                this.SelectSqlData(dsCont, dsCont.tAbnContact, true, " where idAbn = " + ID.ToString() + " order by DateChange desc");
            }
        }

        #endregion







    }
}
