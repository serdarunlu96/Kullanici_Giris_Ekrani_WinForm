namespace Kullanici_Giris_Ekrani_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSifre.PasswordChar = '*'; // S�fre G�zleme
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.ToLower() == "admin" && txtSifre.Text == "1234")
            {
                Form2 form2 = new Form2();
                form2.lblKarsilama.Text = "Hosgeldin Admin";
                form2.ShowDialog();
            }
            else
                MessageBox.Show("Hatali Giris!");
        }
    }
}