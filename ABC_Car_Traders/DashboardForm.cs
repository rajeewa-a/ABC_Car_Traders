using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using BLL;
using DAL;

namespace ABC_Car_Traders
{
    public partial class DashboardForm : Form
    {
        List<revenue> revlist = new List<revenue>();
        
        public DashboardForm()
        {
            InitializeComponent();

            revlist = RevenueBLL.GetRevenue();
            chart_revenue.DataSource = revlist;
            chart_revenue.Series["Revenue"].XValueMember = "month";
            chart_revenue.Series["Revenue"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart_revenue.Series["Revenue"].YValueMembers = "total";
            chart_revenue.Series["Revenue"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;

            chart_rev2.DataSource = revlist;
            chart_rev2.Series["Revenue"].XValueMember = "month";
            chart_rev2.Series["Revenue"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart_rev2.Series["Revenue"].YValueMembers = "total";
            chart_rev2.Series["Revenue"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;

            chart_car.DataSource = revlist;
            chart_car.Series["carsales"].XValueMember = "month";
            chart_car.Series["carsales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart_car.Series["carsales"].YValueMembers = "cars";
            chart_car.Series["carsales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;

            chart_part.DataSource = revlist;
            chart_part.Series["carpartsales"].XValueMember = "month";
            chart_part.Series["carpartsales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart_part.Series["carpartsales"].YValueMembers = "car_parts";
            chart_part.Series["carpartsales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
        }

        List<customer> list = new List<customer>();
        SaveFileDialog sfd = new SaveFileDialog();

        private void btn_customer_Click(object sender, EventArgs e)
        {
            
            list = CustomerBLL.GetCustomers();

            using (IXLWorkbook workbook = new XLWorkbook())
            {

                var ws = workbook.Worksheets.Add("Customers").FirstCell().InsertTable<customer>(list, false);

                ws.Column(6).Delete();

                workbook.SaveAs(@"R:\CustomerReport.xlsx");

            }
        }

        private void btn_cars_Click(object sender, EventArgs e)
        {
            List<car> list = new List<car>();
            list = CarBLL.GetCars();

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx" })
            {
                sfd.FileName = "CarReport.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (IXLWorkbook workbook = new XLWorkbook())
                        {

                            var ws = workbook.Worksheets.Add("Cars").FirstCell().InsertTable<car>(list, false);

                            ws.Column(8).Delete();

                            workbook.SaveAs(sfd.FileName);

                        }

                        MessageBox.Show("Data Successfully Exported!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        private void datagridcustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
        }

        private void btn_parts_Click(object sender, EventArgs e)
        {
            List<car_part> list = new List<car_part>();
            list = CarPartBLL.GetCarParts();

            using (SaveFileDialog sfd = new SaveFileDialog { Filter="Excel Workbook|*.xlsx" })
            {
                sfd.FileName = "CarPartReport.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (IXLWorkbook workbook = new XLWorkbook())
                        {

                            var ws = workbook.Worksheets.Add("Car Parts").FirstCell().InsertTable<car_part>(list, false);

                            ws.Column(4).Delete();

                            workbook.SaveAs(sfd.FileName);

                        }

                        MessageBox.Show("Data Successfully Exported!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

        }

        private void datetime_from_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_sales_Click(object sender, EventArgs e)
        {

            List<sale> list = new List<sale>();
            list = SalesBLL.GetSales(datetime_from.Value, datetime_to.Value);

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx" })
            {
                sfd.FileName = "SalesReport.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (IXLWorkbook workbook = new XLWorkbook())
                        {

                            var ws = workbook.Worksheets.Add("Car Parts").FirstCell().InsertTable<sale>(list, false);


                            workbook.SaveAs(sfd.FileName);

                        }

                        MessageBox.Show("Data Successfully Exported!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        private void chart_revenue_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
