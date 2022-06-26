namespace WinFormsApp1.UserControls;

partial class UC_Mini_Cafe
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

    #region Component Designer generated code

    private void InitializeComponent()
    {
            this.cBtn_name = new System.Windows.Forms.CheckBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cBtn_name
            // 
            this.cBtn_name.AutoSize = true;
            this.cBtn_name.Location = new System.Drawing.Point(5, 6);
            this.cBtn_name.Name = "cBtn_name";
            this.cBtn_name.Size = new System.Drawing.Size(71, 24);
            this.cBtn_name.TabIndex = 10;
            this.cBtn_name.Text = "Name";
            this.cBtn_name.UseVisualStyleBackColor = true;
            this.cBtn_name.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(170, 3);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(79, 27);
            this.txt_price.TabIndex = 9;
            this.txt_price.TabStop = false;
            this.txt_price.Text = "0";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(255, 3);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.PlaceholderText = "0";
            this.txt_quantity.ReadOnly = true;
            this.txt_quantity.Size = new System.Drawing.Size(79, 27);
            this.txt_quantity.TabIndex = 11;
            this.txt_quantity.Tag = "Hot Dog";
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            // 
            // UC_Mini_Cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBtn_name);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_quantity);
            this.Name = "UC_Mini_Cafe";
            this.Size = new System.Drawing.Size(341, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private CheckBox cBtn_name;
    private TextBox txt_price;
    private TextBox txt_quantity;
}
