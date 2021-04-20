using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SchemeModelN;


namespace Legal.Forms.FormRep
{
    public partial class FormRepReceiptElectricity : FormLbr.FormBase
    {
        public FormRepReceiptElectricity()
        {
            InitializeComponent();

            for (DateTime d_c = System.DateTime.Now; d_c >= new DateTime(2007, 01, 01);
            d_c = d_c.AddMonths(-1))
            {
                cBoxPeriodBeg.Items.Add(d_c);
                cBoxPeriodEnd.Items.Add(d_c);
            }
            cBoxPeriodBeg.SelectedIndex = 0;
            cBoxPeriodEnd.SelectedIndex = 0;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            DateTime PeriodBeg = Convert.ToDateTime(cBoxPeriodBeg.SelectedItem);
            int beg = Convert.ToInt16(PeriodBeg.Year) * 100 + Convert.ToInt16(PeriodBeg.Month);
            DateTime PeriodEnd = Convert.ToDateTime(cBoxPeriodEnd.SelectedItem);
            int end = Convert.ToInt16(PeriodEnd.Year) * 100 + Convert.ToInt16(PeriodEnd.Month);

            this.SelectSqlData(dsRep.vG_RepReceiptElectricity, true," where YMonth >= " + beg.ToString() + " and  YMonth <= " + end.ToString());

            UpdateSchmLink();
        }

