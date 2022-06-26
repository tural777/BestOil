using WinFormsApp1.HelperMethods;
using WinFormsApp1.Models;


namespace WinFormsApp1.UserControls;



public partial class UC_Mini_Cafe : UserControl
{
    public Action? SomethingChanged { get; set; }

    private ProductItem? _productItem;
    public ProductItem? ProductItem
    {
        get
        {

            if (_productItem is null)
                return null;


            if (int.TryParse(txt_quantity.Text, out int result))
                _productItem.Quantity = result;
            else
                _productItem.Quantity = 0;


            _productItem.Selected = cBtn_name.Checked;

            return _productItem;
        }
        set
        {

            if (value is null)
                return;

            _productItem = value;

            txt_price.Text = _productItem.Product?.Price.ToString("F2");
            cBtn_name.Text = _productItem.Product?.Name;
        }
    }



    public UC_Mini_Cafe()
    {
        InitializeComponent();
    }



    private void rBtn_CheckedChanged(object sender, EventArgs e)
    {
        txt_quantity.ReadOnly = !txt_quantity.ReadOnly;
        SomethingChanged?.Invoke();
    }



    private void txt_quantity_TextChanged(object sender, EventArgs e)
    {
        Helper.CheckCorrectNumberFormat(txt_quantity);
        SomethingChanged?.Invoke();
    }
}
