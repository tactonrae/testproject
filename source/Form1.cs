using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lesson2
{
    public partial class Form1 : Form
    {

        Form2 index = new Form2();
        int j = 1;
        books mybooks = new books();
        bill bill = new bill();
        public Form1()
       
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }
        
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        
        }
        
        
        public void addToCart(){

             for (int i = 0; i < booksDataGridView.SelectedRows.Count; i++)
             {

                 string ISBN = (string)booksDataGridView.SelectedRows[i].Cells[0].Value;
                 string title = (string)booksDataGridView.SelectedRows[i].Cells[1].Value;
                 string author = (string)booksDataGridView.SelectedRows[i].Cells[2].Value;
                 Decimal price = (Decimal)booksDataGridView.SelectedRows[i].Cells[3].Value;





                 if (ISBN == this.cartTableAdapter.SELECTISBN(ISBN))
                 {

                     j++;

                     if (j != this.cartTableAdapter.SELECTQTY(ISBN))
                     {
                         j = this.cartTableAdapter.SELECTQTY(ISBN).Value + 1;
                     }


                     this.cartTableAdapter.UpdateQTY(j, ISBN);

                 }
                 else
                 {
                     j = 1;

                     this.cartTableAdapter.InsertToDB(ISBN, title, j, price);
                 }

                 this.cartTableAdapter.Fill(this.books1DataSet.Cart);
             }
            }
         
        public void removeFromCart()
         {
             for (int i = 0; i < cartDataGridView.SelectedRows.Count; i++)
             {
                 int p = 1;
                 int k = cartDataGridView.CurrentRow.Index;
                 string ISBN = (string)cartDataGridView.SelectedRows[i].Cells[0].Value;

                 if (p < this.cartTableAdapter.SELECTQTY(ISBN))
                 {
                     j = this.cartTableAdapter.SELECTQTY(ISBN).Value - 1;

                     this.cartTableAdapter.UpdateQTY(j, ISBN);


                     
                 }
                 else
                 {

                     this.cartTableAdapter.RemoveSelection(ISBN);
                 }


                 this.cartTableAdapter.Fill(this.books1DataSet.Cart);

             }
         }
        public void setPrice()
        {
            decimal total = 0.00M;

            for (int k = 0; k < this.cartDataGridView.Rows.Count; k++)
            {
                int y = (int)this.cartDataGridView.Rows[k].Cells[2].Value;

                total += y * (decimal)this.cartDataGridView.Rows[k].Cells[3].Value;
            }

           
            index.testlbl.Text = total.ToString("c");
            
            
            total = 0.00M;
        }
       




        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'books1DataSet.Cart' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.books1DataSet.Books);
            // TODO: This line of code loads data into the 'books1DataSet.Cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.books1DataSet.Cart);
            //this.cartTableAdapter.DeleteCartContents();

        }
      
        
        private void subButton_Click(object sender, EventArgs e)
        {
            index.Show();
            this.Hide();
            
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Passwordfrm index = new Passwordfrm();
            index.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string test = searchBox.Text;
            {

                this.booksTableAdapter.SearchByAll(this.books1DataSet.Books, "%" + test + "%", "%" + test + "%", "%" + test + "%");
            }


        }


        private void addItemButton_Click(object sender, EventArgs e)
        {

            Form2 index = new Form2();
            this.addToCart();
            this.setPrice();
               


        }


        private void RemoveitemButton_Click(object sender, EventArgs e)
        {

            
            this.removeFromCart();
            this.setPrice();    
        }

        private void subButton_Click_1(object sender, EventArgs e)
        {
          
                index.Show();
                this.Hide();

        }

        


    }
}