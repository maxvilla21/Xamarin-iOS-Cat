using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Cats.Client
{
   public class CatsTableViewSource:UITableViewSource
    {
        private List<Cat> Cats;

        public CatsTableViewSource(List<Cat> cats)
        {
            this.Cats = cats;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            // var cell = new UITableViewCell(UITableViewCellStyle.Default,"");
            //cell.TextLabel.Text = Cats[indexPath.Row];

            var cell =(CatsCell) tableView.DequeueReusableCell("cell_id", indexPath);

            var cat = Cats[indexPath.Row];
            cell.UpdateCell(cat);
         

            return cell;

        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Cats.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var selected = Cats[indexPath.Row];
        }
    }
}