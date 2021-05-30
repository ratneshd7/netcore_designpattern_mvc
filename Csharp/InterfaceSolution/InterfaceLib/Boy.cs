using System;

namespace InterfaceLib
{
    public class Boy : IMannerable,IEmmotionerable
    {
        public void Cry()
        {
            Console.WriteLine("Boy is Crying");
        }

        public void Depart()
        {
            Console.WriteLine("Boy is Departing from park");

        }

        public void Laugh()
        {
            Console.WriteLine("Boy is Laughing");

        }

        public void Wish()
        {
            Console.WriteLine("Boy is Wishing For Gift");
        }
    }
}
