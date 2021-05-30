using SerializationApp.BusinessApp;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Ratnesh","81244",100);
            Stream fstream = new FileStream("~SerializedDoc.txt", FileMode.Create,FileAccess.Write);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fstream, account);
             fstream.Close();

            Stream stream = new FileStream("~SerializedDoc.txt", FileMode.Open,FileAccess.Read);
            Account acc = (Account)formatter.Deserialize(stream);
            Console.WriteLine(acc.Accountno+"\n"+acc.Name);
            stream.Close();

            XmlSerializer xs = new XmlSerializer(typeof(Account));
            Stream fstreamxml = new FileStream("~SerializedDoc.xml", FileMode.Create, FileAccess.Write);
            xs.Serialize(fstreamxml, account);
            fstreamxml.Close();

            Stream streamxml = new FileStream("~SerializedDoc.xml", FileMode.Open, FileAccess.Read);
            Account accxml = (Account)xs.Deserialize(streamxml);
            Console.WriteLine(acc.Accountno + "\n" + acc.Name);
            streamxml.Close();
        }
    }
}
