namespace Prv.Forms.Files
{
    partial class FormAbnFilesAddEditFolder
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxFolderName = new System.Windows.Forms.TextBox();
            this.bsFolder = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrv = new Prv.DataSets.DataSetPrv();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrv)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(259, 39);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxFolderName
            // 
            this.textBoxFolderName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFolder, "FileName", true));
            this.textBoxFolderName.Location = new System.Drawing.Point(12, 12);
            this.textBoxFolderName.Name = "textBoxFolderName";
            this.textBoxFolderName.Size = new System.Drawing.Size(322, 20);
            this.textBoxFolderName.TabIndex = 6;
            // 
            // bsFolder
            // 
            this.bsFolder.DataMember = "tAbn_Files";
            this.bsFolder.DataSource = this.dsPrv;
            // 
            // dsPrv
            // 
            this.dsPrv.DataSetName = "DataSetPrv";
            this.dsPrv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 39);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Сохранить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAbnFilesAddEditFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 73);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxFolderName);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAbnFilesAddEditFolder";
            this.Text = "Добавить папку";
            this.Load += new System.EventHandler(this.FormAbnFilesAddFolder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxFolderName;
        private System.Windows.Forms.BindingSource bsFolder;
        private DataSets.DataSetPrv dsPrv;
        private System.Windows.Forms.Button buttonAdd;
    }
}