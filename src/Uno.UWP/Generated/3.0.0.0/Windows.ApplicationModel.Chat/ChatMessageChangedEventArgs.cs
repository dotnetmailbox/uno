#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ChatMessageChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Chat.ChatMessageChangedDeferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member ChatMessageChangedDeferral ChatMessageChangedEventArgs.GetDeferral() is not implemented in Uno.");
		}
		#endif
	}
}
