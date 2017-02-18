namespace sdv
{
    partial class MainForm
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
            System.Windows.Forms.TabPage tabPage1;
            System.Windows.Forms.TabPage tabPage2;
            System.Windows.Forms.Panel panel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ToolStripMenuItem trayItemExit;
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.tabControlTask = new System.Windows.Forms.TabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayItemOpenApp = new System.Windows.Forms.ToolStripMenuItem();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            trayItemExit = new System.Windows.Forms.ToolStripMenuItem();
            panel1.SuspendLayout();
            this.tabControlTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(554, 191);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cơ bản";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(554, 191);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thời gian";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(this.buttonRight);
            panel1.Controls.Add(this.buttonLeft);
            panel1.Controls.Add(this.buttonCenter);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(5, 222);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(562, 37);
            panel1.TabIndex = 1;
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRight.BackColor = System.Drawing.Color.IndianRed;
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonRight.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonRight.Location = new System.Drawing.Point(358, 3);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(102, 31);
            this.buttonRight.TabIndex = 0;
            this.buttonRight.Text = "Hủy bỏ";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLeft.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonLeft.Location = new System.Drawing.Point(98, 3);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(102, 31);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "Trước đó";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonCenter
            // 
            this.buttonCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCenter.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCenter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCenter.Location = new System.Drawing.Point(229, 3);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(102, 31);
            this.buttonCenter.TabIndex = 0;
            this.buttonCenter.Text = "Tạo mới";
            this.buttonCenter.UseVisualStyleBackColor = false;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // tabControlTask
            // 
            this.tabControlTask.Controls.Add(tabPage1);
            this.tabControlTask.Controls.Add(tabPage2);
            this.tabControlTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlTask.Location = new System.Drawing.Point(5, 5);
            this.tabControlTask.Name = "tabControlTask";
            this.tabControlTask.SelectedIndex = 0;
            this.tabControlTask.Size = new System.Drawing.Size(562, 217);
            this.tabControlTask.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(5, 259);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Size = new System.Drawing.Size(562, 233);
            this.splitContainer1.SplitterDistance = 372;
            this.splitContainer1.TabIndex = 2;
            // 
            // mainTrayIcon
            // 
            this.mainTrayIcon.ContextMenuStrip = this.trayMenu;
            this.mainTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mainTrayIcon.Icon")));
            this.mainTrayIcon.Text = "Task Scheduler";
            this.mainTrayIcon.Visible = true;
            this.mainTrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainTrayIcon_Click);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayItemOpenApp,
            trayItemExit});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // trayItemOpenApp
            // 
            this.trayItemOpenApp.CheckOnClick = true;
            this.trayItemOpenApp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.trayItemOpenApp.Name = "trayItemOpenApp";
            this.trayItemOpenApp.Size = new System.Drawing.Size(152, 22);
            this.trayItemOpenApp.Text = "Mở ứng dụng";
            this.trayItemOpenApp.Click += new System.EventHandler(this.trayItemOpenApp_Click);
            // 
            // trayItemExit
            // 
            trayItemExit.Name = "trayItemExit";
            trayItemExit.Size = new System.Drawing.Size(152, 22);
            trayItemExit.Text = "Thoát";
            trayItemExit.Click += new System.EventHandler(this.trayItemExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 497);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(panel1);
            this.Controls.Add(this.tabControlTask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Scheduler";
            this.VisibleChanged += new System.EventHandler(this.form_VisibleCanged);
            this.Resize += new System.EventHandler(this.form_Resize);
            panel1.ResumeLayout(false);
            this.tabControlTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTask;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NotifyIcon mainTrayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem trayItemOpenApp;
    }
}

