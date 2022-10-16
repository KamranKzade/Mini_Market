using HomeWork_5.Models;
using HomeWork_5.Repository;
using HomeWork_5.UserControls;
using System.Text.RegularExpressions;

namespace HomeWork_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var products = FakeDepo.GetStudents();

            for (int i = products.Count - 1; i >= 0; i--)
            {
                UC_Product uc = new(products[i]);


                uc.Dock = DockStyle.Top;
                uc.pbox_productPicture.BackgroundImageLayout = ImageLayout.Zoom;

                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        public double money = 0;

        private void btn_Click(object sender, EventArgs e)
        {

            if (sender is Button btn)
            {
                switch (btn.Name)
                {
                    case "btn_10_qepik":
                        money += 0.1;
                        txt_mebleg.Text = money.ToString();
                        break;
                    case "btn_20_qepik":
                        money += 0.2;
                        txt_mebleg.Text = money.ToString();
                        break;
                    case "btn_50_qepik":
                        money += 0.4;
                        txt_mebleg.Text = money.ToString();
                        break;
                    case "btn_10_azn":
                        money += 10;
                        txt_mebleg.Text = money.ToString();
                        break;
                    case "btn_20_azn":
                        money += 20;
                        txt_mebleg.Text = money.ToString();
                        break;
                    case "btn_50_azn":
                        money += 50;
                        txt_mebleg.Text = money.ToString();
                        break;
                    default:
                        break;
                }
            }

        }

        private void btn_qebz_almaq_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Mebleg: {money}");
        }




        private void txtbox_pulu_daxil_etme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsAllDigits(txtbox_pulu_daxil_etme.Text) is false)
            {
                txtbox_pulu_daxil_etme.Text = string.Empty;
                MessageBox.Show("Reqem daxil edin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

              


        public double daxil;

        private void txtbox_pulu_daxil_etme_TextChanged(object sender, EventArgs e)
        {

            double.TryParse(txtbox_pulu_daxil_etme.Text, out daxil);
            txt_mebleg.Text = txtbox_pulu_daxil_etme.Text;
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

        private void txtbox_pulu_daxil_etme_KeyDown(object sender, KeyEventArgs e)
        {
            money += daxil;
        }
    }

}