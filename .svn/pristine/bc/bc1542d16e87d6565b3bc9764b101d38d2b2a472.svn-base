using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.ActCheck
{
    public partial class FormDocAct_FindPlomb : FormLbr.FormBase
    {
        public int IDWORKER;
        public int IDTYPEPLOMB;
        public int IDPLOMB;

        public FormDocAct_FindPlomb()
        {
            InitializeComponent();
        }

        #region Загрузка данных для грида
        private void FormDocAct_FindPlomb_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsDop1, dsDop1.vPointCheckPlombFind, true, " where idUst = 299");
        }
        #endregion

        #region Поиск пломбы
        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvPlomb.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, txtFind.Text);
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            dgvPlomb.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, txtFind.Text);
        }

        private void btnFindPrev_Click(object sender, EventArgs e)
        {
            dgvPlomb.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, txtFind.Text);
        }
        #endregion

        #region Выбор пломбы и возврат в родительскую форму
        private void dgvPlomb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IDWORKER = Convert.ToInt32(dgvPlomb.CurrentRow.Cells["dgv_idWorker"].Value);
            IDTYPEPLOMB = Convert.ToInt32(dgvPlomb.CurrentRow.Cells["dgv_idTypePlomb"].Value);
            IDPLOMB = Convert.ToInt32(dgvPlomb.CurrentRow.Cells["dgv_id"].Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
            this.Dispose();
        }
        #endregion
    }
}
