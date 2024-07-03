using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Company
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Exit_Menu_Item_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlDataAdapter da;
        public void Refresh_Grid(string TName)
        {
            DataSet ds = new DataSet();
            da.Fill(ds, TName);
            dtgView.DataBindings.Clear();
            dtgView.DataBindings.Add("datasource", ds, TName);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DbConnection C = new DbConnection();
            da = new SqlDataAdapter("SELECT *  FROM Person", C.cnn);
            Refresh_Grid("PersonName");

        }
        private void txtSearchPerson_TextBoxTextChanged(object sender, EventArgs e)
        {
            DbConnection c = new DbConnection();
            SqlCommand cmd = new SqlCommand("Pperson", c.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;
            param = cmd.Parameters.Add("@p_name", SqlDbType.NVarChar, 200);
            param.Value = txtSearchPerson.TextBoxText;
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            Refresh_Grid("PersonName");
            c.Disconnect();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            FPerson fp = new FPerson(this, "add");
            fp.ShowDialog();
        }
        private int Find_person_ID(string id, string rank, string name, string birth)
        {
            DbConnection c = new DbConnection();
            SqlCommand cmd = new SqlCommand("RetrievePersonID", c.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;
            param = cmd.Parameters.Add("@p_id", SqlDbType.VarChar,500);
            param.Value = id;
            param = cmd.Parameters.Add("@p_name", SqlDbType.VarChar, 500);
            param.Value = rank;
            param = cmd.Parameters.Add("@p_rank", SqlDbType.VarChar, 500);
            param.Value = name;
            param = cmd.Parameters.Add("@p_birth", SqlDbType.VarChar, 500);
            param.Value = birth;
            param = cmd.Parameters.Add("@p_resultID", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int ret_id = Convert.ToInt32(cmd.Parameters["@p_id"].Value.ToString());
            return Int32.Parse(cmd.Parameters["@p_id"].Value.ToString());
        }


        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            if (dtgView.SelectedRows.Count > 0)
            {
                string personName = dtgView.SelectedRows[0].Cells[1].Value.ToString();
                string personRANK = dtgView.SelectedRows[0].Cells[2].Value.ToString();
                string personBIRTH= dtgView.SelectedRows[0].Cells[3].Value.ToString();
                string personid= dtgView.SelectedRows[0].Cells[0].Value.ToString();
                
                

                FPerson fp = new FPerson(this, "Update");
                fp.id = Find_person_ID(personid, personName, personRANK, personBIRTH);
                fp.name = personName;
                fp.ShowDialog();
            }
            else
            {
                MessageBox.Show("please Select a row grid to updete.....");
            }
        }

        private void ribbonButton1_Click(object sender, EventArgs e)//delete
        {
            if (dtgView.SelectedRows.Count > 0)
            {
                string personName = dtgView.SelectedRows[0].Cells[1].Value.ToString();
                string personRANK = dtgView.SelectedRows[0].Cells[2].Value.ToString();
                string personBIRTH = dtgView.SelectedRows[0].Cells[3].Value.ToString();
                string personid = dtgView.SelectedRows[0].Cells[0].Value.ToString();
                DbConnection c = new DbConnection();
                DialogResult result = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM Person WHERE ID = " + Find_person_ID(personid, personName, personRANK, personBIRTH).ToString();
                    cmd.Connection = c.cnn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("the deletion was done successfully....");
                    Refresh_Grid("PersonName");
                }
                c.Disconnect();
            }
            else
                MessageBox.Show("please select a row of the grid to delete..");
        }


        

        private void txtSearchPerson_TextBoxTextChanged_1(object sender, EventArgs e)
        {
            DbConnection c = new DbConnection();
            SqlCommand cmd = new SqlCommand("search_person", c.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;
            param = cmd.Parameters.Add("@p_name", SqlDbType.VarChar, 200);
            param.Value = txtSearchPerson.TextBoxText;
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            Refresh_Grid("PersonName");
            c.Disconnect();
        }
    }

}
