namespace Contractor.Forms
{
    partial class FormAddEditContracor
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
            this.dsContr = new Contractor.DataSets.DataSetCont();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonUL = new System.Windows.Forms.RadioButton();
            this.radioButtonFL = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsContr)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsContr
            // 
            this.dsContr.DataSetName = "DataSetCont";
            this.dsContr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFL);
            this.groupBox1.Controls.Add(this.radioButtonUL);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonUL
            // 
            this.radioButtonUL.AutoSize = true;
            this.radioButtonUL.Checked = true;
            this.radioButtonUL.Location = new System.Drawing.Point(9, 15);
            this.radioButtonUL.Name = "radioButtonUL";
            this.radioButtonUL.Size = new System.Drawing.Size(120, 17);
            this.radioButtonUL.TabIndex = 0;
            this.radioButtonUL.TabStop = true;
            this.radioButtonUL.Text = "Юридическое лицо";
            this.radioButtonUL.UseVisualStyleBackColor = true;
            // 
            // radioButtonFL
            // 
            this.radioButtonFL.AutoSize = true;
            this.radioButtonFL.Location = new System.Drawing.Point(135, 15);
            this.radioButtonFL.Name = "radioButtonFL";
            this.radioButtonFL.Size = new System.Drawing.Size(116, 17);
            this.radioButtonFL.TabIndex = 1;
            this.radioButtonFL.Text = "Физическое лицо";
            this.radioButtonFL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя контрагента";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(7, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(411, 20);
            this.txtName.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(7, 91);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(343, 91);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddEditContracor
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(422, 121);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEditContracor";
            this.Text = "FormAddEditContracor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddEditContracor_FormClosing);
            this.Load += new System.EventHandler(this.FormAddEditContracor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsContr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DataSetCont dsContr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFL;
        private System.Windows.Forms.RadioButton radioButtonUL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}