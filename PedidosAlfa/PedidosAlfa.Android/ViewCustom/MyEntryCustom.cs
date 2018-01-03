using Android.Graphics.Drawables;
using PedidosAlfa.Droid.ViewCustom;
using PedidosAlfa.ViewsCustom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryCustom))]
namespace PedidosAlfa.Droid.ViewCustom
{
    class MyEntryCustom : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                //Control.SetBackgroundResource(Resource.Layout.rounded_shape);
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(60f);
                gradientDrawable.SetStroke(2 , Android.Graphics.Color.Black);
                gradientDrawable.SetColor(Android.Graphics.Color.ParseColor("#FFFFFF"));//color en Hex
                Control.SetHintTextColor(global::Android.Graphics.Color.Rgb(182, 182, 182));// color en rgb
                Control.SetBackground(gradientDrawable);

                Control.SetPadding(50, 35, Control.PaddingRight,5);
            }
        }

    }
}