using System;
using System.Net;
using System.Net.Sockets;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DeskIO.Droid
{
	[Activity (Label = "DeskIO", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			EditText ipBox = FindViewById<EditText> (Resource.Id.ipEditBox);

			Button upButton = FindViewById<Button> (Resource.Id.upButton);
			upButton.Click += (object sender, EventArgs e) => {
				if(string.IsNullOrEmpty(ipBox.Text)) {
					return;
				}

				IPAddress deskAddress;
				if(!IPAddress.TryParse(ipBox.Text, out deskAddress)) {
					return;
				}

				var desk = new Desk(deskAddress);

				if(upButton.Text == "Stop") {
					desk.Stop();
					upButton.Text = "Up";
					return;
				}

				upButton.Text = "Stop";
				desk.Raise();
				desk.Disconnect();
			};

			Button downButton = FindViewById<Button> (Resource.Id.downButton);
			downButton.Click += (object sender, EventArgs e) => {
				if(string.IsNullOrEmpty(ipBox.Text)) {
					return;
				}

				IPAddress deskAddress;
				if(!IPAddress.TryParse(ipBox.Text, out deskAddress)) {
					return;
				}

				var desk = new Desk(deskAddress);

				if(downButton.Text == "Stop") {
					desk.Stop();
					downButton.Text = "Down";
					return;
				}

				downButton.Text = "Stop";
				desk.Lower();
				desk.Disconnect();
			};
		}
	}
}


