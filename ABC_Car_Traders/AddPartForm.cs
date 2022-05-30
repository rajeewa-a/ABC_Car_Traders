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
using System.Text.RegularExpressions;

namespace ABC_Car_Traders
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!(txt_description.Text.Trim() == "" || txt_image.Text.Trim() == "" || txt_name.Text.Trim() == "" || txt_price.Text.Trim() == ""
                || txt_stock.Text.Trim() == "" ))
            {
                if (Regex.IsMatch(txt_stock.Text, @"^\d+$"))
                {
                    if (Regex.IsMatch(txt_price.Text, @"^\d+$"))
                    {
                        try
                        {
                            car_part newcarpart = new car_part();
                            newcarpart.part_name = txt_name.Text;
                            newcarpart.part_desc = txt_description.Text;
                            newcarpart.part_image = txt_image.Text;
                            newcarpart.part_price = Int32.Parse(txt_price.Text);
                            newcarpart.part_stock = Int32.Parse(txt_stock.Text);

                            CarPartBLL.AddPart(newcarpart);

                            DialogResult dr = MessageBox.Show("Car Part successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dr == DialogResult.OK)
                            {
                                txt_description.Clear();
                                txt_image.Clear();
                                txt_name.Clear();
                                txt_stock.Clear();
                                txt_price.Clear();
                                pic_carpart.Image = null;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("An error has occured. Please try again!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Price can only contain numbers!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btn_image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image file|*jpg;*jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic_carpart.Image = Image.FromFile(ofd.FileName);
                    txt_image.Text = ofd.FileName;

                }
            }
        }
    }
}
