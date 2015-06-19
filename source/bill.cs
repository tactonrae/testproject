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
       
        private System.Drawing.Printing.PrintDocument docToPrint =
        new System.Drawing.Printing.PrintDocument();

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

        private void printBtn_Click(object sender, EventArgs e)
        {
            printDialog1.AllowSomePages = false;

         
            printDialog1.ShowHelp = false;

            
            printDialog1.Document = docToPrint;

            DialogResult result = printDialog1.ShowDialog();

            // If the result is OK then print the document. 
            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }

        private void document_PrintPage(object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
        {

            
            string text = "Tony's BookStore: ";
            System.Drawing.Font printFont = new System.Drawing.Font
                ("Arial", 35, System.Drawing.FontStyle.Bold);

            
            e.Graphics.DrawString(text, printFont,
                System.Drawing.Brushes.BurlyWood, 10, 10);
        }
    
    
    }


}
