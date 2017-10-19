# CBZSplashView
A Xamarin.iOS implementation of the popular iOS control CBZSplashView from @callumboddy

Credit where credit is due (I just spent a couple hours fighting with the binding libraries, but @callumboddy did the real work): https://github.com/callumboddy/CBZSplashView

## Installation

You can either clone the repository and reference the `CBZSplashView` project, or you can **now** use NuGet!

```
Install-Package ExpandingSplashView
```
https://www.nuget.org/packages/ExpandingSplashView

## Usage

This can be used on any view, but is best suited for covering an entire `UIViewController`. Simply create either a `CBZSplashView`, `CBZRasterSplashView`, or `CBZVectorSplashView` via their constructors or the static initializer within the `CBZSplashView`:

``` csharp
var splashView = new CBZRasterSplashView(someUIImage, someUIColor);
```

Then add the `splashview` to your `View`:

``` csharp
View.Add(splashView);
```

Then start your animation whenever you want:

```csharp
splashView.StartAnimation();
```

Here's an entire `ViewController` class example:

``` csharp
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
```
