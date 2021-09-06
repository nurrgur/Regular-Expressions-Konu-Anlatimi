using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace RegularExpressions
{
    public partial class FormOrnek : Form
    {
        public FormOrnek()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi k = new Kisi();
            Match m = Regex.Match(txtTc.Text, @"^[1-9][0-9]{10}$");
            Match m2 = Regex.Match(txtTel.Text, @"^[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}$");
            Match m3 = Regex.Match(txtMail.Text, @"^[a-z0-9._%+-]+@[a-z0-9.-]+.(com|org|net|edu|gov|mil|biz|info|mobi)(.[A-Z]{2})?$");
            if (m.Success == false)
            {
                MessageBox.Show("Hatalı Tc girişi");
                return;
            }
            else if (m2.Success == false)
            {
                MessageBox.Show("Hatalı Telefon numarası");
                return;
            }
            else if (m3.Success == false)
            {
                MessageBox.Show("Hatalı mail");
                return;
            }
            else
            {
                k.TcKimlik = txtTc.Text;
                k.TelefonNo = txtTel.Text;
                k.Mail = txtMail.Text;
                lstKisi.Items.Add(k);
            }

        }
    }
}
