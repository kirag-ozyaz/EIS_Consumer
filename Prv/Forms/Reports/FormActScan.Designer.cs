namespace Prv.Forms.Reports
{
    partial class FormActScan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripImage = new System.Windows.Forms.ToolStrip();
            this.tsbImage = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveImage = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveImage = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenPrint = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewImages = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.ImageOriginal = new System.Windows.Forms.DataGridViewImageColumn();
            this.Compressed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbScanDoc = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataSetRep = new Prv.DataSets.DataSetRep();
            this.contextMenuStripImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripImage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRep)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripImage
            // 
            this.toolStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbImage,
            this.tsbRemoveImage,
            this.tsbSaveImage,
            this.tsbOpenPrint});
            this.toolStripImage.Location = new System.Drawing.Point(0, 0);
            this.toolStripImage.Name = "toolStripImage";
            this.toolStripImage.Size = new System.Drawing.Size(706, 25);
            this.toolStripImage.Stretch = true;
            this.toolStripImage.TabIndex = 3;
            this.toolStripImage.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // tsbImage
            // 
            this.tsbImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImage.Image = global::Prv.Properties.Resources._1304663065_Add;
            this.tsbImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImage.Name = "tsbImage";
            this.tsbImage.Size = new System.Drawing.Size(23, 22);
            this.tsbImage.Text = "Добавить изображение";
            this.tsbImage.Click += new System.EventHandler(this.tsbImage_Click);
            // 
            // tsbRemoveImage
            // 
            this.tsbRemoveImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveImage.Image = global::Prv.Properties.Resources.Delete;
            this.tsbRemoveImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveImage.Name = "tsbRemoveImage";
            this.tsbRemoveImage.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveImage.Text = "Удалить изображение";
            this.tsbRemoveImage.Click += new System.EventHandler(this.tsbRemoveImage_Click);
            // 
            // tsbSaveImage
            // 
            this.tsbSaveImage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSaveImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveImage.Image = global::Prv.Properties.Resources.filesave;
            this.tsbSaveImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveImage.Name = "tsbSaveImage";
            this.tsbSaveImage.Size = new System.Drawing.Size(23, 22);
            this.tsbSaveImage.Text = "Сохранить изображение в файл для просмотра и печати";
            this.tsbSaveImage.Click += new System.EventHandler(this.tsbSaveImage_Click);
            // 
            // tsbOpenPrint
            // 
            this.tsbOpenPrint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbOpenPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenPrint.Image = global::Prv.Properties.Resources.Print;
            this.tsbOpenPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenPrint.Name = "tsbOpenPrint";
            this.tsbOpenPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbOpenPrint.Text = "Открыть и напечатать изображение";
            this.tsbOpenPrint.Click += new System.EventHandler(this.tsbOpenPrint_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(2, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 573);
            this.panel1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewImages);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbScanDoc);
            this.splitContainer1.Size = new System.Drawing.Size(704, 573);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewImages
            // 
            this.dataGridViewImages.AllowUserToAddRows = false;
            this.dataGridViewImages.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImages.ColumnHeadersVisible = false;
            this.dataGridViewImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.ImageOriginal,
            this.Compressed,
            this.id});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImages.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImages.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewImages.Name = "dataGridViewImages";
            this.dataGridViewImages.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImages.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImages.RowHeadersWidth = 4;
            this.dataGridViewImages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewImages.RowTemplate.Height = 200;
            this.dataGridViewImages.Size = new System.Drawing.Size(185, 573);
            this.dataGridViewImages.TabIndex = 41;
            this.dataGridViewImages.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewImages_CellMouseClick);
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.image.HeaderText = "image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            // 
            // ImageOriginal
            // 
            this.ImageOriginal.HeaderText = "ImageOriginal";
            this.ImageOriginal.Name = "ImageOriginal";
            this.ImageOriginal.ReadOnly = true;
            this.ImageOriginal.Visible = false;
            // 
            // Compressed
            // 
            this.Compressed.HeaderText = "Compressed";
            this.Compressed.Name = "Compressed";
            this.Compressed.ReadOnly = true;
            this.Compressed.Visible = false;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // pbScanDoc
            // 
            this.pbScanDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbScanDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbScanDoc.Location = new System.Drawing.Point(0, 0);
            this.pbScanDoc.Name = "pbScanDoc";
            this.pbScanDoc.Size = new System.Drawing.Size(515, 573);
            this.pbScanDoc.TabIndex = 2;
            this.pbScanDoc.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(642, 602);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(52, 27);
            this.buttonExit.TabIndex = 33;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dataSetRep
            // 
            this.dataSetRep.DataSetName = "DataSetRep";
            this.dataSetRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStripImage
            // 
            this.contextMenuStripImage.Name = "contextMenuStripImage";
            this.contextMenuStripImage.Size = new System.Drawing.Size(61, 4);
            // 
            // FormActScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 636);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripImage);
            this.Name = "FormActScan";
            this.Text = "Акт";
            this.Load += new System.EventHandler(this.FormActScan_Load);
            this.toolStripImage.ResumeLayout(false);
            this.toolStripImage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripImage;
        private System.Windows.Forms.ToolStripButton tsbImage;
        private System.Windows.Forms.ToolStripButton tsbRemoveImage;
        private System.Windows.Forms.ToolStripButton tsbSaveImage;
        private System.Windows.Forms.ToolStripButton tsbOpenPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewImages;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewImageColumn ImageOriginal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Compressed;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.PictureBox pbScanDoc;
        private System.Windows.Forms.Button buttonExit;
        private DataSets.DataSetRep dataSetRep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImage;
    }
}