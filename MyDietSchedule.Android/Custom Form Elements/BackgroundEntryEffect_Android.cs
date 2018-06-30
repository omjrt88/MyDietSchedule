using System;
using Android.Graphics;
using Android.Graphics.Drawables;
using MyDietSchedule.Droid.Effects;
using MyDietSchedule.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("FlyingEverywhere")]
[assembly: ExportEffect(typeof(BackgroundEntryEffect_Android), "BackgroundEffect")]
namespace MyDietSchedule.Droid.CustomFormElements
{
    public class BackgroundEntryEffect_Android
    {
        public BackgroundEntryEffect_Android()
        {
        }
    }
}
