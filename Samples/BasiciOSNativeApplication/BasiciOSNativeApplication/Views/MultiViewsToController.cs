using System;
using CoreGraphics;
using UIKit;

namespace BasiciOSNativeApplication
{
    public class MultiViewsToController : UIViewController
    {
        public nfloat screenHeight, screenWidth;
        public MultiViewsToController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            screenHeight = (View.Bounds.Height) / 100;
            screenWidth = (View.Bounds.Width) / 100;

            UITextField inputUserName = new UITextField();
            inputUserName.Frame = new CGRect((screenWidth * 10), (screenHeight * 30), (screenWidth * 80), (screenHeight * 10));
            //inputUserName.BackgroundColor = UIColor.Yellow;
            inputUserName.BorderStyle = UITextBorderStyle.RoundedRect;


            UITextField inputUserPassword = new UITextField()
            {
                BackgroundColor = UIColor.Yellow,
                SecureTextEntry = true,//this is similar to ispassword in xamarin.forms
                Frame = new CGRect((screenWidth * 10), (screenHeight * 45), (screenWidth * 80), (screenHeight * 10)),
                BorderStyle = UITextBorderStyle.RoundedRect
            };


            //UIButton buttonSubmit = new UIButton();
            UIButton buttonSubmit = UIButton.FromType(UIButtonType.RoundedRect);
            buttonSubmit.SetTitle("Submit", UIControlState.Normal);
            buttonSubmit.SetTitleColor(UIColor.Green, UIControlState.Normal);
            buttonSubmit.Frame = new CGRect((screenWidth * 10), (screenHeight * 60), (screenWidth * 80), (screenHeight * 10));
            buttonSubmit.BackgroundColor = UIColor.Yellow;

            View.BackgroundColor = UIColor.Gray;
            View.AddSubviews(new UIView[]{inputUserName, inputUserPassword, buttonSubmit});

        }
    }
}
