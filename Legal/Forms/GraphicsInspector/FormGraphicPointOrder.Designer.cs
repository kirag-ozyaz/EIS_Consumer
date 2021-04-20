namespace Legal.Forms.GraphicsInspector
{
    partial class FormGraphicPointOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraphicPointOrder));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bsOrder = new System.Windows.Forms.BindingSource(this.components);
            this.dsGraphic = new Legal.DataSet.DataSetGraphic();
            this.dgvOrder = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.abnPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.schmObjNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.objAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameMeterDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterDCheckStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDCheckStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripMainOrder = new System.Windows.Forms.ToolStrip();
            this.tsbCheckFilter = new System.Windows.Forms.ToolStripButton();
            this.tsbUncheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxOrderFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.reportViewerOrder = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbWho = new System.Windows.Forms.ComboBox();
            this.bsMasterWho = new System.Windows.Forms.BindingSource(this.components);
            this.cbWhom = new System.Windows.Forms.ComboBox();
            this.bsMasterWhom = new System.Windows.Forms.BindingSource(this.components);
            this.labelWho = new System.Windows.Forms.Label();
            this.labelWhom = new System.Windows.Forms.Label();
            this.tbOrderN = new System.Windows.Forms.TextBox();
            this.labelOrderN = new System.Windows.Forms.Label();
            this.panelWait = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGraphic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripMainOrder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMasterWho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMasterWhom)).BeginInit();
            this.panelWait.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsOrder
            // 
            this.bsOrder.DataMember = "vG_GraphicPointOrder_new";
            this.bsOrder.DataSource = this.dsGraphic;
            // 
            // dsGraphic
            // 
            this.dsGraphic.DataSetName = "DataSetGraphic";
            this.dsGraphic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.typeAbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.abnPhoneDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn,
            this.idObjDataGridViewTextBoxColumn,
            this.numberObjDataGridViewTextBoxColumn,
            this.nameObjDataGridViewTextBoxColumn,
            this.schmObjNameDataGridViewTextBoxColumn,
            this.objAdressDataGridViewTextBoxColumn,
            this.idAbnDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.idPointDataGridViewTextBoxColumn,
            this.masterIDDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.nameMeterDataGridViewTextBoxColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.meterDCheckStrDataGridViewTextBoxColumn,
            this.transDCheckStrDataGridViewTextBoxColumn,
            this.ktranDataGridViewTextBoxColumn,
            this.valuesDataGridViewTextBoxColumn,
            this.dateActDataGridViewTextBoxColumn,
            this.powerSetDataGridViewTextBoxColumn});
            this.dgvOrder.DataSource = this.bsOrder;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(0, 25);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 21;
            this.dgvOrder.Size = new System.Drawing.Size(872, 242);
            this.dgvOrder.TabIndex = 5;
            this.dgvOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellValueChanged);
            this.dgvOrder.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvOrder_CurrentCellDirtyStateChanged);
            // 
            // check
            // 
            this.check.DataPropertyName = "check";
            this.check.HeaderText = " ";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.check.Width = 25;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "№дог.";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 40;
            // 
            // typeAbnDataGridViewTextBoxColumn
            // 
            this.typeAbnDataGridViewTextBoxColumn.DataPropertyName = "TypeAbn";
            this.typeAbnDataGridViewTextBoxColumn.HeaderText = "TypeAbn";
            this.typeAbnDataGridViewTextBoxColumn.Name = "typeAbnDataGridViewTextBoxColumn";
            this.typeAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // abnPhoneDataGridViewTextBoxColumn
            // 
            this.abnPhoneDataGridViewTextBoxColumn.DataPropertyName = "AbnPhone";
            this.abnPhoneDataGridViewTextBoxColumn.HeaderText = "Контакты";
            this.abnPhoneDataGridViewTextBoxColumn.Name = "abnPhoneDataGridViewTextBoxColumn";
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // idObjDataGridViewTextBoxColumn
            // 
            this.idObjDataGridViewTextBoxColumn.DataPropertyName = "idObj";
            this.idObjDataGridViewTextBoxColumn.HeaderText = "idObj";
            this.idObjDataGridViewTextBoxColumn.Name = "idObjDataGridViewTextBoxColumn";
            this.idObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberObjDataGridViewTextBoxColumn
            // 
            this.numberObjDataGridViewTextBoxColumn.DataPropertyName = "NumberObj";
            this.numberObjDataGridViewTextBoxColumn.HeaderText = "№об.";
            this.numberObjDataGridViewTextBoxColumn.Name = "numberObjDataGridViewTextBoxColumn";
            // 
            // nameObjDataGridViewTextBoxColumn
            // 
            this.nameObjDataGridViewTextBoxColumn.DataPropertyName = "NameObj";
            this.nameObjDataGridViewTextBoxColumn.HeaderText = "Наименование объекта";
            this.nameObjDataGridViewTextBoxColumn.Name = "nameObjDataGridViewTextBoxColumn";
            this.nameObjDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // schmObjNameDataGridViewTextBoxColumn
            // 
            this.schmObjNameDataGridViewTextBoxColumn.DataPropertyName = "schmObjName";
            this.schmObjNameDataGridViewTextBoxColumn.HeaderText = "Схема";
            this.schmObjNameDataGridViewTextBoxColumn.Name = "schmObjNameDataGridViewTextBoxColumn";
            this.schmObjNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.schmObjNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // objAdressDataGridViewTextBoxColumn
            // 
            this.objAdressDataGridViewTextBoxColumn.DataPropertyName = "ObjAdress";
            this.objAdressDataGridViewTextBoxColumn.HeaderText = "Адрес объекта";
            this.objAdressDataGridViewTextBoxColumn.Name = "objAdressDataGridViewTextBoxColumn";
            this.objAdressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idAbnDataGridViewTextBoxColumn
            // 
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPointDataGridViewTextBoxColumn
            // 
            this.idPointDataGridViewTextBoxColumn.DataPropertyName = "idPoint";
            this.idPointDataGridViewTextBoxColumn.HeaderText = "idPoint";
            this.idPointDataGridViewTextBoxColumn.Name = "idPointDataGridViewTextBoxColumn";
            this.idPointDataGridViewTextBoxColumn.Visible = false;
            // 
            // masterIDDataGridViewTextBoxColumn
            // 
            this.masterIDDataGridViewTextBoxColumn.DataPropertyName = "MasterID";
            this.masterIDDataGridViewTextBoxColumn.HeaderText = "MasterID";
            this.masterIDDataGridViewTextBoxColumn.Name = "masterIDDataGridViewTextBoxColumn";
            this.masterIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "№счетчика";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameMeterDataGridViewTextBoxColumn
            // 
            this.nameMeterDataGridViewTextBoxColumn.DataPropertyName = "NameMeter";
            this.nameMeterDataGridViewTextBoxColumn.HeaderText = "Тип. счетчика";
            this.nameMeterDataGridViewTextBoxColumn.Name = "nameMeterDataGridViewTextBoxColumn";
            this.nameMeterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateBeginDataGridViewTextBoxColumn
            // 
            this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "DateBegin";
            this.dateBeginDataGridViewTextBoxColumn.HeaderText = "DateBegin";
            this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
            this.dateBeginDataGridViewTextBoxColumn.Visible = false;
            // 
            // meterDCheckStrDataGridViewTextBoxColumn
            // 
            this.meterDCheckStrDataGridViewTextBoxColumn.DataPropertyName = "MeterDCheckStr";
            this.meterDCheckStrDataGridViewTextBoxColumn.HeaderText = "ГП сч.";
            this.meterDCheckStrDataGridViewTextBoxColumn.Name = "meterDCheckStrDataGridViewTextBoxColumn";
            this.meterDCheckStrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transDCheckStrDataGridViewTextBoxColumn
            // 
            this.transDCheckStrDataGridViewTextBoxColumn.DataPropertyName = "TransDCheckStr";
            this.transDCheckStrDataGridViewTextBoxColumn.HeaderText = "ГП т/т";
            this.transDCheckStrDataGridViewTextBoxColumn.Name = "transDCheckStrDataGridViewTextBoxColumn";
            this.transDCheckStrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ktranDataGridViewTextBoxColumn
            // 
            this.ktranDataGridViewTextBoxColumn.DataPropertyName = "Ktran";
            this.ktranDataGridViewTextBoxColumn.HeaderText = "Ктт";
            this.ktranDataGridViewTextBoxColumn.Name = "ktranDataGridViewTextBoxColumn";
            this.ktranDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valuesDataGridViewTextBoxColumn
            // 
            this.valuesDataGridViewTextBoxColumn.DataPropertyName = "Values";
            this.valuesDataGridViewTextBoxColumn.HeaderText = "Показания сч.";
            this.valuesDataGridViewTextBoxColumn.Name = "valuesDataGridViewTextBoxColumn";
            this.valuesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateActDataGridViewTextBoxColumn
            // 
            this.dateActDataGridViewTextBoxColumn.DataPropertyName = "DateAct";
            this.dateActDataGridViewTextBoxColumn.HeaderText = "Дата пред. акта";
            this.dateActDataGridViewTextBoxColumn.Name = "dateActDataGridViewTextBoxColumn";
            // 
            // powerSetDataGridViewTextBoxColumn
            // 
            this.powerSetDataGridViewTextBoxColumn.DataPropertyName = "PowerSet";
            this.powerSetDataGridViewTextBoxColumn.HeaderText = "Pуст.";
            this.powerSetDataGridViewTextBoxColumn.Name = "powerSetDataGridViewTextBoxColumn";
            this.powerSetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelWait);
            this.splitContainer1.Panel1.Controls.Add(this.dgvOrder);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMainOrder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewerOrder);
            this.splitContainer1.Size = new System.Drawing.Size(872, 534);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 6;
            // 
            // toolStripMainOrder
            // 
            this.toolStripMainOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCheckFilter,
            this.tsbUncheck,
            this.toolStripSeparator1,
            this.toolStripButtonFind,
            this.toolStripTextBoxOrderFind,
            this.toolStripButtonFindPrev,
            this.toolStripButtonFindNext,
            this.toolStripSeparator3,
            this.toolStripButtonPrint,
            this.toolStripSeparator4,
            this.toolStripButtonExportExcel,
            this.toolStripSeparator5,
            this.toolStripButtonRefresh});
            this.toolStripMainOrder.Location = new System.Drawing.Point(0, 0);
            this.toolStripMainOrder.Name = "toolStripMainOrder";
            this.toolStripMainOrder.Size = new System.Drawing.Size(872, 25);
            this.toolStripMainOrder.TabIndex = 13;
            this.toolStripMainOrder.Text = "toolStrip1";
            // 
            // tsbCheckFilter
            // 
            this.tsbCheckFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCheckFilter.Image = global::Legal.Properties.Resources.filter_plus_icon_135624;
            this.tsbCheckFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheckFilter.Name = "tsbCheckFilter";
            this.tsbCheckFilter.Size = new System.Drawing.Size(23, 22);
            this.tsbCheckFilter.Text = "Выбраь отмеченые";
            this.tsbCheckFilter.Click += new System.EventHandler(this.tsbCheckFilter_Click);
            // 
            // tsbUncheck
            // 
            this.tsbUncheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUncheck.Image = global::Legal.Properties.Resources.filter_remove_icon_138610;
            this.tsbUncheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUncheck.Name = "tsbUncheck";
            this.tsbUncheck.Size = new System.Drawing.Size(23, 22);
            this.tsbUncheck.Text = "Убрать фильтр";
            this.tsbUncheck.Click += new System.EventHandler(this.tsbUncheck_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFind.Image")));
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // toolStripTextBoxOrderFind
            // 
            this.toolStripTextBoxOrderFind.Name = "toolStripTextBoxOrderFind";
            this.toolStripTextBoxOrderFind.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonFindPrev
            // 
            this.toolStripButtonFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindPrev.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFindPrev.Image")));
            this.toolStripButtonFindPrev.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFindPrev.Name = "toolStripButtonFindPrev";
            this.toolStripButtonFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindPrev.Text = "Поиск назад";
            this.toolStripButtonFindPrev.Click += new System.EventHandler(this.toolStripButtonFindPrev_Click);
            // 
            // toolStripButtonFindNext
            // 
            this.toolStripButtonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFindNext.Image")));
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
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
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
            this.toolStripButtonExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExportExcel.Image")));
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
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "Обновить";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // reportViewerOrder
            // 
            this.reportViewerOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "GraphicPointOrder";
            reportDataSource2.Value = this.bsOrder;
            this.reportViewerOrder.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerOrder.LocalReport.ReportEmbeddedResource = "Legal.Reports.ReportGraphicOrderNew.rdlc";
            this.reportViewerOrder.Location = new System.Drawing.Point(0, 0);
            this.reportViewerOrder.Name = "reportViewerOrder";
            this.reportViewerOrder.Size = new System.Drawing.Size(872, 263);
            this.reportViewerOrder.TabIndex = 0;
            this.reportViewerOrder.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewerOrder_ReportRefresh);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbWho);
            this.groupBox1.Controls.Add(this.cbWhom);
            this.groupBox1.Controls.Add(this.labelWho);
            this.groupBox1.Controls.Add(this.labelWhom);
            this.groupBox1.Controls.Add(this.tbOrderN);
            this.groupBox1.Controls.Add(this.labelOrderN);
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 53);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // cbWho
            // 
            this.cbWho.DataSource = this.bsMasterWho;
            this.cbWho.DisplayMember = "FIO";
            this.cbWho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbWho.FormattingEnabled = true;
            this.cbWho.Location = new System.Drawing.Point(665, 15);
            this.cbWho.Name = "cbWho";
            this.cbWho.Size = new System.Drawing.Size(200, 28);
            this.cbWho.TabIndex = 16;
            this.cbWho.ValueMember = "id";
            // 
            // bsMasterWho
            // 
            this.bsMasterWho.DataMember = "vWorkerGroup";
            this.bsMasterWho.DataSource = this.dsGraphic;
            // 
            // cbWhom
            // 
            this.cbWhom.DataSource = this.bsMasterWhom;
            this.cbWhom.DisplayMember = "FIO";
            this.cbWhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbWhom.FormattingEnabled = true;
            this.cbWhom.Location = new System.Drawing.Point(347, 15);
            this.cbWhom.Name = "cbWhom";
            this.cbWhom.Size = new System.Drawing.Size(197, 28);
            this.cbWhom.TabIndex = 15;
            this.cbWhom.ValueMember = "id";
            // 
            // bsMasterWhom
            // 
            this.bsMasterWhom.DataMember = "vWorkerGroup";
            this.bsMasterWhom.DataSource = this.dsGraphic;
            // 
            // labelWho
            // 
            this.labelWho.AutoSize = true;
            this.labelWho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWho.Location = new System.Drawing.Point(550, 18);
            this.labelWho.Name = "labelWho";
            this.labelWho.Size = new System.Drawing.Size(109, 20);
            this.labelWho.TabIndex = 14;
            this.labelWho.Text = "Кто выдает";
            // 
            // labelWhom
            // 
            this.labelWhom.AutoSize = true;
            this.labelWhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhom.Location = new System.Drawing.Point(222, 18);
            this.labelWhom.Name = "labelWhom";
            this.labelWhom.Size = new System.Drawing.Size(119, 20);
            this.labelWhom.TabIndex = 13;
            this.labelWhom.Text = "Кому выдать";
            // 
            // tbOrderN
            // 
            this.tbOrderN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOrderN.Location = new System.Drawing.Point(170, 15);
            this.tbOrderN.Name = "tbOrderN";
            this.tbOrderN.Size = new System.Drawing.Size(46, 26);
            this.tbOrderN.TabIndex = 12;
            // 
            // labelOrderN
            // 
            this.labelOrderN.AutoSize = true;
            this.labelOrderN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderN.Location = new System.Drawing.Point(13, 18);
            this.labelOrderN.Name = "labelOrderN";
            this.labelOrderN.Size = new System.Drawing.Size(151, 20);
            this.labelOrderN.TabIndex = 11;
            this.labelOrderN.Text = "№ распоряжения";
            // 
            // panelWait
            // 
            this.panelWait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelWait.Controls.Add(this.groupBox2);
            this.panelWait.Location = new System.Drawing.Point(287, 103);
            this.panelWait.Name = "panelWait";
            this.panelWait.Size = new System.Drawing.Size(298, 61);
            this.panelWait.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Идет формирование отчета.";
            // 
            // FormGraphicPointOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 597);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormGraphicPointOrder";
            this.Text = "Распоряжения";
            this.Load += new System.EventHandler(this.FormGraphicPointOrder_Load);
            this.Shown += new System.EventHandler(this.FormGraphicPointOrder_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGraphic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStripMainOrder.ResumeLayout(false);
            this.toolStripMainOrder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMasterWho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMasterWhom)).EndInit();
            this.panelWait.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet.DataSetGraphic dsGraphic;
        private System.Windows.Forms.BindingSource bsOrder;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvOrder;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStripMainOrder;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxOrderFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbWho;
        private System.Windows.Forms.ComboBox cbWhom;
        private System.Windows.Forms.Label labelWho;
        private System.Windows.Forms.Label labelWhom;
        private System.Windows.Forms.TextBox tbOrderN;
        private System.Windows.Forms.Label labelOrderN;
        private System.Windows.Forms.ToolStripButton tsbCheckFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbUncheck;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeAbnDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abnPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberObjDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameObjDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn schmObjNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterIDDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn numberDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterDCheckStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDCheckStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerSetDataGridViewTextBoxColumn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerOrder;
        private System.Windows.Forms.BindingSource bsMasterWho;
        private System.Windows.Forms.BindingSource bsMasterWhom;
        private System.Windows.Forms.Panel panelWait;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}