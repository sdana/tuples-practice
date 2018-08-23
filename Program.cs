using System;
using System.Collections.Generic;
using System.Linq;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("Hammer", 10.00, 2));
            transactions.Add(("Table Saw", 50.99, 1));
            transactions.Add(("Nails", 00.10, 1000));
            transactions.Add(("Screwdrivers", 5.00, 20));
            transactions.Add(("Paint", 12.99, 50));

            List<int> itemsSold = new List<int>();
            List<double> profits = new List<double>();
            int totalItemsSold;
            double netProfit;

            foreach (var item in transactions)
            {
                System.Console.WriteLine(item);
                itemsSold.Add(item.quantity);
                profits.Add(item.amount);

            }
            totalItemsSold = itemsSold.Sum();
            netProfit = profits.Sum();
            System.Console.WriteLine($"Items Sold Today: {totalItemsSold}");
            System.Console.WriteLine($"Total Profits: {netProfit}");
        }
    }
}
