using System;
using InterfaceLib;

namespace InterfaceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Boy boy = new Boy();
            Man man = new Man();

            AtTheMovie(boy);
            AtThePark(boy);

            AtTheMovie(man);
           
        }

        public static void AtThePark(IEmmotionerable obj)
        {
            Console.WriteLine("At Movie");
            obj.Cry();
            obj.Laugh();
        }

        public static void AtTheMovie(IMannerable obj)
        {
            Console.WriteLine("At The Park");
            obj.Wish();
            obj.Depart();
        }
    }
}
