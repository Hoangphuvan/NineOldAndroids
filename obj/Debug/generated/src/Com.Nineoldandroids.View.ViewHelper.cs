using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.View {

	[global::Android.Runtime.Register ("com/nineoldandroids/view/ViewHelper", DoNotGenerateAcw=true)]
	public sealed partial class ViewHelper : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/nineoldandroids/view/ViewHelper$Honeycomb", DoNotGenerateAcw=true)]
		public sealed partial class Honeycomb : global::Java.Lang.Object {

			internal Honeycomb (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/view/ViewHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewHelper); }
		}

		internal ViewHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAlpha_Landroid_view_View_;
		[Register ("getAlpha", "(Landroid/view/View;)F", "")]
		public static float GetAlpha (global::Android.Views.View p0)
		{
			if (id_getAlpha_Landroid_view_View_ == IntPtr.Zero)
				id_getAlpha_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getAlpha", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getAlpha_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getPivotX_Landroid_view_View_;
		[Register ("getPivotX", "(Landroid/view/View;)F", "")]
		public static float GetPivotX (global::Android.Views.View p0)
		{
			if (id_getPivotX_Landroid_view_View_ == IntPtr.Zero)
				id_getPivotX_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getPivotX", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getPivotX_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getPivotY_Landroid_view_View_;
		[Register ("getPivotY", "(Landroid/view/View;)F", "")]
		public static float GetPivotY (global::Android.Views.View p0)
		{
			if (id_getPivotY_Landroid_view_View_ == IntPtr.Zero)
				id_getPivotY_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getPivotY", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getPivotY_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getRotation_Landroid_view_View_;
		[Register ("getRotation", "(Landroid/view/View;)F", "")]
		public static float GetRotation (global::Android.Views.View p0)
		{
			if (id_getRotation_Landroid_view_View_ == IntPtr.Zero)
				id_getRotation_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getRotation", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getRotation_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getRotationX_Landroid_view_View_;
		[Register ("getRotationX", "(Landroid/view/View;)F", "")]
		public static float GetRotationX (global::Android.Views.View p0)
		{
			if (id_getRotationX_Landroid_view_View_ == IntPtr.Zero)
				id_getRotationX_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getRotationX", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getRotationX_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getRotationY_Landroid_view_View_;
		[Register ("getRotationY", "(Landroid/view/View;)F", "")]
		public static float GetRotationY (global::Android.Views.View p0)
		{
			if (id_getRotationY_Landroid_view_View_ == IntPtr.Zero)
				id_getRotationY_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getRotationY", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getRotationY_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getScaleX_Landroid_view_View_;
		[Register ("getScaleX", "(Landroid/view/View;)F", "")]
		public static float GetScaleX (global::Android.Views.View p0)
		{
			if (id_getScaleX_Landroid_view_View_ == IntPtr.Zero)
				id_getScaleX_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getScaleX", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getScaleX_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getScaleY_Landroid_view_View_;
		[Register ("getScaleY", "(Landroid/view/View;)F", "")]
		public static float GetScaleY (global::Android.Views.View p0)
		{
			if (id_getScaleY_Landroid_view_View_ == IntPtr.Zero)
				id_getScaleY_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getScaleY", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getScaleY_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getScrollX_Landroid_view_View_;
		[Register ("getScrollX", "(Landroid/view/View;)F", "")]
		public static float GetScrollX (global::Android.Views.View p0)
		{
			if (id_getScrollX_Landroid_view_View_ == IntPtr.Zero)
				id_getScrollX_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getScrollX", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getScrollX_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getScrollY_Landroid_view_View_;
		[Register ("getScrollY", "(Landroid/view/View;)F", "")]
		public static float GetScrollY (global::Android.Views.View p0)
		{
			if (id_getScrollY_Landroid_view_View_ == IntPtr.Zero)
				id_getScrollY_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getScrollY", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getScrollY_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getTranslationX_Landroid_view_View_;
		[Register ("getTranslationX", "(Landroid/view/View;)F", "")]
		public static float GetTranslationX (global::Android.Views.View p0)
		{
			if (id_getTranslationX_Landroid_view_View_ == IntPtr.Zero)
				id_getTranslationX_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getTranslationX", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getTranslationX_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getTranslationY_Landroid_view_View_;
		[Register ("getTranslationY", "(Landroid/view/View;)F", "")]
		public static float GetTranslationY (global::Android.Views.View p0)
		{
			if (id_getTranslationY_Landroid_view_View_ == IntPtr.Zero)
				id_getTranslationY_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getTranslationY", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getTranslationY_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getX_Landroid_view_View_;
		[Register ("getX", "(Landroid/view/View;)F", "")]
		public static float GetX (global::Android.Views.View p0)
		{
			if (id_getX_Landroid_view_View_ == IntPtr.Zero)
				id_getX_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getX", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getX_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getY_Landroid_view_View_;
		[Register ("getY", "(Landroid/view/View;)F", "")]
		public static float GetY (global::Android.Views.View p0)
		{
			if (id_getY_Landroid_view_View_ == IntPtr.Zero)
				id_getY_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getY", "(Landroid/view/View;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getY_Landroid_view_View_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_setAlpha_Landroid_view_View_F;
		[Register ("setAlpha", "(Landroid/view/View;F)V", "")]
		public static void SetAlpha (global::Android.Views.View p0, float p1)
		{
			if (id_setAlpha_Landroid_view_View_F == IntPtr.Zero)
				id_setAlpha_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setAlpha", "(Landroid/view/View;F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setAlpha_Landroid_view_View_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setPivotX_Landroid_view_View_F;
		[Register ("setPivotX", "(Landroid/view/View;F)V", "")]
		public static void SetPivotX (global::Android.Views.View p0, float p1)
		{
			if (id_setPivotX_Landroid_view_View_F == IntPtr.Zero)
				id_setPivotX_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setPivotX", "(Landroid/view/View;F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setPivotX_Landroid_view_View_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setPivotY_Landroid_view_View_F;
		[Register ("setPivotY", "(Landroid/view/View;F)V", "")]
		public static void SetPivotY (global::Android.Views.View p0, float p1)
		{
			if (id_setPivotY_Landroid_view_View_F == IntPtr.Zero)
				id_setPivotY_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setPivotY", "(Landroid/view/View;F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setPivotY_Landroid_view_View_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setRotation_Landroid_view_View_F;
		[Register ("setRotation", "(Landroid/view/View;F)V", "")]
		public static void SetRotation (global::Android.Views.View p0, float p1)
		{
			if (id_setRotation_Landroid_view_View_F == IntPtr.Zero)
				id_setRotation_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setRotation", "(Landroid/view/View;F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setRotation_Landroid_view_View_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setRotationX_Landroid_view_View_F;
		[Register ("setRotationX", "(Landroid/view/View;F)V", "")]
		public static void SetRotationX (global::Android.Views.View p0, float p1)
		{
			if (id_setRotationX_Landroid_view_View_F == IntPtr.Zero)
				id_setRotationX_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setRotationX", "(Landroid/view/View;F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setRotationX_Landroid_view_View_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setRotationY_Landroid_view_View_F;
		[Register ("setRotationY", "(Landroid/view/View;F)V", "")]
		public static void SetRotationY (global::Android.Views.View p0, float p1)
		{
			if (id_setRotationY_Landroid_view_View_F == IntPtr.Zero)
				id_setRotationY_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setRotationY", "(Landroid/view/View;F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setRotationY_Landroid_view_View_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setScaleX_Landroid_view_View_F;
		[Register ("setScaleX", "(Landroid/view/View;F)V", "")]
		public static void SetScaleX (global::Android.Views.View p0, float p1)
		{
			if (id_setScaleX_Landroid_view_View_F == IntPtr.Zero)
				id_setScaleX_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setScaleX", "(Landroid/view/View;F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setScaleX_Landroid_view_View_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setScaleY_Landroid_view_View_F;
		[Register ("setScaleY", "(Landroid/view/View;F)V", "")]
		public static void SetScaleY (global::Android.Views.View p0, float p1)
		{
			if (id_setScaleY_Landroid_view_View_F == IntPtr.Zero)
				id_setScaleY_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setScaleY", "(Landroid/view/View;F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setScaleY_Landroid_view_View_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setScrollX_Landroid_view_View_I;
		[Register ("setScrollX", "(Landroid/view/View;I)V", "")]
		public static void SetScrollX (global::Android.Views.View p0, int p1)
		{
			if (id_setScrollX_Landroid_view_View_I == IntPtr.Zero)
				id_setScrollX_Landroid_view_View_I = JNIEnv.GetStaticMethodID (class_ref, "setScrollX", "(Landroid/view/View;I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setScrollX_Landroid_view_View_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setScrollY_Landroid_view_View_I;
		[Register ("setScrollY", "(Landroid/view/View;I)V", "")]
		public static void SetScrollY (global::Android.Views.View p0, int p1)
		{
			if (id_setScrollY_Landroid_view_View_I == IntPtr.Zero)
				id_setScrollY_Landroid_view_View_I = JNIEnv.GetStaticMethodID (class_ref, "setScrollY", "(Landroid/view/View;I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setScrollY_Landroid_view_View_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setTranslationX_Landroid_view_View_F;
		[Register ("setTranslationX", "(Landroid/view/View;F)V", "")]
		public static void SetTranslationX (global::Android.Views.View p0, float p1)
		{
			if (id_setTranslationX_Landroid_view_View_F == IntPtr.Zero)
				id_setTranslationX_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setTranslationX", "(Landroid/view/View;F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setTranslationX_Landroid_view_View_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setTranslationY_Landroid_view_View_F;
		[Register ("setTranslationY", "(Landroid/view/View;F)V", "")]
		public static void SetTranslationY (global::Android.Views.View p0, float p1)
		{
			if (id_setTranslationY_Landroid_view_View_F == IntPtr.Zero)
				id_setTranslationY_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setTranslationY", "(Landroid/view/View;F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setTranslationY_Landroid_view_View_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setX_Landroid_view_View_F;
		[Register ("setX", "(Landroid/view/View;F)V", "")]
		public static void SetX (global::Android.Views.View p0, float p1)
		{
			if (id_setX_Landroid_view_View_F == IntPtr.Zero)
				id_setX_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setX", "(Landroid/view/View;F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setX_Landroid_view_View_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setY_Landroid_view_View_F;
		[Register ("setY", "(Landroid/view/View;F)V", "")]
		public static void SetY (global::Android.Views.View p0, float p1)
		{
			if (id_setY_Landroid_view_View_F == IntPtr.Zero)
				id_setY_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setY", "(Landroid/view/View;F)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setY_Landroid_view_View_F, new JValue (p0), new JValue (p1));
		}

	}
}
