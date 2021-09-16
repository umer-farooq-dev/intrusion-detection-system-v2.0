using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace Network.Packet.Analyzer.App
{
    public partial class NetworkAnalyzerForm : Form
    {
        public NetworkAnalyzerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //NetworkInterface[] Interfaces = NetworkInterface.GetAllNetworkInterfaces();
            //foreach (NetworkInterface Interface in Interfaces)
            //{
            //    //if (Interface.NetworkInterfaceType == NetworkInterfaceType.Loopback)
            //    //  continue;
            //    //    //Console.WriteLine(Interface.Description);
            //    UnicastIPAddressInformationCollection UnicastIPInfoCol = Interface.GetIPProperties().UnicastAddresses;
            //    foreach (UnicastIPAddressInformation UnicatIPInfo in UnicastIPInfoCol)
            //    {
            //        //        // Console.WriteLine("\tIP Address is {0}", UnicatIPInfo.Address);
            //        //        //Console.WriteLine("\tSubnet Mask is {0}", UnicatIPInfo.IPv4Mask);
            //        string subnet = UnicatIPInfo.IPv4Mask.ToString();
            //        lvResult.Items.Add(UnicatIPInfo.IPv4Mask.ToString());
            //    }
            //}
            ////       // txtSubnet.Text = subnet.ToString();
            ////        //}
            ////        //}
            ////        //string subnet = txtSubnet.Text;
            //          //progressBar.Maximum = 254;
            ////        progressBar.Value = 0;
            ////        lvResult.Items.Clear();

            ////        Task.Factory.StartNew(new Action(() =>
            ////        {
            ////            for (int i = 2; i < 255; i++)
            ////            {
            ////                string ip = $"{subnet}.{i}";
            ////                Ping ping = new Ping();
            ////                PingReply reply = ping.Send(ip, 100);
            ////                if (reply.Status == IPStatus.Success)
            ////                {
            ////                    progressBar.BeginInvoke(new Action(() =>
            ////                    {
            ////                        try
            ////                        {
            ////                            IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
            ////                            lvResult.Items.Add(new ListViewItem(new String[] { ip, host.HostName, "Up" }));
            ////                        }
            ////                        catch
            ////                        {
            ////                            MessageBox.Show($"Couldn't retrieve hostname from {ip}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////                        }
            ////                        progressBar.Value += 1;
            ////                        lblStatus.ForeColor = Color.Blue;
            ////                        lblStatus.Text = $"Scanning: {ip}";
            ////                        if (progressBar.Value == 253)
            ////                            lblStatus.Text = "Finished";
            ////                    }));
            ////                }
            ////                else
            ////                {
            ////                    progressBar.BeginInvoke(new Action(() =>
            ////                    {
            ////                        progressBar.Value += 1;
            ////                        lblStatus.ForeColor = Color.DarkGray;
            ////                        lblStatus.Text = $"Scanning: {ip}";
            ////                        lvResult.Items.Add(new ListViewItem(new String[] { ip, "", "Down" }));
            ////                        if (progressBar.Value == 253)
            ////                            lblStatus.Text = "Finished";
            ////                    }));
            ////                }
            ////            }
            ////        }));
            ////    }
            ////}
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
