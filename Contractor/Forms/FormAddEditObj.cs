using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Contractor.Forms
{
    public partial class FormAddEditObj : FormLbr.FormBase
    {

        public int OBJSELECT;

        /// <summary>
        /// Действия над объктом
        /// </summary>
        public enum ActionAbnObj
        {
            /// <summary>
            /// Добавить
            /// </summary>
            Add,
            /// <summary>
            /// Редактировать
            /// </summary>
            Edit,
            /// <summary>
            /// Просмотр
            /// </summary>
            Read
        }
        /// <summary>
        /// Действия над характерситиками объекта
        /// </summary>
        public enum ActionAbnObjReg
        {
            /// <summary>
            /// Добавить
            /// </summary>
            Add,
            /// <summary>
            /// Редактировать
            /// </summary>
            Edit,
            /// <summary>
            /// Просмотр
            /// </summary>
            Read
        }

        private int idAbn = -1;         // id абонента
        private int idAbnObj = -1;      // id объекта
        private int idAbnObjReg = -1;   // id истории объекта
        //private int idAbnObjParent = -1; // id родительского объекта
        //private int idAbnObjSame = -1;  // id объекта, который рассчитывается в другом абоненте
        private int TypeAbn = -1; // id типа абонента
        private ActionAbnObj actAbnObj;         // действия над объектом
        private ActionAbnObjReg actAbnObjReg;   // действия над харак-ами

        private Constants.KontragentObjType typeObj = Constants.KontragentObjType.KontragentObjFL;


        public FormAddEditObj()
        {
            InitializeComponent();
        }

        public FormAddEditObj(int abn, int idObj, ActionAbnObj actObj, int idObjReg, ActionAbnObjReg actObjReg, int type, Constants.KontragentObjType typeObj)
        {
            InitializeComponent();
            idAbn = abn;
            idAbnObj = idObj;
            idAbnObjReg = idObjReg;
            actAbnObj = actObj;
            actAbnObjReg = actObjReg;
            TypeAbn = type;
            this.typeObj = typeObj;

            if (TypeAbn == Convert.ToInt32(Constants.AbnType.Private)) tabControlAddEditObj.TabPages.RemoveAt(1); 
            switch (actAbnObj)
            {
                case ActionAbnObj.Add:  // Добавить объект
                    this.Text = "Новый объект";
                    actAbnObjReg = ActionAbnObjReg.Add; // на всякий случай
                    groupBoxTP.Visible = false;
                    break;
                case ActionAbnObj.Edit: // Редактировать объект
                    this.Text = "Редактировать объект";
                    //if (actAbnObjReg == ActionAbnObjReg.Read) // просмотр характеристик
                    //    EnabledObjRegControls(false);
                    break;
                case ActionAbnObj.Read:  // Просмотр
                    groupBoxAddress.Enabled = false;
                    switch (actAbnObjReg)
                    {
                        case ActionAbnObjReg.Add: // добавить хар-ку
                            this.Text = "Новые характеристики";
                            break;
                        case ActionAbnObjReg.Edit:
                            this.Text = "Редактировать харак-ки";
                            break;
                        case ActionAbnObjReg.Read:
                            this.Text = "Просмотр";
                            break;
                        default: 
                            break;
                    }
                    break;
                default:                
                    break;
            }
            
        }

        private bool LoadtAbn()
        {
            this.SelectSqlData(dsCont, dsCont.tAbn, true, "where id = " + idAbn.ToString());

            DataRow[] dr = dsCont.tAbn.Select("id = " + idAbn.ToString());
            if (dr.Length <= 0) return false;
            txtCodeAbonent.Text = dr[0]["CodeABonent"].ToString();
            txtAbn.Text = dr[0]["Name"].ToString();
            return true;
        }

        private void FormAddEditObj_Load(object sender, EventArgs e)
        {

            if (!LoadtAbn()) // загрузка абонента, сбытовых и сетевых организаций
            {
                MessageBox.Show("Не найден абонент");
                this.Close();
            }

            // загрузка областей
            this.SelectSqlData(dsObl, dsObl.Tables["tR_KladrObj"], true,
                " where Level = 1 and deleted = 0 and KladrCode is not null order by name, socr");


            if (cmbObl.SelectedIndex >= 0)
            {
                this.SelectSqlData(dsRaionObl, dsRaionObl.Tables["tR_kladrObj"], true,
                    " where (Level Between 2 and 3) and deleted = 0 order by name, socr");
                cmbRaionObl.Text = "Ульяновск г";
            }

            NumRazr_Load();

            InitAbnObj();

        }

        // менеджер формы
        private bool InitAbnObj()
        {
            switch (actAbnObj)
            {
                case ActionAbnObj.Add:  // новый объект
                    dsCont.tAbnObj.Rows.Add(dsCont.tAbnObj.NewRow());
                    NewAbnObjConnect();
                    NewAbnObjReg();
                    break;
                case ActionAbnObj.Edit: // редактировать объект
                case ActionAbnObj.Read: // просмотр объекта
                    if (!LoadAbnObj())  //загрузка текущего объекта
                    {
                        MessageBox.Show("Невозможно загрузить объект");
                        return false;
                    }
                    LoadtMapObj();  // загрузка MapObj
                    switch (actAbnObjReg)  //действия над характеристиками
                    {
                        case ActionAbnObjReg.Add: // новая
                            NewAbnObjReg();
                            break;
                        case ActionAbnObjReg.Edit: // редактирование истории
                        case ActionAbnObjReg.Read: // просмотр истории
                            if (TypeAbn != Convert.ToInt32(Constants.AbnType.Private)) //не часный сектор
                            {
                                if (!LoadAbnObjReg())
                                {
                                    if (MessageBox.Show("Невозможно загрузить характеристики\n" +
                                        "Создать новые характеристики?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                        NewAbnObjReg();
                                    else
                                        return true;
                                }
                            }
                            break;
                        default: break;
                    }
                    break;
                default: break;
            }
            return true;
        }
        // подключение для нового объекта
        private void NewAbnObjConnect()
        {
            DataRow dr = dsCont.tConnect.NewRow();
            dr["idObj_old"] = 0;
            dr["UserName"] = System.Environment.UserName.ToString();
            dr["CompName"] = System.Environment.MachineName.ToString();
            dr["DataMod"] = System.DateTime.Now;
            dr["Deleted"] = true;
            dsCont.tConnect.Rows.Add(dr);
        }

        // новая история объекта
        private void NewAbnObjReg()
        {
            DataRow dr = dsCont.tAbnObjReg.NewRow();
            dr["idAbn"] = idAbn;
            dr["idAbnObj"] = 0;
            dr["idAbnNet"] = 0;
            dr["idAbnSale"] = 0;
            dr["CalcLoss"] = 0;
            dr["DateChange"] = System.DateTime.Now;
            dr["DateTU"] = DBNull.Value;
            dsCont.tAbnObjReg.Rows.Add(dr);

        }

        // загрузка данных из tAbnObj, tConnect, vG_AbnObjKLossTrans
        private bool LoadAbnObj()
        {
            if (this.SelectSqlData(dsCont, dsCont.tAbnObj, true, " where id = " + idAbnObj.ToString()))
            {
                if (dsCont.tAbnObj.Rows.Count > 0)
                {
                    txtName.Text = dsCont.tAbnObj.Rows[0]["Name"].ToString();
                    // загрузка подключений
                    SelectSqlData(dsCont, dsCont.tConnect, true, " where Deleted = 0 and idObj = " + idAbnObj.ToString() + "order by idx desc");
 
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        // загрузка истории объекта
        private bool LoadAbnObjReg()
        {
            if (this.SelectSqlData(dsCont, dsCont.tAbnObjReg, true, " where id = " + idAbnObjReg.ToString()))
            {
                if (dsCont.tAbnObjReg.Rows.Count > 0)
                {

                    RegimeNUD.Value = (dsCont.tAbnObjReg.Rows[0]["Regime"] == DBNull.Value) ? 0 : Convert.ToInt16(dsCont.tAbnObjReg.Rows[0]["Regime"]);
                    KLossNUD.Value = (dsCont.tAbnObjReg.Rows[0]["KLoss"] == DBNull.Value) ? 0 : Convert.ToDecimal(dsCont.tAbnObjReg.Rows[0]["KLoss"]);
                    PowerSetNUD.Value = (dsCont.tAbnObjReg.Rows[0]["PowerSet"] == DBNull.Value) ? 0 : Convert.ToDecimal(dsCont.tAbnObjReg.Rows[0]["PowerSet"]);
                    PowerOtherNUD.Value = (dsCont.tAbnObjReg.Rows[0]["PowerOther"] == DBNull.Value) ? 0 : Convert.ToDecimal(dsCont.tAbnObjReg.Rows[0]["PowerOther"]);

                    if (dsCont.tAbnObjReg.Rows[0]["NumberTP"] != DBNull.Value)
                        cmbNumberTP.SelectedValue = dsCont.tAbnObjReg.Rows[0]["NumberTP"];
                    else
                        cmbNumberTP.SelectedIndex = -1;
                    if (dsCont.tAbnObjReg.Rows[0]["DateTP"] != DBNull.Value)
                        cmbDateTP.SelectedValue = dsCont.tAbnObjReg.Rows[0]["DateTP"].ToString();
                    else
                        cmbDateTP.SelectedIndex = -1;

                    txtNumberTU.Text = (dsCont.tAbnObjReg.Rows[0]["NumberTU"] == DBNull.Value) ? "" : dsCont.tAbnObjReg.Rows[0]["NumberTU"].ToString();
                    dtDateTU.Text = (dsCont.tAbnObjReg.Rows[0]["DateTU"] == DBNull.Value) ? "" : dsCont.tAbnObjReg.Rows[0]["DateTU"].ToString();

                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        // загрузка mapObj
        private void LoadtMapObj()
        {
            if (dsCont.tAbnObj.Rows[0]["idmap"] == DBNull.Value)
            {
                groupBoxAddress.Enabled = true;
                return;
            }
            this.SelectSqlData(dsCont, dsCont.tMapObj, true, " where idMap = " + dsCont.tAbnObj.Rows[0]["idmap"].ToString());

            txtHouse.Text = dsCont.tMapObj.Rows[0]["House"].ToString();
            txtHousePrefix.Text = dsCont.tMapObj.Rows[0]["HousePrefix"].ToString();

            // получим улицу
            this.SelectSqlData(dsCont, dsCont.tR_KladrStreet, true, " where id = " + dsCont.tMapObj.Rows[0]["Street"].ToString());

            // получим город(район области)
            this.SelectSqlData(dsCont, dsCont.tR_KladrObj, true, " where id = " + dsCont.tR_KladrStreet.Rows[0]["KladrObjId"].ToString());

            int punkt = -1;
            int raionObl = -1;
            int obl = -1;

            // id города(района области)
            punkt = (int)dsCont.tR_KladrStreet.Rows[0]["KladrObjId"];
            this.SelectSqlData(dsCont, dsCont.tR_KladrObj, true, " where id = " + dsCont.tR_KladrObj.Rows[0]["ParentId"].ToString());
            // id области
            raionObl = (int)dsCont.tR_KladrObj.Rows[0]["Id"];
            // id страны
            obl = (int)dsCont.tR_KladrObj.Rows[0]["ParentId"];

            DataTable dt = dsCont.tR_KladrObj.Clone();
            this.SelectSqlData(dt, true, " where id = " + dsCont.tR_KladrObj.Rows[0]["ParentId"].ToString());
            if (dt.Rows[0]["PrimaryKey"] != DBNull.Value
                && dt.Rows[0]["PrimaryKey"].ToString() == "subject")
            {
                cmbObl.SelectedValue = obl;
                InitCmbRaionObl(Convert.ToInt32(cmbObl.SelectedValue));
                cmbRaionObl.SelectedValue = raionObl;
                cmbCity.SelectedValue = punkt;
            }
            else
            {
                // установим Ульяновскую область
                cmbObl.SelectedIndex = 0;
                InitCmbRaionObl(Convert.ToInt32(cmbObl.SelectedValue));
                cmbRaionObl.SelectedValue = punkt;
            }

            /*// загрузка районов/городов
            if (cmbObl.SelectedIndex >= 0)
            {
                this.SelectSqlData(dsRaionObl, dsRaionObl.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                cmbRaionObl.SelectedIndex = -1;
                cmbRaionObl.SelectedValue = punkt;
            }
            */
            txtIndex.Text = dsCont.tMapObj.Rows[0]["Index"].ToString();
            if (dsCont.tMapObj.Rows[0]["Raion"] != DBNull.Value)
                cmbRaionCity.SelectedValue = Convert.ToInt32(dsCont.tMapObj.Rows[0]["Raion"]);
            if (dsCont.tMapObj.Rows[0]["Comment"] != DBNull.Value)
                txtMapObjComment.Text = dsCont.tMapObj.Rows[0]["Comment"].ToString();
                cmbStreet.SelectedValue = Convert.ToInt32(dsCont.tMapObj.Rows[0]["Street"]);
        }

        private void InitCmbRaionObl(int obl)
        {
            this.SelectSqlData(dsRaionObl, dsRaionObl.Tables["tR_kladrObj"], true,
                    " where ParentId = " + obl.ToString() + " and deleted = 0 order by name, socr");
            cmbRaionObl.SelectedIndex = -1;
        }

        #region comboBoxes Events
        // смена области
        private void cmbObl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // загрузка районов/города выбранной области
            if (cmbObl.SelectedIndex < 0)
                dsRaionObl.Tables["tR_KladrObj"].Clear();
            else
            {
                this.SelectSqlData(dsRaionObl, dsRaionObl.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                cmbRaionObl.SelectedIndex = cmbRaionObl.FindString("Ульяновск", 0);

            }
        }
        // смена района/города области
        private void cmbRaionObl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // загрузка районов/города выбранной области
            if (cmbRaionObl.SelectedIndex < 0)
                dsPunkts.Tables["tR_KladrObj"].Clear();
            else
            {
                // населенные пункты
                this.SelectSqlData(dsPunkts, dsPunkts.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbRaionObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                cmbCity.SelectedIndex = -1;

                // районы города/населенного пункта
                DataSets.DataSetCont dsTmp = new DataSets.DataSetCont();
                this.SelectSqlData(dsTmp, dsTmp.tR_Classifier, true, "where parentkey like '%;CityRaion;%' and value = " +
                    cmbRaionObl.SelectedValue.ToString());

                if (dsTmp.tR_Classifier.Rows.Count <= 0)
                    dsRaionCity.Tables["tR_Classifier"].Clear();
                else
                {
                    this.SelectSqlData(dsRaionCity, dsRaionCity.Tables["tR_Classifier"], true, "where isGRoup = 0 and parentkey = '" +
                        dsTmp.tR_Classifier.Rows[0]["ParentKey"] + "' and deleted = 0 order by name");
                    cmbRaionCity.SelectedIndex = -1;
                }

                this.SelectSqlData(dsStreet, dsStreet.Tables["tR_KladrStreet"], true,
                    " where KladrObjId = " + cmbRaionObl.SelectedValue + " and deleted = 0 order by name, socr ");
                cmbStreet.SelectedIndex = -1;
            }
        }
        // выбор населенного пункта
        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedIndex >= 0)
            {
                this.SelectSqlData(dsStreet, dsStreet.Tables["tR_KladrStreet"], true,
                    " where KladrObjId = " + cmbCity.SelectedValue + " and deleted = 0 order by name, socr ");
                cmbStreet.SelectedIndex = -1;
            }
        }
        // Смена улицы
        private void cmbStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStreet.SelectedIndex >= 0)
            {
                DataRow[] dr = dsStreet.Tables["tR_KladrStreet"].Select("Id = " + cmbStreet.SelectedValue.ToString());
                txtIndex.Text = dr[0]["Index"].ToString();
            }
        }
        #endregion

        #region Подключения

        private void tsbNewTP_Click(object sender, EventArgs e)
        {
            //if (dgvTP.RowCount > 0)
            //{
            Legal.Forms.Object.FormAddEditConnect f = new Legal.Forms.Object.FormAddEditConnect(-1, idAbnObj, Legal.Forms.Object.FormAddEditConnect.ActionСonnect.Add);
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            { SelectSqlData(dsCont, dsCont.tConnect, true, " where Deleted = 0 and idObj = " + idAbnObj.ToString() + "order by idx desc"); };
            //}

        }

        private void tsbEditTP_Click(object sender, EventArgs e)
        {
            if (dgvTP.RowCount > 0)
            {
                Legal.Forms.Object.FormAddEditConnect f = new Legal.Forms.Object.FormAddEditConnect(Convert.ToInt32(dgvTP.CurrentRow.Cells["idxDataGridViewTextBoxColumn"].Value), idAbnObj, Legal.Forms.Object.FormAddEditConnect.ActionСonnect.Edit);
                f.Owner = this;
                f.SqlSettings = this.SqlSettings;
                if (f.ShowDialog() == DialogResult.OK)
                { SelectSqlData(dsCont, dsCont.tConnect, true, " where Deleted = 0 and idObj = " + idAbnObj.ToString() + "order by idx desc"); };
            }
            else
            { MessageBox.Show("Нечего редактировать"); }
        }

        private void tsbDelTP_Click(object sender, EventArgs e)
        {
            if (dgvTP.RowCount > 0)
            {
                int idx = Convert.ToInt32(dgvTP.CurrentRow.Cells["idxDataGridViewTextBoxColumn"].Value);
                if (MessageBox.Show("Вы действительно хотите удалить текущее подключение?", "Удаление",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    DataSets.DataSetCont ds = new DataSets.DataSetCont();
                    this.SelectSqlData(ds, ds.tConnect, true, "where idx = " + idx.ToString());
                    ds.tConnect.Rows[0]["Deleted"] = !Convert.ToBoolean(ds.tConnect.Rows[0]["Deleted"]);
                    ds.tConnect.Rows[0].EndEdit();
                    if (this.UpdateSqlData(ds, ds.tConnect))
                    {
                        if (Convert.ToBoolean(ds.tConnect.Rows[0]["Deleted"]))
                        {
                            MessageBox.Show("Подключене успешно удалено.");
                            SelectSqlData(dsCont, dsCont.tConnect, true, " where Deleted = 0 and idObj = " + idAbnObj.ToString() + "order by idx desc");
                        }
                        else
                        {
                            MessageBox.Show("Подключение успешно восстановлено");
                        }
                    }

                }



            }
            else
            { MessageBox.Show("Нечего удалять"); }
        }
        #endregion

        private void NumRazr_Load()
        {

            this.SelectSqlData(dsCont, dsCont.tR_Classifier, true, " where SocrName = 'PermissionConnection'");
            string Path = "";
            if (dsCont.tR_Classifier.Rows.Count != 0)
                Path = dsCont.tR_Classifier.Rows[0]["Comment"].ToString();
            dsCont.vG_NumRazresh.Clear();
            if (string.IsNullOrEmpty(Path)) return;   // Shumilov Alexandr 06.03.2013. Если нет - то и таблитчки tbl_razresh тоже нет!!!!
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                Path = Path.Trim();
                strCmd = "select distinct TOP (100) PERCENT Num_Razr from " + Path + "tbl_razresh order by Num_Razr";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCont, "vG_NumRazresh");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }

        }

        private void PtsRazr_Load()
        {

            this.SelectSqlData(dsCont, dsCont.tR_Classifier, true, " where SocrName = 'PermissionConnection'");
            string Path = "";
            if (dsCont.tR_Classifier.Rows.Count != 0)
                Path = dsCont.tR_Classifier.Rows[0]["Comment"].ToString();
            dsCont.vG_PtsRazresh.Clear();
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                Path = Path.Trim();
                strCmd = "select distinct TOP (100) PERCENT Date_Vidan from " + Path + " tbl_razresh where Num_Razr = " + cmbNumberTP.Text + " order by Date_Vidan desc";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCont, "vG_PtsRazresh");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }
        }

        private void cmbNumberTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNumberTP.Text != "")
                PtsRazr_Load();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!CheckAbnObj())
                return;
            int idMap = FindIdMap();    //получаем код карты
            if (idMap == -1)
            {
                MessageBox.Show("Не удается создать объект - дом");
                return;
            }
            //int idMap = 0;
            switch (actAbnObj)
            {
                case ActionAbnObj.Add: // новый объект
                    int abnObj = InsertIntotAbnObj(idMap);
                    if (abnObj < 0)
                    {
                        MessageBox.Show("Не удается создать объект");
                        return;
                    }
                    if (TypeAbn != Convert.ToInt32(Constants.AbnType.Private))
                    {
                        if (InsertIntotAbnObjReg(abnObj) < 0)
                        {
                            MessageBox.Show("Не удается создать характеристики");
                            return;
                        }
                    }
                    break;
                case ActionAbnObj.Edit: // редактировать объект
                case ActionAbnObj.Read: // просмотр
                    if (actAbnObj == ActionAbnObj.Edit)
                    {
                        if (!UpdatetAbnObj(idMap))
                        {
                            MessageBox.Show("Не удается отредактировать объект");
                            return;
                        }

                        if (TypeAbn != Convert.ToInt32(Constants.AbnType.Private))
                        {
                            if (InsertIntotAbnObjReg(Convert.ToInt32(dsCont.tAbnObj.Rows[0]["id"])) < 0)
                            {
                                MessageBox.Show("Не удается создать характеристики");
                                return;
                            }
                        }
                    }
                    break;
                default: break;
            }

            this.DialogResult = DialogResult.OK;
        }


        // проверка заполнености объекта
        private bool CheckAbnObj()
        {
            if (actAbnObj != ActionAbnObj.Read)
            {

                if (String.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Нет названия объекта");
                    return false;
                }

                if (cmbStreet.SelectedIndex < 0)
                {
                    MessageBox.Show("Не выбрана улица");
                    return false;
                }
                if (String.IsNullOrEmpty(txtHouse.Text))
                {
                    MessageBox.Show("Не указан номер дома");
                    return false;
                }

            }

            return true;
        }

        private int FindIdMap()
        {
            string housePrefix = (String.IsNullOrEmpty(txtHousePrefix.Text)) ?
                " and HousePrefix is null " : " and HousePrefix = '" + txtHousePrefix.Text + "'";
            this.SelectSqlData(dsCont, dsCont.tMapObj, true, "where Street = " + cmbStreet.SelectedValue.ToString() +
                " and House = " + txtHouse.Text + housePrefix + " and IsHouse = 1 and Name is null");

            if (dsCont.tMapObj.Rows.Count > 0) // есть такой дом (создавать не надо)
            {
                dsCont.tMapObj.Rows[0]["Index"] = txtIndex.Text;
                dsCont.tMapObj.Rows[0]["Raion"] = (cmbRaionCity.SelectedValue == null) ? DBNull.Value : cmbRaionCity.SelectedValue;
                if (string.IsNullOrEmpty(txtMapObjComment.Text))
                    dsCont.tMapObj.Rows[0]["Comment"] = DBNull.Value;
                else
                    dsCont.tMapObj.Rows[0]["Comment"] = txtMapObjComment.Text;
                dsCont.tMapObj.Rows[0].EndEdit();
                if (this.UpdateSqlData(dsCont, dsCont.tMapObj))
                    return Convert.ToInt32(dsCont.tMapObj.Rows[0]["idMap"]);
                else
                    return -1;
            }
            else
            {
                DataRow dr = dsCont.tMapObj.NewRow();
                dr["Raion"] = (cmbRaionCity.SelectedValue == null) ? DBNull.Value : cmbRaionCity.SelectedValue;
                dr["Street"] = cmbStreet.SelectedValue;
                dr["House"] = txtHouse.Text;
                if (!String.IsNullOrEmpty(txtHousePrefix.Text))
                    dr["HousePrefix"] = txtHousePrefix.Text;
                dr["IsHouse"] = true;
                dr["Index"] = txtIndex.Text;
                if (!string.IsNullOrEmpty(txtMapObjComment.Text))
                    dr["Comment"] = txtMapObjComment.Text;
                dr["Deleted"] = 0;

                dsCont.tMapObj.Rows.Add(dr);

                dsCont.tMapObj.Rows[0].EndEdit();
                return this.InsertSqlDataOneRow(dsCont, dsCont.tMapObj);
            }
        }

        // добавить объект в базу
        private int InsertIntotAbnObj(int idMap)
        {
            dsCont.tAbnObj.Rows[0]["idAbn"] = idAbn;
            if (String.IsNullOrEmpty(txtName.Text))
                dsCont.tAbnObj.Rows[0]["Name"] = DBNull.Value;
            else
                dsCont.tAbnObj.Rows[0]["Name"] = txtName.Text;

            dsCont.tAbnObj.Rows[0]["idMap"] = idMap;

            dsCont.tAbnObj.Rows[0]["typeObj"] = (int)typeObj;

            dsCont.tAbnObj.Rows[0]["idObjParent"] = DBNull.Value;

            dsCont.tAbnObj.Rows[0].EndEdit();
            return this.InsertSqlDataOneRow(dsCont, dsCont.tAbnObj);
        }

        // добавить характеристики объекта
        private int InsertIntotAbnObjReg(int AbnObj)
        {
            dsCont.tAbnObjReg.Clear();

            DataRow dr = dsCont.tAbnObjReg.NewRow();

            dr["idAbn"] = idAbn;
            dr["idAbnObj"] = AbnObj;
            dr["idAbnNet"] = 0; // (AbnNetComboBox.SelectedValue == null) ? DBNull.Value : AbnNetComboBox.SelectedValue;
            dr["idAbnSale"] = 0; //(abnSaleComboBox.SelectedValue == null) ? DBNull.Value : abnSaleComboBox.SelectedValue;
            dr["idStatus"] = DBNull.Value; //(statusNameComboBox.SelectedValue == null) ? DBNull.Value : statusNameComboBox.SelectedValue;
            dr["Category"] = DBNull.Value; //(categoryComboBox.SelectedValue == null) ? DBNull.Value : categoryComboBox.SelectedValue;
            dr["idTariff"] = DBNull.Value; //(TariffcomboBox.SelectedValue == null) ? DBNull.Value : TariffcomboBox.SelectedValue;
            dr["Comment"] = "";// txtComment.Text;
            dr["Regime"] = RegimeNUD.Value;
            dr["KLoss"] = KLossNUD.Value;
            dr["PowerSet"] = PowerSetNUD.Value;
            dr["PowerOther"] = PowerOtherNUD.Value;
            dr["PowerFact"] = DBNull.Value; // PowerFactNUD.Value;
            dr["CalcLoss"] = 0; //cbxCalcLoss.Checked;
            dr["DateChange"] = System.DateTime.Now;
            dr["ConsumerGroup"] = DBNull.Value; //(cmbConsumerGroup.SelectedValue == null) ? DBNull.Value : cmbConsumerGroup.SelectedValue;
            dr["Consumer"] = DBNull.Value; //(cmbConsumer.SelectedValue == null) ? DBNull.Value : cmbConsumer.SelectedValue;

            dr["SubNet"] = 0;// cbxSubNet.Checked;
            dr["SubNetComment"] = ""; // txtSubNetComment.Text;

            dr["NumberTP"] = (cmbNumberTP.SelectedValue == null) ? DBNull.Value : cmbNumberTP.SelectedValue;
            dr["DateTP"] = (cmbDateTP.SelectedValue == null) ? DBNull.Value : cmbDateTP.SelectedValue;
            if ((txtNumberTU.Text != null) & (txtNumberTU.Text != ""))
            {
                dr["NumberTU"] = Convert.ToInt32(txtNumberTU.Text);
                dr["DateTU"] = dtDateTU.Value.Date;
            }

           // if (String.IsNullOrEmpty(txtObjectSame.Text))
                dr["idAbnObjSame"] = DBNull.Value;
          //  else
          //      dr["idAbnObjSame"] = idAbnObjSame;

            dsCont.tAbnObjReg.Rows.Add(dr);

            return this.InsertSqlDataOneRow(dsCont, dsCont.tAbnObjReg);
        }

        // редактировать объект
        private bool UpdatetAbnObj(int idMap)
        {
            if (String.IsNullOrEmpty(txtName.Text))
                dsCont.tAbnObj.Rows[0]["Name"] = DBNull.Value;
            else
                dsCont.tAbnObj.Rows[0]["Name"] = txtName.Text;

            dsCont.tAbnObj.Rows[0]["idMap"] = idMap;

           // if (String.IsNullOrEmpty(txtParent.Text))
                dsCont.tAbnObj.Rows[0]["idObjParent"] = DBNull.Value;
           // else
           //     dsCont.tAbnObj.Rows[0]["idObjParent"] = idAbnObjParent;

                dsCont.tAbnObj.Rows[0].EndEdit();
                return this.UpdateSqlData(dsCont, dsCont.tAbnObj);
        }

    }
}
