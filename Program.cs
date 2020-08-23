using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument documento = new XmlDocument();
            XmlElement elemento = documento.CreateElement("persona");
            documento.AppendChild(elemento);

            XmlElement nombre = documento.CreateElement("nombre");
            nombre.InnerText="Fulanito";
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
            

            XmlWriter escritor = new XmlTextWriter("Persona.xml", null);
            documento.Save(escritor);
        }
    }
}
