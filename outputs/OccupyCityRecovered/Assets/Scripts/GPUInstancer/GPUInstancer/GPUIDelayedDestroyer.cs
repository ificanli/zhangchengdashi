using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000054")]
	public class GPUIDelayedDestroyer : MonoBehaviour
	{
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x0")]
		private static GPUIDelayedDestroyer _instance;

		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x8")]
		private static bool _isQuitting;

		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x20")]
		private readonly Queue<(Object obj, int framesLeft)> _destroyQueue;

		[Token(Token = "0x17000017")]
		private static GPUIDelayedDestroyer Instance
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x73E1DEC", Offset = "0x73DDDEC", VA = "0x73E1DEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x73E1F28", Offset = "0x73DDF28", VA = "0x73E1F28")]
		public static void DestroyDelayed(Object obj, int frameDelay = 2)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x73E2170", Offset = "0x73DE170", VA = "0x73E2170")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x73E2210", Offset = "0x73DE210", VA = "0x73E2210")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x73E2368", Offset = "0x73DE368", VA = "0x73E2368")]
		private static void OnApplicationQuitting()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x73E23B4", Offset = "0x73DE3B4", VA = "0x73E23B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x73E25A0", Offset = "0x73DE5A0", VA = "0x73E25A0")]
		public GPUIDelayedDestroyer()
		{
		}
	}
}
