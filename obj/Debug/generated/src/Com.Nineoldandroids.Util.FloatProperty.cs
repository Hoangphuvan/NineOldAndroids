using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Util {

	[global::Android.Runtime.Register ("com/nineoldandroids/util/FloatProperty", DoNotGenerateAcw=true)]
	public abstract partial class FloatProperty : global::Com.Nineoldandroids.Util.Property {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/util/FloatProperty", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FloatProperty); }
		}

		protected FloatProperty (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public FloatProperty (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (FloatProperty)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_set_Ljava_lang_Object_Ljava_lang_Float_;
		[Register ("set", "(Ljava/lang/Object;Ljava/lang/Float;)V", "")]
		public void Set (global::Java.Lang.Object p0, global::Java.Lang.Float p1)
		{
			if (id_set_Ljava_lang_Object_Ljava_lang_Float_ == IntPtr.Zero)
				id_set_Ljava_lang_Object_Ljava_lang_Float_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/Object;Ljava/lang/Float;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_set_Ljava_lang_Object_Ljava_lang_Float_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setValue_Ljava_lang_Object_F;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_Object_FHandler ()
		{
			if (cb_setValue_Ljava_lang_Object_F == null)
				cb_setValue_Ljava_lang_Object_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_SetValue_Ljava_lang_Object_F);
			return cb_setValue_Ljava_lang_Object_F;
		}

		static void n_SetValue_Ljava_lang_Object_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::Com.Nineoldandroids.Util.FloatProperty __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Util.FloatProperty> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (p0, p1);
		}
#pragma warning restore 0169

		[Register ("setValue", "(Ljava/lang/Object;F)V", "GetSetValue_Ljava_lang_Object_FHandler")]
		public abstract void SetValue (global::Java.Lang.Object p0, float p1);

	}

	[global::Android.Runtime.Register ("com/nineoldandroids/util/FloatProperty", DoNotGenerateAcw=true)]
	internal partial class FloatPropertyInvoker : FloatProperty {

		public FloatPropertyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FloatPropertyInvoker); }
		}

		static IntPtr id_setValue_Ljava_lang_Object_F;
		[Register ("setValue", "(Ljava/lang/Object;F)V", "GetSetValue_Ljava_lang_Object_FHandler")]
		public override void SetValue (global::Java.Lang.Object p0, float p1)
		{
			if (id_setValue_Ljava_lang_Object_F == IntPtr.Zero)
				id_setValue_Ljava_lang_Object_F = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/Object;F)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_setValue_Ljava_lang_Object_F, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_get_Ljava_lang_Object_;
		[Register ("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public override global::Java.Lang.Object Get (global::Java.Lang.Object p0)
		{
			if (id_get_Ljava_lang_Object_ == IntPtr.Zero)
				id_get_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
