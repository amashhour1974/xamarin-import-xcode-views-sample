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
    [Register ("LoginViewController")]
    partial class LoginViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIActivityIndicatorView activitySpinner { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel demoNoteLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel demoVersionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel emergencyImageLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel loginImageLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField loginTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView logoImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField passwordTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint topConstraintLogo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel versionNumberLabel { get; set; }

        [Action ("emergencyLoginTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void emergencyLoginTapped (UIKit.UIButton sender);

        [Action ("loginButtonTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void loginButtonTapped (UIKit.UIButton sender);

        [Action ("privacyPolicyButtonTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void privacyPolicyButtonTapped (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (activitySpinner != null) {
                activitySpinner.Dispose ();
                activitySpinner = null;
            }

            if (demoNoteLabel != null) {
                demoNoteLabel.Dispose ();
                demoNoteLabel = null;
            }

            if (demoVersionLabel != null) {
                demoVersionLabel.Dispose ();
                demoVersionLabel = null;
            }

            if (emergencyImageLabel != null) {
                emergencyImageLabel.Dispose ();
                emergencyImageLabel = null;
            }

            if (loginImageLabel != null) {
                loginImageLabel.Dispose ();
                loginImageLabel = null;
            }

            if (loginTextField != null) {
                loginTextField.Dispose ();
                loginTextField = null;
            }

            if (logoImage != null) {
                logoImage.Dispose ();
                logoImage = null;
            }

            if (passwordTextField != null) {
                passwordTextField.Dispose ();
                passwordTextField = null;
            }

            if (topConstraintLogo != null) {
                topConstraintLogo.Dispose ();
                topConstraintLogo = null;
            }

            if (versionNumberLabel != null) {
                versionNumberLabel.Dispose ();
                versionNumberLabel = null;
            }
        }
    }
}