using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    class ProxyImage : IImage
    {
        private RealImage realImage;
        private String fileName;

        public ProxyImage(String fileName)
        {
            this.fileName = fileName;
        }
        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.Display();
        }
    }
}
