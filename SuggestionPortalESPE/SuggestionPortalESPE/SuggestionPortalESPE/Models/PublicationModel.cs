﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SuggestionPortalESPE.Models
{
    public class PublicationModel
    {
        public int Lepub_Id { get; set; }
        public int Lepub_Anonymous { get; set; }
        public int Lepub_Complaint { get; set; }
        public String Lepub_Messag { get; set; }
        public String Lepub_Type { get; set; }
        public int Letop_Id { get; set; }
        public String Leuser_IdEspe { get; set; }

    }
}
