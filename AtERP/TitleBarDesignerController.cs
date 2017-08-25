using System;

using Foundation;
using AppKit;

namespace AtERP
{
    public partial class TitleBarDesignerController : NSWindowController
    {
        public TitleBarDesignerController(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public TitleBarDesignerController(NSCoder coder) : base(coder)
        {
        }

        public TitleBarDesignerController() : base("TitleBarDesigner")
        {
        }

        public override void AwakeFromNib()
        {
            
            base.AwakeFromNib();
			base.WindowDidLoad();
			base.Window.BackgroundColor = NSColor.FromRgb(red: 125 / 255f, green: 125 / 255f, blue: 125 / 255f);
        }
    }
}
