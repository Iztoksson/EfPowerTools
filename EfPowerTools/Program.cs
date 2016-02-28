namespace EfPowerTools
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("This project has custom .tt templates for Entity Framework Power Tools " +
                "which enable filtering for specific tables to be generated in Context, Poco and Map classes." +
                "Search for [// START Filter for specific tables only] inside .tt files.");
            Console.ReadKey();
        }
    }
}