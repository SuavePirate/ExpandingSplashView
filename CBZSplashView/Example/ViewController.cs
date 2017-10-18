using System;

using UIKit;
using CBZSplashView;

namespace Example
{
    public partial class ViewController : UIViewController
    {
        private CBZSplashView.CBZSplashView _splashView;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var icon = UIImage.FromFile("snapchatIcon.png");

            _splashView = new CBZSplashView.CBZRasterSplashView(icon, UIColor.Yellow);

            View.Add(_splashView);

        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            if (_splashView != null)
                _splashView.StartAnimation();
        }
    }
}
