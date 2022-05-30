using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DAO;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace ABC_Car_Traders
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool EmailIsValid(string emailaddress)
        {

            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!(txt_email.Text.Trim() == "" || txt_pw.Text.Trim() == ""))
            {
                if (EmailIsValid(txt_email.Text))
                {
                    List<user> userlist = UserBLL.GetUsers(txt_email.Text, txt_pw.Text);

                    if (userlist.Count == 0)
                        MessageBox.Show("Invalid Credentials!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        //create a new user
                        user user1 = new user();

                        //assign details to user1 object
                        user1 = userlist.First();

                        //create a userstatic class
                        UserStatic.Uid = user1.uid;
                        UserStatic.isAdmin = Convert.ToBoolean(user1.is_admin);

                        if (!user1.is_admin)
                        {
                            List<customer> customerlist = CustomerBLL.GetCustomer(user1.uid);
                            customer customer1 = new customer();
                            customer1 = customerlist.First();
                            UserStatic.Username = customer1.name;
                            var frm1 = new CustomerDashForm();
                            frm1.Show();
                            this.Hide();
                        }
                        else
                        {
                            var frm2 = new AdminDashForm();
                            frm2.Show();
                            this.Hide();
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Invalid E-mail Address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Do not leave fields empty.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
 
        }

        private void txt_pw_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void linklbl_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reg = new RegistrationForm();
            reg.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
