using System;
namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motor motor;

            Console.WriteLine("Pilih motor sport anda");
            Console.WriteLine("1) Kawasaki");
            Console.WriteLine("2) Honda");
            Console.WriteLine("3) BMW");
            Console.Write("Nomor motor yang dipilih [1..3]: ");
            int nomorMotor = Convert.ToInt32(Console.ReadLine());

            if (nomorMotor == 1)
                motor = new Kawasaki();
            else if (nomorMotor == 2)
                motor = new Honda();
            else if (nomorMotor == 3)
                motor = new BMW();
            else
                motor = new Motor();

            Console.WriteLine();
            motor.Info();
            motor.Spek();

            Console.ReadKey();
        }
    }
}