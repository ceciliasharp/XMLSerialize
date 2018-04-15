using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerializeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new MyXMLSerializer();
            x.SerializeToFile();

            var p = x.SerializeFromFile();

            Console.WriteLine(p.Name);
            Console.ReadKey();
        }


        
    }
}
