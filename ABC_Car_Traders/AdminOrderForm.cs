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
    public partial class AdminOrderForm : Form
    {
        public AdminOrderForm()
        {
            InitializeComponent();
            cb_payment.Items.Add("UNPAID");
            cb_payment.Items.Add("PAID");
            cb_payment.SelectedIndex = 0;

            cb_status.Items.Add("PROCESSING");
            cb_status.Items.Add("CANCELLED");
            cb_status.Items.Add("COMPLETE");
            cb_status.SelectedIndex = 0;
        }

        
        List<order> result = new List<order>();
        order order1 = new order();

        sale newsale = new sale();

        string type;

        //initialize order object
        List<order> orderlist = new List<order>();

        private void AdminOrderForm_Load(object sender, EventArgs e)
        {
            //get all orders
            orderlist = OrderBLL.GetOrders();

            //display the order data
            datagridorders.DataSource = orderlist;
            datagridorders.Columns[0].HeaderText = "Order ID";
            datagridorders.Columns[1].Visible = false;
            datagridorders.Columns[2].Visible = false;
            datagridorders.Columns[3].HeaderText = "Created At";
            datagridorders.Columns[4].Visible = false;
            datagridorders.Columns[5].HeaderText = "Description";
            datagridorders.Columns[6].Visible = false;
            datagridorders.Columns[7].HeaderText = "Payment";
            datagridorders.Columns[8].HeaderText = "Status";
            datagridorders.Columns[9].Visible = false;
            datagridorders.Columns[10].Visible = false;
            datagridorders.Columns[11].Visible = false;
            datagridorders.Columns[12].Visible = false;
            datagridorders.Columns[13].Visible = false;

        }

        private void datagridorders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //to avoid indexing error
            if (e.RowIndex >= 0)
            {
                order1.order_id = Int32.Parse(datagridorders.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_oid.Text = datagridorders.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_cid.Text = datagridorders.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_add.Text = datagridorders.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_createdat.Text = datagridorders.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_tp.Text = datagridorders.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_desc.Text = datagridorders.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_name.Text = datagridorders.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_quantity.Text = datagridorders.Rows[e.RowIndex].Cells[9].Value.ToString();
                txt_price.Text = datagridorders.Rows[e.RowIndex].Cells[10].Value.ToString();
                txt_total.Text = datagridorders.Rows[e.RowIndex].Cells[11].Value.ToString();
                type = datagridorders.Rows[e.RowIndex].Cells[12].Value.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dr)
            {
                if(cb_status.SelectedItem.ToString() == "COMPLETE")
                {
                    //enter into sales table
                    newsale.created_at = DateTime.Now;
                    newsale.sale_type = type;
                    newsale.sale_desc = txt_desc.Text;
                    newsale.unit_price = Int32.Parse(txt_price.Text);
                    newsale.sale_quantity = Int32.Parse(txt_quantity.Text);
                    newsale.total_amount = Int32.Parse(txt_total.Text);

                    SalesBLL.AddSale(newsale);
                    //OrderBLL.DeleteOrder(order1.order_id);

                    //update order table
                    order1.order_id = order1.order_id;
                    order1.payment_status = cb_payment.SelectedItem.ToString();
                    order1.order_status = cb_status.SelectedItem.ToString();

                    OrderBLL.UpdateOrder(order1);

                    MessageBox.Show("Sales Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    orderlist = OrderBLL.GetOrders();
                    datagridorders.DataSource = orderlist;
                }
                else
                {
                    //if order is not completed
                    order1.order_id = order1.order_id;
                    order1.payment_status = cb_payment.SelectedItem.ToString();
                    order1.order_status = cb_status.SelectedItem.ToString();


                    OrderBLL.UpdateOrder(order1);

                    MessageBox.Show("Order Details Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    orderlist = OrderBLL.GetOrders();
                    datagridorders.DataSource = orderlist;
                }
                
            }

        }

        private void txt_quantity_Click(object sender, EventArgs e)
        {

        }

        private void datagridorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_search.Text.Trim() == "")
            {
                orderlist = OrderBLL.GetOrders();
                datagridorders.DataSource = orderlist;
            }
            else
            {
                result = OrderBLL.Search(txt_search.Text);
                datagridorders.DataSource = result;
            }
            
        }
    }
}
