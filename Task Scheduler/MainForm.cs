using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace sdv
{
   
    /// <summary>
    /// Main form for Task Scheduler application
    /// </summary>
    public partial class MainForm : Form
    {

        /// <summary>
        /// Create new form object
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            setupComponent();
        }


        /// <summary>
        /// Do configuration for created GUI component
        /// </summary>
        private void setupComponent()
        {
            // Disable selecting tab from user
            tabControlTask.Selecting += (s, e) => {
                e.Cancel = true;
            };
            

        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {

        }

        private void buttonRight_Click(object sender, EventArgs e)
        {

        }

        private void mainTrayIcon_Click(object sender, MouseEventArgs e)
        {
            // Show app when left click on tray icon
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void form_Resize(object sender, EventArgs e)
        {
            // Minimize app to system tray
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void trayItemOpenApp_Click(object sender, EventArgs e)
        {
            // Handle app visibly when check/uncheck from tray menu item
            if (trayItemOpenApp.Checked)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
            else
            {
                this.Hide();
            }
        }

        private void form_VisibleCanged(object sender, EventArgs e)
        {
            // Sync tray menu item state based on form visibly
            trayItemOpenApp.Checked = this.Visible;
        }

        private void trayItemExit_Click(object sender, EventArgs e)
        {
            // Close the app
            this.Close();
        }
    }
}
