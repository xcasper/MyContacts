﻿// WARNING
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
        UIKit.UILabel contactsEmailLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel contactsFullNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView contactsImageView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (contactsEmailLabel != null) {
                contactsEmailLabel.Dispose ();
                contactsEmailLabel = null;
            }

            if (contactsFullNameLabel != null) {
                contactsFullNameLabel.Dispose ();
                contactsFullNameLabel = null;
            }

            if (contactsImageView != null) {
                contactsImageView.Dispose ();
                contactsImageView = null;
            }
        }
    }
}