using Cirrious.CrossCore.IoC;

namespace Mvvm101.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
            RegisterAppStart<FirstViewModel>();
        }

		public void DoSomethingWhenGoingToBackground()
		{
			
		}
    }
}