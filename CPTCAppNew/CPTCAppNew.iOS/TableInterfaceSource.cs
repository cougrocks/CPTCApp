using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using UIKit;

namespace CPTCAppNew.iOS {

    public class TableInterfaceSource : UITableViewSource {

        string[] rowItems;
        string cellIdentifier = "TableCell";

        public TableInterfaceSource(string[] rowItems) {
            this.rowItems = rowItems;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath) {
            //throw new NotImplementedException();

            // calling dequeue automatically returns a row from the table in the Home table controller,
            // at least when dealing with a storyboard.
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);

        }

        public override nint RowsInSection(UITableView tableview, nint section) {
            return rowItems.Length;
        }
    }
}
