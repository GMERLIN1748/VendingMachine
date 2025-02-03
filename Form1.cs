namespace VendingMachine
{
    public partial class Form1 : Form
    {
        private int water = 1000;
        private int coffee = 100;
        private int milk = 50;
        private int chocolate = 50;
        public Form1()
        {
            InitializeComponent();
            UpdateStockDisplay();
        }

        private void UpdateStockDisplay()
        {
            textBox1.Text = water.ToString();
            textBox2.Text = coffee.ToString();
            textBox3.Text = milk.ToString();
            textBox4.Text = chocolate.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox1.Text = "300";
                textBox2.Text = "20";
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox4.ReadOnly = true;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = false;
                textBox1.Text = "300";
                textBox2.Text = "20";
                textBox3.Text = "10";
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = false;
                textBox4.Enabled = true;
                textBox1.Text = "300";
                textBox2.Text = "20";
                textBox4.Text = "10";
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox4.ReadOnly = true;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = true;
                textBox1.Text = "300";
                textBox4.Text = "20";
                textBox1.ReadOnly = true;
                textBox4.ReadOnly = true;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // กาแฟดำ
                MakeDrink(300, 20, 0, 0, "Black Coffee");

            if (checkBox2.Checked) // มอคค่า
                MakeDrink(300, 20, 0, 10, "Mocha");

            if (checkBox3.Checked) // ลาเต้
                MakeDrink(300, 20, 10, 0, "Latte");

            if (checkBox4.Checked) // ช็อคโกแลต
                MakeDrink(300, 0, 0, 20, "Chocolate");
        }

        private void MakeDrink(int requiredWater, int requiredCoffee, int requiredMilk, int requiredChocolate, string drinkName)
        {
            if (water >= requiredWater && coffee >= requiredCoffee && milk >= requiredMilk && chocolate >= requiredChocolate)
            {
                water -= requiredWater;
                coffee -= requiredCoffee;
                milk -= requiredMilk;
                chocolate -= requiredChocolate;
                MessageBox.Show($"{drinkName} prepared!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Not enough ingredients for {drinkName}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            UpdateStockDisplay();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            water += int.Parse(textBox5.Text);
            coffee += int.Parse(textBox6.Text);
            milk += int.Parse(textBox7.Text);
            chocolate += int.Parse(textBox8.Text);

            MessageBox.Show("Stock replenished!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateStockDisplay();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
