using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	[global::Android.Runtime.Register ("com/nineoldandroids/animation/Animator", DoNotGenerateAcw=true)]
	public abstract partial class Animator : global::Java.Lang.Object, global::Java.Lang.ICloneable {

		[Register ("com/nineoldandroids/animation/Animator$AnimatorListener", "", "Com.Nineoldandroids.Animation.Animator/IAnimatorListenerInvoker")]
		public partial interface IAnimatorListener : IJavaObject {

			[Register ("onAnimationCancel", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationCancel_Lcom_nineoldandroids_animation_Animator_Handler:Com.Nineoldandroids.Animation.Animator/IAnimatorListenerInvoker, NineOldAndroids")]
			void OnAnimationCancel (global::Com.Nineoldandroids.Animation.Animator p0);

			[Register ("onAnimationEnd", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationEnd_Lcom_nineoldandroids_animation_Animator_Handler:Com.Nineoldandroids.Animation.Animator/IAnimatorListenerInvoker, NineOldAndroids")]
			void OnAnimationEnd (global::Com.Nineoldandroids.Animation.Animator p0);

			[Register ("onAnimationRepeat", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationRepeat_Lcom_nineoldandroids_animation_Animator_Handler:Com.Nineoldandroids.Animation.Animator/IAnimatorListenerInvoker, NineOldAndroids")]
			void OnAnimationRepeat (global::Com.Nineoldandroids.Animation.Animator p0);

			[Register ("onAnimationStart", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationStart_Lcom_nineoldandroids_animation_Animator_Handler:Com.Nineoldandroids.Animation.Animator/IAnimatorListenerInvoker, NineOldAndroids")]
			void OnAnimationStart (global::Com.Nineoldandroids.Animation.Animator p0);

		}

		[global::Android.Runtime.Register ("com/nineoldandroids/animation/Animator$AnimatorListener", DoNotGenerateAcw=true)]
		internal class IAnimatorListenerInvoker : global::Java.Lang.Object, IAnimatorListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/nineoldandroids/animation/Animator$AnimatorListener");
			IntPtr class_ref;

			public static IAnimatorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAnimatorListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.nineoldandroids.animation.Animator.AnimatorListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAnimatorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IAnimatorListenerInvoker); }
			}

			static Delegate cb_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
			static Delegate GetOnAnimationCancel_Lcom_nineoldandroids_animation_Animator_Handler ()
			{
				if (cb_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_ == null)
					cb_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationCancel_Lcom_nineoldandroids_animation_Animator_);
				return cb_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_;
			}

			static void n_OnAnimationCancel_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationCancel (p0);
			}
#pragma warning restore 0169

			IntPtr id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_;
			public void OnAnimationCancel (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationCancel", "(Lcom/nineoldandroids/animation/Animator;)V");
				JNIEnv.CallVoidMethod (Handle, id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
			}

			static Delegate cb_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
			static Delegate GetOnAnimationEnd_Lcom_nineoldandroids_animation_Animator_Handler ()
			{
				if (cb_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_ == null)
					cb_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationEnd_Lcom_nineoldandroids_animation_Animator_);
				return cb_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_;
			}

			static void n_OnAnimationEnd_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationEnd (p0);
			}
#pragma warning restore 0169

			IntPtr id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_;
			public void OnAnimationEnd (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationEnd", "(Lcom/nineoldandroids/animation/Animator;)V");
				JNIEnv.CallVoidMethod (Handle, id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
			}

			static Delegate cb_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
			static Delegate GetOnAnimationRepeat_Lcom_nineoldandroids_animation_Animator_Handler ()
			{
				if (cb_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ == null)
					cb_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationRepeat_Lcom_nineoldandroids_animation_Animator_);
				return cb_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_;
			}

			static void n_OnAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationRepeat (p0);
			}
#pragma warning restore 0169

			IntPtr id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_;
			public void OnAnimationRepeat (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationRepeat", "(Lcom/nineoldandroids/animation/Animator;)V");
				JNIEnv.CallVoidMethod (Handle, id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
			}

			static Delegate cb_onAnimationStart_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
			static Delegate GetOnAnimationStart_Lcom_nineoldandroids_animation_Animator_Handler ()
			{
				if (cb_onAnimationStart_Lcom_nineoldandroids_animation_Animator_ == null)
					cb_onAnimationStart_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationStart_Lcom_nineoldandroids_animation_Animator_);
				return cb_onAnimationStart_Lcom_nineoldandroids_animation_Animator_;
			}

			static void n_OnAnimationStart_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationStart (p0);
			}
#pragma warning restore 0169

			IntPtr id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_;
			public void OnAnimationStart (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationStart", "(Lcom/nineoldandroids/animation/Animator;)V");
				JNIEnv.CallVoidMethod (Handle, id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
			}

		}

		public partial class AnimationCancelEventArgs : global::System.EventArgs {

			public AnimationCancelEventArgs (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				this.p0 = p0;
			}

			global::Com.Nineoldandroids.Animation.Animator p0;
			public global::Com.Nineoldandroids.Animation.Animator P0 {
				get { return p0; }
			}
		}

		public partial class AnimationEndEventArgs : global::System.EventArgs {

			public AnimationEndEventArgs (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				this.p0 = p0;
			}

			global::Com.Nineoldandroids.Animation.Animator p0;
			public global::Com.Nineoldandroids.Animation.Animator P0 {
				get { return p0; }
			}
		}

		public partial class AnimationRepeatEventArgs : global::System.EventArgs {

			public AnimationRepeatEventArgs (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				this.p0 = p0;
			}

			global::Com.Nineoldandroids.Animation.Animator p0;
			public global::Com.Nineoldandroids.Animation.Animator P0 {
				get { return p0; }
			}
		}

		public partial class AnimationStartEventArgs : global::System.EventArgs {

			public AnimationStartEventArgs (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				this.p0 = p0;
			}

			global::Com.Nineoldandroids.Animation.Animator p0;
			public global::Com.Nineoldandroids.Animation.Animator P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/nineoldandroids/animation/Animator_AnimatorListenerImplementor")]
		internal sealed class IAnimatorListenerImplementor : global::Java.Lang.Object, IAnimatorListener {

			object sender;

			public IAnimatorListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/nineoldandroids/animation/Animator_AnimatorListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AnimationCancelEventArgs> OnAnimationCancelHandler;
#pragma warning restore 0649

			public void OnAnimationCancel (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (OnAnimationCancelHandler != null)
					OnAnimationCancelHandler (sender, new AnimationCancelEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<AnimationEndEventArgs> OnAnimationEndHandler;
#pragma warning restore 0649

			public void OnAnimationEnd (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (OnAnimationEndHandler != null)
					OnAnimationEndHandler (sender, new AnimationEndEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<AnimationRepeatEventArgs> OnAnimationRepeatHandler;
#pragma warning restore 0649

			public void OnAnimationRepeat (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (OnAnimationRepeatHandler != null)
					OnAnimationRepeatHandler (sender, new AnimationRepeatEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<AnimationStartEventArgs> OnAnimationStartHandler;
#pragma warning restore 0649

			public void OnAnimationStart (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (OnAnimationStartHandler != null)
					OnAnimationStartHandler (sender, new AnimationStartEventArgs (p0));
			}

			internal static bool __IsEmpty (IAnimatorListenerImplementor value)
			{
				return value.OnAnimationCancelHandler == null && value.OnAnimationEndHandler == null && value.OnAnimationRepeatHandler == null && value.OnAnimationStartHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/Animator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Animator); }
		}

		protected Animator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public Animator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Animator)) {
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
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		public abstract long Duration { [Register ("getDuration", "()J", "GetGetDurationHandler")] get; }

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		public abstract bool IsRunning { [Register ("isRunning", "()Z", "GetIsRunningHandler")] get; }

		static Delegate cb_isStarted;
#pragma warning disable 0169
		static Delegate GetIsStartedHandler ()
		{
			if (cb_isStarted == null)
				cb_isStarted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStarted);
			return cb_isStarted;
		}

		static bool n_IsStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStarted;
		}
#pragma warning restore 0169

		static IntPtr id_isStarted;
		public virtual bool IsStarted {
			[Register ("isStarted", "()Z", "GetIsStartedHandler")]
			get {
				if (id_isStarted == IntPtr.Zero)
					id_isStarted = JNIEnv.GetMethodID (class_ref, "isStarted", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isStarted);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isStarted);
			}
		}

		static Delegate cb_getListeners;
#pragma warning disable 0169
		static Delegate GetGetListenersHandler ()
		{
			if (cb_getListeners == null)
				cb_getListeners = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListeners);
			return cb_getListeners;
		}

		static IntPtr n_GetListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener>.ToLocalJniHandle (__this.Listeners);
		}
#pragma warning restore 0169

		static IntPtr id_getListeners;
		public virtual global::System.Collections.Generic.IList<global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener> Listeners {
			[Register ("getListeners", "()Ljava/util/ArrayList;", "GetGetListenersHandler")]
			get {
				if (id_getListeners == IntPtr.Zero)
					id_getListeners = JNIEnv.GetMethodID (class_ref, "getListeners", "()Ljava/util/ArrayList;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getListeners), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getListeners), JniHandleOwnership.TransferLocalRef);
			}
		}

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
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartDelay;
		}
#pragma warning restore 0169

		static Delegate cb_setStartDelay_J;
#pragma warning disable 0169
		static Delegate GetSetStartDelay_JHandler ()
		{
			if (cb_setStartDelay_J == null)
				cb_setStartDelay_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetStartDelay_J);
			return cb_setStartDelay_J;
		}

		static void n_SetStartDelay_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDelay = p0;
		}
