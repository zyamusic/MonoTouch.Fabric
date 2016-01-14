using ObjCRuntime;

namespace MonoTouch.Fabric.TwitterKit
{
	[Native]
	public enum TWTRAPIErrorCode : ulong
	{
		CouldNotAuthenticate = 32,
		PageNotExist = 34,
		NotAuthorizedForEndpoint = 37,
		AccountSuspended = 64,
		APIVersionRetired = 68,
		RateLimitExceeded = 88,
		InvalidOrExpiredToken = 89,
		SSLInvalid = 92,
		OverCapacity = 130,
		InternalError = 131,
		CouldNotAuthenticateTimestampOutOfRange = 135,
		AlreadyFavorited = 139,
		CannotFollowOverLimit = 161,
		NotAuthorizedToSeeStatus = 179,
		OverDailyStatusUpdateLimit = 185,
		StatusIsDuplicate = 187,
		BadAuthenticationData = 215,
		RequestIsAutomated = 226,
		UserMustVerifyLogin = 231,
		BadGuestToken = 239,
		EndpointRetired = 251,
		ApplicationCannotPerformWriteAction = 261,
		CannotMuteSelf = 271,
		CannotMuteSpecifiedUser = 272,
		AlreadyRetweeted = 327,
		TooManyRequests = 429
	}
	
	[Native]
	public enum TWTRErrorCode : long
	{
		Unknown = -1,
		NoAuthentication = 0,
		NotInitialized = 1,
		UserDeclinedPermission = 2,
		UserHasNoEmailAddress = 3,
		InvalidResourceID = 4,
		InvalidURL = 5,
		MismatchedJSONType = 6,
		KeychainSerializationFailure = 7,
		DiskSerializationError = 8,
		WebViewError = 9,
		MissingParameter = 10
	}
	
	[Native]
	public enum TWTRLogInErrorCode : long
	{
		Unknown = -1,
		Denied = 0,
		Canceled = 1,
		NoAccounts = 2,
		ReverseAuthFailed = 3,
		CannotRefreshSession = 4,
		SessionNotFound = 5,
		Failed = 6,
		SystemAccountCredentialsInvalid = 7
	}
	
	[Native]
	public enum DGTErrorCode : long
	{
		UnspecifiedError = 0,
		UserCanceledAuthentication = 1,
		UnableToAuthenticateNumber = 2,
		UnableToConfirmNumber = 3,
		UnableToAuthenticatePin = 4,
		UserCanceledFindContacts = 5,
		UserDeniedAddressBookAccess = 6,
		FailedToReadAddressBook = 7,
		UnableToUploadContacts = 8,
		UnableToDeleteContacts = 9,
		UnableToLookupContactMatches = 10,
		UnableToCreateEmailAddress = 11
	}
	
	[Native]
	public enum DGTAccountFields : long
	{
		None = 1 << 0,
		Email = 1 << 1,
		DefaultOptionMask = None
	}
	
	[Native]
	public enum DGTContactAccessAuthorizationStatus : long
	{
		Pending = 0,
		Denied = 1,
		Accepted = 2
	}
	
	[Native]
	public enum TWTRCardType : ulong
	{
		PromoImageApp,
		Unknown
	}
	
	[Native]
	public enum TWTRTimelineType : ulong
	{
		User = 1,
		Search,
		Collection,
		List
	}
	
	[Native]
	public enum TWTRComposerResult : long
	{
		Cancelled,
		Done
	}
	
	[Native]
	public enum TWTRComposerThemeType : long
	{
		Light,
		Dark
	}
	
	[Native]
	public enum TWTRTweetViewStyle : ulong
	{
		Regular,
		Compact
	}
	
	[Native]
	public enum TWTRTweetViewTheme : ulong
	{
		Light,
		Dark
	}
}

