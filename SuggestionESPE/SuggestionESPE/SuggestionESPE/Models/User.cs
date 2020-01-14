using System;
using System.Collections.Generic;
using System.Text;

namespace SuggestionESPE.Models
{
    public class User
    {
        public String UserName { get; set; }
        public String UserPass { get; set; }

        public User(String name, String pass)
        {
            UserName = name;
            UserPass = pass;
        }
    }
}
