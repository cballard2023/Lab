using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare constants
            const int slicesPerLoaf = 28;
            const int tablespoonsPerJar = 32;
            const int teaspoonsPerJar = 48;
            const int slicesPerSandwich = 2;
            const int tablespoonsPerSandwich = 2;
            const int teaspoonsPerSandwich = 4;

            //read input
            Console.WriteLine("How many people are we making PB and J sandwiches for?");
            int numPeople = int.Parse(Console.ReadLine());

            //make calculations
            int totalSlicesNeeded = numPeople * slicesPerSandwich;
            int totalTableSpoonsNeeded = numPeople * tablespoonsPerSandwich;
            int totalTeaSpoonsNeeded = numPeople * teaspoonsPerSandwich;

            int totalLoavesNeeded = (int)Math.Ceiling(totalSlicesNeeded / (double)slicesPerLoaf);
            int totalJarsNeededPeanutButter = (int)Math.Ceiling(totalTableSpoonsNeeded / (double)tablespoonsPerJar);
            int totalJarsNeededJelly = (int)Math.Ceiling(totalTeaSpoonsNeeded / (double)teaspoonsPerJar);

            //display results
            Console.WriteLine();
            Console.WriteLine("You need:");
            Console.WriteLine("        {0} slices of bread", totalSlicesNeeded);
            Console.WriteLine("        {0} tablespoons of peanut butter", totalTableSpoonsNeeded);
            Console.WriteLine("        {0} teaspoons of jelly", totalTeaSpoonsNeeded);
            Console.WriteLine();
            Console.WriteLine("        which is ...");
            Console.WriteLine();
            Console.WriteLine("        {0} loaves of bread", totalLoavesNeeded);
            Console.WriteLine("        {0} jars of peanut butter", totalJarsNeededPeanutButter);
            Console.WriteLine("        {0} jars of jelly", totalJarsNeededJelly);

            //wait for press any key
            Console.ReadKey();

        }
    }
}
