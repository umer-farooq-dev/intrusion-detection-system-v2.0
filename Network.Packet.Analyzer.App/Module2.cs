using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.Diagnostics;
namespace Network.Packet.Analyzer.App
{
    public partial class Module2 : Form
    {
        public Module2()
        {
            InitializeComponent();
        }

        private void Module2_Load(object sender, EventArgs e)
        {
            
               // Console.WriteLine("Key: " + s + " Value: " + sAll.Get(s));
            //Console.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();

            foreach (Process prs in processlist)
            {
                listBox1.Items.Add(prs.ProcessName + "         (" + prs.PrivateMemorySize64.ToString() + ")");
                //Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
                //textBox1.Text = "Process:" + theprocess.ProcessName + "Process ID" + theprocess.Id;
            }
            //    string sAttr;

            //    // Read a particular key from the config file 
            //    sAttr = ConfigurationManager.AppSettings.Get("Key0");
            //    //Console.WriteLine("The value of Key0: " + sAttr);

            //    // Read all the keys from the config file
            //    NameValueCollection sAll;
            //    sAll = ConfigurationManager.AppSettings;

            //    foreach (string s in sAll.AllKeys)
            //        textBox1.Text = sAttr.ToString() + "\n" + sAll.ToString() + "\n";
            // MessageBox.Show();
        }

    }
}
