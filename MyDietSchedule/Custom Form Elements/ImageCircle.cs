using Xamarin.Forms;

namespace MyDietSchedule.CustomFormElements
{
    public class ImageCircle : Image
    {
        public string CircleName { get; set; }

        public int BorderThickness 
        { 
            get
            {
                return (int)GetValue(BorderThicknessProperty);
            }
            set
            {
                SetValue(BorderThicknessProperty, value);
            }
        }

        public Color BorderColor
        {
            get
            {
                return (Color)GetValue(BorderColorProperty);
            }
            set
            {
                SetValue(BorderColorProperty, value);
            }
        }

        public Color FillColor
        {
            get
            {
                return (Color)GetValue(FillColorProperty);
            }
            set
            {
                SetValue(FillColorProperty, value);
            }
        }

        public static readonly BindableProperty BorderThicknessProperty =
            BindableProperty.Create(
                propertyName: nameof(BorderThickness),
                returnType: typeof(int),
                declaringType: typeof(ImageCircle),
                defaultValue: 0
            );

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create(
                propertyName: nameof(BorderColor),
                returnType: typeof(Color),
                declaringType: typeof(ImageCircle),
                defaultValue: Color.Default
            );
        public static readonly BindableProperty FillColorProperty =
            BindableProperty.Create(
                propertyName: nameof(FillColor),
                returnType: typeof(Color),
                declaringType: typeof(ImageCircle),
                defaultValue: Color.Default
            );
    }
}
