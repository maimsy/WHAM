using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class About : Page
    {
        public About()
        {
            this.InitializeComponent();
            List<RootObject> fb = new List<RootObject>();
            fb.Add(new RootObject { description = "sfsdf" });
            DescriptionBox.DataContext = fb;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

         
            public class Cover
            {
                public long cover_id { get; set; }
                public string source { get; set; }
                public int offset_y { get; set; }
            }

            public class RootObject
            {
                public string about { get; set; }
                public string description { get; set; }
                public bool is_published { get; set; }
                public int talking_about_count { get; set; }
                public string username { get; set; }
                public int were_here_count { get; set; }
                public string category { get; set; }
                public string id { get; set; }
                public string name { get; set; }
                public string link { get; set; }
                public int likes { get; set; }
                public Cover cover { get; set; }
            }
        
        
    }
}
