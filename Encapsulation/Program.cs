using System;
namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen1 = new Dosen("Budi", 112233);
            Dosen dosen2 = new Dosen("Asep", 223344);
            Dosen dosen3 = new Dosen("Arif", 334455);
            int totalDosen = Dosen.totalDosen;

            Console.WriteLine("Total dosen = {0}", totalDosen);
            Console.WriteLine("+--------------------------------+");
            Console.WriteLine("Dosen 1 : {0} dengan NIK {1}", dosen1.namaDosen, dosen1.nikDosen);
            Console.WriteLine("Dosen 2 : {0} dengan NIK {1}", dosen2.namaDosen, dosen2.nikDosen);
            Console.WriteLine("Dosen 3 : {0} dengan NIK {1}", dosen3.namaDosen, dosen3.nikDosen);
            Console.ReadKey();
        }
    }
}