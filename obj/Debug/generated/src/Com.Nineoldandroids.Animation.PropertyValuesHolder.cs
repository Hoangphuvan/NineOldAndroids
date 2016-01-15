using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	[global::Android.Runtime.Register ("com/nineoldandroids/animation/PropertyValuesHolder", DoNotGenerateAcw=true)]
	public partial class PropertyValuesHolder : global::Java.Lang.Object, global::Java.Lang.ICloneable {


		static IntPtr mProperty_jfieldId;

		[Register ("mProperty")]
		protected global::Com.Nineoldandroids.Util.Property MProperty {
			get {
				if (mProperty_jfieldId == IntPtr.Zero)
					mProperty_jfieldId = JNIEnv.GetFieldID (class_ref, "mProperty", "Lcom/nineoldandroids/util/Property;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mProperty_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Util.Property> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mProperty_jfieldId == IntPtr.Zero)
					mProperty_jfieldId = JNIEnv.GetFieldID (class_ref, "mProperty", "Lcom/nineoldandroids/util/Property;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mProperty_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		[global::Android.Runtime.Register ("com/nineoldandroids/animation/PropertyValuesHolder$FloatPropertyValuesHolder", DoNotGenerateAcw=true)]
		public partial class FloatPropertyValuesHolder : global::Com.Nineoldandroids.Animation.PropertyValuesHolder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/PropertyValuesHolder$FloatPropertyValuesHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FloatPropertyValuesHolder); }
			}

			protected FloatPropertyValuesHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}





			static IntPtr id_ctor_Ljava_lang_String_arrayF;
			[Register (".ctor", "(Ljava/lang/String;[F)V", "")]
			public FloatPropertyValuesHolder (string p0, params  float[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				IntPtr native_p1 = JNIEnv.NewArray (p1);;
				if (GetType () != typeof (FloatPropertyValuesHolder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;[F)V", new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					return;
				}

				if (id_ctor_Ljava_lang_String_arrayF == IntPtr.Zero)
					id_ctor_Ljava_lang_String_arrayF = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[F)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_arrayF, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_ctor_Lcom_nineoldandroids_util_Property_arrayF;
			[Register (".ctor", "(Lcom/nineoldandroids/util/Property;[F)V", "")]
			public FloatPropertyValuesHolder (global::Com.Nineoldandroids.Util.Property p0, params  float[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);;
				if (GetType () != typeof (FloatPropertyValuesHolder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/nineoldandroids/util/Property;[F)V", new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					return;
				}

				if (id_ctor_Lcom_nineoldandroids_util_Property_arrayF == IntPtr.Zero)
					id_ctor_Lcom_nineoldandroids_util_Property_arrayF = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nineoldandroids/util/Property;[F)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_nineoldandroids_util_Property_arrayF, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		[global::Android.Runtime.Register ("com/nineoldandroids/animation/PropertyValuesHolder$IntPropertyValuesHolder", DoNotGenerateAcw=true)]
		public partial class IntPropertyValuesHolder : global::Com.Nineoldandroids.Animation.PropertyValuesHolder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/PropertyValuesHolder$IntPropertyValuesHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IntPropertyValuesHolder); }
			}

			protected IntPropertyValuesHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}




			static IntPtr id_ctor_Ljava_lang_String_arrayI;
			[Register (".ctor", "(Ljava/lang/String;[I)V", "")]
			public IntPropertyValuesHolder (string p0, params  int[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				IntPtr native_p1 = JNIEnv.NewArray (p1);;
				if (GetType () != typeof (IntPropertyValuesHolder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;[I)V", new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					return;
				}

				if (id_ctor_Ljava_lang_String_arrayI == IntPtr.Zero)
					id_ctor_Ljava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[I)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_arrayI, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_ctor_Lcom_nineoldandroids_util_Property_arrayI;
			[Register (".ctor", "(Lcom/nineoldandroids/util/Property;[I)V", "")]
			public IntPropertyValuesHolder (global::Com.Nineoldandroids.Util.Property p0, params  int[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);;
				if (GetType () != typeof (IntPropertyValuesHolder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/nineoldandroids/util/Property;[I)V", new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					return;
				}

				if (id_ctor_Lcom_nineoldandroids_util_Property_arrayI == IntPtr.Zero)
					id_ctor_Lcom_nineoldandroids_util_Property_arrayI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nineoldandroids/util/Property;[I)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_nineoldandroids_util_Property_arrayI, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/PropertyValuesHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PropertyValuesHolder); }
		}

		protected PropertyValuesHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getPropertyName;
#pragma warning disable 0169
		static Delegate GetGetPropertyNameHandler ()
		{
			if (cb_getPropertyName == null)
				cb_getPropertyName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPropertyName);
			return cb_getPropertyName;
		}

		static IntPtr n_GetPropertyName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PropertyName);
		}
#pragma warning restore 0169

		static Delegate cb_setPropertyName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPropertyName_Ljava_lang_String_Handler ()
		{
			if (cb_setPropertyName_Ljava_lang_String_ == null)
				cb_setPropertyName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPropertyName_Ljava_lang_String_);
			return cb_setPropertyName_Ljava_lang_String_;
		}

		static void n_SetPropertyName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PropertyName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPropertyName;
		static IntPtr id_setPropertyName_Ljava_lang_String_;
		public virtual string PropertyName {
			[Register ("getPropertyName", "()Ljava/lang/String;", "GetGetPropertyNameHandler")]
			get {
				if (id_getPropertyName == IntPtr.Zero)
					id_getPropertyName = JNIEnv.GetMethodID (class_ref, "getPropertyName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPropertyName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPropertyName), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setPropertyName", "(Ljava/lang/String;)V", "GetSetPropertyName_Ljava_lang_String_Handler")]
			set {
				if (id_setPropertyName_Ljava_lang_String_ == IntPtr.Zero)
					id_setPropertyName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPropertyName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPropertyName_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPropertyName_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		[Register ("clone", "()Lcom/nineoldandroids/animation/PropertyValuesHolder;", "GetCloneHandler")]
		public virtual global::Com.Nineoldandroids.Animation.PropertyValuesHolder Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/nineoldandroids/animation/PropertyValuesHolder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_clone), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ofFloat_Lcom_nineoldandroids_util_Property_arrayF;
		[Register ("ofFloat", "(Lcom/nineoldandroids/util/Property;[F)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfFloat (global::Com.Nineoldandroids.Util.Property p0, params  float[] p1)
		{
			if (id_ofFloat_Lcom_nineoldandroids_util_Property_arrayF == IntPtr.Zero)
				id_ofFloat_Lcom_nineoldandroids_util_Property_arrayF = JNIEnv.GetStaticMethodID (class_ref, "ofFloat", "(Lcom/nineoldandroids/util/Property;[F)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofFloat_Lcom_nineoldandroids_util_Property_arrayF, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_ofFloat_Ljava_lang_String_arrayF;
		[Register ("ofFloat", "(Ljava/lang/String;[F)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfFloat (string p0, params  float[] p1)
		{
			if (id_ofFloat_Ljava_lang_String_arrayF == IntPtr.Zero)
				id_ofFloat_Ljava_lang_String_arrayF = JNIEnv.GetStaticMethodID (class_ref, "ofFloat", "(Ljava/lang/String;[F)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofFloat_Ljava_lang_String_arrayF, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_ofInt_Lcom_nineoldandroids_util_Property_arrayI;
		[Register ("ofInt", "(Lcom/nineoldandroids/util/Property;[I)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfInt (global::Com.Nineoldandroids.Util.Property p0, params  int[] p1)
		{
			if (id_ofInt_Lcom_nineoldandroids_util_Property_arrayI == IntPtr.Zero)
				id_ofInt_Lcom_nineoldandroids_util_Property_arrayI = JNIEnv.GetStaticMethodID (class_ref, "ofInt", "(Lcom/nineoldandroids/util/Property;[I)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofInt_Lcom_nineoldandroids_util_Property_arrayI, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_ofInt_Ljava_lang_String_arrayI;
		[Register ("ofInt", "(Ljava/lang/String;[I)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfInt (string p0, params  int[] p1)
		{
			if (id_ofInt_Ljava_lang_String_arrayI == IntPtr.Zero)
				id_ofInt_Ljava_lang_String_arrayI = JNIEnv.GetStaticMethodID (class_ref, "ofInt", "(Ljava/lang/String;[I)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofInt_Ljava_lang_String_arrayI, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_ofKeyframe_Lcom_nineoldandroids_util_Property_arrayLcom_nineoldandroids_animation_Keyframe_;
		[Register ("ofKeyframe", "(Lcom/nineoldandroids/util/Property;[Lcom/nineoldandroids/animation/Keyframe;)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfKeyframe (global::Com.Nineoldandroids.Util.Property p0, params global:: Com.Nineoldandroids.Animation.Keyframe[] p1)
		{
			if (id_ofKeyframe_Lcom_nineoldandroids_util_Property_arrayLcom_nineoldandroids_animation_Keyframe_ == IntPtr.Zero)
				id_ofKeyframe_Lcom_nineoldandroids_util_Property_arrayLcom_nineoldandroids_animation_Keyframe_ = JNIEnv.GetStaticMethodID (class_ref, "ofKeyframe", "(Lcom/nineoldandroids/util/Property;[Lcom/nineoldandroids/animation/Keyframe;)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofKeyframe_Lcom_nineoldandroids_util_Property_arrayLcom_nineoldandroids_animation_Keyframe_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_ofKeyframe_Ljava_lang_String_arrayLcom_nineoldandroids_animation_Keyframe_;
		[Register ("ofKeyframe", "(Ljava/lang/String;[Lcom/nineoldandroids/animation/Keyframe;)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfKeyframe (string p0, params global:: Com.Nineoldandroids.Animation.Keyframe[] p1)
		{
			if (id_ofKeyframe_Ljava_lang_String_arrayLcom_nineoldandroids_animation_Keyframe_ == IntPtr.Zero)
				id_ofKeyframe_Ljava_lang_String_arrayLcom_nineoldandroids_animation_Keyframe_ = JNIEnv.GetStaticMethodID (class_ref, "ofKeyframe", "(Ljava/lang/String;[Lcom/nineoldandroids/animation/Keyframe;)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofKeyframe_Ljava_lang_String_arrayLcom_nineoldandroids_animation_Keyframe_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_ofObject_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_;
		[Register ("ofObject", "(Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfObject (global::Com.Nineoldandroids.Util.Property p0, global::Com.Nineoldandroids.Animation.ITypeEvaluator p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_ofObject_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_ofObject_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "ofObject", "(Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofObject_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_ofObject_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_;
		[Register ("ofObject", "(Ljava/lang/String;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfObject (string p0, global::Com.Nineoldandroids.Animation.ITypeEvaluator p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_ofObject_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_ofObject_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "ofObject", "(Ljava/lang/String;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofObject_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_;
#pragma warning disable 0169
		static Delegate GetSetEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_Handler ()
		{
			if (cb_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ == null)
				cb_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_);
			return cb_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_;
		}

		static void n_SetEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.ITypeEvaluator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ITypeEvaluator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEvaluator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_;
		[Register ("setEvaluator", "(Lcom/nineoldandroids/animation/TypeEvaluator;)V", "GetSetEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_Handler")]
		public virtual void SetEvaluator (global::Com.Nineoldandroids.Animation.ITypeEvaluator p0)
		{
			if (id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ == IntPtr.Zero)
				id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ = JNIEnv.GetMethodID (class_ref, "setEvaluator", "(Lcom/nineoldandroids/animation/TypeEvaluator;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_, new JValue (p0));
		}

		static Delegate cb_setFloatValues_arrayF;
#pragma warning disable 0169
		static Delegate GetSetFloatValues_arrayFHandler ()
		{
			if (cb_setFloatValues_arrayF == null)
				cb_setFloatValues_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFloatValues_arrayF);
			return cb_setFloatValues_arrayF;
		}

		static void n_SetFloatValues_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetFloatValues (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFloatValues_arrayF;
		[Register ("setFloatValues", "([F)V", "GetSetFloatValues_arrayFHandler")]
		public virtual void SetFloatValues (params  float[] p0)
		{
			if (id_setFloatValues_arrayF == IntPtr.Zero)
				id_setFloatValues_arrayF = JNIEnv.GetMethodID (class_ref, "setFloatValues", "([F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setFloatValues_arrayF, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setFloatValues_arrayF, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setIntValues_arrayI;
#pragma warning disable 0169
		static Delegate GetSetIntValues_arrayIHandler ()
		{
			if (cb_setIntValues_arrayI == null)
				cb_setIntValues_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIntValues_arrayI);
			return cb_setIntValues_arrayI;
		}

		static void n_SetIntValues_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetIntValues (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIntValues_arrayI;
		[Register ("setIntValues", "([I)V", "GetSetIntValues_arrayIHandler")]
		public virtual void SetIntValues (params  int[] p0)
		{
			if (id_setIntValues_arrayI == IntPtr.Zero)
				id_setIntValues_arrayI = JNIEnv.GetMethodID (class_ref, "setIntValues", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setIntValues_arrayI, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setIntValues_arrayI, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_;
#pragma warning disable 0169
		static Delegate GetSetKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_Handler ()
		{
			if (cb_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_ == null)
				cb_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_);
			return cb_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_;
		}

		static void n_SetKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.Keyframe[] p0 = (global::Com.Nineoldandroids.Animation.Keyframe[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Nineoldandroids.Animation.Keyframe));
			__this.SetKeyframes (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_;
		[Register ("setKeyframes", "([Lcom/nineoldandroids/animation/Keyframe;)V", "GetSetKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_Handler")]
		public virtual void SetKeyframes (params global:: Com.Nineoldandroids.Animation.Keyframe[] p0)
		{
			if (id_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_ == IntPtr.Zero)
				id_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_ = JNIEnv.GetMethodID (class_ref, "setKeyframes", "([Lcom/nineoldandroids/animation/Keyframe;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setObjectValues_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetObjectValues_arrayLjava_lang_Object_Handler ()
		{
			if (cb_setObjectValues_arrayLjava_lang_Object_ == null)
				cb_setObjectValues_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObjectValues_arrayLjava_lang_Object_);
			return cb_setObjectValues_arrayLjava_lang_Object_;
		}

		static void n_SetObjectValues_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.SetObjectValues (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setObjectValues_arrayLjava_lang_Object_;
		[Register ("setObjectValues", "([Ljava/lang/Object;)V", "GetSetObjectValues_arrayLjava_lang_Object_Handler")]
		public virtual void SetObjectValues (params global:: Java.Lang.Object[] p0)
		{
			if (id_setObjectValues_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_setObjectValues_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setObjectValues", "([Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setObjectValues_arrayLjava_lang_Object_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setObjectValues_arrayLjava_lang_Object_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setProperty_Lcom_nineoldandroids_util_Property_;
#pragma warning disable 0169
		static Delegate GetSetProperty_Lcom_nineoldandroids_util_Property_Handler ()
		{
			if (cb_setProperty_Lcom_nineoldandroids_util_Property_ == null)
				cb_setProperty_Lcom_nineoldandroids_util_Property_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProperty_Lcom_nineoldandroids_util_Property_);
			return cb_setProperty_Lcom_nineoldandroids_util_Property_;
		}

		static void n_SetProperty_Lcom_nineoldandroids_util_Property_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Util.Property p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Util.Property> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetProperty (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setProperty_Lcom_nineoldandroids_util_Property_;
		[Register ("setProperty", "(Lcom/nineoldandroids/util/Property;)V", "GetSetProperty_Lcom_nineoldandroids_util_Property_Handler")]
		public virtual void SetProperty (global::Com.Nineoldandroids.Util.Property p0)
		{
			if (id_setProperty_Lcom_nineoldandroids_util_Property_ == IntPtr.Zero)
				id_setProperty_Lcom_nineoldandroids_util_Property_ = JNIEnv.GetMethodID (class_ref, "setProperty", "(Lcom/nineoldandroids/util/Property;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setProperty_Lcom_nineoldandroids_util_Property_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setProperty_Lcom_nineoldandroids_util_Property_, new JValue (p0));
		}

	}
}
