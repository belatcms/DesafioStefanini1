using DesafioStefanini2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesafioStefanini2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        private const string Url = "http://api.openweathermap.org/data/2.5/weather?id={0}&appid={1}&lang=pt&units=metric";
        private readonly HttpClient _client = new HttpClient();

        private ObservableCollection<Datum> _cidades;

        public Detail(int Id)
        {
            InitializeComponent();
        }
        public Detail()
        {
            InitializeComponent();
        }
        //Alimentando o listView
        async override protected void OnAppearing()
        {
            base.OnAppearing();
            //_cidades = new ObservableCollection<Datum>(Id);
            //DetalheCidades.ItemsSource = _cidades;
            base.OnAppearing();
        }
    }
}