#pragma warning restore 0169

		public abstract long StartDelay { [Register ("getStartDelay", "()J", "GetGetStartDelayHandler")] get; [Register ("setStartDelay", "(J)V", "GetSetStartDelay_JHandler")] set; }

		static Delegate cb_addListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_Handler ()
		{
			if (cb_addListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ == null)
				cb_addListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_);
			return cb_addListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_;
		}

		static void n_AddListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_;
		[Register ("addListener", "(Lcom/nineoldandroids/animation/Animator$AnimatorListener;)V", "GetAddListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_Handler")]
		public virtual void AddListener (global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener p0)
		{
			if (id_addListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ == IntPtr.Zero)
				id_addListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lcom/nineoldandroids/animation/Animator$AnimatorListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_, new JValue (p0));
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
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_cancel);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_cancel);
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
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		[Register ("clone", "()Lcom/nineoldandroids/animation/Animator;", "GetCloneHandler")]
		public virtual global::Com.Nineoldandroids.Animation.Animator Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/nineoldandroids/animation/Animator;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_clone), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_end;
#pragma warning disable 0169
		static Delegate GetEndHandler ()
		{
			if (cb_end == null)
				cb_end = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_End);
			return cb_end;
		}

		static void n_End (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		static IntPtr id_end;
		[Register ("end", "()V", "GetEndHandler")]
		public virtual void End ()
		{
			if (id_end == IntPtr.Zero)
				id_end = JNIEnv.GetMethodID (class_ref, "end", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_end);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_end);
		}

		static Delegate cb_removeAllListeners;
