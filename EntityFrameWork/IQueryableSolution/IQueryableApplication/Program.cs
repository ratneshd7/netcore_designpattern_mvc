using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQueryableApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            SwabhavDb db = new SwabhavDb();
            //QueryableCase1(db);
            //QueryableCase2(db);
            //QueryableCase3(db);
            QueryableCase4(db);
            //QueryableCase5(db);
            
           
        }

        private static void QueryableCase1(SwabhavDb db)
        {
            var empList = db.Employees.ToList().Where(e => e.DEPTNO == 10);
            foreach (EMPIQUERYABLE emp in empList)
            {
                Console.WriteLine(emp.ENAME);
            }
        }

        private static void QueryableCase2(SwabhavDb db)
        {
            var empList = db.Employees.Where(e => e.DEPTNO == 10).ToList();
            foreach (EMPIQUERYABLE emp in empList)
            {
                Console.WriteLine(emp.ENAME);
            }
        }

        private static void QueryableCase3(SwabhavDb db)
        {
            var empList = db.Employees.Where(e => e.ENAME.StartsWith("A")).Select(e=>new { e.ENAME,e.EMPNO}).ToList();
            foreach (var emp in empList)
            {
                Console.WriteLine(emp.ENAME+ " " +emp.EMPNO);
            }
        }

        private static void QueryableCase4(SwabhavDb db)
        {
            var empList = db.Employees.Where(e => e.ENAME.StartsWith("A")).Select(e => new { e.EMPNO, n=e.ENAME.Split(' ')[0] }).ToList();
            foreach (var emp in empList)
            {
                Console.WriteLine(emp.n + " " + emp.EMPNO);
            }
        }

        private static void QueryableCase5(SwabhavDb db)
        {
            var empList = db.Employees.Where(e => e.ENAME.StartsWith("A")).ToList().Select(e => new { e.EMPNO, n = e.ENAME.Split(' ')[0] });
            foreach (var emp in empList)
            {
                Console.WriteLine(emp.n + " " + emp.EMPNO);
            }
        }
    }
}
