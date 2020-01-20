using System;
using System.Collections.Generic;
using System.Text;
using SuggestionESPE.Models;
using SuggestionESPE.Interfaces;

namespace SuggestionESPE.Controllers
{
    class LoginController
    {
        public bool CheckInformation(User EspeUser)
        {
            if(EspeUser.UserName == "srdel" && EspeUser.UserPass=="santyr5442")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
