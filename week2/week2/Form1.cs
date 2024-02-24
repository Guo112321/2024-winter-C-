namespace week2
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double discount;
        private string discountPercent;

        private void button1_Click(object sender, EventArgs e)
        {
            double subTotal = Convert.ToDouble(txtSubtotal.Text);


            if (subTotal < 100)
            {
                discount = 0.05;
                discountPercent = "5%";
            }
            else if (subTotal >= 100 && subTotal <= 300)
            {
                discount = 0.15;
                discountPercent = "15%";
            }
            else if (subTotal > 300 && subTotal <= 500)
            {
                discount = 0.25;
                discountPercent = "25%";
            }
            else if (subTotal > 500)
            {
                discount = 0.3;
                discountPercent = "30%";
            }

            txtDiscountPercent.Text = discountPercent;
            discountAmount.Text = Math.Round((subTotal * discount), 2).ToString("c");
            total.Text = Math.Round((subTotal * (1 - discount)), 2).ToString("c");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
