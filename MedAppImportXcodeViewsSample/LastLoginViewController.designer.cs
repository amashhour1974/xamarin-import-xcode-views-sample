// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MedAppImportXcodeViewsSample
{
    [Register ("LastLoginViewController")]
    partial class LastLoginViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton loginAsDifferentButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel loginAsLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton loginButton { get; set; }

        [Action ("loginAsDifferentTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void loginAsDifferentTapped (UIKit.UIButton sender);

        [Action ("loginTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void loginTapped (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (loginAsDifferentButton != null) {
                loginAsDifferentButton.Dispose ();
                loginAsDifferentButton = null;
            }

            if (loginAsLabel != null) {
                loginAsLabel.Dispose ();
                loginAsLabel = null;
            }

            if (loginButton != null) {
                loginButton.Dispose ();
                loginButton = null;
            }
        }
    }
}