        private void UpdateSchmLink()
        {
            // MessageBox.Show(dsRep.vG_AbnObjQuantity_Flag.Rows.Count.ToString());
            // теперь получаем данные по привязкам объектов
            ElectricModel electricModel = new ElectricModel();
            electricModel.SqlSettings = this.SqlSettings;
            electricModel.LoadSchema(true);

            int idSchmObj = 0;
            int idAbnObj = 0;
            string StrLink = null;
            string[] idLinks;

            string str = "";

            // int i = 1;
            //   int rows = dsRep.vG_AbnObjQuantity_Flag.Rows.Count;

            foreach (DataRow row in dsRep.vG_RepReceiptElectricity.Rows)
            {

                str = "";
                idAbnObj = Convert.ToInt32(row["idObj"]);
                StrLink = (row["idSchmObj"]).ToString();
                idLinks = StrLink.Split(',');

                foreach (string ln in idLinks)
                {

                    try
                    {

                        if (int.TryParse(ln, out idSchmObj))
                        {


                            var ElectricObject = electricModel.GetParamsElectricObjectById((int)idSchmObj);
                            // row["TP"] = ElectricObject.ElectricSubName;
                            if (ElectricObject.ElectricSubName != null) str += ElectricObject.ElectricSubName;

                            if (ElectricObject.electricObject is SchemeModelN.ElectricLine)
                            {
                                // row["TPCell"] = ElectricObject.electricLine.ToString();
                                if (ElectricObject.electricLine != null) str += "/" + ElectricObject.electricLine.ToString();
                            }


                            //if (row["subid"] != DBNull.Value)
                            //{
                            //    var SubStation = electricModel.GetParamsElectricObjectById((int)row["subid"]);
                            //    row["TP"] = SubStation.ElectricSubName;
                            //}
                            // electricModel.GetParamsElectricObjectById(972609).electricObject is SchemeModelN.ElectricLine

                            //центр питания
                            //var listSchmObj = electricModel.GetCellCP((int)idSchmObj);
                            //if (listSchmObj != null)
                            //    if (listSchmObj.Length > 0)
                            //    {
                            //        if (listSchmObj[0].ElectricSubName != null)
                            //            //row["CPName"] = listSchmObj[0].ElectricSubName;
                            //            str += "/" + listSchmObj[0].ElectricSubName;
                            //        if (listSchmObj[0].electricLine != null)
                            //            //row["CellCPName"] = listSchmObj[0].electricLine.ToString();
                            //            str += "/" + listSchmObj[0].electricLine.ToString();
                            //    }

                        } //if (int.TryParse(ln, out idSchmObj))
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString() + ": " + idSchmObj.ToString(), "Ошибка", MessageBoxButtons.OK);
                    }

                    //str += " ;" + "\n\n";

                }
                row["SchmLink"] = str;
 
           /*     try
                {
                    if (row["idSchmObj"] != DBNull.Value)
                    {
                        idSchmObj = (int)row["idSchmObj"];

                        //var test = listSchmPointCP.Where(w=> w.Key==[(int)idSchmObj]);
                        var ElectricObject = electricModel.GetParamsElectricObjectById((int)idSchmObj);
                        //ElectricObject electricObjectById = electricModel.GetElectricObjectById((int)idSchmObj);
                        row["TP"] = ElectricObject.ElectricSubName;
                        if (ElectricObject.electricObject is SchemeModelN.ElectricLine)
                        {
                            row["TPCell"] = ElectricObject.electricLine.ToString();
                        }

                        //if (row["subid"] != DBNull.Value)
                        //{
                        //    var SubStation = electricModel.GetParamsElectricObjectById((int)row["subid"]);
                        //    row["TP"] = SubStation.ElectricSubName;
                        //}
                        // electricModel.GetParamsElectricObjectById(972609).electricObject is SchemeModelN.ElectricLine

                        // 0. Может сделать параллельную обработку
                        // 2. проверить пустые привязки за прошлые период у объектов
                        // 3. присоединить отчет (сводный)
                        if (ElectricObject.electricObject != null)
                        {
                            //// 1. если привязка была, то ищем ее в списке
                            //var centerPower = listSchmPointCP.Where(w => w.Key == ElectricObject.electricObject.Id);
                            //if (centerPower != null && centerPower.Count() > 0)
                            //{
                            //    row["CPName"] = centerPower.First().Value.CPName;
                            //    row["CellCPName"] = centerPower.First().Value.CellCPName;
                            //}
                            //else // 4. ищем центр питания по объекту схему
                            {
                                // 4.1. Проверим еще  способ получения центра питания
                                // соберем дерево объектов до верхушки
                                var treeNodeObj = electricModel.PoweringReportForDrawObject((int)idSchmObj, false);
                                // переменная для расчета основным способом
                                bool isSecondaryCalc = true;
                                if (treeNodeObj != null) isSecondaryCalc = false;
                                if (!isSecondaryCalc)
                                {
                                    // возьмем список веток у родителя дерева
                                    var LeafsList = treeNodeObj.GetRoot.LeafsList;
                                    if (LeafsList.Count() > 0)
                                    {
                                        // возьмем последний элемент в списке веток (это в том случае если не полная привязка)
                                        var firstElement = LeafsList.Last();
                                        if (firstElement.Tag != null && firstElement.Tag is ElectricObject)
                                        {
                                            /// Ячейка запитки от центра питания
                                            if (firstElement.Parent != null && firstElement.Parent.Tag != null && firstElement.Parent.Tag is ElectricObject)
                                            {
                                                row["CPName"] = ((SchemeModelN.ElectricObject)firstElement.Tag).Parent.FullName;
                                                row["CellCPName"] = firstElement.Parent.Tag;
                                            }
                                        }
                                    }
                                    // if (LeafsList.Count() > 1)  {  }
                                    // Если есть хотя бы одна ветка (LeafsList), значит есть центр питания
                                    // и следующее условие отрабатывать не надо
                                }
                                if (isSecondaryCalc)
                                {
                                    // var listNameCP = GetCellsCP(electricModel, (int)idSchmObj);
                                    // var ppp = electricModel.PoweringReportForDrawObject(ElectricObject.electricObject, true, true);
                                    // var ppp = electricModel.PoweringReportForDrawObject(ElectricObject.electricObject.Id, true);
                                    var listSchmObj = electricModel.GetCellCP((int)idSchmObj);
                                    if (listSchmObj != null)
                                        if (listSchmObj.Length > 0)
                                        {
                                            if (listSchmObj[0].ElectricSubName != null)
                                                row["CPName"] = listSchmObj[0].ElectricSubName;
                                            if (listSchmObj[0].electricLine != null)
                                                row["CellCPName"] = listSchmObj[0].electricLine.ToString();
                                        }
                               // } */

            }//foreach (DataRow row in dsRep.vG_AbnObjQuantity_Flag.Rows)
            //    }
            //MessageBox.Show("Усе");
        }
    }
}
