
using System;
using System.IO;
using System.Windows.Forms;

namespace LUCKY_COFFEE_ORDER
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            
            string customername = txtname.Text;

            if (customername.Trim() == "")
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }

            
            int quantity;

            if (!int.TryParse(txtquantity.Text, out quantity) || quantity < 1)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

           
            double price = 0;
            string drink = "";

            if (rdotea.Checked)
            {
                price = 1;
                drink = "Tea";
            }
            else if (rdocoffee.Checked)
            {
                price = 2;
                drink = "Coffee";
            }
            else if (rdojuice.Checked)
            {
                price = 3;
                drink = "Juice";
            }
            else
            {
                MessageBox.Show("Please select a drink.");
                return;
            }

            
            OrderList.Items.Clear();

           
            bool wonPrize = false;

            for (int i = 1; i <= quantity; i++)
            {
                int luckynumber = rand.Next(1, 51);

                if (luckynumber == 7 || luckynumber == 17)
                {
                    wonPrize = true;
                }

                OrderList.Items.Add(
                    i + ") " + customername + " - " + drink +
                    " - Lucky: " + luckynumber +
                    " - $" + price.ToString("0.00")
                );
            }

           
            double total = price * quantity;
            double discount = 0;

            if (chkstudent.Checked)
            {
                discount = total * 0.10;
            }

            double finaltotal = total - discount;

           
            lbltotal.Text = "Total Price: $" + finaltotal.ToString("0.00");

           
            if (wonPrize)
            {
                lbllucky.Text = "You got a Free Cookie!";
            }
            else
            {
                lbllucky.Text = "No prize this time.";
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderList.Items.Count == 0)
                {
                    MessageBox.Show("No order to save.");
                    return;
                }

                StreamWriter writer = File.AppendText("orders.txt");

                for (int i = 0; i < OrderList.Items.Count; i++)
                {
                    writer.WriteLine(OrderList.Items[i].ToString());
                }

                writer.WriteLine(lbltotal.Text);
                writer.WriteLine(lbllucky.Text);

                writer.Close();

                MessageBox.Show("Order saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("orders.txt"))
                {
                    MessageBox.Show("No file found.");
                    return;
                }

                OrderList.Items.Clear();

                StreamReader reader = File.OpenText("orders.txt");

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    OrderList.Items.Add(line);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtquantity.Clear();

            OrderList.Items.Clear();

            lbltotal.Text = "Total Price: $0.00";
            lbllucky.Text = "Lucky Message:";

            chkstudent.Checked = false;

            rdotea.Checked = false;
            rdocoffee.Checked = false;
            rdojuice.Checked = false;

            txtname.Focus();
        }
    }
}
