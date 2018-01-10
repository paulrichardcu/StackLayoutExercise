using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StackLayoutExercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exercise8 : ContentPage
	{
        private int ctr=1;
		public Exercise8 ()
		{
			InitializeComponent ();
		}

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            if (ctr>1)
            {
                ctr = ctr - 1;
            }
            imgSrc.Source = new UriImageSource
            {
                Uri = new Uri("http://placeimg.com/1920/1080/any/" + ctr),CachingEnabled = false, CacheValidity = TimeSpan.FromHours(1)
            };
            //DisplayAlert(ctr.ToString(), imgSrc.Source.ToString().ToString(), "hello");
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (ctr < 10)
            {
                ctr = ctr + 1;
            }
            imgSrc.Source = new UriImageSource
            {
                Uri = new Uri("http://placeimg.com/1920/1080/any/" + ctr),
                CachingEnabled = false,
                CacheValidity = TimeSpan.FromHours(1)
            };
            //DisplayAlert(ctr.ToString(), imgSrc.Source.ToString(), "hello");
        }

        protected override void OnAppearing()
        {
            imgSrc.Source = new UriImageSource
            {
                Uri = new Uri("http://placeimg.com/1920/1080/any/1"),
                CachingEnabled = false,
                CacheValidity = TimeSpan.FromHours(1)
            };
        }




    }
}