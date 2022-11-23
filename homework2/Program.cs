using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            Console.WriteLine("Input the nominal of the trade");
            var userInput = Console.ReadLine();
            var nominal = double.Parse(userInput);

            Console.WriteLine("Input the price of the trade");
            userInput = Console.ReadLine();
            var price = double.Parse(userInput);

            Console.WriteLine("Input the type of the trade");
             
            TransactionType trcType;
            userInput = Console.ReadLine();
            trcType = (TransactionType) Enum.Parse(typeof(TransactionType), userInput,true);

            double currentValue = nominal * price;
            currentValue = (trcType == TransactionType.Buy) ? currentValue: -currentValue;

            Console.WriteLine($"The current value of your investment is: {currentValue}");

            //Assignment 2
            Console.WriteLine("If you want to calculate the profit of a sale, please enter the buy price");
            userInput = Console.ReadLine();
            var buyprice = double.Parse(userInput);

            Console.WriteLine("Please enter the sell price");
            userInput = Console.ReadLine();
            double sellprice = double.Parse(userInput);

            Console.WriteLine("Please enter the amount you sold");
            userInput = Console.ReadLine();
            var nominalsold = double.Parse(userInput);

            double profil = (nominalsold * sellprice) - (nominalsold * buyprice);

            Console.WriteLine($"Your profit is: {profil}");
        }
    }
}
