using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Sdk.Modelmsg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']"
	[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/WXMediaMessage", DoNotGenerateAcw=true)]
	public sealed partial class WXMediaMessage : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='ACTION_WXAPPMESSAGE']"
		[Register ("ACTION_WXAPPMESSAGE")]
		public const string ActionWxappmessage = (string) "com.tencent.mm.sdk.openapi.Intent.ACTION_WXAPPMESSAGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='THUMB_LENGTH_LIMIT']"
		[Register ("THUMB_LENGTH_LIMIT")]
		public const int ThumbLengthLimit = (int) 32768;

		static IntPtr description_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='description']"
		[Register ("description")]
		public string Description {
			get {
				if (description_jfieldId == IntPtr.Zero)
					description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, description_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (description_jfieldId == IntPtr.Zero)
					description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, description_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mediaObject_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='mediaObject']"
		[Register ("mediaObject")]
		public global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject mediaObject_ {
			get {
				if (mediaObject_jfieldId == IntPtr.Zero)
					mediaObject_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaObject", "Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mediaObject_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mediaObject_jfieldId == IntPtr.Zero)
					mediaObject_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaObject", "Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mediaObject_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mediaTagName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='mediaTagName']"
		[Register ("mediaTagName")]
		public string MediaTagName {
			get {
				if (mediaTagName_jfieldId == IntPtr.Zero)
					mediaTagName_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaTagName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mediaTagName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mediaTagName_jfieldId == IntPtr.Zero)
					mediaTagName_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaTagName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mediaTagName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr messageAction_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='messageAction']"
		[Register ("messageAction")]
		public string MessageAction {
			get {
				if (messageAction_jfieldId == IntPtr.Zero)
					messageAction_jfieldId = JNIEnv.GetFieldID (class_ref, "messageAction", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, messageAction_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (messageAction_jfieldId == IntPtr.Zero)
					messageAction_jfieldId = JNIEnv.GetFieldID (class_ref, "messageAction", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, messageAction_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr messageExt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='messageExt']"
		[Register ("messageExt")]
		public string MessageExt {
			get {
				if (messageExt_jfieldId == IntPtr.Zero)
					messageExt_jfieldId = JNIEnv.GetFieldID (class_ref, "messageExt", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, messageExt_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (messageExt_jfieldId == IntPtr.Zero)
					messageExt_jfieldId = JNIEnv.GetFieldID (class_ref, "messageExt", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, messageExt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sdkVer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='sdkVer']"
		[Register ("sdkVer")]
		public int SdkVer {
			get {
				if (sdkVer_jfieldId == IntPtr.Zero)
					sdkVer_jfieldId = JNIEnv.GetFieldID (class_ref, "sdkVer", "I");
				return JNIEnv.GetIntField (Handle, sdkVer_jfieldId);
			}
			set {
				if (sdkVer_jfieldId == IntPtr.Zero)
					sdkVer_jfieldId = JNIEnv.GetFieldID (class_ref, "sdkVer", "I");
				try {
					JNIEnv.SetField (Handle, sdkVer_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr thumbData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='thumbData']"
		[Register ("thumbData")]
		public IList<byte> ThumbData {
			get {
				if (thumbData_jfieldId == IntPtr.Zero)
					thumbData_jfieldId = JNIEnv.GetFieldID (class_ref, "thumbData", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, thumbData_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (thumbData_jfieldId == IntPtr.Zero)
					thumbData_jfieldId = JNIEnv.GetFieldID (class_ref, "thumbData", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, thumbData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr title_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='title']"
		[Register ("title")]
		public string Title {
			get {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, title_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, title_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage.Builder']"
		[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/WXMediaMessage$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage.Builder']/field[@name='KEY_IDENTIFIER']"
			[Register ("KEY_IDENTIFIER")]
			public const string KeyIdentifier = (string) "_wxobject_identifier_";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/WXMediaMessage$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage.Builder']/constructor[@name='WXMediaMessage.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Builder)) {
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

			static IntPtr id_fromBundle_Landroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage.Builder']/method[@name='fromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("fromBundle", "(Landroid/os/Bundle;)Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage;", "")]
			public static unsafe global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage FromBundle (global::Android.OS.Bundle p0)
			{
				if (id_fromBundle_Landroid_os_Bundle_ == IntPtr.Zero)
					id_fromBundle_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "fromBundle", "(Landroid/os/Bundle;)Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromBundle_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_toBundle_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage.Builder']/method[@name='toBundle' and count(parameter)=1 and parameter[1][@type='com.tencent.mm.sdk.modelmsg.WXMediaMessage']]"
			[Register ("toBundle", "(Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage;)Landroid/os/Bundle;", "")]
			public static unsafe global::Android.OS.Bundle ToBundle (global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage p0)
			{
				if (id_toBundle_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_ == IntPtr.Zero)
					id_toBundle_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_ = JNIEnv.GetStaticMethodID (class_ref, "toBundle", "(Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage;)Landroid/os/Bundle;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toBundle_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		[Register ("com/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject")]
		public abstract class MediaObject {

			internal MediaObject ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_APPDATA']"
			[Register ("TYPE_APPDATA")]
			public const int TypeAppdata = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_CARD_SHARE']"
			[Register ("TYPE_CARD_SHARE")]
			public const int TypeCardShare = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_DEVICE_ACCESS']"
			[Register ("TYPE_DEVICE_ACCESS")]
			public const int TypeDeviceAccess = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_EMOJI']"
			[Register ("TYPE_EMOJI")]
			public const int TypeEmoji = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_EMOTICON_GIFT']"
			[Register ("TYPE_EMOTICON_GIFT")]
			public const int TypeEmoticonGift = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_EMOTICON_SHARED']"
			[Register ("TYPE_EMOTICON_SHARED")]
			public const int TypeEmoticonShared = (int) 15;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_FILE']"
			[Register ("TYPE_FILE")]
			public const int TypeFile = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_IMAGE']"
			[Register ("TYPE_IMAGE")]
			public const int TypeImage = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_LOCATION_SHARE']"
			[Register ("TYPE_LOCATION_SHARE")]
			public const int TypeLocationShare = (int) 17;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_MALL_PRODUCT']"
			[Register ("TYPE_MALL_PRODUCT")]
			public const int TypeMallProduct = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_MUSIC']"
			[Register ("TYPE_MUSIC")]
			public const int TypeMusic = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_OLD_TV']"
			[Register ("TYPE_OLD_TV")]
			public const int TypeOldTv = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_PRODUCT']"
			[Register ("TYPE_PRODUCT")]
			public const int TypeProduct = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_RECORD']"
			[Register ("TYPE_RECORD")]
			public const int TypeRecord = (int) 19;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_TEXT']"
			[Register ("TYPE_TEXT")]
			public const int TypeText = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_TV']"
			[Register ("TYPE_TV")]
			public const int TypeTv = (int) 20;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_UNKNOWN']"
			[Register ("TYPE_UNKNOWN")]
			public const int TypeUnknown = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_URL']"
			[Register ("TYPE_URL")]
			public const int TypeUrl = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_VIDEO']"
			[Register ("TYPE_VIDEO")]
			public const int TypeVideo = (int) 4;
		}

		[global::System.Obsolete ("Use the 'MediaObject' type. This type will be removed in a future release.")]
		public abstract class MediaObjectConsts : MediaObject {

			private MediaObjectConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']"
		[Register ("com/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject", "", "Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage/IMediaObjectInvoker")]
		public partial interface IMediaObject : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/method[@name='checkArgs' and count(parameter)=0]"
			[Register ("checkArgs", "()Z", "GetCheckArgsHandler:Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage/IMediaObjectInvoker, WeixinShareBinding")]
			bool CheckArgs ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("serialize", "(Landroid/os/Bundle;)V", "GetSerialize_Landroid_os_Bundle_Handler:Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage/IMediaObjectInvoker, WeixinShareBinding")]
			void Serialize (global::Android.OS.Bundle p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/method[@name='type' and count(parameter)=0]"
			[Register ("type", "()I", "GetTypeHandler:Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage/IMediaObjectInvoker, WeixinShareBinding")]
			int Type ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/method[@name='unserialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("unserialize", "(Landroid/os/Bundle;)V", "GetUnserialize_Landroid_os_Bundle_Handler:Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage/IMediaObjectInvoker, WeixinShareBinding")]
			void Unserialize (global::Android.OS.Bundle p0);

		}

		[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject", DoNotGenerateAcw=true)]
		internal class IMediaObjectInvoker : global::Java.Lang.Object, IMediaObject {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject");
			IntPtr class_ref;

			public static IMediaObject GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMediaObject> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.mm.sdk.modelmsg.WXMediaMessage.IMediaObject"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMediaObjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMediaObjectInvoker); }
			}

			static Delegate cb_checkArgs;
#pragma warning disable 0169
			static Delegate GetCheckArgsHandler ()
			{
				if (cb_checkArgs == null)
					cb_checkArgs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckArgs);
				return cb_checkArgs;
			}

			static bool n_CheckArgs (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			IntPtr id_checkArgs;
			public unsafe bool CheckArgs ()
			{
				if (id_checkArgs == IntPtr.Zero)
					id_checkArgs = JNIEnv.GetMethodID (class_ref, "checkArgs", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_checkArgs);
			}

			static Delegate cb_serialize_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetSerialize_Landroid_os_Bundle_Handler ()
			{
				if (cb_serialize_Landroid_os_Bundle_ == null)
					cb_serialize_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Serialize_Landroid_os_Bundle_);
				return cb_serialize_Landroid_os_Bundle_;
			}

			static void n_Serialize_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Serialize (p0);
			}
#pragma warning restore 0169

			IntPtr id_serialize_Landroid_os_Bundle_;
			public unsafe void Serialize (global::Android.OS.Bundle p0)
			{
				if (id_serialize_Landroid_os_Bundle_ == IntPtr.Zero)
					id_serialize_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "serialize", "(Landroid/os/Bundle;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_serialize_Landroid_os_Bundle_, __args);
			}

			static Delegate cb_type;
#pragma warning disable 0169
			static Delegate GetTypeHandler ()
			{
				if (cb_type == null)
					cb_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Type);
				return cb_type;
			}

			static int n_Type (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type ();
			}
#pragma warning restore 0169

			IntPtr id_type;
			public unsafe int Type ()
			{
				if (id_type == IntPtr.Zero)
					id_type = JNIEnv.GetMethodID (class_ref, "type", "()I");
				return JNIEnv.CallIntMethod (Handle, id_type);
			}

			static Delegate cb_unserialize_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetUnserialize_Landroid_os_Bundle_Handler ()
			{
				if (cb_unserialize_Landroid_os_Bundle_ == null)
					cb_unserialize_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unserialize_Landroid_os_Bundle_);
				return cb_unserialize_Landroid_os_Bundle_;
			}

			static void n_Unserialize_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Unserialize (p0);
			}
#pragma warning restore 0169

			IntPtr id_unserialize_Landroid_os_Bundle_;
			public unsafe void Unserialize (global::Android.OS.Bundle p0)
			{
				if (id_unserialize_Landroid_os_Bundle_ == IntPtr.Zero)
					id_unserialize_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "unserialize", "(Landroid/os/Bundle;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_unserialize_Landroid_os_Bundle_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/WXMediaMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WXMediaMessage); }
		}

		internal WXMediaMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/constructor[@name='WXMediaMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WXMediaMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WXMediaMessage)) {
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

		static IntPtr id_ctor_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_IMediaObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/constructor[@name='WXMediaMessage' and count(parameter)=1 and parameter[1][@type='com.tencent.mm.sdk.modelmsg.WXMediaMessage.IMediaObject']]"
		[Register (".ctor", "(Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject;)V", "")]
		public unsafe WXMediaMessage (global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (WXMediaMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject;)V", __args);
					return;
				}

				if (id_ctor_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_IMediaObject_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_IMediaObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_IMediaObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_IMediaObject_, __args);
			} finally {
			}
		}

		static IntPtr id_getType;
		public unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getType);
				} finally {
				}
			}
		}

		static IntPtr id_setThumbImage_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/method[@name='setThumbImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setThumbImage", "(Landroid/graphics/Bitmap;)V", "")]
		public unsafe void SetThumbImage (global::Android.Graphics.Bitmap p0)
		{
			if (id_setThumbImage_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setThumbImage_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setThumbImage", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setThumbImage_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

	}
}
