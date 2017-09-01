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
            root.AppendChild(firstElement);
            XmlElement secondElement = doc.CreateElement("Second");
            firstElement.AppendChild(secondElement);
            XmlElement thirdElement = doc.CreateElement("Third");
            secondElement.AppendChild(thirdElement);
            XmlElement fourthElement = doc.CreateElement("Forth");
            thirdElement.AppendChild(fourthElement);
            doc.AppendChild(root);
            doc.Save("Elements.xml");

            //for (int i = 0; i < pInfo.Length; i++)
            //    {
            //        if (i == 0)
            //        {
            //            XmlElement orderAttr = doc.CreateElement(pInfo[i].Name);
            //            orderAttr.InnerText = order.GetType().GetProperty(pInfo[i].Name).GetValue(order, null).ToString();
            //            orderElement.SetAttribute(pInfo[i].Name, order.GetType().GetProperty(pInfo[i].Name).GetValue(order, null).ToString());
            //        }
            //        else
            //        {
            //            XmlElement otherElement = null;
            //            try
            //            {
            //                otherElement = doc.CreateElement(pInfo[i].Name);
            //                otherElement.InnerText = order.GetType().GetProperty(pInfo[i].Name).GetValue(order, null).ToString();
            //            }
            //            catch (NullReferenceException)
            //            {
            //                otherElement = doc.CreateElement(pInfo[i].Name);
            //            }
            //            finally
            //            {
            //                orderElement.AppendChild(otherElement);
            //            }
            //        }
            //    }
            //    root.AppendChild(orderElement);
            //}
            //doc.AppendChild(root);
            //doc.Save("Orders.xml");
        }
    }
}
