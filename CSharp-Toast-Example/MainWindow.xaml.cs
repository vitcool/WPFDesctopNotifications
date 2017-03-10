using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;

using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;
using Microsoft.QueryStringDotNET;
using Microsoft.Toolkit.Uwp.Notifications;

namespace DesktopToastsSample
{
    public partial class MainWindow : Window
    {
        private const String APP_ID = "Microsoft.Samples.DesktopToastsSample";

		public MainWindow()
        {
            InitializeComponent();
            ShowToastButton.Click += ShowToastWithButton_Click;
        }

        private void ShowToastWithButton_Click(object sender, RoutedEventArgs e)
		{
			// Construct the visuals of the toast
			ToastVisual visual = new ToastVisual()
			{
				BindingGeneric = new ToastBindingGeneric()
				{
					Children =
					{
						new AdaptiveText()
						{
							Text = "Title"
						},

						new AdaptiveText()
						{
							Text = "Desription"
						}
					}
				}
			};

			ToastActionsCustom actions = new ToastActionsCustom()
			{
				Buttons =
				{
					new ToastButton("Reply", new QueryString()
					{
						{ "action", "reply" }
					}.ToString()),
					new ToastButton("View", new QueryString()
					{
						{ "action", "viewImage" }
					}.ToString())
				}
			};


			// Now we can construct the final toast content
			ToastContent toastContent = new ToastContent()
			{
				Visual = visual,
				Actions = actions
			};
			
			// And create the toast notification
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(toastContent.GetContent());
			ToastNotification notification = new ToastNotification(xmlDoc);
			
			// And then send the toast
			ToastNotificationManager.CreateToastNotifier(APP_ID).Show(notification); 
		}
		

		private void ToastActivated(ToastNotification sender, object e)
        {
            Dispatcher.Invoke(() =>
            {
                Activate();
                Output.Text = "The user activated the toast.";
            });
        }

        private void ToastDismissed(ToastNotification sender, ToastDismissedEventArgs e)
        {
            String outputText = "";
            switch (e.Reason)
            {
                case ToastDismissalReason.ApplicationHidden:
                    outputText = "The app hid the toast using ToastNotifier.Hide";
                    break;
                case ToastDismissalReason.UserCanceled:
                    outputText = "The user dismissed the toast";
                    break;
                case ToastDismissalReason.TimedOut:
                    outputText = "The toast has timed out";
                    break;
            }

            Dispatcher.Invoke(() =>
            {
                Output.Text = outputText;
            });
        }

        private void ToastFailed(ToastNotification sender, ToastFailedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                Output.Text = "The toast encountered an error.";
            });
        }
    }
}
