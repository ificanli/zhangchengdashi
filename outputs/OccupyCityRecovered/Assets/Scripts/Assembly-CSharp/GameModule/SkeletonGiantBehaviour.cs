using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000385")]
	public class SkeletonGiantBehaviour : UndeadBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000386")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40025DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40025DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40025DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SkeletonGiantBehaviour _003C_003E4__this;

			[Token(Token = "0x40025E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalRoleInfo info;

			[Token(Token = "0x40025E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x40025E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int cardLevel;

			[Token(Token = "0x40025E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RareLevel rareLevel;

			[Token(Token = "0x40025E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string relativeCardID;

			[Token(Token = "0x40025E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x40025E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x40025E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FF3")]
			[Address(RVA = "0x3D99CB8", Offset = "0x3D95CB8", VA = "0x3D99CB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FF4")]
			[Address(RVA = "0x3D99FD8", Offset = "0x3D95FD8", VA = "0x3D99FD8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000387")]
		[CompilerGenerated]
		private struct _003CSkeletonGiantSkill_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40025E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40025E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40025EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SkeletonGiantBehaviour _003C_003E4__this;

			[Token(Token = "0x40025EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<float>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x40025EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FF5")]
			[Address(RVA = "0x3D99FE4", Offset = "0x3D95FE4", VA = "0x3D99FE4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FF6")]
			[Address(RVA = "0x3D9A9F4", Offset = "0x3D969F4", VA = "0x3D9A9F4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40025DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject bulletProRes;

		[Token(Token = "0x40025DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private EntityBase skillTarget;

		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x3D99A9C", Offset = "0x3D95A9C", VA = "0x3D99A9C", Slot = "20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x3D99B80", Offset = "0x3D95B80", VA = "0x3D99B80", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x3D99B9C", Offset = "0x3D95B9C", VA = "0x3D99B9C")]
		[AsyncStateMachine(typeof(_003CSkeletonGiantSkill_003Ed__4))]
		private void SkeletonGiantSkill()
		{
		}

		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x3D99C30", Offset = "0x3D95C30", VA = "0x3D99C30")]
		public SkeletonGiantBehaviour()
		{
		}
	}
}
