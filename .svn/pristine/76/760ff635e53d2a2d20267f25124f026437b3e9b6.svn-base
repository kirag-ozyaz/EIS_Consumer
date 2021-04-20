using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Object
{
    public partial class FormAbnObjPoint : FormLbr.FormBase
    {
        public FormAbnObjPoint()
        {
            InitializeComponent();
        }

        private void FormAbnObjPoint_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsDop1, dsDop1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsDop1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsDop1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsDop1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsDop1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            string txtWhereDate = BuildWhereDate();
            SelectSqlData(dsDop1, dsDop1.vG_AbnObjPoint_Voltage, true, "where " + txtWhereDate + " order by Dogovor");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            this.dgvList.ExportToExcel();
        }
    }
}
