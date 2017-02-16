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
    }
}
