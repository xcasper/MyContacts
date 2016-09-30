using Foundation;
using System;
using UIKit;

namespace MyContacts
{
    public partial class EditContactViewController : UIViewController
    {
        public EditContactViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            editContactImageButton.TouchUpInside += EditContactImageButton_TouchUpInside;
            editContactSaveButton.Clicked += EditContactSaveButton_Clicked;
        }

        private void EditContactSaveButton_Clicked(object sender, EventArgs e)
        {
            var contact = new Contact()
            {
                FullName = editContactFullNameLabel.Text,
                Email = editContactEmailLabel.Text,
                Image = editContactImageView.Image
            };

            var del = UIApplication.SharedApplication.Delegate as AppDelegate;
            del.contactList.Add(contact);
        }

        private void EditContactImageButton_TouchUpInside(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}