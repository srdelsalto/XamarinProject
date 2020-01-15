using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuggestionESPE.Models
{
    public class Token
    {
        public int Id { get; set; }
        public String Access_token { get; set; }
        public String Error_description { get; set; }
        public DateTime Expire_date { get; set; }

        public Token()
        {

        }
    }
}
