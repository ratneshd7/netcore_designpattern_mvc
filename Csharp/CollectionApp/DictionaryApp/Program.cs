using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> dict = new Dictionary<string, string>();
            dict.Add("Ratnesh", "ratnesh");
            dict["Ratnesh"] = "onkar";
            Console.WriteLine(dict.ContainsKey("onkar"));
            foreach (KeyValuePair<string, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

        }
    }
}
