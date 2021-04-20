using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using FormLbr.Classes;
using PluginInterfaces;
using Passport.Forms.StateEquipmentList;
using System.Runtime.InteropServices;
using Passport.Forms.Transf;
using FormLbr;
using WinFormsUI.Docking;
using Scheme.Forms;
using Legal.Forms;
using Prv.Forms.Abonent;


namespace EIS.Forms
{
    public partial class FormMain : FormLbr.FormBase, IPluginHost
    {
        #region Constants
        const string SERVER_DB = "ulges-sql2";        // сервер БД по умолчанию
        const string DB_NAME = "GES";             // имя БД по умлчанию
        const string DB_TOK = "TOK";             // имя БД тока по умолчанию
        const string AUTENTIFICATION = "WINDOWS";   // аутентификация по умочанию
        const int FORM_WIDTH = 1000;             // ширина формы по умолчанию
        const int FORM_HEIGHT = 700;             // высота формы по умолчанию

        const string TABLE_USER = "tUser";     // табличка с пользователями
        #endregion

        #region Переменные
        public EISSettings eisSettings = new EISSettings();
        #endregion

        #region Constructors
        public FormMain()
        {
            InitializeComponent();
        }
        #endregion

        // Загрузка данных из конфиг-файла
        private void LoadConfig()
        {            
            // чтение конфига
            eisSettings = new EISSettings();
            AppConfig appConfig = new AppConfig();
            eisSettings = appConfig.OpenAppConfig();
            // если каки-то поля не прочитали... сделаем по-умолчанию
            if (String.IsNullOrEmpty(eisSettings.SqlSettings.ServerDB)) eisSettings.SqlSettings.ServerDB = SERVER_DB;
            if (String.IsNullOrEmpty(eisSettings.SqlSettings.DBName)) eisSettings.SqlSettings.DBName = DB_NAME;
            if (String.IsNullOrEmpty(eisSettings.SqlSettings.Autentification)) eisSettings.SqlSettings.Autentification = AUTENTIFICATION;
            if (eisSettings.FrmMainSettings.Width <= 300) eisSettings.FrmMainSettings.Width = FORM_WIDTH;
            if (eisSettings.FrmMainSettings.Height <= 100) eisSettings.FrmMainSettings.Height = FORM_HEIGHT;
            this.Width = eisSettings.FrmMainSettings.Width;
            this.Height = eisSettings.FrmMainSettings.Height;
            this.WindowState = eisSettings.FrmMainSettings.WindowsState;


            // Таймер обновлений!!
            //timerUpdater.Interval = eisSettings.UpdateSettings.IntervalUpdate;
            timerUpdater.Start();
            

            
            /*
            eisSettings.IsShowFormConnect = false;
            eisSettings.SqlSettings.ServerDB = "ulges-sql2";
            this.SqlSettings = eisSettings.SqlSettings;
            DataTable dt = new DataTable();
            if (SqlSettings.Autentification.ToUpper() == "WINDOWS")
                dt = this.SelectSqlData(TABLE_USER, false, "where Login = SYSTEM_USER AND Deleted = 0");
            else
                dt = this.SelectSqlData(TABLE_USER, false, "where Login = '" + SqlSettings.SqlUserConnect + "' AND Deleted = 0");
            if (dt.Rows.Count > 0) return;
            else
            {
                MessageBox.Show("Данный пользователь не зарегистрирован в базе " + this.SqlSettings.DBName +
            "\nОбратитесь к админитсратору базы данных",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(0);
            }*/


            if (!eisSettings.IsShowFormConnect)
            {
                DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
                if (sql.CheckConnection(eisSettings.SqlSettings))
                {
                    this.SqlSettings = eisSettings.SqlSettings;
                    DataTable dt = new DataTable();
                    if (SqlSettings.Autentification.ToUpper() == "WINDOWS")
                        dt = this.SelectSqlData(TABLE_USER, false, "where Login = SYSTEM_USER AND Deleted = 0");
                    else
                        dt = this.SelectSqlData(TABLE_USER, false, "where Login = '" + SqlSettings.SqlUserConnect + "' AND Deleted = 0");
                    if (dt.Rows.Count > 0) return;
                    else MessageBox.Show("Данный пользователь не зарегистрирован в базе " + this.SqlSettings.DBName +
                    "\nОбратитесь к админитсратору базы данных",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            while (true)
            {
                if (ShowFormConnect())
                {
                    this.SqlSettings = eisSettings.SqlSettings;
                    DataTable dt = new DataTable();
                    if (SqlSettings.Autentification.ToUpper() == "WINDOWS")
                        dt = this.SelectSqlData(TABLE_USER, false, "where Login = SYSTEM_USER AND Deleted = 0");
                    else
                        dt = this.SelectSqlData(TABLE_USER, false, "where Login = '" + SqlSettings.SqlUserConnect + "' AND Deleted = 0");
                    if (dt.Rows.Count > 0) return;
                    else MessageBox.Show("Данный пользователь не зарегистрирован в базе " + this.SqlSettings.DBName +
                    "\nОбратитесь к админитсратору базы данных",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                    Environment.Exit(0);  // здесь такая заплатка, потому что в конструторе это дело происходит
            }
        }
        // показывает форму-коннект
        private bool ShowFormConnect()
        {
            FormConnect newChild = new FormConnect(eisSettings.SqlSettings);

            // Успешное соединение
            if (newChild.ShowDialog() == DialogResult.OK)
            {
                eisSettings.SqlSettings = newChild.SqlSetting;
                return true;
            }
            else // Отмена соединения
            {
                return false;
            }
        }

        #region FormMain Events
        // загрузка формы
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            LoadConfig();
            this.Visible = true;

            notifyIconBirthDay.BalloonTipClosed += new EventHandler(notifyIconBirthDay_BalloonTipClosed);
            ShowBirthDays();
            LoadPlugins();
        }

        // закрытие формы
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIconBirthDay.Visible = false;
            AppConfig appConfig = new AppConfig();
            if (this.WindowState == FormWindowState.Normal)
            {
                eisSettings.FrmMainSettings.Width = this.Width;
                eisSettings.FrmMainSettings.Height = this.Height;
            }
            eisSettings.FrmMainSettings.WindowsState = this.WindowState;
            if (this.WindowState == FormWindowState.Minimized)
                eisSettings.FrmMainSettings.WindowsState = FormWindowState.Normal;
            appConfig.SaveAppConfig(eisSettings);

            backgroundWorkerUpdater.CancelAsync();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.Shift | Keys.J:
                    Passport.Forms.FormRegistr frm = new Passport.Forms.FormRegistr(this.SqlSettings);
                    frm.SqlSettings = this.SqlSettings;
                    frm.MdiParent = this;
                    frm.Show();
                    return true;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region NotifyIconBirthDay
        private void ShowUpdateProgram()
        {
            DataTable tUpdate = this.SelectSqlData("tJ_UpdateProgram", true, "where dateUpdate < getdate() order by dateUpdate desc");
            if (tUpdate.Rows.Count > 0)
            {
                DateTime dUpdate = Convert.ToDateTime(tUpdate.Rows[0]["dateUpdate"]);
                DataTable tCheck = this.SelectSqlData("tJ_UpdateProgramUserCheck", true, 
                    " where Login = SYSTEM_USER and dateCheck >= '" + dUpdate.ToString("yyyyMMdd HH:mm") + "'");
                if (tCheck.Rows.Count == 0)
                {
                    notifyIconBirthDay.BalloonTipText = "Вышли новые обновления программы";
                    notifyIconBirthDay.BalloonTipText += "\nКликните для просмотра журнала обновлений";
                    notifyIconBirthDay.BalloonTipTitle = "Обновления";
                    notifyIconBirthDay.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIconBirthDay.Tag = "Update";
                    notifyIconBirthDay.ShowBalloonTip(0);
                }
            }
        }
        private void ShowBirthDays()
        {
            
            DataTable dt = this.SelectSqlData("tr_Worker", true, " where Day(birthDay) = DAy(getdate()) and Month(BirthDay) = Month(getdate()) and DateEnd is Null order by F, I, O");

            string fio = "";
            foreach (DataRow dr in dt.Rows)
            {
                fio += dr["F"].ToString() + " " + dr["I"].ToString() + " " + dr["O"].ToString() + "\n";
            }
            notifyIconBirthDay.Tag = "BirthDay";
            if (fio != "")
            {
                notifyIconBirthDay.BalloonTipText = fio;
                notifyIconBirthDay.BalloonTipTitle = "Дни рождения";
                notifyIconBirthDay.BalloonTipIcon = ToolTipIcon.Info;
                notifyIconBirthDay.ShowBalloonTip(0);
            }
        }
        // Клик по трею
        private void notifyIconBirthDay_MouseClick(object sender, MouseEventArgs e)
        {
            ShowBirthDays();
            /*if (!String.IsNullOrEmpty(notifyIconBirthDay.BalloonTipText))
                notifyIconBirthDay.ShowBalloonTip(0);*/
        }
        private void notifyIconBirthDay_BalloonTipClicked(object sender, EventArgs e)
        {
            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Activate();

            if (notifyIconBirthDay.Tag.ToString() == "BirthDay")
                ShowUpdateProgram();
            else
                if (notifyIconBirthDay.Tag.ToString() == "Update")
                    ShowMdiForm(typeof(Documents.Forms.JournalUpdateProgram.FormJournalUpdateProgram));
        }
        void notifyIconBirthDay_BalloonTipClosed(object sender, EventArgs e)
        {
            if (notifyIconBirthDay.Tag.ToString() == "BirthDay")
            {
                ShowUpdateProgram();
            }
        }
        //  Двойной клик
        private void notifyIconBirthDay_DoubleClick(object sender, EventArgs e)
        {
            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Activate();
        }
        #endregion
        // Таймер
        //int int_flushMemory = 0;
        private void timerMain_Tick(object sender, EventArgs e)
        {
            toolStripLabelTime.Text = System.DateTime.Now.ToLongTimeString();
            
            // Пока закоментял, есть подозрение, что от него схема подвисает
            //int_flushMemory++;
            //if (int_flushMemory == 120) // каждые две минуты
            //{
            //    MemoryManagement.SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            //    int_flushMemory = 0;
            //}
        }
        // таймер обновлений
        public string pathUpdate;
        bool isCheckUpdate = false;
        private void timerUpdater_Tick(object sender, EventArgs e)
        {
            timerUpdater.Interval = eisSettings.UpdateSettings.IntervalUpdate;
            if (!isCheckUpdate)
                if (string.IsNullOrEmpty(pathUpdate))
                {
                    isCheckUpdate = true;
                    backgroundWorkerUpdater.RunWorkerAsync();
                }
        }

        private void backgroundWorkerUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            if (eisSettings.UpdateSettings.DownloadPath.IndexOf("ftp") == 0)  // начинается с ФТП
            {
                EIS.ChekerDownloaderFromFTP checkFTP = new ChekerDownloaderFromFTP(eisSettings.UpdateSettings.DownloadPath/*, @"d:\eisupdates"*/);
                checkFTP.CurrentVersion = Assembly.GetEntryAssembly().GetName().Version;
                checkFTP.FTPUser = "ftpuser";
                checkFTP.FTPPassword = "qazwsxedc";
                pathUpdate = checkFTP.PrepareUpdates();
            }
            else
            {
                EIS.ChekerDownloaderFromFolder check = new ChekerDownloaderFromFolder(eisSettings.UpdateSettings.DownloadPath);
                check.CurrentVersion = Assembly.GetEntryAssembly().GetName().Version;
                pathUpdate = check.PrepareUpdates();
            }
        }

        private void backgroundWorkerUpdater_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isCheckUpdate = false;
            if (!string.IsNullOrEmpty(pathUpdate)) toolBtnUpdate.Visible = true;
        }

        private void ShowMdiForm(Form mdiForm)
        {
            mdiForm.MdiParent = this;
            mdiForm.Show();
        }
        // вызвать форму по типу (у формы должен быть конструктор без параметров)
        private void ShowMdiForm(Type typeForm)
        {
            FormLbr.FormBase form = null;
            try
            {
                form = (FormLbr.FormBase)Activator.CreateInstance(typeForm);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source); }
            if (form == null) return;
            form.MdiParent = this;
            form.SqlSettings = eisSettings.SqlSettings;
            form.Show();
        }

        #region Prv Бытовой сектор
        // Карточка абоента
        private void toolStripMenuItemFLAbonent_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Abonent.FormAbonent));
        }
        // Журнал пломб
        private void toolMenuItemJPlomb_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Plombs.FormJPlomb));
        }
        // Список все домов
        private void toolMenuItemListAllHouses_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Houses.FormHouses));
        }
        // изменить адрес дома
        private void toolMenuItemChangeAddressHouse_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Houses.FormHousesEditAdress));
        }
        // Участки контролеров
        private void toolMenuItemControlers_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Controlers.FormControlers));
        }
        // Акты
        private void toolMenuItemActs_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Reports.FormActs));
        }
        // Отчет по пломбам
        private void toolMenuItemRepPlombs_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Reports.FormPlombs));
        }
        // протокол начислений
        private void toolMenuItemProtocolDeb_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Reports.FormDebitorka));
        }
        // анализ и сравнение
        private void toolMenuItemAnalysisAndComparison_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Reports.FormDebRep));
        }
        // отчет по контролерам
        private void toolMenuItemReportControler_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Reports.FormWorkControllers));
        }
        // отчет по признакам
        private void toolMenuItemReportOnGrounds_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Reports.FormRepAbnFlag));
        }
        // Экспорт документов
        private void toolMenuItemExportDocuments_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Exchange.FormKOinUE));
        }
        // Импорт из УлЭнерго
        private void UEOplToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Exchange.FormUEOpl));
        }

        private void UEoplPOSTStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Exchange.FormUEoplPOST));
        }


        private void UEDebPOSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Exchange.FormUEDEbPOST));
        }

        private void UEDebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Exchange.FormUEDeb));
        }


        // Импорт из сбербанка
        private void toolMenuItemImportFromSberbank_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Exchange.FormSBROpl));
        }

        //Анализ прогруженых данных
        private void AnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Exchange.FormUEanalysis));
        }

        #endregion

        #region Legal Госсектор
        // Карточка потребителя
        private void toolMenuItemLegalAbn_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.FormAbn));
        }
        // Ввод начислений
        private void toolMenuItemInputCharge_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.FormCntVal));
        }
        // проверка на полноту
        private void toolMenuItemInputCheck_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Calculat.FormInputCheck));
        }
        // формирование и печать документов
        private void toolMenuItemCreateAndPrintDocs_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Calculat.FormGroupDoc));
        }
        // ведомость по начислениям
        private void toolMenuItemReportCharge_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Calculat.FormReportMain));
        }
        // ведомость по корректным счет-фактурам
        private void toolMenuItemReportInvoice_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Calculat.FormReportCorrect));
        }
        // Оперативная сводка
        private void toolMenuItemREportPerformance_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Calculat.FormReportOper));
        }
        // Уведомления
        private void toolMenuItemNoticeGos_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.FormRep.FormNotification));
        }
        // Потребители
        private void toolMenuItemAbonentsLegal_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.FormLAbn));
        }
        // объекты
        private void toolMenuItemAbnObjectsLegal_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Object.FormLObj));
        }
        // приборы учета
        private void toolMenuItemMeterLegal_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Meter.FormLCnt));
        }
        // банки
        private void toolMenuItemBanksLegal_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.FormBanks));
        }
        // акт разграничения балансовой принадлежности
        private void toolMenuItemActBalanceInventory_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Document.FormActBalance));
        }
        // графики обследований
        private void toolMenuItemGraphicSurveys_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.GraphicsInspector.FormGraphicsView));
        }
        // установить расчетный период
        private void toolMenuItemSetAccountPeriod_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Calculat.FormCalcPeriod));
        }
        // закрыть расчетный период
        private void toolMenuItemCloseAccountPeriod_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.FormClosePeriod));
        }
        // уполномоченные лица
        private void toolMenuItemAuthorizedPersons_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.FormAuthorizedPerson));
        }
        // номера счет-фактур
        private void toolMenuItemNumInvoice_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Calculat.FormNumberFact));
        }
        // тарифы
        private void toolMenuItemTariffLegal_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Calculat.FormEnterTariff));
        }
        // ввод прогнозируемых данных
        private void toolMenuItemInputForecast_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Prognosis.FormPrognosisMonthAdd));
        }
        // выгрузка для ГРП
        private void toolMenuItemExportToGRP_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Export.FormExportGRP));
        }
        // выгрузка для ОДС
        private void toolMenuItemExportToODS_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Export.FormExportDispatch));
        }
        // выгрузка для УЭ
        private void toolMenuItemExportToUE_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Export.FormExportUlenergo));
        }
        // выгрузка в 1С
        private void toolMenuItemExportTo1C_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Export.FormExport1C));
        }
        // выгрузка для МРСК
        private void toolMenuItemExportToMRSK_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Export.FormExportMRSK));
        }
        // Проверки на наличие счет-фактур
        private void toolMenuItemCheckInvoice_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Test.FormTestSchetFact));
        }
        // Сверка данных документа и счета
        private void toolMenuItemCheckDocAndInvoice_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Test.FormTestDocSum));
        }
        // Плановые часы пиковой нагрузки по годам
        private void ToolMenuItemMeasurementsHour_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Meter.FormMeasurementsHour));
        }
        // Отчет по начислениям режимного дня
        private void ToolMenuItemMeasurementsReport_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Calculat.FormReportMeasur));
        }

        //ведомость по признакам (по прямым перетокам)
        private void RepQuantityAbnObjFlagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.FormRep.FormRepQuantityAbnObjFlag));
        }





        #endregion

        #region Reference
        // Общий классификатор
        private void toolStripMenuItemClassifier_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Reference.Forms.FormClassifier));
        }
        // должности работников
        private void toolStripMenuItemJobTitles_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Reference.Forms.FormJobTitles));
        }
        // подразделения
        private void toolStripMenuItemDivisions_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Reference.Forms.FormDivisions));
        }
        // сотрудники
        private void toolStripMenuItemWorkers_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Reference.Forms.FormWorkers));
        }
        private void toolStripMenuItemCounter_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Reference.Forms.FormCounter));
        }
        // справлчник трансформаторов
        private void toolStripMenuItemTransformator_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Reference.Forms.FormTrans));
        }
        // трансформаторы силовые
        private void toolStripMenuItemTransf_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Reference.Forms.FormTrasformer));
        }
        // Муфты
        private void toolMenuItemCoupling_Click(object sender, EventArgs e)
        {
            Reference.Forms.FormEquipment f = new Reference.Forms.FormEquipment(eisSettings.SqlSettings, Constants.EquipmentType.Clutch);
            f.MdiParent = this;
            f.Show();
        }
        // Кабель
        private void toolMenuItemCable_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Reference.Forms.FormCable));
        }
        // КЛАДР
        private void toolStripMenuItemKladrObj_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Reference.Forms.FormKladr));
        }
        // сокр КЛАДР
        private void toolStripMenuItemKladrSocr_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Reference.Forms.FormKladrSocr));
        }
        // группы сотрудников
        private void toolMenuItemGroupWorker_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Reference.Forms.FormGroupWorker));
        }
        // справочник объектов домов
        private void toolStripMenuItemKladrHouse_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Reference.Forms.MapObj.FormMapObj));
        }
        /// <summary> Перечень состояний оборудования паспорта
        /// </summary>
        private void tsmiStateList_Click(object sender, EventArgs e)
        {
            Passport.Forms.StateEquipmentList.FormDocValueList f = new Passport.Forms.StateEquipmentList.FormDocValueList(this.SqlSettings);
            f.Show();
        }
        /// <summary> Характеристики объектов паспорта
        /// </summary>
        private void tsmiPassportChars_Click(object sender, EventArgs e)
        {
            // Открыть форму редактирования характеристик паспорта
            Passport.Forms.PassportChars.FormReferPassportChars frm = new Passport.Forms.PassportChars.FormReferPassportChars(this.SqlSettings, Passport.Classes.TypeCharacteristic.Passport);
            frm.ShowDialog();
            frm.Dispose();
        }
        // контрагенты
        private void toolStripMenuItemKontragent_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Contractor.Forms.FormContactor));
        }
        #endregion

        #region Services Events
        // Пользователи
        private void toolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Services.Forms.FormUsers));
        }
        // Безопасность
        private void toolStripMenuItemSecurity_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Services.Forms.FormSecurityUser));
        }
        // Журнал входа/выхода
        private void toolStripMenuItemLogInOut_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Services.Forms.FormLogInOut));
        }
        #endregion

        #region Scheme
        /// <summary>
        ///  форма общей схемы УльГЭС
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolMenuitemGeneralScheme_Click(object sender, EventArgs e)
        {
            Scheme.Forms.FormGeneralScheme2 f = new Scheme.Forms.FormGeneralScheme2(new DataSql.SQLSettings(eisSettings.SqlSettings));
            f.MdiParent = this;
            f.Show();
        }


        private void toolStripMenuItemNormalSchema_Click(object sender, EventArgs e)
        {
            Scheme.Forms.FormGeneralScheme2 f = new Scheme.Forms.FormGeneralScheme2(new DataSql.SQLSettings(eisSettings.SqlSettings), 2, 0);
            f.MdiParent = this;
            f.Show();
        }
        // Подключится к серверу
        private void toolStripMenuItemConnectToServer_Click(object sender, EventArgs e)
        {
            Uri address = new Uri("net.tcp://" /*eisSettings.SqlSettings.ServerDB*/ + "192.168.1.248" + ":22222/WCFSchemeServer");
            Scheme.Forms.FormGeneralScheme2 f = new Scheme.Forms.FormGeneralScheme2(new DataSql.SQLSettings(eisSettings.SqlSettings),
                new System.ServiceModel.EndpointAddress(address.ToString()), 1);
            f.MdiParent = this;
            f.Show();
        }
        // настройка сообщений телеметрии
        private void toolMenuItemOPCMessageConfig_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Scheme.Forms.OPCMessage.FormOPCMessageConfig));
        }
        // Привязка абонентов к схеме
        private void toolMenuItemLinkCellPoint_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Scheme.Forms.LinkCellPoint.FormLinkCellPoint));
        }
        // Отчет диспетчера
        private void toolMenuItemLogDispatcher_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Scheme.Forms.Reports.FormLogDispatcher));
        }
        #endregion

        #region Passport
        /// <summary> Паспорт подстанции
        /// </summary>
        private void tsmiPassportPS_Click_1(object sender, EventArgs e)
        {
            Passport.Forms.FormDockPassport f = new Passport.Forms.FormDockPassport(this.SqlSettings, Passport.Classes.TypeObjListGroup.Substations);
            f.MdiParent = this;
            f.Show();
        }
        /// <summary> Паспорт кабельных линий
        /// </summary>
        private void tsmiPassportCable_Click(object sender, EventArgs e)
        {
            Passport.Forms.FormDockPassport f = new Passport.Forms.FormDockPassport(this.SqlSettings, Passport.Classes.TypeObjListGroup.CableLines);
            f.MdiParent = this;
            f.Show();
        }
        /// <summary> Паспорт трансформатора
        /// </summary>
        private void tsmiPasspTrans_Click(object sender, EventArgs e)
        {
            Passport.Forms.FormDockPassport f = new Passport.Forms.FormDockPassport(this.SqlSettings, Passport.Classes.TypeObjListGroup.Transformer);
            f.MdiParent = this;
            f.Show();
        }
        /// <summary> Настройки панели паспорта
        /// </summary>
        private void tsmiPassportSettingsPanel_Click(object sender, EventArgs e)
        {
            Passport.FormSettings frm = new Passport.FormSettings(this.SqlSettings, Constants.TypeSettings.PassportPanel);
            frm.ShowDialog();
            frm.Dispose();
        }
        // журнал оборудования
        private void tsmiPassportReports_Click(object sender, EventArgs e)
        {
            Passport.Forms.FormRegistr frm = new Passport.Forms.FormRegistr(this.SqlSettings);
            frm.SqlSettings = this.SqlSettings;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsmiPassportValueLists_Click(object sender, EventArgs e)
        {
            Passport.Forms.PassportChars.FormReferValueLists frm = 
                new Passport.Forms.PassportChars.FormReferValueLists(this.SqlSettings);
            frm.MdiParent = this;
            frm.Show();
        }
        // отчет по отключенным линиям
        private void tsmiReportOffKL_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Passport.Forms.Cable.Report.FormReportOffKL));
        }
        #endregion

        #region Documents
        /// <summary>
        /// Документ расчета потерь
        /// </summary>
        private void toolStripMenuItemCalcLoss_Click(object sender, EventArgs e)
        {
            /*Documents.JurnalForm f = new Documents.JurnalForm();
            f.MdiParent = this;
            f.SqlSettings = new DataSql.SQLSettings(eisSettings.SqlSettings);
            f.Show();*/
        }
        // выгрузка ГРП
        private void toolStripMenuItemUnloadingGRP_Click(object sender, EventArgs e)
        {
            GRP.UnloadingGWC f = new GRP.UnloadingGWC();
            f.MdiParent = this;
            f.SqlSettings = new DataSql.SQLSettings(eisSettings.SqlSettings);
            //f.SqlSettings = eisSettings.SqlSettings;
            f.Show();
        }
        // Журнал задач
        private void toolMenuItemJRequest_Click(object sender, EventArgs e)
        {
            Documents.Forms.JournalRequest.FormJournalRequest f = new Documents.Forms.JournalRequest.FormJournalRequest();
            f.MdiParent = this;
            f.SqlSettings = new DataSql.SQLSettings(eisSettings.SqlSettings);
            f.Show();
        }
        // Наряды
        private void toolMenuItemJOrder_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(Documents.Forms.JournalOrder.FormJournalOrder))
                {
                    if (ActiveMdiChild != null)
                        mdiChild.WindowState = ActiveMdiChild.WindowState;
                    else
                        mdiChild.WindowState = FormWindowState.Normal;
                    mdiChild.Activate();

                    mdiChild.Visible = true;
                    return;
                }
            }

            ShowMdiForm(typeof(Documents.Forms.JournalOrder.FormJournalOrder));
        }
        // Журнал заявок на ремонт
        private void toolMenuItemJRequestForRepair_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Documents.Forms.JournalRequestForRepair.FormJournalRequestForRepair));
        }
        // Уставки РЗА
        private void toolMenuItemJRelayProtectionAutomation_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Documents.Forms.JournalRelayProtectionAutomation.FormJournalRelayProtectionAutomation));
        }
        // Журнал раскопок
        private void toolMenuItemJExcavation_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Documents.Forms.JournalExcavation.FormJournalExcavation));
        }

        #endregion

        #region Bulletins
        // Заявки на ограничение
        private void toolStripMenuItemConnectDisconnect_Click(object sender, EventArgs e)
        {
            Documents.Forms.FormList f = new Documents.Forms.FormList();

            f.MdiParent = this;
            f.SqlSettings = eisSettings.SqlSettings;
            f.Show();
        }
        // отчет ОДС
        private void toolStripMenuItemReportODS_Click(object sender, EventArgs e)
        {
            Documents.Forms.FormODS f = new Documents.Forms.FormODS();
            f.MdiParent = this;
            f.SqlSettings = eisSettings.SqlSettings;
            f.Show();
        }
        #endregion

        private void tsmiCountSwitch_Click(object sender, EventArgs e)
        {
            Passport.Forms.FormPassportCountSwitch frm = new Passport.Forms.FormPassportCountSwitch(this.SqlSettings);
            frm.MdiParent = this;
            frm.Show();
        }
        // Журнал обновлений
        private void toolMenuItemUpdateProgram_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Documents.Forms.JournalUpdateProgram.FormJournalUpdateProgram));
        }

        private void tsmiPassportDoc_Click(object sender, EventArgs e)
        {
            FormDocValueList frm = new FormDocValueList(this.SqlSettings);
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MemoryManagement.SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
        }
        // Обновления
        private void toolMenuItemUpdates_Click(object sender, EventArgs e)
        {
            FormUpdateSettings f = new FormUpdateSettings();
            f.UpdateSettings = eisSettings.UpdateSettings;
            f.MdiParent = this;
            f.Show();
        }

        private void tsmiImportoldTransf_Click(object sender, EventArgs e)
        {
            FormImportOldTransf frm = new FormImportOldTransf();
            frm.SqlSettings = this.SqlSettings;
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolMenuItemDocScan_Click_1(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Document.FormDocScan));
        }

        private void toolMenuItemPrintDocAbn_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.FormRep.FormRepUniversal));
        }

        private void ToolStripMenuItemImportMatritca_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Prv.Forms.Exchange.FormMatritca));
        }

        // госсектор документы ---->  Журнал распоряжений
        private void ToolMenuItemJournalOrdersInspection_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Document.FormJournalOrdersInspection));
        }

        private void toolStripMenuItemFL_Click(object sender, EventArgs e)
        {

        }

        private void контрагентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consumer.Forms.AbnFastTree frm = new Consumer.Forms.AbnFastTree();
            ((Form)frm).MdiParent = (Form)this;
            frm.SqlSettings = this.eisSettings.SqlSettings;
            frm.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            frm.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            ((Control)frm).Show();
        }

        #region Функции открытия форм
        // открытие формы в родительском окне
        // надо добавить поиск уже открытого окна
        private void ShowMdiForm(System.Type typeForm, params object[] args)
        {
            FormBase formBase = (FormBase)null;
            try
            {
                formBase = (FormBase)Activator.CreateInstance(typeForm, args);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message + (object)ex.InnerException != null ? "\r\n" + ex.InnerException.Message : "", ex.Source + " (Вызов формы)");
            }
            if (formBase == null)
                return;
            ((Form)formBase).MdiParent = (Form)this;
            formBase.SqlSettings = this.eisSettings.SqlSettings;
            formBase.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            formBase.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            ((Control)formBase).Show();
        }

        private FormBase form_ShowForm(object sender, ShowFormEventArgs e)
        {
            FormBase formBase = (FormBase)null;
            try
            {
                formBase = (FormBase)Activator.CreateInstance(System.Type.GetType(e.TypeForm), e.Param);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, ex.Source);
            }
            if (formBase == null)
                return (FormBase)null;
            e.Form = formBase;
            if (e.FormMode == eFormMode.Mdi)
                ((Form)formBase).MdiParent = (Form)this;
            if (e.SQLSettings != null)
                formBase.SqlSettings = e.SQLSettings;
            else
                formBase.SqlSettings = this.eisSettings.SqlSettings;
            formBase.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            switch ((int)e.FormMode)
            {
                case 0:
                    e.DialogResult = ((Form)formBase).ShowDialog();
                    break;
                case 1:
                    (formBase).Show();
                    break;
                case 2:
                    if (formBase is DockContentBase && e.DockPanel != null && e.DockPanel is DockPanel)
                    {
                        ((DockContentBase)formBase).Show((DockPanel)e.DockPanel);
                        break;
                    }
                    (formBase).Show();
                    break;
            }
            return formBase;
        }

        private void f_GoToSchema(object sender, GoToSchemaEventArgs e)
        {
            foreach (Form mdiChild in ((Form)this).MdiChildren)
            {
                if (mdiChild.GetType() == typeof(FormGeneralScheme2))
                {
                    if (!((FormGeneralScheme2)mdiChild).SetObjectsInCenterScreen(e.IdObjList))
                        return;
                    mdiChild.WindowState = ((Form)this).ActiveMdiChild == null ? FormWindowState.Normal : ((Form)this).ActiveMdiChild.WindowState;
                    mdiChild.Activate();
                    mdiChild.Visible = true;
                    return;
                }
            }
            int num = (int)MessageBox.Show("Для начала нужно открыть схему");
        }

        #endregion

        private void журналАбонентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.ShowMdiForm(typeof(Abonent.FormJournalAbnN2));
        }

        private void поискАбонентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbnFind fFind = new FormAbnFind();
            fFind.SqlSettings = this.SqlSettings;
            //fFind.MdiParent = this.MdiParent;
            if (fFind.ShowDialog() == DialogResult.OK)
            {
                if (fFind.SelectedTypeAbn == Constants.Constants.TypeAbnLegal
                    || fFind.SelectedTypeAbn == Constants.Constants.TypeAbnNet
                    || fFind.SelectedTypeAbn == Constants.Constants.TypeAbnSale)
                {
                    //FormLbr.Classes.ShowFormEventArgs eShow = new FormLbr.Classes.ShowFormEventArgs();
                    //eShow.TypeForm = "Legal.Forms.FormAbn, Legal";
                    //eShow.FormMode = FormLbr.Classes.eFormMode.Mdi;
                    //eShow.Param = new object[2];
                    //eShow.Param[0] = fFind.SelectedAbonent;
                    //eShow.Param[1] = fFind.SelectedObj;
                    //eShow.SQLSettings = this.SqlSettings;
                    //this.OnShowForm(eShow);

                    FormAbn frm = new FormAbn(fFind.SelectedAbonent, fFind.SelectedObj);
                    frm.SqlSettings = this.SqlSettings;
                    frm.MdiParent = this;

                    frm.Show();

                }
                if (fFind.SelectedTypeAbn == Constants.Constants.TypeAbnPrivate
                    || fFind.SelectedTypeAbn == Constants.Constants.TypeAbnPrivateNoDog)
                {
                    Prv.Forms.Abonent.FormAbonent frm = new Prv.Forms.Abonent.FormAbonent(fFind.SelectedAbonent, fFind.SelectedTypeAbn);
                    frm.SqlSettings = this.SqlSettings;
                    frm.MdiParent = this;

                    frm.Show();
                }

            }

        }

        private void AsocaMetersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(typeof(Legal.Forms.Meter.FormASOCAMeters));
        }






    }
    // НАЗЫВАЙТЕ МЕНЮШКИ НОРМАЛЬНО!!!!!  НЕХЕР ПЕРЕМЕШИВАТЬ РУССКИЕ С АНГЛИЙСКИМИ

    public class MemoryManagement
    {
        [DllImport("kernel32.dll")]
        public static extern bool SetProcessWorkingSetSize(IntPtr proc, int min, int max);

        public void FlushMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
    }
}
