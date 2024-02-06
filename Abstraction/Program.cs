using System;
namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            iphone iP13 = new Model();
            iphone iPSE2 = new Model();
            iphone iPX = new Model();

            iP13.model = "iPhone 13";
            iPSE2.model = "iPhone SE gen 2";
            iPX.model = "iPhone X";

            Console.WriteLine("Select an iPhone.");
            Console.WriteLine("[1] iPhone 13");
            Console.WriteLine("[2] iPhone SE gen 2");
            Console.WriteLine("[3] iphone X");
            Console.Write("\nSelect [1..3]: ");
            int select = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (select == 1)
            {
                iP13.showSpec();
            }
            else if (select == 2)
            {
                iPSE2.showSpec();
            }
            else if (select == 3)
            {
                iPX.showSpec();
            }
            else
                Console.WriteLine("{0} not found.", select);

            Console.ReadKey();
        }
    }
}