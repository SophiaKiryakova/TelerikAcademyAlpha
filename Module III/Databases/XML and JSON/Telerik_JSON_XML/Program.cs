using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace Telerik_JSON_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            // JSON
            // Read all data from the movies.json file.
            var json = File.ReadAllText("../../resources/movies.json");

            // Create the appropriate objects to deserialize the data into.
            var movies = JsonConvert.DeserializeObject<List<Movie>>(json);

            // List all actors, sorted alphabetically.
            var actors = movies.SelectMany(movie => movie.Actors).OrderBy(actor => actor);

            Console.WriteLine(string.Join("\n", actors));


            // XML           
            // Load the shiporders.xml file into and XmlDocument class.
            XmlDocument doc = new XmlDocument();
            doc.Load("../../resources/shiporders.xml");

            XmlNode rootNode = doc.DocumentElement;
            Console.WriteLine("Root node: {0}", rootNode.Name);

            //Print information about all item elements
            foreach(XmlAttribute attribute in rootNode.Attributes)
            {
                Console.WriteLine($"Attribute: {attribute.Name} = {attribute.Value}");
            }
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                if(node.Name == "item")
                {
                    foreach(XmlNode childNode in node.ChildNodes)
                    {
                        Console.WriteLine($"{childNode.Name}: {childNode.InnerText}");
                    }
                }
            }
        }
    }
    public class Movie
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public string Director { get; set; }

        [JsonProperty("cast")]
        public List<string> Actors { get; set; }
    }
}
