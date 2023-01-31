namespace ogr_sinav_durum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int snv1, snv2, snv3,ort;
            string durum;
            snv1 = Convert.ToInt16(textBox1.Text);
            snv2 = Convert.ToInt16(textBox2.Text);
            snv3 = Convert.ToInt16(textBox3.Text);
            ort = (snv1 + snv2 + snv3) / 3;
            textBox4.Enabled = false;
            if (ort>=50)
            {
                durum = "Geçti";
                textBox4.Text = ort + " " + durum;
            }
            else
            {
                durum = "Kaldý";
                textBox4.Text = ort + " " + durum;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}