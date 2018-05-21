using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;

namespace API_testing51
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }


        public async void API_call_converterAsync(Button button)
        {
            string Bname = button.Text.Replace(" ", "%20");
            string API_key = "0569675f8e13a45a05a936752b66fc04";

            var client = new HttpClient();
            //Get response API
            HttpResponseMessage response = await client.GetAsync("http://food2fork.com/api/search?key=" + API_key + "&q=" + Bname);
            //Select content of the response
            HttpContent content = response.Content;
            //Set to string
            var json = await content.ReadAsStringAsync();
            //Set to json-object
            var JsonToString = JsonConvert.DeserializeObject<dynamic>(json);
            //Read the json-object
            var Select = JsonToString["recipes"][0]["title"];
            Select.Replace("&amp;", "&");
            Label1.Text = Select;
        }

        

        public void Shredded_Chicken_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            API_call_converterAsync(button);
        }

        public void Garlic_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            API_call_converterAsync(button);
        }

        public void Cooked_Pork_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            API_call_converterAsync(button);
        }
    }
}