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
    public partial class Signature_Based_Form : Form
    {
        public Signature_Based_Form()
        {
            InitializeComponent();
        }
        
        private void Signature_Based_Form_Load(object sender, EventArgs e)
        {
            Form myform = new Forms.Main.FrmAnalyzer();
            myform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }
    }
}
