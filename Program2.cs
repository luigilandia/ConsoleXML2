using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML2
{
    class Program2
    {
        static void Main(string[] args)
        {
            XmlReader lector = new XmlTextReader("Persona.xml");
            while (lector.Read())
            {
                //Console.WriteLine(lector.Name);
                if (lector.NodeType == XmlNodeType.Element)
                {
                    Console.WriteLine(lector.Name);
                }
                if (lector.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine(lector.Value);
                }

            }
            Console.ReadLine();
        }
    }
}
