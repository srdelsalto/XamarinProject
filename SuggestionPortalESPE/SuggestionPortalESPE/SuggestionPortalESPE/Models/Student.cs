using System;
using System.Collections.Generic;
using System.Text;

namespace SuggestionPortalESPE.Models
{
    public class Student
    {
        public String Name { get; set; }
        public String LastName { get; set; }
        public String CI { get; set; }
        public User UserESPE { get; set; }
        public String CompleteName { get; set; }

        public Student(Student MainStudent)
        {
            Name = MainStudent.Name;
            LastName = MainStudent.LastName;
            CI = MainStudent.CI;
            UserESPE = MainStudent.UserESPE;
            CompleteName = Name + " " + LastName;
        }

        public Student(String name, String lastName, String ci, User user)
        {
            Name = name;
            LastName = lastName;
            CI = ci;
            UserESPE = user;
            CompleteName = Name + " " + LastName;
        }

        public Student() { }

        public Student fillData() //METHOD TO FILL SOME DATA JUST TO TRY MAIN PAGE
        {
            Student ModelStudent = new Student("Santiago", "Del Salto", "1724567522", new User("srdel", "santyr5442"));
            ModelStudent.CompleteName = Name + " " + LastName;

            return ModelStudent;
        }
    }
}
