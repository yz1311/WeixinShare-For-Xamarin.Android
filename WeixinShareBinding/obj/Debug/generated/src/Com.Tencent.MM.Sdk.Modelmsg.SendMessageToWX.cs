using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Sdk.Modelmsg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX']"
	[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/SendMessageToWX", DoNotGenerateAcw=true)]
	public partial class SendMessageToWX : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Req']"
		[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/SendMessageToWX$Req", DoNotGenerateAcw=true)]
		public partial class Req : global::Com.Tencent.MM.Sdk.Modelbase.BaseReq {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Req']/field[@name='WXSceneFavorite']"
			[Register ("WXSceneFavorite")]
			public const int WXSceneFavorite = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Req']/field[@name='WXSceneSession']"
			[Register ("WXSceneSession")]
			public const int WXSceneSession = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Req']/field[@name='WXSceneTimeline']"
			[Register ("WXSceneTimeline")]
			public const int WXSceneTimeline = (int) 1;

			static IntPtr message_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Req']/field[@name='message']"
			[Register ("message")]
			public global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage Message {
				get {
					if (message_jfieldId == IntPtr.Zero)
						message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, message_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (message_jfieldId == IntPtr.Zero)
						message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, message_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr scene_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Req']/field[@name='scene']"
			[Register ("scene")]
			public int Scene {
				get {
					if (scene_jfieldId == IntPtr.Zero)
						scene_jfieldId = JNIEnv.GetFieldID (class_ref, "scene", "I");
					return JNIEnv.GetIntField (Handle, scene_jfieldId);
				}
				set {
					if (scene_jfieldId == IntPtr.Zero)
						scene_jfieldId = JNIEnv.GetFieldID (class_ref, "scene", "I");
					try {
						JNIEnv.SetField (Handle, scene_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/SendMessageToWX$Req", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Req); }
			}

			protected Req (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Req']/constructor[@name='SendMessageToWX.Req' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Req ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Req)) {
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

			static IntPtr id_ctor_Landroid_os_Bundle_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Req']/constructor[@name='SendMessageToWX.Req' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
			public unsafe Req (global::Android.OS.Bundle p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (Req)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Bundle;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Bundle;)V", __args);
						return;
					}

					if (id_ctor_Landroid_os_Bundle_ == IntPtr.Zero)
						id_ctor_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Bundle;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Bundle_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Bundle_, __args);
				} finally {
				}
			}

			static Delegate cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
				return cb_getType;
			}

			static int n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.MM.Sdk.Modelmsg.SendMessageToWX.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.SendMessageToWX.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public override unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Req']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()I", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getType);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()I"));
					} finally {
					}
				}
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
				global::Com.Tencent.MM.Sdk.Modelmsg.SendMessageToWX.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.SendMessageToWX.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			static IntPtr id_checkArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Req']/method[@name='checkArgs' and count(parameter)=0]"
			[Register ("checkArgs", "()Z", "GetCheckArgsHandler")]
			public override unsafe bool CheckArgs ()
			{
				if (id_checkArgs == IntPtr.Zero)
					id_checkArgs = JNIEnv.GetMethodID (class_ref, "checkArgs", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_checkArgs);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkArgs", "()Z"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Resp']"
		[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/SendMessageToWX$Resp", DoNotGenerateAcw=true)]
		public partial class Resp : global::Com.Tencent.MM.Sdk.Modelbase.BaseResp {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/SendMessageToWX$Resp", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Resp); }
			}

			protected Resp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Resp']/constructor[@name='SendMessageToWX.Resp' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Resp ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Resp)) {
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

			static IntPtr id_ctor_Landroid_os_Bundle_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Resp']/constructor[@name='SendMessageToWX.Resp' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
			public unsafe Resp (global::Android.OS.Bundle p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (Resp)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Bundle;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Bundle;)V", __args);
						return;
					}

					if (id_ctor_Landroid_os_Bundle_ == IntPtr.Zero)
						id_ctor_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Bundle;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Bundle_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Bundle_, __args);
				} finally {
				}
			}

			static Delegate cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
				return cb_getType;
			}

			static int n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.MM.Sdk.Modelmsg.SendMessageToWX.Resp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.SendMessageToWX.Resp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public override unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Resp']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()I", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getType);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()I"));
					} finally {
					}
				}
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
				global::Com.Tencent.MM.Sdk.Modelmsg.SendMessageToWX.Resp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.SendMessageToWX.Resp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			static IntPtr id_checkArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='SendMessageToWX.Resp']/method[@name='checkArgs' and count(parameter)=0]"
			[Register ("checkArgs", "()Z", "GetCheckArgsHandler")]
			public override unsafe bool CheckArgs ()
			{
				if (id_checkArgs == IntPtr.Zero)
					id_checkArgs = JNIEnv.GetMethodID (class_ref, "checkArgs", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_checkArgs);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkArgs", "()Z"));
				} finally {
				}
			}

		}

		protected SendMessageToWX (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
