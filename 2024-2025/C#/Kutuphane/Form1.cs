namespace Kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox2.Text;
            if (ad == "admin" && sifre == "123456")
            {
                MessageBox.Show("Kullan�c� ad� do�ru, sisteme giri� yapt�n�z");
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }
    }
}