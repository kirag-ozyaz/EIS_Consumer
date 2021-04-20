using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prv.Forms.Files
{
    public partial class FormAbnFilesAddEditFolder : FormLbr.FormBase
    {
        private int idAbn;
        private int idFolder;
        private bool isInsert = true;// добавить папку по умолчанию


        public FormAbnFilesAddEditFolder()
        {
            InitializeComponent();
        }

        public FormAbnFilesAddEditFolder(int idAbn, int idFolder, bool isInsert)
        {
            InitializeComponent();
            this.idAbn = idAbn;
            this.idFolder = idFolder;
            this.isInsert = isInsert;
            this.Text = (isInsert) ? "Добавление папки" : "Редактирование папки";
        }

        private void FormAbnFilesAddFolder_Load(object sender, EventArgs e)
        {
            if (isInsert) // добавление
            {
                DataRow r = dsPrv.tAbn_Files.NewRow();
                r["idAbn"] = idAbn;
                r["Deleted"] = 0;
                r["ParentID"] = idFolder;
                r["IsGroup"] = 1;
                r["Date"] = System.DateTime.Now;
                dsPrv.tAbn_Files.Rows.Add(r);
            }
            else //редактирование
            {
                this.SelectSqlData(dsPrv, dsPrv.tAbn_Files, true, " where id = " + idFolder.ToString());
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            if (isInsert)
            {
                dsPrv.tAbn_Files.Rows[0].EndEdit();
                idFolder = this.InsertSqlDataOneRow(dsPrv, dsPrv.tAbn_Files);
                if (idFolder < 0)
                    isOk = false;
                else
                    isOk = true;

            }
            else
            {
                dsPrv.tAbn_Files.Rows[0].EndEdit();
                isOk = this.UpdateSqlData(dsPrv, dsPrv.tAbn_Files);
            }
            if (isOk) this.DialogResult = DialogResult.OK;
        }
    }
}
