// See https://aka.ms/new-console-template for more information
using SerializeXML;
using System.Diagnostics.Metrics;
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");
//SerializeListToXmlFile();
//DeserializeXmlFileToList();
DeserializeXmlFileToObject();
Console.WriteLine("Process completed...");

static void SerializeObjectToXmlString()
{
    var member = new Member
    {
        Name = "John",
        Email = "john.com",
        Age = 30,
        JoiningDate = DateTime.Now,
        IsPlatinumMember = false
    };
    var xmlSerializer = new XmlSerializer(typeof(Member));
    using (var writer = new StringWriter())
    {
        xmlSerializer.Serialize(writer, member);
        var xmlContent = writer.ToString();
        Console.WriteLine(xmlContent);
        DeserializeXmlStringToObject(xmlContent);
    }
}

static void SerializeObjectToXmlFile()
{
    var member = new Member
    {
        Name = "John",
        Email = "john.com",
        Age = 30,
        JoiningDate = DateTime.Now,
        IsPlatinumMember = false
    };
    var xmlSerializer = new XmlSerializer(typeof(Member));
    using (var writer = new StreamWriter(@"C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\XMLExamples\SerializeXML\SerializeXML\xml-files\sampl02.xml"))
    {
        xmlSerializer.Serialize(writer, member);
    }
}

static void SerializeListToXmlFile()
{
    var memberList = new List<Member>
    {
       new Member{Name = "John", Email = "john.com",Age = 30, JoiningDate = DateTime.Now, IsPlatinumMember = false },
       new Member{Name = "Ema", Email = "Ema.com",Age = 10, JoiningDate = DateTime.Now, IsPlatinumMember = true },
       new Member{Name = "Hasan", Email = "Hasan.com",Age = 20, JoiningDate = DateTime.Now, IsPlatinumMember = false },
       new Member{Name = "Mustafa", Email = "Mustafa.com",Age = 15, JoiningDate = DateTime.Now, IsPlatinumMember = true },
       new Member{Name = "David", Email = "david.com",Age = 25, JoiningDate = DateTime.Now, IsPlatinumMember = false },
       new Member{Name = "Jack", Email = "Jack.com",Age = 10, JoiningDate = DateTime.Now, IsPlatinumMember = true },
       new Member{Name = "Patrick", Email = "Patrick.com",Age = 25, JoiningDate = DateTime.Now, IsPlatinumMember = false },
       new Member{Name = "Arthur", Email = "Arthur.com",Age = 22, JoiningDate = DateTime.Now, IsPlatinumMember = true },
    };
    var xmlSerializer = new XmlSerializer(typeof(List<Member>));
    using (var writer = new StreamWriter(@"C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\XMLExamples\SerializeXML\SerializeXML\xml-files\sampl03.xml"))
    {
        xmlSerializer.Serialize(writer, memberList);
    }
}

static void DeserializeXmlFileToList()
{
    var xmlSerializer = new XmlSerializer(typeof(List<Member>));
    using (var reader = new StreamReader(@"C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\XMLExamples\SerializeXML\SerializeXML\xml-files\sampl03.xml"))
    {
        var members = (List<Member>)xmlSerializer.Deserialize(reader);
    }
}

static void DeserializeXmlFileToObject()
{
    var xmlSerializer = new XmlSerializer(typeof(Member));
    using (var reader = new StreamReader(@"C:\Users\Emre\Desktop\FinalDev\Asp.NET CORE\XMLExamples\SerializeXML\SerializeXML\xml-files\sampl02.xml"))
    {
        var members = (Member)xmlSerializer.Deserialize(reader);
    }
}

static void DeserializeXmlStringToObject(string xmlString)
{
    var xmlSerializer = new XmlSerializer(typeof(Member));
    using (var reader = new StreamReader(xmlString))
    {
        var member = (Member)xmlSerializer.Deserialize(reader);
    }
}