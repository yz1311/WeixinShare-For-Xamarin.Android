using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Sdk.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/class[@name='ConstantsAPI.Token']"
	[global::Android.Runtime.Register ("com/tencent/mm/sdk/constants/ConstantsAPI$Token", DoNotGenerateAcw=true)]
	public sealed partial class ConstantsAPIToken : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/class[@name='ConstantsAPI.Token']/field[@name='WX_LAUNCH_PARAM_KEY']"
		[Register ("WX_LAUNCH_PARAM_KEY")]
		public const string WxLaunchParamKey = (string) "launchParam";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/class[@name='ConstantsAPI.Token']/field[@name='WX_TOKEN_KEY']"
		[Register ("WX_TOKEN_KEY")]
		public const string WxTokenKey = (string) "wx_token_key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/class[@name='ConstantsAPI.Token']/field[@name='WX_TOKEN_PLATFORMID_KEY']"
		[Register ("WX_TOKEN_PLATFORMID_KEY")]
		public const string WxTokenPlatformidKey = (string) "platformId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/class[@name='ConstantsAPI.Token']/field[@name='WX_TOKEN_PLATFORMID_VALUE']"
		[Register ("WX_TOKEN_PLATFORMID_VALUE")]
		public const string WxTokenPlatformidValue = (string) "wechat";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/class[@name='ConstantsAPI.Token']/field[@name='WX_TOKEN_VALUE_MSG']"
		[Register ("WX_TOKEN_VALUE_MSG")]
		public const string WxTokenValueMsg = (string) "com.tencent.mm.openapi.token";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/sdk/constants/ConstantsAPI$Token", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConstantsAPIToken); }
		}

		internal ConstantsAPIToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/class[@name='ConstantsAPI.Token']/constructor[@name='ConstantsAPI.Token' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConstantsAPIToken ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ConstantsAPIToken)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/class[@name='ConstantsAPI.WXApp']"
	[global::Android.Runtime.Register ("com/tencent/mm/sdk/constants/ConstantsAPI$WXApp", DoNotGenerateAcw=true)]
	public sealed partial class ConstantsAPIWXApp : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/class[@name='ConstantsAPI.WXApp']/field[@name='WXAPP_BROADCAST_PERMISSION']"
		[Register ("WXAPP_BROADCAST_PERMISSION")]
		public const string WxappBroadcastPermission = (string) "com.tencent.mm.permission.MM_MESSAGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/class[@name='ConstantsAPI.WXApp']/field[@name='WXAPP_MSG_ENTRY_CLASSNAME']"
		[Register ("WXAPP_MSG_ENTRY_CLASSNAME")]
		public const string WxappMsgEntryClassname = (string) "com.tencent.mm.plugin.base.stub.WXEntryActivity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/class[@name='ConstantsAPI.WXApp']/field[@name='WXAPP_PACKAGE_NAME']"
		[Register ("WXAPP_PACKAGE_NAME")]
		public const string WxappPackageName = (string) "com.tencent.mm";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/sdk/constants/ConstantsAPI$WXApp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConstantsAPIWXApp); }
		}

		internal ConstantsAPIWXApp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/class[@name='ConstantsAPI.WXApp']/constructor[@name='ConstantsAPI.WXApp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConstantsAPIWXApp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ConstantsAPIWXApp)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}

	[Register ("com/tencent/mm/sdk/constants/ConstantsAPI")]
	public abstract class ConstantsAPI {

		internal ConstantsAPI ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='ACTION_HANDLE_APP_REGISTER']"
		[Register ("ACTION_HANDLE_APP_REGISTER")]
		public const string ActionHandleAppRegister = (string) "com.tencent.mm.plugin.openapi.Intent.ACTION_HANDLE_APP_REGISTER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='ACTION_HANDLE_APP_UNREGISTER']"
		[Register ("ACTION_HANDLE_APP_UNREGISTER")]
		public const string ActionHandleAppUnregister = (string) "com.tencent.mm.plugin.openapi.Intent.ACTION_HANDLE_APP_UNREGISTER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='ACTION_REFRESH_WXAPP']"
		[Register ("ACTION_REFRESH_WXAPP")]
		public const string ActionRefreshWxapp = (string) "com.tencent.mm.plugin.openapi.Intent.ACTION_REFRESH_WXAPP";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='APP_PACKAGE']"
		[Register ("APP_PACKAGE")]
		public const string AppPackage = (string) "_mmessage_appPackage";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='CHECK_SUM']"
		[Register ("CHECK_SUM")]
		public const string CheckSum = (string) "_mmessage_checksum";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_ADD_CARD_TO_EX_CARD_PACKAGE']"
		[Register ("COMMAND_ADD_CARD_TO_EX_CARD_PACKAGE")]
		public const int CommandAddCardToExCardPackage = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_GETMESSAGE_FROM_WX']"
		[Register ("COMMAND_GETMESSAGE_FROM_WX")]
		public const int CommandGetmessageFromWx = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_JUMP_BIZ_WEBVIEW']"
		[Register ("COMMAND_JUMP_BIZ_WEBVIEW")]
		public const int CommandJumpBizWebview = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_JUMP_TO_BIZ_PROFILE']"
		[Register ("COMMAND_JUMP_TO_BIZ_PROFILE")]
		public const int CommandJumpToBizProfile = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_LAUNCH_BY_WX']"
		[Register ("COMMAND_LAUNCH_BY_WX")]
		public const int CommandLaunchByWx = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_PAY_BY_WX']"
		[Register ("COMMAND_PAY_BY_WX")]
		public const int CommandPayByWx = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_SENDAUTH']"
		[Register ("COMMAND_SENDAUTH")]
		public const int CommandSendauth = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_SENDMESSAGE_TO_WX']"
		[Register ("COMMAND_SENDMESSAGE_TO_WX")]
		public const int CommandSendmessageToWx = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_SHOWMESSAGE_FROM_WX']"
		[Register ("COMMAND_SHOWMESSAGE_FROM_WX")]
		public const int CommandShowmessageFromWx = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_UNKNOWN']"
		[Register ("COMMAND_UNKNOWN")]
		public const int CommandUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='CONTENT']"
		[Register ("CONTENT")]
		public const string Content = (string) "_mmessage_content";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.constants']/interface[@name='ConstantsAPI']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "_mmessage_sdkVersion";
	}

	[global::System.Obsolete ("Use the 'ConstantsAPI' type. This type will be removed in a future release.")]
	public abstract class ConstantsAPIConsts : ConstantsAPI {

		private ConstantsAPIConsts ()
		{
		}
	}

}
