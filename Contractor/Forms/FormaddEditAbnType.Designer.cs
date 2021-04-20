namespace Contractor.Forms
{
    partial class FormaddEditAbnType
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
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonОК = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.ds = new Contractor.DataSets.DataSetCont();
            this.tRClassifierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClassifierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.DataSource = this.tRClassifierBindingSource;
            this.cmbType.DisplayMember = "Name";
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(12, 25);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(370, 21);
            this.cmbType.TabIndex = 0;
            this.cmbType.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип контрагента";
            // 
            // buttonОК
            // 
            this.buttonОК.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonОК.Location = new System.Drawing.Point(12, 67);
            this.buttonОК.Name = "buttonОК";
            this.buttonОК.Size = new System.Drawing.Size(75, 23);
            this.buttonОК.TabIndex = 2;
            this.buttonОК.Text = "ОК";
            this.buttonОК.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(307, 67);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ds
            // 
            this.ds.DataSetName = "DataSetCont";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRClassifierBindingSource
            // 
            this.tRClassifierBindingSource.DataMember = "tR_Classifier";
            this.tRClassifierBindingSource.DataSource = this.ds;
            // 
            // FormaddEditAbnType
            // 
            this.AcceptButton = this.buttonОК;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(391, 102);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonОК);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaddEditAbnType";
            this.Text = "FormaddEditAbnType";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormaddEditAbnType_FormClosing);
            this.Load += new System.EventHandler(this.FormaddEditAbnType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClassifierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonОК;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.BindingSource tRClassifierBindingSource;
        private DataSets.DataSetCont ds;
    }
}