#pragma warning disable 0169
		static Delegate GetRemoveAllListenersHandler ()
		{
			if (cb_removeAllListeners == null)
				cb_removeAllListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllListeners);
			return cb_removeAllListeners;
		}

		static void n_RemoveAllListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllListeners ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllListeners;
		[Register ("removeAllListeners", "()V", "GetRemoveAllListenersHandler")]
		public virtual void RemoveAllListeners ()
		{
			if (id_removeAllListeners == IntPtr.Zero)
				id_removeAllListeners = JNIEnv.GetMethodID (class_ref, "removeAllListeners", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeAllListeners);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeAllListeners);
		}

		static Delegate cb_removeListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_Handler ()
		{
			if (cb_removeListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ == null)
				cb_removeListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_);
			return cb_removeListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_;
		}

		static void n_RemoveListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_;
		[Register ("removeListener", "(Lcom/nineoldandroids/animation/Animator$AnimatorListener;)V", "GetRemoveListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_Handler")]
		public virtual void RemoveListener (global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener p0)
		{
			if (id_removeListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ == IntPtr.Zero)
				id_removeListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lcom/nineoldandroids/animation/Animator$AnimatorListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_, new JValue (p0));
		}

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
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDuration (p0));
		}
#pragma warning restore 0169

		[Register ("setDuration", "(J)Lcom/nineoldandroids/animation/Animator;", "GetSetDuration_JHandler")]
		public abstract global::Com.Nineoldandroids.Animation.Animator SetDuration (long p0);

		static Delegate cb_setInterpolator_Landroid_view_animation_Interpolator_;
#pragma warning disable 0169
		static Delegate GetSetInterpolator_Landroid_view_animation_Interpolator_Handler ()
		{
			if (cb_setInterpolator_Landroid_view_animation_Interpolator_ == null)
				cb_setInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInterpolator_Landroid_view_animation_Interpolator_);
			return cb_setInterpolator_Landroid_view_animation_Interpolator_;
		}

		static void n_SetInterpolator_Landroid_view_animation_Interpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInterpolator (p0);
		}
