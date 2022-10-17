using HomeWork_5.Models;

namespace HomeWork_5.UserControls;

public partial class UC_Product : UserControl
{
    public double xerc ;

    public UC_Product(Product product)
    {
        InitializeComponent();

        if (!string.IsNullOrWhiteSpace(product.PictureUrl))
        {
            pbox_productPicture.Load($"./../../../Resources/{product.PictureUrl}");
            pbox_productPicture.BackgroundImageLayout = ImageLayout.Stretch;
        }


        lbl_product_name.Text = product.ProductName;
        lbl_product_price.Text = $"{product.Price.ToString()}";

        txt_count.Text = 0.ToString();
        cbox.Checked = product.Checked;
    }

    private void cbox_CheckedChanged(object sender, EventArgs e)
    => txt_count.Visible = cbox.Checked;

    private void txt_count_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (IsAllDigits(txt_count.Text) is false)
        {
            txt_count.Text = string.Empty;
            MessageBox.Show("Reqem daxil edin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }




    bool IsAllDigits(string s)
    {
        foreach (char c in s)
        {
            if (!char.IsDigit(c))
                return false;
        }
        return true;
    }

    private void txt_count_Leave(object sender, EventArgs e)
    {
        int.TryParse(txt_count.Text, out int value);
        double.TryParse(lbl_product_price.Text, out double qiymet);

        xerc += value * qiymet;
    }



}
