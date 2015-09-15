using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Sdk.Modelbiz {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelbiz']/class[@name='JumpToBizProfile']"
	[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelbiz/JumpToBizProfile", DoNotGenerateAcw=true)]
	public partial class JumpToBizProfile : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelbiz']/class[@name='JumpToBizProfile']/field[@name='JUMP_TO_HARD_WARE_BIZ_PROFILE']"
		[Register ("JUMP_TO_HARD_WARE_BIZ_PROFILE")]
		public const int JumpToHardWareBizProfile = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelbiz']/class[@name='JumpToBizProfile']/field[@name='JUMP_TO_NORMAL_BIZ_PROFILE']"
		[Register ("JUMP_TO_NORMAL_BIZ_PROFILE")]
		public const int JumpToNormalBizProfile = (int) 0;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelbiz']/class[@name='JumpToBizProfile.Req']"
		[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelbiz/JumpToBizProfile$Req", DoNotGenerateAcw=true)]
		public partial class Req : global::Com.Tencent.MM.Sdk.Modelbase.BaseReq {


			static IntPtr extMsg_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelbiz']/class[@name='JumpToBizProfile.Req']/field[@name='extMsg']"
			[Register ("extMsg")]
			public string ExtMsg {
				get {
					if (extMsg_jfieldId == IntPtr.Zero)
						extMsg_jfieldId = JNIEnv.GetFieldID (class_ref, "extMsg", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, extMsg_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (extMsg_jfieldId == IntPtr.Zero)
						extMsg_jfieldId = JNIEnv.GetFieldID (class_ref, "extMsg", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, extMsg_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr profileType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelbiz']/class[@name='JumpToBizProfile.Req']/field[@name='profileType']"
			[Register ("profileType")]
			public int ProfileType {
				get {
					if (profileType_jfieldId == IntPtr.Zero)
						profileType_jfieldId = JNIEnv.GetFieldID (class_ref, "profileType", "I");
					return JNIEnv.GetIntField (Handle, profileType_jfieldId);
				}
				set {
					if (profileType_jfieldId == IntPtr.Zero)
						profileType_jfieldId = JNIEnv.GetFieldID (class_ref, "profileType", "I");
					try {
						JNIEnv.SetField (Handle, profileType_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr toUserName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelbiz']/class[@name='JumpToBizProfile.Req']/field[@name='toUserName']"
			[Register ("toUserName")]
			public string ToUserName {
				get {
					if (toUserName_jfieldId == IntPtr.Zero)
						toUserName_jfieldId = JNIEnv.GetFieldID (class_ref, "toUserName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, toUserName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (toUserName_jfieldId == IntPtr.Zero)
						toUserName_jfieldId = JNIEnv.GetFieldID (class_ref, "toUserName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, toUserName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/sdk/modelbiz/JumpToBizProfile$Req", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelbiz']/class[@name='JumpToBizProfile.Req']/constructor[@name='JumpToBizProfile.Req' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Sdk.Modelbiz.JumpToBizProfile.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelbiz.JumpToBizProfile.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public override unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelbiz']/class[@name='JumpToBizProfile.Req']/method[@name='getType' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Sdk.Modelbiz.JumpToBizProfile.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelbiz.JumpToBizProfile.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			static IntPtr id_checkArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelbiz']/class[@name='JumpToBizProfile.Req']/method[@name='checkArgs' and count(parameter)=0]"
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/sdk/modelbiz/JumpToBizProfile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JumpToBizProfile); }
		}

		protected JumpToBizProfile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelbiz']/class[@name='JumpToBizProfile']/constructor[@name='JumpToBizProfile' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JumpToBizProfile ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JumpToBizProfile)) {
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
}
