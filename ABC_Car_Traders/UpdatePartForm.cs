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
    public partial class UpdatePartForm : Form
    {
        public UpdatePartForm()
        {
            InitializeComponent();
        }

        List<car_part> partlist = new List<car_part>();
        List<car_part> result = new List<car_part>();
        car_part carpartdetail = new car_part();

        private void UpdatePartForm_Load(object sender, EventArgs e)
        {
            partlist = CarPartBLL.GetCarParts();
            datagridcarparts.DataSource = partlist;
            datagridcarparts.Columns[0].HeaderText = "ID";
            datagridcarparts.Columns[1].HeaderText = "Name";
            datagridcarparts.Columns[2].Visible = false;
            datagridcarparts.Columns[3].Visible = false;
            datagridcarparts.Columns[4].HeaderText = "Stock";
            datagridcarparts.Columns[5].HeaderText = "Price (Rs.)";

        }

        private void datagridcarparts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                carpartdetail.part_id = Convert.ToInt32(datagridcarparts.Rows[e.RowIndex].Cells[0].Value);
                txt_name.Text = datagridcarparts.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_desc.Text = datagridcarparts.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_price.Text = datagridcarparts.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_stock.Text = datagridcarparts.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (!(txt_desc.Text.Trim() == "" || txt_name.Text.Trim() == "" || txt_price.Text.Trim() == "" || txt_stock.Text.Trim() == ""))
            {
                if (Regex.IsMatch(txt_stock.Text, @"^\d+$"))
                {
                    if (Regex.IsMatch(txt_price.Text, @"^\d+$"))
                    {
                        try
                        {
                            carpartdetail.part_id = carpartdetail.part_id;
                            carpartdetail.part_name = txt_name.Text;
                            carpartdetail.part_price = Int32.Parse(txt_price.Text);
                            carpartdetail.part_stock = Int32.Parse(txt_stock.Text);
                            carpartdetail.part_desc = txt_desc.Text;

                            CarPartBLL.UpdateCarPart(carpartdetail);

                            MessageBox.Show("Car Part details updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            partlist = CarPartBLL.GetCarParts();
                            datagridcarparts.DataSource = partlist;

                                                       
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (DialogResult.Yes == dr)
            {
                CarPartBLL.DeleteCarPart(carpartdetail.part_id);

                MessageBox.Show("Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                partlist = CarPartBLL.GetCarParts();
                datagridcarparts.DataSource = partlist;
            }
            else
            {

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_search.Text.Trim() == "")
            {
                partlist = CarPartBLL.GetCarParts();
                datagridcarparts.DataSource = partlist;
            }
            else
            {
                result = CarPartBLL.Search(txt_search.Text);
                datagridcarparts.DataSource = result;
            }
            
        }
    }
}
