namespace mathragnarok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox_A.Text);
            double b = Convert.ToDouble(textBox_B.Text);

            double s = (a*b);
                  
            label_otvet.Text = ""+s;
        }

        private void button_two_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox_A_two.Text);
            double b = Convert.ToDouble(textBox_B_two.Text);

            double p = (a + b)*2;

            label_two.Text = ""+p;

        }

        private void textBox_A_two_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_B_two_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_B_two_Click(object sender, EventArgs e)
        {

        }
    }
}