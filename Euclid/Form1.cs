namespace Euclid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int gcd = Euclid(a, b);
            label2.Text = "GCD = " + gcd;
        }

        private int Euclid(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return Euclid(b, a % b);
        }
    }
}
