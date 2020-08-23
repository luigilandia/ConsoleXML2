using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML2
{
    class Program3
    {
        static void Main(string[] args)
        {
            cargarDocumento();
            XmlReader lector = new XmlTextReader("Persona.xml");
            Console.ReadLine();
        }

        private static void cargarDocumento()
        {
            XmlDocument documento = new XmlDocument();
            XmlElement elemento2 = documento.CreateElement("personas");
            documento.AppendChild(elemento2);

            XmlElement elemento = documento.CreateElement("persona");
            elemento2.AppendChild(elemento);

            XmlElement elemento3 = documento.CreateElement("persona");
            elemento2.AppendChild(elemento3);

            XmlElement nombre = documento.CreateElement("nombre");
            nombre.InnerText = "Fulanito";
            elemento.AppendChild(nombre);

            XmlElement apellido = documento.CreateElement("apellido");
            elemento.AppendChild(apellido);
            apellido.InnerText = "Detal";

            XmlElement edad = documento.CreateElement("edad");
            edad.InnerText = "37";
            elemento.AppendChild(edad);

            XmlAttribute atributo = documento.CreateAttribute("Telefono");
            atributo.InnerText = "123456";
            elemento.Attributes.Append(atributo);

            XmlElement nombre2 = documento.CreateElement("nombre");
            nombre2.InnerText = "Menganito";
            elemento3.AppendChild(nombre2);

            XmlElement apellido2 = documento.CreateElement("apellido");
            elemento3.AppendChild(apellido2);
            apellido2.InnerText = "Pascual";

            XmlElement edad2 = documento.CreateElement("edad");
            edad2.InnerText = "40";
            elemento3.AppendChild(edad2);

            XmlAttribute atributo2 = documento.CreateAttribute("Telefono");
            atributo2.InnerText = "456789";
            elemento3.Attributes.Append(atributo2);


            XmlWriter escritor = new XmlTextWriter("persona.xml", null);
            documento.Save(escritor);

            XmlNodeList nodo = documento.GetElementsByTagName("edad");
            int suma = 0;
            for (int i = 0; i < nodo.Count; i++)
            {
                string sedad = nodo[i].InnerXml;
                int ed = Convert.ToInt32(sedad);
                suma += ed;
            }
            Console.WriteLine(suma);
        }
    }
}
