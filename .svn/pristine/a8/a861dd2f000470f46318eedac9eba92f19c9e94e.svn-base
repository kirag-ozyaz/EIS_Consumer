using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Prv.Forms.Reports 
{
     

    public partial class FormRepActJournal : FormLbr.FormBase
    {
        private DateTime DateBeg, DateEnd;

        public FormRepActJournal()
        {
            InitializeComponent();
        }

        public FormRepActJournal(DateTime datebeg, DateTime datebend)
        {
            InitializeComponent();
            DateBeg = datebeg ;
            DateEnd = datebend;

        }


        private void FormRepActJournal_Load(object sender, EventArgs e)
        {
            string where = " where DateCheck >= '" + DateBeg.ToString("yyyyMMdd") +"' and DateCheck <= '" + DateEnd.ToString("yyyyMMdd") +"' ";
            this.SelectSqlData(dsRep, dsRep.vPrv_JournalAct, true, where);
            this.reportViewer1.RefreshReport();
        }
    }
}
