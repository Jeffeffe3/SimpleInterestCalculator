using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace JashQ4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int intPrice;
            double dblTotalCost;
            double dblRate;
            int iYear;


            
            intPrice = Convert.ToInt32( txtInitial.Text);
            System.Console.WriteLine(intPrice.ToString());

            if (txtRate.Text == "" && txtYears.Text == "")
            {
                dblTotalCost = InterestSet(intPrice); ;
                
            }
            else 
            {
                iYear = Convert.ToInt32(txtYears.Text);
                System.Console.WriteLine(iYear.ToString());
                dblRate = Convert.ToDouble(txtRate.Text);
                System.Console.WriteLine(dblRate.ToString()); 
                dblTotalCost = InterestRecieved(intPrice, iYear, dblRate);
                
            };
            
            txtOutput.Text = Convert.ToString(dblTotalCost);

        }

        public double ErrorCheck(string text) 
        {
            return 0; 
        }
        public double InterestSet(int price)
        {
            double interest, dblPrincipal;

            dblPrincipal = (Convert.ToDouble(price));

            interest = (dblPrincipal * (1.0 + (0.15 / 5)));

            return interest;
        }

        public double exchangeRate(double Rate) 
        {
            double dblRate = Rate / 100;
            System.Console.WriteLine(dblRate.ToString());
            return dblRate;
        }

        public double InterestRecieved(int price,int year, double Rate) 
        {
            double interest,dblPrincipal,dblYear,dblRate;
            
            dblRate = Rate;
            dblYear = Convert.ToDouble(year);

            dblPrincipal = (Convert.ToDouble(price));
            
            interest = (dblPrincipal*(1.0+((dblRate/100.0)/dblYear)));
                        
            return interest;
        }
    }
}