#pragma warning restore 0169

		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)V", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public abstract void SetInterpolator (global::Android.Views.Animations.IInterpolator p0);

		static Delegate cb_setTarget_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetTarget_Ljava_lang_Object_Handler ()
		{
			if (cb_setTarget_Ljava_lang_Object_ == null)
				cb_setTarget_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTarget_Ljava_lang_Object_);
			return cb_setTarget_Ljava_lang_Object_;
		}

		static void n_SetTarget_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTarget (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTarget_Ljava_lang_Object_;
		[Register ("setTarget", "(Ljava/lang/Object;)V", "GetSetTarget_Ljava_lang_Object_Handler")]
		public virtual void SetTarget (global::Java.Lang.Object p0)
		{
			if (id_setTarget_Ljava_lang_Object_ == IntPtr.Zero)
				id_setTarget_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setTarget", "(Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTarget_Ljava_lang_Object_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setTarget_Ljava_lang_Object_, new JValue (p0));
		}

		static Delegate cb_setupEndValues;
#pragma warning disable 0169
		static Delegate GetSetupEndValuesHandler ()
		{
			if (cb_setupEndValues == null)
				cb_setupEndValues = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetupEndValues);
			return cb_setupEndValues;
		}

		static void n_SetupEndValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetupEndValues ();
		}
#pragma warning restore 0169

		static IntPtr id_setupEndValues;
		[Register ("setupEndValues", "()V", "GetSetupEndValuesHandler")]
		public virtual void SetupEndValues ()
		{
			if (id_setupEndValues == IntPtr.Zero)
				id_setupEndValues = JNIEnv.GetMethodID (class_ref, "setupEndValues", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setupEndValues);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setupEndValues);
		}

		static Delegate cb_setupStartValues;
#pragma warning disable 0169
		static Delegate GetSetupStartValuesHandler ()
		{
			if (cb_setupStartValues == null)
				cb_setupStartValues = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetupStartValues);
			return cb_setupStartValues;
		}

		static void n_SetupStartValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetupStartValues ();
		}
#pragma warning restore 0169

		static IntPtr id_setupStartValues;
		[Register ("setupStartValues", "()V", "GetSetupStartValuesHandler")]
		public virtual void SetupStartValues ()
		{
			if (id_setupStartValues == IntPtr.Zero)
				id_setupStartValues = JNIEnv.GetMethodID (class_ref, "setupStartValues", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setupStartValues);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setupStartValues);
		}

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
			global::Com.Nineoldandroids.Animation.Animator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		[Register ("start", "()V", "GetStartHandler")]
		public virtual void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_start);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_start);
		}

#region "Event implementation for Com.Nineoldandroids.Animation.Animator.IAnimatorListener"

		global::Com.Nineoldandroids.Animation.Animator.IAnimatorListenerImplementor __CreateIAnimatorListenerImplementor ()
		{
			return new global::Com.Nineoldandroids.Animation.Animator.IAnimatorListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/nineoldandroids/animation/Animator", DoNotGenerateAcw=true)]
	internal partial class AnimatorInvoker : Animator {

		public AnimatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatorInvoker); }
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

		static IntPtr id_isRunning;
		public override bool IsRunning {
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
			}
		}

		static IntPtr id_getStartDelay;
		static IntPtr id_setStartDelay_J;
		public override long StartDelay {
			[Register ("getStartDelay", "()J", "GetGetStartDelayHandler")]
			get {
				if (id_getStartDelay == IntPtr.Zero)
					id_getStartDelay = JNIEnv.GetMethodID (class_ref, "getStartDelay", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getStartDelay);
			}
			[Register ("setStartDelay", "(J)V", "GetSetStartDelay_JHandler")]
			set {
				if (id_setStartDelay_J == IntPtr.Zero)
					id_setStartDelay_J = JNIEnv.GetMethodID (class_ref, "setStartDelay", "(J)V");
				JNIEnv.CallVoidMethod  (Handle, id_setStartDelay_J, new JValue (value));
			}
		}

		static IntPtr id_setDuration_J;
		[Register ("setDuration", "(J)Lcom/nineoldandroids/animation/Animator;", "GetSetDuration_JHandler")]
		public override global::Com.Nineoldandroids.Animation.Animator SetDuration (long p0)
		{
			if (id_setDuration_J == IntPtr.Zero)
				id_setDuration_J = JNIEnv.GetMethodID (class_ref, "setDuration", "(J)Lcom/nineoldandroids/animation/Animator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (JNIEnv.CallObjectMethod  (Handle, id_setDuration_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setInterpolator_Landroid_view_animation_Interpolator_;
		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)V", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public override void SetInterpolator (global::Android.Views.Animations.IInterpolator p0)
		{
			if (id_setInterpolator_Landroid_view_animation_Interpolator_ == IntPtr.Zero)
				id_setInterpolator_Landroid_view_animation_Interpolator_ = JNIEnv.GetMethodID (class_ref, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setInterpolator_Landroid_view_animation_Interpolator_, new JValue (p0));
		}

	}

}
