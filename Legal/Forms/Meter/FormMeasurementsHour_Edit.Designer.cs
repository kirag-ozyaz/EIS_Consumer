namespace Legal.Forms.Meter
{
    partial class FormMeasurementsHour_Edit
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
            this.dsAbnObjAct1 = new Legal.DataSet.dsAbnObjAct();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grp = new System.Windows.Forms.GroupBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnObjAct1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsAbnObjAct1
            // 
            this.dsAbnObjAct1.DataSetName = "dsAbnObjAct";
            this.dsAbnObjAct1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "YearValue", true));
            this.textBox1.Location = new System.Drawing.Point(47, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tG_MeasurementsHour";
            this.bindingSource1.DataSource = this.dsAbnObjAct1;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "MonthValue", true));
            this.textBox2.Location = new System.Drawing.Point(222, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Год:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Месяц:";
            // 
            // grp
            // 
            this.grp.Controls.Add(this.checkBox24);
            this.grp.Controls.Add(this.checkBox23);
            this.grp.Controls.Add(this.checkBox22);
            this.grp.Controls.Add(this.checkBox21);
            this.grp.Controls.Add(this.checkBox20);
            this.grp.Controls.Add(this.checkBox19);
            this.grp.Controls.Add(this.checkBox18);
            this.grp.Controls.Add(this.checkBox17);
            this.grp.Controls.Add(this.checkBox16);
            this.grp.Controls.Add(this.checkBox15);
            this.grp.Controls.Add(this.checkBox14);
            this.grp.Controls.Add(this.checkBox13);
            this.grp.Controls.Add(this.checkBox12);
            this.grp.Controls.Add(this.checkBox11);
            this.grp.Controls.Add(this.checkBox10);
            this.grp.Controls.Add(this.checkBox9);
            this.grp.Controls.Add(this.checkBox8);
            this.grp.Controls.Add(this.checkBox7);
            this.grp.Controls.Add(this.checkBox6);
            this.grp.Controls.Add(this.checkBox5);
            this.grp.Controls.Add(this.checkBox4);
            this.grp.Controls.Add(this.checkBox3);
            this.grp.Controls.Add(this.checkBox2);
            this.grp.Controls.Add(this.checkBox1);
            this.grp.Location = new System.Drawing.Point(12, 55);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(590, 135);
            this.grp.TabIndex = 4;
            this.grp.TabStop = false;
            this.grp.Text = " Часы ";
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h24", true));
            this.checkBox24.Location = new System.Drawing.Point(520, 103);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(53, 17);
            this.checkBox24.TabIndex = 23;
            this.checkBox24.Text = "23-24";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h23", true));
            this.checkBox23.Location = new System.Drawing.Point(448, 104);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(53, 17);
            this.checkBox23.TabIndex = 22;
            this.checkBox23.Text = "22-23";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h22", true));
            this.checkBox22.Location = new System.Drawing.Point(376, 103);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(53, 17);
            this.checkBox22.TabIndex = 21;
            this.checkBox22.Text = "21-22";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h21", true));
            this.checkBox21.Location = new System.Drawing.Point(304, 104);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(53, 17);
            this.checkBox21.TabIndex = 20;
            this.checkBox21.Text = "20-21";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h20", true));
            this.checkBox20.Location = new System.Drawing.Point(232, 103);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(53, 17);
            this.checkBox20.TabIndex = 19;
            this.checkBox20.Text = "19-20";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h19", true));
            this.checkBox19.Location = new System.Drawing.Point(160, 103);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(53, 17);
            this.checkBox19.TabIndex = 18;
            this.checkBox19.Text = "18-19";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h18", true));
            this.checkBox18.Location = new System.Drawing.Point(88, 103);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(53, 17);
            this.checkBox18.TabIndex = 17;
            this.checkBox18.Text = "17-18";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h17", true));
            this.checkBox17.Location = new System.Drawing.Point(16, 103);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(53, 17);
            this.checkBox17.TabIndex = 16;
            this.checkBox17.Text = "16-17";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h9", true));
            this.checkBox16.Location = new System.Drawing.Point(16, 65);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(41, 17);
            this.checkBox16.TabIndex = 15;
            this.checkBox16.Text = "8-9";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h16", true));
            this.checkBox15.Location = new System.Drawing.Point(520, 65);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(53, 17);
            this.checkBox15.TabIndex = 14;
            this.checkBox15.Text = "15-16";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h15", true));
            this.checkBox14.Location = new System.Drawing.Point(448, 65);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(53, 17);
            this.checkBox14.TabIndex = 13;
            this.checkBox14.Text = "14-15";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h14", true));
            this.checkBox13.Location = new System.Drawing.Point(376, 65);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(53, 17);
            this.checkBox13.TabIndex = 12;
            this.checkBox13.Text = "13-14";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h13", true));
            this.checkBox12.Location = new System.Drawing.Point(304, 65);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(53, 17);
            this.checkBox12.TabIndex = 11;
            this.checkBox12.Text = "12-13";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h12", true));
            this.checkBox11.Location = new System.Drawing.Point(232, 65);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(53, 17);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "11-12";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h11", true));
            this.checkBox10.Location = new System.Drawing.Point(160, 65);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(53, 17);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "10-11";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h10", true));
            this.checkBox9.Location = new System.Drawing.Point(88, 65);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(47, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "9-10";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h8", true));
            this.checkBox8.Location = new System.Drawing.Point(520, 31);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(41, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "7-8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h7", true));
            this.checkBox7.Location = new System.Drawing.Point(448, 31);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(41, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "6-7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h6", true));
            this.checkBox6.Location = new System.Drawing.Point(376, 31);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(41, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "5-6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h5", true));
            this.checkBox5.Location = new System.Drawing.Point(304, 31);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(41, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "4-5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h4", true));
            this.checkBox4.Location = new System.Drawing.Point(232, 31);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(41, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "3-4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h3", true));
            this.checkBox3.Location = new System.Drawing.Point(160, 31);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(41, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "2-3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h2", true));
            this.checkBox2.Location = new System.Drawing.Point(88, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(41, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "1-2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "h1", true));
            this.checkBox1.Location = new System.Drawing.Point(16, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(41, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "0-1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(527, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Режимный день:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "MeasurementsDay", true));
            this.textBox3.Location = new System.Drawing.Point(447, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // FormMeasurementsHour_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(616, 244);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormMeasurementsHour_Edit";
            this.Load += new System.EventHandler(this.FormMeasurementsHour_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnObjAct1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet.dsAbnObjAct dsAbnObjAct1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}