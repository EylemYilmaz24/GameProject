using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITES.Abstracts
{
    public interface IChar
    {
        public CharClassEnum CharClass { get; set; }

        public NationEnum Nation { get; set; }


    }
}
