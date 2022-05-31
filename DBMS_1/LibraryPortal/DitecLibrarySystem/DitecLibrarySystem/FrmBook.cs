using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace DitecLibrarySystem
{
    public partial class FrmBook : Form
    {


        public FrmBook()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sqlCommand = "select * from tbl_book where BookID = '"+txtIsbnNumber.Text+"';";
            MySqlCommand command = new MySqlCommand(sqlCommand, DataLink.libConnection);
            try
            {
                DataLink.libConnection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txtBookName.Text = reader["BookName"].ToString();
                        txtBookPrice.Text = reader["BookPrice"].ToString();
                        txtAuthor.Text = reader["Author"].ToString();
                        cmbCategory.Text = reader["Category"].ToString();
                        MessageBox.Show(reader["Status"].ToString(),"Book Status");                        
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error While Command Execution !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DataLink.libConnection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
   bool result = DataLink.runCommand("INSERT INTO tbl_book ( BookID, BookName, BookPrice, Author, Category, Status ) values ('"+ txtIsbnNumber.Text+"','"+txtBookName.Text+"','"+txtBookPrice.Text+"','"+txtAuthor.Text+"','"+cmbCategory.Text+"','Available');");
          if (result)
          {
              MessageBox.Show("New Book Added successfully !", "Ditec Library System ", MessageBoxButtons.OK, MessageBoxIcon.Information); 
          }  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool result = DataLink.runCommand("DELETE FROM tbl_book where BookID = '"+txtIsbnNumber.Text+"';");


            if (result)
            {
                MessageBox.Show("Book deleted successfully !", "Ditec Library System ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
         bool result = DataLink.runCommand( "UPDATE tbl_book SET tbl_book.BookName = '"+txtBookName.Text+"', tbl_book.BookPrice = "+txtBookPrice.Text+", tbl_book.Author =' "+txtAuthor.Text+"', tbl_book.Category = '"+cmbCategory.Text+"'  WHERE BookID = '"+ txtIsbnNumber.Text+"';");


            if (result)
            {
                MessageBox.Show("Book updated successfully !", "Ditec Library System ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
           
        }

        private void FrmBook_Load(object sender, EventArgs e)
        {

        }

        private void txtIsbnNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
