using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CPTCAppNew.iOS {

	public partial class MainTableViewController : UITableViewController {

		public MainTableViewController (IntPtr handle) : base (handle) {

		}

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            var table = new UITableView(View.Bounds);  // default style is "plain"
            string[] rowItems = new string[] { "General Information", "Map", "Events", "Programs", "Student Email", "Canvas" };
            table.Source = new TableInterfaceSource(rowItems);
        }

    }
}
