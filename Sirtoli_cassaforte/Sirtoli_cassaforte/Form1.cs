namespace Sirtoli_cassaforte
{
    public partial class Form1 : Form
    {
        private Cassaforte cassaforte;


        public Form1()
        {
            InitializeComponent();
            cassaforte = new Cassaforte("001", "Bosch", "Modello7", "1a2b3c4d5e6f", 12345);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.ToString() != cassaforte.CodiceUtente.ToString())
            {
                textBox1.Text = "Chiusa";
            }
            else
                textBox1.Text = "Aperta";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Chiusa";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.ToString() != cassaforte.CodiceSblocco.ToString())
            {
                textBox1.Text = "Chiusa";
            }
            else
                textBox1.Text = "Aperta";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}