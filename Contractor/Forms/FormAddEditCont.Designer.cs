namespace Contractor.Forms
{
    partial class FormAddEditCont
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label codeAbonentLabel;
            System.Windows.Forms.Label nameFullLabel;
            System.Windows.Forms.Label bankAcntLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label bankDestLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label bankIDLabel;
            System.Windows.Forms.Label oKVEDLabel;
            System.Windows.Forms.Label oKPOLabel;
            System.Windows.Forms.Label postLabel;
            System.Windows.Forms.Label i_OLabel;
            System.Windows.Forms.Label i_ILabel;
            System.Windows.Forms.Label i_FLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label r_OLabel;
            System.Windows.Forms.Label r_ILabel;
            System.Windows.Forms.Label r_FLabel;
            System.Windows.Forms.Label d_OLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label d_ILabel;
            System.Windows.Forms.Label d_FLabel;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label t_OLabel;
            System.Windows.Forms.Label t_ILabel;
            System.Windows.Forms.Label t_FLabel;
            this.btnFindCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.MaskedTextBox();
            this.dsCont = new Contractor.DataSets.DataSetCont();
            this.labelTypeAbn = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.richTextBoxName = new System.Windows.Forms.RichTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.gbCont = new System.Windows.Forms.GroupBox();
            this.tabControlAbn = new System.Windows.Forms.TabControl();
            this.tabPageAbnInfo = new System.Windows.Forms.TabPage();
            this.tsAbnInfo = new System.Windows.Forms.ToolStrip();
            this.tsbAddAbnInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbInfoHistory = new System.Windows.Forms.ToolStripButton();
            this.nameFullTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.bankAcntTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.bankDestTextBox = new System.Windows.Forms.TextBox();
            this.oKVEDTextBox = new System.Windows.Forms.TextBox();
            this.bankIDTextBox = new System.Windows.Forms.TextBox();
            this.oKPOTextBox = new System.Windows.Forms.TextBox();
            this.tabPageDirector = new System.Windows.Forms.TabPage();
            this.tsDirector = new System.Windows.Forms.ToolStrip();
            this.tsbDirectorAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDirectorEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDirectorHistory = new System.Windows.Forms.ToolStripButton();
            this.tabControlDirectorFIO = new System.Windows.Forms.TabControl();
            this.tabPageI = new System.Windows.Forms.TabPage();
            this.I_postTextBox = new System.Windows.Forms.TextBox();
            this.i_OTextBox = new System.Windows.Forms.TextBox();
            this.i_ITextBox = new System.Windows.Forms.TextBox();
            this.i_FTextBox = new System.Windows.Forms.TextBox();
            this.tabPageR = new System.Windows.Forms.TabPage();
            this.R_postTextBox = new System.Windows.Forms.TextBox();
            this.r_OTextBox = new System.Windows.Forms.TextBox();
            this.r_ITextBox = new System.Windows.Forms.TextBox();
            this.r_FTextBox = new System.Windows.Forms.TextBox();
            this.tabPageD = new System.Windows.Forms.TabPage();
            this.D_postTextBox = new System.Windows.Forms.TextBox();
            this.d_OTextBox = new System.Windows.Forms.TextBox();
            this.d_ITextBox = new System.Windows.Forms.TextBox();
            this.d_FTextBox = new System.Windows.Forms.TextBox();
            this.tabPageT = new System.Windows.Forms.TabPage();
            this.T_postTextBox = new System.Windows.Forms.TextBox();
            this.t_OTextBox = new System.Windows.Forms.TextBox();
            this.t_ITextBox = new System.Windows.Forms.TextBox();
            this.t_FTextBox = new System.Windows.Forms.TextBox();
            this.tabPageAddress = new System.Windows.Forms.TabPage();
            this.tsAddress = new System.Windows.Forms.ToolStrip();
            this.tsbAddressHistory = new System.Windows.Forms.ToolStripButton();
            this.groupBoxAddressP = new System.Windows.Forms.GroupBox();
            this.richTextBoxAddressP = new System.Windows.Forms.RichTextBox();
            this.groupBoxAddressL = new System.Windows.Forms.GroupBox();
            this.richTextBoxAddressL = new System.Windows.Forms.RichTextBox();
            this.tabPageContacts = new System.Windows.Forms.TabPage();
            this.dGVAbnContact = new System.Windows.Forms.DataGridView();
            this.idDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAbnContact = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContact = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewContact = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditContac = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelContact = new System.Windows.Forms.ToolStripButton();
            nameLabel = new System.Windows.Forms.Label();
            codeAbonentLabel = new System.Windows.Forms.Label();
            nameFullLabel = new System.Windows.Forms.Label();
            bankAcntLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            bankDestLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            bankIDLabel = new System.Windows.Forms.Label();
            oKVEDLabel = new System.Windows.Forms.Label();
            oKPOLabel = new System.Windows.Forms.Label();
            postLabel = new System.Windows.Forms.Label();
            i_OLabel = new System.Windows.Forms.Label();
            i_ILabel = new System.Windows.Forms.Label();
            i_FLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            r_OLabel = new System.Windows.Forms.Label();
            r_ILabel = new System.Windows.Forms.Label();
            r_FLabel = new System.Windows.Forms.Label();
            d_OLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            d_ILabel = new System.Windows.Forms.Label();
            d_FLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            t_OLabel = new System.Windows.Forms.Label();
            t_ILabel = new System.Windows.Forms.Label();
            t_FLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsCont)).BeginInit();
            this.gbCont.SuspendLayout();
            this.tabControlAbn.SuspendLayout();
            this.tabPageAbnInfo.SuspendLayout();
            this.tsAbnInfo.SuspendLayout();
            this.tabPageDirector.SuspendLayout();
            this.tsDirector.SuspendLayout();
            this.tabControlDirectorFIO.SuspendLayout();
            this.tabPageI.SuspendLayout();
            this.tabPageR.SuspendLayout();
            this.tabPageD.SuspendLayout();
            this.tabPageT.SuspendLayout();
            this.tabPageAddress.SuspendLayout();
            this.tsAddress.SuspendLayout();
            this.groupBoxAddressP.SuspendLayout();
            this.groupBoxAddressL.SuspendLayout();
            this.tabPageContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAbnContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnContact)).BeginInit();
            this.toolStripContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(8, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(110, 17);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "Наименование:";
            // 
            // codeAbonentLabel
            // 
            codeAbonentLabel.AutoSize = true;
            codeAbonentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            codeAbonentLabel.Location = new System.Drawing.Point(15, 22);
            codeAbonentLabel.Name = "codeAbonentLabel";
            codeAbonentLabel.Size = new System.Drawing.Size(37, 17);
            codeAbonentLabel.TabIndex = 15;
            codeAbonentLabel.Text = "Код:";
            // 
            // nameFullLabel
            // 
            nameFullLabel.AutoSize = true;
            nameFullLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameFullLabel.Location = new System.Drawing.Point(9, 41);
            nameFullLabel.Name = "nameFullLabel";
            nameFullLabel.Size = new System.Drawing.Size(82, 13);
            nameFullLabel.TabIndex = 16;
            nameFullLabel.Text = "Полное имя:";
            // 
            // bankAcntLabel
            // 
            bankAcntLabel.AutoSize = true;
            bankAcntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bankAcntLabel.Location = new System.Drawing.Point(38, 202);
            bankAcntLabel.Name = "bankAcntLabel";
            bankAcntLabel.Size = new System.Drawing.Size(105, 13);
            bankAcntLabel.TabIndex = 30;
            bankAcntLabel.Text = "Расчетный счет:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iNNLabel.Location = new System.Drawing.Point(53, 99);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(38, 13);
            iNNLabel.TabIndex = 18;
            iNNLabel.Text = "ИНН:";
            // 
            // bankDestLabel
            // 
            bankDestLabel.AutoSize = true;
            bankDestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bankDestLabel.Location = new System.Drawing.Point(33, 176);
            bankDestLabel.Name = "bankDestLabel";
            bankDestLabel.Size = new System.Drawing.Size(111, 13);
            bankDestLabel.TabIndex = 28;
            bankDestLabel.Text = "Банк получателя:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kPPLabel.Location = new System.Drawing.Point(335, 99);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(37, 13);
            kPPLabel.TabIndex = 20;
            kPPLabel.Text = "КПП:";
            // 
            // bankIDLabel
            // 
            bankIDLabel.AutoSize = true;
            bankIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bankIDLabel.Location = new System.Drawing.Point(19, 150);
            bankIDLabel.Name = "bankIDLabel";
            bankIDLabel.Size = new System.Drawing.Size(127, 13);
            bankIDLabel.TabIndex = 26;
            bankIDLabel.Text = "Банк плательщика :";
            // 
            // oKVEDLabel
            // 
            oKVEDLabel.AutoSize = true;
            oKVEDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            oKVEDLabel.Location = new System.Drawing.Point(39, 121);
            oKVEDLabel.Name = "oKVEDLabel";
            oKVEDLabel.Size = new System.Drawing.Size(54, 13);
            oKVEDLabel.TabIndex = 22;
            oKVEDLabel.Text = "ОКВЕД:";
            // 
            // oKPOLabel
            // 
            oKPOLabel.AutoSize = true;
            oKPOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            oKPOLabel.Location = new System.Drawing.Point(327, 121);
            oKPOLabel.Name = "oKPOLabel";
            oKPOLabel.Size = new System.Drawing.Size(46, 13);
            oKPOLabel.TabIndex = 24;
            oKPOLabel.Text = "ОКПО:";
            // 
            // postLabel
            // 
            postLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            postLabel.AutoSize = true;
            postLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            postLabel.Location = new System.Drawing.Point(12, 15);
            postLabel.Name = "postLabel";
            postLabel.Size = new System.Drawing.Size(95, 17);
            postLabel.TabIndex = 32;
            postLabel.Text = "Должность:";
            // 
            // i_OLabel
            // 
            i_OLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            i_OLabel.AutoSize = true;
            i_OLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            i_OLabel.Location = new System.Drawing.Point(23, 130);
            i_OLabel.Name = "i_OLabel";
            i_OLabel.Size = new System.Drawing.Size(84, 17);
            i_OLabel.TabIndex = 42;
            i_OLabel.Text = "Отчество:";
            // 
            // i_ILabel
            // 
            i_ILabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            i_ILabel.AutoSize = true;
            i_ILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            i_ILabel.Location = new System.Drawing.Point(64, 95);
            i_ILabel.Name = "i_ILabel";
            i_ILabel.Size = new System.Drawing.Size(43, 17);
            i_ILabel.TabIndex = 40;
            i_ILabel.Text = "Имя:";
            // 
            // i_FLabel
            // 
            i_FLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            i_FLabel.AutoSize = true;
            i_FLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            i_FLabel.Location = new System.Drawing.Point(25, 58);
            i_FLabel.Name = "i_FLabel";
            i_FLabel.Size = new System.Drawing.Size(82, 17);
            i_FLabel.TabIndex = 38;
            i_FLabel.Text = "Фамилия:";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(12, 15);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(95, 17);
            label5.TabIndex = 34;
            label5.Text = "Должность:";
            // 
            // r_OLabel
            // 
            r_OLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            r_OLabel.AutoSize = true;
            r_OLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            r_OLabel.Location = new System.Drawing.Point(23, 130);
            r_OLabel.Name = "r_OLabel";
            r_OLabel.Size = new System.Drawing.Size(84, 17);
            r_OLabel.TabIndex = 52;
            r_OLabel.Text = "Отчество:";
            // 
            // r_ILabel
            // 
            r_ILabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            r_ILabel.AutoSize = true;
            r_ILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            r_ILabel.Location = new System.Drawing.Point(64, 95);
            r_ILabel.Name = "r_ILabel";
            r_ILabel.Size = new System.Drawing.Size(43, 17);
            r_ILabel.TabIndex = 50;
            r_ILabel.Text = "Имя:";
            // 
            // r_FLabel
            // 
            r_FLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            r_FLabel.AutoSize = true;
            r_FLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            r_FLabel.Location = new System.Drawing.Point(25, 58);
            r_FLabel.Name = "r_FLabel";
            r_FLabel.Size = new System.Drawing.Size(82, 17);
            r_FLabel.TabIndex = 48;
            r_FLabel.Text = "Фамилия:";
            r_FLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // d_OLabel
            // 
            d_OLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            d_OLabel.AutoSize = true;
            d_OLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            d_OLabel.Location = new System.Drawing.Point(23, 130);
            d_OLabel.Name = "d_OLabel";
            d_OLabel.Size = new System.Drawing.Size(84, 17);
            d_OLabel.TabIndex = 58;
            d_OLabel.Text = "Отчество:";
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.Location = new System.Drawing.Point(12, 15);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(95, 17);
            label6.TabIndex = 36;
            label6.Text = "Должность:";
            // 
            // d_ILabel
            // 
            d_ILabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            d_ILabel.AutoSize = true;
            d_ILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            d_ILabel.Location = new System.Drawing.Point(64, 95);
            d_ILabel.Name = "d_ILabel";
            d_ILabel.Size = new System.Drawing.Size(43, 17);
            d_ILabel.TabIndex = 56;
            d_ILabel.Text = "Имя:";
            // 
            // d_FLabel
            // 
            d_FLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            d_FLabel.AutoSize = true;
            d_FLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            d_FLabel.Location = new System.Drawing.Point(25, 58);
            d_FLabel.Name = "d_FLabel";
            d_FLabel.Size = new System.Drawing.Size(82, 17);
            d_FLabel.TabIndex = 54;
            d_FLabel.Text = "Фамилия:";
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label7.Location = new System.Drawing.Point(12, 15);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(95, 17);
            label7.TabIndex = 36;
            label7.Text = "Должность:";
            // 
            // t_OLabel
            // 
            t_OLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            t_OLabel.AutoSize = true;
            t_OLabel.CausesValidation = false;
            t_OLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            t_OLabel.Location = new System.Drawing.Point(23, 130);
            t_OLabel.Name = "t_OLabel";
            t_OLabel.Size = new System.Drawing.Size(84, 17);
            t_OLabel.TabIndex = 64;
            t_OLabel.Text = "Отчество:";
            // 
            // t_ILabel
            // 
            t_ILabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            t_ILabel.AutoSize = true;
            t_ILabel.CausesValidation = false;
            t_ILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            t_ILabel.Location = new System.Drawing.Point(64, 95);
            t_ILabel.Name = "t_ILabel";
            t_ILabel.Size = new System.Drawing.Size(43, 17);
            t_ILabel.TabIndex = 62;
            t_ILabel.Text = "Имя:";
            // 
            // t_FLabel
            // 
            t_FLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            t_FLabel.AutoSize = true;
            t_FLabel.CausesValidation = false;
            t_FLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            t_FLabel.Location = new System.Drawing.Point(25, 58);
            t_FLabel.Name = "t_FLabel";
            t_FLabel.Size = new System.Drawing.Size(82, 17);
            t_FLabel.TabIndex = 60;
            t_FLabel.Text = "Фамилия:";
            // 
            // btnFindCode
            // 
            this.btnFindCode.Location = new System.Drawing.Point(164, 19);
            this.btnFindCode.Name = "btnFindCode";
            this.btnFindCode.Size = new System.Drawing.Size(75, 23);
            this.btnFindCode.TabIndex = 25;
            this.btnFindCode.Text = "Подбор";
            this.btnFindCode.UseVisualStyleBackColor = true;
            this.btnFindCode.Click += new System.EventHandler(this.btnFindCode_Click);
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tAbn.CodeAbonent", true));
            this.txtCode.Location = new System.Drawing.Point(58, 21);
            this.txtCode.Mask = "0000";
            this.txtCode.Name = "txtCode";
            this.txtCode.PromptChar = ' ';
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 24;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // dsCont
            // 
            this.dsCont.DataSetName = "DataSetCont";
            this.dsCont.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelTypeAbn
            // 
            this.labelTypeAbn.AutoSize = true;
            this.labelTypeAbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeAbn.Location = new System.Drawing.Point(257, 22);
            this.labelTypeAbn.Name = "labelTypeAbn";
            this.labelTypeAbn.Size = new System.Drawing.Size(37, 17);
            this.labelTypeAbn.TabIndex = 23;
            this.labelTypeAbn.Text = "Тип:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsCont, "tAbn.TypeAbn", true));
            this.comboBoxType.DataSource = this.dsCont;
            this.comboBoxType.DisplayMember = "tR_Classifier.Name";
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(299, 22);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(246, 24);
            this.comboBoxType.TabIndex = 22;
            this.comboBoxType.ValueMember = "tR_Classifier.Id";
            // 
            // richTextBoxName
            // 
            this.richTextBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tAbn.Name", true));
            this.richTextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxName.Location = new System.Drawing.Point(131, 57);
            this.richTextBoxName.Name = "richTextBoxName";
            this.richTextBoxName.Size = new System.Drawing.Size(475, 26);
            this.richTextBoxName.TabIndex = 21;
            this.richTextBoxName.Text = "";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(520, 363);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Выход";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(414, 363);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 17;
            this.buttonOK.Text = "Сохранить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // gbCont
            // 
            this.gbCont.Controls.Add(this.btnFindCode);
            this.gbCont.Controls.Add(codeAbonentLabel);
            this.gbCont.Controls.Add(this.txtCode);
            this.gbCont.Controls.Add(nameLabel);
            this.gbCont.Controls.Add(this.labelTypeAbn);
            this.gbCont.Controls.Add(this.comboBoxType);
            this.gbCont.Controls.Add(this.richTextBoxName);
            this.gbCont.Location = new System.Drawing.Point(5, 2);
            this.gbCont.Name = "gbCont";
            this.gbCont.Size = new System.Drawing.Size(615, 93);
            this.gbCont.TabIndex = 26;
            this.gbCont.TabStop = false;
            this.gbCont.Text = "Контрагент";
            // 
            // tabControlAbn
            // 
            this.tabControlAbn.Controls.Add(this.tabPageAbnInfo);
            this.tabControlAbn.Controls.Add(this.tabPageDirector);
            this.tabControlAbn.Controls.Add(this.tabPageAddress);
            this.tabControlAbn.Controls.Add(this.tabPageContacts);
            this.tabControlAbn.Location = new System.Drawing.Point(5, 101);
            this.tabControlAbn.Name = "tabControlAbn";
            this.tabControlAbn.SelectedIndex = 0;
            this.tabControlAbn.Size = new System.Drawing.Size(615, 260);
            this.tabControlAbn.TabIndex = 36;
            // 
            // tabPageAbnInfo
            // 
            this.tabPageAbnInfo.Controls.Add(this.tsAbnInfo);
            this.tabPageAbnInfo.Controls.Add(this.nameFullTextBox);
            this.tabPageAbnInfo.Controls.Add(this.iNNTextBox);
            this.tabPageAbnInfo.Controls.Add(this.bankAcntTextBox);
            this.tabPageAbnInfo.Controls.Add(this.kPPTextBox);
            this.tabPageAbnInfo.Controls.Add(this.bankDestTextBox);
            this.tabPageAbnInfo.Controls.Add(this.oKVEDTextBox);
            this.tabPageAbnInfo.Controls.Add(this.bankIDTextBox);
            this.tabPageAbnInfo.Controls.Add(this.oKPOTextBox);
            this.tabPageAbnInfo.Controls.Add(nameFullLabel);
            this.tabPageAbnInfo.Controls.Add(bankAcntLabel);
            this.tabPageAbnInfo.Controls.Add(iNNLabel);
            this.tabPageAbnInfo.Controls.Add(bankDestLabel);
            this.tabPageAbnInfo.Controls.Add(kPPLabel);
            this.tabPageAbnInfo.Controls.Add(bankIDLabel);
            this.tabPageAbnInfo.Controls.Add(oKVEDLabel);
            this.tabPageAbnInfo.Controls.Add(oKPOLabel);
            this.tabPageAbnInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbnInfo.Name = "tabPageAbnInfo";
            this.tabPageAbnInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbnInfo.Size = new System.Drawing.Size(607, 234);
            this.tabPageAbnInfo.TabIndex = 0;
            this.tabPageAbnInfo.Text = "Реквизиты";
            this.tabPageAbnInfo.UseVisualStyleBackColor = true;
            // 
            // tsAbnInfo
            // 
            this.tsAbnInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddAbnInfo,
            this.tsbEditInfo,
            this.tsbInfoHistory});
            this.tsAbnInfo.Location = new System.Drawing.Point(3, 3);
            this.tsAbnInfo.Name = "tsAbnInfo";
            this.tsAbnInfo.Size = new System.Drawing.Size(601, 25);
            this.tsAbnInfo.TabIndex = 35;
            this.tsAbnInfo.Text = "toolStrip1";
            // 
            // tsbAddAbnInfo
            // 
            this.tsbAddAbnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddAbnInfo.Image = global::Contractor.Properties.Resources.ElementAdd;
            this.tsbAddAbnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddAbnInfo.Name = "tsbAddAbnInfo";
            this.tsbAddAbnInfo.Size = new System.Drawing.Size(23, 22);
            this.tsbAddAbnInfo.Text = "Новые реквизиты";
            this.tsbAddAbnInfo.Click += new System.EventHandler(this.tsbAddAbnInfo_Click);
            // 
            // tsbEditInfo
            // 
            this.tsbEditInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditInfo.Image = global::Contractor.Properties.Resources.ElementEdit;
            this.tsbEditInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditInfo.Name = "tsbEditInfo";
            this.tsbEditInfo.Size = new System.Drawing.Size(23, 22);
            this.tsbEditInfo.Text = "Редактировать реквизиты";
            this.tsbEditInfo.Click += new System.EventHandler(this.tsbEditInfo_Click);
            // 
            // tsbInfoHistory
            // 
            this.tsbInfoHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInfoHistory.Image = global::Contractor.Properties.Resources.ElementInformation;
            this.tsbInfoHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInfoHistory.Name = "tsbInfoHistory";
            this.tsbInfoHistory.Size = new System.Drawing.Size(23, 22);
            this.tsbInfoHistory.Text = "Истрия реквизитов";
            this.tsbInfoHistory.Click += new System.EventHandler(this.tsbInfoHistory_Click);
            // 
            // nameFullTextBox
            // 
            this.nameFullTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nameFullTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "vG_AbnInfo.NameFull", true));
            this.nameFullTextBox.Location = new System.Drawing.Point(97, 38);
            this.nameFullTextBox.Multiline = true;
            this.nameFullTextBox.Name = "nameFullTextBox";
            this.nameFullTextBox.ReadOnly = true;
            this.nameFullTextBox.Size = new System.Drawing.Size(485, 48);
            this.nameFullTextBox.TabIndex = 17;
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "vG_AbnInfo.INN", true));
            this.iNNTextBox.Location = new System.Drawing.Point(97, 96);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.ReadOnly = true;
            this.iNNTextBox.Size = new System.Drawing.Size(230, 20);
            this.iNNTextBox.TabIndex = 19;
            // 
            // bankAcntTextBox
            // 
            this.bankAcntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "vG_AbnInfo.BankAcnt", true));
            this.bankAcntTextBox.Location = new System.Drawing.Point(145, 199);
            this.bankAcntTextBox.Name = "bankAcntTextBox";
            this.bankAcntTextBox.ReadOnly = true;
            this.bankAcntTextBox.Size = new System.Drawing.Size(223, 20);
            this.bankAcntTextBox.TabIndex = 31;
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "vG_AbnInfo.KPP", true));
            this.kPPTextBox.Location = new System.Drawing.Point(374, 92);
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.ReadOnly = true;
            this.kPPTextBox.Size = new System.Drawing.Size(208, 20);
            this.kPPTextBox.TabIndex = 21;
            // 
            // bankDestTextBox
            // 
            this.bankDestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bankDestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "vG_AbnInfo.BankDestName", true));
            this.bankDestTextBox.Location = new System.Drawing.Point(145, 173);
            this.bankDestTextBox.Name = "bankDestTextBox";
            this.bankDestTextBox.ReadOnly = true;
            this.bankDestTextBox.Size = new System.Drawing.Size(437, 20);
            this.bankDestTextBox.TabIndex = 29;
            // 
            // oKVEDTextBox
            // 
            this.oKVEDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "vG_AbnInfo.OKVED", true));
            this.oKVEDTextBox.Location = new System.Drawing.Point(97, 118);
            this.oKVEDTextBox.Name = "oKVEDTextBox";
            this.oKVEDTextBox.ReadOnly = true;
            this.oKVEDTextBox.Size = new System.Drawing.Size(230, 20);
            this.oKVEDTextBox.TabIndex = 23;
            // 
            // bankIDTextBox
            // 
            this.bankIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bankIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "vG_AbnInfo.BankName", true));
            this.bankIDTextBox.Location = new System.Drawing.Point(145, 147);
            this.bankIDTextBox.Name = "bankIDTextBox";
            this.bankIDTextBox.ReadOnly = true;
            this.bankIDTextBox.Size = new System.Drawing.Size(437, 20);
            this.bankIDTextBox.TabIndex = 27;
            // 
            // oKPOTextBox
            // 
            this.oKPOTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oKPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "vG_AbnInfo.OKPO", true));
            this.oKPOTextBox.Location = new System.Drawing.Point(374, 118);
            this.oKPOTextBox.Name = "oKPOTextBox";
            this.oKPOTextBox.ReadOnly = true;
            this.oKPOTextBox.Size = new System.Drawing.Size(208, 20);
            this.oKPOTextBox.TabIndex = 25;
            // 
            // tabPageDirector
            // 
            this.tabPageDirector.Controls.Add(this.tsDirector);
            this.tabPageDirector.Controls.Add(this.tabControlDirectorFIO);
            this.tabPageDirector.Location = new System.Drawing.Point(4, 22);
            this.tabPageDirector.Name = "tabPageDirector";
            this.tabPageDirector.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDirector.Size = new System.Drawing.Size(607, 234);
            this.tabPageDirector.TabIndex = 1;
            this.tabPageDirector.Text = "Руководитель";
            this.tabPageDirector.UseVisualStyleBackColor = true;
            // 
            // tsDirector
            // 
            this.tsDirector.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDirectorAdd,
            this.tsbDirectorEdit,
            this.tsbDirectorHistory});
            this.tsDirector.Location = new System.Drawing.Point(3, 3);
            this.tsDirector.Name = "tsDirector";
            this.tsDirector.Size = new System.Drawing.Size(601, 25);
            this.tsDirector.TabIndex = 38;
            this.tsDirector.Text = "toolStrip1";
            // 
            // tsbDirectorAdd
            // 
            this.tsbDirectorAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDirectorAdd.Image = global::Contractor.Properties.Resources.ElementAdd;
            this.tsbDirectorAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDirectorAdd.Name = "tsbDirectorAdd";
            this.tsbDirectorAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbDirectorAdd.Text = "Новый руководитель";
            this.tsbDirectorAdd.Click += new System.EventHandler(this.tsbDirectorAdd_Click);
            // 
            // tsbDirectorEdit
            // 
            this.tsbDirectorEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDirectorEdit.Image = global::Contractor.Properties.Resources.ElementEdit;
            this.tsbDirectorEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDirectorEdit.Name = "tsbDirectorEdit";
            this.tsbDirectorEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbDirectorEdit.Text = "Редактировать руководителя";
            this.tsbDirectorEdit.Click += new System.EventHandler(this.tsbDirectorEdit_Click);
            // 
            // tsbDirectorHistory
            // 
            this.tsbDirectorHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDirectorHistory.Image = global::Contractor.Properties.Resources.ElementInformation;
            this.tsbDirectorHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDirectorHistory.Name = "tsbDirectorHistory";
            this.tsbDirectorHistory.Size = new System.Drawing.Size(23, 22);
            this.tsbDirectorHistory.Text = "История руководителей";
            this.tsbDirectorHistory.Click += new System.EventHandler(this.tsbDirectorHistory_Click);
            // 
            // tabControlDirectorFIO
            // 
            this.tabControlDirectorFIO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlDirectorFIO.Controls.Add(this.tabPageI);
            this.tabControlDirectorFIO.Controls.Add(this.tabPageR);
            this.tabControlDirectorFIO.Controls.Add(this.tabPageD);
            this.tabControlDirectorFIO.Controls.Add(this.tabPageT);
            this.tabControlDirectorFIO.Location = new System.Drawing.Point(6, 37);
            this.tabControlDirectorFIO.Name = "tabControlDirectorFIO";
            this.tabControlDirectorFIO.SelectedIndex = 0;
            this.tabControlDirectorFIO.Size = new System.Drawing.Size(595, 185);
            this.tabControlDirectorFIO.TabIndex = 34;
            // 
            // tabPageI
            // 
            this.tabPageI.Controls.Add(this.I_postTextBox);
            this.tabPageI.Controls.Add(postLabel);
            this.tabPageI.Controls.Add(i_OLabel);
            this.tabPageI.Controls.Add(this.i_OTextBox);
            this.tabPageI.Controls.Add(i_ILabel);
            this.tabPageI.Controls.Add(this.i_ITextBox);
            this.tabPageI.Controls.Add(i_FLabel);
            this.tabPageI.Controls.Add(this.i_FTextBox);
            this.tabPageI.Location = new System.Drawing.Point(4, 22);
            this.tabPageI.Name = "tabPageI";
            this.tabPageI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageI.Size = new System.Drawing.Size(587, 159);
            this.tabPageI.TabIndex = 0;
            this.tabPageI.Text = "Именительный (кто)";
            this.tabPageI.UseVisualStyleBackColor = true;
            // 
            // I_postTextBox
            // 
            this.I_postTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.I_postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.I_Post", true));
            this.I_postTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.I_postTextBox.Location = new System.Drawing.Point(113, 15);
            this.I_postTextBox.Multiline = true;
            this.I_postTextBox.Name = "I_postTextBox";
            this.I_postTextBox.ReadOnly = true;
            this.I_postTextBox.Size = new System.Drawing.Size(458, 25);
            this.I_postTextBox.TabIndex = 33;
            // 
            // i_OTextBox
            // 
            this.i_OTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.i_OTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.I_O", true));
            this.i_OTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i_OTextBox.Location = new System.Drawing.Point(113, 127);
            this.i_OTextBox.Name = "i_OTextBox";
            this.i_OTextBox.ReadOnly = true;
            this.i_OTextBox.Size = new System.Drawing.Size(458, 23);
            this.i_OTextBox.TabIndex = 43;
            // 
            // i_ITextBox
            // 
            this.i_ITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.i_ITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.I_I", true));
            this.i_ITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i_ITextBox.Location = new System.Drawing.Point(113, 92);
            this.i_ITextBox.Name = "i_ITextBox";
            this.i_ITextBox.ReadOnly = true;
            this.i_ITextBox.Size = new System.Drawing.Size(458, 23);
            this.i_ITextBox.TabIndex = 41;
            // 
            // i_FTextBox
            // 
            this.i_FTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.i_FTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.I_F", true));
            this.i_FTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i_FTextBox.Location = new System.Drawing.Point(113, 55);
            this.i_FTextBox.Name = "i_FTextBox";
            this.i_FTextBox.ReadOnly = true;
            this.i_FTextBox.Size = new System.Drawing.Size(458, 23);
            this.i_FTextBox.TabIndex = 39;
            // 
            // tabPageR
            // 
            this.tabPageR.Controls.Add(this.R_postTextBox);
            this.tabPageR.Controls.Add(label5);
            this.tabPageR.Controls.Add(r_OLabel);
            this.tabPageR.Controls.Add(this.r_OTextBox);
            this.tabPageR.Controls.Add(r_ILabel);
            this.tabPageR.Controls.Add(this.r_ITextBox);
            this.tabPageR.Controls.Add(r_FLabel);
            this.tabPageR.Controls.Add(this.r_FTextBox);
            this.tabPageR.Location = new System.Drawing.Point(4, 22);
            this.tabPageR.Name = "tabPageR";
            this.tabPageR.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageR.Size = new System.Drawing.Size(587, 159);
            this.tabPageR.TabIndex = 1;
            this.tabPageR.Text = "Родительный (кого)";
            this.tabPageR.UseVisualStyleBackColor = true;
            // 
            // R_postTextBox
            // 
            this.R_postTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.R_postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.R_Post", true));
            this.R_postTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R_postTextBox.Location = new System.Drawing.Point(113, 15);
            this.R_postTextBox.Multiline = true;
            this.R_postTextBox.Name = "R_postTextBox";
            this.R_postTextBox.ReadOnly = true;
            this.R_postTextBox.Size = new System.Drawing.Size(458, 25);
            this.R_postTextBox.TabIndex = 35;
            // 
            // r_OTextBox
            // 
            this.r_OTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.r_OTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.I_O", true));
            this.r_OTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_OTextBox.Location = new System.Drawing.Point(113, 127);
            this.r_OTextBox.Name = "r_OTextBox";
            this.r_OTextBox.ReadOnly = true;
            this.r_OTextBox.Size = new System.Drawing.Size(458, 23);
            this.r_OTextBox.TabIndex = 53;
            // 
            // r_ITextBox
            // 
            this.r_ITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.r_ITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.R_I", true));
            this.r_ITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_ITextBox.Location = new System.Drawing.Point(113, 92);
            this.r_ITextBox.Name = "r_ITextBox";
            this.r_ITextBox.ReadOnly = true;
            this.r_ITextBox.Size = new System.Drawing.Size(458, 23);
            this.r_ITextBox.TabIndex = 51;
            // 
            // r_FTextBox
            // 
            this.r_FTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.r_FTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.R_F", true));
            this.r_FTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_FTextBox.Location = new System.Drawing.Point(113, 55);
            this.r_FTextBox.Name = "r_FTextBox";
            this.r_FTextBox.ReadOnly = true;
            this.r_FTextBox.Size = new System.Drawing.Size(458, 23);
            this.r_FTextBox.TabIndex = 49;
            // 
            // tabPageD
            // 
            this.tabPageD.Controls.Add(this.D_postTextBox);
            this.tabPageD.Controls.Add(d_OLabel);
            this.tabPageD.Controls.Add(label6);
            this.tabPageD.Controls.Add(this.d_OTextBox);
            this.tabPageD.Controls.Add(d_ILabel);
            this.tabPageD.Controls.Add(this.d_ITextBox);
            this.tabPageD.Controls.Add(d_FLabel);
            this.tabPageD.Controls.Add(this.d_FTextBox);
            this.tabPageD.Location = new System.Drawing.Point(4, 22);
            this.tabPageD.Name = "tabPageD";
            this.tabPageD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageD.Size = new System.Drawing.Size(587, 159);
            this.tabPageD.TabIndex = 2;
            this.tabPageD.Text = "Дательный (кому)";
            this.tabPageD.UseVisualStyleBackColor = true;
            // 
            // D_postTextBox
            // 
            this.D_postTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.D_postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.D_Post", true));
            this.D_postTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D_postTextBox.Location = new System.Drawing.Point(113, 15);
            this.D_postTextBox.Multiline = true;
            this.D_postTextBox.Name = "D_postTextBox";
            this.D_postTextBox.ReadOnly = true;
            this.D_postTextBox.Size = new System.Drawing.Size(458, 25);
            this.D_postTextBox.TabIndex = 37;
            // 
            // d_OTextBox
            // 
            this.d_OTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.d_OTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.D_O", true));
            this.d_OTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_OTextBox.Location = new System.Drawing.Point(113, 127);
            this.d_OTextBox.Name = "d_OTextBox";
            this.d_OTextBox.ReadOnly = true;
            this.d_OTextBox.Size = new System.Drawing.Size(458, 23);
            this.d_OTextBox.TabIndex = 59;
            // 
            // d_ITextBox
            // 
            this.d_ITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.d_ITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.D_I", true));
            this.d_ITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_ITextBox.Location = new System.Drawing.Point(113, 92);
            this.d_ITextBox.Name = "d_ITextBox";
            this.d_ITextBox.ReadOnly = true;
            this.d_ITextBox.Size = new System.Drawing.Size(458, 23);
            this.d_ITextBox.TabIndex = 57;
            // 
            // d_FTextBox
            // 
            this.d_FTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.d_FTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.D_F", true));
            this.d_FTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_FTextBox.Location = new System.Drawing.Point(113, 55);
            this.d_FTextBox.Name = "d_FTextBox";
            this.d_FTextBox.ReadOnly = true;
            this.d_FTextBox.Size = new System.Drawing.Size(458, 23);
            this.d_FTextBox.TabIndex = 55;
            // 
            // tabPageT
            // 
            this.tabPageT.CausesValidation = false;
            this.tabPageT.Controls.Add(this.T_postTextBox);
            this.tabPageT.Controls.Add(label7);
            this.tabPageT.Controls.Add(t_OLabel);
            this.tabPageT.Controls.Add(this.t_OTextBox);
            this.tabPageT.Controls.Add(t_ILabel);
            this.tabPageT.Controls.Add(this.t_ITextBox);
            this.tabPageT.Controls.Add(t_FLabel);
            this.tabPageT.Controls.Add(this.t_FTextBox);
            this.tabPageT.Location = new System.Drawing.Point(4, 22);
            this.tabPageT.Name = "tabPageT";
            this.tabPageT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageT.Size = new System.Drawing.Size(587, 159);
            this.tabPageT.TabIndex = 3;
            this.tabPageT.Text = "Творительный (кем)";
            this.tabPageT.UseVisualStyleBackColor = true;
            // 
            // T_postTextBox
            // 
            this.T_postTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.T_postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.T_Post", true));
            this.T_postTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T_postTextBox.Location = new System.Drawing.Point(113, 15);
            this.T_postTextBox.Multiline = true;
            this.T_postTextBox.Name = "T_postTextBox";
            this.T_postTextBox.ReadOnly = true;
            this.T_postTextBox.Size = new System.Drawing.Size(458, 25);
            this.T_postTextBox.TabIndex = 37;
            // 
            // t_OTextBox
            // 
            this.t_OTextBox.CausesValidation = false;
            this.t_OTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.T_O", true));
            this.t_OTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_OTextBox.Location = new System.Drawing.Point(113, 127);
            this.t_OTextBox.Name = "t_OTextBox";
            this.t_OTextBox.ReadOnly = true;
            this.t_OTextBox.Size = new System.Drawing.Size(484, 23);
            this.t_OTextBox.TabIndex = 65;
            // 
            // t_ITextBox
            // 
            this.t_ITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.t_ITextBox.CausesValidation = false;
            this.t_ITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.T_I", true));
            this.t_ITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_ITextBox.Location = new System.Drawing.Point(113, 92);
            this.t_ITextBox.Name = "t_ITextBox";
            this.t_ITextBox.ReadOnly = true;
            this.t_ITextBox.Size = new System.Drawing.Size(458, 23);
            this.t_ITextBox.TabIndex = 63;
            // 
            // t_FTextBox
            // 
            this.t_FTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.t_FTextBox.CausesValidation = false;
            this.t_FTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "tG_AbnChief.T_F", true));
            this.t_FTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_FTextBox.Location = new System.Drawing.Point(113, 55);
            this.t_FTextBox.Name = "t_FTextBox";
            this.t_FTextBox.ReadOnly = true;
            this.t_FTextBox.Size = new System.Drawing.Size(458, 23);
            this.t_FTextBox.TabIndex = 61;
            // 
            // tabPageAddress
            // 
            this.tabPageAddress.Controls.Add(this.tsAddress);
            this.tabPageAddress.Controls.Add(this.groupBoxAddressP);
            this.tabPageAddress.Controls.Add(this.groupBoxAddressL);
            this.tabPageAddress.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddress.Name = "tabPageAddress";
            this.tabPageAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddress.Size = new System.Drawing.Size(607, 234);
            this.tabPageAddress.TabIndex = 2;
            this.tabPageAddress.Text = "Адреса";
            this.tabPageAddress.UseVisualStyleBackColor = true;
            // 
            // tsAddress
            // 
            this.tsAddress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddressHistory});
            this.tsAddress.Location = new System.Drawing.Point(3, 3);
            this.tsAddress.Name = "tsAddress";
            this.tsAddress.Size = new System.Drawing.Size(601, 25);
            this.tsAddress.TabIndex = 4;
            this.tsAddress.Text = "toolStrip1";
            // 
            // tsbAddressHistory
            // 
            this.tsbAddressHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddressHistory.Image = global::Contractor.Properties.Resources.ElementInformation;
            this.tsbAddressHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddressHistory.Name = "tsbAddressHistory";
            this.tsbAddressHistory.Size = new System.Drawing.Size(23, 22);
            this.tsbAddressHistory.Text = "История адресов";
            this.tsbAddressHistory.Click += new System.EventHandler(this.tsbAddressHistory_Click);
            // 
            // groupBoxAddressP
            // 
            this.groupBoxAddressP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddressP.Controls.Add(this.richTextBoxAddressP);
            this.groupBoxAddressP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAddressP.Location = new System.Drawing.Point(10, 119);
            this.groupBoxAddressP.Name = "groupBoxAddressP";
            this.groupBoxAddressP.Size = new System.Drawing.Size(591, 101);
            this.groupBoxAddressP.TabIndex = 3;
            this.groupBoxAddressP.TabStop = false;
            this.groupBoxAddressP.Text = "Почтовый адрес потребителя";
            // 
            // richTextBoxAddressP
            // 
            this.richTextBoxAddressP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAddressP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "vG_AbnAddressP.Representation", true));
            this.richTextBoxAddressP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxAddressP.Location = new System.Drawing.Point(12, 19);
            this.richTextBoxAddressP.Name = "richTextBoxAddressP";
            this.richTextBoxAddressP.ReadOnly = true;
            this.richTextBoxAddressP.Size = new System.Drawing.Size(561, 65);
            this.richTextBoxAddressP.TabIndex = 0;
            this.richTextBoxAddressP.Text = "";
            // 
            // groupBoxAddressL
            // 
            this.groupBoxAddressL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddressL.Controls.Add(this.richTextBoxAddressL);
            this.groupBoxAddressL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAddressL.Location = new System.Drawing.Point(10, 27);
            this.groupBoxAddressL.Name = "groupBoxAddressL";
            this.groupBoxAddressL.Size = new System.Drawing.Size(592, 97);
            this.groupBoxAddressL.TabIndex = 2;
            this.groupBoxAddressL.TabStop = false;
            this.groupBoxAddressL.Text = "Юридический адрес потребителя";
            // 
            // richTextBoxAddressL
            // 
            this.richTextBoxAddressL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAddressL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCont, "vG_AbnAddressL.Representation", true));
            this.richTextBoxAddressL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxAddressL.Location = new System.Drawing.Point(13, 19);
            this.richTextBoxAddressL.Name = "richTextBoxAddressL";
            this.richTextBoxAddressL.ReadOnly = true;
            this.richTextBoxAddressL.Size = new System.Drawing.Size(561, 67);
            this.richTextBoxAddressL.TabIndex = 1;
            this.richTextBoxAddressL.Text = "";
            // 
            // tabPageContacts
            // 
            this.tabPageContacts.Controls.Add(this.dGVAbnContact);
            this.tabPageContacts.Controls.Add(this.toolStripContact);
            this.tabPageContacts.Location = new System.Drawing.Point(4, 22);
            this.tabPageContacts.Name = "tabPageContacts";
            this.tabPageContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContacts.Size = new System.Drawing.Size(607, 234);
            this.tabPageContacts.TabIndex = 3;
            this.tabPageContacts.Text = "Контакты";
            this.tabPageContacts.UseVisualStyleBackColor = true;
            // 
            // dGVAbnContact
            // 
            this.dGVAbnContact.AllowUserToAddRows = false;
            this.dGVAbnContact.AllowUserToDeleteRows = false;
            this.dGVAbnContact.AutoGenerateColumns = false;
            this.dGVAbnContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAbnContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDGVTBC,
            this.idAbnDataGridViewTextBoxColumn1,
            this.postDataGridViewTextBoxColumn,
            this.fDataGridViewTextBoxColumn,
            this.iDataGridViewTextBoxColumn,
            this.oDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dateChangeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dGVAbnContact.DataSource = this.bsAbnContact;
            this.dGVAbnContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVAbnContact.Location = new System.Drawing.Point(3, 28);
            this.dGVAbnContact.MultiSelect = false;
            this.dGVAbnContact.Name = "dGVAbnContact";
            this.dGVAbnContact.ReadOnly = true;
            this.dGVAbnContact.RowHeadersWidth = 5;
            this.dGVAbnContact.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGVAbnContact.RowTemplate.Height = 24;
            this.dGVAbnContact.Size = new System.Drawing.Size(601, 203);
            this.dGVAbnContact.TabIndex = 5;
            // 
            // idDGVTBC
            // 
            this.idDGVTBC.DataPropertyName = "id";
            this.idDGVTBC.HeaderText = "id";
            this.idDGVTBC.Name = "idDGVTBC";
            this.idDGVTBC.ReadOnly = true;
            this.idDGVTBC.Visible = false;
            // 
            // idAbnDataGridViewTextBoxColumn1
            // 
            this.idAbnDataGridViewTextBoxColumn1.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn1.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn1.Name = "idAbnDataGridViewTextBoxColumn1";
            this.idAbnDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn1.Visible = false;
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fDataGridViewTextBoxColumn
            // 
            this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
            this.fDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
            this.fDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDataGridViewTextBoxColumn
            // 
            this.iDataGridViewTextBoxColumn.DataPropertyName = "I";
            this.iDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.iDataGridViewTextBoxColumn.Name = "iDataGridViewTextBoxColumn";
            this.iDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            this.oDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateChangeDataGridViewTextBoxColumn
            // 
            this.dateChangeDataGridViewTextBoxColumn.DataPropertyName = "DateChange";
            this.dateChangeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateChangeDataGridViewTextBoxColumn.Name = "dateChangeDataGridViewTextBoxColumn";
            this.dateChangeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateChangeDataGridViewTextBoxColumn.Visible = false;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Коментарий";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsAbnContact
            // 
            this.bsAbnContact.DataMember = "tAbnContact";
            this.bsAbnContact.DataSource = this.dsCont;
            // 
            // toolStripContact
            // 
            this.toolStripContact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewContact,
            this.toolStripButtonEditContac,
            this.toolStripButtonDelContact});
            this.toolStripContact.Location = new System.Drawing.Point(3, 3);
            this.toolStripContact.Name = "toolStripContact";
            this.toolStripContact.Size = new System.Drawing.Size(601, 25);
            this.toolStripContact.TabIndex = 2;
            this.toolStripContact.Text = "toolStrip1";
            // 
            // toolStripButtonNewContact
            // 
            this.toolStripButtonNewContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewContact.Image = global::Contractor.Properties.Resources.ElementAdd;
            this.toolStripButtonNewContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewContact.Name = "toolStripButtonNewContact";
            this.toolStripButtonNewContact.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewContact.Text = "Новый контакт";
            this.toolStripButtonNewContact.Click += new System.EventHandler(this.toolStripButtonNewContact_Click);
            // 
            // toolStripButtonEditContac
            // 
            this.toolStripButtonEditContac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditContac.Image = global::Contractor.Properties.Resources.ElementEdit;
            this.toolStripButtonEditContac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditContac.Name = "toolStripButtonEditContac";
            this.toolStripButtonEditContac.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditContac.Text = "Редактировать контакт";
            this.toolStripButtonEditContac.Click += new System.EventHandler(this.toolStripButtonEditContac_Click);
            // 
            // toolStripButtonDelContact
            // 
            this.toolStripButtonDelContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelContact.Image = global::Contractor.Properties.Resources.ElementDel;
            this.toolStripButtonDelContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelContact.Name = "toolStripButtonDelContact";
            this.toolStripButtonDelContact.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelContact.Text = "Удалить контакт";
            this.toolStripButtonDelContact.Click += new System.EventHandler(this.toolStripButtonDelContact_Click);
            // 
            // FormAddEditCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 397);
            this.Controls.Add(this.tabControlAbn);
            this.Controls.Add(this.gbCont);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAddEditCont";
            this.Load += new System.EventHandler(this.FormAddEditCont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCont)).EndInit();
            this.gbCont.ResumeLayout(false);
            this.gbCont.PerformLayout();
            this.tabControlAbn.ResumeLayout(false);
            this.tabPageAbnInfo.ResumeLayout(false);
            this.tabPageAbnInfo.PerformLayout();
            this.tsAbnInfo.ResumeLayout(false);
            this.tsAbnInfo.PerformLayout();
            this.tabPageDirector.ResumeLayout(false);
            this.tabPageDirector.PerformLayout();
            this.tsDirector.ResumeLayout(false);
            this.tsDirector.PerformLayout();
            this.tabControlDirectorFIO.ResumeLayout(false);
            this.tabPageI.ResumeLayout(false);
            this.tabPageI.PerformLayout();
            this.tabPageR.ResumeLayout(false);
            this.tabPageR.PerformLayout();
            this.tabPageD.ResumeLayout(false);
            this.tabPageD.PerformLayout();
            this.tabPageT.ResumeLayout(false);
            this.tabPageT.PerformLayout();
            this.tabPageAddress.ResumeLayout(false);
            this.tabPageAddress.PerformLayout();
            this.tsAddress.ResumeLayout(false);
            this.tsAddress.PerformLayout();
            this.groupBoxAddressP.ResumeLayout(false);
            this.groupBoxAddressL.ResumeLayout(false);
            this.tabPageContacts.ResumeLayout(false);
            this.tabPageContacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAbnContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnContact)).EndInit();
            this.toolStripContact.ResumeLayout(false);
            this.toolStripContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindCode;
        private System.Windows.Forms.MaskedTextBox txtCode;
        private System.Windows.Forms.Label labelTypeAbn;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.RichTextBox richTextBoxName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private DataSets.DataSetCont dsCont;
        private System.Windows.Forms.GroupBox gbCont;
        private System.Windows.Forms.TabControl tabControlAbn;
        private System.Windows.Forms.TabPage tabPageAbnInfo;
        private System.Windows.Forms.TextBox nameFullTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox bankAcntTextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.TextBox bankDestTextBox;
        private System.Windows.Forms.TextBox oKVEDTextBox;
        private System.Windows.Forms.TextBox bankIDTextBox;
        private System.Windows.Forms.TextBox oKPOTextBox;
        private System.Windows.Forms.TabPage tabPageDirector;
        private System.Windows.Forms.TabControl tabControlDirectorFIO;
        private System.Windows.Forms.TabPage tabPageI;
        private System.Windows.Forms.TextBox I_postTextBox;
        private System.Windows.Forms.TextBox i_OTextBox;
        private System.Windows.Forms.TextBox i_ITextBox;
        private System.Windows.Forms.TextBox i_FTextBox;
        private System.Windows.Forms.TabPage tabPageR;
        private System.Windows.Forms.TextBox R_postTextBox;
        private System.Windows.Forms.TextBox r_OTextBox;
        private System.Windows.Forms.TextBox r_ITextBox;
        private System.Windows.Forms.TextBox r_FTextBox;
        private System.Windows.Forms.TabPage tabPageD;
        private System.Windows.Forms.TextBox D_postTextBox;
        private System.Windows.Forms.TextBox d_OTextBox;
        private System.Windows.Forms.TextBox d_ITextBox;
        private System.Windows.Forms.TextBox d_FTextBox;
        private System.Windows.Forms.TabPage tabPageT;
        private System.Windows.Forms.TextBox T_postTextBox;
        private System.Windows.Forms.TextBox t_OTextBox;
        private System.Windows.Forms.TextBox t_ITextBox;
        private System.Windows.Forms.TextBox t_FTextBox;
        private System.Windows.Forms.TabPage tabPageAddress;
        private System.Windows.Forms.GroupBox groupBoxAddressP;
        private System.Windows.Forms.RichTextBox richTextBoxAddressP;
        private System.Windows.Forms.GroupBox groupBoxAddressL;
        private System.Windows.Forms.RichTextBox richTextBoxAddressL;
        private System.Windows.Forms.TabPage tabPageContacts;
        private System.Windows.Forms.ToolStrip toolStripContact;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewContact;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditContac;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelContact;
        private System.Windows.Forms.BindingSource bsAbnContact;
        private System.Windows.Forms.DataGridView dGVAbnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateChangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip tsAbnInfo;
        private System.Windows.Forms.ToolStripButton tsbAddAbnInfo;
        private System.Windows.Forms.ToolStripButton tsbEditInfo;
        private System.Windows.Forms.ToolStripButton tsbInfoHistory;
        private System.Windows.Forms.ToolStrip tsDirector;
        private System.Windows.Forms.ToolStripButton tsbDirectorAdd;
        private System.Windows.Forms.ToolStripButton tsbDirectorEdit;
        private System.Windows.Forms.ToolStripButton tsbDirectorHistory;
        private System.Windows.Forms.ToolStrip tsAddress;
        private System.Windows.Forms.ToolStripButton tsbAddressHistory;
    }
}