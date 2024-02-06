using System;
namespace Abstraction
{
    public abstract class iphone
    {
        public string model { get; set; }
        public int price { get; set; }

        public abstract void showSpec();

    }
}