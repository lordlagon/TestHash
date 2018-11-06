using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hash.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Passwordhash { get; set; }
        public string Email { get; set; }
    }
}
