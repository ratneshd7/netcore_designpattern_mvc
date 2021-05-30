using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    class Octopus : IAnimal
    {
        public string speak()
        {
            return "SQUAWCK";
        }
    }
}
