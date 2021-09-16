using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Network.Packet.Analyzer.App.Forms.MainUserForm;

namespace Network.Packet.Analyzer.App.Forms.LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        Welcome mf = new Welcome();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(tbusername.Text=="umer" && tbpassword.Text == "admin")
            {
                MessageBox.Show("Welcome '" + tbusername.Text + "'","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                tbusername.Text = "";
                tbpassword.Text = "";
            
                mf.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             tbusername.Text = "";
             tbpassword.Text = "";
            }
            //try
            //{
            //    SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=IDS;Integrated Security=True");
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    //if (mf.mainformcon1.State == ConnectionState.Closed)
            //    //    mf.mainformcon1.Open();
            //    if (tbusername.Text != string.Empty && tbpassword.Text != string.Empty)
            //    {
            //        cmd.CommandText = "Select * from Login where UserName = '" + tbusername.Text + "' And Password = '" + tbpassword.Text + "' ";
            //        SqlDataReader dr = null;
            //        dr = cmd.ExecuteReader();
            //        if (dr.Read())
            //        {
            //            dr.Close();
            //            MessageBox.Show("Welcome '" + tbusername.Text + "'");
            //            this.Hide();
            //            tbusername.Text = "";
            //            tbpassword.Text = "";
            //            mf.ShowDialog();
            //        }
            //        else
            //        {
            //            dr.Close();
            //            MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            tbusername.Text = "";
            //            tbpassword.Text = "";
            //        }

            //    }
            //    else
            //    {
            //        MessageBox.Show("Please type data in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    con.Close();
            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show(exp.ToString());
            //}
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
