using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Constants;

namespace Contractor.Forms
{
    public partial class FormContactor : FormLbr.FormBase
    {
        private int ID;
        private int TA;
        //private int AbnFilter = 0;

        private TabPage[] tabs=null;

        //позиционирование в гриде
        private int GetRowIndexByKey(DataGridView dgv, string columnName, int key)
        {
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                if (Convert.ToInt32(dr.Cells[columnName].Value) == key)
                    return dr.Index;
            }
            return 0;
        }


        public FormContactor()
        {
            InitializeComponent();
        }

        private void FormContactor_Load(object sender, EventArgs e)
        {

            LoadTypeTree();

            tabs = new TabPage[tabControlContr.TabPages.Count];
            for (int i = 0; i < tabControlContr.TabPages.Count; i++)
                tabs[i] = tabControlContr.TabPages[i];
            tabControlContr.TabPages.Clear();
        //    this.SelectSqlData(dsCont, dsCont.vAbn, true, " where  Deleted=0 order by CodeAbonent  "); 
        }

        private void FormContactor_Shown(object sender, EventArgs e)
        {
            LoadCont();
        }

        private void LoadCont()
        {
            panelWait.Visible = true;

            panelWait.Refresh();
            Cursor.Current = Cursors.WaitCursor;

            this.SelectSqlData(dsCont, dsCont.vAbn, true, " where  Deleted=0 order by CodeAbonent  ");

            Cursor.Current = Cursors.Default;

            panelWait.Visible = false;
        }

