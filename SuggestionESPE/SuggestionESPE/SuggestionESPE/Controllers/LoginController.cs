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
            if(EspeUser.UserName == null)
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
