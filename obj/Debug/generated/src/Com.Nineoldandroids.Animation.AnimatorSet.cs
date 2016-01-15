using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorSet", DoNotGenerateAcw=true)]
	public sealed partial class AnimatorSet : global::Com.Nineoldandroids.Animation.Animator {

		[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorSet$AnimatorSetListener", DoNotGenerateAcw=true)]
		public partial class AnimatorSetListener : global::Java.Lang.Object, global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorSet$AnimatorSetListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AnimatorSetListener); }
			}

			protected AnimatorSetListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationCancel (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_;
			[Register ("onAnimationCancel", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationCancel_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual void OnAnimationCancel (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationCancel", "(Lcom/nineoldandroids/animation/Animator;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationEnd (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_;
			[Register ("onAnimationEnd", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationEnd_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual void OnAnimationEnd (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationEnd", "(Lcom/nineoldandroids/animation/Animator;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationRepeat (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_;
			[Register ("onAnimationRepeat", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationRepeat_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual void OnAnimationRepeat (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationRepeat", "(Lcom/nineoldandroids/animation/Animator;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationStart (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_;
			[Register ("onAnimationStart", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationStart_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual void OnAnimationStart (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationStart", "(Lcom/nineoldandroids/animation/Animator;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
			}

		}

		[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorSet$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorSet$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_after_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
			static Delegate GetAfter_Lcom_nineoldandroids_animation_Animator_Handler ()
			{
				if (cb_after_Lcom_nineoldandroids_animation_Animator_ == null)
					cb_after_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_After_Lcom_nineoldandroids_animation_Animator_);
				return cb_after_Lcom_nineoldandroids_animation_Animator_;
			}

			static IntPtr n_After_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.After (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_after_Lcom_nineoldandroids_animation_Animator_;
			[Register ("after", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;", "GetAfter_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual global::Com.Nineoldandroids.Animation.AnimatorSet.Builder After (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_after_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_after_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "after", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;");

				global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_after_Lcom_nineoldandroids_animation_Animator_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_after_Lcom_nineoldandroids_animation_Animator_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_after_J;
#pragma warning disable 0169
			static Delegate GetAfter_JHandler ()
			{
				if (cb_after_J == null)
					cb_after_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_After_J);
				return cb_after_J;
			}

			static IntPtr n_After_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.After (p0));
			}
#pragma warning restore 0169

			static IntPtr id_after_J;
			[Register ("after", "(J)Lcom/nineoldandroids/animation/AnimatorSet$Builder;", "GetAfter_JHandler")]
			public virtual global::Com.Nineoldandroids.Animation.AnimatorSet.Builder After (long p0)
			{
				if (id_after_J == IntPtr.Zero)
					id_after_J = JNIEnv.GetMethodID (class_ref, "after", "(J)Lcom/nineoldandroids/animation/AnimatorSet$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_after_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_after_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_before_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
			static Delegate GetBefore_Lcom_nineoldandroids_animation_Animator_Handler ()
			{
				if (cb_before_Lcom_nineoldandroids_animation_Animator_ == null)
					cb_before_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Before_Lcom_nineoldandroids_animation_Animator_);
				return cb_before_Lcom_nineoldandroids_animation_Animator_;
			}

			static IntPtr n_Before_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Before (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_before_Lcom_nineoldandroids_animation_Animator_;
			[Register ("before", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;", "GetBefore_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual global::Com.Nineoldandroids.Animation.AnimatorSet.Builder Before (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_before_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_before_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "before", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;");

				global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_before_Lcom_nineoldandroids_animation_Animator_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_before_Lcom_nineoldandroids_animation_Animator_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_with_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
			static Delegate GetWith_Lcom_nineoldandroids_animation_Animator_Handler ()
			{
				if (cb_with_Lcom_nineoldandroids_animation_Animator_ == null)
					cb_with_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_With_Lcom_nineoldandroids_animation_Animator_);
				return cb_with_Lcom_nineoldandroids_animation_Animator_;
			}

			static IntPtr n_With_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.With (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_with_Lcom_nineoldandroids_animation_Animator_;
			[Register ("with", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;", "GetWith_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual global::Com.Nineoldandroids.Animation.AnimatorSet.Builder With (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_with_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_with_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "with", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;");

				global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_with_Lcom_nineoldandroids_animation_Animator_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_with_Lcom_nineoldandroids_animation_Animator_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorSet$Dependency", DoNotGenerateAcw=true)]
		public partial class Dependency : global::Java.Lang.Object {


			static IntPtr node_jfieldId;

			[Register ("node")]
			public global::Com.Nineoldandroids.Animation.AnimatorSet.Node Node {
				get {
					if (node_jfieldId == IntPtr.Zero)
						node_jfieldId = JNIEnv.GetFieldID (class_ref, "node", "Lcom/nineoldandroids/animation/AnimatorSet$Node;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, node_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Node> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (node_jfieldId == IntPtr.Zero)
						node_jfieldId = JNIEnv.GetFieldID (class_ref, "node", "Lcom/nineoldandroids/animation/AnimatorSet$Node;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, node_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr rule_jfieldId;

			[Register ("rule")]
			public int Rule {
				get {
					if (rule_jfieldId == IntPtr.Zero)
						rule_jfieldId = JNIEnv.GetFieldID (class_ref, "rule", "I");
					return JNIEnv.GetIntField (Handle, rule_jfieldId);
				}
				set {
					if (rule_jfieldId == IntPtr.Zero)
						rule_jfieldId = JNIEnv.GetFieldID (class_ref, "rule", "I");
					JNIEnv.SetField (Handle, rule_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorSet$Dependency", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Dependency); }
			}

			protected Dependency (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Node_I;
			[Register (".ctor", "(Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V", "")]
			public Dependency (global::Com.Nineoldandroids.Animation.AnimatorSet.Node p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Dependency)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Node_I == IntPtr.Zero)
					id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Node_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Node_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			}

		}

		[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorSet$DependencyListener", DoNotGenerateAcw=true)]
		public partial class DependencyListener : global::Java.Lang.Object, global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorSet$DependencyListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DependencyListener); }
			}

			protected DependencyListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Lcom_nineoldandroids_animation_AnimatorSet_Node_I;
			[Register (".ctor", "(Lcom/nineoldandroids/animation/AnimatorSet;Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V", "")]
			public DependencyListener (global::Com.Nineoldandroids.Animation.AnimatorSet p0, global::Com.Nineoldandroids.Animation.AnimatorSet.Node p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (DependencyListener)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/nineoldandroids/animation/AnimatorSet;Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Lcom_nineoldandroids_animation_AnimatorSet_Node_I == IntPtr.Zero)
					id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Lcom_nineoldandroids_animation_AnimatorSet_Node_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nineoldandroids/animation/AnimatorSet;Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Lcom_nineoldandroids_animation_AnimatorSet_Node_I, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationCancel (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_;
			[Register ("onAnimationCancel", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationCancel_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual void OnAnimationCancel (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationCancel", "(Lcom/nineoldandroids/animation/Animator;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationEnd (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_;
			[Register ("onAnimationEnd", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationEnd_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual void OnAnimationEnd (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationEnd", "(Lcom/nineoldandroids/animation/Animator;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationRepeat (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_;
			[Register ("onAnimationRepeat", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationRepeat_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual void OnAnimationRepeat (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationRepeat", "(Lcom/nineoldandroids/animation/Animator;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationStart (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_;
			[Register ("onAnimationStart", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationStart_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual void OnAnimationStart (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationStart", "(Lcom/nineoldandroids/animation/Animator;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_, new JValue (p0));
			}

		}

		[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorSet$Node", DoNotGenerateAcw=true)]
		public partial class Node : global::Java.Lang.Object, global::Java.Lang.ICloneable {


			static IntPtr animation_jfieldId;

			[Register ("animation")]
			public global::Com.Nineoldandroids.Animation.Animator Animation {
				get {
					if (animation_jfieldId == IntPtr.Zero)
						animation_jfieldId = JNIEnv.GetFieldID (class_ref, "animation", "Lcom/nineoldandroids/animation/Animator;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, animation_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (animation_jfieldId == IntPtr.Zero)
						animation_jfieldId = JNIEnv.GetFieldID (class_ref, "animation", "Lcom/nineoldandroids/animation/Animator;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, animation_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr dependencies_jfieldId;

			[Register ("dependencies")]
			public global::System.Collections.IList Dependencies {
				get {
					if (dependencies_jfieldId == IntPtr.Zero)
						dependencies_jfieldId = JNIEnv.GetFieldID (class_ref, "dependencies", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, dependencies_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (dependencies_jfieldId == IntPtr.Zero)
						dependencies_jfieldId = JNIEnv.GetFieldID (class_ref, "dependencies", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, dependencies_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr done_jfieldId;

			[Register ("done")]
			public bool Done {
				get {
					if (done_jfieldId == IntPtr.Zero)
						done_jfieldId = JNIEnv.GetFieldID (class_ref, "done", "Z");
					return JNIEnv.GetBooleanField (Handle, done_jfieldId);
				}
				set {
					if (done_jfieldId == IntPtr.Zero)
						done_jfieldId = JNIEnv.GetFieldID (class_ref, "done", "Z");
					JNIEnv.SetField (Handle, done_jfieldId, value);
				}
			}

			static IntPtr nodeDependencies_jfieldId;

			[Register ("nodeDependencies")]
			public global::System.Collections.IList NodeDependencies {
				get {
					if (nodeDependencies_jfieldId == IntPtr.Zero)
						nodeDependencies_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeDependencies", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, nodeDependencies_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (nodeDependencies_jfieldId == IntPtr.Zero)
						nodeDependencies_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeDependencies", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, nodeDependencies_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr nodeDependents_jfieldId;

			[Register ("nodeDependents")]
			public global::System.Collections.IList NodeDependents {
				get {
					if (nodeDependents_jfieldId == IntPtr.Zero)
						nodeDependents_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeDependents", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, nodeDependents_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (nodeDependents_jfieldId == IntPtr.Zero)
						nodeDependents_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeDependents", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, nodeDependents_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr tmpDependencies_jfieldId;

			[Register ("tmpDependencies")]
			public global::System.Collections.IList TmpDependencies {
				get {
					if (tmpDependencies_jfieldId == IntPtr.Zero)
						tmpDependencies_jfieldId = JNIEnv.GetFieldID (class_ref, "tmpDependencies", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, tmpDependencies_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (tmpDependencies_jfieldId == IntPtr.Zero)
						tmpDependencies_jfieldId = JNIEnv.GetFieldID (class_ref, "tmpDependencies", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, tmpDependencies_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorSet$Node", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Node); }
			}

			protected Node (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_nineoldandroids_animation_Animator_;
			[Register (".ctor", "(Lcom/nineoldandroids/animation/Animator;)V", "")]
			public Node (global::Com.Nineoldandroids.Animation.Animator p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Node)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/nineoldandroids/animation/Animator;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_ctor_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nineoldandroids/animation/Animator;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_nineoldandroids_animation_Animator_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.Node __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Node> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Clone ());
			}
#pragma warning restore 0169

			static IntPtr id_clone;
			[Register ("clone", "()Ljava/lang/Object;", "GetCloneHandler")]
			public virtual global::Java.Lang.Object Clone ()
			{
				if (id_clone == IntPtr.Zero)
					id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_clone), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatorSet); }
		}

		internal AnimatorSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public AnimatorSet () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AnimatorSet)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getChildAnimations;
		public global::System.Collections.Generic.IList<global::Com.Nineoldandroids.Animation.Animator> ChildAnimations {
			[Register ("getChildAnimations", "()Ljava/util/ArrayList;", "GetGetChildAnimationsHandler")]
			get {
				if (id_getChildAnimations == IntPtr.Zero)
					id_getChildAnimations = JNIEnv.GetMethodID (class_ref, "getChildAnimations", "()Ljava/util/ArrayList;");
				return global::Android.Runtime.JavaList<global::Com.Nineoldandroids.Animation.Animator>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getChildAnimations), JniHandleOwnership.TransferLocalRef);
			}
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

		static IntPtr id_play_Lcom_nineoldandroids_animation_Animator_;
		[Register ("play", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;", "")]
		public global::Com.Nineoldandroids.Animation.AnimatorSet.Builder Play (global::Com.Nineoldandroids.Animation.Animator p0)
		{
			if (id_play_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
				id_play_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "play", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;");
			global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_play_Lcom_nineoldandroids_animation_Animator_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_playSequentially_arrayLcom_nineoldandroids_animation_Animator_;
		[Register ("playSequentially", "([Lcom/nineoldandroids/animation/Animator;)V", "")]
		public void PlaySequentially (params global:: Com.Nineoldandroids.Animation.Animator[] p0)
		{
			if (id_playSequentially_arrayLcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
				id_playSequentially_arrayLcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "playSequentially", "([Lcom/nineoldandroids/animation/Animator;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_playSequentially_arrayLcom_nineoldandroids_animation_Animator_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_playSequentially_Ljava_util_List_;
		[Register ("playSequentially", "(Ljava/util/List;)V", "")]
		public void PlaySequentially (global::System.Collections.Generic.IList<global::Com.Nineoldandroids.Animation.Animator> p0)
		{
			if (id_playSequentially_Ljava_util_List_ == IntPtr.Zero)
				id_playSequentially_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "playSequentially", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Nineoldandroids.Animation.Animator>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_playSequentially_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_playTogether_arrayLcom_nineoldandroids_animation_Animator_;
		[Register ("playTogether", "([Lcom/nineoldandroids/animation/Animator;)V", "")]
		public void PlayTogether (params global:: Com.Nineoldandroids.Animation.Animator[] p0)
		{
			if (id_playTogether_arrayLcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
				id_playTogether_arrayLcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "playTogether", "([Lcom/nineoldandroids/animation/Animator;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_playTogether_arrayLcom_nineoldandroids_animation_Animator_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_playTogether_Ljava_util_Collection_;
		[Register ("playTogether", "(Ljava/util/Collection;)V", "")]
		public void PlayTogether (global::System.Collections.Generic.ICollection<global::Com.Nineoldandroids.Animation.Animator> p0)
		{
			if (id_playTogether_Ljava_util_Collection_ == IntPtr.Zero)
				id_playTogether_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "playTogether", "(Ljava/util/Collection;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Com.Nineoldandroids.Animation.Animator>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_playTogether_Ljava_util_Collection_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_setDuration_J;
		[Register ("setDuration", "(J)Lcom/nineoldandroids/animation/AnimatorSet;", "")]
		public override global::Com.Nineoldandroids.Animation.Animator SetDuration (long p0)
		{
			if (id_setDuration_J == IntPtr.Zero)
				id_setDuration_J = JNIEnv.GetMethodID (class_ref, "setDuration", "(J)Lcom/nineoldandroids/animation/AnimatorSet;");
			return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet> (JNIEnv.CallObjectMethod  (Handle, id_setDuration_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setInterpolator_Landroid_view_animation_Interpolator_;
		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)V", "")]
		public override void SetInterpolator (global::Android.Views.Animations.IInterpolator p0)
		{
			if (id_setInterpolator_Landroid_view_animation_Interpolator_ == IntPtr.Zero)
				id_setInterpolator_Landroid_view_animation_Interpolator_ = JNIEnv.GetMethodID (class_ref, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setInterpolator_Landroid_view_animation_Interpolator_, new JValue (p0));
		}

	}
}
