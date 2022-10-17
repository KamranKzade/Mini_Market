using HomeWork_5.Repository;
using HomeWork_5.UserControls;
using System.Text;

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

                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        public double money = 0;
        public double odenis = 0;


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
                        money += 0.5;
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

            flowLayoutPanel1.Enabled = true;
        }
        private void txtbox_pulu_daxil_etme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsAllDigits(txtbox_pulu_daxil_etme.Text) is false)
            {
                txtbox_pulu_daxil_etme.Text = string.Empty;
                MessageBox.Show("Reqem daxil edin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtbox_pulu_daxil_etme_TextChanged(object sender, EventArgs e)
        {
            txt_mebleg.Text = txtbox_pulu_daxil_etme.Text;
            flowLayoutPanel1.Enabled = true;
        }
        private void txtbox_pulu_daxil_etme_Leave(object sender, EventArgs e)
        {
            double.TryParse(txtbox_pulu_daxil_etme.Text, out double daxil);
            money += daxil;
        }
        private void btn_qebz_almaq_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new();
            sb.Append($"Alinan Mallar\n");
            foreach (var control in flowLayoutPanel1.Controls)
            {
                if (control is UC_Product uC_Product)
                {
                    if (uC_Product.cbox.Checked)
                    {
                        odenis += uC_Product.xerc;
                        sb.Append(@$"{(uC_Product.lbl_product_name.Text)} -> {uC_Product.txt_count.Text.ToString()} eded 
");
                    }
                }
            }

            double qaliq = money - odenis;
            txt_box_qaliq.Text = qaliq.ToString();
            sb.Append($"Daxil edilen pul: {money}\nOdenilen mebleg: {odenis}\n");


            if (qaliq >= 0)
            {
                sb.Append($@"Qaliq: {qaliq}");
                MessageBox.Show(sb.ToString(), "Qebz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                double borc = money - odenis;
                sb.Append($@"Borc: {borc * -1}");
                MessageBox.Show(sb.ToString(), "Qebz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Zehmet olmasa tez bir zamanda borcunuzu odeyin ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
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
    }
}