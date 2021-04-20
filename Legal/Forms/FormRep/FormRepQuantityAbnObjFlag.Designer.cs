namespace Legal.Forms.FormRep
{
    partial class FormRepQuantityAbnObjFlag
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bsRep = new System.Windows.Forms.BindingSource(this.components);
            this.dsRep = new Legal.DataSet.dsReportsLegal();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvefAbnFlags = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeAbnNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.abnHighNetDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.netNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.SchmLink = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.TariffName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.SumQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YMonthStr = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.YMonth = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idSchm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rwRep = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gBoxPeriod = new System.Windows.Forms.GroupBox();
            this.labelMonthEnd = new System.Windows.Forms.Label();
            this.labelMonthBeg = new System.Windows.Forms.Label();
            this.cBoxPeriodEnd = new System.Windows.Forms.ComboBox();
            this.cBoxPeriodBeg = new System.Windows.Forms.ComboBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.clbFlags = new System.Windows.Forms.CheckedListBox();
            this.cbGroupFlags = new System.Windows.Forms.ComboBox();
            this.bsGroupName = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bsRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefAbnFlags)).BeginInit();
            this.gBoxPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupName)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsRep
            // 
            this.bsRep.DataMember = "vG_AbnObjQuantity_Flag";
            this.bsRep.DataSource = this.dsRep;
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "dsReportsLegal";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 25);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvefAbnFlags);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rwRep);
            this.splitContainer2.Size = new System.Drawing.Size(513, 529);
            this.splitContainer2.SplitterDistance = 158;
            this.splitContainer2.TabIndex = 5;
            // 
            // dgvefAbnFlags
            // 
            this.dgvefAbnFlags.AllowUserToAddRows = false;
            this.dgvefAbnFlags.AllowUserToDeleteRows = false;
            this.dgvefAbnFlags.AllowUserToOrderColumns = true;
            this.dgvefAbnFlags.AutoGenerateColumns = false;
            this.dgvefAbnFlags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvefAbnFlags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeAbonentDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeAbnNameDataGridViewTextBoxColumn,
            this.nameObjDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.abnHighNetDataGridViewTextBoxColumn,
            this.netNameDataGridViewTextBoxColumn,
            this.SchmLink,
            this.TariffName,
            this.SumQuantity,
            this.YMonthStr,
            this.YMonth,
            this.idSchm});
            this.dgvefAbnFlags.DataSource = this.bsRep;
            this.dgvefAbnFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvefAbnFlags.Location = new System.Drawing.Point(0, 0);
            this.dgvefAbnFlags.Name = "dgvefAbnFlags";
            this.dgvefAbnFlags.ReadOnly = true;
            this.dgvefAbnFlags.RowHeadersWidth = 21;
            this.dgvefAbnFlags.Size = new System.Drawing.Size(513, 158);
            this.dgvefAbnFlags.TabIndex = 4;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeAbnNameDataGridViewTextBoxColumn
            // 
            this.typeAbnNameDataGridViewTextBoxColumn.DataPropertyName = "typeAbnName";
            this.typeAbnNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeAbnNameDataGridViewTextBoxColumn.Name = "typeAbnNameDataGridViewTextBoxColumn";
            this.typeAbnNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeAbnNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameObjDataGridViewTextBoxColumn
            // 
            this.nameObjDataGridViewTextBoxColumn.DataPropertyName = "nameObj";
            this.nameObjDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameObjDataGridViewTextBoxColumn.Name = "nameObjDataGridViewTextBoxColumn";
            this.nameObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameObjDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // abnHighNetDataGridViewTextBoxColumn
            // 
            this.abnHighNetDataGridViewTextBoxColumn.DataPropertyName = "abnHighNet";
            this.abnHighNetDataGridViewTextBoxColumn.HeaderText = "Вышестоящая сетевая";
            this.abnHighNetDataGridViewTextBoxColumn.Name = "abnHighNetDataGridViewTextBoxColumn";
            this.abnHighNetDataGridViewTextBoxColumn.ReadOnly = true;
            this.abnHighNetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // netNameDataGridViewTextBoxColumn
            // 
            this.netNameDataGridViewTextBoxColumn.DataPropertyName = "NetName";
            this.netNameDataGridViewTextBoxColumn.HeaderText = "Сетевая";
            this.netNameDataGridViewTextBoxColumn.Name = "netNameDataGridViewTextBoxColumn";
            this.netNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.netNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SchmLink
            // 
            this.SchmLink.DataPropertyName = "SchmLink";
            this.SchmLink.HeaderText = "Привязка";
            this.SchmLink.Name = "SchmLink";
            this.SchmLink.ReadOnly = true;
            this.SchmLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TariffName
            // 
            this.TariffName.DataPropertyName = "TariffName";
            this.TariffName.HeaderText = "Тариф";
            this.TariffName.Name = "TariffName";
            this.TariffName.ReadOnly = true;
            this.TariffName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SumQuantity
            // 
            this.SumQuantity.DataPropertyName = "SumQuantity";
            this.SumQuantity.HeaderText = "Суммв кВт";
            this.SumQuantity.Name = "SumQuantity";
            this.SumQuantity.ReadOnly = true;
            // 
            // YMonthStr
            // 
            this.YMonthStr.DataPropertyName = "YMonthStr";
            this.YMonthStr.HeaderText = "Месяц";
            this.YMonthStr.Name = "YMonthStr";
            this.YMonthStr.ReadOnly = true;
            this.YMonthStr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // YMonth
            // 
            this.YMonth.DataPropertyName = "YMonth";
            this.YMonth.HeaderText = "YMonth";
            this.YMonth.Name = "YMonth";
            this.YMonth.ReadOnly = true;
            this.YMonth.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.YMonth.Visible = false;
            // 
            // idSchm
            // 
            this.idSchm.DataPropertyName = "idSchm";
            this.idSchm.HeaderText = "idSchm";
            this.idSchm.Name = "idSchm";
            this.idSchm.ReadOnly = true;
            this.idSchm.Visible = false;
            // 
            // rwRep
            // 
            this.rwRep.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bsRep;
            this.rwRep.LocalReport.DataSources.Add(reportDataSource1);
            this.rwRep.LocalReport.ReportEmbeddedResource = "Legal.Reports.ReportReoQuantityAbnQbjFlag2.rdlc";
            this.rwRep.Location = new System.Drawing.Point(0, 0);
            this.rwRep.Name = "rwRep";
            this.rwRep.Size = new System.Drawing.Size(513, 367);
            this.rwRep.TabIndex = 0;
            // 
            // gBoxPeriod
            // 
            this.gBoxPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxPeriod.Controls.Add(this.labelMonthEnd);
            this.gBoxPeriod.Controls.Add(this.labelMonthBeg);
            this.gBoxPeriod.Controls.Add(this.cBoxPeriodEnd);
            this.gBoxPeriod.Controls.Add(this.cBoxPeriodBeg);
            this.gBoxPeriod.Location = new System.Drawing.Point(5, 293);
            this.gBoxPeriod.Name = "gBoxPeriod";
            this.gBoxPeriod.Size = new System.Drawing.Size(151, 119);
            this.gBoxPeriod.TabIndex = 9;
            this.gBoxPeriod.TabStop = false;
            this.gBoxPeriod.Text = "Период";
            // 
            // labelMonthEnd
            // 
            this.labelMonthEnd.AutoSize = true;
            this.labelMonthEnd.Location = new System.Drawing.Point(9, 65);
            this.labelMonthEnd.Name = "labelMonthEnd";
            this.labelMonthEnd.Size = new System.Drawing.Size(38, 13);
            this.labelMonthEnd.TabIndex = 3;
            this.labelMonthEnd.Text = "Конец";
            // 
            // labelMonthBeg
            // 
            this.labelMonthBeg.AutoSize = true;
            this.labelMonthBeg.Location = new System.Drawing.Point(6, 21);
            this.labelMonthBeg.Name = "labelMonthBeg";
            this.labelMonthBeg.Size = new System.Drawing.Size(44, 13);
            this.labelMonthBeg.TabIndex = 2;
            this.labelMonthBeg.Text = "Начало";
            // 
            // cBoxPeriodEnd
            // 
            this.cBoxPeriodEnd.FormatString = "MMMM yyyy";
            this.cBoxPeriodEnd.FormattingEnabled = true;
            this.cBoxPeriodEnd.Location = new System.Drawing.Point(6, 82);
            this.cBoxPeriodEnd.Name = "cBoxPeriodEnd";
            this.cBoxPeriodEnd.Size = new System.Drawing.Size(135, 21);
            this.cBoxPeriodEnd.TabIndex = 1;
            // 
            // cBoxPeriodBeg
            // 
            this.cBoxPeriodBeg.FormatString = "MMMM yyyy";
            this.cBoxPeriodBeg.FormattingEnabled = true;
            this.cBoxPeriodBeg.Location = new System.Drawing.Point(6, 37);
            this.cBoxPeriodBeg.Name = "cBoxPeriodBeg";
            this.cBoxPeriodBeg.Size = new System.Drawing.Size(135, 21);
            this.cBoxPeriodBeg.TabIndex = 0;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Location = new System.Drawing.Point(5, 491);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(150, 23);
            this.buttonCreate.TabIndex = 8;
            this.buttonCreate.Text = "Сформировать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(5, 520);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(150, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // clbFlags
            // 
            this.clbFlags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clbFlags.FormattingEnabled = true;
            this.clbFlags.Location = new System.Drawing.Point(5, 32);
            this.clbFlags.Name = "clbFlags";
            this.clbFlags.Size = new System.Drawing.Size(151, 244);
            this.clbFlags.TabIndex = 6;
            // 
            // cbGroupFlags
            // 
            this.cbGroupFlags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGroupFlags.DataSource = this.bsGroupName;
            this.cbGroupFlags.DisplayMember = "Name";
            this.cbGroupFlags.FormattingEnabled = true;
            this.cbGroupFlags.Location = new System.Drawing.Point(5, 5);
            this.cbGroupFlags.Name = "cbGroupFlags";
            this.cbGroupFlags.Size = new System.Drawing.Size(151, 21);
            this.cbGroupFlags.TabIndex = 5;
            this.cbGroupFlags.ValueMember = "Id";
            this.cbGroupFlags.SelectedIndexChanged += new System.EventHandler(this.cbGroupFlags_SelectedIndexChanged);
            // 
            // bsGroupName
            // 
            this.bsGroupName.DataMember = "tR_Classifier_GroupFlags";
            this.bsGroupName.DataSource = this.dsRep;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gBoxPeriod);
            this.panel1.Controls.Add(this.clbFlags);
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Controls.Add(this.cbGroupFlags);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Location = new System.Drawing.Point(514, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 554);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.splitContainer2);
            this.panel2.Controls.Add(this.toolStripMain);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 554);
            this.panel2.TabIndex = 2;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFind,
            this.toolStripTextBoxFind,
            this.toolStripButtonFindPrev,
            this.toolStripButtonFindNext,
            this.toolStripSeparator3,
            this.toolStripButtonPrint,
            this.toolStripSeparator4,
            this.toolStripButtonExportExcel,
            this.toolStripSeparator5,
            this.toolStripButtonRefresh});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(513, 25);
            this.toolStripMain.TabIndex = 4;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = global::Legal.Properties.Resources.Find;
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxFind_KeyDown);
            // 
            // toolStripButtonFindPrev
            // 
            this.toolStripButtonFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindPrev.Image = global::Legal.Properties.Resources.FindPrev;
            this.toolStripButtonFindPrev.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFindPrev.Name = "toolStripButtonFindPrev";
            this.toolStripButtonFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindPrev.Text = "Поиск назад";
            this.toolStripButtonFindPrev.Click += new System.EventHandler(this.toolStripButtonFindPrev_Click);
            // 
            // toolStripButtonFindNext
            // 
            this.toolStripButtonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindNext.Image = global::Legal.Properties.Resources.FindNext;
            this.toolStripButtonFindNext.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFindNext.Name = "toolStripButtonFindNext";
            this.toolStripButtonFindNext.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindNext.Text = "Поиск вперед";
            this.toolStripButtonFindNext.Click += new System.EventHandler(this.toolStripButtonFindNext_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrint.Image = global::Legal.Properties.Resources.Print;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrint.Text = "Печать";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonExportExcel
            // 
            this.toolStripButtonExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExportExcel.Image = global::Legal.Properties.Resources.xlsx_mac;
            this.toolStripButtonExportExcel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonExportExcel.Name = "toolStripButtonExportExcel";
            this.toolStripButtonExportExcel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExportExcel.Text = "Экспорт в Excel";
            this.toolStripButtonExportExcel.Click += new System.EventHandler(this.toolStripButtonExportExcel_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::Legal.Properties.Resources.Обновить;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "Обновить";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // FormRepQuantityAbnObjFlag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormRepQuantityAbnObjFlag";
            this.Text = "Ведомось по признакам";
            this.Load += new System.EventHandler(this.FormRepQuantityAbnObjFlag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvefAbnFlags)).EndInit();
            this.gBoxPeriod.ResumeLayout(false);
            this.gBoxPeriod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupName)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvefAbnFlags;
        private System.Windows.Forms.BindingSource bsRep;
        private DataSet.dsReportsLegal dsRep;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckedListBox clbFlags;
        private System.Windows.Forms.ComboBox cbGroupFlags;
        private System.Windows.Forms.BindingSource bsGroupName;
        private System.Windows.Forms.GroupBox gBoxPeriod;
        private System.Windows.Forms.ComboBox cBoxPeriodBeg;
        private System.Windows.Forms.ComboBox cBoxPeriodEnd;
        private System.Windows.Forms.Label labelMonthEnd;
        private System.Windows.Forms.Label labelMonthBeg;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Microsoft.Reporting.WinForms.ReportViewer rwRep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn typeAbnNameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameObjDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn addressDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn abnHighNetDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn netNameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn SchmLink;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn TariffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumQuantity;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn YMonthStr;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn YMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSchm;
    }
}