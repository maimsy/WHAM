 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Windows.Data.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.ApplicationModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        //private readonly FacebookClient _fb = new FacebookClient();
        private string _GroupId;

        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override  void OnNavigatedTo(NavigationEventArgs e)
        { 
            //dynamic parameter = e.Parameter;
            //_fb.AccessToken = parameter.access_token;
            //_GroupId = parameter.id;
            //string url = "http://graph.facebook.com/whamfi/";

            string PictureUrl = string.Format("https://graph.facebook.com/whamfi/picture?type=square&access_token?=AAAE377gfRI4BALsx2pV27oR4n75kDZAc8MmV6PH1FBg9VLCvQoBHqW6oP5FuJML2Hv3x8YeNOnriGXkbDwIUW3pDTSWcfKNI7Hu5gqwZDZD");
            IMAGE.Source = new BitmapImage(new Uri(PictureUrl));
            LoadData_Pics();
            
             
        }

          private static void CreateRecipesAndRecipeGroups(JsonArray array)
        {
              

            //List<Datum> listColl = new List<Datum>();
            //foreach (Datum b in array)
            //{
            //    listColl.Add(new Datum {  source= b.source  });
            //}
            
           
         }
        

        public async void LoadData_Pics() 
        {

            var o = JObject.Parse(yourJsonString);

            foreach (JToken child in o.Children())
            {
                foreach (JToken grandChild in child)
                {
                    foreach (JToken grandGrandChild in grandChild)
                    {
                        var property = grandGrandChild as JProperty;

                        if (property != null)
                        {
                            Console.WriteLine(property.Name + ":" + property.Value);
                        }
                    }
                }
            }

            /*
            var client = new HttpClient();
var response = await client.GetStringAsync(new Uri("https://graph.facebook.com/whamfi/photos?type=uploaded"));

var obj = JsonObject.Parse(response);
var manga = obj["manga"] as  JsonArray;
            */ 
             // Convert the JSON objects into RecipeDataItems and RecipeDataGroups
            CreateRecipesAndRecipeGroups(manga);
             

            /*var Url = string.Format("https://graph.facebook.com/whamfi/photos?type=uploaded");
            HttpClient hc = new HttpClient();
            HttpResponseMessage  responseStream = await hc.GetAsync(Url);*/
          
            //HttpResponseMessage response = await hc.GetAsync(Url);

       /* var hn = JsonArray.Parse(responseStream); */
             
            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Datum));
            //List<Datum> list = serializer.ReadObject(hn) as List<Datum>;
             
          /*  List<Datum> listColl = new List<Datum>();
            foreach (Datum b in hn)
            { 
                    listColl.Add(new Datum { source = b.source });
            }
            this.listboxGall.DataContext = listColl;
        */

        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(About));
        }



     

       public class From
       {
           public string category { get; set; }
           public string name { get; set; }
           public string id { get; set; }
       }

       public class Image
       {
           public int height { get; set; }
           public int width { get; set; }
           public string source { get; set; }
       }

       public class Location
       {
           public string street { get; set; }
           public string city { get; set; }
           public string state { get; set; }
           public string country { get; set; }
           public string zip { get; set; }
           public double latitude { get; set; }
           public double longitude { get; set; }
       }

       public class Place
       {
           public string id { get; set; }
           public string name { get; set; }
           public Location location { get; set; }
       }

       public class Datum2
       {
           public string id { get; set; }
           public string name { get; set; }
       }

       public class Paging
       {
           public string next { get; set; }
       }

       public class Likes
       {
           public List<Datum2> data { get; set; }
           public Paging paging { get; set; }
       }

       public class Datum
       {
           public string id { get; set; }
           public From from { get; set; }
           public string name { get; set; }
           public string picture { get; set; }
           public string source { get; set; }
           public int height { get; set; }
           public int width { get; set; }
           public List<Image> images { get; set; }
           public string link { get; set; }
           public string icon { get; set; }
           public string created_time { get; set; }
           public string updated_time { get; set; }
           public Place place { get; set; }
           public Likes likes { get; set; }
       }

       public class Paging2
       {
           public string next { get; set; }
       }

       public class RootObject
       {
           public List<Datum> data { get; set; }
           public Paging2 paging { get; set; }
       }
             

    }
}
