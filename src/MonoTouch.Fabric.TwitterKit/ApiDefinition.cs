using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using MonoTouch.Fabric.TwitterCore;
using MonoTouch.Fabric.DigitsKit;

namespace MonoTouch.Fabric.TwitterKit
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

    // typedef void (^TWTRLoadUserCompletion)(TWTRUser *NSError *);
    delegate void TWTRLoadUserCompletion ([NullAllowed]TWTRUser arg0, [NullAllowed]NSError arg1);

    // typedef void (^TWTRLoadTweetCompletion)(TWTRTweet *NSError *);
    delegate void TWTRLoadTweetCompletion ([NullAllowed]TWTRTweet arg0, [NullAllowed]NSError arg1);

    // typedef void (^TWTRLoadTweetsCompletion)(NSArray *NSError *);
    delegate void TWTRLoadTweetsCompletion ([NullAllowed]NSObject[] arg0, [NullAllowed]NSError arg1);

    // typedef void (^TWTRNetworkCompletion)(NSURLResponse *NSData *NSError *);
    delegate void TWTRNetworkCompletion ([NullAllowed]NSUrlResponse arg0, [NullAllowed]NSData arg1, [NullAllowed]NSError arg2);

    // typedef void (^TWTRJSONRequestCompletion)(NSURLResponse *idNSError *);
    delegate void TWTRJSONRequestCompletion ([NullAllowed]NSUrlResponse arg0,[NullAllowed] NSObject arg1,[NullAllowed] NSError arg2);

    // typedef void (^TWTRTweetActionCompletion)(TWTRTweet *NSError *);
    delegate void TWTRTweetActionCompletion ([NullAllowed]TWTRTweet arg0, [NullAllowed]NSError arg1);

    // typedef void (^TWTRGuestLogInCompletion)(TWTRGuestSession *NSError *);
    delegate void TWTRGuestLogInCompletion ([NullAllowed]TWTRGuestSession arg0, [NullAllowed]NSError arg1);

    // typedef void (^TWTRLogInCompletion)(TWTRSession *NSError *);
    delegate void TWTRLogInCompletion ([NullAllowed]TWTRSession arg0, [NullAllowed]NSError arg1);
	
	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const DGTErrorDomain;
		[Field ("DGTErrorDomain", "__Internal")]
		NSString DGTErrorDomain { get; }
	}
	
	// typedef void (^DGTAuthenticationCompletion)(DGTSession *, NSError *);
	delegate void DGTAuthenticationCompletion (DGTSession arg0, NSError arg1);
	
	// typedef void (^DGTUploadContactsCompletion)(DGTContactsUploadResult *, NSError *);
	delegate void DGTUploadContactsCompletion (DGTContactsUploadResult arg0, NSError arg1);
	
	// typedef void (^DGTLookupContactsCompletion)(NSArray *, NSString *, NSError *);
	delegate void DGTLookupContactsCompletion (NSObject[] arg0, string arg1, NSError arg2);
	
	// typedef void (^DGTDeleteAllUploadedContactsCompletion)(NSError *);
	delegate void DGTDeleteAllUploadedContactsCompletion (NSError arg0);
	
	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int FOUNDATION_EXPORT;
		[Field ("FOUNDATION_EXPORT", "__Internal")]
		int FOUNDATION_EXPORT { get; }
	}

	// @interface TWTRAPIClient
	[BaseType (typeof(NSObject))]
	interface TWTRAPIClient
	{
		// @property (readonly, copy, nonatomic) int * userID;
		[Export ("userID", ArgumentSemantic.Copy)]
		string UserID { get; }
	
		// -(instancetype)initWithUserID:(id)userID;
		[Export ("initWithUserID:")]
		IntPtr Constructor (NSObject userID);
	
		// -(id)URLRequestWithMethod:(id)method URL:(id)URLString parameters:(id)parameters error:(id)error;
		[Export ("URLRequestWithMethod:URL:parameters:error:")]
		NSObject URLRequestWithMethod (NSObject method, NSObject URLString, NSObject parameters, NSObject error);
	
		// -(void)sendTwitterRequest:(id)request completion:(TWTRNetworkCompletion)completion;
		[Export ("sendTwitterRequest:completion:")]
		void SendTwitterRequest (NSObject request, TWTRNetworkCompletion completion);
	
		// -(void)loadUserWithID:(id)userID completion:(TWTRLoadUserCompletion)completion;
		[Export ("loadUserWithID:completion:")]
		void LoadUserWithID (NSObject userID, TWTRLoadUserCompletion completion);
	
		// -(void)loadTweetWithID:(id)tweetID completion:(TWTRLoadTweetCompletion)completion;
		[Export ("loadTweetWithID:completion:")]
		void LoadTweetWithID (NSObject tweetID, TWTRLoadTweetCompletion completion);
	
		// -(void)loadTweetsWithIDs:(id)tweetIDStrings completion:(TWTRLoadTweetsCompletion)completion;
		[Export ("loadTweetsWithIDs:completion:")]
		void LoadTweetsWithIDs (NSObject tweetIDStrings, TWTRLoadTweetsCompletion completion);
	}
	
	// @interface TWTRCardConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TWTRCardConfiguration
	{
		// @property (readonly, nonatomic) TWTRCardType cardType;
		[Export ("cardType")]
		TWTRCardType CardType { get; }
	
		// @property (readonly, copy, nonatomic) NSString * _Nonnull cardTitle;
		[Export ("cardTitle")]
		string CardTitle { get; }
	
		// @property (readonly, copy, nonatomic) NSString * _Nonnull cardDescription;
		[Export ("cardDescription")]
		string CardDescription { get; }
	
		// @property (readonly, nonatomic) UIImage * _Nonnull image;
		[Export ("image")]
		UIImage Image { get; }
	
		// +(TWTRCardConfiguration * _Nonnull)appCardConfigurationWithPromoImage:(UIImage * _Nonnull)promoImage iPhoneAppID:(id)iPhoneAppID iPadAppID:(id)iPadAppID googlePlayAppID:(id)googlePlayAppID;
		[Static]
		[Export ("appCardConfigurationWithPromoImage:iPhoneAppID:iPadAppID:googlePlayAppID:")]
		TWTRCardConfiguration AppCardConfigurationWithPromoImage (UIImage promoImage, NSObject iPhoneAppID, NSObject iPadAppID, NSObject googlePlayAppID);
	}
	
	// typedef void (^TWTRLoadTimelineCompletion)(NSArray * _Nonnull);
	delegate void TWTRLoadTimelineCompletion (NSObject[] arg0);
	
	// @protocol TWTRTimelineDataSource <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface TWTRTimelineDataSource
	{
		// @required -(void)loadPreviousTweetsBeforePosition:(NSString * _Nonnull)position completion:(TWTRLoadTimelineCompletion _Nonnull)completion;
		[Abstract]
		[Export ("loadPreviousTweetsBeforePosition:completion:")]
		void Completion (string position, TWTRLoadTimelineCompletion completion);
	
		// @required @property (readonly, nonatomic) TWTRTimelineType timelineType;
		[Export ("timelineType")]
		TWTRTimelineType TimelineType { get; }
	
		// @required @property (nonatomic) TWTRAPIClient * _Nonnull APIClient;
		[Export ("APIClient", ArgumentSemantic.Assign)]
		TWTRAPIClient APIClient { get; set; }
	}
	
	// @interface TWTRCollectionTimelineDataSource : NSObject <TWTRTimelineDataSource>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TWTRCollectionTimelineDataSource : TWTRTimelineDataSource
	{
		// @property (readonly, assign, nonatomic) NSInteger maxTweetsPerRequest;
		[Export ("maxTweetsPerRequest")]
		nint MaxTweetsPerRequest { get; }
	
		// @property (readonly, copy, nonatomic) NSString * _Nonnull collectionID;
		[Export ("collectionID")]
		string CollectionID { get; }
	
		// -(instancetype _Nonnull)initWithCollectionID:(NSString * _Nonnull)collectionID APIClient:(TWTRAPIClient * _Nonnull)client;
		[Export ("initWithCollectionID:APIClient:")]
		IntPtr Constructor (string collectionID, TWTRAPIClient client);
	
		// -(instancetype _Nonnull)initWithCollectionID:(NSString * _Nonnull)collectionID APIClient:(TWTRAPIClient * _Nonnull)client maxTweetsPerRequest:(NSUInteger)maxTweetsPerRequest __attribute__((objc_designated_initializer));
		[Export ("initWithCollectionID:APIClient:maxTweetsPerRequest:")]
		[DesignatedInitializer]
		IntPtr Constructor (string collectionID, TWTRAPIClient client, nuint maxTweetsPerRequest);
	}
	
	// typedef void (^TWTRComposerCompletion)(TWTRComposerResult);
	delegate void TWTRComposerCompletion (TWTRComposerResult arg0);
	
	// @interface TWTRComposer : NSObject
	[BaseType (typeof(NSObject))]
	interface TWTRComposer
	{
		// -(BOOL)setText:(id)text;
		[Export ("setText:")]
		bool SetText (NSObject text);
	
		// -(BOOL)setImage:(id)image;
		[Export ("setImage:")]
		bool SetImage (NSObject image);
	
		// -(BOOL)setURL:(id)url;
		[Export ("setURL:")]
		bool SetURL (NSObject url);
	
		// -(void)showFromViewController:(UIViewController * _Nonnull)fromController completion:(TWTRComposerCompletion _Nonnull)completion;
		[Export ("showFromViewController:completion:")]
		void ShowFromViewController (UIViewController fromController, TWTRComposerCompletion completion);
	}
	
	// @interface TWTRDeprecated (TWTRComposer)
	[Category]
	[BaseType (typeof(TWTRComposer))]
	interface TWTRComposer_TWTRDeprecated
	{
		// -(void)showWithCompletion:(TWTRComposerCompletion _Nonnull)completion;
		[Export ("showWithCompletion:")]
		void ShowWithCompletion (TWTRComposerCompletion completion);
	}
	
	// @interface TWTRComposerTheme : NSObject
	[BaseType (typeof(NSObject))]
	interface TWTRComposerTheme
	{
		// -(instancetype)initWithThemeType:(TWTRComposerThemeType)type __attribute__((objc_designated_initializer));
		[Export ("initWithThemeType:")]
		[DesignatedInitializer]
		IntPtr Constructor (TWTRComposerThemeType type);
	}
	
	// @interface TWTRComposerViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	[DisableDefaultCtor]
	interface TWTRComposerViewController
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		TWTRComposerViewControllerDelegate Delegate { get; set; }
	
		// @property (nonatomic, weak) id<TWTRComposerViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	
		// @property (nonatomic) TWTRComposerTheme * _Nonnull theme;
		[Export ("theme", ArgumentSemantic.Assign)]
		TWTRComposerTheme Theme { get; set; }
	
		// -(instancetype _Nonnull)initWithUserID:(NSString * _Nonnull)userID;
		[Export ("initWithUserID:")]
		IntPtr Constructor (string userID);
	
		// -(instancetype _Nonnull)initWithUserID:(NSString * _Nonnull)userID cardConfiguration:(id)cardConfig;
		[Export ("initWithUserID:cardConfiguration:")]
		IntPtr Constructor (string userID, NSObject cardConfig);
	}
	
	// @protocol TWTRComposerViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface TWTRComposerViewControllerDelegate
	{
		// @optional -(void)composerDidCancel:(TWTRComposerViewController * _Nonnull)controller;
		[Export ("composerDidCancel:")]
		void ComposerDidCancel (TWTRComposerViewController controller);
	
		// @optional -(void)composerDidSucceed:(TWTRComposerViewController * _Nonnull)controller withTweet:(TWTRTweet * _Nonnull)tweet;
		[Export ("composerDidSucceed:withTweet:")]
		void ComposerDidSucceed (TWTRComposerViewController controller, TWTRTweet tweet);
	
		// @optional -(void)composerDidFail:(TWTRComposerViewController * _Nonnull)controller withError:(NSError * _Nonnull)error;
		[Export ("composerDidFail:withError:")]
		void ComposerDidFail (TWTRComposerViewController controller, NSError error);
	}
	
	// @interface TWTRListTimelineDataSource : NSObject <TWTRTimelineDataSource>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TWTRListTimelineDataSource : TWTRTimelineDataSource
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull listID;
		[Export ("listID")]
		string ListID { get; }
	
		// @property (readonly, copy, nonatomic) NSString * _Nonnull listSlug;
		[Export ("listSlug")]
		string ListSlug { get; }
	
		// @property (readonly, copy, nonatomic) NSString * _Nonnull listOwnerScreenName;
		[Export ("listOwnerScreenName")]
		string ListOwnerScreenName { get; }
	
		// @property (readonly, assign, nonatomic) NSUInteger maxTweetsPerRequest;
		[Export ("maxTweetsPerRequest")]
		nuint MaxTweetsPerRequest { get; }
	
		// @property (readonly, assign, nonatomic) BOOL includeRetweets;
		[Export ("includeRetweets")]
		bool IncludeRetweets { get; }
	
		// -(instancetype _Nonnull)initWithListID:(NSString * _Nonnull)listID APIClient:(TWTRAPIClient * _Nonnull)client;
		[Export ("initWithListID:APIClient:")]
		IntPtr Constructor (string listID, TWTRAPIClient client);
	
		// -(instancetype _Nonnull)initWithListSlug:(NSString * _Nonnull)listSlug listOwnerScreenName:(NSString * _Nonnull)listOwnerScreenName APIClient:(TWTRAPIClient * _Nonnull)client;
		[Export ("initWithListSlug:listOwnerScreenName:APIClient:")]
		IntPtr Constructor (string listSlug, string listOwnerScreenName, TWTRAPIClient client);
	
		// -(instancetype _Nonnull)initWithListID:(NSString * _Nonnull)listID listSlug:(NSString * _Nonnull)listSlug listOwnerScreenName:(NSString * _Nonnull)listOwnerScreenName APIClient:(TWTRAPIClient * _Nonnull)client maxTweetsPerRequest:(NSUInteger)maxTweetsPerRequest includeRetweets:(BOOL)includeRetweets __attribute__((objc_designated_initializer));
		[Export ("initWithListID:listSlug:listOwnerScreenName:APIClient:maxTweetsPerRequest:includeRetweets:")]
		[DesignatedInitializer]
		IntPtr Constructor (string listID, string listSlug, string listOwnerScreenName, TWTRAPIClient client, nuint maxTweetsPerRequest, bool includeRetweets);
	}
	
	// @interface TWTRLogInButton : UIButton
	[BaseType (typeof(UIButton))]
	interface TWTRLogInButton
	{
		// @property (copy, nonatomic) TWTRLogInCompletion logInCompletion;
		[Export ("logInCompletion", ArgumentSemantic.Copy)]
		TWTRLogInCompletion LogInCompletion { get; set; }
	
		// +(instancetype)buttonWithLogInCompletion:(TWTRLogInCompletion)completion;
		[Static]
		[Export ("buttonWithLogInCompletion:")]
		TWTRLogInButton ButtonWithLogInCompletion (TWTRLogInCompletion completion);
	}
	
	// @interface TWTROAuthSigning : NSObject <TWTRCoreOAuthSigning>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TWTROAuthSigning : ITWTRCoreOAuthSigning
	{
		// -(instancetype)initWithAuthConfig:(TWTRAuthConfig *)authConfig authSession:(TWTRSession *)authSession __attribute__((objc_designated_initializer));
		[Export ("initWithAuthConfig:authSession:")]
		[DesignatedInitializer]
		IntPtr Constructor (TWTRAuthConfig authConfig, TWTRSession authSession);
	}
	
	// @interface TWTRSearchTimelineDataSource : NSObject <TWTRTimelineDataSource>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TWTRSearchTimelineDataSource : TWTRTimelineDataSource
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull searchQuery;
		[Export ("searchQuery")]
		string SearchQuery { get; }
	
		// @property (readonly, copy, nonatomic) NSString * _Nullable languageCode;
		[NullAllowed, Export ("languageCode")]
		string LanguageCode { get; }
	
		// @property (readonly, assign, nonatomic) NSUInteger maxTweetsPerRequest;
		[Export ("maxTweetsPerRequest")]
		nuint MaxTweetsPerRequest { get; }
	
		// -(instancetype _Nonnull)initWithSearchQuery:(NSString * _Nonnull)searchQuery APIClient:(TWTRAPIClient * _Nonnull)client;
		[Export ("initWithSearchQuery:APIClient:")]
		IntPtr Constructor (string searchQuery, TWTRAPIClient client);
	
		// -(instancetype _Nonnull)initWithSearchQuery:(NSString * _Nonnull)searchQuery APIClient:(TWTRAPIClient * _Nonnull)client languageCode:(NSString * _Nullable)languageCode maxTweetsPerRequest:(NSUInteger)maxTweetsPerRequest __attribute__((objc_designated_initializer));
		[Export ("initWithSearchQuery:APIClient:languageCode:maxTweetsPerRequest:")]
		[DesignatedInitializer]
		IntPtr Constructor (string searchQuery, TWTRAPIClient client, [NullAllowed] string languageCode, nuint maxTweetsPerRequest);
	}
	
	// typedef void (^TWTRShareEmailCompletion)(NSString * _Nullable, NSError * _Nullable);
	delegate void TWTRShareEmailCompletion ([NullAllowed] string arg0, [NullAllowed] NSError arg1);
	
	// @interface TWTRShareEmailViewController : UINavigationController
	[BaseType (typeof(UINavigationController))]
	interface TWTRShareEmailViewController
	{
		// @property (copy, nonatomic) TWTRShareEmailCompletion _Nonnull completion;
		[Export ("completion", ArgumentSemantic.Copy)]
		TWTRShareEmailCompletion Completion { get; set; }
	
		// -(instancetype _Nonnull)initWithCompletion:(TWTRShareEmailCompletion _Nullable)completion;
		[Export ("initWithCompletion:")]
		IntPtr Constructor ([NullAllowed] TWTRShareEmailCompletion completion);
	
		// -(instancetype _Nonnull)initWithUserID:(NSString * _Nullable)userID completion:(TWTRShareEmailCompletion _Nullable)completion;
		[Export ("initWithUserID:completion:")]
		IntPtr Constructor ([NullAllowed] string userID, [NullAllowed] TWTRShareEmailCompletion completion);
	}
	
	// @interface TWTRTimelineViewController : UITableViewController
	[BaseType (typeof(UITableViewController))]
	interface TWTRTimelineViewController
	{
		// -(instancetype)initWithDataSource:(id<TWTRTimelineDataSource>)dataSource;
		[Export ("initWithDataSource:")]
		IntPtr Constructor (TWTRTimelineDataSource dataSource);
	
		// @property (nonatomic, strong) id<TWTRTimelineDataSource> dataSource;
		[Export ("dataSource", ArgumentSemantic.Strong)]
		TWTRTimelineDataSource DataSource { get; set; }
	
		// @property (assign, nonatomic) BOOL showTweetActions;
		[Export ("showTweetActions")]
		bool ShowTweetActions { get; set; }
	
		// -(void)refresh;
		[Export ("refresh")]
		void Refresh ();
	}
	
	// @interface TWTRTweet : NSObject <NSCoding>
	[BaseType (typeof(NSObject))]
	interface TWTRTweet : INSCoding
	{
		// @property (readonly, copy, nonatomic) NSString * tweetID;
		[Export ("tweetID")]
		string TweetID { get; }
	
		// @property (readonly, copy, nonatomic) NSDate * createdAt;
		[Export ("createdAt", ArgumentSemantic.Copy)]
		NSDate CreatedAt { get; }
	
		// @property (readonly, copy, nonatomic) NSString * text;
		[Export ("text")]
		string Text { get; }
	
		// @property (readonly, nonatomic, strong) TWTRUser * author;
		[Export ("author", ArgumentSemantic.Strong)]
		TWTRUser Author { get; }
	
		// @property (readonly, assign, nonatomic) long long favoriteCount __attribute__((deprecated("Use `likeCount`.")));
		[Export ("favoriteCount")]
		long FavoriteCount { get; }
	
		// @property (readonly, assign, nonatomic) long long likeCount;
		[Export ("likeCount")]
		long LikeCount { get; }
	
		// @property (readonly, assign, nonatomic) long long retweetCount;
		[Export ("retweetCount")]
		long RetweetCount { get; }
	
		// @property (readonly, copy, nonatomic) NSString * inReplyToTweetID;
		[Export ("inReplyToTweetID")]
		string InReplyToTweetID { get; }
	
		// @property (readonly, copy, nonatomic) NSString * inReplyToUserID;
		[Export ("inReplyToUserID")]
		string InReplyToUserID { get; }
	
		// @property (readonly, copy, nonatomic) NSString * inReplyToScreenName;
		[Export ("inReplyToScreenName")]
		string InReplyToScreenName { get; }
	
		// @property (readonly, copy, nonatomic) NSURL * permalink;
		[Export ("permalink", ArgumentSemantic.Copy)]
		NSUrl Permalink { get; }
	
		// @property (readonly, assign, nonatomic) BOOL isFavorited __attribute__((deprecated("Use `isLiked`.")));
		[Export ("isFavorited")]
		bool IsFavorited { get; }
	
		// @property (readonly, assign, nonatomic) BOOL isLiked;
		[Export ("isLiked")]
		bool IsLiked { get; }
	
		// @property (readonly, assign, nonatomic) BOOL isRetweeted;
		[Export ("isRetweeted")]
		bool IsRetweeted { get; }
	
		// @property (readonly, copy, nonatomic) NSString * retweetID;
		[Export ("retweetID")]
		string RetweetID { get; }
	
		// @property (readonly, nonatomic, strong) TWTRTweet * retweetedTweet;
		[Export ("retweetedTweet", ArgumentSemantic.Strong)]
		TWTRTweet RetweetedTweet { get; }
	
		// @property (readonly, assign, nonatomic) BOOL isRetweet;
		[Export ("isRetweet")]
		bool IsRetweet { get; }
	
		// -(instancetype)initWithJSONDictionary:(NSDictionary *)dictionary;
		[Export ("initWithJSONDictionary:")]
		IntPtr Constructor (NSDictionary dictionary);
	
		// +(NSArray *)tweetsWithJSONArray:(NSArray *)array;
		[Static]
		[Export ("tweetsWithJSONArray:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] TweetsWithJSONArray (NSObject[] array);
	
		// -(TWTRTweet *)tweetWithFavoriteToggled __attribute__((deprecated("Use `tweetWithLikeToggled`.")));
		[Export ("tweetWithFavoriteToggled")]
		//[Verify (MethodToProperty)]
		TWTRTweet TweetWithFavoriteToggled { get; }
	
		// -(TWTRTweet *)tweetWithLikeToggled;
		[Export ("tweetWithLikeToggled")]
		//[Verify (MethodToProperty)]
		TWTRTweet TweetWithLikeToggled { get; }
	}
	
	// @interface TWTRTweetTableViewCell : UITableViewCell
	[BaseType (typeof(UITableViewCell))]
	interface TWTRTweetTableViewCell
	{
		// @property (readonly, nonatomic, strong) TWTRTweetView * tweetView;
		[Export ("tweetView", ArgumentSemantic.Strong)]
		TWTRTweetView TweetView { get; }
	
		// -(void)configureWithTweet:(TWTRTweet *)tweet;
		[Export ("configureWithTweet:")]
		void ConfigureWithTweet (TWTRTweet tweet);
	
		// +(CGFloat)heightForTweet:(TWTRTweet *)tweet width:(CGFloat)width showingActions:(BOOL)actionsAreVisible;
		[Static]
		[Export ("heightForTweet:width:showingActions:")]
		nfloat HeightForTweet (TWTRTweet tweet, nfloat width, bool actionsAreVisible);
	
		// +(CGFloat)heightForTweet:(TWTRTweet *)tweet width:(CGFloat)width;
		[Static]
		[Export ("heightForTweet:width:")]
		nfloat HeightForTweet (TWTRTweet tweet, nfloat width);
	
		// -(CGFloat)calculatedHeightForWidth:(CGFloat)width __attribute__((deprecated("Use +heightForTweet:width: instead.")));
		[Export ("calculatedHeightForWidth:")]
		nfloat CalculatedHeightForWidth (nfloat width);
	}
	
	// typedef void (^TWTRAuthenticationCompletionHandler)(id<TWTRSessionStore> _Nonnull, NSString * _Nonnull);
	delegate void TWTRAuthenticationCompletionHandler (TWTRSessionStore arg0, string arg1);
	
	// @protocol TWTRTweetViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface TWTRTweetViewDelegate
	{
		// @optional -(void)tweetView:(TWTRTweetView * _Nonnull)tweetView didSelectTweet:(TWTRTweet * _Nonnull)tweet;
		[Export ("tweetView:didSelectTweet:")]
		void DidSelectTweet (TWTRTweetView tweetView, TWTRTweet tweet);
	
		// @optional -(void)tweetView:(TWTRTweetView * _Nonnull)tweetView didTapImage:(UIImage * _Nonnull)image withURL:(NSURL * _Nonnull)imageURL;
		[Export ("tweetView:didTapImage:withURL:")]
		void DidTapImage (TWTRTweetView tweetView, UIImage image, NSUrl imageURL);
	
		// @optional -(void)tweetView:(TWTRTweetView * _Nonnull)tweetView didTapVideoWithURL:(NSURL * _Nonnull)videoURL;
		[Export ("tweetView:didTapVideoWithURL:")]
		void DidTapVideoWithURL (TWTRTweetView tweetView, NSUrl videoURL);
	
		// @optional -(void)tweetView:(TWTRTweetView * _Nonnull)tweetView didTapURL:(NSURL * _Nonnull)url;
		[Export ("tweetView:didTapURL:")]
		void DidTapURL (TWTRTweetView tweetView, NSUrl url);
	
		// @optional -(void)tweetView:(TWTRTweetView * _Nonnull)tweetView didTapProfileImageForUser:(TWTRUser * _Nonnull)user;
		[Export ("tweetView:didTapProfileImageForUser:")]
		void DidTapProfileImageForUser (TWTRTweetView tweetView, TWTRUser user);
	
		// @optional -(void)tweetView:(TWTRTweetView * _Nonnull)tweetView willShareTweet:(TWTRTweet * _Nonnull)tweet;
		[Export ("tweetView:willShareTweet:")]
		void WillShareTweet (TWTRTweetView tweetView, TWTRTweet tweet);
	
		// @optional -(void)tweetView:(TWTRTweetView * _Nonnull)tweetView didShareTweet:(TWTRTweet * _Nonnull)tweet withType:(NSString * _Nonnull)shareType;
		[Export ("tweetView:didShareTweet:withType:")]
		void DidShareTweet (TWTRTweetView tweetView, TWTRTweet tweet, string shareType);
	
		// @optional -(void)tweetView:(TWTRTweetView * _Nonnull)tweetView cancelledShareTweet:(TWTRTweet * _Nonnull)tweet;
		[Export ("tweetView:cancelledShareTweet:")]
		void CancelledShareTweet (TWTRTweetView tweetView, TWTRTweet tweet);
	
		// @optional -(void)tweetView:(TWTRTweetView * _Nonnull)tweetView didLikeTweet:(TWTRTweet * _Nonnull)tweet;
		[Export ("tweetView:didLikeTweet:")]
		void DidLikeTweet (TWTRTweetView tweetView, TWTRTweet tweet);
	
		// @optional -(void)tweetView:(TWTRTweetView * _Nonnull)tweetView didUnlikeTweet:(TWTRTweet * _Nonnull)tweet;
		[Export ("tweetView:didUnlikeTweet:")]
		void DidUnlikeTweet (TWTRTweetView tweetView, TWTRTweet tweet);
	
		// @optional -(void)tweetView:(TWTRTweetView * _Nonnull)tweetView willRequireAuthenticationCompletionHandler:(TWTRAuthenticationCompletionHandler _Nonnull)authenticationCompletionHandler;
		[Export ("tweetView:willRequireAuthenticationCompletionHandler:")]
		void WillRequireAuthenticationCompletionHandler (TWTRTweetView tweetView, TWTRAuthenticationCompletionHandler authenticationCompletionHandler);
	
		// @optional -(void)tweetView:(TWTRTweetView * _Nonnull)tweetView didFavoriteTweet:(TWTRTweet * _Nonnull)tweet __attribute__((deprecated("Use `tweetView:didLikeTweet:`.")));
		[Export ("tweetView:didFavoriteTweet:")]
		void DidFavoriteTweet (TWTRTweetView tweetView, TWTRTweet tweet);
	
		// @optional -(void)tweetView:(TWTRTweetView * _Nonnull)tweetView didUnfavoriteTweet:(TWTRTweet * _Nonnull)tweet __attribute__((deprecated("Use `tweetView:didUnlikeTweet:`.")));
		[Export ("tweetView:didUnfavoriteTweet:")]
		void DidUnfavoriteTweet (TWTRTweetView tweetView, TWTRTweet tweet);
	}
	
	// @interface TWTRTweetView : UIView <UIAppearanceContainer>
	[BaseType (typeof(UIView))]
	interface TWTRTweetView : IUIAppearanceContainer
	{
		// @property (nonatomic, strong) UIColor * backgroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }
	
		// @property (nonatomic, strong) UIColor * primaryTextColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("primaryTextColor", ArgumentSemantic.Strong)]
		UIColor PrimaryTextColor { get; set; }
	
		// @property (nonatomic, strong) UIColor * linkTextColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("linkTextColor", ArgumentSemantic.Strong)]
		UIColor LinkTextColor { get; set; }
	
		// @property (assign, nonatomic) BOOL showBorder __attribute__((annotate("ui_appearance_selector")));
		[Export ("showBorder")]
		bool ShowBorder { get; set; }
	
		// @property (assign, nonatomic) BOOL showActionButtons;
		[Export ("showActionButtons")]
		bool ShowActionButtons { get; set; }
	
		// @property (assign, nonatomic) TWTRTweetViewTheme theme __attribute__((annotate("ui_appearance_selector")));
		[Export ("theme", ArgumentSemantic.Assign)]
		TWTRTweetViewTheme Theme { get; set; }
	
		// @property (readonly, assign, nonatomic) TWTRTweetViewStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		TWTRTweetViewStyle Style { get; }
	
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		TWTRTweetViewDelegate Delegate { get; set; }
	
		// @property (nonatomic, weak) id<TWTRTweetViewDelegate> _Nullable delegate __attribute__((iboutlet));
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	
		// @property (nonatomic, weak) UIViewController * _Nullable presenterViewController;
		[NullAllowed, Export ("presenterViewController", ArgumentSemantic.Weak)]
		UIViewController PresenterViewController { get; set; }
	
		// -(instancetype)initWithTweet:(TWTRTweet *)tweet;
		[Export ("initWithTweet:")]
		IntPtr Constructor (TWTRTweet tweet);
	
		// -(instancetype)initWithTweet:(TWTRTweet *)tweet style:(TWTRTweetViewStyle)style;
		[Export ("initWithTweet:style:")]
		IntPtr Constructor (TWTRTweet tweet, TWTRTweetViewStyle style);
	
		// -(CGSize)sizeThatFits:(CGSize)size;
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);
	
		// -(void)configureWithTweet:(TWTRTweet *)tweet;
		[Export ("configureWithTweet:")]
		void ConfigureWithTweet (TWTRTweet tweet);
	}
	
	// @interface TWTRUser : NSObject <NSCoding, NSCopying>
	[BaseType (typeof(NSObject))]
	interface TWTRUser : INSCoding, INSCopying
	{
		// @property (readonly, copy, nonatomic) NSString * userID;
		[Export ("userID")]
		string UserID { get; }
	
		// @property (readonly, copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; }
	
		// @property (readonly, copy, nonatomic) NSString * screenName;
		[Export ("screenName")]
		string ScreenName { get; }
	
		// @property (readonly, assign, nonatomic) BOOL isVerified;
		[Export ("isVerified")]
		bool IsVerified { get; }
	
		// @property (readonly, assign, nonatomic) BOOL isProtected;
		[Export ("isProtected")]
		bool IsProtected { get; }
	
		// @property (readonly, copy, nonatomic) NSString * profileImageURL;
		[Export ("profileImageURL")]
		string ProfileImageURL { get; }
	
		// @property (readonly, copy, nonatomic) NSString * profileImageMiniURL;
		[Export ("profileImageMiniURL")]
		string ProfileImageMiniURL { get; }
	
		// @property (readonly, copy, nonatomic) NSString * profileImageLargeURL;
		[Export ("profileImageLargeURL")]
		string ProfileImageLargeURL { get; }
	
		// @property (readonly, copy, nonatomic) NSString * formattedScreenName;
		[Export ("formattedScreenName")]
		string FormattedScreenName { get; }
	
		// @property (readonly, copy, nonatomic) NSURL * profileURL;
		[Export ("profileURL", ArgumentSemantic.Copy)]
		NSUrl ProfileURL { get; }
	
		// -(instancetype)initWithJSONDictionary:(NSDictionary *)dictionary;
		[Export ("initWithJSONDictionary:")]
		IntPtr Constructor (NSDictionary dictionary);
	
		// +(NSArray *)usersWithJSONArray:(NSArray *)array;
		[Static]
		[Export ("usersWithJSONArray:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] UsersWithJSONArray (NSObject[] array);
	}
	
	// @interface TWTRUserTimelineDataSource : NSObject <TWTRTimelineDataSource>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TWTRUserTimelineDataSource : TWTRTimelineDataSource
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull screenName;
		[Export ("screenName")]
		string ScreenName { get; }
	
		// @property (readonly, copy, nonatomic) NSString * _Nonnull userID;
		[Export ("userID")]
		string UserID { get; }
	
		// @property (readonly, assign, nonatomic) NSUInteger maxTweetsPerRequest;
		[Export ("maxTweetsPerRequest")]
		nuint MaxTweetsPerRequest { get; }
	
		// @property (readonly, assign, nonatomic) BOOL includeReplies;
		[Export ("includeReplies")]
		bool IncludeReplies { get; }
	
		// @property (readonly, assign, nonatomic) BOOL includeRetweets;
		[Export ("includeRetweets")]
		bool IncludeRetweets { get; }
	
		// -(instancetype _Nonnull)initWithScreenName:(NSString * _Nonnull)screenName APIClient:(TWTRAPIClient * _Nonnull)client;
		[Export ("initWithScreenName:APIClient:")]
		IntPtr Constructor (string screenName, TWTRAPIClient client);
	
		// -(instancetype _Nonnull)initWithScreenName:(NSString * _Nullable)screenName userID:(NSString * _Nullable)userID APIClient:(TWTRAPIClient * _Nonnull)client maxTweetsPerRequest:(NSUInteger)maxTweetsPerRequest includeReplies:(BOOL)includeReplies includeRetweets:(BOOL)includeRetweets __attribute__((objc_designated_initializer));
		[Export ("initWithScreenName:userID:APIClient:maxTweetsPerRequest:includeReplies:includeRetweets:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string screenName, [NullAllowed] string userID, TWTRAPIClient client, nuint maxTweetsPerRequest, bool includeReplies, bool includeRetweets);
	}
	
	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull TWTRUserDidLogOutNotification;
		[Field ("TWTRUserDidLogOutNotification", "__Internal")]
		NSString TWTRUserDidLogOutNotification { get; }
	
		// extern NSString *const _Nonnull TWTRLoggedOutUserIDKey;
		[Field ("TWTRLoggedOutUserIDKey", "__Internal")]
		NSString TWTRLoggedOutUserIDKey { get; }
	}
	
	// @interface Twitter : NSObject
	[BaseType (typeof(NSObject))]
	interface Twitter
	{
		// +(Twitter * _Nonnull)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		//[Verify (MethodToProperty)]
		Twitter SharedInstance { get; }
	
		// -(void)startWithConsumerKey:(NSString * _Nonnull)consumerKey consumerSecret:(NSString * _Nonnull)consumerSecret;
		[Export ("startWithConsumerKey:consumerSecret:")]
		void StartWithConsumerKey (string consumerKey, string consumerSecret);
	
		// -(void)startWithConsumerKey:(NSString * _Nonnull)consumerKey consumerSecret:(NSString * _Nonnull)consumerSecret accessGroup:(NSString * _Nullable)accessGroup;
		[Export ("startWithConsumerKey:consumerSecret:accessGroup:")]
		void StartWithConsumerKey (string consumerKey, string consumerSecret, [NullAllowed] string accessGroup);
	
		// @property (readonly, copy, nonatomic) NSString * _Nonnull version;
		[Export ("version")]
		string Version { get; }
	
		// @property (readonly, nonatomic, strong) TWTRAuthConfig * _Nonnull authConfig;
		[Export ("authConfig", ArgumentSemantic.Strong)]
		TWTRAuthConfig AuthConfig { get; }
	
		// @property (readonly, nonatomic, strong) TWTRSessionStore * _Nonnull sessionStore;
		[Export ("sessionStore", ArgumentSemantic.Strong)]
		TWTRSessionStore SessionStore { get; }
	
		// -(void)logInWithCompletion:(TWTRLogInCompletion _Nonnull)completion;
		[Export ("logInWithCompletion:")]
		void LogInWithCompletion (TWTRLogInCompletion completion);
	
		// -(void)logInWithViewController:(UIViewController * _Nullable)viewController completion:(TWTRLogInCompletion _Nonnull)completion;
		[Export ("logInWithViewController:completion:")]
		void LogInWithViewController ([NullAllowed] UIViewController viewController, TWTRLogInCompletion completion);
	}

/*  Had issues so commented it out
	// @interface TWTRDeprecated (Twitter)
	[Category]
	[BaseType (typeof(Twitter))]
	interface Twitter_TWTRDeprecated
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull consumerKey __attribute__((deprecated("Use `authConfig`. This property will be removed in a later release.")));
		[Export ("consumerKey")]
		string ConsumerKey { get; }
	
		// @property (readonly, copy, nonatomic) NSString * _Nonnull consumerSecret __attribute__((deprecated("Use `authConfig`. This property will be removed in a later release.")));
		[Export ("consumerSecret")]
		string ConsumerSecret { get; }
	
		// -(void)logInGuestWithCompletion:(TWTRGuestLogInCompletion _Nonnull)completion;
		[Export ("logInGuestWithCompletion:")]
		void LogInGuestWithCompletion (TWTRGuestLogInCompletion completion);
	
		// -(void)logInWithExistingAuthToken:(NSString * _Nonnull)authToken authTokenSecret:(NSString * _Nonnull)authTokenSecret completion:(TWTRLogInCompletion _Nonnull)completion;
		[Export ("logInWithExistingAuthToken:authTokenSecret:completion:")]
		void LogInWithExistingAuthToken (string authToken, string authTokenSecret, TWTRLogInCompletion completion);
	
		// @property (readonly, nonatomic, strong) TWTRAPIClient * _Nonnull APIClient;
		[Export ("APIClient", ArgumentSemantic.Strong)]
		TWTRAPIClient APIClient { get; }
	
		// -(TWTRSession * _Nullable)session;
		[NullAllowed, Export ("session")]
		//[Verify (MethodToProperty)]
		TWTRSession Session { get; }
	
		// -(TWTRGuestSession * _Nullable)guestSession;
		[NullAllowed, Export ("guestSession")]
		//[Verify (MethodToProperty)]
		TWTRGuestSession GuestSession { get; }
	
		// -(void)logOut;
		[Export ("logOut")]
		void LogOut ();
	
		// -(void)logOutGuest;
		[Export ("logOutGuest")]
		void LogOutGuest ();
	}
*/
}

