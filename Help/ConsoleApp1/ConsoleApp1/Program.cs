using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        const String file = "reciep.xml";
        static void PrintBooks()
        {
            int counter = 1;
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlElement root = doc.DocumentElement;
            Console.WriteLine("\nBooks listing: ");
            foreach (XmlNode node in root)
            {
                XmlNodeList childList = node.ChildNodes;

                Console.WriteLine(counter++ + ") \nType: " + childList.Item(0).InnerText);
                Console.WriteLine("Name: " + childList.Item(1).InnerText);
                Console.WriteLine("Time: " + childList.Item(2).InnerText);
                Console.WriteLine("Complexity: " + childList.Item(3).InnerText);
            }
        }
        static void createBook(String type, String name, String time, String complexity)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlElement root = doc.DocumentElement;
            XmlElement addElem = doc.CreateElement("RECIPE");
            XmlElement ch1 = doc.CreateElement("TYPE");
            XmlElement ch2 = doc.CreateElement("NAME");
            XmlElement ch3 = doc.CreateElement("TIME");
            XmlElement ch4 = doc.CreateElement("COMPLEXITY");

            ch1.InnerText = type;
            ch2.InnerText = name;
            ch3.InnerText = time;
            ch4.InnerText = complexity;

            addElem.AppendChild(ch1);
            addElem.AppendChild(ch2);
            addElem.AppendChild(ch3);
            addElem.AppendChild(ch4);

            root.AppendChild(addElem);
            doc.Save("reciep.xml");
        }
        static void delete(String name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlElement root = doc.DocumentElement;
            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                if (root.ChildNodes.Item(i).ChildNodes.Item(1).InnerText == name)
                    root.RemoveChild(root.ChildNodes.Item(i));
            }
            doc.Save("reciep.xml");
        }
        static void refactor(String name, String elem, String newTxt)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlElement root = doc.DocumentElement;

            foreach (XmlNode node in root)
            {
                if (node.ChildNodes.Item(1).InnerText == name)
                {
                    foreach (XmlNode child in node.ChildNodes)
                        if (child.Name == elem)
                            child.InnerText = newTxt;
                }
            }
            doc.Save("reciep.xml");
        }
        static bool correctpam(string pam, string name)
        {
            int count = 0;
            bool check = true;
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlElement root = doc.DocumentElement;

            foreach (XmlNode node in root)
            {
                if (node.ChildNodes.Item(1).InnerText == name)
                {
                    foreach (XmlNode child in node.ChildNodes)
                        if (child.Name == pam)
                            count++;
                }
            }
            if (count == 0)
            {
                check = false;
                Console.WriteLine("Wrong parameter");
            }

            return check;
        }
        static bool correctname(string par)
        {
            int count = 0;
            bool check = true;
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlElement root = doc.DocumentElement;
            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                if (root.ChildNodes.Item(i).ChildNodes.Item(1).InnerText == par)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                check = false;
                Console.WriteLine("Wrong name");
            }
            return check;
        }
        private static void ValidationCallBack(object sender, ValidationEventArgs e)
        {
            Console.WriteLine("Validation Error: {0}", e.Message);
            Console.ReadKey();
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            settings.ValidationType = ValidationType.DTD;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);

            XmlReader reader = XmlReader.Create("reciep.xml", settings);

            while (reader.Read()) ;

            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Select an action: \n1 - print recipe \n2 - create recipe \n3 - delete recipe \n4 -  add information to the recipe");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case '1': PrintBooks(); break;
                    case '2':
                        {
                            String name;
                            Console.WriteLine("\nEnter parameters \nType: ");
                            String type = Console.ReadLine();
                            Console.WriteLine("Name: ");
                            name = Console.ReadLine();
                            Console.WriteLine("Time of cooking: ");
                            String time = Console.ReadLine();
                            Console.WriteLine("Complexity: ");
                            String complexity = Console.ReadLine();
                            createBook(type, name, time, complexity);
                            break;
                        }
                    case '3':
                        {
                            String name;
                            bool check = false;
                            Console.WriteLine("\nName of the recipe to be deleted:");
                            do
                            {
                                name = Console.ReadLine();
                                check = correctname(name);
                            } while (check == false);
                            delete(name);
                            break;
                        }
                    case '4':
                        {
                            String recipeName;
                            String param;
                            bool check = false;
                            Console.WriteLine("\nName of the recipe to be changed:");
                            do
                            {
                                recipeName = Console.ReadLine();
                                check = correctname(recipeName);
                            } while (check == false);
                            Console.WriteLine("Variable parameter(capsLock):");
                            do
                            {
                                param = Console.ReadLine();
                                check = correctpam(param, recipeName);
                            } while (check == false);
                            Console.WriteLine("New text:");
                            String txt = Console.ReadLine();
                            refactor(recipeName, param, txt);
                            break;
                        }
                }
                Console.WriteLine("\n");
            }
        }
    }
}

