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
    [Register ("PasswordChangedViewController")]
    partial class PasswordChangedViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel logoutImageLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField passwordTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel signInImageLabel { get; set; }

        [Action ("logoutTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void logoutTapped (UIKit.UIButton sender);

        [Action ("signInTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void signInTapped (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (logoutImageLabel != null) {
                logoutImageLabel.Dispose ();
                logoutImageLabel = null;
            }

            if (passwordTextField != null) {
                passwordTextField.Dispose ();
                passwordTextField = null;
            }

            if (signInImageLabel != null) {
                signInImageLabel.Dispose ();
                signInImageLabel = null;
            }
        }
    }
}