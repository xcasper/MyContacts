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

namespace MyContacts
{
    [Register ("ViewContactViewController")]
    partial class ViewContactViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton viewContactEmailButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel viewContactEmailLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel viewContactFullNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView viewContactImageView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (viewContactEmailButton != null) {
                viewContactEmailButton.Dispose ();
                viewContactEmailButton = null;
            }

            if (viewContactEmailLabel != null) {
                viewContactEmailLabel.Dispose ();
                viewContactEmailLabel = null;
            }

            if (viewContactFullNameLabel != null) {
                viewContactFullNameLabel.Dispose ();
                viewContactFullNameLabel = null;
            }

            if (viewContactImageView != null) {
                viewContactImageView.Dispose ();
                viewContactImageView = null;
            }
        }
    }
}