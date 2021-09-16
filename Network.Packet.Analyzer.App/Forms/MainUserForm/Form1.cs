using Network.Packet.Analyzer.App.Forms.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Network.Packet.Analyzer.App.Forms.MainUserForm
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private int xPos = 0;

        private void module1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnalyzer mf = new FrmAnalyzer();
            mf.ShowDialog();
            
        }

        private void module2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module2 add = new Module2();
            //NetworkAnalyzerForm add = new NetworkAnalyzerForm();
            add.ShowDialog();
        }

        private void module3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileIntegrityForm add = new FileIntegrityForm();
            add.ShowDialog();
        }

        private void module4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application_Interface_Form add = new Application_Interface_Form();
            add.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void module5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signature_Based_Form add = new Signature_Based_Form();
            add.ShowDialog();
        }

        private void module6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Policy_Violation_Form pl = new Policy_Violation_Form();
            pl.ShowDialog();
        }

        private void module7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analysis_Network_Form anf = new Analysis_Network_Form();
            anf.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VirusForm add = new VirusForm();
            add.ShowDialog();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width == xPos)
            {
                //repeat marquee
                this.lbl_Marquee.Location = new Point(287, 28);
                xPos = 0;
            }
            else
            {
                this.lbl_Marquee.Location = new Point(xPos, 28);
                xPos++;
            }
        }
    }
}
