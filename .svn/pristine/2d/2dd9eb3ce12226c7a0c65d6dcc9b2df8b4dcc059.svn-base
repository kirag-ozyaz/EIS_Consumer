using System;
using System.Windows.Forms;

namespace EIS.Forms
{
    partial class FormMain
    {
        #region toolStripMenuWindwos Events
        // Окна каскадом
        private void toolStripMenuItemCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        // окна по горизонтали
        private void toolStripMenuItemTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        // окна по вертикали
        private void toolStripMenuItemTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        // закрыть все окна
        private void toolStripMenuItemWindowCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                for (int i = 0; i < toolStripMain.Items.Count; i++)
                {
                    if (toolStripMain.Items[i].Tag == childForm)
                    {
                        toolStripMain.Items.RemoveAt(i);
                        break;
                    }
                }

                childForm.Close();

            }
        }
        // Открытие меню окна
        private void toolStripMenuItemWindows_DropDownOpening(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Form childForm in MdiChildren)
            {
                i++;
                ToolStripMenuItem ts = new ToolStripMenuItem();
                ts.Text = i.ToString() + " " + childForm.Text;
                ts.Click += new EventHandler(item_Click);
                ts.Tag = childForm;

                if (this.ActiveMdiChild == childForm)
                {
                    ts.Checked = true;
                    ts.CheckOnClick = true;
                    ts.CheckState = System.Windows.Forms.CheckState.Checked;
                }

                if (i == 1) // первое окно
                    this.toolStripMenuItemWindows.DropDownItems.Add(new ToolStripSeparator());
                this.toolStripMenuItemWindows.DropDownItems.Add(ts);

            }
            if (i > 0)
            {
                toolStripMenuItemWindowCloseAll.Enabled = true;
                toolStripMenuItemCascade.Enabled = true;
                toolStripMenuItemTileHorizontal.Enabled = true;
                toolStripMenuItemTileVertical.Enabled = true;


                ToolStripMenuItem tsMDI = new ToolStripMenuItem();
                tsMDI.Text = "Список окон...";
                tsMDI.Click += new EventHandler(formsList_Click);
                tsMDI.Tag = 1;
                this.toolStripMenuItemWindows.DropDownItems.Add(tsMDI);
            }
            else
            {
                toolStripMenuItemWindowCloseAll.Enabled = false;
                toolStripMenuItemCascade.Enabled = false;
                toolStripMenuItemTileHorizontal.Enabled = false;
                toolStripMenuItemTileVertical.Enabled = false;
            }
        }
        // Закрытие меню окна
        private void toolStripMenuItemWindows_DropDownClosed(object sender, EventArgs e)
        {
            bool isDel = false;

            for (int i = 0; i < toolStripMenuItemWindows.DropDownItems.Count; i++)
            {
                if (toolStripMenuItemWindows.DropDownItems[i].GetType() == typeof(ToolStripSeparator))
                    isDel = true;
                if (isDel)
                {
                    this.toolStripMenuItemWindows.DropDownItems.RemoveAt(i);
                    i--;
                }
            }
        }
        #endregion

        #region contextMenuWindow Events
        // Восстановить свернутое окно
        private void toolStripMenuItemWindowsRestore_Click(object sender, EventArgs e)
        {
            Form f = (Form)((ToolStripMenuItem)sender).GetCurrentParent().Tag;

            f.Activate();
            f.WindowState = FormWindowState.Normal;
            f.Visible = true;
        }
        // Свернуть окно
        private void toolStripMenuItemWindowsMinimize_Click(object sender, EventArgs e)
        {
            Form f = (Form)((ToolStripMenuItem)sender).GetCurrentParent().Tag;
            f.WindowState = FormWindowState.Minimized;
        }
        // РАзвернуть окно
        private void toolStripMenuItemWindowMaximaze_Click(object sender, EventArgs e)
        {
            Form f = (Form)((ToolStripMenuItem)sender).GetCurrentParent().Tag;
            f.Activate();
            f.WindowState = FormWindowState.Normal;
            f.Visible = true;
            f.WindowState = FormWindowState.Maximized;
        }
        // закрыть окно
        private void toolStripMenuItemWindowsClose_Click(object sender, EventArgs e)
        {
            Form f = (Form)((ToolStripMenuItem)sender).GetCurrentParent().Tag;

            for (int i = 0; i < toolStripMain.Items.Count; i++)
            {
                if (toolStripMain.Items[i].Tag == f)
                {
                    toolStripMain.Items.RemoveAt(i);
                    break;
                }
            }

            f.Close();
        }
        #endregion

        #region MDIFormAddEvents
        // активация дочерних окон
        private void FormMain_MdiChildActivate(object sender, EventArgs e)
        {
            Form f = this.ActiveMdiChild;

            if (f != null)
            {
                ToolStripButton item = new ToolStripButton();
                item.Name = f.Name;
                int len = (f.Text.Length >= 25) ? 25 : f.Text.Length;
                item.Text = f.Text.Substring(0, len);
                item.ToolTipText = f.Text;
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                item.Tag = f;
                item.Image = f.Icon.ToBitmap();
                item.Checked = true;

                item.Click += new EventHandler(item_Click);
                item.MouseDown += new MouseEventHandler(item_MouseDown);

                f.FormClosed -= mdiForm_FormClosed;
                f.FormClosed += new FormClosedEventHandler(mdiForm_FormClosed);

                f.Resize -= mdiForm_Resize;
                f.Resize += new EventHandler(mdiForm_Resize);

                f.TextChanged -= mdiFrom_TextChanged;
                f.TextChanged += new EventHandler(mdiFrom_TextChanged);

                bool isadd = false;
                for (int i = 0; i < toolStripMain.Items.Count; i++)
                {
                    if (typeof(ToolStripButton) == toolStripMain.Items[i].GetType())
                        if (toolStripMain.Items[i].Tag == f)
                            ((ToolStripButton)toolStripMain.Items[i]).Checked = true;
                        else
                            ((ToolStripButton)toolStripMain.Items[i]).Checked = false;

                    if (toolStripMain.Items[i].Tag == f)
                        isadd = true;
                }
                if (!isadd)
                {
                    toolStripMain.Items.Add(item);
                    toolStripMain.Items[toolStripMain.Items.Count - 1].Width = 100;
                }
            }
        }

        void mdiFrom_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < toolStripMain.Items.Count; i++)
            {
                if (typeof(ToolStripButton) == toolStripMain.Items[i].GetType())
                    if (toolStripMain.Items[i].Tag == sender)
                    {
                        toolStripMain.Items[i].Text = ((Form)sender).Text;
                    }
            }
            
        }

        // Закрытие дочернего окна
        private void mdiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < toolStripMain.Items.Count; i++)
            {
                if (toolStripMain.Items[i].Tag == sender)
                {
                    toolStripMain.Items.RemoveAt(i);
                    return;
                }
            }
        }
        // Изменение разщмера дочернего окна
        private void mdiForm_Resize(object sender, EventArgs e)
        {
            if ((((Form)sender).WindowState == FormWindowState.Minimized)
                & (((Form)sender).Visible == true))
            {
                //((Form)sender).Visible = false;
                ((Form)sender).Hide();

            }
        }
        // кликаем по кнопочки тулбара
        private void item_Click(object sender, EventArgs e)
        {
            Form f;
            if (sender.GetType() == typeof(ToolStripButton))
                f = (Form)((ToolStripButton)sender).Tag;
            else
                f = (Form)((ToolStripMenuItem)sender).Tag;

            if (this.ActiveMdiChild == f)
            {
                f.WindowState = FormWindowState.Minimized;
            }
            else
            {
                FormWindowState w;
                if (this.ActiveMdiChild != null && this.ActiveMdiChild.WindowState != FormWindowState.Minimized)
                    w = this.ActiveMdiChild.WindowState;
                else
                    w = FormWindowState.Normal;
                f.Activate();
                f.WindowState = w;//FormWindowState.Normal;
                f.Visible = true;
            }
        }
        // нажатие мышки на кнопочки тулбара
        private void item_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuWindow.Tag = ((ToolStripButton)sender).Tag;

                if (this.ActiveMdiChild == (Form)((ToolStripButton)sender).Tag) // если активно
                    toolStripMenuItemWindowsRestore.Enabled = false;
                else
                    toolStripMenuItemWindowsRestore.Enabled = true;

                if (((Form)((ToolStripButton)sender).Tag).WindowState == FormWindowState.Maximized)
                    toolStripMenuItemWindowMaximaze.Enabled = false;
                else
                    toolStripMenuItemWindowMaximaze.Enabled = true;

                if (((Form)((ToolStripButton)sender).Tag).WindowState == FormWindowState.Minimized)
                    toolStripMenuItemWindowsMinimize.Enabled = false;
                else
                    toolStripMenuItemWindowsMinimize.Enabled = true;


                contextMenuWindow.Show(System.Windows.Forms.Cursor.Position);
            }
        }
        // Список окон
        private void formsList_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.List<Form> fList = new System.Collections.Generic.List<Form>();
            foreach (Form mdiChild in this.MdiChildren)
            {
                fList.Add(mdiChild);
            }
            Form activeForm = this.ActiveMdiChild;
            //DisableControls();
            FormWindowsList formsList = new FormWindowsList(fList, activeForm);
            formsList.MdiParent = this;
            formsList.MaximizeBox = false;
            formsList.FormClosed += new FormClosedEventHandler(frm_FormClosed);

            formsList.Show();
            DisableControls(formsList);
        }
        // закрыть окно
        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= new FormClosedEventHandler(frm_FormClosed);
            ForceReleaseOfControls();

            FormWindowsList f = (FormWindowsList)sender;
            f.ActivateForm.Activate();
        }
        // деактивировать все окна и контролы
        private void DisableControls(Form f)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].GetType() != typeof(MdiClient))
                    this.Controls[i].Enabled = false;
            }
            foreach (Form frm in MdiChildren)
                if (frm != f)
                    frm.Enabled = false;
        }
        
        public void ForceReleaseOfControls()
        {
            for (int i = 0; i < this.Controls.Count; i++)
                this.Controls[i].Enabled = true;

            foreach (Form frm in MdiChildren)
                frm.Enabled = true;
        }

        #endregion
    }
}
