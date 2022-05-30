using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ABC_Car_Traders
{
    public partial class CustomerUpdateForm : Form
    {
        public CustomerUpdateForm()
        {
            InitializeComponent();
        }

        List<customer> customerlist = new List<customer>();
        List<customer> result = new List<customer>();
        customer customer1 = new customer();

        private void CustomerUpdateForm_Load(object sender, EventArgs e)
        {
            customerlist = CustomerBLL.GetCustomers();
            datagridcustomers.DataSource = customerlist;
            datagridcustomers.Columns[0].HeaderText = "ID";
            datagridcustomers.Columns[1].HeaderText = "Name";
            datagridcustomers.Columns[2].Visible = false;
            datagridcustomers.Columns[3].HeaderText = "DOB";
            datagridcustomers.Columns[4].HeaderText = "Telephone";
            datagridcustomers.Columns[5].Visible = false;
        }

        private void datagridcustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagridcustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                customer1.customer_id = datagridcustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbl_id.Text = customer1.customer_id;
                txt_name.Text = datagridcustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_add.Text = datagridcustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_no.Text = datagridcustomers.Rows[e.RowIndex].Cells[4].Value.ToString();
                date_dob.Value = DateTime.Parse(datagridcustomers.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!(txt_add.Text.Trim() == "" || txt_name.Text.Trim() == "" || txt_no.Text.Trim() == ""))
            {
                try
                {
                    customer1.customer_id = customer1.customer_id;
                    customer1.name = txt_name.Text;
                    customer1.address = txt_add.Text;
                    customer1.contact = txt_no.Text;
                    customer1.dob = date_dob.Value;


                    CustomerBLL.UpdateCustomer(customer1);

                    MessageBox.Show("Customer details successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    customerlist = CustomerBLL.GetCustomers();
                    datagridcustomers.DataSource = customerlist;
                }
                catch
                {
                    MessageBox.Show("An error has occured. Please try again!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("All fields are required!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (DialogResult.Yes == dr)
            {
                CustomerBLL.DeleteCustomer(customer1.customer_id);

                MessageBox.Show("Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                customerlist = CustomerBLL.GetCustomers();
                datagridcustomers.DataSource = customerlist;
            }
            else
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_search.Text.Trim() == "")
            {
                customerlist = CustomerBLL.GetCustomers();
                datagridcustomers.DataSource = customerlist;
            }
            else
            {
                result = CustomerBLL.Search(txt_search.Text);
                datagridcustomers.DataSource = result;
            }
            
        }
    }
}
