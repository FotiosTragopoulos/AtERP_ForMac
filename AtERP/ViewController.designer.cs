// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AtERP
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSView coloredView { get; set; }

		[Outlet]
		AppKit.NSButton customersButton { get; set; }

		[Outlet]
		AppKit.NSButton employeesButton { get; set; }

		[Outlet]
		AppKit.NSButton inventoryButton { get; set; }

		[Outlet]
		AppKit.NSButton invoicesButton { get; set; }

		[Outlet]
		AppKit.NSButton purchasesButton { get; set; }

		[Outlet]
		AppKit.NSButton suppliersButton { get; set; }

		[Action ("tabSelectionAction:")]
		partial void tabSelectionAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (employeesButton != null) {
				employeesButton.Dispose ();
				employeesButton = null;
			}

			if (suppliersButton != null) {
				suppliersButton.Dispose ();
				suppliersButton = null;
			}

			if (customersButton != null) {
				customersButton.Dispose ();
				customersButton = null;
			}

			if (purchasesButton != null) {
				purchasesButton.Dispose ();
				purchasesButton = null;
			}

			if (inventoryButton != null) {
				inventoryButton.Dispose ();
				inventoryButton = null;
			}

			if (invoicesButton != null) {
				invoicesButton.Dispose ();
				invoicesButton = null;
			}

			if (coloredView != null) {
				coloredView.Dispose ();
				coloredView = null;
			}
		}
	}
}
