using System;

namespace JButtonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            JButton btn1 = new JButton("Click", 10, 10);
            btn1.OnButtonClick += (j) => Console.WriteLine("Updating dataBase {0}",j.Width);
            btn1.OnButtonClick += (j) => Console.WriteLine("Refresing page...");
            btn1.OnClick(20,20);
        }
    }
}
