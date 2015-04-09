using System;
using Cirrious.MvvmCross.Touch.Views;
using UIKit;
using ObjCRuntime;
using Cirrious.MvvmCross.Binding.BindingContext;
using Mvvm101.Core;

namespace Mvvm101.Touch
{
	public class FirstView : MvxViewController
	{
		UIButton StartButton;

		public override void ViewDidLoad ()
		{
			View = new UIView { BackgroundColor = UIColor.White };
			base.ViewDidLoad();

			// ios7 layout
			if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
			{
				EdgesForExtendedLayout = UIRectEdge.None;
			}

			StartButton = new UIButton ();
			StartButton.SetTitle("Start", UIControlState.Normal);
			StartButton.SetTitleColor(UIColor.Blue, UIControlState.Normal);
			StartButton.Frame = new CoreGraphics.CGRect ((nfloat)100, (nfloat)100, (nfloat)100, (nfloat)100);

			View.Add(StartButton);

			var set = this.CreateBindingSet<FirstView, FirstViewModel> ();
			set.Bind (StartButton).To (model => model.StartCommand);
			set.Apply ();
		}
	}
}

