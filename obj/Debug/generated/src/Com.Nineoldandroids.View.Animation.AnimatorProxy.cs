using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.View.Animation {

	[global::Android.Runtime.Register ("com/nineoldandroids/view/animation/AnimatorProxy", DoNotGenerateAcw=true)]
	public sealed partial class AnimatorProxy : global::Android.Views.Animations.Animation {


		static IntPtr NEEDS_PROXY_jfieldId;

		[Register ("NEEDS_PROXY")]
		public static bool NeedsProxy {
			get {
				if (NEEDS_PROXY_jfieldId == IntPtr.Zero)
					NEEDS_PROXY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEEDS_PROXY", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, NEEDS_PROXY_jfieldId);
			}
			set {
				if (NEEDS_PROXY_jfieldId == IntPtr.Zero)
					NEEDS_PROXY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEEDS_PROXY", "Z");
				JNIEnv.SetStaticField (class_ref, NEEDS_PROXY_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/view/animation/AnimatorProxy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatorProxy); }
		}

		internal AnimatorProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAlpha;
		static IntPtr id_setAlpha_F;
		public float Alpha {
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				if (id_getAlpha == IntPtr.Zero)
					id_getAlpha = JNIEnv.GetMethodID (class_ref, "getAlpha", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getAlpha);
			}
			[Register ("setAlpha", "(F)V", "GetSetAlpha_FHandler")]
			set {
				if (id_setAlpha_F == IntPtr.Zero)
					id_setAlpha_F = JNIEnv.GetMethodID (class_ref, "setAlpha", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setAlpha_F, new JValue (value));
			}
		}

		static IntPtr id_getPivotX;
		static IntPtr id_setPivotX_F;
		public float PivotX {
			[Register ("getPivotX", "()F", "GetGetPivotXHandler")]
			get {
				if (id_getPivotX == IntPtr.Zero)
					id_getPivotX = JNIEnv.GetMethodID (class_ref, "getPivotX", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getPivotX);
			}
			[Register ("setPivotX", "(F)V", "GetSetPivotX_FHandler")]
			set {
				if (id_setPivotX_F == IntPtr.Zero)
					id_setPivotX_F = JNIEnv.GetMethodID (class_ref, "setPivotX", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setPivotX_F, new JValue (value));
			}
		}

		static IntPtr id_getPivotY;
		static IntPtr id_setPivotY_F;
		public float PivotY {
			[Register ("getPivotY", "()F", "GetGetPivotYHandler")]
			get {
				if (id_getPivotY == IntPtr.Zero)
					id_getPivotY = JNIEnv.GetMethodID (class_ref, "getPivotY", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getPivotY);
			}
			[Register ("setPivotY", "(F)V", "GetSetPivotY_FHandler")]
			set {
				if (id_setPivotY_F == IntPtr.Zero)
					id_setPivotY_F = JNIEnv.GetMethodID (class_ref, "setPivotY", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setPivotY_F, new JValue (value));
			}
		}

		static IntPtr id_getRotation;
		static IntPtr id_setRotation_F;
		public float Rotation {
			[Register ("getRotation", "()F", "GetGetRotationHandler")]
			get {
				if (id_getRotation == IntPtr.Zero)
					id_getRotation = JNIEnv.GetMethodID (class_ref, "getRotation", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getRotation);
			}
			[Register ("setRotation", "(F)V", "GetSetRotation_FHandler")]
			set {
				if (id_setRotation_F == IntPtr.Zero)
					id_setRotation_F = JNIEnv.GetMethodID (class_ref, "setRotation", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setRotation_F, new JValue (value));
			}
		}

		static IntPtr id_getRotationX;
		static IntPtr id_setRotationX_F;
		public float RotationX {
			[Register ("getRotationX", "()F", "GetGetRotationXHandler")]
			get {
				if (id_getRotationX == IntPtr.Zero)
					id_getRotationX = JNIEnv.GetMethodID (class_ref, "getRotationX", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getRotationX);
			}
			[Register ("setRotationX", "(F)V", "GetSetRotationX_FHandler")]
			set {
				if (id_setRotationX_F == IntPtr.Zero)
					id_setRotationX_F = JNIEnv.GetMethodID (class_ref, "setRotationX", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setRotationX_F, new JValue (value));
			}
		}

		static IntPtr id_getRotationY;
		static IntPtr id_setRotationY_F;
		public float RotationY {
			[Register ("getRotationY", "()F", "GetGetRotationYHandler")]
			get {
				if (id_getRotationY == IntPtr.Zero)
					id_getRotationY = JNIEnv.GetMethodID (class_ref, "getRotationY", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getRotationY);
			}
			[Register ("setRotationY", "(F)V", "GetSetRotationY_FHandler")]
			set {
				if (id_setRotationY_F == IntPtr.Zero)
					id_setRotationY_F = JNIEnv.GetMethodID (class_ref, "setRotationY", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setRotationY_F, new JValue (value));
			}
		}

		static IntPtr id_getScaleX;
		static IntPtr id_setScaleX_F;
		public float ScaleX {
			[Register ("getScaleX", "()F", "GetGetScaleXHandler")]
			get {
				if (id_getScaleX == IntPtr.Zero)
					id_getScaleX = JNIEnv.GetMethodID (class_ref, "getScaleX", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getScaleX);
			}
			[Register ("setScaleX", "(F)V", "GetSetScaleX_FHandler")]
			set {
				if (id_setScaleX_F == IntPtr.Zero)
					id_setScaleX_F = JNIEnv.GetMethodID (class_ref, "setScaleX", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setScaleX_F, new JValue (value));
			}
		}

		static IntPtr id_getScaleY;
		static IntPtr id_setScaleY_F;
		public float ScaleY {
			[Register ("getScaleY", "()F", "GetGetScaleYHandler")]
			get {
				if (id_getScaleY == IntPtr.Zero)
					id_getScaleY = JNIEnv.GetMethodID (class_ref, "getScaleY", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getScaleY);
			}
			[Register ("setScaleY", "(F)V", "GetSetScaleY_FHandler")]
			set {
				if (id_setScaleY_F == IntPtr.Zero)
					id_setScaleY_F = JNIEnv.GetMethodID (class_ref, "setScaleY", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setScaleY_F, new JValue (value));
			}
		}

		static IntPtr id_getScrollX;
		static IntPtr id_setScrollX_I;
		public int ScrollX {
			[Register ("getScrollX", "()I", "GetGetScrollXHandler")]
			get {
				if (id_getScrollX == IntPtr.Zero)
					id_getScrollX = JNIEnv.GetMethodID (class_ref, "getScrollX", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getScrollX);
			}
			[Register ("setScrollX", "(I)V", "GetSetScrollX_IHandler")]
			set {
				if (id_setScrollX_I == IntPtr.Zero)
					id_setScrollX_I = JNIEnv.GetMethodID (class_ref, "setScrollX", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setScrollX_I, new JValue (value));
			}
		}

		static IntPtr id_getScrollY;
		static IntPtr id_setScrollY_I;
		public int ScrollY {
			[Register ("getScrollY", "()I", "GetGetScrollYHandler")]
			get {
				if (id_getScrollY == IntPtr.Zero)
					id_getScrollY = JNIEnv.GetMethodID (class_ref, "getScrollY", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getScrollY);
			}
			[Register ("setScrollY", "(I)V", "GetSetScrollY_IHandler")]
			set {
				if (id_setScrollY_I == IntPtr.Zero)
					id_setScrollY_I = JNIEnv.GetMethodID (class_ref, "setScrollY", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setScrollY_I, new JValue (value));
			}
		}

		static IntPtr id_getTranslationX;
		static IntPtr id_setTranslationX_F;
		public float TranslationX {
			[Register ("getTranslationX", "()F", "GetGetTranslationXHandler")]
			get {
				if (id_getTranslationX == IntPtr.Zero)
					id_getTranslationX = JNIEnv.GetMethodID (class_ref, "getTranslationX", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getTranslationX);
			}
			[Register ("setTranslationX", "(F)V", "GetSetTranslationX_FHandler")]
			set {
				if (id_setTranslationX_F == IntPtr.Zero)
					id_setTranslationX_F = JNIEnv.GetMethodID (class_ref, "setTranslationX", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setTranslationX_F, new JValue (value));
			}
		}

		static IntPtr id_getTranslationY;
		static IntPtr id_setTranslationY_F;
		public float TranslationY {
			[Register ("getTranslationY", "()F", "GetGetTranslationYHandler")]
			get {
				if (id_getTranslationY == IntPtr.Zero)
					id_getTranslationY = JNIEnv.GetMethodID (class_ref, "getTranslationY", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getTranslationY);
			}
			[Register ("setTranslationY", "(F)V", "GetSetTranslationY_FHandler")]
			set {
				if (id_setTranslationY_F == IntPtr.Zero)
					id_setTranslationY_F = JNIEnv.GetMethodID (class_ref, "setTranslationY", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setTranslationY_F, new JValue (value));
			}
		}

		static IntPtr id_getX;
		[Register ("getX", "()F", "")]
		public float GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()F");
			return JNIEnv.CallFloatMethod  (Handle, id_getX);
		}

		static IntPtr id_getY;
		[Register ("getY", "()F", "")]
		public float GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()F");
			return JNIEnv.CallFloatMethod  (Handle, id_getY);
		}

		static IntPtr id_setX_F;
		[Register ("setX", "(F)V", "")]
		public void SetX (float p0)
		{
			if (id_setX_F == IntPtr.Zero)
				id_setX_F = JNIEnv.GetMethodID (class_ref, "setX", "(F)V");
			JNIEnv.CallVoidMethod  (Handle, id_setX_F, new JValue (p0));
		}

		static IntPtr id_setY_F;
		[Register ("setY", "(F)V", "")]
		public void SetY (float p0)
		{
			if (id_setY_F == IntPtr.Zero)
				id_setY_F = JNIEnv.GetMethodID (class_ref, "setY", "(F)V");
			JNIEnv.CallVoidMethod  (Handle, id_setY_F, new JValue (p0));
		}

		static IntPtr id_wrap_Landroid_view_View_;
		[Register ("wrap", "(Landroid/view/View;)Lcom/nineoldandroids/view/animation/AnimatorProxy;", "")]
		public static global::Com.Nineoldandroids.View.Animation.AnimatorProxy Wrap (global::Android.Views.View p0)
		{
			if (id_wrap_Landroid_view_View_ == IntPtr.Zero)
				id_wrap_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Landroid/view/View;)Lcom/nineoldandroids/view/animation/AnimatorProxy;");
			global::Com.Nineoldandroids.View.Animation.AnimatorProxy __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.Animation.AnimatorProxy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Landroid_view_View_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
