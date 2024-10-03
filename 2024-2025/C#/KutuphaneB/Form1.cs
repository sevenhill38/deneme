namespace KutuphaneB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string ad;
            string sifre;
            ad = textBox1.Text;
            sifre = textBox2.Text;

            if (ad == "admin")
            {
                if (sifre == "1234ab")
                {
                    MessageBox.Show("Kullanýcý adý ve þifre doðru, sisteme giriþ yapabilirsiniz!!!");
                }
                else
                {
                    sayac++;
                    if (sayac == 3)
                    {
                        button1.Enabled = false;
                        MessageBox.Show("Þifreyi çok fazla hatalý giriþ yapýldý");
                    }
                    MessageBox.Show("Þifreyi hatalý girdiniz");
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanýcý adý bulunamadý!!!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.Blue;
            checkBox1.Checked = true;
        }
    }
}