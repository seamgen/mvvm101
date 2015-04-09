using Cirrious.MvvmCross.ViewModels;
using Mvvm101.Plugin.Device;

namespace Mvvm101.Core.ViewModels
{
    public class SecondViewModel 
		: MvxViewModel
    {
		private string _hello; // = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

		public SecondViewModel(IDevicePlugin plugin)
		{
			_hello = plugin.GetDeviceName();
		}
    }
}
