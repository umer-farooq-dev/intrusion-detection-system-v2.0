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
    public partial class FileIntegrityForm : Form
    {
        public FileIntegrityForm()
        {
            InitializeComponent();
        }

        private void FileIntegrityForm_Load(object sender, EventArgs e)
        {
            var data = String.Format("{0}{1}", (char)1, @"i11A0014092414220&&");
            const string checkSum = "FBEA";

            // Checksum is 16 bit word
            var checkSumValue = Convert.ToUInt16(checkSum, 16);

            // Sum of message chars preceeding checksum
            var mySum = data.TakeWhile(c => c != '&').Aggregate(0, (current, c) => current + c);
            var validate = checkSumValue + mySum;
            label1.Text = "Data: " + data + "\n Checksum: " + checkSumValue + " \n Sum of chars: {0:x4} " + mySum + " \n Validation: " + Convert.ToString(validate, 2);
            //MessageBox.Show("Data: " + data + "Checksum: " + checkSumValue + " Sum of chars: {0:x4} " + mySum + " Validation: " + Convert.ToString(validate, 2));
            
        }
    }
}
