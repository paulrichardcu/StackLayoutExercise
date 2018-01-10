using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Button = Xamarin.Forms.Button;
using StackLayoutExercise;
using StackLayoutExercise.Droid;

[assembly: ExportRenderer(typeof(RoundButtons), typeof(RoundButtons_DRIOD))]
namespace StackLayoutExercise.Droid
{
    internal class RoundButtons_DRIOD : ButtonRenderer
    {
        public RoundButtons_DRIOD(Context context): base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control == null) return;
            var gradientDrawable = new GradientDrawable();
            gradientDrawable.SetShape(ShapeType.Rectangle);
            gradientDrawable.SetColor(Element.BackgroundColor.ToAndroid(Color.FromRgb(255, 215, 0)));
            gradientDrawable.SetStroke(4, Element.BorderColor.ToAndroid());
            gradientDrawable.SetCornerRadius(30.0f);
            Control.SetBackground(gradientDrawable);


        }
    }
}