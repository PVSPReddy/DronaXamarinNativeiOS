using System;
using CoreGraphics;
using UIKit;

namespace BasiciOSNativeApplication
{
    public class SecondTrailViewController : UIViewController
    {
        public SecondTrailViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Yellow;
            Title = "Second View Controller";

            UIButton buttonOpenNewControllerOne = UIButton.FromType(UIButtonType.System);
            buttonOpenNewControllerOne.Frame = new CGRect(50, 100, 150, 40);
            buttonOpenNewControllerOne.SetTitle("First Button", UIControlState.Normal);


            UIButton buttonOpenNewControllerTwo = new UIButton(new CGRect(50, 200, 150, 40));
            buttonOpenNewControllerTwo.SetTitle("Second Button", UIControlState.Normal);
            buttonOpenNewControllerTwo.SetTitleColor(UIColor.Green, UIControlState.Normal);




            UIViewController naviPage = new UIViewController();
            naviPage.View.BackgroundColor = UIColor.Orange;

            var multiView = new MultiViewsToController();




            buttonOpenNewControllerOne.TouchUpInside += async (object sender, EventArgs e) => 
            {
                this.NavigationController.PushViewController(naviPage, true);
            };

            buttonOpenNewControllerTwo.TouchUpInside += async (object sender, EventArgs e) => 
            {
                this.NavigationController.PushViewController(multiView, true);
            };

            View.AddSubview(buttonOpenNewControllerOne);
            View.AddSubview(buttonOpenNewControllerTwo);


        }
    }
}
