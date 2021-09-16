using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
namespace Network.Packet.Analyzer.App
{
    public partial class Analysis_Network_Form : Form
    {
        public Analysis_Network_Form()
        {
            InitializeComponent();
        }

        private void Analysis_Network_Form_Load(object sender, EventArgs e)
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
                return;

            NetworkInterface[] interfaces
                = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface ni in interfaces)
            {
                MessageBox.Show("Bytes Sent: " + ni.GetIPv4Statistics().BytesSent.ToString() + "\n" + " Bytes Received: " + ni.GetIPv4Statistics().BytesReceived.ToString());
                
            }
        }
    }
}
