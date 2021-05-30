using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManInheritanceApp
{
    class Man
    {
        public virtual void Play()// use virtual key which shows that method can be overide
        {
            Console.WriteLine("Man is Playing");
        }
        public void Raed()
        {
            Console.WriteLine("Man is Reading");
        }
    }
}
