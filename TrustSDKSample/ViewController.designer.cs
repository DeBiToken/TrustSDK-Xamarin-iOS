// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TrustSDKSample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField AmountInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SignMessageButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SignTransactionButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ToAddressInput { get; set; }

        [Action ("SignButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SignButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("SignTransactionButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SignTransactionButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AmountInput != null) {
                AmountInput.Dispose ();
                AmountInput = null;
            }

            if (SignMessageButton != null) {
                SignMessageButton.Dispose ();
                SignMessageButton = null;
            }

            if (SignTransactionButton != null) {
                SignTransactionButton.Dispose ();
                SignTransactionButton = null;
            }

            if (TextInput != null) {
                TextInput.Dispose ();
                TextInput = null;
            }

            if (ToAddressInput != null) {
                ToAddressInput.Dispose ();
                ToAddressInput = null;
            }
        }
    }
}