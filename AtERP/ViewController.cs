using System;

using AppKit;
using Foundation;

namespace AtERP
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            this.View.WantsLayer = true;
            base.ViewDidLoad();
            initialView();
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        //Change the color of the 
		public override void AwakeFromNib()
		{
			base.AwakeFromNib();
			if (this.View.Layer != null)
			{
				var color = new CoreGraphics.CGColor(red: 105 / 255f, green: 105 / 255f, blue: 105 / 255f);
				this.View.Layer.BackgroundColor = color;
			}
		}

		protected void designView()
		{
			coloredView.Shadow = new NSShadow();
			coloredView.Layer.MasksToBounds = false;
			coloredView.Layer.CornerRadius = 5f;
			coloredView.Layer.ShadowOpacity = 1f;
			coloredView.Layer.ShadowRadius = 5f;
			coloredView.Layer.ShadowOffset = new CoreGraphics.CGSize(width: 0f, height: 0f);
			coloredView.Layer.ShadowColor = new CoreGraphics.CGColor(red: 1 / 255f, green: 1 / 255f, blue: 1 / 255f);
		}

		partial void tabSelectionAction(NSObject sender)
		{
			var buttonTagNumber = (sender as NSButton).Tag;

			switch (buttonTagNumber)
			{
				case 1:
					{
						designView();
						coloredView.Layer.BackgroundColor = new CoreGraphics.CGColor(red: 250 / 255f, green: 184 / 255f, blue: 63 / 255f);
						break;
					}
				case 2:
					{
						designView();
						coloredView.Layer.BackgroundColor = new CoreGraphics.CGColor(red: 29 / 255f, green: 115 / 255f, blue: 162 / 255f);
						break;
					}
				case 3:
					{
						designView();
						coloredView.Layer.BackgroundColor = new CoreGraphics.CGColor(red: 217 / 255f, green: 46 / 255f, blue: 68 / 255f);
						break;
					}
				case 4:
					{
						designView();
						coloredView.Layer.BackgroundColor = new CoreGraphics.CGColor(red: 31 / 255f, green: 111 / 255f, blue: 98 / 255f);
						break;
					}
				case 5:
					{
						designView();
						coloredView.Layer.BackgroundColor = new CoreGraphics.CGColor(red: 67 / 255f, green: 54 / 255f, blue: 61 / 255f);
						break;
					}
				case 6:
					{
						designView();
						coloredView.Layer.BackgroundColor = new CoreGraphics.CGColor(red: 243 / 255f, green: 128 / 255f, blue: 24 / 255f);
						break;
					}
				default:
					{
						designView();
						coloredView.Layer.BackgroundColor = new CoreGraphics.CGColor(red: 250 / 255f, green: 184 / 255f, blue: 63 / 255f);
						break;
					}
			}
		}

		protected void initialView()
		{
			tabSelectionAction(employeesButton);
		}


    }
}
