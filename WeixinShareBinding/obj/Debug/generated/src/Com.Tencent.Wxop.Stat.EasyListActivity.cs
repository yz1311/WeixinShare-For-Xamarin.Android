using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Wxop.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.wxop.stat']/class[@name='EasyListActivity']"
	[global::Android.Runtime.Register ("com/tencent/wxop/stat/EasyListActivity", DoNotGenerateAcw=true)]
	public partial class EasyListActivity : global::Android.App.ListActivity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/wxop/stat/EasyListActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EasyListActivity); }
		}

		protected EasyListActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.wxop.stat']/class[@name='EasyListActivity']/constructor[@name='EasyListActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EasyListActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EasyListActivity)) {
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
