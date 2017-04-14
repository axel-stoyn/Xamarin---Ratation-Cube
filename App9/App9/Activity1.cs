using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App9
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        GLView1 view;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            view = new GLView1(this);
            SetContentView(view);
        }
    }
}