using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	[Token(Token = "0x2000006")]
	[AddComponentMenu("DOTween/DOTween Path")]
	public class DOTweenPath : ABSAnimationComponent
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		private static Action<DOTweenPath> m_OnReset;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x70")]
		public float delay;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x74")]
		public float duration;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x78")]
		public Ease easeType;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x80")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x88")]
		public int loops;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x90")]
		public string id;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x98")]
		public LoopType loopType;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x9C")]
		public OrientType orientType;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0xA0")]
		public Transform lookAtTransform;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0xA8")]
		public Vector3 lookAtPosition;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0xB4")]
		public float lookAhead;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0xB8")]
		public bool autoPlay;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0xB9")]
		public bool autoKill;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0xBA")]
		public bool relative;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0xBB")]
		public bool isLocal;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0xBC")]
		public bool isClosedPath;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0xC0")]
		public int pathResolution;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0xC4")]
		public PathMode pathMode;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0xC8")]
		public AxisConstraint lockRotation;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0xCC")]
		public bool assignForwardAndUp;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0xD0")]
		public Vector3 forwardDirection;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0xDC")]
		public Vector3 upDirection;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0xE8")]
		public bool tweenRigidbody;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0xF0")]
		public List<Vector3> wps;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0xF8")]
		public List<Vector3> fullWps;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x100")]
		public Path path;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x108")]
		public DOTweenInspectorMode inspectorMode;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x10C")]
		public PathType pathType;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x110")]
		public HandlesType handlesType;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x114")]
		public bool livePreview;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x118")]
		public HandlesDrawMode handlesDrawMode;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x11C")]
		public float perspectiveHandleSize;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x120")]
		public bool showIndexes;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x121")]
		public bool showWpLength;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x124")]
		public Color pathColor;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x134")]
		public Vector3 lastSrcPosition;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x140")]
		public Quaternion lastSrcRotation;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x150")]
		public bool wpsDropdown;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x154")]
		public float dropToFloorOffset;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x8")]
		private static MethodInfo _miCreateTween;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenPath> OnReset
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x46AC55C", Offset = "0x46A855C", VA = "0x46AC55C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x46AC628", Offset = "0x46A8628", VA = "0x46AC628")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x46AC6F4", Offset = "0x46A86F4", VA = "0x46AC6F4")]
		private static void Dispatch_OnReset(DOTweenPath path)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x46AC760", Offset = "0x46A8760", VA = "0x46AC760")]
		private void Awake()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x46AD5CC", Offset = "0x46A95CC", VA = "0x46AD5CC")]
		private void Reset()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x46AD6C4", Offset = "0x46A96C4", VA = "0x46AD6C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x46AD6F4", Offset = "0x46A96F4", VA = "0x46AD6F4", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x46AD73C", Offset = "0x46A973C", VA = "0x46AD73C")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x46AD7B8", Offset = "0x46A97B8", VA = "0x46AD7B8")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x46AD810", Offset = "0x46A9810", VA = "0x46AD810", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x46AD81C", Offset = "0x46A981C", VA = "0x46AD81C", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x46AD828", Offset = "0x46A9828", VA = "0x46AD828", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x46AD870", Offset = "0x46A9870", VA = "0x46AD870", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x46AD87C", Offset = "0x46A987C", VA = "0x46AD87C", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x46AD88C", Offset = "0x46A988C", VA = "0x46AD88C", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x46AD89C", Offset = "0x46A989C", VA = "0x46AD89C", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x46AD944", Offset = "0x46A9944", VA = "0x46AD944", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x46AD950", Offset = "0x46A9950", VA = "0x46AD950", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x46AD960", Offset = "0x46A9960", VA = "0x46AD960")]
		public void DOKillAllById(string id)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x46AD9BC", Offset = "0x46A99BC", VA = "0x46AD9BC")]
		public Tween GetTween()
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x46ADA40", Offset = "0x46A9A40", VA = "0x46ADA40")]
		public Vector3[] GetDrawPoints()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x46ADAC0", Offset = "0x46A9AC0", VA = "0x46ADAC0")]
		internal Vector3[] GetFullWps()
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x46AD468", Offset = "0x46A9468", VA = "0x46AD468")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x46ADC18", Offset = "0x46A9C18", VA = "0x46ADC18")]
		public DOTweenPath()
		{
		}
	}
}
