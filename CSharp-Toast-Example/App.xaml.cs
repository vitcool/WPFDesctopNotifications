using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Background;
using Windows.Storage;
using Windows.UI.Xaml.Navigation;
using Microsoft.QueryStringDotNET;

namespace DesktopToastsSample
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	/// 
	public partial class App : Application
	{
		App()
		{
			//need to registrate Background Task
			RegisterBackgroundTask();
		}


		private void RegisterBackgroundTask()
		{
			//const string taskName = "ToastBackgroundTask";

			//If background task is already registered, do nothing
			//next line causes exception BackgroundTaskRegistration not found
			//if (BackgroundTaskRegistration.AllTasks.Any(i => i.Value.Name.Equals(taskName)))
			//return;

			// Otherwise create the background task
			//var builder = new BackgroundTaskBuilder()
			//{
			//	Name = taskName,
			//	TaskEntryPoint = typeof(ToastNotificationBackgroundTask).FullName
			//};

			// And set the toast action trigger
			//next line causes exception ToastNotificationActionTrigger not found
			//builder.SetTrigger(new ToastNotificationActionTrigger());

			// And register the task
			//builder.Register();
		}
	}


}
