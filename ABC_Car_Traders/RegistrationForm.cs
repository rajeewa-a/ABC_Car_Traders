using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DAO;

namespace ABC_Car_Traders
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        //validate email address
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

        private void btn_reg_Click(object sender, EventArgs e)
        {
            if(!(txt_add.Text.Trim() == "" || txt_em.Text.Trim() == "" || txt_name.Text.Trim() == "" || txt_nic.Text.Trim() == "" || txt_pw.Text.Trim() == "" ||
                txt_pwconfirm.Text.Trim() == "" || txt_tp.Text.Trim() == ""))
            {
                if (EmailIsValid(txt_em.Text))
                {
                    if (txt_pw.Text == txt_pwconfirm.Text)
                    {
                        try
                        {
                            user newuser = new user();
                            newuser.uid = txt_nic.Text;
                            newuser.password = txt_pw.Text;
                            newuser.email = txt_em.Text;
                            UserBLL.AddUser(newuser);

                            customer newcustomer = new customer();
                            newcustomer.name = txt_name.Text;
                            newcustomer.customer_id = txt_nic.Text;
                            newcustomer.address = txt_add.Text;
                            newcustomer.contact = txt_tp.Text;
                            newcustomer.dob = date_dob.Value;
                            CustomerBLL.AddCustomer(newcustomer);

                            DialogResult dr = MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dr == DialogResult.OK)
                            {
                                var frm1 = new Login();
                                frm1.Show();
                                this.Hide();
                            }
                            else
                            {
                                var frm1 = new Login();
                                frm1.Show();
                                this.Hide();
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Error! Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid E-mail Address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Fields.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linklbl_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
