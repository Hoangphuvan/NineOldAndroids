using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	[global::Android.Runtime.Register ("com/nineoldandroids/animation/ObjectAnimator", DoNotGenerateAcw=true)]
	public sealed partial class ObjectAnimator : global::Com.Nineoldandroids.Animation.ValueAnimator {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/ObjectAnimator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectAnimator); }
		}

		internal ObjectAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public ObjectAnimator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ObjectAnimator)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getPropertyName;
		static IntPtr id_setPropertyName_Ljava_lang_String_;
		public string PropertyName {
			[Register ("getPropertyName", "()Ljava/lang/String;", "GetGetPropertyNameHandler")]
			get {
				if (id_getPropertyName == IntPtr.Zero)
					id_getPropertyName = JNIEnv.GetMethodID (class_ref, "getPropertyName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPropertyName), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setPropertyName", "(Ljava/lang/String;)V", "GetSetPropertyName_Ljava_lang_String_Handler")]
			set {
				if (id_setPropertyName_Ljava_lang_String_ == IntPtr.Zero)
					id_setPropertyName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPropertyName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setPropertyName_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getTarget;
		public global::Java.Lang.Object Target {
			[Register ("getTarget", "()Ljava/lang/Object;", "GetGetTargetHandler")]
			get {
				if (id_getTarget == IntPtr.Zero)
					id_getTarget = JNIEnv.GetMethodID (class_ref, "getTarget", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getTarget), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_ofFloat_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayF;
		[Register ("ofFloat", "(Ljava/lang/Object;Lcom/nineoldandroids/util/Property;[F)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static global::Com.Nineoldandroids.Animation.ObjectAnimator OfFloat (global::Java.Lang.Object p0, global::Com.Nineoldandroids.Util.Property p1, params  float[] p2)
		{
			if (id_ofFloat_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayF == IntPtr.Zero)
				id_ofFloat_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayF = JNIEnv.GetStaticMethodID (class_ref, "ofFloat", "(Ljava/lang/Object;Lcom/nineoldandroids/util/Property;[F)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofFloat_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayF, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_ofFloat_Ljava_lang_Object_Ljava_lang_String_arrayF;
		[Register ("ofFloat", "(Ljava/lang/Object;Ljava/lang/String;[F)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static global::Com.Nineoldandroids.Animation.ObjectAnimator OfFloat (global::Java.Lang.Object p0, string p1, params  float[] p2)
		{
			if (id_ofFloat_Ljava_lang_Object_Ljava_lang_String_arrayF == IntPtr.Zero)
				id_ofFloat_Ljava_lang_Object_Ljava_lang_String_arrayF = JNIEnv.GetStaticMethodID (class_ref, "ofFloat", "(Ljava/lang/Object;Ljava/lang/String;[F)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofFloat_Ljava_lang_Object_Ljava_lang_String_arrayF, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_ofInt_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayI;
		[Register ("ofInt", "(Ljava/lang/Object;Lcom/nineoldandroids/util/Property;[I)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static global::Com.Nineoldandroids.Animation.ObjectAnimator OfInt (global::Java.Lang.Object p0, global::Com.Nineoldandroids.Util.Property p1, params  int[] p2)
		{
			if (id_ofInt_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayI == IntPtr.Zero)
				id_ofInt_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayI = JNIEnv.GetStaticMethodID (class_ref, "ofInt", "(Ljava/lang/Object;Lcom/nineoldandroids/util/Property;[I)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofInt_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayI, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_ofInt_Ljava_lang_Object_Ljava_lang_String_arrayI;
		[Register ("ofInt", "(Ljava/lang/Object;Ljava/lang/String;[I)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static global::Com.Nineoldandroids.Animation.ObjectAnimator OfInt (global::Java.Lang.Object p0, string p1, params  int[] p2)
		{
			if (id_ofInt_Ljava_lang_Object_Ljava_lang_String_arrayI == IntPtr.Zero)
				id_ofInt_Ljava_lang_Object_Ljava_lang_String_arrayI = JNIEnv.GetStaticMethodID (class_ref, "ofInt", "(Ljava/lang/Object;Ljava/lang/String;[I)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofInt_Ljava_lang_Object_Ljava_lang_String_arrayI, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_ofObject_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_;
		[Register ("ofObject", "(Ljava/lang/Object;Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static global::Com.Nineoldandroids.Animation.ObjectAnimator OfObject (global::Java.Lang.Object p0, global::Com.Nineoldandroids.Util.Property p1, global::Com.Nineoldandroids.Animation.ITypeEvaluator p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_ofObject_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_ofObject_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "ofObject", "(Ljava/lang/Object;Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofObject_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static IntPtr id_ofObject_Ljava_lang_Object_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_;
		[Register ("ofObject", "(Ljava/lang/Object;Ljava/lang/String;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static global::Com.Nineoldandroids.Animation.ObjectAnimator OfObject (global::Java.Lang.Object p0, string p1, global::Com.Nineoldandroids.Animation.ITypeEvaluator p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_ofObject_Ljava_lang_Object_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_ofObject_Ljava_lang_Object_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "ofObject", "(Ljava/lang/Object;Ljava/lang/String;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofObject_Ljava_lang_Object_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static IntPtr id_ofPropertyValuesHolder_Ljava_lang_Object_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_;
		[Register ("ofPropertyValuesHolder", "(Ljava/lang/Object;[Lcom/nineoldandroids/animation/PropertyValuesHolder;)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static global::Com.Nineoldandroids.Animation.ObjectAnimator OfPropertyValuesHolder (global::Java.Lang.Object p0, params global:: Com.Nineoldandroids.Animation.PropertyValuesHolder[] p1)
		{
			if (id_ofPropertyValuesHolder_Ljava_lang_Object_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_ == IntPtr.Zero)
				id_ofPropertyValuesHolder_Ljava_lang_Object_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_ = JNIEnv.GetStaticMethodID (class_ref, "ofPropertyValuesHolder", "(Ljava/lang/Object;[Lcom/nineoldandroids/animation/PropertyValuesHolder;)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofPropertyValuesHolder_Ljava_lang_Object_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_setProperty_Lcom_nineoldandroids_util_Property_;
		[Register ("setProperty", "(Lcom/nineoldandroids/util/Property;)V", "")]
		public void SetProperty (global::Com.Nineoldandroids.Util.Property p0)
		{
			if (id_setProperty_Lcom_nineoldandroids_util_Property_ == IntPtr.Zero)
				id_setProperty_Lcom_nineoldandroids_util_Property_ = JNIEnv.GetMethodID (class_ref, "setProperty", "(Lcom/nineoldandroids/util/Property;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setProperty_Lcom_nineoldandroids_util_Property_, new JValue (p0));
		}

	}
}
