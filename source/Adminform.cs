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
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();

            try
            {
                this.booksTableAdapter.Fill(this.books1DataSet.Books);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.booksTableAdapter.Fill(form1.books1DataSet.Books);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.booksTableAdapter.Fill(this.books1DataSet.Books);
        }

        private void AddCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.booksTableAdapter.Fill(this.books1DataSet.Books);
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.books1DataSet);

        }

        private void Adminform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'books1DataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.books1DataSet.Books);

        }


        private void AddBookButton_Click(object sender, EventArgs e)
        {
            String a = AddISBNtextBox.Text;
            String b = AddTitletextBox.Text;
            String c = AddAuthortextBox.Text;
            decimal d = Convert.ToDecimal(AddPricetextBox.Text);
            int f = Convert.ToInt32(AddQTYtextBox.Text);



            this.booksTableAdapter.AddBooks(a, b, c, d, f);


            AddISBNtextBox.Text = " ";
            AddTitletextBox.Text = " ";
            AddAuthortextBox.Text = " ";
           AddPricetextBox.Text = " "; 
           AddQTYtextBox.Text = " ";

           this.booksTableAdapter.Fill(this.books1DataSet.Books);

        }

        

        private void booksListBox_DoubleClick(object sender, EventArgs e)
        {
            if (booksListBox.SelectedItem != null)
            {
                DataRowView drvItem = booksListBox.SelectedItem as DataRowView;

                if (drvItem != null)
                {
                    textBox1.Text = drvItem["ISBN"].ToString();
                    textBox4.Text = drvItem["title"].ToString();
                    textBox3.Text = drvItem["author"].ToString();
                    textBox2.Text = drvItem["price"].ToString();
                    textBox5.Text = drvItem["Quanity"].ToString();
                   
                }
                
                
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            
        {
            string a = textBox1.Text;
            decimal d = Convert.ToDecimal(textBox2.Text);
            int f = Convert.ToInt32(textBox5.Text);


           
            this.booksTableAdapter.UpdateBooks(f, d, a);
            this.booksTableAdapter.Fill(this.books1DataSet.Books);
            

        }
        }

       
        
    }
}
