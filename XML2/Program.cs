using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", null));



            XmlElement root = doc.CreateElement("RootElement");
            XmlElement firstElement = doc.CreateElement("First");
            firstElement.SetAttribute("Comment", "Some Comment of Element");
            firstElement.InnerText = "\nFirst element inner text"; //почему-то при установке текста всё становится в одну строку. Не знаю как победить. Без внутреннего текста всё красиво.



            XmlElement secondElement = doc.CreateElement("Second");
            secondElement.SetAttribute("Comment", "Some Comment of Element");
            
            

            XmlElement thirdElement = doc.CreateElement("Third");
            secondElement.AppendChild(thirdElement);
            XmlElement fourthElement = doc.CreateElement("Forth");
            fourthElement.InnerText = "\nFourth element inner text";
            thirdElement.AppendChild(fourthElement);
            XmlElement emptyElement = doc.CreateElement("Empty");
            emptyElement.SetAttribute("Comment", "Some Comment of Element");
            emptyElement.InnerText= "\nEmptyElemInnerText\n";
          
            XmlNode emp1 = emptyElement.Clone();
            XmlNode emp2 = emptyElement.Clone();
            XmlNode emp3 = emptyElement.Clone();
            XmlNode emp4 = emptyElement.Clone();
            XmlNode emp5 = emptyElement.Clone();
            XmlNode emp6 = emptyElement.Clone();
            root.AppendChild(firstElement);
            firstElement.AppendChild(secondElement);
            root.AppendChild(emptyElement);
            root.AppendChild(emp1);
            root.AppendChild(emp2);
            root.AppendChild(emp3);
            root.AppendChild(emp4);
            root.AppendChild(emp5);
            root.AppendChild(emp6);



            doc.AppendChild(root);
            doc.Save("Elements.xml");
        }
    }
}
