using ObjCRuntime;

[assembly: LinkWith ("libCardIO.a", SmartLink = true, Frameworks = "Accelerate AudioToolbox AVFoundation CoreGraphics CoreLocation CoreMedia CoreVideo Foundation MessageUI MobileCoreServices OpenGLES QuartzCore Security SystemConfiguration UIKit SafariServices", IsCxx = true, LinkerFlags = "-lc++ -ObjC", ForceLoad = true)]
