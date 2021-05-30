using System;


namespace ManInheritanceApp
{
    class Boy:Man
    {
        public override void Play()
        {
            Console.WriteLine("Boy is playing");
        }
        public void Walk()
        {
            Console.WriteLine("Boy is walking");
        }
        public void Eat()
        {
            Console.WriteLine("Boy is Eating");
        }
    }
}
