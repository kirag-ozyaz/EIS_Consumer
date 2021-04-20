using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Legal.Forms.Calculat
{
    public partial class FormAvans : FormLbr.FormBase
    {
        public FormAvans()
        {
            InitializeComponent();
        }

        #region загрузка источников данных

        private void FormAvans_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsDop1, dsDop1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsDop1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsDop1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsDop1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsDop1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);

            numProcent.Value = 50;

            dtBank.Value = new DateTime((int)dsDop1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsDop1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);
            // загрузка банковских дней
            InitCmbDays();

            // виды платежа
            f_PaymentSelect_Load();
            f_Payment.Text = f_PaymentSelect.Text + ", за " + dtEnd.Value.ToString("MMMM") + " " + dtEnd.Value.Date.Year + "г.";

            // документы по тарифам
            f_TariffLegal_Load();

            rbtn_PlanVolume.Checked = true;
            rbtn_Contract.Checked = true;


            for (DateTime d_c = dtBegin.Value.AddYears(-1); d_c < dtBegin.Value;
                d_c = d_c.AddMonths(1))
            {
            cmbSelectVolume.Items.Add(d_c.ToString("MMMM yyyy"));

            }
            cmbSelectVolume.SelectedIndex = 0;

        }

        // загрузка видов платежа
        private void f_PaymentSelect_Load()
        {
            int idType = 560;
            SelectSqlData(dsDop1, dsDop1.tR_Classifier, true, " where ParentID = " + idType.ToString());
            f_PaymentSelect.SelectedValue = 561;
        }

        // загрузка оснований
        private void f_TariffLegal_Load()
        {
            int idType = 565;
            SelectSqlDataTableOther(dsDop1, dsDop1.tR_Classifier1, "tR_Classifier", true, " where ParentID = " + idType.ToString() + "order by id desc");
        }

        // загрузка банковских дней
        private void InitCmbDays()
        {
            DataTable dt = new DataTable("tG_Doc_Avans");
            dt.Columns.Add("dtBank", typeof(DateTime));

            cbxDays.DataSource = dt;
            cbxDays.DisplayMember = "dtBank";
            cbxDays.ValueMember = "dtBank";

            this.SelectSqlData(dt, true, " order by dtBank desc", null, true);
        }

        #endregion

        #region интерфейс

        private void btnPlus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(1).AddDays(-1);
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(-1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(-1).AddDays(-1);
        }

        // выберем всех потребителей
        private void btnCheck_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < dgvDocList.RowCount; i++) {
                dgvDocList.Rows[i].Cells["SelectCell"].Value = true;
            }
            Cursor.Current = Cursors.Default;
        }
        // отменим выбор
        private void btnUncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDocList.RowCount; i++) {
                dgvDocList.Rows[i].Cells["SelectCell"].Value = false;
            }
        }

        // завершить редактирование ячейки
        private void dgvDocList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvDocList.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        #endregion

        #region расчет аванса

        // фильтр для даты
        private string BuildWhereDate()
        {
            string txtWhereDate = "";
            if (txtWhereDate != "")
                txtWhereDate += " and (dtPay >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                    " (dtPay <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            else
                txtWhereDate += " (dtPay >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                    " (dtPay <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            txtWhereDate += " or dtPay is null";
            return txtWhereDate;
        }

        // рассчитаем аванс
        private void btnCalcAvans_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            DateTime DateBank = (DateTime)dtBank.Value.Date;
            DateTime dtPay = (DateTime)dtEnd.Value.Date;
            DateTime dtSelectVolume = Convert.ToDateTime(cmbSelectVolume.SelectedItem);

            var IsDoc = 0;
            int idDoc = 0;
            string Payment = f_Payment.Text;
            int Base = (int)f_TariffLegal.SelectedValue;
            int metod = 0;
            if (rbtn_PlanVolume.Checked)
                metod = 1;
            else
                metod = 2;

            for (int i = 0; i < dgvDocList.RowCount; i++) {
                if (dgvDocList.Rows[i].Cells["SelectCell"].Value != null) {
                    if ((bool)dgvDocList.Rows[i].Cells["SelectCell"].Value == true) {
                        DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                        try {
                            con.OpenConnection(SqlSettings);
                            string strCmd = "";
                            strCmd = "sp_LegDocSave_Avans";
                            SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                            sqlCmd.CommandType = CommandType.StoredProcedure;

                            SqlParameter p1 = new SqlParameter("@percent", numProcent.Value);
                            sqlCmd.Parameters.Add(p1);

                            SqlParameter p2 = new SqlParameter("@metod", metod);
                            sqlCmd.Parameters.Add(p2);

                            if (dgvDocList.Rows[i].Cells["idDoc"].Value == DBNull.Value)
                                idDoc = 0;
                            else
                                idDoc = Convert.ToInt32(dgvDocList.Rows[i].Cells["idDoc"].Value);

                            SqlParameter p3 = new SqlParameter("@idDoc", idDoc);
                            sqlCmd.Parameters.Add(p3);

                            int idAbn = Convert.ToInt32(dgvDocList.Rows[i].Cells["idAbn"].Value);
                            SqlParameter p4 = new SqlParameter("@idAbn", idAbn);
                            sqlCmd.Parameters.Add(p4);

                            int idList = Convert.ToInt32(dgvDocList.Rows[i].Cells["idDogovor"].Value);
                            SqlParameter p5 = new SqlParameter("@idList", idList);
                            sqlCmd.Parameters.Add(p5);

                            SqlParameter p6 = new SqlParameter("@dtPay", dtPay);
                            sqlCmd.Parameters.Add(p6);

                            SqlParameter p7 = new SqlParameter("@DateBank", DateBank);
                            sqlCmd.Parameters.Add(p7);

                            SqlParameter p8 = new SqlParameter("@Payment", Payment);
                            sqlCmd.Parameters.Add(p8);

                            SqlParameter p9 = new SqlParameter("@Base", Base);
                            sqlCmd.Parameters.Add(p9);

                            SqlParameter p10 = new SqlParameter("@dtSelectVolume", dtSelectVolume);
                            sqlCmd.Parameters.Add(p10);

                            if (dgvDocList.Rows[i].Cells["idDoc"].Value != DBNull.Value)
                                IsDoc = 1;
                            SqlParameter p11 = new SqlParameter("@IsDoc", IsDoc);
                            sqlCmd.Parameters.Add(p11);

                            sqlCmd.CommandTimeout = 0;
                            sqlCmd.ExecuteNonQuery();
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.Message, ex.Source);
                        }
                        finally {
                            con.CloseConnection();
                        }
                    }
                }
            }
            dgvLoad();
            dgvDocList.Refresh();
            // загрузка банковских дней
            InitCmbDays();

            Cursor.Current = Cursors.Default;

        }

        // функция которая показывает всех потребителей с авансами за период
        private void dgvLoad()
        {
            string txtWhereDate = BuildWhereDate();

            if (rbtn_Contract.Checked)
                SelectSqlData(dsDop1, dsDop1.vG_DocAvans, true, "where " + txtWhereDate + " and BankID = 1317 order by codeabonent");
            else if (rbtn_Other.Checked)
                SelectSqlData(dsDop1, dsDop1.vG_DocAvans, true, "where " + txtWhereDate + " and BankID <> 1317 order by codeabonent");
            else
                SelectSqlData(dsDop1, dsDop1.vG_DocAvans, true, "where " + txtWhereDate + " order by codeabonent");
        }

        // покажем всех потребителей с авансами за период
        private void btnView_Click(object sender, EventArgs e)
        {
            dgvLoad();
        }

        #endregion

        #region формирование и печать счетов

        // формирование печатных форм счетов
        private void btnPrintAvans_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            // удалим все печатные формы за выбранный банковский день
            DelDocPrint();
            int idDoc = 0;

            for (int i = 0; i < dgvDocList.RowCount; i++) {
                if (dgvDocList.Rows[i].Cells["SelectCell"].Value != null) {
                    if ((bool)dgvDocList.Rows[i].Cells["SelectCell"].Value == true) {
                        DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                        try {
                            con.OpenConnection(SqlSettings);
                            string strCmd = "";
                            strCmd = "LegPrint_Avans";
                            SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                            sqlCmd.CommandType = CommandType.StoredProcedure;

                            idDoc = Convert.ToInt32(dgvDocList.Rows[i].Cells["idDoc"].Value);
                            SqlParameter p1 = new SqlParameter("@idDocum", idDoc);
                            sqlCmd.Parameters.Add(p1);

                            sqlCmd.CommandTimeout = 0;
                            sqlCmd.ExecuteNonQuery();
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.Message, ex.Source);
                        }
                        finally {
                            con.CloseConnection();
                        }
                    }
                }
            }
            Cursor.Current = Cursors.Default;
            dgvLoad();
            dgvDocList.Refresh();
        }

        // посмотреть все счета с авансами за выбранный день
        private void btnPrintSchet_Click(object sender, EventArgs e)
        {
            DateTime BANKDAY = (DateTime)cbxDays.SelectedValue;
            Legal.Forms.FormSchetPrint frm = new Legal.Forms.FormSchetPrint(BANKDAY);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK) { }
        }

        // удалить все счета за выбранный день
        private void DelDocPrint()
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try {
                con.OpenConnection(SqlSettings);
                string strCmd = "";
                strCmd = "LegDocPrintDelete1";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                DateTime DateBank = (DateTime)cbxDays.SelectedValue;
                SqlParameter p = new SqlParameter("@DateBank", DateBank.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p);

                sqlCmd.CommandTimeout = 0;
                Cursor.Current = Cursors.WaitCursor;
                sqlCmd.ExecuteNonQuery();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, ex.Source);
            } 
            finally {
                con.CloseConnection();
            }
        }

        #endregion
    }
}
