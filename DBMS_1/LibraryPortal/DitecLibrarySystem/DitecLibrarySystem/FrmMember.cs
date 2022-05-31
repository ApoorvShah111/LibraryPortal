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
    public partial class FrmMember : Form
    {
        string _gender, _lifeLong;
        public FrmMember()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = DataLink.runCommand("insert into tbl_member (NIC,MemberName,Phone,Gender,Lifelong) values ('" + txtMemberId.Text + "','" + txtName.Text + "','"+txtPhone.Text+"','"+_gender+"','"+_lifeLong+"');");
            if (result)
            {
                MessageBox.Show("New Book Added successfully !", "Ditec Library System ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadDatagridMember();
            clearAll_UI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool result = DataLink.runCommand("DELETE FROM tbl_member where NIC = '" +txtMemberId.Text + "';");


            if (result)
            {
                MessageBox.Show("Book deleted successfully !", "Ditec Library System ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadDatagridMember();
            clearAll_UI();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool result = DataLink.runCommand("UPDATE tbl_member SET MemberName = '" + txtName.Text + "',Phone='" + txtPhone.Text + "',Gender = '" + _gender + "',Lifelong = '" + _lifeLong + "'  WHERE NIC ='" + txtMemberId.Text + "';");


            if (result)
            {
                MessageBox.Show("Updated successfully !", "Ditec Library System ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadDatagridMember();
            clearAll_UI();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT * from tbl_member  where NIC = '" + txtMemberId.Text + "';";
            MySqlCommand command = new MySqlCommand(sqlCommand, DataLink.libConnection);
            try
            {
                DataLink.libConnection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txtName.Text = reader["MemberName"].ToString();
                        txtPhone.Text = reader["Phone"].ToString();
                        _gender = reader["Gender"].ToString();
                        _lifeLong = reader["Lifelong"].ToString();


                        if (_gender == "male")
                        {
                            rbtnMale.Checked = true;
                        }
                        else
                        {
                            rbtnFemale.Checked = true;
                        }


                        if (_lifeLong == "yes")
                        {
                            chkLifeLong.Checked = true;
                        }
                        else
                        {
                            chkLifeLong.Checked = false;
                        }



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


 

        private void FrmMember_Load(object sender, EventArgs e)
        {
            loadDatagridMember();
        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMale.Checked == true)
            {
                _gender = "male";
            }

        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFemale.Checked == true)
            {
                _gender = "female";
            }

        }

        private void chkLifeLong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLifeLong.Checked == true)
            {
                _lifeLong = "yes";
            }
            else
            {
                _lifeLong = "no";
            }

        }

        // To add data to grid view 
        public void loadDatagridMember()
        {
            try
            {

                MySqlCommand resultscommand = null;
                MySqlDataAdapter adp = new MySqlDataAdapter();
                DataTable resultstable = new DataTable();
                resultscommand = new MySqlCommand("SELECT * from tbl_member;", DataLink.libConnection);
                adp.SelectCommand = resultscommand;
                adp.Fill(resultstable);
                dataGridMember.DataSource = resultstable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Loading Memebr Details");
                
            }

     
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll_UI();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void clearAll_UI()
    {
        txtMemberId.Clear();
        txtName.Clear();
        txtPhone.Clear();
        chkLifeLong.Checked = false;
        rbtnFemale.Checked = false;
        rbtnMale.Checked = false;

    }




    }
}
