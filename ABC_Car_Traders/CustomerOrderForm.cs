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

namespace ABC_Car_Traders
{
    public partial class CustomerOrderForm : Form
    {
        public CustomerOrderForm()
        {
            InitializeComponent();
        }

        List<order> orderlist = new List<order>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datagridmyorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerOrderForm_Load(object sender, EventArgs e)
        {
            orderlist = OrderBLL.GetMyOrders(UserStatic.Uid);
            datagridmyorders.DataSource = orderlist;
            datagridmyorders.Columns[0].HeaderText = "Order ID";
            datagridmyorders.Columns[1].Visible = false;
            datagridmyorders.Columns[2].Visible = false;
            datagridmyorders.Columns[3].Visible = false;
            datagridmyorders.Columns[4].Visible = false;
            datagridmyorders.Columns[5].HeaderText = "Description";
            datagridmyorders.Columns[6].HeaderText = "Ship To";
            datagridmyorders.Columns[7].HeaderText = "Payment";
            datagridmyorders.Columns[8].HeaderText = "Status";
            datagridmyorders.Columns[9].Visible = false;
            datagridmyorders.Columns[10].Visible = false;
            datagridmyorders.Columns[11].HeaderText = "Amount";
            datagridmyorders.Columns[12].Visible = false;
            datagridmyorders.Columns[13].Visible = false;
        }

        private void datagridmyorders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_oid.Text = datagridmyorders.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_cid.Text = datagridmyorders.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_add.Text = datagridmyorders.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_createdat.Text = datagridmyorders.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_tp.Text = datagridmyorders.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_desc.Text = datagridmyorders.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_name.Text = datagridmyorders.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_quantity.Text = datagridmyorders.Rows[e.RowIndex].Cells[9].Value.ToString();
                txt_price.Text = datagridmyorders.Rows[e.RowIndex].Cells[10].Value.ToString();
                txt_total.Text = datagridmyorders.Rows[e.RowIndex].Cells[11].Value.ToString();
                lbl_payment.Text = datagridmyorders.Rows[e.RowIndex].Cells[7].Value.ToString();
                lbl_status.Text = datagridmyorders.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
                
        }
    }
}
