using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20004DA")]
	public class HumanBehaviour : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004DB")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4002C88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002C89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002C8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HumanBehaviour _003C_003E4__this;

			[Token(Token = "0x4002C8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string camp;

			[Token(Token = "0x4002C8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string modelPath;

			[Token(Token = "0x4002C8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001877")]
			[Address(RVA = "0x3E79A94", Offset = "0x3E75A94", VA = "0x3E79A94", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001878")]
			[Address(RVA = "0x3E79F94", Offset = "0x3E75F94", VA = "0x3E79F94", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x4002C83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Animator animator;

		[Token(Token = "0x4002C84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string camp;

		[Token(Token = "0x4002C85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform model;

		[NonSerialized]
		[Token(Token = "0x4002C86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool canAttack;

		[Token(Token = "0x4002C87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float generateHitEffectInterTime;

		[Token(Token = "0x6001875")]
		[Address(RVA = "0x3E799DC", Offset = "0x3E759DC", VA = "0x3E799DC")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__5))]
		public void Init(string camp, string modelPath)
		{
		}

		[Token(Token = "0x6001876")]
		[Address(RVA = "0x3E79A84", Offset = "0x3E75A84", VA = "0x3E79A84")]
		public HumanBehaviour()
		{
		}
	}
}
