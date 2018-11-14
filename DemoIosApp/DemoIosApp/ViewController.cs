using System;

using UIKit;

namespace DemoIosApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void OnClickButtonTapped(Foundation.NSObject sender)
        {
            //AlertView
            var alertVC = new UIAlertView("Title", "Hello App", null, "Cancel", null);
            alertVC.Show();

        }

        private void TestFunction()
        {
            var name = "Bharat";
        }
    }
}
