using ENTITES.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITES.Models
{
    public class Character:BaseChar
    {
        public Character()
        {
            if (Nation == NationEnum.Human)
            {
                Speed = 80;
                Power = 90;
                Healty = 75;
            }
            if (Nation == NationEnum.Elf)
            {
                Speed = 55;
                Power = 85;
                Healty = 100;
            }
            if(Nation==NationEnum.Dwarf)
            {
                Speed = 100;
                Power = 75;
                Healty = 65;
            }
        }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
