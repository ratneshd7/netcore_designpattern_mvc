using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# provides an option to override the base class method, by adding the virtual keyword to the method inside the base class, 
             * and by using the override keyword for each derived class methods:
             */

            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myCat = new Cat();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myCat.animalSound();
            myDog.animalSound();
        }
    }
}
