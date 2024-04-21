using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITES.Models
{
    public class Profile
    {
        public int ID { get; set; }
        
        
        public List<Character> Characters { get; set; }
        public List<User> Users { get; set; }


    }
}
