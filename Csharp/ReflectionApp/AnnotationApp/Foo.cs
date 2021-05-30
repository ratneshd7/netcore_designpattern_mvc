using System;

namespace AnnotationApp
{
   public class Foo
    {
        [NeedForRefactor]
        public bool  m1()
        {
            //Console.WriteLine("inside M1");
            return true;
        }
        
        public bool m2()
        {
           // Console.WriteLine("inside M2");
            return true;
        }
        [NeedForRefactor]
        public bool m3()
        {
           // Console.WriteLine("inside M3");
            return true;
        }
        [NeedForRefactor]
        public bool m4()
        {
            //Console.WriteLine("inside M4");
            return false;
        }
    }
}
