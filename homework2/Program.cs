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
         }
    }
}
