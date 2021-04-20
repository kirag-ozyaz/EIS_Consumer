using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using ControlsLbr;


namespace Legal.Forms.FormRep
{
    public partial class FormRepPowerVolume : FormLbr.FormBase
    {
        public FormRepPowerVolume()
        {
            InitializeComponent();
        }

        private void FormRepPowerVolume_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsCalc1, dsCalc1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);
        }

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

        private void btnReport_Click(object sender, EventArgs e)
        {

            dsCalc1.tG_ReportPowerVolume.Rows.Clear();

            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";

                strCmd = "select * from fn_LegReportPowerVolume (@DateBegin, @DateEnd) order by CodeAbonent";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                DateTime DateEnd = (DateTime)dtEnd.Value.Date;

                SqlParameter p1 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCalc1, "tG_ReportPowerVolume");
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            dgv.ExportToExcel();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
