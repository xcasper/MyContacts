using Foundation;
using System;
using UIKit;

namespace MyContacts
{
    public partial class ContactsTableViewController : UITableViewController
    {
        public ContactsTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            TableView.ReloadData();
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return (UIApplication.SharedApplication.Delegate as AppDelegate).contactList.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("contactCell") as ContactTableViewCell;

            var contact = (UIApplication.SharedApplication.Delegate as AppDelegate).contactList[indexPath.Row];
            cell.SetContactValues(contact);
            return cell;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            if (segue.Identifier == "viewContactSegue")
            {
                var viewContactViewController = segue.DestinationViewController as ViewContactViewController;
                viewContactViewController.selectedContact = (UIApplication.SharedApplication.Delegate as AppDelegate).contactList[TableView.IndexPathForSelectedRow.Row];
            }
        }
    }
}