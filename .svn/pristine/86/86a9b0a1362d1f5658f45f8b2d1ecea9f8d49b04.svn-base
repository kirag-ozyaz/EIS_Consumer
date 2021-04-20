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
    public partial class FormDebControllers : FormLbr.FormBase
    {
        public FormDebControllers()
        {
            InitializeComponent();

            for (int i = DateTime.Today.Year; i >= 2009; i--)
                toolStripComboBoxPeriod.Items.Add(i);
            toolStripComboBoxPeriod.SelectedIndex = toolStripComboBoxPeriod.FindString(DateTime.Today.Year.ToString());


        }

        private void FormDebControllers_Load(object sender, EventArgs e)
        {

            this.rvContDeb.RefreshReport();
        }

        private void LoadRepDate()
        {

            DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
            try
            {

                sql.OpenConnection(this.SqlSettings);

                dsRep.Tables["fn_PrvControllerDeb"].Clear();

                string select = "select * from dbo.fn_PrvControllerDeb(@date)";
                string date = toolStripComboBoxPeriod.SelectedItem.ToString()+ ".01.01";

                SqlCommand sqlCmd = new SqlCommand(select, sql.Connection);

                sqlCmd.Parameters.Add("@Date", SqlDbType.SmallDateTime);
                sqlCmd.Parameters["@Date"].Value = Convert.ToDateTime(date);

                sqlCmd.CommandTimeout = 600;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsRep, "fn_PrvControllerDeb");

                this.rvContDeb.RefreshReport();


            }
            catch (Exception ex) // Если ошибка
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {   // В любом случае коннект надо закрыть
                sql.CloseConnection();
            }

           
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            LoadRepDate();
        }

    }
}
