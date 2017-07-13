// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Cats.Client
{
    [Register ("CatsCell")]
    partial class CatsCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NameUILabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PriceUILabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (NameUILabel != null) {
                NameUILabel.Dispose ();
                NameUILabel = null;
            }

            if (PriceUILabel != null) {
                PriceUILabel.Dispose ();
                PriceUILabel = null;
            }
        }
    }
}