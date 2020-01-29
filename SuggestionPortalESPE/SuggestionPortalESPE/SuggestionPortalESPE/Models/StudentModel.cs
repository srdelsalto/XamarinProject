using System;
using System.Collections.Generic;
using System.Text;

namespace SuggestionPortalESPE.Models
{
    public class StudentModel
    {
        public String Name { get; set; }
        public String Last_Name { get; set; }
        public String CI { get; set; }
        public String CompleteName { get; set; }
        public String Id_Espe { get; set; }
        public String User_Name { get; set; }
        public String User_Pass { get; set; }
        public StudentModel(StudentModel MainStudent)
        {
            Name = MainStudent.Name;
            Last_Name = MainStudent.Last_Name;
            CI = MainStudent.CI;
            Id_Espe = MainStudent.Id_Espe;
            User_Name = MainStudent.User_Name;
            User_Pass = MainStudent.User_Pass;

            CompleteName = Name + " " + Last_Name;
        }

        public StudentModel(String username, String password)
        {
            User_Name = username;
            User_Pass = password;
        }

        public StudentModel(){}

        public StudentModel(String name, String lastName, String ci, String idespe, String username, String password)
        {
            Name = name;
            Last_Name = lastName;
            CI = ci;
            Id_Espe = idespe;
            User_Name = username;
            User_Pass = password;
            
            CompleteName = Name + " " + Last_Name;
        }



        public StudentModel fillData() //METHOD TO FILL SOME DATA JUST TO TRY MAIN PAGE
        {
            StudentModel ModelStudent = new StudentModel("Santiago", "Del Salto", "1724567522", "L00368497","srdel", "santyr5442");
            ModelStudent.CompleteName = Name + " " + Last_Name;

            return ModelStudent;
        }
    }
}
