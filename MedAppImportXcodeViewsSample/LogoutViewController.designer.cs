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
    [Register ("LogoutViewController")]
    partial class LogoutViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel dotsLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel loggingOutLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (dotsLabel != null) {
                dotsLabel.Dispose ();
                dotsLabel = null;
            }

            if (loggingOutLabel != null) {
                loggingOutLabel.Dispose ();
                loggingOutLabel = null;
            }
        }
    }
}