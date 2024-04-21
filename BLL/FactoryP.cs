using ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FactoryP
    {
        public Character CharacterMethod(Character ch)
        {
            Character character= null;
            character=new Character();
            return character;
        }

        public User UserMethod(User us) 
        {
            User user=null;
            user=new User();
            return user;

        }
        public Profile ProfileMethod(Profile pr)
        {
            Profile profile=null;
            profile=new Profile();
            return profile;
        }



    }
}
