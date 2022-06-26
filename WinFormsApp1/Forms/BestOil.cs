using WinFormsApp1.HelperMethods;
using WinFormsApp1.Models;
using WinFormsApp1.UserControls;

namespace WinFormsApp1.Forms;




public partial class BestOil : Form
{
    public BestOil()
    {
        InitializeComponent();

        InitializeGasolines();
        InitializeMiniCafeProducts();
    }





    private void InitializeGasolines()
    {
        cBox_fuel_types.ValueMember = "Price";
        cBox_fuel_types.DisplayMember = "Name";
        cBox_fuel_types.DataSource = FakeRepository.GetGasolines();
    }





    private void InitializeMiniCafeProducts()
    {
        int locY = -50;
        foreach (ProductItem item in FakeRepository.GetMiniCafeProducts())
        {
            var control = new UC_Mini_Cafe
            {
                ProductItem = item,
                SomethingChanged = UpdatePayment,
                Location = new Point(panel_products.Location.X - 27, panel_products.Location.Y + locY)
            };

            locY += 50;


            panel_products.Controls.Add(control);
        }
    }





    private void cBox_fuel_types_SelectedIndexChanged(object sender, EventArgs e)
    {
        gasoline_price.Text = ((float)cBox_fuel_types
                               .SelectedValue)
                               .ToString("F2");

        UpdatePayment();
    }





    private void Btn_CheckedChanged(object sender, EventArgs e)
    {
        var btn = sender as RadioButton;

        if (btn is not null)
            foreach (var txt in btn.Parent.Controls.OfType<TextBox>())
            {
                if (txt.Tag?.ToString() == btn.Text)
                {
                    txt.ReadOnly = !txt.ReadOnly;
                    break;
                }
            }


        UpdatePayment();
    }





    private void TextBox_TextChanged(object sender, EventArgs e)
    {
        if(sender is TextBox txt)
        {
            Helper.CheckCorrectNumberFormat(txt);

            UpdatePayment();
        }
    }





    public void UpdatePayment()
    {

        // Calculate Mini Cafe
        float sum = 0, total = 0;

        foreach (var control in panel_products.Controls.OfType<UC_Mini_Cafe>())
        {
            if (control is null)
                continue;

            if (control.ProductItem?.Selected ?? false)
                sum += control.ProductItem.TotalPrice();
        }

        lbl_payment_cafe.Text = Math.Round(sum, 2).ToString();



        total += sum;



        // Calculate Gas Station
        sum = 0;
        foreach (var txt in panel_gas_station.Controls.OfType<TextBox>())
        {
            if (!txt.ReadOnly)
            {
                if (float.TryParse(txt.Text, out float x))
                {
                    if (txt.Tag.ToString() == "Number")
                        sum += (x * (float)cBox_fuel_types.SelectedValue);
                    else
                        sum += x;
                }
                else
                    sum += 0;
            }
        }

        lbl_gasoline.Text = Math.Round(sum, 2).ToString();





        total += sum;
        lbl_total_payment.Text = Math.Round(total, 2).ToString();

    }





    private void Btn_confirm_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"{lbl_total_payment.Text} Azn", "Total payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

   
}