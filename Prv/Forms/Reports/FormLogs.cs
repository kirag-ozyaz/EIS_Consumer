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
    public partial class FormLogs : FormLbr.FormBase
    {
        private int CodeAbn,idPoint;

        private int GetIdFromNodeTag(System.Object tag)
        {
            string stTag = tag.ToString();

            if (stTag.IndexOf("All") >= 0) // all
                return -1;
            if (stTag.IndexOf("Table") >= 0) // 
                return Convert.ToInt32(stTag.Substring(6));

            return -1;
        }


        public FormLogs()
        {
            InitializeComponent();
        }

        public FormLogs(int idA, int idP)
        {
            InitializeComponent();
            CodeAbn = idA;
            idPoint = idP;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogs_Load(object sender, EventArgs e)
        {
            tbCode.Text = CodeAbn.ToString();
            cmbGroup.SelectedIndex = 0;
            treeViewTable_Load(null);
        }


        private void treeViewTable_Load(TreeNode selNode)
        {
            // устанавливаем расчетный период
            //SelectSqlData(dsRep, dsRep.tG_PeriodCalc, true);
            //dtBegin.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            //dtEnd.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);
            SelectSqlData(dsRep, dsRep.tAbn, true, " where TypeAbn in (206)");

            dtBegin.Value = new DateTime(DateTime.Now.Date.Year, 1, 1);
            dtEnd.Value = new DateTime(DateTime.Now.Date.Year, 12, 31);

            treeViewTable.Nodes.Clear();
            //treeViewTable.

            TreeNode root = new TreeNode("Таблицы");
            root.Tag = "All";
            treeViewTable.Nodes.Add(root);

            if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(root.Tag)))
            {   // выделяем элемент, если надо
                treeViewTable.SelectedNode = root;
                treeViewTable.SelectedNode.Expand();
            }
            this.SelectSqlData(dsRep, dsRep.vPrv_LogsTable, true, " order by COLUMN_NAME");
            foreach (DataRow dr in dsRep.vPrv_LogsTable.Rows)
            {
                TreeNode nodeTable = new TreeNode();
                nodeTable.Text = dr["TABLE_NAME"].ToString().Substring(9);
                nodeTable.Tag = "Table" + dr["COLUMN_NAME"].ToString();
                root.Nodes.Add(nodeTable);

                if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(nodeTable.Tag)))
                {   // выделяем элемент, если надо
                    treeViewTable.SelectedNode = nodeTable;
                    treeViewTable.SelectedNode.Expand();
                }
            }
            treeViewTable.Nodes[0].Expand();
            treeViewTable.Nodes[0].Checked = false;
            treeViewTable.SelectedNode = treeViewTable.Nodes[0];
        }


        // загрузка данных в грид
        private void LoadLogView()
        {
            this.Cursor = Cursors.WaitCursor;

            this.dataGridView1.Columns.Clear();

            DataTable dt = new DataTable("dtLog");
            if (treeViewTable.SelectedNode != null)
            {
                string nameView = treeViewTable.SelectedNode.Text;

                SelectSqlData(dsRep, dsRep.vListColumns, true, " where TABLE_NAME = 'Prv_Logs_" + nameView + "'");

                for (int i = 0; i < dsRep.vListColumns.Rows.Count - 1; i++)
                {
                    string colName = dsRep.vListColumns.Rows[i]["COLUMN_NAME"].ToString();
                    string colType = dsRep.vListColumns.Rows[i]["DATA_TYPE"].ToString();

                    switch (colType)
                    {
                        case "int":
                            dt.Columns.Add(new DataColumn(colName, typeof(int)));
                            break;
                        case "varchar":
                            dt.Columns.Add(new DataColumn(colName, typeof(string)));
                            break;
                        case "nvarchar":
                            dt.Columns.Add(new DataColumn(colName, typeof(string)));
                            break;
                        case "datetime":
                            dt.Columns.Add(new DataColumn(colName, typeof(DateTime)));
                            break;
                        case "smalldatetime":
                            dt.Columns.Add(new DataColumn(colName, typeof(DateTime)));
                            break;
                        case "float":
                            dt.Columns.Add(new DataColumn(colName, typeof(decimal)));
                            break;
                        case "decimal":
                            dt.Columns.Add(new DataColumn(colName, typeof(decimal)));
                            break;
                        case "bit":
                            dt.Columns.Add(new DataColumn(colName, typeof(int)));
                            break;
                        case "varbinary":
                            dt.Columns.Add(new DataColumn(colName, typeof(int)));
                            break;
                        case "tinyint":
                            dt.Columns.Add(new DataColumn(colName, typeof(int)));
                            break;
                        case "money":
                            dt.Columns.Add(new DataColumn(colName, typeof(decimal)));
                            break;
                        case "default":
                            dt.Columns.Add(new DataColumn(colName, typeof(string)));
                            break;
                    }
                }

                // заполняем данными
                string txtWhere = "";
                txtWhere += " (Дата >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                    " (Дата <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";

                if (tbCode.Text.Trim().Length > 0)
                {
                    int n;
                    if (int.TryParse(tbCode.Text, out n))
                    {
                        string filterStr = "CodeAbonent = " + tbCode.Text;
                        DataRow[] makes = dsRep.tAbn.Select(filterStr);
                        if (makes.Length != 0)
                        {
                            DataRow temp = makes[0];
                            tbName.Text = temp["Name"].ToString();
                            txtWhere += " and Код = " + tbCode.Text;
                        }
                    }
                }


                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "sp_Log";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    nameView = "[GES_log].[dbo].[Prv_Logs_" + nameView + "]";
                    SqlParameter p1 = new SqlParameter("@nameView", nameView);
                    sqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter("@txtWhere", txtWhere);
                    sqlCmd.Parameters.Add(p2);

                    sqlCmd.CommandTimeout = 0;

                    SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                    dAdapt.Fill(dt);

                    dataGridView1.Columns.Clear();

                    if (cmbGroup.SelectedIndex == 0)
                    {
                        for (int i = 0; i < dsRep.vListColumns.Rows.Count - 1; i++)
                        {
                            DataGridViewColumn ID = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
                            ID.Name = dsRep.vListColumns.Rows[i]["COLUMN_NAME"].ToString();
                            dataGridView1.Columns.Add(ID);
                            ID.DataPropertyName = dsRep.vListColumns.Rows[i]["COLUMN_NAME"].ToString();
                        }
                        BindingSource bds = new BindingSource();
                        bds.DataSource = dt;
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = bds;
                    }
                    else
                    {
                        DataTable dtGroup = new DataTable("dtLogGroup");

                        switch (cmbGroup.SelectedIndex)
                        {
                            case 1:
                                dtGroup.Columns.Add(new DataColumn("Пользователь", typeof(string)));
                                dtGroup.Columns.Add(new DataColumn("Количество", typeof(int)));

                                var groupbyfilter1 = from row in dt.AsEnumerable()
                                                     where (row.Field<string>("Операция") != "Было")
                                                     group row by row.Field<string>("Пользователь") into grp
                                                     orderby grp.Key
                                                     select new
                                                     {
                                                         KeyNo = grp.Key,
                                                         Cnt = grp.Count()
                                                     };

                                foreach (var grp in groupbyfilter1)
                                {
                                    dtGroup.Rows.Add(new object[] { grp.KeyNo, grp.Cnt });
                                }
                                break;
                            case 2:
                                dtGroup.Columns.Add(new DataColumn("Операция", typeof(string)));
                                dtGroup.Columns.Add(new DataColumn("Количество", typeof(int)));

                                var groupbyfilter2 = from row in dt.AsEnumerable()
                                                     where (row.Field<string>("Операция") != "Было")
                                                     group row by row.Field<string>("Операция") into grp
                                                     orderby grp.Key
                                                     select new
                                                     {
                                                         KeyNo = grp.Key,
                                                         Cnt = grp.Count()
                                                     };

                                foreach (var grp in groupbyfilter2)
                                {
                                    dtGroup.Rows.Add(new object[] { grp.KeyNo, grp.Cnt });
                                }
                                break;
                            case 3:
                                dtGroup.Columns.Add(new DataColumn("Пользователь", typeof(string)));
                                dtGroup.Columns.Add(new DataColumn("Операция", typeof(string)));
                                dtGroup.Columns.Add(new DataColumn("Количество", typeof(int)));

                                var groupbyfilter3 = from row in dt.AsEnumerable()
                                                     where (row.Field<string>("Операция") != "Было")
                                                     group row by new { id1 = row.Field<string>("Пользователь"), id2 = row.Field<string>("Операция") } into grp
                                                     orderby grp.Key.id1, grp.Key.id2
                                                     select new
                                                     {
                                                         Key1 = grp.Key.id1,
                                                         Key2 = grp.Key.id2,
                                                         Cnt = grp.Count()
                                                     };

                                foreach (var grp in groupbyfilter3)
                                {
                                    dtGroup.Rows.Add(new object[] { grp.Key1, grp.Key2, grp.Cnt });
                                }
                                break;
                            case 4:
                                dtGroup.Columns.Add(new DataColumn("Пользователь", typeof(string)));
                                dtGroup.Columns.Add(new DataColumn("Месяц", typeof(string)));
                                dtGroup.Columns.Add(new DataColumn("Количество", typeof(int)));

                                var groupbyfilter4 = from row in dt.AsEnumerable()
                                                     where (row.Field<string>("Операция") != "Было")
                                                     group row by new { id1 = row.Field<string>("Пользователь"), id2 = row.Field<DateTime>("Дата").Month } into grp
                                                     orderby grp.Key.id1, grp.Key.id2
                                                     select new
                                                     {
                                                         Key1 = grp.Key.id1,
                                                         Key2 = grp.Key.id2,
                                                         Cnt = grp.Count()
                                                     };

                                foreach (var grp in groupbyfilter4)
                                {
                                    dtGroup.Rows.Add(new object[] { grp.Key1, grp.Key2, grp.Cnt });
                                }
                                break;
                        }
                        BindingSource bds = new BindingSource();
                        bds.DataSource = dtGroup;
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = bds;
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    con.CloseConnection();
                }
                dataGridView1.Refresh();
            }
                this.Cursor = Cursors.Default;
            
        }

        private void treeViewTable_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadLogView();
        }

        private void treeViewTable_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                e.Cancel = true;
            }
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadLogView();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
        //    if (. == null)
        //    {
        //    if (tbCode.Text.Trim().Length > 0)
        //    {
        //        int n;
        //        if (int.TryParse(tbCode.Text, out n))
        //        {
        //            string filterStr = "CodeAbonent = " + tbCode.Text;
        //            DataRow[] makes = dsRep.tAbn.Select(filterStr);
        //            if (makes.Length == 0)
        //                MessageBox.Show("Абонент не найден...", "Selection error!");
        //            else
        //            {
        //                DataRow temp = makes[0];
        //                tbName.Text = temp["Name"].ToString();
                        
        //            }
        //        }
        //        else
        //            MessageBox.Show("Введено не число!");
        //    }
        //}
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            tbCode.Text = null;
            tbName.Text = null;
        }


    }
}
