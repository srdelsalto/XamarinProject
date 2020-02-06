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
        private const String Url = "http://3.135.186.13:3001/publications/";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<PublicationModel> _publication;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            String content = await client.GetStringAsync(Url);
            List<PublicationModel> publications = JsonConvert.DeserializeObject<List<PublicationModel>>(content);
            _publication = new ObservableCollection<PublicationModel>(publications);
            DataListView.ItemsSource = _publication;
            base.OnAppearing();
        }
    }
}
