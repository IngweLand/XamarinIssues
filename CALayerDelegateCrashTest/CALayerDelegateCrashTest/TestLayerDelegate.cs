using MonoTouch.CoreAnimation;
using MonoTouch.CoreGraphics;
using System;
using System.Drawing;
using MonoTouch.UIKit;

namespace Test
{
    public class TestLayerDelegate : CALayerDelegate
    {
        public override void DrawLayer(CALayer layer, CGContext context)
        {
			context.SetFillColor(UIColor.Green.CGColor);
			context.FillRect(layer.Frame);
		}

		protected override void Dispose (bool disposing)
		{
			Console.WriteLine ("---dispose {0}", this);
			base.Dispose (disposing);
			Console.WriteLine ("---postdispose {0}", this);
		}      
    }
}