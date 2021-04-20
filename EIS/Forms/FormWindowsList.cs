using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EIS.Forms
{
    public partial class FormWindowsList : Form
    {
        private Form activateForm = null;

        // свойство - активное окно
        public Form ActivateForm
        {
            get
            {
                return activateForm;
            }
        }

        // Конструктор
        public FormWindowsList(List<Form> formsList, Form activeForm)
        {
            InitializeComponent();

            activateForm = activeForm;
            listViewWindows.Columns[0].Width = listViewWindows.ClientRectangle.Width;
            PaintListView(formsList, activeForm);
            
        }

        // Добавление итемов в listview
        private void PaintListView(List<Form> formsList, Form acttiveForm)
        {
            try
            {
                ListViewItem lvi;
                
                if (formsList.Count == 0)
                    return;

                this.listViewWindows.Items.Clear();

                this.listViewWindows.BeginUpdate();

                int i = 0;

                foreach (Form f in formsList)
                {
                    imageListWindows.Images.Add(f.Icon);

                    imageListWindows.TransparentColor = Color.Transparent;

                    lvi = new ListViewItem();
                    lvi.Text = f.Text;
                    lvi.ImageIndex = i;
                    lvi.Tag = f;

                    this.listViewWindows.Items.Add(lvi);

                    if (f == acttiveForm)
                    {
                        this.listViewWindows.Items[i].Selected = true;
                        this.listViewWindows.Select();
                    }

                    i++;
                }

                this.listViewWindows.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        // Изменение размера Listview
        private void listViewWindows_Resize(object sender, EventArgs e)
        {
            listViewWindows.Columns[0].Width = listViewWindows.ClientRectangle.Width;
        }

        // Активировать выбранное окно
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.listViewWindows.SelectedItems.Count > 0)
                activateForm = (Form)this.listViewWindows.SelectedItems[0].Tag;
            this.Close();
        }

        // Закрыть выборанные окна
        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.listViewWindows.SelectedItems.Count; i++)
            {
                Form f = (Form)this.listViewWindows.SelectedItems[i].Tag;
                f.Close();
                this.listViewWindows.SelectedItems[i].Remove();
                i--;
            }

            if (listViewWindows.Items.Count > 0)
            {
                listViewWindows.Items[0].Selected = true;
                listViewWindows.Select();
            }

        }

        // Двойное нажатие по listview
        private void listViewWindows_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewWindows.GetItemAt(e.X, e.Y);

            activateForm = (Form)item.Tag;
            this.Close();
        }
    }
}
