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
    public partial class Form1 : Form
    {

        //List<LifeExpenses> LE = new List<LifeExpenses>();


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            //
            double EMTD, GROC, WAL, TCS, CELL_TEL, OE;
            double TotalExpenses;
            //
            
            EMTD = double.Parse(txtTD.Text);
            GROC = double.Parse(txtGroc.Text);
            WAL = double.Parse(txtWAL.Text);
            TCS = double.Parse(txtTC.Text);
            CELL_TEL = double.Parse(txtCAT.Text);
            OE = double.Parse(txtOE.Text);
            //
            TotalExpenses = EMTD + GROC + WAL + TCS + CELL_TEL + OE;
            //
            MessageBox.Show("Expenses for this month amount to: " + TotalExpenses);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rdbYesH.Checked == true)
            {
                grbHome.Enabled = true;
                grbRent.Enabled = false;
            }
            else if (rdbNoH.Checked == true)
            {
                grbHome.Enabled = false;
                grbRent.Enabled = true;
            }
        }

        private void btnUpdateV_Click(object sender, EventArgs e)
        {
            if (rdbYesV.Checked == true)
            {
                grbV.Enabled = true;
            }
            else if (rdbNoV.Checked == true)
            {
                grbV.Enabled = false;
            }
        }

        private void btnCalcHLA_Click(object sender, EventArgs e)
        {
            //
            double PurchasePriceOfProperty, H_TotalDeposit, H_InterestRate, Number_Of_Months_To_Repay;
            double PH, IH, AH, NH;
            //
            PurchasePriceOfProperty = double.Parse(txtPPOP.Text);
            H_TotalDeposit = double.Parse(txtH.Text);
            H_InterestRate = double.Parse(txtIR.Text);
            Number_Of_Months_To_Repay = double.Parse(txtRP.Text);
            //
            PH = PurchasePriceOfProperty - H_TotalDeposit;
            IH = H_InterestRate / 100;
            NH = Number_Of_Months_To_Repay;
            //
            AH = PH * (1 + IH) / NH;

            if (AH < 1/3*100)
            {
                MessageBox.Show("Chance Loan May Not be Approved");
            }
            else
            {
                MessageBox.Show("Loan May Be Approved \nMonthly Home Loan Repayment is R:" + AH);
            }
                    
        }

        private void btnVA_Click(object sender, EventArgs e)
        {
            string ModelAndMake;
            double PurchasePrice, V_TotalDeposit, V_InterestRate, EstimatedInsurancePremuim, MonthlyRepayments;
            double PV, IV, AV, NV;
            //
            ModelAndMake = txtMM.Text;
            PurchasePrice = double.Parse(txtPP.Text);
            V_TotalDeposit = double.Parse(txtV.Text);
            V_InterestRate = double.Parse(txtIRV.Text);
            MonthlyRepayments = double.Parse(txtVMR.Text);
            EstimatedInsurancePremuim = double.Parse(txtEIP.Text);
            //
            PV = ((PurchasePrice + EstimatedInsurancePremuim) - V_TotalDeposit);
            IV = V_InterestRate / 100;
            NV = MonthlyRepayments;
            //
            AV = PV * (1 + IV) / NV;

            MessageBox.Show("Car Model And Make: " +ModelAndMake+ "\nMonthly Car Repayment is R:" + AV);
        }

        private void btnAMM_Click(object sender, EventArgs e)
        {
            double AvailableMonthlyFunds;
            //
            double GMI, EMTD, GROC, WAL, TCS, CELL_TEL, OE;
            double TotalExpenses;
            //
            GMI = double.Parse(txtGMI.Text);
            EMTD = double.Parse(txtTD.Text);
            GROC = double.Parse(txtGroc.Text);
            WAL = double.Parse(txtWAL.Text);
            TCS = double.Parse(txtTC.Text);
            CELL_TEL = double.Parse(txtCAT.Text);
            OE = double.Parse(txtOE.Text);
            //
            TotalExpenses = EMTD + GROC + WAL + TCS + CELL_TEL + OE;

            //
            double PurchasePriceOfProperty, H_TotalDeposit, H_InterestRate, Number_Of_Months_To_Repay;
            double PH, IH, AH, NH;
            //
            PurchasePriceOfProperty = double.Parse(txtPPOP.Text);
            H_TotalDeposit = double.Parse(txtH.Text);
            H_InterestRate = double.Parse(txtIR.Text);
            Number_Of_Months_To_Repay = double.Parse(txtRP.Text);
            //
            PH = PurchasePriceOfProperty - H_TotalDeposit;
            IH = H_InterestRate / 100;
            NH = Number_Of_Months_To_Repay;
            //
            AH = PH * (1 + IH) / NH;


            //
            string ModelAndMake;
            double PurchasePrice, V_TotalDeposit, V_InterestRate, EstimatedInsurancePremuim, MonthlyRepayments;
            double PV, IV, AV, NV;
            //
            ModelAndMake = txtMM.Text;
            PurchasePrice = double.Parse(txtPP.Text);
            V_TotalDeposit = double.Parse(txtV.Text);
            V_InterestRate = double.Parse(txtIRV.Text);
            MonthlyRepayments = double.Parse(txtVMR.Text);
            EstimatedInsurancePremuim = double.Parse(txtEIP.Text);
            //
            PV = ((PurchasePrice + EstimatedInsurancePremuim) - V_TotalDeposit);
            IV = V_InterestRate / 100;
            NV = MonthlyRepayments;
            //
            AV = PV * (1 + IV) / NV;

            //

            AvailableMonthlyFunds = (GMI - (AH + AV));
            MessageBox.Show("Available funds for the month:R " + AvailableMonthlyFunds);



        }
    }
}
