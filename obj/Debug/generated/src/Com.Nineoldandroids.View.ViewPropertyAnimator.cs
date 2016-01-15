using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.View {

	[global::Android.Runtime.Register ("com/nineoldandroids/view/ViewPropertyAnimator", DoNotGenerateAcw=true)]
	public abstract partial class ViewPropertyAnimator : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/view/ViewPropertyAnimator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewPropertyAnimator); }
		}

		protected ViewPropertyAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public ViewPropertyAnimator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ViewPropertyAnimator)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		public abstract long Duration { [Register ("getDuration", "()J", "GetGetDurationHandler")] get; }

		static Delegate cb_getStartDelay;
#pragma warning disable 0169
		static Delegate GetGetStartDelayHandler ()
		{
			if (cb_getStartDelay == null)
				cb_getStartDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetStartDelay);
			return cb_getStartDelay;
		}

		static long n_GetStartDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartDelay;
		}
#pragma warning restore 0169

		public abstract long StartDelay { [Register ("getStartDelay", "()J", "GetGetStartDelayHandler")] get; }

		static Delegate cb_alpha_F;
#pragma warning disable 0169
		static Delegate GetAlpha_FHandler ()
		{
			if (cb_alpha_F == null)
				cb_alpha_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Alpha_F);
			return cb_alpha_F;
		}

		static IntPtr n_Alpha_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Alpha (p0));
		}
#pragma warning restore 0169

		[Register ("alpha", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetAlpha_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator Alpha (float p0);

		static Delegate cb_alphaBy_F;
#pragma warning disable 0169
		static Delegate GetAlphaBy_FHandler ()
		{
			if (cb_alphaBy_F == null)
				cb_alphaBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_AlphaBy_F);
			return cb_alphaBy_F;
		}

		static IntPtr n_AlphaBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AlphaBy (p0));
		}
#pragma warning restore 0169

		[Register ("alphaBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetAlphaBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator AlphaBy (float p0);

		static IntPtr id_animate_Landroid_view_View_;
		[Register ("animate", "(Landroid/view/View;)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "")]
		public static global::Com.Nineoldandroids.View.ViewPropertyAnimator Animate (global::Android.Views.View p0)
		{
			if (id_animate_Landroid_view_View_ == IntPtr.Zero)
				id_animate_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "animate", "(Landroid/view/View;)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_animate_Landroid_view_View_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		[Register ("cancel", "()V", "GetCancelHandler")]
		public abstract void Cancel ();

		static Delegate cb_rotation_F;
#pragma warning disable 0169
		static Delegate GetRotation_FHandler ()
		{
			if (cb_rotation_F == null)
				cb_rotation_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Rotation_F);
			return cb_rotation_F;
		}

		static IntPtr n_Rotation_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rotation (p0));
		}
#pragma warning restore 0169

		[Register ("rotation", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotation_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator Rotation (float p0);

		static Delegate cb_rotationBy_F;
#pragma warning disable 0169
		static Delegate GetRotationBy_FHandler ()
		{
			if (cb_rotationBy_F == null)
				cb_rotationBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_RotationBy_F);
			return cb_rotationBy_F;
		}

		static IntPtr n_RotationBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotationBy (p0));
		}
#pragma warning restore 0169

		[Register ("rotationBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationBy (float p0);

		static Delegate cb_rotationX_F;
#pragma warning disable 0169
		static Delegate GetRotationX_FHandler ()
		{
			if (cb_rotationX_F == null)
				cb_rotationX_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_RotationX_F);
			return cb_rotationX_F;
		}

		static IntPtr n_RotationX_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotationX (p0));
		}
#pragma warning restore 0169

		[Register ("rotationX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationX_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationX (float p0);

		static Delegate cb_rotationXBy_F;
#pragma warning disable 0169
		static Delegate GetRotationXBy_FHandler ()
		{
			if (cb_rotationXBy_F == null)
				cb_rotationXBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_RotationXBy_F);
			return cb_rotationXBy_F;
		}

		static IntPtr n_RotationXBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotationXBy (p0));
		}
