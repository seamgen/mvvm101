using System;
using Android.OS;

namespace Mvvm101.Plugin.Device.Droid
{
	public class DeviceAndroid : IDevicePlugin
	{
		public DeviceAndroid ()
		{
		}

		#region IDevicePlugin implementation

		public string GetDeviceName ()
		{
			return Build.Device;
		}

		#endregion
	}
}

