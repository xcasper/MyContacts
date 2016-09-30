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
    [Register ("ContactTableViewCell")]
    partial class ContactTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel contactEmailLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView contactImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel contactNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (contactEmailLabel != null) {
                contactEmailLabel.Dispose ();
                contactEmailLabel = null;
            }

            if (contactImage != null) {
                contactImage.Dispose ();
                contactImage = null;
            }

            if (contactNameLabel != null) {
                contactNameLabel.Dispose ();
                contactNameLabel = null;
            }
        }
    }
}