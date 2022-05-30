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
using DAL.DAO;
using System.Text.RegularExpressions;

namespace ABC_Car_Traders
{
    public partial class CarUpdateForm : Form
    {
        public CarUpdateForm()
        {
            InitializeComponent();
        }

        List<car> list = new List<car>();
        List<car> result = new List<car>();
        public car cardetail = new car();


        private void CustomerForm_Load(object sender, EventArgs e)
        {

            list = CarBLL.GetCars();
            datagridcars.DataSource = list;
            datagridcars.Columns[0].Visible = false;
            datagridcars.Columns[1].HeaderText = "Make";
            datagridcars.Columns[2].HeaderText = "Model";
            datagridcars.Columns[3].HeaderText = "Year";
            datagridcars.Columns[4].HeaderText = "Price (Rs.)";
            datagridcars.Columns[5].Visible = false;
            datagridcars.Columns[6].HeaderText = "Stock";
            datagridcars.Columns[7].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                cardetail.car_id = Convert.ToInt32(datagridcars.Rows[e.RowIndex].Cells[0].Value);
                txt_make.Text = datagridcars.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_model.Text = datagridcars.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_price.Text = datagridcars.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_desc.Text = datagridcars.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_stock.Text = datagridcars.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_year.Text = datagridcars.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //check if any fields are left empty
            if (!(txt_desc.Text.Trim() == "" || txt_make.Text.Trim() == "" || txt_model.Text.Trim() == ""
                || txt_price.Text.Trim() == "" || txt_stock.Text.Trim() == "" || txt_year.Text.Trim() == ""))
            {
                //check if stock and year are integers
                if (Regex.IsMatch(txt_stock.Text, @"^\d+$"))
                {
                    if (Regex.IsMatch(txt_year.Text, @"^\d+$"))
                    {
                        try
                        {
                            //assign the new values to the object
                            cardetail.car_id = cardetail.car_id;
                            cardetail.car_make = txt_make.Text;
                            cardetail.car_model = txt_model.Text;
                            cardetail.car_price = txt_price.Text;
                            cardetail.car_desc = txt_desc.Text;
                            cardetail.car_year = Int32.Parse(txt_year.Text);
                            cardetail.car_stock = Int32.Parse(txt_stock.Text);

                            //pass the object to the bll
                            CarBLL.UpdateCar(cardetail);

                            MessageBox.Show("Car details successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            list = CarBLL.GetCars();
                            datagridcars.DataSource = list;

                        }
                        catch
                        {
                            MessageBox.Show("An error has occured. Please try again!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Enter a valid year!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Stock can only contain numbers!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                CarBLL.DeleteCar(cardetail.car_id);

                MessageBox.Show("Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                list = CarBLL.GetCars();
                datagridcars.DataSource = list;
            }
            else
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_search.Text.Trim() == "")
            {
                list = CarBLL.GetCars();
                datagridcars.DataSource = list;
            }
            else
            {
                result = CarBLL.Search(txt_search.Text);
                datagridcars.DataSource = result;
            }

            
        }
    }
}
