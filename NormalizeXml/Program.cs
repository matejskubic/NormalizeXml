using System.Xml;

if (args.Length != 1)
{
    Console.WriteLine("Usage: NormalizeXml <filename>");
    return;
}

XmlDocument xml = new();
xml.Load(args[0]);
xml.Save(args[0]);
