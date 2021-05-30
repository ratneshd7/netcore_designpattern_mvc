using System;

namespace ExtensionMethodApp
{
    static class StringExtension
    {
        public static string ToSnakeCase(this String a)
        {
            
            string b="" ;
            Console.WriteLine(a[0]);
            foreach(Char c in a)
            {  
                if (Char.IsUpper(c))
                {
                    b += "_"+c;
                }
                else
                b += c;
            }
            return b.ToLower();
        }
    }
}
