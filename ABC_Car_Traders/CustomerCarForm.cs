using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DAO;

namespace ABC_Car_Traders
{
    public partial class CustomerCarForm : Form
    {
        List<car> list = new List<car>();
        List<car> result = new List<car>(); 

        int carid;
        
        public CustomerCarForm()
        {
            InitializeComponent();
            btn_order.Hide();

        }

        private void CustomerCarForm_Load(object sender, EventArgs e)
        {
            list = CarBLL.GetCars();
            datagridcar.DataSource = list;
            datagridcar.Columns[0].Visible = false;
            datagridcar.Columns[1].HeaderText = "Make";
            datagridcar.Columns[2].HeaderText = "Model";
            datagridcar.Columns[3].HeaderText = "Year";
            datagridcar.Columns[4].HeaderText = "Price (Rs.)";
            datagridcar.Columns[5].Visible = false;
            datagridcar.Columns[6].Visible = false;
            datagridcar.Columns[7].Visible = false;
                    

        }





        public void datagridcar_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            OrderStatic.id = carid;
            OrderStatic.type = "Car";
            var ord = new OrderForm();
            ord.Show();

        }

        private void datagridcar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lbl_make.Text = datagridcar.Rows[e.RowIndex].Cells[1].Value.ToString();
                lbl_model.Text = datagridcar.Rows[e.RowIndex].Cells[2].Value.ToString();
                lbl_year.Text = datagridcar.Rows[e.RowIndex].Cells[3].Value.ToString();
                lbl_desc.Text = datagridcar.Rows[e.RowIndex].Cells[5].Value.ToString();
                lbl_price.Text = datagridcar.Rows[e.RowIndex].Cells[4].Value.ToString();

                string available = datagridcar.Rows[e.RowIndex].Cells[6].Value.ToString();
                string imageloc = datagridcar.Rows[e.RowIndex].Cells[7].Value.ToString();
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

                pic_car.Image = Image.FromFile(imageloc);


                carid = Int32.Parse(datagridcar.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            

        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //if txt is empty
            if (txt_search.Text.Trim() == "")
            {
                list = CarBLL.GetCars();
                datagridcar.DataSource = list;
            }
            else
            {   
                //pass search txt to carbll.search
                result = CarBLL.Search(txt_search.Text);
                datagridcar.DataSource = result;
            }
            
        }
    }
}
