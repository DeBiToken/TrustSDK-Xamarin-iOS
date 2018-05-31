using System;
using Foundation;
using UIKit;

namespace TrustSDKSample
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

		partial void SignTransactionButton_TouchUpInside(UIButton sender)
		{
			var gasPrice = "10000000000";
			ulong gasLimit = 21000;
			var toAddress = ToAddressInput.Text;
			var amount = AmountInput.Text;
            
			AppDelegate.Trust.SignTransaction(gasPrice, gasLimit, toAddress, amount, (NSData obj) =>
			{
				//Create Alert
                string str = ByteArrayToString(obj.ToArray());
                var okAlertController = UIAlertController.Create("Success", str, UIAlertControllerStyle.Alert);

                //Add Action
                okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

                // Present Alert
                PresentViewController(okAlertController, true, null);

			});

		}

		partial void SignButton_TouchUpInside(UIButton sender)
		{
			var message = TextInput.Text;

			AppDelegate.Trust.SignMessage(message, "", (NSData obj) =>
            {
				//Create Alert
				string str = ByteArrayToString(obj.ToArray());
				var okAlertController = UIAlertController.Create("Success", str, UIAlertControllerStyle.Alert);

                //Add Action
                okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

                // Present Alert
                PresentViewController(okAlertController, true, null);
            });

            
		}

        public override void ViewDidLoad()
        {
			base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
		public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
    }
}
