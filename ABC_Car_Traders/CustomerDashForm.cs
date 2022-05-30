using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class CustomerDashForm : Form
    {
        public CustomerDashForm()
        {
            InitializeComponent();

            loadform(new CustomerCarForm());
            lbl_un.Text = UserStatic.Username;

        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new CustomerCarForm());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new CustomerOrderForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnparts_Click(object sender, EventArgs e)
        {
            loadform(new CustomerPartForm());
        }

        private void mainpanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            loadform(new CustomerOrderForm());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == dr)
            {
                UserStatic.Uid = "";
                UserStatic.Username = "";
                UserStatic.isAdmin = false;

                var login = new Login();
                login.Show();
                this.Hide();

            }
            else
            {
                
            }
        }
    }
}
