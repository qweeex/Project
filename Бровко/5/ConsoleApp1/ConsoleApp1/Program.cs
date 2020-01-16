using System;
using System.Text;
using System.Xml;
class Program
{
    const String file = "Inventory.xml";
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

            Console.WriteLine(counter++ + ") \nTitle: " + childList.Item(0).InnerText);
            Console.WriteLine("Author: " + childList.Item(1).InnerText);
            Console.WriteLine("Binding: " + childList.Item(2).InnerText);
            Console.WriteLine("Pages: " + childList.Item(3).InnerText);
            Console.WriteLine("Price: " + childList.Item(4).InnerText);
        }
    }

    static void createBook(String title, String author, String binding, String pages, String price)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(file);
        XmlElement root = doc.DocumentElement;
        XmlElement addElem = doc.CreateElement("BOOK");
        XmlElement ch1 = doc.CreateElement("TITLE");
        XmlElement ch2 = doc.CreateElement("AUTHOR");
        XmlElement ch3 = doc.CreateElement("BINDING");
        XmlElement ch4 = doc.CreateElement("PAGES");
        XmlElement ch5 = doc.CreateElement("PRICE");

        ch1.InnerText = title;
        ch2.InnerText = author;
        ch3.InnerText = binding;
        ch4.InnerText = pages;
        ch5.InnerText = price;

        addElem.AppendChild(ch1);
        addElem.AppendChild(ch2);
        addElem.AppendChild(ch3);
        addElem.AppendChild(ch4);
        addElem.AppendChild(ch5);

        root.AppendChild(addElem);
        doc.Save("Inventory.xml");
    }

    static void delete(String title)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(file);
        XmlElement root = doc.DocumentElement;
        for (int i = 0; i < root.ChildNodes.Count; i++)
        {
            if (root.ChildNodes.Item(i).ChildNodes.Item(0).InnerText == title)
                root.RemoveChild(root.ChildNodes.Item(i));
        }
        doc.Save("Inventory.xml");
    }

    static void refactor(int number, String elem, String newTxt)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(file);
        XmlNode node = doc.GetElementsByTagName("BOOK")[number - 1];

        foreach (XmlNode child in node.ChildNodes)
            if (child.Name == elem)
                child.InnerText = newTxt;

        doc.Save("Inventory.xml");
    }


    static void Main(string[] args)
    {
        while (true)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Select option: \n1 - Print information \n2 - Create book \n3 - Delete book \n4 -  Add information about book");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case '1': PrintBooks(); break;
                case '2':
                    {
                        Console.WriteLine("\nEnter parameters \nBook name: ");
                        String title = Console.ReadLine();
                        Console.WriteLine("Author: ");
                        String author = Console.ReadLine();
                        Console.WriteLine("Binding: ");
                        String binding = Console.ReadLine();
                        Console.WriteLine("Num of pages: ");
                        String pages = Console.ReadLine();
                        Console.WriteLine("Price: ");
                        String price = Console.ReadLine();
                        createBook(title, author, binding, pages, price);
                        break;
                    }
                case '3':
                    {
                        Console.WriteLine("\nRemovable book name:");
                        delete(Console.ReadLine());
                        break;
                    }
                case '4':
                    {
                        Console.WriteLine("\nMutable book name:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Mutable parameter:");
                        String param = Console.ReadLine();
                        Console.WriteLine("New text:");
                        String txt = Console.ReadLine();
                        refactor(number, param, txt);
                        break;
                    }
            }
            Console.WriteLine("\n");
        }
    }
}

