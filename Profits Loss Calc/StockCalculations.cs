using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profits_Loss_Calc
{
    class StockCalculations
    {
        //declare varilables 
        private double numSharesBought, priceBought, priceSold;
        // create constructor
        public StockCalculations(double num, double bought, double sold)
        {
            //assign values to variables based on input from program class
            priceBought = bought;
            priceSold = sold;
            numSharesBought = num;
        }
        // calculate price paid
        public double PricePaid()
        {
            double totalPaid;
            totalPaid = numSharesBought * priceBought;
            return totalPaid;
        }
        // calculate price sold
        public double TotalSold()
        {
            double totalSold;
            totalSold = numSharesBought * priceSold;
            return totalSold;
        }
        //calculate profits/losses
        public double Difference(double tSold, double tPaid)
        {
            double totalProfLoss;
            totalProfLoss = tSold - tPaid;
            return totalProfLoss;
        }

    }
}
