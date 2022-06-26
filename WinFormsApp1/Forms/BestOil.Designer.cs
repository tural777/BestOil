namespace WinFormsApp1.Forms;

partial class BestOil
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

   
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestOil));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_total_payment = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_gas_station = new System.Windows.Forms.GroupBox();
            this.rBtn_sum = new System.Windows.Forms.RadioButton();
            this.rBtn_number = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_gasoline = new System.Windows.Forms.Label();
            this.txt_azn = new System.Windows.Forms.TextBox();
            this.txt_liter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gasoline_price = new System.Windows.Forms.TextBox();
            this.cBox_fuel_types = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_payment_cafe = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel_products = new System.Windows.Forms.Panel();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_gas_station.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.lbl_total_payment);
            this.groupBox5.Controls.Add(this.btn_confirm);
            this.groupBox5.Location = new System.Drawing.Point(26, 471);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(757, 124);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Azn";
            // 
            // lbl_total_payment
            // 
            this.lbl_total_payment.AutoSize = true;
            this.lbl_total_payment.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_total_payment.Location = new System.Drawing.Point(468, 29);
            this.lbl_total_payment.Name = "lbl_total_payment";
            this.lbl_total_payment.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbl_total_payment.Size = new System.Drawing.Size(52, 67);
            this.lbl_total_payment.TabIndex = 5;
            this.lbl_total_payment.Text = "0";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.FlatAppearance.BorderSize = 2;
            this.btn_confirm.Location = new System.Drawing.Point(153, 30);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(212, 76);
            this.btn_confirm.TabIndex = 15;
            this.btn_confirm.Text = "Confirm payment";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.Btn_confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Azn";
            // 
            // panel_gas_station
            // 
            this.panel_gas_station.Controls.Add(this.rBtn_sum);
            this.panel_gas_station.Controls.Add(this.rBtn_number);
            this.panel_gas_station.Controls.Add(this.groupBox2);
            this.panel_gas_station.Controls.Add(this.label2);
            this.panel_gas_station.Controls.Add(this.txt_azn);
            this.panel_gas_station.Controls.Add(this.txt_liter);
            this.panel_gas_station.Controls.Add(this.label5);
            this.panel_gas_station.Controls.Add(this.label4);
            this.panel_gas_station.Controls.Add(this.label3);
            this.panel_gas_station.Controls.Add(this.label1);
            this.panel_gas_station.Controls.Add(this.gasoline_price);
            this.panel_gas_station.Controls.Add(this.cBox_fuel_types);
            this.panel_gas_station.Location = new System.Drawing.Point(26, 30);
            this.panel_gas_station.Name = "panel_gas_station";
            this.panel_gas_station.Size = new System.Drawing.Size(365, 414);
            this.panel_gas_station.TabIndex = 3;
            this.panel_gas_station.TabStop = false;
            this.panel_gas_station.Text = "Gas Station";
            // 
            // rBtn_sum
            // 
            this.rBtn_sum.AutoSize = true;
            this.rBtn_sum.Location = new System.Drawing.Point(22, 223);
            this.rBtn_sum.Name = "rBtn_sum";
            this.rBtn_sum.Size = new System.Drawing.Size(59, 24);
            this.rBtn_sum.TabIndex = 3;
            this.rBtn_sum.Tag = "";
            this.rBtn_sum.Text = "Sum";
            this.rBtn_sum.UseVisualStyleBackColor = true;
            this.rBtn_sum.CheckedChanged += new System.EventHandler(this.Btn_CheckedChanged);
            // 
            // rBtn_number
            // 
            this.rBtn_number.AutoSize = true;
            this.rBtn_number.Location = new System.Drawing.Point(22, 186);
            this.rBtn_number.Name = "rBtn_number";
            this.rBtn_number.Size = new System.Drawing.Size(84, 24);
            this.rBtn_number.TabIndex = 3;
            this.rBtn_number.Tag = "";
            this.rBtn_number.Text = "Number";
            this.rBtn_number.UseVisualStyleBackColor = true;
            this.rBtn_number.CheckedChanged += new System.EventHandler(this.Btn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_gasoline);
            this.groupBox2.Location = new System.Drawing.Point(22, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Azn";
            // 
            // lbl_gasoline
            // 
            this.lbl_gasoline.AutoSize = true;
            this.lbl_gasoline.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_gasoline.Location = new System.Drawing.Point(100, 29);
            this.lbl_gasoline.Name = "lbl_gasoline";
            this.lbl_gasoline.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbl_gasoline.Size = new System.Drawing.Size(52, 67);
            this.lbl_gasoline.TabIndex = 2;
            this.lbl_gasoline.Text = "0";
            // 
            // txt_azn
            // 
            this.txt_azn.Location = new System.Drawing.Point(201, 223);
            this.txt_azn.Name = "txt_azn";
            this.txt_azn.PlaceholderText = "0";
            this.txt_azn.ReadOnly = true;
            this.txt_azn.Size = new System.Drawing.Size(87, 27);
            this.txt_azn.TabIndex = 6;
            this.txt_azn.Tag = "Sum";
            this.txt_azn.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txt_liter
            // 
            this.txt_liter.Location = new System.Drawing.Point(201, 185);
            this.txt_liter.Name = "txt_liter";
            this.txt_liter.PlaceholderText = "0";
            this.txt_liter.ReadOnly = true;
            this.txt_liter.Size = new System.Drawing.Size(87, 27);
            this.txt_liter.TabIndex = 5;
            this.txt_liter.Tag = "Number";
            this.txt_liter.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Liter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Azn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gasoline";
            // 
            // gasoline_price
            // 
            this.gasoline_price.Location = new System.Drawing.Point(136, 102);
            this.gasoline_price.Name = "gasoline_price";
            this.gasoline_price.PlaceholderText = "0";
            this.gasoline_price.ReadOnly = true;
            this.gasoline_price.Size = new System.Drawing.Size(152, 27);
            this.gasoline_price.TabIndex = 2;
            this.gasoline_price.TabStop = false;
            // 
            // cBox_fuel_types
            // 
            this.cBox_fuel_types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_fuel_types.FormattingEnabled = true;
            this.cBox_fuel_types.Location = new System.Drawing.Point(136, 56);
            this.cBox_fuel_types.Name = "cBox_fuel_types";
            this.cBox_fuel_types.Size = new System.Drawing.Size(152, 28);
            this.cBox_fuel_types.TabIndex = 1;
            this.cBox_fuel_types.SelectedIndexChanged += new System.EventHandler(this.cBox_fuel_types_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(272, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(187, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Price";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lbl_payment_cafe);
            this.groupBox4.Location = new System.Drawing.Point(22, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 125);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Azn";
            // 
            // lbl_payment_cafe
            // 
            this.lbl_payment_cafe.AutoSize = true;
            this.lbl_payment_cafe.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_payment_cafe.Location = new System.Drawing.Point(100, 29);
            this.lbl_payment_cafe.Name = "lbl_payment_cafe";
            this.lbl_payment_cafe.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbl_payment_cafe.Size = new System.Drawing.Size(52, 67);
            this.lbl_payment_cafe.TabIndex = 2;
            this.lbl_payment_cafe.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel_products);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(418, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 414);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mini-Cafe";
            // 
            // panel_products
            // 
            this.panel_products.Location = new System.Drawing.Point(22, 58);
            this.panel_products.Name = "panel_products";
            this.panel_products.Size = new System.Drawing.Size(321, 214);
            this.panel_products.TabIndex = 5;
            // 
            // BestOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 623);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel_gas_station);
            this.Controls.Add(this.groupBox3);
            this.Name = "BestOil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BestOil";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_gas_station.ResumeLayout(false);
            this.panel_gas_station.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion
    private GroupBox groupBox5;
    private Label label10;
    private Label lbl_total_payment;
    private Button btn_confirm;
    private Label label2;
    private GroupBox panel_gas_station;
    private GroupBox groupBox2;
    private Label label7;
    private Label lbl_gasoline;
    private RadioButton rBtn_number;
    private RadioButton rBtn_sum;
    private TextBox txt_azn;
    private TextBox txt_liter;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label1;
    private TextBox gasoline_price;
    private ComboBox cBox_fuel_types;
    private Label label14;
    private Label label13;
    private GroupBox groupBox4;
    private Label label8;
    private Label lbl_payment_cafe;
    private GroupBox groupBox3;
    private PictureBox pictureBox1;
    private Panel panel_products;
}