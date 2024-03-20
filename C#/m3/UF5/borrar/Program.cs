using System;
using EasterEggCharacter;
using System;
using System.Xml;
using System.Xml.Linq;

namespace EasterEgg
{
    public class Program
    {
        public static void Main()
        {
            const string RabbitArt = @"      / \
                                            / _ \
                                           | / \ |
                                           ||   || _______
                                           ||   || |\     \
                                           ||   || ||\     \
                                           ||   || || \    |
                                           ||   || ||  \__/
                                           ||   || ||   ||
                                            \\_/ \_/ \_//
                                           /   _     _   \
                                          /               \
                                          |    O     O    |
                                          |   \  ___  /   |                           
                                         /     \ \_/ /     \
                                        /  -----  |  --\    \
                                        |     \__/|\__/ \   |
                                        \       |_|_|       /
                                         \_____       _____/
                                               \     /
                                               |     |";
            const string Menu = "EasterEgg:\n" + "[1]CREAR PERSONATGE \n " + "[2]LLEGIR PERSONATGES \n " + "[3]ACTUALITZAR PERSONATGES \n ";
            string name = " ";
            int function;
            int id = 1, level = 1, hp = 50, atack = 20, defense = 25;

            Console.WriteLine(RabbitArt);
            Console.WriteLine(Menu);
            //do
            //{
                function = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

            //} while (function != 1 || function != 2 || function != 3 );

            switch (function)
            {
                case 1:
                    Console.WriteLine("Introdueix el nom del personatge: ");
                    name = Console.ReadLine();
                    Character characterOne = new Character(id, name, level, hp, atack, defense);
                    XMLHelpers.CreateXMLFileWithLINQ(characterOne);

                    break;

                case 2:
                    XMLHelpers.ReadXMLFileWithLINQ();
                    break;

                case 3:
                    
                    //ACTUALITZAR PERSONATGES XMLHELPER
                    break;

                default:

                    break;

            }
        }
    }
}

