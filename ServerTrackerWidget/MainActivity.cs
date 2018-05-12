using Android.App;
using Android.Widget;
using Android.OS;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace ServerTrackerWidget
{
    [Activity(Label = "Server Tracker Widget", MainLauncher = true, Icon = "@drawable/android")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //8.8.8.8 (Google DNS)
            if (new ServerTest().Ping("8.8.8.8") == IPStatus.Success)
                Toast.MakeText(this, "It worked", ToastLength.Long).Show();

            //Finish();
        }
    }
}