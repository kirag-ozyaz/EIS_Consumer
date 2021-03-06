namespace Legal.Forms.Meter
{
    partial class FormMeter_ControlUchet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsDop1 = new Legal.DataSet.dsDop();
            this.typeDogovorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uchetSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.differDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDop1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnMinus);
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.dtBegin);
            this.groupBox1.Location = new System.Drawing.Point(719, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 87);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "За период:";
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(179, 47);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(16, 23);
            this.btnMinus.TabIndex = 69;
            this.btnMinus.Text = "<";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(179, 18);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(16, 23);
            this.btnPlus.TabIndex = 68;
            this.btnPlus.Text = ">";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "с:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "по:";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(32, 48);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 67;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(32, 19);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 66;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(922, 25);
            this.toolStrip1.TabIndex = 67;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDogovorDataGridViewTextBoxColumn,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.numberObjDataGridViewTextBoxColumn,
            this.abonentDataGridViewTextBoxColumn,
            this.objectDataGridViewTextBoxColumn,
            this.tariffDataGridViewTextBoxColumn,
            this.uchetSizeDataGridViewTextBoxColumn,
            this.controlSizeDataGridViewTextBoxColumn,
            this.differDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.Size = new System.Drawing.Size(717, 447);
            this.dataGridView1.TabIndex = 69;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(751, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 23);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnOK.Location = new System.Drawing.Point(751, 382);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(138, 23);
            this.btnOK.TabIndex = 70;
            this.btnOK.Text = "Сформировать";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tMeter_ControlUchet";
            this.bindingSource1.DataSource = this.dsDop1;
            // 
            // dsDop1
            // 
            this.dsDop1.DataSetName = "dsDop";
            this.dsDop1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeDogovorDataGridViewTextBoxColumn
            // 
            this.typeDogovorDataGridViewTextBoxColumn.DataPropertyName = "TypeDogovor";
            this.typeDogovorDataGridViewTextBoxColumn.HeaderText = "тип договора";
            this.typeDogovorDataGridViewTextBoxColumn.Name = "typeDogovorDataGridViewTextBoxColumn";
            this.typeDogovorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "№дог";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 50;
            // 
            // numberObjDataGridViewTextBoxColumn
            // 
            this.numberObjDataGridViewTextBoxColumn.DataPropertyName = "NumberObj";
            this.numberObjDataGridViewTextBoxColumn.HeaderText = "№об";
            this.numberObjDataGridViewTextBoxColumn.Name = "numberObjDataGridViewTextBoxColumn";
            this.numberObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberObjDataGridViewTextBoxColumn.Width = 50;
            // 
            // abonentDataGridViewTextBoxColumn
            // 
            this.abonentDataGridViewTextBoxColumn.DataPropertyName = "Abonent";
            this.abonentDataGridViewTextBoxColumn.HeaderText = "наименование";
            this.abonentDataGridViewTextBoxColumn.Name = "abonentDataGridViewTextBoxColumn";
            this.abonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.abonentDataGridViewTextBoxColumn.Width = 150;
            // 
            // objectDataGridViewTextBoxColumn
            // 
            this.objectDataGridViewTextBoxColumn.DataPropertyName = "Object";
            this.objectDataGridViewTextBoxColumn.HeaderText = "объект";
            this.objectDataGridViewTextBoxColumn.Name = "objectDataGridViewTextBoxColumn";
            this.objectDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectDataGridViewTextBoxColumn.Width = 200;
            // 
            // tariffDataGridViewTextBoxColumn
            // 
            this.tariffDataGridViewTextBoxColumn.DataPropertyName = "Tariff";
            this.tariffDataGridViewTextBoxColumn.HeaderText = "напр";
            this.tariffDataGridViewTextBoxColumn.Name = "tariffDataGridViewTextBoxColumn";
            this.tariffDataGridViewTextBoxColumn.ReadOnly = true;
            this.tariffDataGridViewTextBoxColumn.Width = 50;
            // 
            // uchetSizeDataGridViewTextBoxColumn
            // 
            this.uchetSizeDataGridViewTextBoxColumn.DataPropertyName = "UchetSize";
            this.uchetSizeDataGridViewTextBoxColumn.HeaderText = "расчетный квт.ч";
            this.uchetSizeDataGridViewTextBoxColumn.Name = "uchetSizeDataGridViewTextBoxColumn";
            this.uchetSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // controlSizeDataGridViewTextBoxColumn
            // 
            this.controlSizeDataGridViewTextBoxColumn.DataPropertyName = "ControlSize";
            this.controlSizeDataGridViewTextBoxColumn.HeaderText = "контрольный квт.ч";
            this.controlSizeDataGridViewTextBoxColumn.Name = "controlSizeDataGridViewTextBoxColumn";
            this.controlSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // differDataGridViewTextBoxColumn
            // 
            this.differDataGridViewTextBoxColumn.DataPropertyName = "Differ";
            this.differDataGridViewTextBoxColumn.HeaderText = "разногласия";
            this.differDataGridViewTextBoxColumn.Name = "differDataGridViewTextBoxColumn";
            this.differDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnExport
            // 
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExport.Image = global::Legal.Properties.Resources.xlsx_mac;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(23, 22);
            this.btnExport.Text = "Экспорт в Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormMeter_ControlUchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 476);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMeter_ControlUchet";
            this.Text = "Отчет по разногласии по контрольным и расчетным приборам учета";
            this.Load += new System.EventHandler(this.FormMeter_ControlUchet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDop1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private DataSet.dsDop dsDop1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDogovorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uchetSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn differDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnExport;
    }
}