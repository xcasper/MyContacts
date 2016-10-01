using Foundation;
using System;
using UIKit;

namespace MyContacts
{
    public partial class EditContactViewController : UIViewController
    {
        UIImagePickerController imagePickerController;
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

            NavigationController.PopViewController(true);
        }

        private void EditContactImageButton_TouchUpInside(object sender, EventArgs e)
        {
            imagePickerController = new UIImagePickerController();
            imagePickerController.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
            //imagePickerController.MediaTypes = UIImagePickerController.AvailableMediaTypes(UIImagePickerControllerSourceType.PhotoLibrary);

            imagePickerController.Canceled += ImagePickerController_Canceled;
            imagePickerController.FinishedPickingMedia += ImagePickerController_FinishedPickingMedia;

            NavigationController.PresentModalViewController(imagePickerController, true);
        }

        private void ImagePickerController_FinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs e)
        {
            editContactImageView.Image = e.Info[UIImagePickerController.OriginalImage] as UIImage;
            imagePickerController.DismissModalViewController(true);
        }

        private void ImagePickerController_Canceled(object sender, EventArgs e)
        {
            imagePickerController.DismissModalViewController(true);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}