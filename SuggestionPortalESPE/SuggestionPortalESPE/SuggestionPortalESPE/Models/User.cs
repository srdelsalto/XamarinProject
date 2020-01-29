using System;
using System.Collections.Generic;
using System.Text;

namespace SuggestionPortalESPE.Models
{
    public class User
    {

        public string User_Name { get; set; }
        public string User_Pass { get; set; }
        public User(string text1, string text2)
        {
            this.User_Name = text1;
            this.User_Pass = text2;
        }
    }
}
