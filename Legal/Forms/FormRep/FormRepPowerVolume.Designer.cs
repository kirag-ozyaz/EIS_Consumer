namespace Legal.Forms.FormRep
{
    partial class FormRepPowerVolume
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
            System.Windows.Forms.Button btnExcel;
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.dgv = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dsCalc1 = new Legal.DataSet.dsCalc();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameShortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excessVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            btnExcel.Location = new System.Drawing.Point(39, 218);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new System.Drawing.Size(131, 23);
            btnExcel.TabIndex = 113;
            btnExcel.Text = "экспорт в Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(176, 64);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(16, 23);
            this.btnMinus.TabIndex = 103;
            this.btnMinus.Text = "<";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(176, 35);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(16, 23);
            this.btnPlus.TabIndex = 102;
            this.btnPlus.Text = ">";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "За период:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "с:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "по:";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(39, 63);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 101;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(39, 34);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 100;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(39, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 23);
            this.btnCancel.TabIndex = 112;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(39, 168);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(131, 23);
            this.btnReport.TabIndex = 111;
            this.btnReport.Text = "Сформировать";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nameShortDataGridViewTextBoxColumn,
            this.objNameDataGridViewTextBoxColumn,
            this.powerVolumeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.excessVolumeDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bindingSource1;
            this.dgv.Location = new System.Drawing.Point(198, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 5;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(616, 394);
            this.dgv.TabIndex = 114;
            // 
            // dsCalc1
            // 
            this.dsCalc1.DataSetName = "dsCalc";
            this.dsCalc1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tG_ReportPowerVolume";
            this.bindingSource1.DataSource = this.dsCalc1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodeAbonent";
            this.dataGridViewTextBoxColumn1.HeaderText = "Договор";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameShortDataGridViewTextBoxColumn
            // 
            this.nameShortDataGridViewTextBoxColumn.DataPropertyName = "NameShort";
            this.nameShortDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.nameShortDataGridViewTextBoxColumn.Name = "nameShortDataGridViewTextBoxColumn";
            this.nameShortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objNameDataGridViewTextBoxColumn
            // 
            this.objNameDataGridViewTextBoxColumn.DataPropertyName = "ObjName";
            this.objNameDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.objNameDataGridViewTextBoxColumn.Name = "objNameDataGridViewTextBoxColumn";
            this.objNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powerVolumeDataGridViewTextBoxColumn
            // 
            this.powerVolumeDataGridViewTextBoxColumn.DataPropertyName = "PowerVolume";
            this.powerVolumeDataGridViewTextBoxColumn.HeaderText = "Расчитанный объем";
            this.powerVolumeDataGridViewTextBoxColumn.Name = "powerVolumeDataGridViewTextBoxColumn";
            this.powerVolumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Полезный отпуск";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // excessVolumeDataGridViewTextBoxColumn
            // 
            this.excessVolumeDataGridViewTextBoxColumn.DataPropertyName = "ExcessVolume";
            this.excessVolumeDataGridViewTextBoxColumn.HeaderText = "Превышение";
            this.excessVolumeDataGridViewTextBoxColumn.Name = "excessVolumeDataGridViewTextBoxColumn";
            this.excessVolumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormRepPowerVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 418);
            this.Controls.Add(this.dgv);
            this.Controls.Add(btnExcel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtBegin);
            this.Name = "FormRepPowerVolume";
            this.Text = "Анализ соотношения потребляемой энергии и установленной мощности ";
            this.Load += new System.EventHandler(this.FormRepPowerVolume_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReport;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameShortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn excessVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet.dsCalc dsCalc1;
    }
}