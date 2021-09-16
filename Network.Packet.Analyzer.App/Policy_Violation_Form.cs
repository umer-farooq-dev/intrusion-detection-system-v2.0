using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Network.Packet.Analyzer.App
{
    public partial class Policy_Violation_Form : Form
    {
        public Policy_Violation_Form()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcesses();

            foreach (Process prs in process)
            {
                listBox1.Items.Add(prs.ProcessName + "         (" + prs.PrivateMemorySize64.ToString() + ")");
            }
        }
    }
}
