using System;
using System.Collections.Generic;
using System.Text;
using SuggestionPortalESPE.Models;
using SuggestionPortalESPE.API;
using System.Diagnostics;

namespace SuggestionPortalESPE.Controller
{
    public class LoginController
    {
        public StudentModel CheckInformation(User student)
        {
            UserApiConsumption User_Api = new UserApiConsumption();

            List<User> students = User_Api.getUsers();

            Boolean flag = false ;
            int position = 0;

            for (int i=0; i < students.Count; i++)
            {
                if (students[i].User_Name == student.User_Name && students[i].User_Pass == student.User_Pass)
                {
                    flag = true;
                    position = i;
                }          
            }
            if (flag)
            {
                List<StudentModel> estudiantes = User_Api.getStudent();
                return estudiantes[position];
            }


            return null;
        }
    }
}
