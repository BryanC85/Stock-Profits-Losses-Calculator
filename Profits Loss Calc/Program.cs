using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profits_Loss_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            //display heading and instructions
            Heading();
            DisplayInstructions();

            //declare variables
            string stockName;
            double sharesBought, pricePaid, priceSold; // input
            double totalPaid, totalSold, difference; // output

            //assign input variables
            stockName = getStockName();
            sharesBought = getSharesBought();
            pricePaid = getPriceBought();
            priceSold = getPriceSold();

            //assign variable as constructor StockCalculations
            StockCalculations aStockCalculation = new StockCalculations(sharesBought, pricePaid, priceSold);
            //get the calculations for total paid and total sold
            totalPaid = aStockCalculation.PricePaid();
            totalSold = aStockCalculation.TotalSold();
            //calculate the difference
            difference = aStockCalculation.Difference(totalSold, totalPaid);
            //display output 
            Console.WriteLine("**************************************");
            Console.WriteLine("\t {0}", stockName);
            Console.WriteLine("Bought price \t {0:c}", totalPaid);
            Console.WriteLine("Sold price \t {0:c}", totalSold);
            Console.WriteLine("Difference \t {0:c}", difference);

        }
        //get user input via methods
        private static void Heading()
        {

            Console.WriteLine("********************************************************");
            Console.WriteLine("\t Stock Transactions");
            Console.WriteLine("\t Calculate results of stock bought and sold");
            Console.WriteLine("\t {0}", DateTime.Today.ToShortDateString());
            Console.WriteLine("********************************************************");
        }


        private static void DisplayInstructions()
        {
            Console.WriteLine("This program will determine the profit or loss on a stock.");
            Console.WriteLine("");
            Console.WriteLine("You will be asked to enter the stock name, number of shares,");
            Console.WriteLine("price bought, and price sold.");
            Console.WriteLine("********************************************************");
            Console.WriteLine("**************************************");
        }
        private static string getStockName()
        {
            string inputValue;
            Console.Write("Enter stock name: ");
            inputValue = Console.ReadLine();
            return inputValue;
        }
        private static Double getSharesBought()
        {
            double inputValue;
            Console.Write("Enter shares bought: ");
            inputValue = int.Parse(Console.ReadLine());
            return inputValue;
        }

        private static Double getPriceBought()
        {
            double inputValue;
            Console.Write("Enter price bought: ");
            inputValue = int.Parse(Console.ReadLine());
            return inputValue;
        }
        private static Double getPriceSold()
        {
            double inputValue;
            Console.Write("Enter price sold: ");
            inputValue = int.Parse(Console.ReadLine());
            return inputValue;
        }
    

    }
}
