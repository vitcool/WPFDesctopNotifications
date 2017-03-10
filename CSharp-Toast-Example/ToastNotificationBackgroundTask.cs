using System;
using Windows.ApplicationModel.Background;
using Microsoft.QueryStringDotNET;

namespace DesktopToastsSample
{
	public class ToastNotificationBackgroundTask : IBackgroundTask
	{

		public void Run(IBackgroundTaskInstance taskInstance)
		{
			// Get a deferral since we're executing async code
			//var deferral = taskInstance.GetDeferral();

			//try
			//{
			// If it's a toast notification action
			//next line causes exception ToastNotificationActionTrigger not found
			//if (taskInstance.TriggerDetails is ToastNotificationActionTriggerDetail)
			//{
			// Get the toast activation details
			//next line causes exception ToastNotificationActionTrigger not found
			//var details = taskInstance.TriggerDetails as ToastNotificationActionTriggerDetail;

			// Deserialize the arguments received from the toast activation
			//QueryString args = QueryString.Parse(details.Argument);

			// Depending on what action was taken...
			//switch (args["action"])
			//		{
			//			// User clicked the  reply button (doing a quick reply)
			//			/case "view":
			//				//await HandleReply(details, args);
			//				break;

			//			// User clicked the like button
			//			case "like":
			//				//await HandleLike(details, args);
			//				break;

			//			default:
			//				throw new NotImplementedException();
			//		}
			//	}

			//	// Otherwise handle other background activations
			//	else
			//		throw new NotImplementedException();
			//}

			//finally
			//{
			//	// And finally release the deferral since we're done
			//	deferral.Complete();
			//}
			//}
		}
	}
}
