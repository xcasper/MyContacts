using Foundation;
using System;
using UIKit;

namespace MyContacts
{
    public partial class ContactTableViewCell : UITableViewCell
    {
        public ContactTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public void SetContactValues(Contact contact)
        {
            contactListFullNameLabel.Text = contact.FullName;
            contactListEmailLabel.Text = contact.Email;
            contactListImageView.Image = contact.Image;
        }
    }
}