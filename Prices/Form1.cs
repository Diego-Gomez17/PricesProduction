namespace Prices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {


                long num1 = string.IsNullOrEmpty(textBox1.Text) ? 0 : Convert.ToInt64(textBox1.Text);
                long num2 = string.IsNullOrEmpty(textBox2.Text) ? 0 : Convert.ToInt64(textBox2.Text);
                long num3 = string.IsNullOrEmpty(textBox3.Text) ? 0 : Convert.ToInt64(textBox3.Text);
                long num4 = string.IsNullOrEmpty(textBox4.Text) ? 0 : Convert.ToInt64(textBox4.Text);


                double resultado = ((num1 * 2) + (((num2 * 0.30) + num2) * num3) + num4);
                resultado = Convert.ToInt64(resultado + (resultado * 0.45));
                long desc1 = Convert.ToInt64(resultado - (resultado * 0.15));
                long desc2 = Convert.ToInt64(resultado - (resultado * 0.30));
                long desc3 = Convert.ToInt64(resultado - (resultado * 0.45));

                MessageBox.Show($"El prosupuesto total seria: {resultado}");
                dataGridView1.Rows.Add(resultado, desc1, desc2, desc3);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

        }
    }
}