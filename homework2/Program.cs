using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        enum TransactionType
        {
            Buy = 1,
            Sell = -1
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Input the nominal of the trade");
            var UInominal = Console.ReadLine();
            var nominal = float.Parse(UInominal);

            Console.WriteLine("Input the price of the trade");
            var UIprice = Console.ReadLine();
            float price = float.Parse(UInominal);

            Console.WriteLine("Input the type of the trade");
             
            TransactionType trcType;
            string userInput = Console.ReadLine();
            trcType = (TransactionType) Enum.Parse(typeof(TransactionType), userInput,true);

            double currentValue = ((double)trcType) * nominal * price;
            
            Console.WriteLine($"The current value of your investment is: {currentValue}");

            //Assignment 2
            Console.WriteLine("If you want to calculate the profit of a sale, please enter the buy price");
            var UIbuyprice = Console.ReadLine();
            var buyprice = float.Parse(UIbuyprice);

            Console.WriteLine("Please enter the sell price");
            var UIsell = Console.ReadLine();
            float sell = float.Parse(UIsell);

            Console.WriteLine("Please enter the amount you soldt");
            var UInominalsold = Console.ReadLine();
            var nominalsold = float.Parse(UInominalsold);

            double profil = (nominalsold * buyprice) - (nominalsold * sell);

            Console.WriteLine($"Your profit is: {profil}");
        }
    }
}