#pragma warning restore 0169

		[Register ("rotationXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationXBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationXBy (float p0);

		static Delegate cb_rotationY_F;
#pragma warning disable 0169
		static Delegate GetRotationY_FHandler ()
		{
			if (cb_rotationY_F == null)
				cb_rotationY_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_RotationY_F);
			return cb_rotationY_F;
		}

		static IntPtr n_RotationY_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotationY (p0));
		}
#pragma warning restore 0169

		[Register ("rotationY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationY_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationY (float p0);

		static Delegate cb_rotationYBy_F;
#pragma warning disable 0169
		static Delegate GetRotationYBy_FHandler ()
		{
			if (cb_rotationYBy_F == null)
				cb_rotationYBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_RotationYBy_F);
			return cb_rotationYBy_F;
		}

		static IntPtr n_RotationYBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotationYBy (p0));
		}
#pragma warning restore 0169

		[Register ("rotationYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationYBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationYBy (float p0);

		static Delegate cb_scaleX_F;
#pragma warning disable 0169
		static Delegate GetScaleX_FHandler ()
		{
			if (cb_scaleX_F == null)
				cb_scaleX_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_ScaleX_F);
			return cb_scaleX_F;
		}

		static IntPtr n_ScaleX_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleX (p0));
		}
#pragma warning restore 0169

		[Register ("scaleX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleX_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleX (float p0);

		static Delegate cb_scaleXBy_F;
#pragma warning disable 0169
		static Delegate GetScaleXBy_FHandler ()
		{
			if (cb_scaleXBy_F == null)
				cb_scaleXBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_ScaleXBy_F);
			return cb_scaleXBy_F;
		}

		static IntPtr n_ScaleXBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleXBy (p0));
		}
#pragma warning restore 0169

		[Register ("scaleXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleXBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleXBy (float p0);

		static Delegate cb_scaleY_F;
#pragma warning disable 0169
		static Delegate GetScaleY_FHandler ()
		{
			if (cb_scaleY_F == null)
				cb_scaleY_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_ScaleY_F);
			return cb_scaleY_F;
		}

		static IntPtr n_ScaleY_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleY (p0));
		}
#pragma warning restore 0169

		[Register ("scaleY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleY_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleY (float p0);

		static Delegate cb_scaleYBy_F;
#pragma warning disable 0169
		static Delegate GetScaleYBy_FHandler ()
		{
			if (cb_scaleYBy_F == null)
				cb_scaleYBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_ScaleYBy_F);
			return cb_scaleYBy_F;
		}

		static IntPtr n_ScaleYBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleYBy (p0));
		}
#pragma warning restore 0169

		[Register ("scaleYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleYBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleYBy (float p0);

		static Delegate cb_setDuration_J;
#pragma warning disable 0169
		static Delegate GetSetDuration_JHandler ()
		{
			if (cb_setDuration_J == null)
				cb_setDuration_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetDuration_J);
			return cb_setDuration_J;
		}

		static IntPtr n_SetDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDuration (p0));
		}
#pragma warning restore 0169

		[Register ("setDuration", "(J)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetDuration_JHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator SetDuration (long p0);

		static Delegate cb_setInterpolator_Landroid_view_animation_Interpolator_;
#pragma warning disable 0169
		static Delegate GetSetInterpolator_Landroid_view_animation_Interpolator_Handler ()
		{
			if (cb_setInterpolator_Landroid_view_animation_Interpolator_ == null)
				cb_setInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInterpolator_Landroid_view_animation_Interpolator_);
			return cb_setInterpolator_Landroid_view_animation_Interpolator_;
		}

		static IntPtr n_SetInterpolator_Landroid_view_animation_Interpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInterpolator (p0));
			return __ret;
		}
