using System.Text.RegularExpressions;


namespace WinFormsApp1.HelperMethods;

public static class Helper
{
    public static void CheckCorrectNumberFormat(TextBox txt)
    {
        if (!Regex.IsMatch(txt.Text, "^[0-9]*$"))
        {
            MessageBox.Show("Please enter positive numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            txt.Text = string.Empty;
            return;
        }

        if (txt.Text.Length > 3)
        {
            MessageBox.Show("The number of digits cannot exceed 3", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            txt.Text = txt.Text[..^1];
        }


        if (txt.Text.Length > 0 && txt.Text[0] == '0')
        {
            txt.Text = txt.Text[1..];
        }
    }

}
