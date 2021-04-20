using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Library;
using System.Data.SqlClient;
using DataSql;
using SchemeModelN;
using System.Windows.Forms;

namespace Consumer.Classes
{
    public static class Tables
    {
        public static void SChmAbnFull_2020(DataTable dt, DataSql.SQLSettings sqlsettings, List<ElectricObject> listElectricObj, DateTime dateTime)
        {
            if (listElectricObj != null && listElectricObj.Count != 0)
            {
                string text = "";
                dt.Clear();
                foreach (ElectricObject item in listElectricObj)
                {
                    text = ((!string.IsNullOrEmpty(text)) ? (text + "," + item.Id) : item.Id.ToString());
                }

                using (SqlConnection connection = new SqlConnection(sqlsettings.GetConnectionString() + ";Connection Timeout=1000"))
                {
                    SqlCommand sqlCommand = new SqlCommand(ResourceReader.GetStringAssembly(typeof(Classes.Tables).Assembly, "vL_SchmAbnFull_2020.sql") + " \r\n\r\n and abn2.idSchmObj in (" + text + ")", connection);
                    sqlCommand.Parameters.Add("dt", SqlDbType.DateTime).Value = dateTime;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    sqlDataAdapter.Fill(dt);
                }
            }


        }
    }
}