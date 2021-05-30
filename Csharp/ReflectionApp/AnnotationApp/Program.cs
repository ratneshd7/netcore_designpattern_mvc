using System;
using System.Reflection;

namespace AnnotationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int trueValue = 0,falseValue=0;
            Type type = typeof(Foo);
            MemberInfo info = typeof(Foo);
            MethodInfo[] methods = type.GetMethods();
            object instance = Activator.CreateInstance(type, null);
            for (int i = 0; i < methods.Length; i++)
            {
                System.Collections.Generic.IEnumerable<Attribute> attributes = methods[i].GetCustomAttributes();
                foreach (Attribute attr in attributes)
                {
                    if(attr is NeedForRefactor)
                    {
                        Console.WriteLine(methods[i].Name);
                        Console.WriteLine(methods[i].Invoke(instance,null));
                        if (methods[i].Invoke(instance,null).Equals(true))
                        {
                            trueValue++;
                        }
                        else
                        {
                            falseValue++;
                        }
                    }
                    
                }
            }
            Console.WriteLine("No of true return "+trueValue);
            Console.WriteLine("No of false return "+falseValue);

        }
    }
}
