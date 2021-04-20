namespace Legal.Forms.Object
{
    partial class FormAbnObjPoint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsDop1 = new Legal.DataSet.dsDop();
            this.dogovorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDop1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvList.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dogovorDataGridViewTextBoxColumn,
            this.consumerDataGridViewTextBoxColumn,
            this.nameObjectDataGridViewTextBoxColumn,
            this.powerObjectDataGridViewTextBoxColumn,
            this.voltageDataGridViewTextBoxColumn,
            this.tariffDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.dtPayDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bindingSource1;
            this.dgvList.Location = new System.Drawing.Point(0, 2);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.NumbLineVisible = false;
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersWidth = 5;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(581, 480);
            this.dgvList.TabIndex = 3;
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(177, 57);
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
            this.btnPlus.Location = new System.Drawing.Point(177, 28);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(16, 23);
            this.btnPlus.TabIndex = 67;
            this.btnPlus.Text = ">";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "с:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "по:";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(30, 58);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 66;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(30, 29);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtBegin);
            this.groupBox1.Controls.Add(this.btnMinus);
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(586, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 104);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "За период";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(634, 377);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(113, 23);
            this.btnOK.TabIndex = 70;
            this.btnOK.Text = "Сформировать";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(634, 438);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 23);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(634, 318);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(113, 23);
            this.btnExcel.TabIndex = 72;
            this.btnExcel.Text = "Экспорт в Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "vG_AbnObjPoint_Voltage";
            this.bindingSource1.DataSource = this.dsDop1;
            // 
            // dsDop1
            // 
            this.dsDop1.DataSetName = "dsDop";
            this.dsDop1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dogovorDataGridViewTextBoxColumn
            // 
            this.dogovorDataGridViewTextBoxColumn.DataPropertyName = "Dogovor";
            this.dogovorDataGridViewTextBoxColumn.HeaderText = "Договор";
            this.dogovorDataGridViewTextBoxColumn.Name = "dogovorDataGridViewTextBoxColumn";
            this.dogovorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consumerDataGridViewTextBoxColumn
            // 
            this.consumerDataGridViewTextBoxColumn.DataPropertyName = "Consumer";
            this.consumerDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.consumerDataGridViewTextBoxColumn.Name = "consumerDataGridViewTextBoxColumn";
            this.consumerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameObjectDataGridViewTextBoxColumn
            // 
            this.nameObjectDataGridViewTextBoxColumn.DataPropertyName = "NameObject";
            this.nameObjectDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameObjectDataGridViewTextBoxColumn.Name = "nameObjectDataGridViewTextBoxColumn";
            this.nameObjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powerObjectDataGridViewTextBoxColumn
            // 
            this.powerObjectDataGridViewTextBoxColumn.DataPropertyName = "PowerObject";
            this.powerObjectDataGridViewTextBoxColumn.HeaderText = "Мощность";
            this.powerObjectDataGridViewTextBoxColumn.Name = "powerObjectDataGridViewTextBoxColumn";
            this.powerObjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voltageDataGridViewTextBoxColumn
            // 
            this.voltageDataGridViewTextBoxColumn.DataPropertyName = "Voltage";
            this.voltageDataGridViewTextBoxColumn.HeaderText = "Напряжение";
            this.voltageDataGridViewTextBoxColumn.Name = "voltageDataGridViewTextBoxColumn";
            this.voltageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tariffDataGridViewTextBoxColumn
            // 
            this.tariffDataGridViewTextBoxColumn.DataPropertyName = "Tariff";
            this.tariffDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.tariffDataGridViewTextBoxColumn.Name = "tariffDataGridViewTextBoxColumn";
            this.tariffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Объем";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtPayDataGridViewTextBoxColumn
            // 
            this.dtPayDataGridViewTextBoxColumn.DataPropertyName = "dtPay";
            this.dtPayDataGridViewTextBoxColumn.HeaderText = "dtPay";
            this.dtPayDataGridViewTextBoxColumn.Name = "dtPayDataGridViewTextBoxColumn";
            this.dtPayDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtPayDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormAbnObjPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 485);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvList);
            this.Name = "FormAbnObjPoint";
            this.Text = "Реестр точек подключения по уровню напряжения";
            this.Load += new System.EventHandler(this.FormAbnObjPoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDop1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvList;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private DataSet.dsDop dsDop1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogovorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPayDataGridViewTextBoxColumn;
    }
}