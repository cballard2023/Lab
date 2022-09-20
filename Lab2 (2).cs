using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare constants
            double coffeePrice = 2.00;
            double buffetPrice = 9.99;

            //read input and calculations
            Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");
            int numPeople = int.Parse(Console.ReadLine());

            if(numPeople<1 || numPeople>6)
            {
                Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
                return;
            }

            double totalCost = numPeople * buffetPrice;

            Console.WriteLine();
            Console.WriteLine("A table for {0}! Please follow me and take a seat.", numPeople);
            Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.");
            Console.WriteLine();

            int waterCount = 0;
            int coffeeCount = 0;

            for(int i=0;i<numPeople;i++)
            {
                Console.WriteLine("Alright, person number {0}, water or coffee?",i+1);
                string drink = Console.ReadLine().ToLower();
                if(drink== "water")
                {
                    Console.WriteLine("Water, good choice!");
                    waterCount++;
                } else 
                if(drink == "coffee")
                {
                    Console.WriteLine("Coffee, okay!");
                    totalCost += coffeePrice;
                    coffeeCount++;
                } else
                {
                    Console.WriteLine("We don't have that. No drink for you!");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Okay, so that's {0} coffees and {1} waters. I'll be right back. Feel free to grab your food!",coffeeCount,waterCount);
            Console.WriteLine("Here's your bill! Total price: ${0:F2}",totalCost);

        }
    }
}
