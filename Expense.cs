using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeLoan
{
    public abstract class Expense 
    {
        //
        protected double _GrossMonthlyIncome;
        protected double _EstimatedMonthlyTaxDeductions;
        protected double _Groceries;
        protected double _WaterAndLights;
        protected double _Cellphone_Telephone;
        protected double _OtherExpenses;
        //
        public abstract double Estimated_monthly_expenditures(double GrossMonthlyIncome, double EstimatedMonthlyTaxDeductions, double Groceries, double WaterAndLights, double Cellphone_Telephone, double OtherExpenses);
        

    }
}
