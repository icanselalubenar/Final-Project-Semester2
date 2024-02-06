using System;
namespace Abstraction
{
    public class Model : iphone
    {
        public override void showSpec()
        {
            string chip = "-";
            int ram = 0;
            if (model == "iPhone 13")
            {
                price = 9550000;
                chip = "A15 Bionic";
                ram = 4;
            }
            else if (model == "iPhone SE gen 2")
            {
                price = 4999000;
                chip = "A13 Bionic";
                ram = 3;
            }
            else if (model == "iPhone X")
            {
                price = 3299000;
                chip = "A11 Bionic";
                ram = 3;
            }
            else
                price = 0;

            Console.WriteLine("{0} using {1} chipset and {2} GB of RAM.", model, chip, ram);
            Console.WriteLine("Price : Rp.{0}", price);
        }
    }
}

//public override void data()
//{
//    string model;
//    if (merk == "Apple")
//        model = "iPhone 14 Pro Max";
//    else if (merk == "Samsung")
//        model = "Samsung S23 Ultra";
//    else if (merk == "Xiaomi")
//        model = "Xiaomi 13 Ultra";
//    else
//        model = "-";
//    Console.WriteLine("Model : {0}", model);
//}
//public override void spec()
//{
//    if (merk == "Apple")
//    {
//        Console.WriteLine("Spesifikasi :");
//        Console.WriteLine("A16 Bionic / RAM 6 GB / Battery 4323mAh / Camera 48MP");
//    }
//    else if (merk == "Samsung")
//    {
//        Console.WriteLine("Spesifikasi :");
//        Console.WriteLine("Snapdragon 8 Gen 2 / RAM 12 GB / Battery 5000mAh / Camera 200MP");
//    }
//    else if (merk == "Xiaomi")
//    {
//        Console.WriteLine("Spesifikasi :");
//        Console.WriteLine("Snapdragon 8 Gen 2 / RAM 16 GB / Battery 5000mAh / Camera 50MP");
//    }
//    else
//        Console.WriteLine("-");

//}