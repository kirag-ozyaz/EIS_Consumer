using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Consumer.Classes
{
    class TabControlHelper
    {
        private TabControl tc;
        private List<TabPage> pages;
        private int IDNODE;
        
        public TabControlHelper(TabControl tabControl, TabPage vp)
        {
            tc = tabControl;
            pages = new List<TabPage>();
            ShowAllPages();
            foreach (TabPage p in tc.TabPages)
            {
                pages.Add(p);
            }
            HideAllPages();
            ShowPage(vp);
        }

        public bool ChangePage(string level, int idnode)
        {
            if (idnode == IDNODE || idnode == 0)
                return false;
            HideAllPages();
            foreach (TabPage p in pages)
            {
                if (p.Name == level)
                {
                    ShowPage(p);
                    IDNODE = idnode;
                    return true;
                }
            }
            ShowPage(pages[0]);
            IDNODE = idnode;
            return true;
        }


        public bool ChangePage(string level)
        {
            HideAllPages();
            foreach (TabPage p in pages)
            {
                if (p.Name == level)
                {
                    ShowPage(p);
                    return true;
                }
            }
            ShowPage(pages[0]);
            return true;
        }



        public void HideAllPages()
        {
            foreach (TabPage p in pages)
            {
                tc.TabPages.Remove(p);
            }
        }

        public void ShowAllPages()
        {
            foreach (TabPage p in pages)
            {
                tc.TabPages.Add(p);
            }
        }

        public void HidePage(TabPage tp)
        {
            tc.TabPages.Remove(tp);
        }

        public void ShowPage(TabPage tp)
        {
            tc.TabPages.Add(tp);
        }
    }
}
