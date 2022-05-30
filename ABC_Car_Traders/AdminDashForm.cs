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
    public partial class AdminDashForm : Form
    {
        bool carmenucollapsed;
        bool partmenucollapsed;
        public AdminDashForm()
        {
            InitializeComponent();
            time_partmenu.Start();
            time_carmenu.Start();
            loadform(new DashboardForm());

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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cars_Click(object sender, EventArgs e)
        {
            time_carmenu.Start();
            pnl_partmenu.Height = pnl_partmenu.MinimumSize.Height;
            partmenucollapsed = true;
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void time_carmenu_Tick(object sender, EventArgs e)
        {
            if (carmenucollapsed)
            {
                pnl_carmenu.Height += 10;
                if(pnl_carmenu.Height == pnl_carmenu.MaximumSize.Height){
                    carmenucollapsed = false;
                    time_carmenu.Stop();
                }
                
            }
            else
            {
                pnl_carmenu.Height -= 10;
                if (pnl_carmenu.Height == pnl_carmenu.MinimumSize.Height)
                {
                    carmenucollapsed = true;
                    time_carmenu.Stop();
                }
            }
        }

        private void time_partmenu_Tick(object sender, EventArgs e)
        {
            if (partmenucollapsed)
            {
                pnl_partmenu.Height += 10;
                if (pnl_partmenu.Height == pnl_partmenu.MaximumSize.Height)
                {
                    partmenucollapsed = false;
                    time_partmenu.Stop();
                }

            }
            else
            {
                pnl_partmenu.Height -= 10;
                if (pnl_partmenu.Height == pnl_partmenu.MinimumSize.Height)
                {
                    partmenucollapsed = true;
                    time_partmenu.Stop();
                }
            }
        }

        private void btn_partmenu_Click(object sender, EventArgs e)
        {
            time_partmenu.Start();

            pnl_carmenu.Height = pnl_carmenu.MinimumSize.Height;
            carmenucollapsed = true;

        }

        private void btn_addcar_Click(object sender, EventArgs e)
        {
            loadform(new AddCarForm());
        }

        private void btn_updatecar_Click(object sender, EventArgs e)
        {
            loadform(new CarUpdateForm());
        }

        private void btn_addpart_Click(object sender, EventArgs e)
        {
            loadform(new AddPartForm());
        }

        private void btn_updatepart_Click(object sender, EventArgs e)
        {
            loadform(new UpdatePartForm());
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            loadform(new CustomerUpdateForm());
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            loadform(new AdminOrderForm());
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btn_dash_Click(object sender, EventArgs e)
        {
            loadform(new DashboardForm());
        }
    }
}
