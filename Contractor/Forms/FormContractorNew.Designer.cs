namespace Contractor.Forms
{
    partial class FormContractorNew
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
            this.ds = new Contractor.DataSets.DataSetCont();
            this.dgv = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bsAbn = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewExcelFilter2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeAbnDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.typeNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameSocrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reasonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datechangeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReasonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bWork = new System.ComponentModel.BackgroundWorker();
            this.idDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeNameSocrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datechangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbn)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelFilter2)).BeginInit();
            this.SuspendLayout();
            // 
            // ds
            // 
            this.ds.DataSetName = "DataSetCont";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDgvColumn,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeAbnDataGridViewTextBoxColumn,
            this.idWorkerDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn,
            this.typeNameDataGridViewTextBoxColumn,
            this.typeNameSocrDataGridViewTextBoxColumn,
            this.workerDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.datechangeDataGridViewTextBoxColumn,
            this.idReasonDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsAbn;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 21;
            this.dgv.Size = new System.Drawing.Size(872, 298);
            this.dgv.TabIndex = 0;
            this.dgv.VirtualMode = true;
            this.dgv.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridViewExcelFilter1_CellValueNeeded);
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewExcelFilter1_DataError);
            // 
            // bsAbn
            // 
            this.bsAbn.DataMember = "vAbn";
            this.bsAbn.DataSource = this.ds;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewExcelFilter2);
            this.splitContainer1.Size = new System.Drawing.Size(872, 596);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridViewExcelFilter2
            // 
            this.dataGridViewExcelFilter2.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter2.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter2.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcelFilter2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.codeAbonentDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.typeAbnDataGridViewTextBoxColumn1,
            this.idWorkerDataGridViewTextBoxColumn1,
            this.deletedDataGridViewCheckBoxColumn1,
            this.typeNameDataGridViewTextBoxColumn1,
            this.typeNameSocrDataGridViewTextBoxColumn1,
            this.workerDataGridViewTextBoxColumn1,
            this.isActiveDataGridViewCheckBoxColumn1,
            this.reasonDataGridViewTextBoxColumn1,
            this.datechangeDataGridViewTextBoxColumn1,
            this.idReasonDataGridViewTextBoxColumn1});
            this.dataGridViewExcelFilter2.DataSource = this.bsAbn;
            this.dataGridViewExcelFilter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExcelFilter2.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewExcelFilter2.Name = "dataGridViewExcelFilter2";
            this.dataGridViewExcelFilter2.ReadOnly = true;
            this.dataGridViewExcelFilter2.RowHeadersWidth = 21;
            this.dataGridViewExcelFilter2.Size = new System.Drawing.Size(872, 294);
            this.dataGridViewExcelFilter2.TabIndex = 0;
            this.dataGridViewExcelFilter2.VirtualMode = true;
            this.dataGridViewExcelFilter2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewExcelFilter2_DataError);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // codeAbonentDataGridViewTextBoxColumn1
            // 
            this.codeAbonentDataGridViewTextBoxColumn1.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn1.HeaderText = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn1.Name = "codeAbonentDataGridViewTextBoxColumn1";
            this.codeAbonentDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeAbnDataGridViewTextBoxColumn1
            // 
            this.typeAbnDataGridViewTextBoxColumn1.DataPropertyName = "TypeAbn";
            this.typeAbnDataGridViewTextBoxColumn1.HeaderText = "TypeAbn";
            this.typeAbnDataGridViewTextBoxColumn1.Name = "typeAbnDataGridViewTextBoxColumn1";
            this.typeAbnDataGridViewTextBoxColumn1.ReadOnly = true;
            this.typeAbnDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idWorkerDataGridViewTextBoxColumn1
            // 
            this.idWorkerDataGridViewTextBoxColumn1.DataPropertyName = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn1.HeaderText = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn1.Name = "idWorkerDataGridViewTextBoxColumn1";
            this.idWorkerDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // deletedDataGridViewCheckBoxColumn1
            // 
            this.deletedDataGridViewCheckBoxColumn1.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn1.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn1.Name = "deletedDataGridViewCheckBoxColumn1";
            this.deletedDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // typeNameDataGridViewTextBoxColumn1
            // 
            this.typeNameDataGridViewTextBoxColumn1.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn1.HeaderText = "TypeName";
            this.typeNameDataGridViewTextBoxColumn1.Name = "typeNameDataGridViewTextBoxColumn1";
            this.typeNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeNameSocrDataGridViewTextBoxColumn1
            // 
            this.typeNameSocrDataGridViewTextBoxColumn1.DataPropertyName = "TypeNameSocr";
            this.typeNameSocrDataGridViewTextBoxColumn1.HeaderText = "TypeNameSocr";
            this.typeNameSocrDataGridViewTextBoxColumn1.Name = "typeNameSocrDataGridViewTextBoxColumn1";
            this.typeNameSocrDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // workerDataGridViewTextBoxColumn1
            // 
            this.workerDataGridViewTextBoxColumn1.DataPropertyName = "Worker";
            this.workerDataGridViewTextBoxColumn1.HeaderText = "Worker";
            this.workerDataGridViewTextBoxColumn1.Name = "workerDataGridViewTextBoxColumn1";
            this.workerDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn1
            // 
            this.isActiveDataGridViewCheckBoxColumn1.DataPropertyName = "isActive";
            this.isActiveDataGridViewCheckBoxColumn1.HeaderText = "isActive";
            this.isActiveDataGridViewCheckBoxColumn1.Name = "isActiveDataGridViewCheckBoxColumn1";
            this.isActiveDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn1
            // 
            this.reasonDataGridViewTextBoxColumn1.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn1.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn1.Name = "reasonDataGridViewTextBoxColumn1";
            this.reasonDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // datechangeDataGridViewTextBoxColumn1
            // 
            this.datechangeDataGridViewTextBoxColumn1.DataPropertyName = "datechange";
            this.datechangeDataGridViewTextBoxColumn1.HeaderText = "datechange";
            this.datechangeDataGridViewTextBoxColumn1.Name = "datechangeDataGridViewTextBoxColumn1";
            this.datechangeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idReasonDataGridViewTextBoxColumn1
            // 
            this.idReasonDataGridViewTextBoxColumn1.DataPropertyName = "idReason";
            this.idReasonDataGridViewTextBoxColumn1.HeaderText = "idReason";
            this.idReasonDataGridViewTextBoxColumn1.Name = "idReasonDataGridViewTextBoxColumn1";
            this.idReasonDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bWork
            // 
            this.bWork.WorkerReportsProgress = true;
            this.bWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWork_DoWork);
            this.bWork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bWork_ProgressChanged);
            this.bWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWork_RunWorkerCompleted);
            // 
            // idDgvColumn
            // 
            this.idDgvColumn.DataPropertyName = "id";
            this.idDgvColumn.HeaderText = "id";
            this.idDgvColumn.Name = "idDgvColumn";
            this.idDgvColumn.ReadOnly = true;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeAbnDataGridViewTextBoxColumn
            // 
            this.typeAbnDataGridViewTextBoxColumn.DataPropertyName = "TypeAbn";
            this.typeAbnDataGridViewTextBoxColumn.HeaderText = "TypeAbn";
            this.typeAbnDataGridViewTextBoxColumn.Name = "typeAbnDataGridViewTextBoxColumn";
            this.typeAbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idWorkerDataGridViewTextBoxColumn
            // 
            this.idWorkerDataGridViewTextBoxColumn.DataPropertyName = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn.HeaderText = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn.Name = "idWorkerDataGridViewTextBoxColumn";
            this.idWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeNameSocrDataGridViewTextBoxColumn
            // 
            this.typeNameSocrDataGridViewTextBoxColumn.DataPropertyName = "TypeNameSocr";
            this.typeNameSocrDataGridViewTextBoxColumn.HeaderText = "TypeNameSocr";
            this.typeNameSocrDataGridViewTextBoxColumn.Name = "typeNameSocrDataGridViewTextBoxColumn";
            this.typeNameSocrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workerDataGridViewTextBoxColumn
            // 
            this.workerDataGridViewTextBoxColumn.DataPropertyName = "Worker";
            this.workerDataGridViewTextBoxColumn.HeaderText = "Worker";
            this.workerDataGridViewTextBoxColumn.Name = "workerDataGridViewTextBoxColumn";
            this.workerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datechangeDataGridViewTextBoxColumn
            // 
            this.datechangeDataGridViewTextBoxColumn.DataPropertyName = "datechange";
            this.datechangeDataGridViewTextBoxColumn.HeaderText = "datechange";
            this.datechangeDataGridViewTextBoxColumn.Name = "datechangeDataGridViewTextBoxColumn";
            this.datechangeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idReasonDataGridViewTextBoxColumn
            // 
            this.idReasonDataGridViewTextBoxColumn.DataPropertyName = "idReason";
            this.idReasonDataGridViewTextBoxColumn.HeaderText = "idReason";
            this.idReasonDataGridViewTextBoxColumn.Name = "idReasonDataGridViewTextBoxColumn";
            this.idReasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormContractorNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 596);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormContractorNew";
            this.Text = "FormContractorNew";
            this.Load += new System.EventHandler(this.FormContractorNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbn)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelFilter2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSets.DataSetCont ds;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgv;
        private System.Windows.Forms.BindingSource bsAbn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn typeAbnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameSocrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datechangeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReasonDataGridViewTextBoxColumn1;
        private System.ComponentModel.BackgroundWorker bWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeAbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameSocrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datechangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReasonDataGridViewTextBoxColumn;
    }
}