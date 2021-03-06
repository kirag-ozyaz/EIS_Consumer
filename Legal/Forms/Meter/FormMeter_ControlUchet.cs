using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ControlsLbr;
using FormLbr.Classes;
using Library;
using Microsoft.Office.Interop.Excel;



namespace Legal.Forms.Meter 
{
    public partial class FormMeter_ControlUchet : FormLbr.FormBase
    {
        public FormMeter_ControlUchet()
        {
            InitializeComponent();
        }

        private void FormMeter_ControlUchet_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsDop1, dsDop1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsDop1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsDop1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsDop1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsDop1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);
            //dtBegin.Value = new DateTime(DateTime.Today.Year, 1, 1);
            //dtEnd.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month + 1, 1).AddDays(-1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dsDop1.tMeter_ControlUchet.Rows.Clear();
            // получаем данные по начислениям
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";

                strCmd = "select * from [fn_LegMeter_ControlUchet](@DateBegin, @DateEnd) order by codeabonent";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                DateTime DateEnd = (DateTime)dtEnd.Value.Date;

                SqlParameter p1 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsDop1, "tMeter_ControlUchet");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void ExportToExcel()
        {
            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            exApp.Visible = true;
            exApp.Workbooks.Add();
            Worksheet workSheet = (Worksheet)exApp.ActiveSheet;

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                workSheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        workSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        workSheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

    }
}
