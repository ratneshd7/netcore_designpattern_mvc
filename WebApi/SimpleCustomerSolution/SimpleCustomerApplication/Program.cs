using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace SimpleCustomerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(101, "Onkar", "More", "Jogeshwari","SWD");
            //Customer c2 = new Customer(102, "Ratnesh", "Dubey", "andheri");
            SwabhavDbContext db = new SwabhavDbContext();
            db.Customers.Add(c1);
            //db.Customers.Add(c2);
            db.SaveChanges();
            DisplayDatabaseData(db);
            //Console.WriteLine("-----------------------Update---------------------------------");
            //UpdateDatabase(db);
            Console.WriteLine("-----------------------Delete---------------------------------");
            //RemoveData(db);
        }     

        private static void DisplayDatabaseData(SwabhavDbContext db)
        {
            if (db.Database != null)
            {
                var list = db.Set<Customer>();
                foreach (var item in list)
                {
                    Console.WriteLine(item.FirstName);
                }
            }
        }

        private static void UpdateDatabase(SwabhavDbContext db)
        {
            var updateCustomer = db.Set<Customer>().Find(1);
            updateCustomer.FirstName = "Hiren";
            db.SaveChanges();
            foreach (var item in db.Customers)
            {
                Console.WriteLine(item.FirstName);
            }
        }
        private static void RemoveData(SwabhavDbContext db)
        {
            db.Set<Customer>().Remove(db.Set<Customer>().Find(1));
            db.SaveChanges();
            DisplayDatabaseData(db);

        }
    }
}
