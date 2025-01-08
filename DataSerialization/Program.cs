using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Serialization;

namespace DataSerialization
{
    /// <summary>
    /// 
    /// </summary>
    public class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Book book1 = new Book { ISBN = 107 , Title = "Atomic Habits" , Author = "James Clear" };

            string jsonBook1 = JsonConvert.SerializeObject(book1);
            
            Console.WriteLine($"book1 object in JSON : {jsonBook1}");

            Console.WriteLine();

            Book deserializedBook1 = JsonConvert.DeserializeObject<Book>(jsonBook1);

            Console.WriteLine($"Deserialized book1 object : ");
            Console.WriteLine(deserializedBook1.ISBN);
            Console.WriteLine(deserializedBook1.Title);
            Console.WriteLine(deserializedBook1.Author);

            Console.WriteLine();

            string jsonBook2 = "{\"ISBN\":107,\"Title\":\"Atomic Habits\",\"Author\":\"James Clear\",\"Price\":999}";

            JObject book2 = JObject.Parse(jsonBook2);
            int isbn = (int)book2["ISBN"];
            string title = (string)book2["Title"];
            string author = (string)book2["Author"];
            int price = (int)book2["Price"];

            Console.WriteLine($"Custom object :");
            Console.WriteLine($"isbn : {isbn}");
            Console.WriteLine($"title : {title}");
            Console.WriteLine($"author : {author}");
            Console.WriteLine($"price : {price}");

            Console.WriteLine();

            string jsonBookArr = "[{\"ISBN\":107,\"Title\":\"Atomic Habits\",\"Author\":\"James Clear\"},{\"ISBN\":109,\"Title\":\"One Piece\",\"Author\":\"Ichiro Oda\"}]";

            JArray bookArr = JArray.Parse(jsonBookArr);
            bookArr.ToList();
            Console.WriteLine("string to JSON array : ");
            foreach( var item in bookArr ) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            List<Book> books = new List<Book>
            {
                new Book { ISBN = 101 , Title = "Book101" , Author = "Author101"},
                new Book { ISBN = 102 , Title = "Book102" , Author = "Author102"},
                new Book { ISBN = 103 , Title = "Book103" , Author = "Author103"}
            };

            string path = @"F:\Keyur-417\Code\CsharpAdvance\DataSerialization\books.xml";

            XmlSerializer xs = new XmlSerializer(typeof(List<Book>));

            using(FileStream fs = new FileStream(path,FileMode.Create))
            {
                xs.Serialize(fs, books);
                Console.WriteLine("Books List serialize to XMl file books.xml");
            }

            List<Book> deserializedXMLBooks = new List<Book>();

            using(FileStream fs = new FileStream(path, FileMode.Open))
            {
                deserializedXMLBooks = (List<Book>)xs.Deserialize(fs);
                Console.WriteLine("Books List deserialized from XMl file to List of books");
            }

            foreach(var item in deserializedXMLBooks)
            {
                Console.WriteLine(item);
            }

        }
    }
}