using HomeWork_5.Models;

namespace HomeWork_5.UserControls;

public partial class UC_Product : UserControl
{
    public UC_Product(Product product)
    {
        InitializeComponent();

        if (!string.IsNullOrWhiteSpace(product.PictureUrl))
        {
            pbox_productPicture.Load($"./../../../Resources/{product.PictureUrl}");
            pbox_productPicture.BackgroundImageLayout = ImageLayout.Stretch;
        }


        lbl_product_name.Text = product.ProductName;
        lbl_product_price.Text = $"{product.Price.ToString()} azn" ;

        txt_count.Text = 0.ToString();
        cbox.Checked = product.Checked;
    }

    private void cbox_CheckedChanged(object sender, EventArgs e)
    => txt_count.Visible = cbox.Checked;
}
