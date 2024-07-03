using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Company
{
    class DbConnection
    {
        public SqlConnection cnn { get; set; }
        public DbConnection()
        {
            try
            {
                cnn = new SqlConnection("Data Source =DESKTOP-4AH15UV; Initial Catalog = Programming-Company; Integrated Security = True");
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Disconnect()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
    }
}
