using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace DG.Tweening.Core
{
	[Token(Token = "0x200000B")]
	[AddComponentMenu("")]
	public abstract class ABSAnimationComponent : MonoBehaviour
	{
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x20")]
		public UpdateType updateType;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x24")]
		public bool isSpeedBased;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x25")]
		public bool hasOnStart;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x26")]
		public bool hasOnPlay;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x27")]
		public bool hasOnUpdate;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x28")]
		public bool hasOnStepComplete;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x29")]
		public bool hasOnComplete;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x2A")]
		public bool hasOnTweenCreated;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x2B")]
		public bool hasOnRewind;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent onStart;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onPlay;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onUpdate;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onStepComplete;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent onComplete;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onTweenCreated;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent onRewind;

		[NonSerialized]
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x68")]
		public Tween tween;

		[Token(Token = "0x600002D")]
		public abstract void DOPlay();

		[Token(Token = "0x600002E")]
		public abstract void DOPlayBackwards();

		[Token(Token = "0x600002F")]
		public abstract void DOPlayForward();

		[Token(Token = "0x6000030")]
		public abstract void DOPause();

		[Token(Token = "0x6000031")]
		public abstract void DOTogglePause();

		[Token(Token = "0x6000032")]
		public abstract void DORewind();

		[Token(Token = "0x6000033")]
		public abstract void DORestart();

		[Token(Token = "0x6000034")]
		public abstract void DORestart(bool fromHere);

		[Token(Token = "0x6000035")]
		public abstract void DOComplete();

		[Token(Token = "0x6000036")]
		public abstract void DOKill();

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x46ADE90", Offset = "0x46A9E90", VA = "0x46ADE90")]
		protected ABSAnimationComponent()
		{
		}
	}
}
