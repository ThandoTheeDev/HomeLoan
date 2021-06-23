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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void btnMAR_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void btnARM_Click(object sender, EventArgs e)
        {
            ManageReg Reg = new ManageReg();
            Reg.Show();
            this.Hide();
        }

        private void btnMAL_Click(object sender, EventArgs e)
        {
            string connectionString;


            connectionString = "Data Source=THANDO;Initial Catalog=Employee_HomeLoan_System;Integrated Security=True";


            if (txtusername.Text == "")
            {
                MessageBox.Show("Please Enter Username", "Error");
                txtusername.Focus();
                return;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Error");
                txtpassword.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(connectionString);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT Managers_UserName,Managers_Password FROM Managers WHERE Managers_UserName = @Managers_UserName AND Managers_Password = @Managers_Password", myConnection);

                SqlParameter uName = new SqlParameter("@Managers_UserName", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@Managers_Password", SqlDbType.VarChar);

                uName.Value = txtusername.Text;
                uPassword.Value = txtpassword.Text;

                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    MessageBox.Show("You have logged in successfully " + txtusername.Text);
                    //Hide the login form
                    this.Hide();
                    Form1 fr = new Form1();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied");

                    txtusername.Clear();
                    txtpassword.Clear();
                    txtusername.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
