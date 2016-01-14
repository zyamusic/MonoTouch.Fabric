using System;
using Foundation;
using ObjCRuntime;
using UIKit;
using MonoTouch.Fabric.DigitsKit;
using MonoTouch.Fabric.TwitterCore;

namespace MonoTouch.Fabric.DigitsKit
{
	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const TWTRAPIErrorDomain;
		[Field ("TWTRAPIErrorDomain", "__Internal")]
		NSString TWTRAPIErrorDomain { get; }
	}
	
	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const TWTRErrorDomain;
		[Field ("TWTRErrorDomain", "__Internal")]
		NSString TWTRErrorDomain { get; }
	}
	
	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const TWTRLogInErrorDomain;
		[Field ("TWTRLogInErrorDomain", "__Internal")]
		NSString TWTRLogInErrorDomain { get; }
	}
	
	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const TWTROAuthEchoRequestURLStringKey;
		[Field ("TWTROAuthEchoRequestURLStringKey", "__Internal")]
		NSString TWTROAuthEchoRequestURLStringKey { get; }
	
		// extern NSString *const TWTROAuthEchoAuthorizationHeaderKey;
		[Field ("TWTROAuthEchoAuthorizationHeaderKey", "__Internal")]
		NSString TWTROAuthEchoAuthorizationHeaderKey { get; }
	}
	
	// typedef void (^TWTRGuestLogInCompletion)(TWTRGuestSession * _Nullable, NSError * _Nullable);
	delegate void TWTRGuestLogInCompletion ([NullAllowed] TWTRGuestSession arg0, [NullAllowed] NSError arg1);
	
	// typedef void (^TWTRLogInCompletion)(TWTRSession * _Nullable, NSError * _Nullable);
	delegate void TWTRLogInCompletion ([NullAllowed] TWTRSession arg0, [NullAllowed] NSError arg1);
	
	// typedef void (^TWTRSessionStoreRefreshCompletion)(id _Nullable, NSError * _Nullable);
	delegate void TWTRSessionStoreRefreshCompletion ([NullAllowed] NSObject arg0, [NullAllowed] NSError arg1);
	
	// typedef void (^TWTRSessionStoreSaveCompletion)(id<TWTRAuthSession> _Nullable, NSError * _Nullable);
	delegate void TWTRSessionStoreSaveCompletion ([NullAllowed] TWTRAuthSession arg0, [NullAllowed] NSError arg1);
	
	// typedef void (^TWTRSessionStoreBatchFetchCompletion)(NSArray * _Nonnull);
	delegate void TWTRSessionStoreBatchFetchCompletion (NSObject[] arg0);
	
	// typedef void (^TWTRSessionStoreDeleteCompletion)(id<TWTRAuthSession> _Nullable);
	delegate void TWTRSessionStoreDeleteCompletion ([NullAllowed] TWTRAuthSession arg0);
	
	// typedef void (^TWTRSessionGuestLogInCompletion)(TWTRGuestSession * _Nullable, NSError * _Nullable);
	delegate void TWTRSessionGuestLogInCompletion ([NullAllowed] TWTRGuestSession arg0, [NullAllowed] NSError arg1);
	
	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const DGTErrorDomain;
		[Field ("DGTErrorDomain", "__Internal")]
		NSString DGTErrorDomain { get; }
	}
	
	// @interface DGTSession : NSObject <TWTRAuthSession>
	[BaseType (typeof(NSObject))]
	interface DGTSession : ITWTRAuthSession
	{
		// @property (readonly, copy, nonatomic) NSString * authToken;
		[Export ("authToken")]
		string AuthToken { get; }
	
		// @property (readonly, copy, nonatomic) NSString * authTokenSecret;
		[Export ("authTokenSecret")]
		string AuthTokenSecret { get; }
	
		// @property (readonly, copy, nonatomic) NSString * userID;
		[Export ("userID")]
		string UserID { get; }
	
		// @property (readonly, copy, nonatomic) NSString * phoneNumber;
		[Export ("phoneNumber")]
		string PhoneNumber { get; }
	
		// @property (readonly, copy, nonatomic) NSString * emailAddress;
		[Export ("emailAddress")]
		string EmailAddress { get; }
	
		// @property (readonly, nonatomic) BOOL emailAddressIsVerified;
		[Export ("emailAddressIsVerified")]
		bool EmailAddressIsVerified { get; }
	
		// -(instancetype)initWithAuthToken:(NSString *)authToken authTokenSecret:(NSString *)authTokenSecret userID:(NSString *)userID phoneNumber:(NSString *)phoneNumber;
		[Export ("initWithAuthToken:authTokenSecret:userID:phoneNumber:")]
		IntPtr Constructor (string authToken, string authTokenSecret, string userID, string phoneNumber);
	
		// -(instancetype)initWithAuthToken:(NSString *)authToken authTokenSecret:(NSString *)authTokenSecret userID:(NSString *)userID phoneNumber:(NSString *)phoneNumber emailAddress:(NSString *)emailAddress emailAddressIsVerified:(BOOL)emailAddressIsVerified;
		[Export ("initWithAuthToken:authTokenSecret:userID:phoneNumber:emailAddress:emailAddressIsVerified:")]
		IntPtr Constructor (string authToken, string authTokenSecret, string userID, string phoneNumber, string emailAddress, bool emailAddressIsVerified);
	}
	
	// typedef void (^DGTAuthenticationCompletion)(DGTSession *, NSError *);
	delegate void DGTAuthenticationCompletion (DGTSession arg0, NSError arg1);
	
	// @interface DGTAPIClient : NSObject
	[BaseType (typeof(NSObject))]
	interface DGTAPIClient
	{
		// -(void)authenticateWithConfiguration:(DGTAuthenticationConfiguration *)configuration delegate:(id<DGTAPIAuthenticationDelegate>)authDelegate completion:(DGTAuthenticationCompletion)completionBlock;
		[Export ("authenticateWithConfiguration:delegate:completion:")]
		void AuthenticateWithConfiguration (DGTAuthenticationConfiguration configuration, DGTAPIAuthenticationDelegate authDelegate, DGTAuthenticationCompletion completionBlock);
	}


	// @protocol DGTAPIChallengeDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface DGTAPIChallengeDelegate
	{
	}

	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface DGTDeviceRegisterResponse
	{
	}

	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface DGTLogInAuthResponse
	{
	}

	// @protocol DGTAPIAuthenticationDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface DGTAPIAuthenticationDelegate
	{
		// @required -(void)challengeViewController:(UIViewController<DGTAPIChallengeDelegate> *)challengeViewController error:(NSError *)error;
		[Abstract]
		[Export ("challengeViewController:error:")]
		void ChallengeViewController (DGTAPIChallengeDelegate challengeViewController, NSError error);
	
		// @optional -(UIViewController<DGTAPIChallengeDelegate> *)signUpViewControllerWithDeviceRegisterResponse:(DGTDeviceRegisterResponse *)deviceRegisterResponse;
		[Export ("signUpViewControllerWithDeviceRegisterResponse:")]
		DGTAPIChallengeDelegate SignUpViewControllerWithDeviceRegisterResponse (DGTDeviceRegisterResponse deviceRegisterResponse);
	
		// @optional -(UIViewController<DGTAPIChallengeDelegate> *)logInViewControllerWithLogInResponse:(DGTLogInAuthResponse *)logInResponse;
		[Export ("logInViewControllerWithLogInResponse:")]
		DGTAPIChallengeDelegate LogInViewControllerWithLogInResponse (DGTLogInAuthResponse logInResponse);
	}

	
	// @interface DGTAppearance : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface DGTAppearance : INSCopying
	{
		// @property (nonatomic, strong) UIColor * backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }
	
		// @property (nonatomic, strong) UIColor * accentColor;
		[Export ("accentColor", ArgumentSemantic.Strong)]
		UIColor AccentColor { get; set; }
	
		// @property (nonatomic, strong) UIFont * headerFont;
		[Export ("headerFont", ArgumentSemantic.Strong)]
		UIFont HeaderFont { get; set; }
	
		// @property (nonatomic, strong) UIFont * labelFont;
		[Export ("labelFont", ArgumentSemantic.Strong)]
		UIFont LabelFont { get; set; }
	
		// @property (nonatomic, strong) UIFont * bodyFont;
		[Export ("bodyFont", ArgumentSemantic.Strong)]
		UIFont BodyFont { get; set; }
	
		// @property (nonatomic, strong) UIImage * logoImage;
		[Export ("logoImage", ArgumentSemantic.Strong)]
		UIImage LogoImage { get; set; }
	}
	
	// @interface DGTAuthenticateButton : UIButton
	[BaseType (typeof(UIButton))]
	interface DGTAuthenticateButton
	{
		// +(instancetype)buttonWithAuthenticationCompletion:(DGTAuthenticationCompletion)completion;
		[Static]
		[Export ("buttonWithAuthenticationCompletion:")]
		DGTAuthenticateButton ButtonWithAuthenticationCompletion (DGTAuthenticationCompletion completion);
	
		// @property (copy, nonatomic) DGTAppearance * digitsAppearance;
		[Export ("digitsAppearance", ArgumentSemantic.Copy)]
		DGTAppearance DigitsAppearance { get; set; }
	}
	
	// @interface DGTAuthenticationConfiguration : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface DGTAuthenticationConfiguration : INSCopying
	{
		// @property (nonatomic, strong) DGTAppearance * appearance;
		[Export ("appearance", ArgumentSemantic.Strong)]
		DGTAppearance Appearance { get; set; }
	
		// @property (nonatomic, strong) NSString * phoneNumber;
		[Export ("phoneNumber", ArgumentSemantic.Strong)]
		string PhoneNumber { get; set; }
	
		// @property (nonatomic, strong) NSString * title;
		[Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }
	
		// -(instancetype)initWithAccountFields:(DGTAccountFields)accountFields;
		[Export ("initWithAccountFields:")]
		IntPtr Constructor (DGTAccountFields accountFields);
	}
	
	// @protocol DGTCompletionViewController <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface DGTCompletionViewController
	{
		// @required -(void)digitsAuthenticationFinishedWithSession:(DGTSession *)session error:(NSError *)error;
		[Abstract]
		[Export ("digitsAuthenticationFinishedWithSession:error:")]
		void Error (DGTSession session, NSError error);
	}
	
	// typedef void (^DGTUploadContactsCompletion)(DGTContactsUploadResult *, NSError *);
	delegate void DGTUploadContactsCompletion (DGTContactsUploadResult arg0, NSError arg1);
	
	// typedef void (^DGTLookupContactsCompletion)(NSArray *, NSString *, NSError *);
	delegate void DGTLookupContactsCompletion (NSObject[] arg0, string arg1, NSError arg2);
	
	// typedef void (^DGTDeleteAllUploadedContactsCompletion)(NSError *);
	delegate void DGTDeleteAllUploadedContactsCompletion (NSError arg0);
	
	// @interface DGTContacts : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface DGTContacts
	{
		// +(DGTContactAccessAuthorizationStatus)contactsAccessAuthorizationStatus;
		[Static]
		[Export ("contactsAccessAuthorizationStatus")]
		//[Verify (MethodToProperty)]
		DGTContactAccessAuthorizationStatus ContactsAccessAuthorizationStatus { get; }
	
		// -(instancetype)initWithUserSession:(DGTSession *)userSession;
		[Export ("initWithUserSession:")]
		IntPtr Constructor (DGTSession userSession);
	
		// -(void)startContactsUploadWithCompletion:(DGTUploadContactsCompletion)completion;
		[Export ("startContactsUploadWithCompletion:")]
		void StartContactsUploadWithCompletion (DGTUploadContactsCompletion completion);
	
		// -(void)startContactsUploadWithTitle:(NSString *)title completion:(DGTUploadContactsCompletion)completion;
		[Export ("startContactsUploadWithTitle:completion:")]
		void StartContactsUploadWithTitle (string title, DGTUploadContactsCompletion completion);
	
		// -(void)startContactsUploadWithPresenterViewController:(UIViewController *)presenterViewController title:(NSString *)title completion:(DGTUploadContactsCompletion)completion;
		[Export ("startContactsUploadWithPresenterViewController:title:completion:")]
		void StartContactsUploadWithPresenterViewController (UIViewController presenterViewController, string title, DGTUploadContactsCompletion completion);
	
		// -(void)startContactsUploadWithDigitsAppearance:(DGTAppearance *)appearance presenterViewController:(UIViewController *)presenterViewController title:(NSString *)title completion:(DGTUploadContactsCompletion)completion;
		[Export ("startContactsUploadWithDigitsAppearance:presenterViewController:title:completion:")]
		void StartContactsUploadWithDigitsAppearance (DGTAppearance appearance, UIViewController presenterViewController, string title, DGTUploadContactsCompletion completion);
	
		// -(void)lookupContactMatchesWithCursor:(NSString *)cursor completion:(DGTLookupContactsCompletion)completion;
		[Export ("lookupContactMatchesWithCursor:completion:")]
		void LookupContactMatchesWithCursor (string cursor, DGTLookupContactsCompletion completion);
	
		// -(void)deleteAllUploadedContactsWithCompletion:(DGTDeleteAllUploadedContactsCompletion)completion;
		[Export ("deleteAllUploadedContactsWithCompletion:")]
		void DeleteAllUploadedContactsWithCompletion (DGTDeleteAllUploadedContactsCompletion completion);
	}
	
	// @interface DGTContactsUploadResult : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface DGTContactsUploadResult
	{
		// @property (readonly, nonatomic) NSUInteger totalContacts;
		[Export ("totalContacts")]
		nuint TotalContacts { get; }
	
		// @property (readonly, nonatomic) NSUInteger numberOfUploadedContacts;
		[Export ("numberOfUploadedContacts")]
		nuint NumberOfUploadedContacts { get; }
	}
	
	// @interface DGTOAuthSigning : NSObject <TWTRCoreOAuthSigning>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface DGTOAuthSigning : ITWTRCoreOAuthSigning
	{
		// -(instancetype)initWithAuthConfig:(TWTRAuthConfig *)authConfig authSession:(DGTSession *)authSession __attribute__((objc_designated_initializer));
		[Export ("initWithAuthConfig:authSession:")]
		[DesignatedInitializer]
		IntPtr Constructor (TWTRAuthConfig authConfig, DGTSession authSession);
	
		// -(NSDictionary *)OAuthEchoHeadersToVerifyCredentialsWithParams:(NSDictionary *)params;
		[Export ("OAuthEchoHeadersToVerifyCredentialsWithParams:")]
		NSDictionary OAuthEchoHeadersToVerifyCredentialsWithParams (NSDictionary @params);
	}
	
	// @protocol DGTSessionUpdateDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface DGTSessionUpdateDelegate
	{
		// @required -(void)digitsSessionHasChanged:(DGTSession *)newSession;
		[Abstract]
		[Export ("digitsSessionHasChanged:")]
		void DigitsSessionHasChanged (DGTSession newSession);
	
		// @required -(void)digitsSessionExpiredForUserID:(NSString *)userID;
		[Abstract]
		[Export ("digitsSessionExpiredForUserID:")]
		void DigitsSessionExpiredForUserID (string userID);
	}
	
	// @interface DGTUser : NSObject
	[BaseType (typeof(NSObject))]
	interface DGTUser
	{
		// @property (readonly, copy, nonatomic) NSString * userID;
		[Export ("userID")]
		string UserID { get; }
	}
	
	// @interface Digits : NSObject
	[BaseType (typeof(NSObject))]
	interface Digits
	{
		// +(Digits * _Nonnull)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		//[Verify (MethodToProperty)]
		Digits SharedInstance { get; }
	
		// -(void)startWithConsumerKey:(NSString * _Nonnull)consumerKey consumerSecret:(NSString * _Nonnull)consumerSecret;
		[Export ("startWithConsumerKey:consumerSecret:")]
		void StartWithConsumerKey (string consumerKey, string consumerSecret);
	
		// -(void)startWithConsumerKey:(NSString * _Nonnull)consumerKey consumerSecret:(NSString * _Nonnull)consumerSecret accessGroup:(NSString * _Nullable)accessGroup;
		[Export ("startWithConsumerKey:consumerSecret:accessGroup:")]
		void StartWithConsumerKey (string consumerKey, string consumerSecret, [NullAllowed] string accessGroup);
	
		// -(DGTSession * _Nullable)session;
		[NullAllowed, Export ("session")]
		//[Verify (MethodToProperty)]
		DGTSession Session { get; }
	
		// @property (readonly, nonatomic, strong) TWTRAuthConfig * _Nonnull authConfig;
		[Export ("authConfig", ArgumentSemantic.Strong)]
		TWTRAuthConfig AuthConfig { get; }
	
		[Wrap ("WeakSessionUpdateDelegate")]
		[NullAllowed]
		DGTSessionUpdateDelegate SessionUpdateDelegate { get; set; }
	
		// @property (nonatomic, weak) id<DGTSessionUpdateDelegate> _Nullable sessionUpdateDelegate;
		[NullAllowed, Export ("sessionUpdateDelegate", ArgumentSemantic.Weak)]
		NSObject WeakSessionUpdateDelegate { get; set; }
	
		// -(void)authenticateWithCompletion:(DGTAuthenticationCompletion _Nonnull)completion __attribute__((availability(tvos, unavailable)));
		//[NoTV]
		[Export ("authenticateWithCompletion:")]
		void AuthenticateWithCompletion (DGTAuthenticationCompletion completion);
	
		// -(void)authenticateWithTitle:(NSString * _Nullable)title completion:(DGTAuthenticationCompletion _Nonnull)completion __attribute__((availability(tvos, unavailable))) __attribute__((deprecated("Use authenticateWithViewController:configuration:completion: instead.")));
		//[NoTV]
		[Export ("authenticateWithTitle:completion:")]
		void AuthenticateWithTitle ([NullAllowed] string title, DGTAuthenticationCompletion completion);
	
		// -(void)authenticateWithViewController:(UIViewController * _Nullable)viewController title:(NSString * _Nullable)title completion:(DGTAuthenticationCompletion _Nonnull)completion __attribute__((availability(tvos, unavailable))) __attribute__((deprecated("Use authenticateWithViewController:configuration:completion: instead.")));
		//[NoTV]
		[Export ("authenticateWithViewController:title:completion:")]
		void AuthenticateWithViewController ([NullAllowed] UIViewController viewController, [NullAllowed] string title, DGTAuthenticationCompletion completion);
	
		// -(void)authenticateWithDigitsAppearance:(DGTAppearance * _Nullable)appearance viewController:(UIViewController * _Nullable)viewController title:(NSString * _Nullable)title completion:(DGTAuthenticationCompletion _Nonnull)completion __attribute__((availability(tvos, unavailable))) __attribute__((deprecated("Use authenticateWithViewController:configuration:completion: instead.")));
		//[NoTV]
		[Export ("authenticateWithDigitsAppearance:viewController:title:completion:")]
		void AuthenticateWithDigitsAppearance ([NullAllowed] DGTAppearance appearance, [NullAllowed] UIViewController viewController, [NullAllowed] string title, DGTAuthenticationCompletion completion);
	
		// -(void)authenticateWithPhoneNumber:(NSString * _Nullable)phoneNumber digitsAppearance:(DGTAppearance * _Nullable)appearance viewController:(UIViewController * _Nullable)viewController title:(NSString * _Nullable)title completion:(DGTAuthenticationCompletion _Nonnull)completion __attribute__((availability(tvos, unavailable))) __attribute__((deprecated("Use authenticateWithViewController:configuration:completion: instead.")));
		//[NoTV]
		[Export ("authenticateWithPhoneNumber:digitsAppearance:viewController:title:completion:")]
		void AuthenticateWithPhoneNumber ([NullAllowed] string phoneNumber, [NullAllowed] DGTAppearance appearance, [NullAllowed] UIViewController viewController, [NullAllowed] string title, DGTAuthenticationCompletion completion);
	
		// -(void)authenticateWithNavigationViewController:(UINavigationController * _Nonnull)navigationController phoneNumber:(NSString * _Nullable)phoneNumber digitsAppearance:(DGTAppearance * _Nullable)appearance title:(NSString * _Nullable)title completionViewController:(UIViewController<DGTCompletionViewController> * _Nonnull)completionViewController __attribute__((availability(tvos, unavailable))) __attribute__((deprecated("Use authenticateWithNavigationViewController:configuration:completionViewController: instead.")));
		//[NoTV]
		[Export ("authenticateWithNavigationViewController:phoneNumber:digitsAppearance:title:completionViewController:")]
		void AuthenticateWithNavigationViewController (UINavigationController navigationController, [NullAllowed] string phoneNumber, [NullAllowed] DGTAppearance appearance, [NullAllowed] string title, DGTCompletionViewController completionViewController);
	
		// -(void)authenticateWithViewController:(UIViewController * _Nullable)viewController configuration:(DGTAuthenticationConfiguration * _Nonnull)configuration completion:(DGTAuthenticationCompletion _Nonnull)completion __attribute__((availability(tvos, unavailable)));
		//[NoTV]
		[Export ("authenticateWithViewController:configuration:completion:")]
		void AuthenticateWithViewController ([NullAllowed] UIViewController viewController, DGTAuthenticationConfiguration configuration, DGTAuthenticationCompletion completion);
	
		// -(void)authenticateWithNavigationViewController:(UINavigationController * _Nonnull)navigationController configuration:(DGTAuthenticationConfiguration * _Nonnull)configuration completionViewController:(UIViewController<DGTCompletionViewController> * _Nonnull)completionViewController __attribute__((availability(tvos, unavailable)));
		//[NoTV]
		[Export ("authenticateWithNavigationViewController:configuration:completionViewController:")]
		void AuthenticateWithNavigationViewController (UINavigationController navigationController, DGTAuthenticationConfiguration configuration, DGTCompletionViewController completionViewController);
	
		// -(void)logOut;
		[Export ("logOut")]
		void LogOut ();
	}
}

