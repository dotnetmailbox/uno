#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.DataTransfer
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	public delegate void DataProviderHandler(global::Windows.ApplicationModel.DataTransfer.DataProviderRequest @request);
	#endif
}