#pragma warning restore 0169

		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator SetInterpolator (global::Android.Views.Animations.IInterpolator p0);

		static Delegate cb_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_Handler ()
		{
			if (cb_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ == null)
				cb_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_);
			return cb_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_;
		}

		static IntPtr n_SetListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		[Register ("setListener", "(Lcom/nineoldandroids/animation/Animator$AnimatorListener;)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_Handler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator SetListener (global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener p0);

		static Delegate cb_setStartDelay_J;
#pragma warning disable 0169
		static Delegate GetSetStartDelay_JHandler ()
		{
			if (cb_setStartDelay_J == null)
				cb_setStartDelay_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetStartDelay_J);
			return cb_setStartDelay_J;
		}

		static IntPtr n_SetStartDelay_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStartDelay (p0));
		}
#pragma warning restore 0169

		[Register ("setStartDelay", "(J)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetStartDelay_JHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator SetStartDelay (long p0);

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		[Register ("start", "()V", "GetStartHandler")]
		public abstract void Start ();

		static Delegate cb_translationX_F;
#pragma warning disable 0169
		static Delegate GetTranslationX_FHandler ()
		{
			if (cb_translationX_F == null)
				cb_translationX_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_TranslationX_F);
			return cb_translationX_F;
		}

		static IntPtr n_TranslationX_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TranslationX (p0));
		}
#pragma warning restore 0169

		[Register ("translationX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationX_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationX (float p0);

		static Delegate cb_translationXBy_F;
#pragma warning disable 0169
		static Delegate GetTranslationXBy_FHandler ()
		{
			if (cb_translationXBy_F == null)
				cb_translationXBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_TranslationXBy_F);
			return cb_translationXBy_F;
		}

		static IntPtr n_TranslationXBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TranslationXBy (p0));
		}
#pragma warning restore 0169

		[Register ("translationXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationXBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationXBy (float p0);

		static Delegate cb_translationY_F;
#pragma warning disable 0169
		static Delegate GetTranslationY_FHandler ()
		{
			if (cb_translationY_F == null)
				cb_translationY_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_TranslationY_F);
			return cb_translationY_F;
		}

		static IntPtr n_TranslationY_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TranslationY (p0));
		}
#pragma warning restore 0169

		[Register ("translationY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationY_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationY (float p0);

		static Delegate cb_translationYBy_F;
#pragma warning disable 0169
		static Delegate GetTranslationYBy_FHandler ()
		{
			if (cb_translationYBy_F == null)
				cb_translationYBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_TranslationYBy_F);
			return cb_translationYBy_F;
		}

		static IntPtr n_TranslationYBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TranslationYBy (p0));
		}
#pragma warning restore 0169

		[Register ("translationYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationYBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationYBy (float p0);

		static Delegate cb_x_F;
#pragma warning disable 0169
		static Delegate GetX_FHandler ()
		{
			if (cb_x_F == null)
				cb_x_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_X_F);
			return cb_x_F;
		}

		static IntPtr n_X_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.X (p0));
		}
#pragma warning restore 0169

		[Register ("x", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetX_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator X (float p0);

		static Delegate cb_xBy_F;
#pragma warning disable 0169
		static Delegate GetXBy_FHandler ()
		{
			if (cb_xBy_F == null)
				cb_xBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_XBy_F);
			return cb_xBy_F;
		}

		static IntPtr n_XBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.XBy (p0));
		}
#pragma warning restore 0169

		[Register ("xBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetXBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator XBy (float p0);

		static Delegate cb_y_F;
#pragma warning disable 0169
		static Delegate GetY_FHandler ()
		{
			if (cb_y_F == null)
				cb_y_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Y_F);
			return cb_y_F;
		}

		static IntPtr n_Y_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Y (p0));
		}
#pragma warning restore 0169

		[Register ("y", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetY_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator Y (float p0);

		static Delegate cb_yBy_F;
#pragma warning disable 0169
		static Delegate GetYBy_FHandler ()
		{
			if (cb_yBy_F == null)
				cb_yBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_YBy_F);
			return cb_yBy_F;
		}

		static IntPtr n_YBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.YBy (p0));
		}
