using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webPreglednik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(tbSearch.Text);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("Google.com");
        }

     

        private void btnNewtab_Click(object sender, EventArgs e)
        {
            TabPage tabpage = new TabPage();
            tabpage.Text = "Nova kartica";
            tabControl1.Controls.Add(tabpage);
            WebBrowser webbrowser = new WebBrowser();
            webbrowser.Parent = tabpage;
            webbrowser.Dock = DockStyle.Fill;
            webbrowser.Navigate("www.google.com");
        }
    }
}
