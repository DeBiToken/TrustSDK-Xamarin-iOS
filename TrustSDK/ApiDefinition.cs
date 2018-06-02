using System;
using Foundation;

namespace TrustSDK {
    // @interface TrustSDK : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    partial interface TrustSDK
    {
        // -(instancetype _Nonnull)initWithCallbackScheme:(NSString * _Nonnull)callbackScheme __attribute__((objc_designated_initializer));
        [Export("initWithCallbackScheme:")]
        [DesignatedInitializer]
        IntPtr Constructor(string callbackScheme);

        // -(BOOL)handleCallbackWithUrl:(NSURL * _Nonnull)url __attribute__((warn_unused_result));
        [Export("handleCallbackWithUrl:")]
        bool HandleCallback(NSUrl url);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        TrustSDK New();
    }

    // @interface TrustSDK_Swift_205 (TrustSDK)
    partial interface TrustSDK
    {
        // -(void)signMessage:(NSData * _Nonnull)message address:(NSString * _Nullable)address completion:(void (^ _Nonnull)(NSData * _Nonnull))completion;
        [Export("signMessage:address:completion:")]
        void SignMessage(NSData message, [NullAllowed] string address, Action<NSData> completion);

        // -(void)signTransaction:(NSString * _Nonnull)gasPrice :(uint64_t)gasLimit :(NSString * _Nonnull)address amount:(NSString * _Nonnull)amount completion:(void (^ _Nonnull)(NSData * _Nonnull))completion;
        [Export("signTransaction:::amount:completion:")]
        void SignTransaction(string gasPrice, ulong gasLimit, string address, string amount, Action<NSData> completion);

        // -(void)signPersonalMessage:(NSData * _Nonnull)message address:(NSString * _Nullable)address completion:(void (^ _Nonnull)(NSData * _Nonnull))completion;
        [Export("signPersonalMessage:address:completion:")]
        void SignPersonalMessage(NSData message, [NullAllowed] string address, Action<NSData> completion);
    }

}
    