#pragma warning restore 0169

		[Register ("yBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetYBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator YBy (float p0);

	}

	[global::Android.Runtime.Register ("com/nineoldandroids/view/ViewPropertyAnimator", DoNotGenerateAcw=true)]
	internal partial class ViewPropertyAnimatorInvoker : ViewPropertyAnimator {

		public ViewPropertyAnimatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewPropertyAnimatorInvoker); }
		}

		static IntPtr id_getDuration;
		public override long Duration {
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getDuration);
			}
		}

		static IntPtr id_getStartDelay;
		public override long StartDelay {
			[Register ("getStartDelay", "()J", "GetGetStartDelayHandler")]
			get {
				if (id_getStartDelay == IntPtr.Zero)
					id_getStartDelay = JNIEnv.GetMethodID (class_ref, "getStartDelay", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getStartDelay);
			}
		}

		static IntPtr id_alpha_F;
		[Register ("alpha", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetAlpha_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator Alpha (float p0)
		{
			if (id_alpha_F == IntPtr.Zero)
				id_alpha_F = JNIEnv.GetMethodID (class_ref, "alpha", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_alpha_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_alphaBy_F;
		[Register ("alphaBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetAlphaBy_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator AlphaBy (float p0)
		{
			if (id_alphaBy_F == IntPtr.Zero)
				id_alphaBy_F = JNIEnv.GetMethodID (class_ref, "alphaBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_alphaBy_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_cancel;
		[Register ("cancel", "()V", "GetCancelHandler")]
		public override void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_cancel);
		}

		static IntPtr id_rotation_F;
		[Register ("rotation", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotation_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator Rotation (float p0)
		{
			if (id_rotation_F == IntPtr.Zero)
				id_rotation_F = JNIEnv.GetMethodID (class_ref, "rotation", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_rotation_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_rotationBy_F;
		[Register ("rotationBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationBy_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationBy (float p0)
		{
			if (id_rotationBy_F == IntPtr.Zero)
				id_rotationBy_F = JNIEnv.GetMethodID (class_ref, "rotationBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_rotationBy_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_rotationX_F;
		[Register ("rotationX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationX_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationX (float p0)
		{
			if (id_rotationX_F == IntPtr.Zero)
				id_rotationX_F = JNIEnv.GetMethodID (class_ref, "rotationX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_rotationX_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_rotationXBy_F;
		[Register ("rotationXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationXBy_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationXBy (float p0)
		{
			if (id_rotationXBy_F == IntPtr.Zero)
				id_rotationXBy_F = JNIEnv.GetMethodID (class_ref, "rotationXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_rotationXBy_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_rotationY_F;
		[Register ("rotationY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationY_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationY (float p0)
		{
			if (id_rotationY_F == IntPtr.Zero)
				id_rotationY_F = JNIEnv.GetMethodID (class_ref, "rotationY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_rotationY_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_rotationYBy_F;
		[Register ("rotationYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationYBy_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationYBy (float p0)
		{
			if (id_rotationYBy_F == IntPtr.Zero)
				id_rotationYBy_F = JNIEnv.GetMethodID (class_ref, "rotationYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_rotationYBy_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_scaleX_F;
		[Register ("scaleX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleX_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleX (float p0)
		{
			if (id_scaleX_F == IntPtr.Zero)
				id_scaleX_F = JNIEnv.GetMethodID (class_ref, "scaleX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_scaleX_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_scaleXBy_F;
		[Register ("scaleXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleXBy_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleXBy (float p0)
		{
			if (id_scaleXBy_F == IntPtr.Zero)
				id_scaleXBy_F = JNIEnv.GetMethodID (class_ref, "scaleXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_scaleXBy_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_scaleY_F;
		[Register ("scaleY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleY_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleY (float p0)
		{
			if (id_scaleY_F == IntPtr.Zero)
				id_scaleY_F = JNIEnv.GetMethodID (class_ref, "scaleY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_scaleY_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_scaleYBy_F;
		[Register ("scaleYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleYBy_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleYBy (float p0)
		{
			if (id_scaleYBy_F == IntPtr.Zero)
				id_scaleYBy_F = JNIEnv.GetMethodID (class_ref, "scaleYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_scaleYBy_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setDuration_J;
		[Register ("setDuration", "(J)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetDuration_JHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator SetDuration (long p0)
		{
			if (id_setDuration_J == IntPtr.Zero)
				id_setDuration_J = JNIEnv.GetMethodID (class_ref, "setDuration", "(J)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_setDuration_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setInterpolator_Landroid_view_animation_Interpolator_;
		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator SetInterpolator (global::Android.Views.Animations.IInterpolator p0)
		{
			if (id_setInterpolator_Landroid_view_animation_Interpolator_ == IntPtr.Zero)
				id_setInterpolator_Landroid_view_animation_Interpolator_ = JNIEnv.GetMethodID (class_ref, "setInterpolator", "(Landroid/view/animation/Interpolator;)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_setInterpolator_Landroid_view_animation_Interpolator_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_;
		[Register ("setListener", "(Lcom/nineoldandroids/animation/Animator$AnimatorListener;)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_Handler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator SetListener (global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener p0)
		{
			if (id_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ == IntPtr.Zero)
				id_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/nineoldandroids/animation/Animator$AnimatorListener;)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_setStartDelay_J;
		[Register ("setStartDelay", "(J)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetStartDelay_JHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator SetStartDelay (long p0)
		{
			if (id_setStartDelay_J == IntPtr.Zero)
				id_setStartDelay_J = JNIEnv.GetMethodID (class_ref, "setStartDelay", "(J)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_setStartDelay_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_start;
		[Register ("start", "()V", "GetStartHandler")]
		public override void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_start);
		}

		static IntPtr id_translationX_F;
		[Register ("translationX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationX_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationX (float p0)
		{
			if (id_translationX_F == IntPtr.Zero)
				id_translationX_F = JNIEnv.GetMethodID (class_ref, "translationX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_translationX_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_translationXBy_F;
		[Register ("translationXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationXBy_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationXBy (float p0)
		{
			if (id_translationXBy_F == IntPtr.Zero)
				id_translationXBy_F = JNIEnv.GetMethodID (class_ref, "translationXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_translationXBy_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_translationY_F;
		[Register ("translationY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationY_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationY (float p0)
		{
			if (id_translationY_F == IntPtr.Zero)
				id_translationY_F = JNIEnv.GetMethodID (class_ref, "translationY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_translationY_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_translationYBy_F;
		[Register ("translationYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationYBy_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationYBy (float p0)
		{
			if (id_translationYBy_F == IntPtr.Zero)
				id_translationYBy_F = JNIEnv.GetMethodID (class_ref, "translationYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_translationYBy_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_x_F;
		[Register ("x", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetX_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator X (float p0)
		{
			if (id_x_F == IntPtr.Zero)
				id_x_F = JNIEnv.GetMethodID (class_ref, "x", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_x_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_xBy_F;
		[Register ("xBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetXBy_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator XBy (float p0)
		{
			if (id_xBy_F == IntPtr.Zero)
				id_xBy_F = JNIEnv.GetMethodID (class_ref, "xBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_xBy_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_y_F;
		[Register ("y", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetY_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator Y (float p0)
		{
			if (id_y_F == IntPtr.Zero)
				id_y_F = JNIEnv.GetMethodID (class_ref, "y", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_y_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_yBy_F;
		[Register ("yBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetYBy_FHandler")]
		public override global::Com.Nineoldandroids.View.ViewPropertyAnimator YBy (float p0)
		{
			if (id_yBy_F == IntPtr.Zero)
				id_yBy_F = JNIEnv.GetMethodID (class_ref, "yBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_yBy_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}

}
