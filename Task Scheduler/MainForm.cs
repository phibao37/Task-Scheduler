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
            foreach (TabPage page in tabControlTask.TabPages)
            {
                page.Enabled = false;
                Debug.WriteLine("Disabling " + page);
            }
        }
    }
}
