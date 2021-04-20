using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormLbr.Classes;

namespace EIS.Forms
{
    public partial class FormUpdateSettings : Form
    {
        UpdateSettings updSEtt;

        public UpdateSettings UpdateSettings
        {
            get { return updSEtt; }
            set
            {
                textBox1.Text = value.DownloadPath;
                if (value.IntervalUpdate / 1000 / 60 >= 10)
                    numericUpDown1.Value = value.IntervalUpdate / 1000 / 60;
                else
                    numericUpDown1.Value = 10;
                updSEtt = value;
            }
        }

        public FormUpdateSettings()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdateSettings.DownloadPath = textBox1.Text;
            UpdateSettings.IntervalUpdate = (int) (numericUpDown1.Value * 60 * 1000);
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
