using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using MyDietSchedule.CustomFormElements;
using MyDietSchedule.iOS.CustomFormElements;

[assembly: ExportRenderer(typeof(ImageCircle), typeof(ImageCircleRenderer))]
namespace MyDietSchedule.iOS.CustomFormElements
{
    public class ImageCircleRenderer : ImageRenderer
    {
        public ImageCircleRenderer()
        {
        }

        public static void Init()
        {
            var temp = DateTime.Now;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);

            if (Element == null)
            {
                return;
            }
            CreateCircle();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == ImageCircle.HeightProperty.PropertyName ||
                e.PropertyName == ImageCircle.WidthProperty.PropertyName ||
                e.PropertyName == ImageCircle.BorderColorProperty.PropertyName || 
                e.PropertyName == ImageCircle.BorderThicknessProperty.PropertyName ||
                e.PropertyName == ImageCircle.FillColorProperty.PropertyName)
            {
                CreateCircle();
            }
        }

        private void CreateCircle()
        {
            try
            {
                var min = Math.Min(Element.Width, Element.Height);
                Control.Layer.CornerRadius = (float)(min / 2.0);
                Control.Layer.MasksToBounds = false;
                Control.Layer.BorderColor = ((ImageCircle)Element).BorderColor.ToCGColor();
                Control.Layer.BorderWidth = ((ImageCircle)Element).BorderThickness;
                Control.BackgroundColor = ((ImageCircle)Element).FillColor.ToUIColor();
                Control.ClipsToBounds = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Unable to create circle image: " + ex);
            }
        }
    }
}
