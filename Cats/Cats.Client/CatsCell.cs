using Foundation;
using System;
using UIKit;

namespace Cats.Client
{
    public partial class CatsCell : UITableViewCell
    {
        public CatsCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(Cat cat)
        {
            NameUILabel.Text = cat.Name;
            PriceUILabel.Text = $"{cat.Price:C}";
        }
    }
}