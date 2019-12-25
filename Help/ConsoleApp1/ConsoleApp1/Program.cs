using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        const String file = "Musicbook.xml";
        static void PrintBooks()
        {
            int counter = 1;
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlElement root = doc.DocumentElement;
            Console.WriteLine("\nSongs listing: ");
            foreach (XmlNode node in root)
            {
                XmlNodeList childList = node.ChildNodes;

                Console.WriteLine(counter++ + ") \nName: " + childList.Item(0).InnerText);
                Console.WriteLine("Singer: " + childList.Item(1).InnerText);
                Console.WriteLine("Album: " + childList.Item(2).InnerText);
                Console.WriteLine("Year: " + childList.Item(3).InnerText);
                Console.WriteLine("Language: " + childList.Item(4).InnerText);
            }
        }
        static void createBook(String name, String singer, String album, String year, String language)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlElement root = doc.DocumentElement;
            XmlElement addElem = doc.CreateElement("Song");
            XmlElement ch1 = doc.CreateElement("Name");
            XmlElement ch2 = doc.CreateElement("Singer");
            XmlElement ch3 = doc.CreateElement("Album");
            XmlElement ch4 = doc.CreateElement("Year");
            XmlElement ch5 = doc.CreateElement("Language");

            ch1.InnerText = name;
            ch2.InnerText = singer;
            ch3.InnerText = album;
            ch4.InnerText = year;
            ch5.InnerText = language;

            addElem.AppendChild(ch1);
            addElem.AppendChild(ch2);
            addElem.AppendChild(ch3);
            addElem.AppendChild(ch4);
            addElem.AppendChild(ch5);

            root.AppendChild(addElem);
            doc.Save("Musicbook.xml");
        }
        static void delete(String name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlElement root = doc.DocumentElement;
            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                if (root.ChildNodes.Item(i).ChildNodes.Item(0).InnerText == name)
                    root.RemoveChild(root.ChildNodes.Item(i));
            }
            doc.Save("Musicbook.xml");
        }
        static void changer(String name, String elem, String newTxt)
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
            doc.Save("Musicbook.xml");
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
                if (node.ChildNodes.Item(0).InnerText == name)
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
                if (root.ChildNodes.Item(i).ChildNodes.Item(0).InnerText == par)
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
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Select an action: \n1 - print songs \n2 - create song \n3 - delete song \n4 -  add information to the song");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case '1': PrintBooks(); break;
                    case '2':
                        {
                            Console.WriteLine("\nEnter parameters \nName: ");
                            String name = Console.ReadLine();
                            Console.WriteLine("Singer: ");
                            String singer = Console.ReadLine();
                            Console.WriteLine("Album: ");
                            String album = Console.ReadLine();
                            Console.WriteLine("Year: ");
                            String year = Console.ReadLine();
                            Console.WriteLine("Language: ");
                            String language = Console.ReadLine();
                            createBook(name, singer, album, year, language);
                            break;
                        }
                    case '3':
                        {
                            String name;
                            bool check = false;
                            Console.WriteLine("\nName of the song to be deleted:");
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
                            String Name;
                            String param;
                            bool check = false;
                            Console.WriteLine("\nName of the song to be changed:");
                            do
                            {
                                Name = Console.ReadLine();
                                check = correctname(Name);
                            } while (check == false);
                            Console.WriteLine("Variable parameter:");
                            do
                            {
                                param = Console.ReadLine();
                                check = correctpam(param, Name);
                            } while (check == false);
                            Console.WriteLine("New text:");
                            String txt = Console.ReadLine();
                            changer(Name, param, txt);
                            break;
                        }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
