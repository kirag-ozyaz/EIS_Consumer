using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prv.Forms.Reports
{
    public partial class FormActMeterDemUst : FormLbr.FormBase
    {
        public FormActMeterDemUst()
        {
            InitializeComponent();
        }


        private void FormActMeterDemUst_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Date.Year;
            dtBegin.Value = new DateTime(year, 1, 1);
            dtEnd.Value = new DateTime(year, 12, 31);
            this.rvMeterDemUst.RefreshReport();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {

            CreateRep();
        }

        private void CreateRep()
        {
            DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
            try
            {

                sql.OpenConnection(this.SqlSettings);

                dsRep.Tables["fn_Prv_MeterUstDem"].Clear();

                string select = "select * from dbo.fn_Prv_MeterUstDem( @dateBeg , @dateEnd )  order by CodeAbonent,datebegin,dateend";
                
                SqlCommand sqlCmd = new SqlCommand(select, sql.Connection);

                sqlCmd.Parameters.Add("@dateBeg", SqlDbType.SmallDateTime);
                sqlCmd.Parameters["@dateBeg"].Value = Convert.ToDateTime(dtBegin.Value.Date);

                sqlCmd.Parameters.Add("@dateEnd", SqlDbType.SmallDateTime);
                sqlCmd.Parameters["@dateEnd"].Value = Convert.ToDateTime(dtEnd.Value.Date);
               
                sqlCmd.CommandTimeout = 600;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsRep, "fn_Prv_MeterUstDem");

                this.rvMeterDemUst.RefreshReport();


            }
            catch (Exception ex) // Если ошибка
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {   // В любом случае коннект надо закрыть
                sql.CloseConnection();
            }
        }

    }
}
