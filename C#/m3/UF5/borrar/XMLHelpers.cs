using System;
using System.Xml.Linq;
using System.Xml;
using System;
using EasterEggCharacter;
using System;

namespace EasterEgg
{
    public class XMLHelpers
    {
        public static void ReadXMLFileWithLINQ()
        {
            string xmlFilePath = "new_character.xml";
            XDocument xmlDoc = XDocument.Load(xmlFilePath);

            var characters = from character in xmlDoc.Descendants("character")
                select new
                {
                    Id = character.Attribute("id") != null ? (int)character.Attribute("id") : 0,
                    Name = (string)character.Element("Name"),
                    Level = (int)character.Element("Level"),
                    HP = (int)character.Element("HP"),
                    Atack = (int)character.Element("Atack"),
                    Defense = (int)character.Element("Defense")
                };

            foreach (var character in characters)
            {
                Console.WriteLine($"Id: {character.Id}");
                Console.WriteLine($"Name: {character.Name}");
                Console.WriteLine($"Level: {character.Level}");
                Console.WriteLine($"HP: {character.HP}");
                Console.WriteLine($"Atack: {character.Atack}");
                Console.WriteLine($"Defense: {character.Defense}");
                Console.WriteLine();
            }
        }

        public static void CreateXMLFileWithLINQ(Character character)
        {
            XDocument xmlDoc = new XDocument(
                new XElement("characters",
                    new XElement("character",
                        new XAttribute("Id", character.Id),
                        new XElement("Name", character.Name),
                        new XElement("Level", character.Level),
                        new XElement("HP", character.HP),
                        new XElement("Atack", character.Atack),
                        new XElement("Defense", character.Defense)
                    )
                )
            );

            string xmlFilePath = "new_character.xml";
            xmlDoc.Save(xmlFilePath);

            Console.WriteLine("Personajes creados correctamente!");
        }

        /*

        public static void UpdateXML() 
        {
            string xmlFilePath = "new_character.xml";
            Console.WriteLine("XML inicial:");
            ReadXMLFileWithLINQ();
            Console.WriteLine();
            Console.WriteLine("Introduce el ID del personaje que quieras actualizar:");
            string id ="";
            id = Console.ReadLine();

            try
            {
                // Carga el documento XML
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                // Busca el elemento por su ID
                XmlNode node = xmlDoc.SelectSingleNode($"//*[@id='{idElemento}']");

                // Si el elemento existe, actualiza su valor
                if (node != null)
                {
                    node.InnerText = nuevoValor;

                    // Guarda los cambios en el archivo XML
                    xmlDoc.Save(filePath);
                    Console.WriteLine("Valor del elemento actualizado correctamente.");
                }
                else
                {
                    Console.WriteLine("Elemento con el ID especificado no encontrado en el archivo XML.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el valor del elemento XML: " + ex.Message);
            }

        */


        }
    }
//}

