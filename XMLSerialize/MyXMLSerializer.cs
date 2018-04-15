using System.IO;
using System.Xml.Serialization;

namespace XMLSerializeExample
{
    public class MyXMLSerializer
    {
        private string fileName = @"c:\tmp\person.xml";
        public void SerializeToFile()
        {
            var personToSaveToFile = CreatePerson();
            using (var file = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var x = new XmlSerializer(typeof(Person));
                x.Serialize(file, personToSaveToFile);
            }
        }

        public Person SerializeFromFile()
        {
            Person personFromFile;
            using (var file = new FileStream(fileName, FileMode.Open))
            {
                var x = new XmlSerializer(typeof(Person));
                personFromFile = (Person)x.Deserialize(file);
            }
            return personFromFile;
        }

        public Person CreatePerson()
        {
            return new Person
            {
                Name = "Lisa",
                Age = 14,
                Address = "hemma"
            };
        }
    }
}
