using SuggestionPortalESPE.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SuggestionPortalESPE.API
{
    public class UserApiConsumption
    {
        private String Url = "http://3.135.186.13:3001/students/";
        public List<User> Users = new List<User>();
        public List<StudentModel> Students = new List<StudentModel>();

        public UserApiConsumption()
        {
            this.Url = "http://3.135.186.13:3001/students/";
            Users = new List<User>();
            Students = new List<StudentModel>();
    }

        public List<User> getUsers()
        {
            var json = new WebClient().DownloadString(Url);
            dynamic result = JsonConvert.DeserializeObject(json);
            User usuario;
            foreach(var i in result)
            {
                usuario = new User((string)i.user_name, (string)i.user_pass);
                Users.Add(usuario);
            }
            return Users;
        }

        public List<StudentModel> getStudent()
        {
            var json = new WebClient().DownloadString(Url);
            dynamic result = JsonConvert.DeserializeObject(json);
            StudentModel estudiante;
            foreach (var i in result)
            {
                estudiante = new StudentModel((string)i.name, (string)i.last_name, (string)i.ci, (string)i.id_espe, (string)i.user_name, (string)i.user_pass);
                Students.Add(estudiante);
            }
            return Students;
        }
    }
}
