using System;
using DLLAccountApp.BusinessAccounts;
using System.Reflection;

namespace ReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Account);
            Console.WriteLine("class Name:" + type.Name);
            PrintMethods(type);
            PrintConstructors(type);
            PrintProperties(type);

        }

        private static void PrintProperties(Type type)
        {
            Console.WriteLine("\nProperties in Account Class");
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("\nGetters in Account Class");

            foreach (PropertyInfo property in properties)
            {
                if (property.CanRead)
                    Console.WriteLine(property.Name);
            }
            Console.WriteLine("\nSetters in Account Class");
            foreach (PropertyInfo property in properties)
            {
                if (property.CanWrite)
                    Console.WriteLine(property.Name);
            }

        }

        private static void PrintConstructors(Type type)
        {
            Console.WriteLine("\nConstructor in Account Class");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor);
            }

        }

        public static void PrintMethods(Type type)
        {
            MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine("Methods in Account Class");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}
