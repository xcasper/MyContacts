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
    [Register ("EditContactViewController")]
    partial class EditContactViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField editContactEmailLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField editContactFullNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton editContactImageButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView editContactImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem editContactSaveButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (editContactEmailLabel != null) {
                editContactEmailLabel.Dispose ();
                editContactEmailLabel = null;
            }

            if (editContactFullNameLabel != null) {
                editContactFullNameLabel.Dispose ();
                editContactFullNameLabel = null;
            }

            if (editContactImageButton != null) {
                editContactImageButton.Dispose ();
                editContactImageButton = null;
            }

            if (editContactImageView != null) {
                editContactImageView.Dispose ();
                editContactImageView = null;
            }

            if (editContactSaveButton != null) {
                editContactSaveButton.Dispose ();
                editContactSaveButton = null;
            }
        }
    }
}