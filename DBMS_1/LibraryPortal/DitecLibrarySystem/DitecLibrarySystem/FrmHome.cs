using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DitecLibrarySystem
{
    public partial class FrmHome : Form
    {
        DataView dv ;
       public bool adminUser;
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            FrmBook b = new FrmBook();
            b.ShowDialog();

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            //loadDatagridBook();
            if (adminUser) 
            { 
                btnBook.Enabled = true;
                btnIssue.Enabled = true;
                btnMember.Enabled = true; 
                btnReturn.Enabled = true; 
            }
        }

        private void loadDatagridBook()
        {
            try
            {
                //codes for loading data
                 MySqlCommand resultscommand = null;
                MySqlDataAdapter adp = new MySqlDataAdapter();
                DataTable resultstable = new DataTable();
                resultscommand = new  MySqlCommand("SELECT * from tbl_book;", DataLink.libConnection);
                adp.SelectCommand = resultscommand;
                adp.Fill(resultstable);
                dataGridBook.DataSource = resultstable;
                dv = resultstable.DefaultView;



                //codes for add items for combobox by code

                cmboSearchBy.Items.Clear();
                cmboSearchBy.Items.Add("BookName");
                cmboSearchBy.Items.Add("Author");
                cmboSearchBy.Items.Add("Category");
                cmboSearchBy.Text = "BookName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading data");            
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                dv.RowFilter = string.Format(cmboSearchBy.Text +" LIKE '%{0}%'", txtBookName.Text);
                dataGridBook.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filter data");
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            FrmMember m = new FrmMember();
            m.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDatagridBook();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            FrmIssueBooks ib = new FrmIssueBooks();
            ib.ShowDialog();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmReturnBook rb = new FrmReturnBook();
            rb.ShowDialog();
                      
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
