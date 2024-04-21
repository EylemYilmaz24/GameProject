using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITES.Abstracts
{
    public abstract class BaseChar:IChar
    {
        public int ID { get; set; }

        public string CharName { get; set; }

        public int Healty { get; set; }

        public int Speed { get; set; }

        public int Power { get; set; }

        public LevelEnum Level { get; set; }
        public CharClassEnum CharClass { get; set; }
        public NationEnum Nation { get; set; }
    }
}
