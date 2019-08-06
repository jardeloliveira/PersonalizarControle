using Xamarin.Forms;

namespace PersonalizarControl.Controls
{
    public class CustomBoxView : BoxView
    {
        public static readonly BindableProperty EspessuraProperty = BindableProperty.Create<CustomBoxView,double>(
                p=>p.Espessura, default(double)
            );
        public double Espessura
        {
            get { return (double)GetValue(EspessuraProperty); }
            set { SetValue(EspessuraProperty, value); }
        }

    }
}
