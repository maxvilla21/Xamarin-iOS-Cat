using System;
using System.Collections.Generic;
using UIKit;

namespace Cats.Client
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            List<Cat> cats = new List<Cat>
            {
                new Cat
                {
                    ID = 1,
                    Name = "Uno",
                    Price = 1600

                },
                new Cat
                {
                    ID = 2,
                    Name = "Dos",
                    Price = 2000
                },

                new Cat
                {
                    ID = 3,
                    Name = "Tres",
                    Price = 5000
                }
            };
            CatsTableView.Source = new CatsTableViewSource(cats);

            CatsTableView.RowHeight = UITableView.AutomaticDimension;
            CatsTableView.EstimatedRowHeight = 40f;
            CatsTableView.ReloadData();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}