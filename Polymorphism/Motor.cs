﻿using System;
namespace Polymorphism
{
    public class Motor
    {
        public virtual void Info()
        {
            Console.WriteLine("Motor tidak dipilih");
        }
        public virtual void Spek()
        {
            Console.WriteLine("Silahkan coba kembali.");
        }
    }
    public class Kawasaki:Motor
    {
        public override void Info()
        {
            Console.WriteLine("Kawasaki Ninja H2");
            Console.WriteLine("Top Speed : 325 Km/H");
        }
        public override void Spek()
        {
            Console.WriteLine("Spesifikasi:");
            Console.WriteLine("998 cc / 207 hp / 140.4 Nm / 4 Silinder 4 Tak");
        }
    }
    public class Honda : Motor
    {
        public override void Info()
        {
            Console.WriteLine("Honda CBR 1000RR-R");
            Console.WriteLine("Top Speed : 299 Km/H");
        }
        public override void Spek()
        {
            Console.WriteLine("Spesifikasi:");
            Console.WriteLine("999.9 cc / 214.5 hp / 113 Nm / 4 Silinder 4 Tak");
        }
    }
    public class BMW : Motor
    {
        public override void Info()
        {
            Console.WriteLine("BMW S 1000 RR");
            Console.WriteLine("Top Speed : 303 Km/H");
        }
        public override void Spek()
        {
            Console.WriteLine("Spesifikasi:");
            Console.WriteLine("999 cc / 210 hp / 113 Nm / 4 Silinder 4 Tak");
        }
    }
}