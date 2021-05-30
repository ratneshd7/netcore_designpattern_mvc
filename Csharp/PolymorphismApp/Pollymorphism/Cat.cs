using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pollymorphism
{
    class Cat : Animal  // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The Cat says: meow meow");
        }
    }
}
