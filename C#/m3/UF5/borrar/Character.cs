using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using EasterEggCharacter;
using System;
using System.Xml;
using System.Xml.Linq;

namespace EasterEggCharacter
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int Atack {  get; set; }
        public int Defense { get; set;}

        public Character(int id, string name, int level, int hp, int atack, int defense)
        {
            Id = id;
            Name = name;
            Level = level;
            HP = hp;
            Atack = atack;
            Defense = defense;
        }
    }
}
