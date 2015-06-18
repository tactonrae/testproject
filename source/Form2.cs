using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Form2 : Form
    {
        public static string name = "";
        public static string email = "";
        public static string address = "";
        public static string cityStZip = "";
        public static string theBill = "";
        public static string theQuan = "";
        public static string thePrice = "";
        public string isbn;
        public string author;
        public string title;
        public int quantity;
        public decimal price = 0.00M;


        public Form2()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        
      
    
        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 index = new Form1();
            index.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'books1DataSet.Cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.books1DataSet.Cart);
            for (int i = 0; i < this.books1DataSet.Cart.Rows.Count; ++i)
            {
                isbn = (string)this.cartDataGridView.Rows[i].Cells[0].Value;
                title = (string)this.cartDataGridView.Rows[i].Cells[1].Value;
                quantity = (int)this.cartDataGridView.Rows[i].Cells[2].Value;
                price = (decimal)this.cartDataGridView.Rows[i].Cells[3].Value;
                
                theBill += isbn + "       " + title + "\n";
                theQuan += quantity + "\n";
                thePrice += "$" + price + "\n";
                
            }
            


       
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            bill receipt = new bill();
            name = "Name: "+firstNameTextBox.Text+" "+lastNameTextBox.Text;
            email = "Email: "+eMailTextBox.Text;
            address = "Address: "+addressTextBox.Text;
            cityStZip = "City, State, Zip: "+cityTextBox.Text + " " + stateTextBox.Text + " " + zipCodeTextBox.Text;
            receipt.LblTotal.Text = this.testlbl.Text; 
            receipt.Show();
            this.Hide();
        }

        private void cartBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cartBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.books1DataSet);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
