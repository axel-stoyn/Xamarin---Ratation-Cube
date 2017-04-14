using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

namespace App9
{
    [Activity(Label = "App9", MainLauncher = true, Icon = "@drawable/icon")]

    public class MainActivity : Activity
    {
        TextView tvCounts1;
        Button btnAdd1;
        Button btnSubstract1;
        int counter1 = 0;

        TextView tvCounts2;
        Button btnAdd2;
        Button btnSubstract2;
        int counter2 = 0;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            tvCounts1 = FindViewById<TextView>(Resource.Id.tvCounts1);
            btnAdd1 = FindViewById<Button>(Resource.Id.btnAdd1);
            btnSubstract1 = FindViewById<Button>(Resource.Id.btnSubstract1);

            btnAdd1.Click += (object sender, System.EventArgs e) =>
            {
                if (counter1 != 3)
                {
                    counter1++; 
                    tvCounts1.Text = counter1.ToString();
                }
                else if (counter1 >= 3)
                {
                    tvCounts1.Text = "Only till 3";
                }
            };

            btnSubstract1.Click += (object sender, System.EventArgs e) =>
            {
                if (counter1 != 0)
                {
                    counter1--;
                    tvCounts1.Text = counter1.ToString();
                }
            };

            tvCounts2 = FindViewById<TextView>(Resource.Id.tvCounts2);
            btnAdd2 = FindViewById<Button>(Resource.Id.btnAdd2);
            btnSubstract2 = FindViewById<Button>(Resource.Id.btnSubstract2);

            btnAdd2.Click += (object sender, System.EventArgs e) =>
            {
                if (counter2 != 5)
                {
                    counter2++;
                    tvCounts2.Text = counter2.ToString();
                }
                else if (counter2 >= 5)
                {
                    tvCounts2.Text = "Only till 5";
                }
            };

            btnSubstract2.Click += (object sender, System.EventArgs e) =>
            {
                if (counter2 != 0)
                {
                    counter2--;
                    tvCounts2.Text = counter2.ToString();
                }
            };

            Button show = FindViewById<Button>(Resource.Id.Show);
            show.Click += delegate {
                StartActivity(typeof(Activity1));
            };
        }
    }
}

