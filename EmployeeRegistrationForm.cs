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
    public partial class EmployeeRegistrationForm : Form
    {
        public EmployeeRegistrationForm()
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
                
                string str = "insert into Employee(Employee_Branch, Employee_Department, Employee_DOB, Employee_Name, Employee_Password, Employee_Surname, Employee_Title, Employee_UserName) " +
                "values ('" + txtB.Text + "', '" + txtD.Text + "', " +
                "'" + txtDOB.Text + "', '" + txtN.Text + "', '" + txtP.Text + "', " +
                "'" + txtS.Text + "', '" + txtT.Text + "', '" + txtUN.Text + "')";
                
                SqlCommand cmd = new SqlCommand(str, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful!");
                ClearData();
                
                Login Log = new Login();
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

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
