using Foundation;
using MessageUI;
using System;
using UIKit;

namespace MyContacts
{
    public partial class ViewContactViewController : UIViewController
    {
        public Contact selectedContact;

        public ViewContactViewController (IntPtr handle) : base (handle)
        {
        }
       
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            viewContactEmailButton.TouchUpInside += ViewContactEmailButton_TouchUpInside;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            viewContactImageView.Image = selectedContact.Image;
            viewContactFullNameLabel.Text = selectedContact.FullName;
            viewContactEmailLabel.Text = selectedContact.Email;
            
        }
        private void ViewContactEmailButton_TouchUpInside(object sender, EventArgs e)
        {
            if (MFMailComposeViewController.CanSendMail)
            {
                var emailController = new MFMailComposeViewController();
                emailController.SetToRecipients(new string[] { viewContactEmailLabel.Text });

                emailController.Finished += EmailController_Finished;

                PresentViewController(emailController, true, null);
            }
        }

        private void EmailController_Finished(object sender, MFComposeResultEventArgs e)
        {
            e.Controller.DismissViewController(true, null);
        }
    }
}