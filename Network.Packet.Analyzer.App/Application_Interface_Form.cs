using Network.Packet.Analyzer.App.Forms.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Network.Packet.Analyzer.App
{
    public partial class Application_Interface_Form : Form
    {
        public Application_Interface_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnalyzer mf = new FrmAnalyzer();
            mf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NetworkAnalyzerForm add = new NetworkAnalyzerForm();
            add.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileIntegrityForm add = new FileIntegrityForm();
            add.ShowDialog();
        }
    }
}
