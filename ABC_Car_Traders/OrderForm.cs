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
    public partial class OrderForm : Form
    {
        List<car> carlist = CarBLL.GetCar(OrderStatic.id);
        car car1 = new car();

        List<customer> customerlist = CustomerBLL.GetCustomer(UserStatic.Uid);
        customer customer1 = new customer();

        List<car_part> carpartlist = CarPartBLL.GetCarPart(OrderStatic.id);
        car_part carpart1 = new car_part();

        public OrderForm()
        {
            InitializeComponent();

            lbl_id.Text = OrderStatic.id.ToString();
            lbl_type.Text = OrderStatic.type.ToString();
            
            if (OrderStatic.type == "Car")
            {
                car1 = carlist.First();
                lbl_desc.Text = car1.car_make + " " + car1.car_model;
                lbl_price.Text = car1.car_price.ToString();
                lbl_total.Text = (Decimal.ToInt32(num_quantity.Value) * Int32.Parse(car1.car_price)).ToString();
                num_quantity.Maximum = car1.car_stock;
            }
            else
            {
                carpart1 = carpartlist.First();
                lbl_desc.Text = carpart1.part_name;
                lbl_price.Text = carpart1.part_price.ToString();
                lbl_total.Text = (Decimal.ToInt32(num_quantity.Value) * (carpart1.part_price)).ToString();
                num_quantity.Maximum = carpart1.part_stock;
            }
            

            customer1 = customerlist.First();
            txt_add.Text = customer1.address;
            txt_name.Text = customer1.name;
            txt_tp.Text = customer1.contact;

        }

        

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //create new order object
            order neworder = new order();

            //assign values to the object
            neworder.customer_id = customer1.customer_id;
            neworder.shipping_add = txt_add.Text;
            neworder.created_at = DateTime.Now;
            neworder.telephone = txt_tp.Text;
            neworder.order_desc = lbl_desc.Text;
            neworder.ship_to = txt_name.Text;
            neworder.quantity = Int32.Parse(num_quantity.Value.ToString());
            neworder.price = Int32.Parse(lbl_price.Text);
            neworder.total = Int32.Parse(lbl_total.Text);
            neworder.order_type = OrderStatic.type;

            //initial payment status and order status
            neworder.payment_status = "PENDING";
            neworder.order_status = "PROCESSING";

            //create new order
            OrderBLL.AddOrder(neworder);

            //update car stock
            if (OrderStatic.type == "Car")
            {
                CarBLL.UpdateStock(OrderStatic.id, neworder.quantity);
            }
            //update part stock
            else
            {
                CarPartBLL.UpdateStock(OrderStatic.id, neworder.quantity);
            }

            MessageBox.Show("Order successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void num_quantity_ValueChanged(object sender, EventArgs e)
        {

            if(OrderStatic.type == "Car")
            {
                lbl_total.Text = (Decimal.ToInt32(num_quantity.Value) * Int32.Parse(car1.car_price)).ToString();
            }
            else
            {
                lbl_total.Text = (Decimal.ToInt32(num_quantity.Value) * (carpart1.part_price)).ToString();
            }
            
        }
    }
}
