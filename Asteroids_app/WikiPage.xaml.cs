using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

using System.Net.Http;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Data;

namespace Asteroids_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WikiPage : ContentPage
    {
        public static ObservableCollection<DangerousObject> VesmirnaCollection = new ObservableCollection<DangerousObject>();
        public WikiPage()
        {
            InitializeComponent();
            SortingList();
            GetJson();
            VesmirneObjListView.ItemsSource = VesmirnaCollection;
        }

        static async Task GetJson()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://api.nasa.gov/neo/rest/v1/feed?" +
                "start_date=2022-10-30&end_date=2022-10-31" +
                "&api_key=6gl9t1NwwZCNsT3KPHBSsQplH8n0F07xQ0we9Gdd");

            var content = await response.Content.ReadAsStringAsync();

            JObject asteroids = JObject.Parse(content);

            JArray asteroidsData = (JArray)asteroids["near_earth_objects"]["2022-10-31"];
            for (int i = 0; i < asteroidsData.Count; i++)
            {
                DangerousObject dObj = asteroidsData[i].ToObject<DangerousObject>();
                VesmirnaCollection.Add(dObj);
            }

            asteroidsData = (JArray)asteroids["near_earth_objects"]["2022-10-30"];
            for (int i = 0; i < asteroidsData.Count; i++)
            {
                DangerousObject dObj = asteroidsData[i].ToObject<DangerousObject>();
                VesmirnaCollection.Add(dObj);
            }

        }
        private void InfoButton_Clicked(object sender, EventArgs e)
        {
            ImageButton b = sender as ImageButton;
            VesmirnyObjektPage.vesmirnyObjektNow = b.CommandParameter as DangerousObject;
            Navigation.PushAsync(new VesmirnyObjektPage());
        }


        // SORT
        List<string> sortList = new List<string>();
        public void SortingList()
        {
            sortList.Add("Název");
            sortList.Add("ID");
            sortList.Add("Jasnost");

            foreach (var item in sortList)
            {
                MainPicker.Items.Add(item);
            }
        }

        public void Sorting(string s)
        {
            var sorted = new List<DangerousObject>();
            switch (s)
            {
                case "ID":
                    if (ByPicker.SelectedIndex == 0) { sorted = VesmirnaCollection.OrderBy(x => x.Id).ToList(); }
                    else if (ByPicker.SelectedIndex == 1) { sorted = VesmirnaCollection.OrderByDescending(x => x.Id).ToList(); }
                    break;
                case "Jasnost":
                    if (ByPicker.SelectedIndex == 0) { sorted = VesmirnaCollection.OrderBy(x => x.Absolute_magnitude_h).ToList(); }
                    else if (ByPicker.SelectedIndex == 1) { sorted = VesmirnaCollection.OrderByDescending(x => x.Absolute_magnitude_h).ToList(); }
                    break;
                case "Název":
                    if (ByPicker.SelectedIndex == 0) { sorted = VesmirnaCollection.OrderBy(x => x.Name).ToList(); }
                    else if (ByPicker.SelectedIndex == 1) { sorted = VesmirnaCollection.OrderByDescending(x => x.Name).ToList(); }
                    break;

            }
            VesmirneObjListView.ItemsSource = sorted;
        }

        private void SortingBut_Clicked(object sender, EventArgs e)
        {
            if (MainPicker.SelectedIndex >= 0 && ByPicker.SelectedIndex >= 0)
            {
                int selected = MainPicker.SelectedIndex;
                Sorting(sortList[selected]);
            }
        }
        // SORT
    }

    public class DangerousObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Is_potentially_hazardous_asteroid { get; set; }
        public double kilometers_per_hour { get; set; }
        public string Nasa_jpl_url { get; set; }
        public double Absolute_magnitude_h { get; set; }
    } 

}