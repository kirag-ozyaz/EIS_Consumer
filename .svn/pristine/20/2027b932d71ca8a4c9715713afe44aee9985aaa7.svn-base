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
    public partial class FormContractorNew : FormLbr.FormBase
    {
        private Cache memoryCache;

        public FormContractorNew()
        {
            InitializeComponent();
            dgv.DataSource = null;
        }

        private void FormContractorNew_Load(object sender, EventArgs e)
        {

            LoadData();

            try
            {
                DataRetriever retriever =
                    new DataRetriever(this.SqlSettings.GetConnectionString(), ds.vAbn.TableName);
                memoryCache = new Cache(retriever, 16);
                this.dgv.RowCount = retriever.RowCount;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Connection could not be established. " +
                    "Verify that the connection string is valid.");

            }
        }

        private void dataGridViewExcelFilter1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {

            
            e.Value = memoryCache.RetrieveElement(e.RowIndex, e.ColumnIndex);
        }

        private void LoadData()
        {
            //DataSql.SqlDataConnect sqlCon = new DataSql.SqlDataConnect();
            //sqlCon.OpenConnection(SqlSettings);
            //this.SelectSqlData(ds, ds.vAbn, true, "order by id", 100);
            dataGridViewExcelFilter2.DataSource = null;
            bWork.RunWorkerAsync();
        }


        private void Ver1()
        {
            DataSql.SqlDataConnect sqlCon = new DataSql.SqlDataConnect();
            sqlCon.OpenConnection(SqlSettings);

            string sql = "select * from vAbn where id not in (select top 100 id from vAbn order by id) order by id";
            using (SqlCommand command1 = new SqlCommand(sql, sqlCon.Connection))
            {
                SqlDataReader dataReader1 = command1.ExecuteReader();
                int count = 0;
                DataSets.DataSetCont.vAbnDataTable dt = new DataSets.DataSetCont.vAbnDataTable();
                while (dataReader1.Read())
                {
                    //DataRow  newRow = ds.vAbn.NewRow();
                    //foreach (DataColumn col in ds.vAbn.Columns)
                    //{

                    //    newRow[col.ColumnName] = dataReader1[col.ColumnName];
                    //}
                    //this.BeginInvoke(new MethodInvoker(() => ds.vAbn.Rows.Add(newRow)));


                    DataRow newRow = dt.NewRow();
                    foreach (DataColumn col in dt.Columns)
                    {
                        newRow[col.ColumnName] = dataReader1[col.ColumnName];
                    }
                    dt.Rows.Add(newRow);
                    //this.BeginInvoke(new MethodInvoker(() => ds.vAbn.Rows.Add(newRow)));
                    count++;
                    if (count > 100)
                    {
                        this.BeginInvoke(new MethodInvoker(() => dataGridViewExcelFilter2.DataSource = null));
                        foreach (DataRow r in dt.Rows)
                        {
                            DataRow newRow1 = ds.vAbn.NewRow();
                            foreach (DataColumn col in dt.Columns)
                            {
                                newRow1[col.ColumnName] = r[col.ColumnName];
                            }
                            //dt.Rows.Add(newRow);


                            this.BeginInvoke(new MethodInvoker(() => ds.vAbn.Rows.Add(newRow1)));

                        }
                        this.BeginInvoke(new MethodInvoker(() => dataGridViewExcelFilter2.DataSource = bsAbn));
                        //foreach (DataRow r in dt.Rows)
                        //this.BeginInvoke(new MethodInvoker(() => ds.vAbn.ImportRow(r)));
                        count = 0;
                        dt.Clear();
                    }
                }
                dataReader1.Close();

            }             
        }
        private void Ver2()
        
        {
            this.SelectSqlData(ds,ds.vAbn,true, " order by id");
            /*int page = 10000;
            int position = 100;

            DataSql.SqlDataConnect sqlCon = new DataSql.SqlDataConnect();
            sqlCon.OpenConnection(SqlSettings);
            while (true)
            {
                string sql = "select top " + page.ToString() + " * from vAbn where " + 
                    " id not in (select top " + position.ToString() + " id from vAbn order by id) order by id";

                SqlDataAdapter adapt = new SqlDataAdapter(sql, sqlCon.Connection);

                int cR = ds.vAbn.Rows.Count;
                //this.BeginInvoke(new MethodInvoker(() => adapt.Fill(ds.vAbn)));
                //if (cR == ds.vAbn.Rows.Count) break;
                position += page;
                //adapt.Fill(ds.vAbn);
            }*/


        }

        private void bWork_DoWork(object sender, DoWorkEventArgs e)
        {
            //Ver1();
            Ver2();
            
        }

        private void bWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //ds.vAbn.Rows.Add((DataRow)e.UserState);
        }

        private void bWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int idx = dgv.FirstDisplayedScrollingRowIndex;
            int id = -1;
            if (dgv.CurrentRow != null)
                id = Convert.ToInt32(dgv.CurrentRow.Cells[idDgvColumn.Name].Value);
            dgv.CellValueNeeded -= dataGridViewExcelFilter1_CellValueNeeded;
            dgv.DataSource = bsAbn;
            dataGridViewExcelFilter2.DataSource = bsAbn;
            dgv.SearchGrid(idDgvColumn.Name, id.ToString());
            dgv.FirstDisplayedScrollingRowIndex = idx;
        }

        private void dataGridViewExcelFilter2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void dataGridViewExcelFilter1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
