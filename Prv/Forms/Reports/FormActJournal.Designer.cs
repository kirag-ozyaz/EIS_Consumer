namespace Prv.Forms.Reports
{
    partial class FormActJournal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDeleted = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpRepBeg = new System.Windows.Forms.DateTimePicker();
            this.dtpRepEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonReport = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRep1 = new Prv.DataSets.DataSetRep();
            this.idDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberAct = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateAct = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCheck = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.AuthorAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOcontr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDcontr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountAbnAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountAbnCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountJournalImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRep1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnDel,
            this.btnPrint,
            this.btnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(883, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::Prv.Properties.Resources.ElementAdd;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "Новый акт";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::Prv.Properties.Resources.ElementEdit;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "Редактировать акт";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = global::Prv.Properties.Resources.ElementDel;
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(23, 22);
            this.btnDel.Text = "Удалить акт";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = global::Prv.Properties.Resources.Print;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 22);
            this.btnPrint.Text = "Напечатать акт";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::Prv.Properties.Resources.Refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "Обновить журнал";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvJournal
            // 
            this.dgvJournal.AllowUserToAddRows = false;
            this.dgvJournal.AllowUserToDeleteRows = false;
            this.dgvJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJournal.AutoGenerateColumns = false;
            this.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDGV,
            this.numberAct,
            this.dateAct,
            this.Adress,
            this.DateCheck,
            this.AuthorAct,
            this.FIOcontr,
            this.IDcontr,
            this.CountAbnAct,
            this.CountAbnCheck,
            this.Deleted,
            this.CountJournalImage});
            this.dgvJournal.DataSource = this.bindingSource1;
            this.dgvJournal.Location = new System.Drawing.Point(0, 93);
            this.dgvJournal.Name = "dgvJournal";
            this.dgvJournal.ReadOnly = true;
            this.dgvJournal.RowHeadersWidth = 5;
            this.dgvJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJournal.Size = new System.Drawing.Size(883, 412);
            this.dgvJournal.TabIndex = 1;
            this.dgvJournal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvJournal_CellFormatting);
            this.dgvJournal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvJournal_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Конец";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Начало";
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(193, 33);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(16, 23);
            this.btnMinus.TabIndex = 68;
            this.btnMinus.Text = "<";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(193, 9);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(16, 23);
            this.btnPlus.TabIndex = 67;
            this.btnPlus.Text = ">";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(56, 35);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 66;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(56, 10);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDeleted);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtBegin);
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.btnMinus);
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 63);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Журнал";
            // 
            // cbDeleted
            // 
            this.cbDeleted.AutoSize = true;
            this.cbDeleted.Location = new System.Drawing.Point(224, 37);
            this.cbDeleted.Name = "cbDeleted";
            this.cbDeleted.Size = new System.Drawing.Size(133, 17);
            this.cbDeleted.TabIndex = 71;
            this.cbDeleted.Text = "Показать удаленные";
            this.cbDeleted.UseVisualStyleBackColor = true;
            this.cbDeleted.CheckedChanged += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpRepBeg);
            this.groupBox2.Controls.Add(this.dtpRepEnd);
            this.groupBox2.Controls.Add(this.buttonReport);
            this.groupBox2.Location = new System.Drawing.Point(617, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 63);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отчет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Начало";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Конец";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpRepBeg
            // 
            this.dtpRepBeg.Location = new System.Drawing.Point(55, 11);
            this.dtpRepBeg.Name = "dtpRepBeg";
            this.dtpRepBeg.Size = new System.Drawing.Size(131, 20);
            this.dtpRepBeg.TabIndex = 73;
            // 
            // dtpRepEnd
            // 
            this.dtpRepEnd.Location = new System.Drawing.Point(55, 36);
            this.dtpRepEnd.Name = "dtpRepEnd";
            this.dtpRepEnd.Size = new System.Drawing.Size(131, 20);
            this.dtpRepEnd.TabIndex = 74;
            // 
            // buttonReport
            // 
            this.buttonReport.Image = global::Prv.Properties.Resources.Print;
            this.buttonReport.Location = new System.Drawing.Point(192, 14);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(51, 36);
            this.buttonReport.TabIndex = 72;
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "vPrv_JournalAct";
            this.bindingSource1.DataSource = this.dataSetRep1;
            // 
            // dataSetRep1
            // 
            this.dataSetRep1.DataSetName = "DataSetRep";
            this.dataSetRep1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDGV
            // 
            this.idDGV.DataPropertyName = "id";
            this.idDGV.HeaderText = "id";
            this.idDGV.Name = "idDGV";
            this.idDGV.ReadOnly = true;
            this.idDGV.Visible = false;
            this.idDGV.Width = 50;
            // 
            // numberAct
            // 
            this.numberAct.DataPropertyName = "NumberAct";
            this.numberAct.HeaderText = "№Акта";
            this.numberAct.Name = "numberAct";
            this.numberAct.ReadOnly = true;
            this.numberAct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numberAct.Width = 70;
            // 
            // dateAct
            // 
            this.dateAct.DataPropertyName = "DateAct";
            this.dateAct.HeaderText = "Дата акта";
            this.dateAct.Name = "dateAct";
            this.dateAct.ReadOnly = true;
            this.dateAct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateAct.Width = 80;
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "Adress";
            this.Adress.HeaderText = "Адреса";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 200;
            // 
            // DateCheck
            // 
            this.DateCheck.DataPropertyName = "DateCheck";
            this.DateCheck.HeaderText = "Дата обхода";
            this.DateCheck.Name = "DateCheck";
            this.DateCheck.ReadOnly = true;
            this.DateCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateCheck.Width = 80;
            // 
            // AuthorAct
            // 
            this.AuthorAct.DataPropertyName = "AuthorAct";
            this.AuthorAct.HeaderText = "Создатель";
            this.AuthorAct.Name = "AuthorAct";
            this.AuthorAct.ReadOnly = true;
            // 
            // FIOcontr
            // 
            this.FIOcontr.DataPropertyName = "FIOcontr";
            this.FIOcontr.HeaderText = "Контролеры";
            this.FIOcontr.Name = "FIOcontr";
            this.FIOcontr.ReadOnly = true;
            this.FIOcontr.Width = 150;
            // 
            // IDcontr
            // 
            this.IDcontr.DataPropertyName = "IDcontr";
            this.IDcontr.HeaderText = "IDcontr";
            this.IDcontr.Name = "IDcontr";
            this.IDcontr.ReadOnly = true;
            this.IDcontr.Visible = false;
            // 
            // CountAbnAct
            // 
            this.CountAbnAct.DataPropertyName = "CountAbnAct";
            this.CountAbnAct.HeaderText = "Кл-во абн.";
            this.CountAbnAct.Name = "CountAbnAct";
            this.CountAbnAct.ReadOnly = true;
            this.CountAbnAct.Width = 80;
            // 
            // CountAbnCheck
            // 
            this.CountAbnCheck.DataPropertyName = "CountAbnCheck";
            this.CountAbnCheck.HeaderText = "Колво пройдннных";
            this.CountAbnCheck.Name = "CountAbnCheck";
            this.CountAbnCheck.ReadOnly = true;
            this.CountAbnCheck.Width = 80;
            // 
            // Deleted
            // 
            this.Deleted.DataPropertyName = "Deleted";
            this.Deleted.HeaderText = "Deleted";
            this.Deleted.Name = "Deleted";
            this.Deleted.ReadOnly = true;
            this.Deleted.Visible = false;
            // 
            // CountJournalImage
            // 
            this.CountJournalImage.DataPropertyName = "CountJournalImage";
            this.CountJournalImage.HeaderText = "Сканы";
            this.CountJournalImage.Name = "CountJournalImage";
            this.CountJournalImage.ReadOnly = true;
            this.CountJournalImage.Width = 50;
            // 
            // FormActJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvJournal);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormActJournal";
            this.Text = "Журнал актов";
            this.Load += new System.EventHandler(this.FormActJournal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvJournal;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSets.DataSetRep dataSetRep1;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbDeleted;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpRepBeg;
        private System.Windows.Forms.DateTimePicker dtpRepEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDGV;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn numberAct;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dateAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn DateCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOcontr;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcontr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountAbnAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountAbnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountJournalImage;
    }
}