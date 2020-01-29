using SuggestionPortalESPE.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SuggestionPortalESPE
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private const String Url = "https://192.168.100.63:3000/students/";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<User> _publication;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            String content = await client.GetStringAsync(Url);
            List<User> publications = JsonConvert.DeserializeObject<List<User>>(content);
            _publication = new ObservableCollection<User>(publications);
            DataListView.ItemsSource = _publication;
            base.OnAppearing();
        }
    }
}
