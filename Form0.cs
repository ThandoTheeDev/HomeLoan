using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLoan
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            ManagerLogin Man = new ManagerLogin();
            Man.Show();
            this.Hide();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            Login Log = new Login();
            Log.Show();
            this.Hide();
        }
    }
}
