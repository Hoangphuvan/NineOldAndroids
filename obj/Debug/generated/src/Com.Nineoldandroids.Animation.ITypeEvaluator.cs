using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	[Register ("com/nineoldandroids/animation/TypeEvaluator", "", "Com.Nineoldandroids.Animation.ITypeEvaluatorInvoker")]
	public partial interface ITypeEvaluator : IJavaObject {

		[Register ("evaluate", "(FLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetEvaluate_FLjava_lang_Object_Ljava_lang_Object_Handler:Com.Nineoldandroids.Animation.ITypeEvaluatorInvoker, NineOldAndroids")]
		global::Java.Lang.Object Evaluate (float p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2);

	}

	[global::Android.Runtime.Register ("com/nineoldandroids/animation/TypeEvaluator", DoNotGenerateAcw=true)]
	internal class ITypeEvaluatorInvoker : global::Java.Lang.Object, ITypeEvaluator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nineoldandroids/animation/TypeEvaluator");
		IntPtr class_ref;

		public static ITypeEvaluator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITypeEvaluator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nineoldandroids.animation.TypeEvaluator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITypeEvaluatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ITypeEvaluatorInvoker); }
		}

		static Delegate cb_evaluate_FLjava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEvaluate_FLjava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_evaluate_FLjava_lang_Object_Ljava_lang_Object_ == null)
				cb_evaluate_FLjava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr, IntPtr, IntPtr>) n_Evaluate_FLjava_lang_Object_Ljava_lang_Object_);
			return cb_evaluate_FLjava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_Evaluate_FLjava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, float p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nineoldandroids.Animation.ITypeEvaluator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ITypeEvaluator> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Evaluate (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_evaluate_FLjava_lang_Object_Ljava_lang_Object_;
		public global::Java.Lang.Object Evaluate (float p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_evaluate_FLjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_evaluate_FLjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "evaluate", "(FLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_evaluate_FLjava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}

}
