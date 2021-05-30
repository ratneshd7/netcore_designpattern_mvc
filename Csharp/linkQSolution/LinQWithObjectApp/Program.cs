using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQWithObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> account = new List<Account>();
            account.Add(new Account
            {
                Balance = 5000,
                Name = "Ratnesh",
                AccountNo = 81244,
            });
            account.Add(new Account{
                Balance = 4000,
                Name = "Onkar",
                AccountNo = 1234,
            });
            account.Add(new Account
            {
                Balance = 6000,
                Name = "Hiren",
                AccountNo = 7855,
            });
            account.Add(new Account
            {
                Balance = 1000,
                Name = "Mayur",
                AccountNo = 76765,
            });
            account.Add(new Account
            {
                Balance = 500,
                Name = "MayurN",
                AccountNo = 987965,
            });

            //DisplayAllName(account);
            //DisplayNameUppercaseDesc(account);
            //DisplayTopThreeRich(account);
            //DisplaySumofAllBalance(account);
            GetAccountDetails(account);
            //BalWithinterest(account);
        }

        private static void BalWithinterest(List<Account> account)
        {
            var increasedBalance = account.Select(a =>
            {
                a.Balance += a.Balance * 0.1;
                return a;
            }).ToList();
            foreach (Account bal in increasedBalance)
            {
                Console.WriteLine("Name:"+bal.Name+"\nBalance:"+bal.Balance);
            }
        }

        private static void GetAccountDetails(List<Account> account)
        {
            var accountDetail = account.Where(a => a.AccountNo == 81244)
                                       .Single();
            Console.WriteLine("Name:" + accountDetail.Name + "\nBalance:" + accountDetail.Balance + "\nAccount No:" + accountDetail.AccountNo + "\n");
        }

        private static void DisplaySumofAllBalance(List<Account> account)
        {
            var totalbalance = account.Select(a => a.Balance)
                                      .Sum(a=>a);
            Console.WriteLine(totalbalance);
        }

        private static void DisplayTopThreeRich(List<Account> account)
        {
            var namelist = account.OrderByDescending(a => a.Balance)
                                  .Take(3)
                                  .ToList();
            foreach ( Account name in namelist)
            {
                Console.WriteLine("Name:"+name.Name+"\nBalance:"+name.Balance + "\nAccount No:" + name.AccountNo+"\n");
            }
        }

        private static void DisplayAllName(List<Account> acc)
        {
           var namelist = acc.Select(a=>a.Name);
            foreach (string name in namelist)
            {
                Console.WriteLine(name);
            }
        }
        private static void DisplayNameUppercaseDesc(List<Account> acc)
        {
            var namelist = acc.Select(a => a.Name.ToUpper())
                              .OrderByDescending(a=>a);
            foreach (string name in namelist)
            {
                Console.WriteLine(name);
            }
        }
    }
}
