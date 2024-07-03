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
    
    public partial class FPerson : Form
    {
        private frmMain fmain {get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public FPerson(frmMain f,string Textperson)
        {
            InitializeComponent();
            fmain = f;
            btnPerson.Text = Textperson;
        }

        private void AddPerson()
        {
            DbConnection c = new DbConnection();
            DialogResult result=MessageBox.Show("Are you sure ?","", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO PERSON(Name,rank) values(@name,hd)";
                cmd.Connection = c.cnn;
                cmd.Parameters.AddWithValue("@name", textBoxPerson.Text);
                    cmd.ExecuteNonQuery();
                textBoxPerson.Text = string.Empty;
                fmain.Refresh_Grid("personName");
            }
            c.Disconnect();


        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            if (btnPerson.Text == "add")
                AddPerson();
            if (btnPerson.Text == "Update")
                updetPerson();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          
           this.Close();
        }
        private void frmPersonLoad(object s,EventArgs e)
        {
            textBoxPerson.Text = name;
        }
        private void updetPerson()
        {
            DbConnection c = new DbConnection();
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE person SET Name =@name where ID=" + id.ToString();
                cmd.Connection = c.cnn;
                cmd.Parameters.AddWithValue("@name", textBoxPerson.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("the updation was done successfuly...");
                fmain.Refresh_Grid("PersonName");
                this.Close();
            }
            c.Disconnect();
        }
        
    }
}
