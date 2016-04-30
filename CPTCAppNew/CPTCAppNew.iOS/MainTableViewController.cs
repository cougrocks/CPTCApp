using Foundation;
using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using UIKit;

namespace CPTCAppNew.iOS {

	public partial class MainTableViewController : UITableViewController {

        public List<String> TableRowContents { get; set; }

        static NSString tableCellId = new NSString("HomeTableCell");

		public MainTableViewController (IntPtr handle) : base (handle) {
            TableView.RegisterClassForCellReuse(typeof(UITableViewCell), tableCellId);
            TableView.Source = new HomeTableDataSource(this);
            TableRowContents = new List<string>();
		}

        class HomeTableDataSource : UITableViewSource {
            MainTableViewController controller;

            public HomeTableDataSource(MainTableViewController controller) {
                this.controller = controller;
            }

            // gets the number of rows in the table view
            public override nint RowsInSection(UITableView tableview, nint section) {
                return controller.TableRowContents.Count;
            }

            // returns a table cell for the row indicated by row property of
            // the NSIndexPath. This method is called multiple times to populate
            // each row of the table. The method automatically uses cells that have
            // scrolled off the screen or creates new ones if necessary
            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath) {
                var cell = tableView.DequeueReusableCell(MainTableViewController.tableCellId);

                int row = indexPath.Row;
                cell.TextLabel.Text = controller.TableRowContents[row];
                return cell;
            }
        }

    }
}