        private void LoadAbonent()
        {
            if (dgvCont.CurrentRow == null) return;
            ID = Convert.ToInt32(dgvCont.CurrentRow.Cells["AbnidDGVTBC"].Value);
            TA = Convert.ToInt32(dgvCont.CurrentRow.Cells["typeAbn"].Value);

            this.SelectSqlData(dsCont, dsCont.vContObj, true, " where  idAbn = " + ID.ToString());//TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and //+ "  and (idAbnDog = " + ID.ToString() + " OR idAbnDog IS NULL) order by NumberObj, NumberSubObj");

            int typeAbn = Convert.ToInt32(dgvCont.CurrentRow.Cells["typeAbn"].Value);

            if (typeAbn != Convert.ToInt32(Constants.AbnType.Private))
            {
                tabControlContr.TabPages.Clear();
                tabControlContr.TabPages.Add(tabs[0]);

                LoadAbonentLegal();
                dgvCont.Focus();

            }
            else
            {
                tabControlContr.TabPages.Clear();
                tabControlContr.TabPages.Add(tabs[1]);

                dgvCont.Focus();
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

        private void dgvCont_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToInt32(dgvCont.Rows[e.RowIndex].Cells["typeAbn"].Value) == 206)
                    e.CellStyle.ForeColor = Color.Blue;
                if (Convert.ToInt32(dgvCont.Rows[e.RowIndex].Cells["typeAbn"].Value) == 207)
                    e.CellStyle.ForeColor = Color.Green;

                if (Convert.ToInt32(dgvCont.Rows[e.RowIndex].Cells["typeAbn"].Value) == 231)
                    e.CellStyle.ForeColor = Color.Red;
                if (Convert.ToInt32(dgvCont.Rows[e.RowIndex].Cells["typeAbn"].Value) == 230)
                    e.CellStyle.ForeColor = Color.Purple;

            }
        }


        private void dgvCont_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
            {

                dgvObj.Focus();
            }
        }

        #region Добавление абонента
        private void AddCont_Click(object sender, EventArgs e)
        {
            FormAddEditCont fAdd = new FormAddEditCont(-1, true);
            fAdd.SqlSettings = this.SqlSettings;

            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                LoadCont();
            }
        }
        #endregion

        #region Редактирование абонента
        private void EditAbn()
        {
            int id = Convert.ToInt32(dgvCont.CurrentRow.Cells["AbnidDGVTBC"].Value);
            FormAddEditCont fAdd = new FormAddEditCont(id, false);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsCont, dsCont.vAbn, true, " where Deleted=0 order by CodeAbonent  ");
                //dgvCont.Refresh();
                dgvCont.CurrentCell = dgvCont["codeAbonentDGVTBC", GetRowIndexByKey(dgvCont, "AbnidDGVTBC", id)];
                LoadAbonent();
            }
        }
       #endregion

        private void dgvCont_SelectionChanged(object sender, EventArgs e)
        {
            LoadAbonent();
        }

        private void EditCont_Click(object sender, EventArgs e)
        {
            EditAbn();
        }

        private void DelCont_Click(object sender, EventArgs e)
        {
            DelAbn();
        }

        #region Удаление абонента
        private void DelAbn()
        {
            if (MessageBox.Show("Вы действительно хотите удалить текущего контрагента?", "Удаление",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int id = Convert.ToInt32(dgvCont.CurrentRow.Cells["AbnidDGVTBC"].Value);
                int CA = Convert.ToInt32(dgvCont.CurrentRow.Cells["codeAbonentDGVTBC"].Value);


                if (dsCont.vAbn.Rows.Count > 0)
                {

                    DataSets.DataSetCont ds = new Contractor.DataSets.DataSetCont();
                    this.SelectSqlData(ds, ds.tAbn, true, "where id = " + id);
                    ds.tAbn.Rows[0]["Deleted"] = !Convert.ToBoolean(ds.tAbn.Rows[0]["Deleted"]);
                    ds.tAbn.Rows[0].EndEdit();
                    if (this.UpdateSqlData(ds, ds.tAbn))
                    {
                        if (Convert.ToBoolean(ds.tAbn.Rows[0]["Deleted"]))
                        {
                            MessageBox.Show("Абонент успешно удален");
                          
                        }
                        else
                        {
                            MessageBox.Show("Абонент успешно восстановлен");
                        }
                    }
                }

                dsCont.tAbn.Clear();
                this.SelectSqlData(dsCont.tAbn, true, "where deleted=0 and CodeAbonent >= " + CA + " order by CodeAbonent ", null, false, 1);
                CA = (int)dsCont.tAbn.Rows[0]["CodeAbonent"];
                if (CA > 0)
                {
                    LoadCont();

                    dgvCont.CurrentCell = dgvCont["codeAbonentDGVTBC", GetRowIndexByKey(dgvCont, "codeAbonentDGVTBC", CA)];
                }
                LoadAbonent();
            }
        }

        #endregion

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
        //#region Реквизиты
        ////История реквизитов
        //private void buttonAbnInfHistory_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(dgvCont.CurrentRow.Cells["AbnidDGVTBC"].Value);
        //    Legal.Forms.FormAbnDetailsHistory fAdd = new Legal.Forms.FormAbnDetailsHistory(id);
        //    fAdd.SqlSettings = this.SqlSettings;
        //    if (fAdd.ShowDialog() == DialogResult.OK)
        //    {
        
        //    }
        //}

        ////Новые реквизиты
        //private void buttonAbnInfNew_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(dgvCont.CurrentRow.Cells["AbnidDGVTBC"].Value);
        //    Legal.Forms.FormAbnDetails fAdd = new Legal.Forms.FormAbnDetails(id, true);
        //    fAdd.SqlSettings = this.SqlSettings;
        //    if (fAdd.ShowDialog() == DialogResult.OK)
        //    {
        //        this.SelectSqlData(dsCont, dsCont.vG_AbnInfo, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", 1);
        //    }
        //}
        ////редактирование текущих реквизитов абонента
        //private void buttonAbnInfoEdit_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(dgvCont.CurrentRow.Cells["AbnidDGVTBC"].Value);
        //    Legal.Forms.FormAbnDetails fAdd = new Legal.Forms.FormAbnDetails(id, false);
        //    fAdd.SqlSettings = this.SqlSettings;
        //    if (fAdd.ShowDialog() == DialogResult.OK)
        //    {
        //        this.SelectSqlData(dsCont, dsCont.vG_AbnInfo, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", 1);
        //    }
        //}
        //#endregion


        //#region Руководитель
        ////История руководителя
        //private void buttonDirectorHistory_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(dgvCont.CurrentRow.Cells["AbnidDGVTBC"].Value);
        //    Legal.Forms.FormAbnChiefHistory fAdd = new Legal.Forms.FormAbnChiefHistory(id);
        //    fAdd.SqlSettings = this.SqlSettings;
        //    if (fAdd.ShowDialog() == DialogResult.OK)
        //    {
        //        this.SelectSqlData(dsCont, dsCont.tG_AbnChief, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", 1);
        //    }
        //}
        ////Новый руководитель
        //private void buttonDirectorNew_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(dgvCont.CurrentRow.Cells["AbnidDGVTBC"].Value);
        //    Legal.Forms.FormAbnChief fAdd = new Legal.Forms.FormAbnChief(id, true);
        //    fAdd.SqlSettings = this.SqlSettings;
        //    if (fAdd.ShowDialog() == DialogResult.OK)
        //    {
        //        this.SelectSqlData(dsCont, dsCont.tG_AbnChief, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", 1);
        //    }
        //}
        ////Редактирование руководителя
        //private void buttonDirectorEdit_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(dgvCont.CurrentRow.Cells["AbnidDGVTBC"].Value);
        //    Legal.Forms.FormAbnChief fAdd = new Legal.Forms.FormAbnChief(id, false);
        //    fAdd.SqlSettings = this.SqlSettings;
        //    if (fAdd.ShowDialog() == DialogResult.OK)
        //    {
        //        this.SelectSqlData(dsCont, dsCont.tG_AbnChief, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", 1);
        //    }
        //}
        //#endregion


        //#region Адреса
        //private void buttonAddressHistory_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(dgvCont.CurrentRow.Cells["AbnidDGVTBC"].Value);
        //    Legal.Forms.FormAbnAddressHistory frm = new Legal.Forms.FormAbnAddressHistory(id);
        //    frm.SqlSettings = this.SqlSettings;
        //    if (frm.ShowDialog() == DialogResult.OK)
        //    {
        //        this.SelectSqlData(dsCont, dsCont.vG_AbnAddressL, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", 1);
        //        this.SelectSqlData(dsCont, dsCont.vG_AbnAddressP, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", 1);
        //    }
        //}
        //#endregion

        //#region Работа с контактами
        //private void toolStripButtonNewContact_Click(object sender, EventArgs e)
        //{
        //    Legal.Forms.FormAbnContactAdd fAdd = new Legal.Forms.FormAbnContactAdd(Convert.ToInt32(dgvCont.CurrentRow.Cells["AbnidDGVTBC"].Value), true);

        //    fAdd.SqlSettings = this.SqlSettings;
        //    if (fAdd.ShowDialog() == DialogResult.OK)
        //    {
        //        this.SelectSqlData(dsCont, dsCont.tAbnContact, true, " where idAbn = " + ID.ToString() + " order by DateChange desc");
        //    }
        //}

        //private void toolStripButtonEditContac_Click(object sender, EventArgs e)
        //{
        //    Legal.Forms.FormAbnContactAdd fAdd = new Legal.Forms.FormAbnContactAdd(Convert.ToInt32(dGVAbnContact.CurrentRow.Cells["idDGVTBC"].Value), false);
        //    fAdd.SqlSettings = this.SqlSettings;
        //    if (fAdd.ShowDialog() == DialogResult.OK)
        //    {
        //        this.SelectSqlData(dsCont, dsCont.tAbnContact, true, " where idAbn = " + ID.ToString() + " order by DateChange desc");
        //    }
        //}

        //private void toolStripButtonDelContact_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Хотите удалить контакт?", "Удаление",
        //         MessageBoxButtons.YesNo) == DialogResult.Yes)
        //    {
        //        DeleteSqlDataById(dsCont.tAbnContact, Convert.ToInt32(dGVAbnContact.CurrentRow.Cells["idDGVTBC"].Value));
        //        this.SelectSqlData(dsCont, dsCont.tAbnContact, true, " where idAbn = " + ID.ToString() + " order by DateChange desc");
        //    }
        //}

        //#endregion

        #region Работа с Объектами
        private void AddObj_Click(object sender, EventArgs e)
        {
            Constants.KontragentObjType typeObj = (TA == (int)Constants.AbnType.Private || TA == (int)Constants.AbnType.PrivateNoDog ||
                TA == (int)Constants.AbnType.KontragentFL) ? Constants.KontragentObjType.KontragentObjFL : KontragentObjType.KontragentObjLegal;
            FormAddEditObj fAdd = new FormAddEditObj(ID, -1, FormAddEditObj.ActionAbnObj.Add, -1, FormAddEditObj.ActionAbnObjReg.Add, TA, typeObj);
            fAdd.SqlSettings = this.SqlSettings;

            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                LoadAbonent();
                //this.SelectSqlData(dsAbn, dsAbn.vG_AbnObj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString());
                //if (dGVEFObj.RowCount > 0) LoadObj();
            }

        }



        private void EditObj_Click(object sender, EventArgs e)
        {
            if (dgvObj.RowCount > 0)
            {
                int idObj = Convert.ToInt32(dgvObj.CurrentRow.Cells["idObj"].Value);
                int idObjReg = (dgvObj.CurrentRow.Cells["idObjReg"].Value == DBNull.Value) ? 0 : Convert.ToInt32(dgvObj.CurrentRow.Cells["idObjReg"].Value);
                Constants.KontragentObjType typeObj = (TA == (int)Constants.AbnType.Private || TA == (int)Constants.AbnType.PrivateNoDog ||
                    TA == (int)Constants.AbnType.KontragentFL) ? Constants.KontragentObjType.KontragentObjFL : KontragentObjType.KontragentObjLegal;

                FormAddEditObj fAdd = new FormAddEditObj(ID, idObj, FormAddEditObj.ActionAbnObj.Edit, idObjReg, FormAddEditObj.ActionAbnObjReg.Edit, TA, typeObj);
                fAdd.SqlSettings = this.SqlSettings;

                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    LoadAbonent();
                    // this.SelectSqlData(dsCont, dsCont.vContObj, true, " where  idAbn = " + ID.ToString());
                    //if (dGVEFObj.RowCount > 0) LoadObj();
                }
            }
            else
            {
                MessageBox.Show("Нечего редактировать.");
            }
        }


        private void tsbDelObj_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить текущий объект?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Уверены? ВСЕ ТЕКУЩИЕ ДАННЫЕ БУДУТ ПОТЕРЯНЫ!!!", "Внимание!", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    MessageBox.Show("Функция отключена. Обратитесь в ОА.");

                    //if (this.DeleteSqlDataById(dsCont.tAbnObj, Convert.ToInt32(dgvObj.CurrentRow.Cells["idObj"].Value)))
                    //{
                    //    MessageBox.Show("Объект успешно удален");
                    //    LoadAbonent();
                    //}

                }
            }
        }

        #endregion

        #region Дерево типов
        private void LoadTypeTree()
        {

            TreeNode nodeType = new TreeNode("Все ");  // наименование
            nodeType.Tag = "Type0";
            tvType.Nodes.Add(nodeType);

            SelectSqlData(dsCont, dsCont.tR_Classifier, true, "where ParentKey = ';SKUEE;TypeAbn;' ");

            foreach (DataRow dr in dsCont.tR_Classifier.Select("", "id, Name"))
            {
                TreeNode node = new TreeNode();
                node.Text = dr["Name"].ToString();
                node.Tag = dr["id"].ToString();
                nodeType.Nodes.Add(node);

            }

            tvType.SelectedNode = nodeType;
            tvType.SelectedNode.Expand();

        }

        private void tvType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag.ToString() != "Type0")
            {
                bsAbn.Filter = "TypeAbn = " + e.Node.Tag.ToString();
            }
            else
            { bsAbn.RemoveFilter(); }

        }

        #endregion

        private void dgvObj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Контекстное меню контактов
        //private void dGVAbnContact_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && toolStripButtonNewContact.Visible == true) // если правой кнопкой
        //    {
        //        this.dGVAbnContact.Rows[e.RowIndex].Selected = true;
        //        ///-----------
        //        dGVAbnContact.CurrentCell = dGVAbnContact["postDataGridViewTextBoxColumn", e.RowIndex]; //делаем текущей
        //        this.contextMenuAbnContact.Show(System.Windows.Forms.Cursor.Position);
        //    }
        //}



    

        //private void tatbSearch_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
        //       dgvCont.Focus();
        //}

        //private void tatbSearch_KeyUp(object sender, KeyEventArgs e)
        //{
        //    for (int i = 0; i < dgvCont.RowCount; i++)
        //        if (dgvCont[1, i].FormattedValue.ToString().
        //            Contains(tatbSearch.Text.Trim()))
        //        {
        //            dgvCont.CurrentCell = dgvCont[1, i];
        //            return;
        //        }
        //        else
        //        {
        //            if (i == dgvCont.RowCount - 1) 
        //                tatbSearch.Text = tatbSearch.Text.Trim().Substring(0, tatbSearch.Text.Trim().Length - 1);
        //        }

        //}

        //private void tstbSearchName_KeyUp(object sender, KeyEventArgs e)
        //{

        //    for (int i = 0; i < dgvCont.RowCount; i++)
        //        if (dgvCont["NameAbnDGVTBC", i].FormattedValue.ToString().
        //            Contains(tstbSearchName.Text.Trim()))
        //        {
        //            dgvCont.CurrentCell = dgvCont[1, i];
        //            return;
        //        }
        //}

        //private void tsbFilter_Click(object sender, EventArgs e)
        //{
        //    if (AbnFilter == 1)
        //    {
        //        bsAbn.Filter = null;
        //        AbnFilter = 0;
        //    }

        //    else
        //    {
        //        bsAbn.Filter = "Name like '%" + tstbSearchName.Text.Trim() + "%' ";
        //        AbnFilter = 1;
        //    }

        //    dgvCont.Refresh();
        //}


    }
}
