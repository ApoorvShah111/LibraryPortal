using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DitecLibrarySystem
{
    class DataLink
    {
        public static MySqlConnection libConnection = new MySqlConnection("Server=localhost;userid=root;password=;database=db_library;charSet=utf8;Convert Zero Datetime=True;");

        public static bool runCommand(String Command) //to use insert,update,delete commands
        {
            MySqlCommand MySqlCommand = new MySqlCommand(Command, libConnection);
            try
            {
                libConnection.Open();
                MySqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error While Command Execution !",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                libConnection.Close();
            }


           
        }



    }
}
