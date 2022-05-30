
namespace ABC_Car_Traders
{
    partial class AdminDashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_dash = new System.Windows.Forms.Button();
            this.pnl_carmenu = new System.Windows.Forms.Panel();
            this.btn_updatecar = new System.Windows.Forms.Button();
            this.btn_addcar = new System.Windows.Forms.Button();
            this.btn_cars = new System.Windows.Forms.Button();
            this.pnl_partmenu = new System.Windows.Forms.Panel();
            this.btn_updatepart = new System.Windows.Forms.Button();
            this.btn_addpart = new System.Windows.Forms.Button();
            this.btn_partmenu = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_un = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.time_carmenu = new System.Windows.Forms.Timer(this.components);
            this.time_partmenu = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnl_carmenu.SuspendLayout();
            this.pnl_partmenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 30);
            this.panel1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(1070, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 30);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(125)))));
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 570);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_dash);
            this.flowLayoutPanel1.Controls.Add(this.pnl_carmenu);
            this.flowLayoutPanel1.Controls.Add(this.pnl_partmenu);
            this.flowLayoutPanel1.Controls.Add(this.btn_customers);
            this.flowLayoutPanel1.Controls.Add(this.btn_orders);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 158);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(170, 369);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btn_dash
            // 
            this.btn_dash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(125)))));
            this.btn_dash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_dash.FlatAppearance.BorderSize = 0;
            this.btn_dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dash.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dash.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dash.Image = global::ABC_Car_Traders.Properties.Resources.icons8_dashboard_24;
            this.btn_dash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dash.Location = new System.Drawing.Point(3, 3);
            this.btn_dash.Name = "btn_dash";
            this.btn_dash.Size = new System.Drawing.Size(170, 40);
            this.btn_dash.TabIndex = 4;
            this.btn_dash.Text = "Dashboard";
            this.btn_dash.UseVisualStyleBackColor = false;
            this.btn_dash.Click += new System.EventHandler(this.btn_dash_Click);
            // 
            // pnl_carmenu
            // 
            this.pnl_carmenu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_carmenu.Controls.Add(this.btn_updatecar);
            this.pnl_carmenu.Controls.Add(this.btn_addcar);
            this.pnl_carmenu.Controls.Add(this.btn_cars);
            this.pnl_carmenu.Location = new System.Drawing.Point(3, 49);
            this.pnl_carmenu.MaximumSize = new System.Drawing.Size(170, 111);
            this.pnl_carmenu.MinimumSize = new System.Drawing.Size(170, 40);
            this.pnl_carmenu.Name = "pnl_carmenu";
            this.pnl_carmenu.Size = new System.Drawing.Size(170, 40);
            this.pnl_carmenu.TabIndex = 0;
            // 
            // btn_updatecar
            // 
            this.btn_updatecar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(120)))), ((int)(((byte)(168)))));
            this.btn_updatecar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_updatecar.FlatAppearance.BorderSize = 0;
            this.btn_updatecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatecar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatecar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_updatecar.Image = global::ABC_Car_Traders.Properties.Resources.icons8_circle_16__1_;
            this.btn_updatecar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updatecar.Location = new System.Drawing.Point(0, 75);
            this.btn_updatecar.Name = "btn_updatecar";
            this.btn_updatecar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_updatecar.Size = new System.Drawing.Size(170, 35);
            this.btn_updatecar.TabIndex = 2;
            this.btn_updatecar.Text = "Update/Delete";
            this.btn_updatecar.UseVisualStyleBackColor = false;
            this.btn_updatecar.Click += new System.EventHandler(this.btn_updatecar_Click);
            // 
            // btn_addcar
            // 
            this.btn_addcar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(120)))), ((int)(((byte)(168)))));
            this.btn_addcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_addcar.FlatAppearance.BorderSize = 0;
            this.btn_addcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addcar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_addcar.Image = global::ABC_Car_Traders.Properties.Resources.icons8_circle_16__1_;
            this.btn_addcar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addcar.Location = new System.Drawing.Point(0, 40);
            this.btn_addcar.Name = "btn_addcar";
            this.btn_addcar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_addcar.Size = new System.Drawing.Size(170, 35);
            this.btn_addcar.TabIndex = 1;
            this.btn_addcar.Text = "Add New Car";
            this.btn_addcar.UseVisualStyleBackColor = false;
            this.btn_addcar.Click += new System.EventHandler(this.btn_addcar_Click);
            // 
            // btn_cars
            // 
            this.btn_cars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(125)))));
            this.btn_cars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cars.FlatAppearance.BorderSize = 0;
            this.btn_cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cars.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cars.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cars.Image = global::ABC_Car_Traders.Properties.Resources.icons8_car_30;
            this.btn_cars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cars.Location = new System.Drawing.Point(0, 0);
            this.btn_cars.Name = "btn_cars";
            this.btn_cars.Size = new System.Drawing.Size(170, 40);
            this.btn_cars.TabIndex = 0;
            this.btn_cars.Text = "Cars";
            this.btn_cars.UseVisualStyleBackColor = false;
            this.btn_cars.Click += new System.EventHandler(this.btn_cars_Click);
            // 
            // pnl_partmenu
            // 
            this.pnl_partmenu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_partmenu.Controls.Add(this.btn_updatepart);
            this.pnl_partmenu.Controls.Add(this.btn_addpart);
            this.pnl_partmenu.Controls.Add(this.btn_partmenu);
            this.pnl_partmenu.Location = new System.Drawing.Point(3, 95);
            this.pnl_partmenu.MaximumSize = new System.Drawing.Size(170, 111);
            this.pnl_partmenu.MinimumSize = new System.Drawing.Size(170, 40);
            this.pnl_partmenu.Name = "pnl_partmenu";
            this.pnl_partmenu.Size = new System.Drawing.Size(170, 40);
            this.pnl_partmenu.TabIndex = 3;
            // 
            // btn_updatepart
            // 
            this.btn_updatepart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(120)))), ((int)(((byte)(168)))));
            this.btn_updatepart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_updatepart.FlatAppearance.BorderSize = 0;
            this.btn_updatepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatepart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatepart.ForeColor = System.Drawing.Color.Transparent;
            this.btn_updatepart.Image = global::ABC_Car_Traders.Properties.Resources.icons8_circle_16__1_;
            this.btn_updatepart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updatepart.Location = new System.Drawing.Point(0, 75);
            this.btn_updatepart.Name = "btn_updatepart";
            this.btn_updatepart.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_updatepart.Size = new System.Drawing.Size(170, 35);
            this.btn_updatepart.TabIndex = 2;
            this.btn_updatepart.Text = "Update/Delete";
            this.btn_updatepart.UseVisualStyleBackColor = false;
            this.btn_updatepart.Click += new System.EventHandler(this.btn_updatepart_Click);
            // 
            // btn_addpart
            // 
            this.btn_addpart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(120)))), ((int)(((byte)(168)))));
            this.btn_addpart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_addpart.FlatAppearance.BorderSize = 0;
            this.btn_addpart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addpart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addpart.ForeColor = System.Drawing.Color.Transparent;
            this.btn_addpart.Image = global::ABC_Car_Traders.Properties.Resources.icons8_circle_16__1_;
            this.btn_addpart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addpart.Location = new System.Drawing.Point(0, 40);
            this.btn_addpart.Name = "btn_addpart";
            this.btn_addpart.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_addpart.Size = new System.Drawing.Size(170, 35);
            this.btn_addpart.TabIndex = 1;
            this.btn_addpart.Text = "Add New Part";
            this.btn_addpart.UseVisualStyleBackColor = false;
            this.btn_addpart.Click += new System.EventHandler(this.btn_addpart_Click);
            // 
            // btn_partmenu
            // 
            this.btn_partmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(125)))));
            this.btn_partmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_partmenu.FlatAppearance.BorderSize = 0;
            this.btn_partmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_partmenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_partmenu.ForeColor = System.Drawing.Color.Transparent;
            this.btn_partmenu.Image = global::ABC_Car_Traders.Properties.Resources.icons8_gears_24;
            this.btn_partmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_partmenu.Location = new System.Drawing.Point(0, 0);
            this.btn_partmenu.Name = "btn_partmenu";
            this.btn_partmenu.Size = new System.Drawing.Size(170, 40);
            this.btn_partmenu.TabIndex = 0;
            this.btn_partmenu.Text = "Car Parts";
            this.btn_partmenu.UseVisualStyleBackColor = false;
            this.btn_partmenu.Click += new System.EventHandler(this.btn_partmenu_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(125)))));
            this.btn_customers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_customers.FlatAppearance.BorderSize = 0;
            this.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.ForeColor = System.Drawing.Color.Transparent;
            this.btn_customers.Image = global::ABC_Car_Traders.Properties.Resources.icons8_user_account_24;
            this.btn_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customers.Location = new System.Drawing.Point(3, 141);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(170, 40);
            this.btn_customers.TabIndex = 1;
            this.btn_customers.Text = "Customers";
            this.btn_customers.UseVisualStyleBackColor = false;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(125)))));
            this.btn_orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_orders.FlatAppearance.BorderSize = 0;
            this.btn_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders.ForeColor = System.Drawing.Color.Transparent;
            this.btn_orders.Image = global::ABC_Car_Traders.Properties.Resources.icons8_shopping_cart_24;
            this.btn_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_orders.Location = new System.Drawing.Point(3, 187);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(170, 40);
            this.btn_orders.TabIndex = 2;
            this.btn_orders.Text = "Orders";
            this.btn_orders.UseVisualStyleBackColor = false;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbl_un);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 152);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABC_Car_Traders.Properties.Resources.icons8_account_96;
            this.pictureBox1.InitialImage = global::ABC_Car_Traders.Properties.Resources.icons8_account_96;
            this.pictureBox1.Location = new System.Drawing.Point(34, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_un
            // 
            this.lbl_un.AutoSize = true;
            this.lbl_un.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_un.ForeColor = System.Drawing.Color.White;
            this.lbl_un.Location = new System.Drawing.Point(22, 103);
            this.lbl_un.Name = "lbl_un";
            this.lbl_un.Size = new System.Drawing.Size(133, 16);
            this.lbl_un.TabIndex = 4;
            this.lbl_un.Text = "ADMINISTRATOR";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(125)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::ABC_Car_Traders.Properties.Resources.icons8_sign_out_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(170, 30);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(930, 570);
            this.mainpanel.TabIndex = 4;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // time_carmenu
            // 
            this.time_carmenu.Interval = 14;
            this.time_carmenu.Tick += new System.EventHandler(this.time_carmenu_Tick);
            // 
            // time_partmenu
            // 
            this.time_partmenu.Interval = 14;
            this.time_partmenu.Tick += new System.EventHandler(this.time_partmenu_Tick);
            // 
            // AdminDashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnl_carmenu.ResumeLayout(false);
            this.pnl_partmenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_un;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Button btn_cars;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_carmenu;
        private System.Windows.Forms.Button btn_addcar;
        private System.Windows.Forms.Button btn_updatecar;
        private System.Windows.Forms.Timer time_carmenu;
        private System.Windows.Forms.Panel pnl_partmenu;
        private System.Windows.Forms.Button btn_updatepart;
        private System.Windows.Forms.Button btn_addpart;
        private System.Windows.Forms.Button btn_partmenu;
        private System.Windows.Forms.Timer time_partmenu;
        private System.Windows.Forms.Button btn_dash;
    }
}