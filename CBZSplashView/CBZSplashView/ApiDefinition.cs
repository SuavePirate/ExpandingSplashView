using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CBZSplashView
{


    // @interface CBZSplashView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface CBZSplashView
    {
        // +(instancetype)splashViewWithIcon:(UIImage *)icon backgroundColor:(UIColor *)backgroundColor;
        [Static]
        [Export("splashViewWithIcon:backgroundColor:")]
        CBZSplashView SplashViewWithIcon(UIImage icon, UIColor backgroundColor);

        // +(instancetype)splashViewWithBezierPath:(UIBezierPath *)bezier backgroundColor:(UIColor *)backgroundColor;
        [Static]
        [Export("splashViewWithBezierPath:backgroundColor:")]
        CBZSplashView SplashViewWithBezierPath(UIBezierPath bezier, UIColor backgroundColor);

        // -(void)startAnimation;
        [Export("startAnimation")]
        void StartAnimation();

        // -(void)startAnimationWithCompletionHandler:(void (^)())completionHandler;
        [Export("startAnimationWithCompletionHandler:")]
        void StartAnimationWithCompletionHandler(Action completionHandler);

        // @property (assign, nonatomic) CGSize iconStartSize;
        [Export("iconStartSize", ArgumentSemantic.Assign)]
        CGSize IconStartSize { get; set; }

        // @property (assign, nonatomic) CGFloat animationDuration;
        [Export("animationDuration")]
        nfloat AnimationDuration { get; set; }

        // @property (nonatomic, strong) CAAnimation * iconAnimation;
        [Export("iconAnimation", ArgumentSemantic.Strong)]
        CAAnimation IconAnimation { get; set; }

        // @property (nonatomic, strong) UIColor * iconColor;
        [Export("iconColor", ArgumentSemantic.Strong)]
        UIColor IconColor { get; set; }

    }

    // @interface CBZRasterSplashView : CBZSplashView
    [BaseType(typeof(CBZSplashView))]
    //[Protocol]
    interface CBZRasterSplashView
    {
        // -(instancetype)initWithIconImage:(UIImage *)icon backgroundColor:(UIColor *)color;
        [Export("initWithIconImage:backgroundColor:")]
        IntPtr Constructor(UIImage icon, UIColor color);
    }

    // @interface CBZVectorSplashView : CBZSplashView
    [BaseType(typeof(CBZSplashView))]
    //[Protocol]
    interface CBZVectorSplashView
    {
        // -(instancetype)initWithBezierPath:(UIBezierPath *)bezier backgroundColor:(UIColor *)backgroundColor;
        [Export("initWithBezierPath:backgroundColor:")]
        IntPtr Constructor(UIBezierPath bezier, UIColor backgroundColor);
    }

    //[Static]
    ////[Verify(ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern double CBZSplashViewVersionNumber;
    //    [Field("CBZSplashViewVersionNumber", "__Internal")]
    //    double CBZSplashViewVersionNumber { get; }

    //    // extern const unsigned char [] CBZSplashViewVersionString;
    //    [Field("CBZSplashViewVersionString", "__Internal")]
    //    IntPtr CBZSplashViewVersionString { get; }
    //}


}