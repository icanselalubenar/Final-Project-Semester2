using System;
namespace Abstraction
{
    public abstract class Smartphone
    {
        public string merk { get; set; }
        public string model { get; set; }

        public abstract void data();
        public abstract void spec();
    }
}