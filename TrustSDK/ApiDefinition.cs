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

    // @interface TrustSDK_Swift_206 (TrustSDK)
    partial interface TrustSDK
    {
        // -(void)signMessage:(NSData * _Nonnull)message address:(NSString * _Nullable)address success:(void (^ _Nonnull)(NSData * _Nonnull))success failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Export("signMessage:address:success:failure:")]
        void SignMessage(NSData message, [NullAllowed] string address, Action<NSData> success, Action<NSError> failure);

        // -(void)signTransaction:(NSString * _Nonnull)gasPrice :(uint64_t)gasLimit :(NSString * _Nonnull)address amount:(NSString * _Nonnull)amount success:(void (^ _Nonnull)(NSData * _Nonnull))success failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Export("signTransaction:::amount:success:failure:")]
        void SignTransaction(string gasPrice, ulong gasLimit, string address, string amount, Action<NSData> success, Action<NSError> failure);

        // -(void)signPersonalMessage:(NSData * _Nonnull)message address:(NSString * _Nullable)address success:(void (^ _Nonnull)(NSData * _Nonnull))success failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Export("signPersonalMessage:address:success:failure:")]
        void SignPersonalMessage(NSData message, [NullAllowed] string address, Action<NSData> success, Action<NSError> failure);
    }

}
    