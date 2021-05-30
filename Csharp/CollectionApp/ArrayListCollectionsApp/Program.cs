using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListCollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cart = new ArrayList();
            cart.Add(new LineItem("Book",500,5));
            cart.Add(new LineItem("Pen", 100, 10));
            cart.Add(new LineItem("Pencil", 200, 10));
           // cart.Add(DateTime.Now);

            foreach (object item in cart)
            {
                LineItem cartItem = (LineItem)item;
                Console.WriteLine("Item Name:"+cartItem.Name +"  ItemCost:"+cartItem.CalTotalCost());
            }
        }
    }
}
