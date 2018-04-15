using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializeExample
{
    public class Person
    {
        [XmlAttribute]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
