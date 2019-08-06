using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PersonalizarControl.iOS.Controls;
using PersonalizarControl.Controls;
using CoreGraphics;
using System.ComponentModel;

[assembly:ExportRenderer(typeof(CustomBoxView),typeof(CustomBoxViewRenderer))]
namespace PersonalizarControl.iOS.Controls
{
    public class CustomBoxViewRenderer:BoxRenderer
    {
       
        public override void Draw(CGRect rect)
        {
            //base.Draw(rect);
            CustomBoxView control = (CustomBoxView)Element;
            using(var context = UIGraphics.GetCurrentContext())
            {
                context.SetStrokeColor(new CGColor(0, 0, 0));
                context.SetLineWidth((float)control.Espessura);

                var recPath = new CGRect(0,0,200,200);

                context.AddRect(recPath);
                context.DrawPath(CGPathDrawingMode.Stroke);
            }

        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == CustomBoxView.EspessuraProperty.PropertyName)
            {
                SetNeedsDisplay();
            }
            //base.OnElementPropertyChanged(sender, e);
            
        }
    }
}