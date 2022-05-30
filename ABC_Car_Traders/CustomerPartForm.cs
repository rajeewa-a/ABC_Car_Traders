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

namespace ABC_Car_Traders
{
    public partial class CustomerPartForm : Form
    {
        public CustomerPartForm()
        {
            InitializeComponent();
            btn_order.Hide();
        }

        List<car_part> list = new List<car_part>();
        List<car_part> result = new List<car_part>();

        int partid;

        private void datagridcar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            OrderStatic.id = partid;
            OrderStatic.type = "Part";
            var ord = new OrderForm();
            ord.Show();
        }

        private void CustomerPartForm_Load(object sender, EventArgs e)
        {
            list = CarPartBLL.GetCarParts();
            datagridcarparts.DataSource = list;
            datagridcarparts.Columns[0].Visible = false;
            datagridcarparts.Columns[1].HeaderText = "Name";
            datagridcarparts.Columns[2].HeaderText = "Description";
            datagridcarparts.Columns[3].Visible = false;
            datagridcarparts.Columns[4].HeaderText = "In Stock";
            datagridcarparts.Columns[5].HeaderText = "Price (Rs.)";
        }

        private void datagridcarparts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                lbl_name.Text = datagridcarparts.Rows[e.RowIndex].Cells[1].Value.ToString();
                lbl_desc.Text = datagridcarparts.Rows[e.RowIndex].Cells[2].Value.ToString();
                lbl_quantity.Text = datagridcarparts.Rows[e.RowIndex].Cells[4].Value.ToString();
                lbl_price.Text = datagridcarparts.Rows[e.RowIndex].Cells[5].Value.ToString();

                string available = datagridcarparts.Rows[e.RowIndex].Cells[4].Value.ToString();
                string imageloc = datagridcarparts.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (available == "0")
                {
                    lbl_available.Text = "Out of Stock!";
                    lbl_available.ForeColor = Color.Red;
                    btn_order.Hide();
                }
                else
                {
                    lbl_available.Text = "Available";
                    lbl_available.ForeColor = Color.Green;
                    btn_order.Show();
                }

                pic_part.Image = Image.FromFile(imageloc);


                partid = Int32.Parse(datagridcarparts.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.Trim() == "")
            {
                list = CarPartBLL.GetCarParts();
                datagridcarparts.DataSource = list;
            }
            else
            {
                result = CarPartBLL.Search(txt_search.Text);
                datagridcarparts.DataSource = result;
            }
                
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
