using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Util {

	[global::Android.Runtime.Register ("com/nineoldandroids/util/Property", DoNotGenerateAcw=true)]
	public abstract partial class Property : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/util/Property", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Property); }
		}

		protected Property (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Class_Ljava_lang_String_;
		[Register (".ctor", "(Ljava/lang/Class;Ljava/lang/String;)V", "")]
		public Property (global::Java.Lang.Class p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (Property)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/Class;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_isReadOnly;
#pragma warning disable 0169
		static Delegate GetIsReadOnlyHandler ()
		{
			if (cb_isReadOnly == null)
				cb_isReadOnly = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReadOnly);
			return cb_isReadOnly;
		}

		static bool n_IsReadOnly (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Util.Property __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Util.Property> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReadOnly;
		}
#pragma warning restore 0169

		static IntPtr id_isReadOnly;
		public virtual bool IsReadOnly {
			[Register ("isReadOnly", "()Z", "GetIsReadOnlyHandler")]
			get {
				if (id_isReadOnly == IntPtr.Zero)
					id_isReadOnly = JNIEnv.GetMethodID (class_ref, "isReadOnly", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isReadOnly);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isReadOnly);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Util.Property __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Util.Property> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual string Name {
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Util.Property __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Util.Property> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual global::Java.Lang.Class Type {
			[Register ("getType", "()Ljava/lang/Class;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/Class;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_get_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_Object_Handler ()
		{
			if (cb_get_Ljava_lang_Object_ == null)
				cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_Object_);
			return cb_get_Ljava_lang_Object_;
		}

		static IntPtr n_Get_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Util.Property __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Util.Property> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		[Register ("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public abstract global::Java.Lang.Object Get (global::Java.Lang.Object p0);

		static IntPtr id_of_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_;
		[Register ("of", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Lcom/nineoldandroids/util/Property;", "")]
		public static global::Com.Nineoldandroids.Util.Property Of (global::Java.Lang.Class p0, global::Java.Lang.Class p1, string p2)
		{
			if (id_of_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_of_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "of", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Lcom/nineoldandroids/util/Property;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::Com.Nineoldandroids.Util.Property __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Util.Property> (JNIEnv.CallStaticObjectMethod  (class_ref, id_of_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_set_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_set_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_set_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_set_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Set_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nineoldandroids.Util.Property __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Util.Property> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_Object_Ljava_lang_Object_;
		[Register ("set", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetSet_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual void Set (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_set_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_set_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_set_Ljava_lang_Object_Ljava_lang_Object_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_set_Ljava_lang_Object_Ljava_lang_Object_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	[global::Android.Runtime.Register ("com/nineoldandroids/util/Property", DoNotGenerateAcw=true)]
	internal partial class PropertyInvoker : Property {

		public PropertyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PropertyInvoker); }
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
