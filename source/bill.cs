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
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Form1 index = new Form1();
            index.Show();
            index.cartTableAdapter.DeleteCartContents();
            index.cartTableAdapter.Fill(index.books1DataSet.Cart);
            Form2.theBill = "";
            Form2.theQuan = "";
            Form2.thePrice = "";
            
            this.Hide();
        }

        private void bill_Load(object sender, EventArgs e)
        {
            lbBill.Text = Form2.theBill + "" + "\n";
            lbQuan.Text = Form2.theQuan + "" + "\n";
            lbPrice.Text = Form2.thePrice +"" + "\n";
            lbAddress.Text= Form2.name+"\n"+Form2.email+"\n"+Form2.address+"\n"+Form2.cityStZip;
            Form2.theBill = "";
        }
    }
}
