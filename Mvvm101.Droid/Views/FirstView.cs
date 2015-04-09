
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using Mvvm101.Core;

namespace Mvvm101.Droid
{
	[Activity(Label = "View for FirstViewModel")]
	public class FirstView : MvxActivity
	{
		Button StartButton;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.FirstView);

			StartButton = FindViewById<Button>(Resource.Id.button1);

			var set = this.CreateBindingSet<FirstView, FirstViewModel> ();
			set.Bind (StartButton).To (model => model.StartCommand);
			set.Apply ();
		}
	}
}

