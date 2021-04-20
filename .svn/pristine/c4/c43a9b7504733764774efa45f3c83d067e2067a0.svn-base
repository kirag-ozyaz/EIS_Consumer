using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormLbr.Classes;

namespace EIS.Forms
{
    public partial class FormConnect : Form
    {
        public DataSql.SQLSettings SqlSetting
        {
            get 
            {
                DataSql.SQLSettings currSettings = new DataSql.SQLSettings();
                currSettings.ServerDB = textBoxServer.Text;        // сервер
                currSettings.DBName = textBoxDbName.Text;           // имя БД
                if (comboBoxAuthentication.SelectedIndex == 0)     // аутентификация
                    currSettings.Autentification = "WINDOWS";
                else
                    currSettings.Autentification = "SQL";

                currSettings.SqlUserConnect = textBoxUser.Text;    // пользователь
                currSettings.SqlPasswConnect = textBoxPassw.Text;  // пароль

                return currSettings;
            }
        }

        private EISSettings currentKWTSettings;

        #region Constructors
        // Конструктор формы
        public FormConnect()
        {
            InitializeComponent();
            currentKWTSettings = new EISSettings();

            textBoxUser.Enabled = false;
            textBoxPassw.Enabled = false;
        }

        // Конструктор формы
        public FormConnect(DataSql.SQLSettings sqlSettings)
        {
            InitializeComponent();

            textBoxServer.Text = sqlSettings.ServerDB;  // имя сервера БД
            textBoxDbName.Text = sqlSettings.DBName;    // имя БД
            // Аутентификация
            if (sqlSettings.Autentification.ToUpper() == "WINDOWS")
                comboBoxAuthentication.SelectedIndex = 0;   // виндовая аутентификация
            else
                comboBoxAuthentication.SelectedIndex = 1;   // sql аутентификация
            textBoxUser.Text = sqlSettings.SqlUserConnect;       // пользователь
            textBoxPassw.Text = sqlSettings.SqlPasswConnect;     // пароль
        }
        #endregion

        // Смена аутентификации
        private void comboBoxAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxUser.Enabled = (comboBoxAuthentication.SelectedIndex == 0) ? false : true;
            textBoxPassw.Enabled = (comboBoxAuthentication.SelectedIndex == 0) ? false : true;
        }

        // Принятие соединения
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.comboBoxAuthentication.SelectedIndex == 0) // аутентификация windows
            {
                DataSql.SqlDataConnect sqlAccess = new DataSql.SqlDataConnect();

                if (!sqlAccess.CheckConnection(textBoxServer.Text, textBoxDbName.Text))
                    this.DialogResult = DialogResult.None;
            }
            else  //  if (this.comboBoxAuthentication.SelectedIndex == 1) // sql-аутентификация 
            {
                DataSql.SqlDataConnect sqlAccess = new DataSql.SqlDataConnect();

                if (!sqlAccess.CheckConnection(textBoxServer.Text, textBoxDbName.Text,
                                            textBoxUser.Text, textBoxPassw.Text))
                    this.DialogResult = DialogResult.None;
            }
        }

    }
}
