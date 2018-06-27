﻿using System;
using System.ComponentModel;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using MyDietSchedule.CustomFormElements;
using MyDietSchedule.Droid.CustomFormElements;

[assembly: ExportRenderer(typeof(ImageCircle), typeof(ImageCircleRenderer))]
namespace MyDietSchedule.Droid.CustomFormElements
{
    [Preserve(AllMembers = true)]
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
            if (e.OldElement == null)
            {
                if ((int)Android.OS.Build.VERSION.SdkInt < 21)
                {
                    SetLayerType(LayerType.Software, null);
                }
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == ImageCircle.BorderColorProperty.PropertyName ||
                e.PropertyName == ImageCircle.BorderThicknessProperty.PropertyName || 
                e.PropertyName == ImageCircle.FillColorProperty.PropertyName)
            {
                this.Invalidate();
            }
        }

        protected override bool DrawChild(Canvas canvas, Android.Views.View child, long drawingTime)
        {
            try
            {
                var radius = Math.Min(Width, Height / 2);
                var borderThickness = (float)((ImageCircle)Element).BorderThickness;
                int strokeWidth = 0;

                if (borderThickness > 0)
                {
                    var logicalDensity = Xamarin.Forms.Forms.Context.Resources.DisplayMetrics.Density;
                    strokeWidth = (int)Math.Ceiling(borderThickness * logicalDensity + 0.5f);
                }

                radius -= strokeWidth / 2;
                var path = new Path();
                path.AddCircle(Width / 2.0f, Height / 2.0f, radius, Path.Direction.Ccw);
                canvas.Save();
                canvas.ClipPath(path);
                var paint = new Paint();
                paint.AntiAlias = true;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color = ((ImageCircle)Element).FillColor.ToAndroid();
                canvas.DrawPath(path, paint);
                paint.Dispose();

                var result = base.DrawChild(canvas, child, drawingTime);
                canvas.Restore();


                path = new Path();
                path.AddCircle(Width / 2, Height / 2, radius, Path.Direction.Ccw);
                if (strokeWidth > 0.0f)
                {
                    paint = new Paint();
                    paint.AntiAlias = true;
                    paint.StrokeWidth = strokeWidth;
                    paint.SetStyle(Paint.Style.Stroke);
                    paint.Color = ((ImageCircle)Element).BorderColor.ToAndroid();
                    canvas.DrawPath(path, paint);
                    paint.Dispose();
                }
                path.Dispose();
                return result;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Unable to create circle image: " + ex);
            }
            return base.DrawChild(canvas, child, drawingTime);
        }
    }
}
 