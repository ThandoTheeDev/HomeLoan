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

namespace HomeLoan
{
    public partial class ManageReg : Form
    {
        public ManageReg()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            txtB.Clear();
            txtD.Clear();
            txtDOB.Clear();
            txtN.Clear();
            txtP.Clear();
            txtS.Clear();
            txtT.Clear();
            txtUN.Clear();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = "Data Source=THANDO;Initial Catalog=Employee_HomeLoan_System;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();

                string str = "insert into Managers(Managers_Branch, Managers_Department, Managers_DOB, Managers_Name, Managers_Password, Managers_Surname, Managers_Title, Managers_UserName) " +
                "values ('" + txtB.Text + "', '" + txtD.Text + "', " +
                "'" + txtDOB.Text + "', '" + txtN.Text + "', '" + txtP.Text + "', " +
                "'" + txtS.Text + "', '" + txtT.Text + "', '" + txtUN.Text + "')";

                SqlCommand cmd = new SqlCommand(str, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful!");
                ClearData();

                ManagerLogin Log = new ManagerLogin();
                Log.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Registration Unsuccessful");
                ClearData();
            }
            finally
            {
                cnn.Close();
            }

        }
        public void ClearData()
        {
            txtUN.Text = "";
            txtT.Text = "";
            txtS.Text = "";
            txtP.Text = "";
            txtN.Text = "";
            txtDOB.Text = "";
            txtD.Text = "";
            txtB.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
