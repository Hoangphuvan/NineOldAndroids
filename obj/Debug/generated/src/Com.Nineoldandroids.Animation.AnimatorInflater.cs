using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorInflater", DoNotGenerateAcw=true)]
	public partial class AnimatorInflater : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorInflater", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatorInflater); }
		}

		protected AnimatorInflater (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public AnimatorInflater () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AnimatorInflater)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_loadAnimator_Landroid_content_Context_I;
		[Register ("loadAnimator", "(Landroid/content/Context;I)Lcom/nineoldandroids/animation/Animator;", "")]
		public static global::Com.Nineoldandroids.Animation.Animator LoadAnimator (global::Android.Content.Context p0, int p1)
		{
			if (id_loadAnimator_Landroid_content_Context_I == IntPtr.Zero)
				id_loadAnimator_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "loadAnimator", "(Landroid/content/Context;I)Lcom/nineoldandroids/animation/Animator;");
			global::Com.Nineoldandroids.Animation.Animator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadAnimator_Landroid_content_Context_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
