using Foundation;
using System;
using UIKit;

namespace MyContacts
{
    public partial class ViewContactViewController : UIViewController
    {
        public ViewContactViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            viewContactEmailButton.TouchUpInside += ViewContactEmailButton_TouchUpInside;
        }

        private void ViewContactEmailButton_TouchUpInside(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}