namespace Legal.Forms
{
    partial class FormAbnDetails
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameFullLabel;
            System.Windows.Forms.Label bankPayerLabel;
            System.Windows.Forms.Label bankPayeeLabel;
            System.Windows.Forms.Label bankAcntLabel;
            System.Windows.Forms.Label oKPOLabel;
            System.Windows.Forms.Label oKVEDLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label iNNLabel;
            this.dsAbnDetails1 = new Legal.DataSet.dsAbnDetails();
            this.dateChangeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bankPayerComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankPayeeComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.bankAcntmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameFullTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnParent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.INNmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.OKPOmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.OKVEDmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lemail = new System.Windows.Forms.Label();
            this.btnInnCheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KBK = new System.Windows.Forms.MaskedTextBox();
            this.OKOPF = new System.Windows.Forms.MaskedTextBox();
            this.OKFS = new System.Windows.Forms.MaskedTextBox();
            this.OKTMO = new System.Windows.Forms.MaskedTextBox();
            this.OKOGU = new System.Windows.Forms.MaskedTextBox();
            this.OGRN = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Account1 = new System.Windows.Forms.TextBox();
            this.Account2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            nameFullLabel = new System.Windows.Forms.Label();
            bankPayerLabel = new System.Windows.Forms.Label();
            bankPayeeLabel = new System.Windows.Forms.Label();
            bankAcntLabel = new System.Windows.Forms.Label();
            oKPOLabel = new System.Windows.Forms.Label();
            oKVEDLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDetails1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameFullLabel
            // 
            nameFullLabel.AutoSize = true;
            nameFullLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameFullLabel.Location = new System.Drawing.Point(7, 73);
            nameFullLabel.Name = "nameFullLabel";
            nameFullLabel.Size = new System.Drawing.Size(163, 15);
            nameFullLabel.TabIndex = 3;
            nameFullLabel.Text = "Полное наименование:";
            // 
            // bankPayerLabel
            // 
            bankPayerLabel.AutoSize = true;
            bankPayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bankPayerLabel.Location = new System.Drawing.Point(34, 299);
            bankPayerLabel.Name = "bankPayerLabel";
            bankPayerLabel.Size = new System.Drawing.Size(136, 15);
            bankPayerLabel.TabIndex = 14;
            bankPayerLabel.Text = "Банк плательщика:";
            // 
            // bankPayeeLabel
            // 
            bankPayeeLabel.AutoSize = true;
            bankPayeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bankPayeeLabel.Location = new System.Drawing.Point(46, 368);
            bankPayeeLabel.Name = "bankPayeeLabel";
            bankPayeeLabel.Size = new System.Drawing.Size(124, 15);
            bankPayeeLabel.TabIndex = 16;
            bankPayeeLabel.Text = "Банк получателя:";
            // 
            // bankAcntLabel
            // 
            bankAcntLabel.AutoSize = true;
            bankAcntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bankAcntLabel.Location = new System.Drawing.Point(52, 337);
            bankAcntLabel.Name = "bankAcntLabel";
            bankAcntLabel.Size = new System.Drawing.Size(118, 15);
            bankAcntLabel.TabIndex = 18;
            bankAcntLabel.Text = "Расчетный счет:";
            // 
            // oKPOLabel
            // 
            oKPOLabel.AutoSize = true;
            oKPOLabel.BackColor = System.Drawing.SystemColors.Control;
            oKPOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            oKPOLabel.Location = new System.Drawing.Point(483, 26);
            oKPOLabel.Name = "oKPOLabel";
            oKPOLabel.Size = new System.Drawing.Size(50, 15);
            oKPOLabel.TabIndex = 11;
            oKPOLabel.Text = "ОКПО:";
            // 
            // oKVEDLabel
            // 
            oKVEDLabel.AutoSize = true;
            oKVEDLabel.BackColor = System.Drawing.SystemColors.Control;
            oKVEDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            oKVEDLabel.Location = new System.Drawing.Point(12, 141);
            oKVEDLabel.Name = "oKVEDLabel";
            oKVEDLabel.Size = new System.Drawing.Size(58, 15);
            oKVEDLabel.TabIndex = 9;
            oKVEDLabel.Text = "ОКВЭД:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.BackColor = System.Drawing.SystemColors.Control;
            kPPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kPPLabel.Location = new System.Drawing.Point(261, 27);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(40, 15);
            kPPLabel.TabIndex = 7;
            kPPLabel.Text = "КПП:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.BackColor = System.Drawing.SystemColors.Control;
            iNNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iNNLabel.Location = new System.Drawing.Point(11, 24);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(41, 15);
            iNNLabel.TabIndex = 5;
            iNNLabel.Text = "ИНН:";
            // 
            // dsAbnDetails1
            // 
            this.dsAbnDetails1.DataSetName = "dsAbnDetails";
            this.dsAbnDetails1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateChangeDateTimePicker
            // 
            this.dateChangeDateTimePicker.Enabled = false;
            this.dateChangeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateChangeDateTimePicker.Location = new System.Drawing.Point(366, 479);
            this.dateChangeDateTimePicker.Name = "dateChangeDateTimePicker";
            this.dateChangeDateTimePicker.Size = new System.Drawing.Size(160, 21);
            this.dateChangeDateTimePicker.TabIndex = 14;
            // 
            // bankPayerComboBox
            // 
            this.bankPayerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAbnDetails1, "tG_AbnInfo.BankID", true));
            this.bankPayerComboBox.DataSource = this.bindingSource1;
            this.bankPayerComboBox.DisplayMember = "NameShort";
            this.bankPayerComboBox.FormattingEnabled = true;
            this.bankPayerComboBox.Location = new System.Drawing.Point(181, 301);
            this.bankPayerComboBox.Name = "bankPayerComboBox";
            this.bankPayerComboBox.Size = new System.Drawing.Size(567, 21);
            this.bankPayerComboBox.TabIndex = 20;
            this.bankPayerComboBox.ValueMember = "BankID";
            this.bankPayerComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bankPayerComboBox_KeyUp);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tBanks";
            this.bindingSource1.DataSource = this.dsAbnDetails1;
            // 
            // bankPayeeComboBox
            // 
            this.bankPayeeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAbnDetails1, "tG_AbnInfo.BankDest", true));
            this.bankPayeeComboBox.DataSource = this.bindingSource2;
            this.bankPayeeComboBox.DisplayMember = "NameShort";
            this.bankPayeeComboBox.FormattingEnabled = true;
            this.bankPayeeComboBox.Location = new System.Drawing.Point(181, 362);
            this.bankPayeeComboBox.Name = "bankPayeeComboBox";
            this.bankPayeeComboBox.Size = new System.Drawing.Size(567, 21);
            this.bankPayeeComboBox.TabIndex = 21;
            this.bankPayeeComboBox.ValueMember = "BankID";
            this.bankPayeeComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bankPayeeComboBox_KeyUp);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "tBanks";
            this.bindingSource2.DataSource = this.dsAbnDetails1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(648, 472);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(532, 472);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 22;
            this.buttonOK.Text = "Сохранить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // bankAcntmaskedTextBox
            // 
            this.bankAcntmaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.BankAcnt", true));
            this.bankAcntmaskedTextBox.Location = new System.Drawing.Point(181, 332);
            this.bankAcntmaskedTextBox.Mask = "000 000 000 000 000  000 00";
            this.bankAcntmaskedTextBox.Name = "bankAcntmaskedTextBox";
            this.bankAcntmaskedTextBox.Size = new System.Drawing.Size(224, 20);
            this.bankAcntmaskedTextBox.TabIndex = 22;
            this.bankAcntmaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // nameFullTextBox
            // 
            this.nameFullTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.NameFull", true));
            this.nameFullTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameFullTextBox.Location = new System.Drawing.Point(181, 55);
            this.nameFullTextBox.Name = "nameFullTextBox";
            this.nameFullTextBox.Size = new System.Drawing.Size(569, 53);
            this.nameFullTextBox.TabIndex = 27;
            this.nameFullTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Наименование:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.NameShort", true));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(181, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(567, 37);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // btnParent
            // 
            this.btnParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParent.Location = new System.Drawing.Point(143, 477);
            this.btnParent.Name = "btnParent";
            this.btnParent.Size = new System.Drawing.Size(100, 23);
            this.btnParent.TabIndex = 30;
            this.btnParent.Text = "Новая";
            this.btnParent.UseVisualStyleBackColor = true;
            this.btnParent.Click += new System.EventHandler(this.btnParent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Головная орг-ия:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(249, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // INNmaskedTextBox
            // 
            this.INNmaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.INN", true));
            this.INNmaskedTextBox.Enabled = false;
            this.INNmaskedTextBox.Location = new System.Drawing.Point(77, 26);
            this.INNmaskedTextBox.Mask = "999 999 999 999";
            this.INNmaskedTextBox.Name = "INNmaskedTextBox";
            this.INNmaskedTextBox.Size = new System.Drawing.Size(130, 20);
            this.INNmaskedTextBox.TabIndex = 13;
            this.INNmaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.KPP", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(311, 26);
            this.maskedTextBox1.Mask = "999 999 999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(130, 20);
            this.maskedTextBox1.TabIndex = 14;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // OKPOmaskedTextBox
            // 
            this.OKPOmaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.OKPO", true));
            this.OKPOmaskedTextBox.Location = new System.Drawing.Point(548, 24);
            this.OKPOmaskedTextBox.Mask = "999 999 999 9";
            this.OKPOmaskedTextBox.Name = "OKPOmaskedTextBox";
            this.OKPOmaskedTextBox.Size = new System.Drawing.Size(130, 20);
            this.OKPOmaskedTextBox.TabIndex = 15;
            this.OKPOmaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // OKVEDmaskedTextBox
            // 
            this.OKVEDmaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.OKVED", true));
            this.OKVEDmaskedTextBox.Location = new System.Drawing.Point(77, 141);
            this.OKVEDmaskedTextBox.Name = "OKVEDmaskedTextBox";
            this.OKVEDmaskedTextBox.Size = new System.Drawing.Size(364, 20);
            this.OKVEDmaskedTextBox.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.Email", true));
            this.txtEmail.Location = new System.Drawing.Point(511, 433);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 20);
            this.txtEmail.TabIndex = 33;
            // 
            // lemail
            // 
            this.lemail.AutoSize = true;
            this.lemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lemail.Location = new System.Drawing.Point(457, 436);
            this.lemail.Name = "lemail";
            this.lemail.Size = new System.Drawing.Size(49, 13);
            this.lemail.TabIndex = 34;
            this.lemail.Text = "E-mail :";
            // 
            // btnInnCheck
            // 
            this.btnInnCheck.Location = new System.Drawing.Point(486, 138);
            this.btnInnCheck.Name = "btnInnCheck";
            this.btnInnCheck.Size = new System.Drawing.Size(100, 23);
            this.btnInnCheck.TabIndex = 35;
            this.btnInnCheck.Text = "Проверить ИНН";
            this.btnInnCheck.UseVisualStyleBackColor = true;
            this.btnInnCheck.Click += new System.EventHandler(this.btnInnCheck_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(478, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "ОКТМО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "ОГРН:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(243, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "ОКОГУ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "ОКФС:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(243, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "ОКОПФ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(498, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "КБК:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KBK);
            this.groupBox1.Controls.Add(this.OKOPF);
            this.groupBox1.Controls.Add(this.OKFS);
            this.groupBox1.Controls.Add(this.OKTMO);
            this.groupBox1.Controls.Add(this.OKOGU);
            this.groupBox1.Controls.Add(this.OGRN);
            this.groupBox1.Controls.Add(this.btnInnCheck);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(oKPOLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(kPPLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(iNNLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.OKVEDmaskedTextBox);
            this.groupBox1.Controls.Add(this.INNmaskedTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.OKPOmaskedTextBox);
            this.groupBox1.Controls.Add(oKVEDLabel);
            this.groupBox1.Location = new System.Drawing.Point(7, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 174);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Классификаторы";
            // 
            // KBK
            // 
            this.KBK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.KBK", true));
            this.KBK.Location = new System.Drawing.Point(548, 96);
            this.KBK.Mask = "999 999 999 999 999 999 99";
            this.KBK.Name = "KBK";
            this.KBK.Size = new System.Drawing.Size(183, 20);
            this.KBK.TabIndex = 47;
            this.KBK.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // OKOPF
            // 
            this.OKOPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.OKOPF", true));
            this.OKOPF.Location = new System.Drawing.Point(311, 96);
            this.OKOPF.Mask = "999 99";
            this.OKOPF.Name = "OKOPF";
            this.OKOPF.Size = new System.Drawing.Size(130, 20);
            this.OKOPF.TabIndex = 46;
            this.OKOPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // OKFS
            // 
            this.OKFS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.OKFS", true));
            this.OKFS.Location = new System.Drawing.Point(77, 96);
            this.OKFS.Mask = "99";
            this.OKFS.Name = "OKFS";
            this.OKFS.Size = new System.Drawing.Size(130, 20);
            this.OKFS.TabIndex = 45;
            this.OKFS.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // OKTMO
            // 
            this.OKTMO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.OKTMO", true));
            this.OKTMO.Location = new System.Drawing.Point(548, 60);
            this.OKTMO.Mask = "999 999 999 99";
            this.OKTMO.Name = "OKTMO";
            this.OKTMO.Size = new System.Drawing.Size(130, 20);
            this.OKTMO.TabIndex = 44;
            this.OKTMO.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // OKOGU
            // 
            this.OKOGU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.OKOGU", true));
            this.OKOGU.Location = new System.Drawing.Point(311, 61);
            this.OKOGU.Mask = "999 999 9";
            this.OKOGU.Name = "OKOGU";
            this.OKOGU.Size = new System.Drawing.Size(130, 20);
            this.OKOGU.TabIndex = 43;
            this.OKOGU.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // OGRN
            // 
            this.OGRN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.OGRN", true));
            this.OGRN.Location = new System.Drawing.Point(77, 61);
            this.OGRN.Mask = "999 999 999 999 9 ";
            this.OGRN.Name = "OGRN";
            this.OGRN.Size = new System.Drawing.Size(130, 20);
            this.OGRN.TabIndex = 42;
            this.OGRN.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(276, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Л/с 1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(518, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Л/с 2:";
            // 
            // Account1
            // 
            this.Account1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.PersonalAccount_1", true));
            this.Account1.Location = new System.Drawing.Point(326, 399);
            this.Account1.Name = "Account1";
            this.Account1.Size = new System.Drawing.Size(180, 20);
            this.Account1.TabIndex = 46;
            // 
            // Account2
            // 
            this.Account2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.PersonalAccount_2", true));
            this.Account2.Location = new System.Drawing.Point(568, 399);
            this.Account2.Name = "Account2";
            this.Account2.Size = new System.Drawing.Size(180, 20);
            this.Account2.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Тел/факс:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDetails1, "tG_AbnInfo.Phone", true));
            this.textBox1.Location = new System.Drawing.Point(84, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 20);
            this.textBox1.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(81, 402);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Для бюджетных организаций:";
            // 
            // FormAbnDetails
            // 
            this.ClientSize = new System.Drawing.Size(762, 512);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Account2);
            this.Controls.Add(this.Account1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lemail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankAcntmaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateChangeDateTimePicker);
            this.Controls.Add(this.btnParent);
            this.Controls.Add(this.bankPayeeComboBox);
            this.Controls.Add(this.bankPayerComboBox);
            this.Controls.Add(bankAcntLabel);
            this.Controls.Add(bankPayeeLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(bankPayerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameFullTextBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(nameFullLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbnDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Платежные реквизиты потребителя";
            this.Load += new System.EventHandler(this.FormAbnDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDetails1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Legal.DataSet.dsAbnDetails dsAbnDetails1;
        private System.Windows.Forms.DateTimePicker dateChangeDateTimePicker;
        private System.Windows.Forms.ComboBox bankPayerComboBox;
        private System.Windows.Forms.ComboBox bankPayeeComboBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.RichTextBox nameFullTextBox;
        private System.Windows.Forms.MaskedTextBox bankAcntmaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnParent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox INNmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox OKPOmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox OKVEDmaskedTextBox;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lemail;
        private System.Windows.Forms.Button btnInnCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox KBK;
        private System.Windows.Forms.MaskedTextBox OKOPF;
        private System.Windows.Forms.MaskedTextBox OKFS;
        private System.Windows.Forms.MaskedTextBox OKTMO;
        private System.Windows.Forms.MaskedTextBox OKOGU;
        private System.Windows.Forms.MaskedTextBox OGRN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Account1;
        private System.Windows.Forms.TextBox Account2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
    }
}
