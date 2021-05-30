using System;
using System.Threading.Tasks;

namespace SingltonDemo
{
    class Program
    {
        static void Main(string[] args)
        {       //parallel invoke to see same method invoke same thread 
                Parallel.Invoke(
                    () => PrintTeacherDetails(),
                    () => PrintStudentdetails()
                    );
                Console.ReadLine();
            }
            private static void PrintTeacherDetails()
            {
                Singleton fromTeacher = Singleton.GetInstance;
                fromTeacher.PrintDetails("From Teacher");
            }
            private static void PrintStudentdetails()
            {
                Singleton fromStudent = Singleton.GetInstance;
                fromStudent.PrintDetails("From Student");
            }
        }
    
}
