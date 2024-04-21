using MAPP.Contextt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SingletonP
    {
        private SingletonP() { }

        private static Contextt _context;

        public static Contextt Context 
        {
            get 
            {
                if(_context==null)
                    _context = new Contextt();
                return _context; 
            
            } 
        
        
        }

    }
}
