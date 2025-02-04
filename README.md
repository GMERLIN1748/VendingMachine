# VendingMachine

by Krittin Intrakool 673450030-6  Computer and Infomation Science, KKU

![image](https://github.com/user-attachments/assets/5ae66c27-9d75-40c8-9a5a-6de2431d06d2)

## Show raw material
```
 private int water = 3000;
 private int coffee = 500;
 private int milk = 500;
 private int chocolate = 500;
```
## Update raw materials
```
textBox1.Text = water.ToString();
textBox2.Text = coffee.ToString();
textBox3.Text = milk.ToString();
textBox4.Text = chocolate.ToString();
```
## Check the menu preparation
```
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
```
## Start menu button
```
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

```
## How to do it
```
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

```
## Add Ingredients Button
```
private void button2_Click(object sender, EventArgs e)
{
    water += int.Parse(textBox5.Text);
    coffee += int.Parse(textBox6.Text);
    milk += int.Parse(textBox7.Text);
    chocolate += int.Parse(textBox8.Text);

    MessageBox.Show("Stock replenished!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    UpdateStockDisplay();
}

```
## Class
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Item
    {
        private string name;
        private int price;
        private int stock;

        public Item(string name, int price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
            this.Quantity = 0;
            this.RequiredAmount = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public int Quantity { get; set; }
        public int RequiredAmount { get; set; }


        public bool HasEnoughStock()
        {
            return Quantity >= RequiredAmount;
        }

        public void UseItem()
        {
            if (HasEnoughStock())
            {
                Quantity -= RequiredAmount;
                Console.WriteLine($"{Name} used. Remaining: {Quantity}g");
            }
            else
            {
                Console.WriteLine($"Not enough {Name} in stock.");
            }
        }

        public void Refill(int amount)
        {
            Quantity += amount;
            Console.WriteLine($"{Name} refilled. New stock: {Quantity}g");
        }
    }
}


```
