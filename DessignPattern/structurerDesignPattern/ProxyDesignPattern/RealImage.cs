using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    class RealImage : IImage
    {
        private String FileName;
        public RealImage(String fileName)
        {
            this.FileName = fileName;
            loadFromDisk(fileName);
        }
        public void Display()
        {
            Console.WriteLine("Displaying " + FileName);
        }
        private void loadFromDisk(String fileName)
        {
            Console.WriteLine("Loading " + fileName);
        }
    }
}
