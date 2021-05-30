using System;


namespace ManInheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //case1();
           // case2();
            case3();
        }

        public static void case1()
        {
            Man man;
            man = new Man();
            man.Play();
            man.Raed();
        }
        public static void case2()
        {
            Man man;
            man = new Boy();
            man.Play();
            man.Raed();
        }
        public static void case3()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
        }

        public static void AtThePark(Man x)
        {
            Console.WriteLine("At the Park");
            x.Play();
        }
    }
}
