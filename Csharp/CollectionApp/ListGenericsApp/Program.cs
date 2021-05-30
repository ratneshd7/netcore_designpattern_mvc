using System;
using System.Collections.Generic;


namespace ListGenericsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LineItem> cart = new List<LineItem>();
            cart.Add(new LineItem("Book", 500, 5));
            cart.Add(new LineItem("Pen", 100, 10));
            cart.Add(new LineItem("Pencil", 200, 10));
            
            foreach (LineItem item in cart)
            {  
                Console.WriteLine("Item Name:" + item.Name + "  ItemCost:" + item.CalTotalCost());
            }

            IEnumerator<LineItem> enumerator = cart.GetEnumerator();
            
                while (enumerator.MoveNext())
                {
                //var data = enumerator.Current.CalTotalCost();
                    Console.WriteLine(enumerator.Current.CalTotalCost());
                }
            }   
        }
}
