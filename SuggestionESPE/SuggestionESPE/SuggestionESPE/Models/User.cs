using System;
using System.Collections.Generic;
using System.Text;

namespace SuggestionESPE.Models
{
    public class User
    {
        public String Id { get; set; }
        public String UserName { get; set; }
        public String UserPass { get; set; }

        public User() { }
        public User(String name, String pass)
        {
            UserName = name;
            UserPass = pass;
        }
    }
}
