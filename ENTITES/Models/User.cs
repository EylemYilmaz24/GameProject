﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITES.Models
{
    public class User
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int ProfileID { get; set; }

        public Profile Profile { get; set; }
    }
}
