using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using UIKit;

namespace CPTCAppNew.iOS {

    public class TableInterfaceSource : UITableViewSource {

        // global variables
        string[] rowItems;  // holds the "categories" of each individual row in the home table
        string cellIdentifier = "TableCell";

        // default constructor
        public TableInterfaceSource(string[] contents) {
            this.rowItems = contents;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath) {
            //throw new NotImplementedException();

            // calling dequeue automatically returns a row from the table in the Home table controller,
            // at least when dealing with a storyboard.
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            string item = rowItems[indexPath.Row];

            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            cell.TextLabel.Text = rowItems[indexPath.Row];

            return cell;

        }

        // returns the number of rows in the table view.
        public override nint RowsInSection(UITableView tableview, nint section) {
            return rowItems.Length;
        }
    }
}
