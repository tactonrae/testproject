namespace Lesson2
{
    partial class Adminform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateISBNLbl = new System.Windows.Forms.Label();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.booksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.books1DataSet = new Lesson2.books1DataSet();
            this.CnclButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.QtyLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.AuthorLbl = new System.Windows.Forms.Label();
            this.ISBNlbl = new System.Windows.Forms.Label();
            this.AddCancelButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.AddQTYtextBox = new System.Windows.Forms.TextBox();
            this.AddTitletextBox = new System.Windows.Forms.TextBox();
            this.AddAuthortextBox = new System.Windows.Forms.TextBox();
            this.AddPricetextBox = new System.Windows.Forms.TextBox();
            this.AddISBNtextBox = new System.Windows.Forms.TextBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Lesson2.books1DataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new Lesson2.books1DataSetTableAdapters.TableAdapterManager();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.books1DataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.UpdateISBNLbl);
            this.tabPage1.Controls.Add(this.booksListBox);
            this.tabPage1.Controls.Add(this.CnclButton);
            this.tabPage1.Controls.Add(this.UpdateButton);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(354, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Update Book";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quanity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Title";
            // 
            // UpdateISBNLbl
            // 
            this.UpdateISBNLbl.AutoSize = true;
            this.UpdateISBNLbl.Location = new System.Drawing.Point(3, 182);
            this.UpdateISBNLbl.Name = "UpdateISBNLbl";
            this.UpdateISBNLbl.Size = new System.Drawing.Size(32, 13);
            this.UpdateISBNLbl.TabIndex = 16;
            this.UpdateISBNLbl.Text = "ISBN";
            // 
            // booksListBox
            // 
            this.booksListBox.DataSource = this.booksBindingSource2;
            this.booksListBox.DisplayMember = "title";
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.Location = new System.Drawing.Point(0, 3);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(340, 173);
            this.booksListBox.TabIndex = 13;
            this.booksListBox.ValueMember = "ISBN";
            this.booksListBox.DoubleClick += new System.EventHandler(this.booksListBox_DoubleClick);
            // 
            // booksBindingSource2
            // 
            this.booksBindingSource2.DataMember = "Books";
            this.booksBindingSource2.DataSource = this.books1DataSet;
            // 
            // books1DataSet
            // 
            this.books1DataSet.DataSetName = "books1DataSet";
            this.books1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CnclButton
            // 
            this.CnclButton.Location = new System.Drawing.Point(112, 301);
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(75, 23);
            this.CnclButton.TabIndex = 13;
            this.CnclButton.Text = "Cancel";
            this.CnclButton.UseVisualStyleBackColor = true;
            this.CnclButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(6, 301);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 275);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(112, 198);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(6, 237);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.QtyLbl);
            this.tabPage2.Controls.Add(this.PriceLbl);
            this.tabPage2.Controls.Add(this.TitleLbl);
            this.tabPage2.Controls.Add(this.AuthorLbl);
            this.tabPage2.Controls.Add(this.ISBNlbl);
            this.tabPage2.Controls.Add(this.AddCancelButton);
            this.tabPage2.Controls.Add(this.AddBookButton);
            this.tabPage2.Controls.Add(this.AddQTYtextBox);
            this.tabPage2.Controls.Add(this.AddTitletextBox);
            this.tabPage2.Controls.Add(this.AddAuthortextBox);
            this.tabPage2.Controls.Add(this.AddPricetextBox);
            this.tabPage2.Controls.Add(this.AddISBNtextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(354, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Book";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // QtyLbl
            // 
            this.QtyLbl.AutoSize = true;
            this.QtyLbl.Location = new System.Drawing.Point(3, 126);
            this.QtyLbl.Name = "QtyLbl";
            this.QtyLbl.Size = new System.Drawing.Size(43, 13);
            this.QtyLbl.TabIndex = 19;
            this.QtyLbl.Text = "Quanity";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(109, 71);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(31, 13);
            this.PriceLbl.TabIndex = 18;
            this.PriceLbl.Text = "Price";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Location = new System.Drawing.Point(109, 32);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(27, 13);
            this.TitleLbl.TabIndex = 17;
            this.TitleLbl.Text = "Title";
            // 
            // AuthorLbl
            // 
            this.AuthorLbl.AutoSize = true;
            this.AuthorLbl.Location = new System.Drawing.Point(3, 71);
            this.AuthorLbl.Name = "AuthorLbl";
            this.AuthorLbl.Size = new System.Drawing.Size(38, 13);
            this.AuthorLbl.TabIndex = 16;
            this.AuthorLbl.Text = "Author";
            // 
            // ISBNlbl
            // 
            this.ISBNlbl.AutoSize = true;
            this.ISBNlbl.Location = new System.Drawing.Point(3, 29);
            this.ISBNlbl.Name = "ISBNlbl";
            this.ISBNlbl.Size = new System.Drawing.Size(32, 13);
            this.ISBNlbl.TabIndex = 15;
            this.ISBNlbl.Text = "ISBN";
            // 
            // AddCancelButton
            // 
            this.AddCancelButton.Location = new System.Drawing.Point(137, 181);
            this.AddCancelButton.Name = "AddCancelButton";
            this.AddCancelButton.Size = new System.Drawing.Size(75, 23);
            this.AddCancelButton.TabIndex = 13;
            this.AddCancelButton.Text = "Cancel";
            this.AddCancelButton.UseVisualStyleBackColor = true;
            this.AddCancelButton.Click += new System.EventHandler(this.AddCancelButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(31, 181);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(75, 23);
            this.AddBookButton.TabIndex = 12;
            this.AddBookButton.Text = "Add";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // AddQTYtextBox
            // 
            this.AddQTYtextBox.Location = new System.Drawing.Point(6, 142);
            this.AddQTYtextBox.Name = "AddQTYtextBox";
            this.AddQTYtextBox.Size = new System.Drawing.Size(100, 20);
            this.AddQTYtextBox.TabIndex = 14;
            // 
            // AddTitletextBox
            // 
            this.AddTitletextBox.Location = new System.Drawing.Point(112, 48);
            this.AddTitletextBox.Name = "AddTitletextBox";
            this.AddTitletextBox.Size = new System.Drawing.Size(100, 20);
            this.AddTitletextBox.TabIndex = 9;
            // 
            // AddAuthortextBox
            // 
            this.AddAuthortextBox.Location = new System.Drawing.Point(6, 94);
            this.AddAuthortextBox.Name = "AddAuthortextBox";
            this.AddAuthortextBox.Size = new System.Drawing.Size(100, 20);
            this.AddAuthortextBox.TabIndex = 8;
            // 
            // AddPricetextBox
            // 
            this.AddPricetextBox.Location = new System.Drawing.Point(112, 94);
            this.AddPricetextBox.Name = "AddPricetextBox";
            this.AddPricetextBox.Size = new System.Drawing.Size(100, 20);
            this.AddPricetextBox.TabIndex = 7;
            // 
            // AddISBNtextBox
            // 
            this.AddISBNtextBox.Location = new System.Drawing.Point(6, 48);
            this.AddISBNtextBox.Name = "AddISBNtextBox";
            this.AddISBNtextBox.Size = new System.Drawing.Size(100, 20);
            this.AddISBNtextBox.TabIndex = 6;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.books1DataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.CartTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lesson2.books1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.books1DataSet;
            // 
            // Adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "Adminform";
            this.Text = "Adminform";
            this.Load += new System.EventHandler(this.Adminform_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.books1DataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox AddQTYtextBox;
        private System.Windows.Forms.TextBox AddTitletextBox;
        private System.Windows.Forms.TextBox AddAuthortextBox;
        private System.Windows.Forms.TextBox AddPricetextBox;
        private System.Windows.Forms.TextBox AddISBNtextBox;
        private System.Windows.Forms.Button CnclButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddCancelButton;
        private System.Windows.Forms.Button AddBookButton;
        private books1DataSet books1DataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private books1DataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private books1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.BindingSource booksBindingSource2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UpdateISBNLbl;
        private System.Windows.Forms.Label QtyLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label AuthorLbl;
        private System.Windows.Forms.Label ISBNlbl;
    }
}