using System;

namespace ProxyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("test_10mb.jpg");

            //image will be loaded from disk
            image.Display();
            
            //image will not be loaded from disk
            image.Display();
        }
    }
}
