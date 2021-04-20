using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contractor.Forms
{
    public partial class FormaddEditAbnType : FormLbr.FormBase
    {
        int id = -1;
        int idAbn = -1;
        public FormaddEditAbnType()
        {
            InitializeComponent();
        }

        public FormaddEditAbnType(int id = -1, int idAbn = -1)
        {
            InitializeComponent();
            this.id = id;
            this.idAbn = idAbn;
            this.Text = (id == -1) ? "Добавить тип" : "Редактировать тип";

        }
        // Загрузка формы
        private void FormaddEditAbnType_Load(object sender, EventArgs e)
        {
            if (id == -1)
            {
                this.SelectSqlData(ds, ds.tR_Classifier, true, " where ParentKey = ';TypeKontragent;' and isGroup = 0 and deleted = 0 " +
                    " and id not in (select typeKontragent from tAbnType where idAbn = " + idAbn.ToString() + ") order by name");
            }
            else
            {
                this.SelectSqlData(ds.tAbnType, true, "where id = " + id.ToString());
                if (ds.tAbnType.Rows.Count > 0)
                {
                    this.SelectSqlData(ds, ds.tR_Classifier, true, " where (ParentKey = ';TypeKontragent;' and isGroup = 0 and deleted = 0 " +
                    " and id not in (select typeKontragent from tAbnType where idAbn = " + idAbn.ToString() + "))" +
                    " or (id = " + ds.tAbnType.Rows[0]["typeKontragent"].ToString() + ") " + 
                    " order by name");
                    cmbType.SelectedValue = ds.tAbnType.Rows[0]["typeKontragent"];
                }
                else
                {  // так то не должно
                    this.SelectSqlData(ds, ds.tR_Classifier, true, " where ParentKey = ';TypeKontragent;' and isGroup = 0 and deleted = 0 " +
                    " and id not in (select typeKontragent from tAbnType where idAbn = " + idAbn.ToString() + ") order by name");
                }
            }
        }

        private void FormaddEditAbnType_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (cmbType.SelectedIndex == -1)
                {
                    MessageBox.Show("Не выбран тип контрагента");
                    e.Cancel = true;
                    return;
                }

                if (id == -1)
                {
                    DataRow r = ds.tAbnType.NewRow();
                    r["idAbn"] = idAbn;
                    r["typeKontragent"] = cmbType.SelectedValue;
                    ds.tAbnType.Rows.Add(r);
                    this.InsertSqlData(ds, ds.tAbnType);
                }
                else
                {
                    if (ds.tAbnType.Rows.Count > 0)
                    {
                        ds.tAbnType.Rows[0]["typeKontragent"] = cmbType.SelectedValue;
                        ds.tAbnType.Rows[0].EndEdit();
                        this.UpdateSqlData(ds,ds.tAbnType);
                    }
                }
            }
        }
    }
}
