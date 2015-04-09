using System;
using UIKit;

namespace Mvvm101.Plugin.Device.Touch
{
	public class DeviceTouch : IDevicePlugin
	{
		public DeviceTouch ()
		{
		}

		#region IDevicePlugin implementation

		public string GetDeviceName ()
		{
			return UIDevice.CurrentDevice.Model;
		}

		#endregion
	}
}

