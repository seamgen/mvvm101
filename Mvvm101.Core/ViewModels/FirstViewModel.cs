using System;
using Cirrious.MvvmCross.ViewModels;
using Mvvm101.Core.ViewModels;

namespace Mvvm101.Core
{
	public class FirstViewModel : MvxViewModel
	{
		public MvxCommand StartCommand
		{
			get;
			set;
		}

		public FirstViewModel ()
		{
			StartCommand = new MvxCommand (StartButtonTapped);
		}

		private void StartButtonTapped()
		{
			ShowViewModel<SecondViewModel>();
		}
	}
}

