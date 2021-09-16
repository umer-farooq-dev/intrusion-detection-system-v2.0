
namespace Network.Packet.Analyzer.App.Forms.MainUserForm
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.module1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.module2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.module3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.module4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.module5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.module6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.module7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Marquee = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.module1ToolStripMenuItem,
            this.module2ToolStripMenuItem,
            this.module3ToolStripMenuItem,
            this.module4ToolStripMenuItem,
            this.module5ToolStripMenuItem,
            this.module6ToolStripMenuItem,
            this.module7ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.mainMenuToolStripMenuItem.Text = "IDS Main Menu";
            // 
            // module1ToolStripMenuItem
            // 
            this.module1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("module1ToolStripMenuItem.Image")));
            this.module1ToolStripMenuItem.Name = "module1ToolStripMenuItem";
            this.module1ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.module1ToolStripMenuItem.Text = "Sniffer";
            this.module1ToolStripMenuItem.Click += new System.EventHandler(this.module1ToolStripMenuItem_Click);
            // 
            // module2ToolStripMenuItem
            // 
            this.module2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("module2ToolStripMenuItem.Image")));
            this.module2ToolStripMenuItem.Name = "module2ToolStripMenuItem";
            this.module2ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.module2ToolStripMenuItem.Text = "Integrity";
            this.module2ToolStripMenuItem.Click += new System.EventHandler(this.module2ToolStripMenuItem_Click);
            // 
            // module3ToolStripMenuItem
            // 
            this.module3ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("module3ToolStripMenuItem.Image")));
            this.module3ToolStripMenuItem.Name = "module3ToolStripMenuItem";
            this.module3ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.module3ToolStripMenuItem.Text = "File Integrity";
            this.module3ToolStripMenuItem.Click += new System.EventHandler(this.module3ToolStripMenuItem_Click);
            // 
            // module4ToolStripMenuItem
            // 
            this.module4ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("module4ToolStripMenuItem.Image")));
            this.module4ToolStripMenuItem.Name = "module4ToolStripMenuItem";
            this.module4ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.module4ToolStripMenuItem.Text = "Application Interface";
            this.module4ToolStripMenuItem.Click += new System.EventHandler(this.module4ToolStripMenuItem_Click);
            // 
            // module5ToolStripMenuItem
            // 
            this.module5ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("module5ToolStripMenuItem.Image")));
            this.module5ToolStripMenuItem.Name = "module5ToolStripMenuItem";
            this.module5ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.module5ToolStripMenuItem.Text = "Signature ";
            this.module5ToolStripMenuItem.Click += new System.EventHandler(this.module5ToolStripMenuItem_Click);
            // 
            // module6ToolStripMenuItem
            // 
            this.module6ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("module6ToolStripMenuItem.Image")));
            this.module6ToolStripMenuItem.Name = "module6ToolStripMenuItem";
            this.module6ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.module6ToolStripMenuItem.Text = "Policy Voilation";
            this.module6ToolStripMenuItem.Click += new System.EventHandler(this.module6ToolStripMenuItem_Click);
            // 
            // module7ToolStripMenuItem
            // 
            this.module7ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("module7ToolStripMenuItem.Image")));
            this.module7ToolStripMenuItem.Name = "module7ToolStripMenuItem";
            this.module7ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.module7ToolStripMenuItem.Text = "Anlysis Network";
            this.module7ToolStripMenuItem.Click += new System.EventHandler(this.module7ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem1.Text = "Detect Virus";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lbl_Marquee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 73);
            this.panel1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Marquee
            // 
            this.lbl_Marquee.AutoSize = true;
            this.lbl_Marquee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marquee.Location = new System.Drawing.Point(287, 28);
            this.lbl_Marquee.Name = "lbl_Marquee";
            this.lbl_Marquee.Size = new System.Drawing.Size(186, 25);
            this.lbl_Marquee.TabIndex = 0;
            this.lbl_Marquee.Text = "Welcome To IDS";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.Text = "Welcom to IDS System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem module1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem module2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem module3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem module4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem module5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem module6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem module7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Marquee;
    }
}