using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DAO;

namespace ABC_Car_Traders
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter ="Image file|*jpg;*jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic_car.Image = Image.FromFile(ofd.FileName);
                    txt_image.Text = ofd.FileName;

                }
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            //check if any of the fields are empty
            if (!(txt_desc.Text.Trim() == "" || txt_image.Text.Trim() == "" || txt_make.Text.Trim() == "" || txt_model.Text.Trim() == ""
                || txt_price.Text.Trim() == "" || txt_stock.Text.Trim() == "" || txt_year.Text.Trim() == ""))
            {
                //check if stock and year provided are integers
                if(Regex.IsMatch(txt_stock.Text, @"^\d+$")){
                    if (Regex.IsMatch(txt_year.Text, @"^\d+$"))
                    {
                        try
                        {
                            //create new car object
                            car newcar = new car();
                            newcar.car_make = txt_make.Text;
                            newcar.car_model = txt_model.Text;
                            newcar.car_price = txt_price.Text;
                            newcar.car_stock = Int32.Parse(txt_stock.Text);
                            newcar.car_year = Int32.Parse(txt_year.Text);
                            newcar.car_desc = txt_desc.Text;

                            newcar.car_image = txt_image.Text;

                            //pass object to bll
                            BLL.CarBLL.AddCar(newcar);

                            DialogResult dr = MessageBox.Show("Car successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dr == DialogResult.OK)
                            {
                                //clear the screen
                                txt_make.Clear();
                                txt_model.Clear();
                                txt_price.Clear();
                                txt_stock.Clear();
                                txt_year.Clear();
                                txt_desc.Clear();
                                txt_image.Clear();
                                pic_car.Image = null;
                            }
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

        private void pic_car_Click(object sender, EventArgs e)
        {

        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
