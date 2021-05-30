using System;


namespace InterfaceLib
{
    public class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine("Man is Departing from Park'");

        }

        public void Wish()
        {
            Console.WriteLine("Man is Wishing 'Hello'");

        }
    }
}
