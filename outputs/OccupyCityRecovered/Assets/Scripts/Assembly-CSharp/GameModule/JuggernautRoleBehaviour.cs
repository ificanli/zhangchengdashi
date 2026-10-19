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
	[Token(Token = "0x200033E")]
	public class JuggernautRoleBehaviour : OrcsBehaviour
	{
		[Token(Token = "0x200033F")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x400240F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JuggernautRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<Vector3> allPos;

			[Token(Token = "0x6000E94")]
			[Address(RVA = "0x3D73F98", Offset = "0x3D6FF98", VA = "0x3D73F98")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000341")]
		[CompilerGenerated]
		private struct _003CAtkCallBack_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4002413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JuggernautRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

			[Token(Token = "0x4002417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int attackNum;

			[Token(Token = "0x4002418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E97")]
			[Address(RVA = "0x3D74300", Offset = "0x3D70300", VA = "0x3D74300", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E98")]
			[Address(RVA = "0x3D749FC", Offset = "0x3D709FC", VA = "0x3D749FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000342")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4002419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400241A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400241B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JuggernautRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400241C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalRoleInfo info;

			[Token(Token = "0x400241D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x400241E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int cardLevel;

			[Token(Token = "0x400241F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RareLevel rareLevel;

			[Token(Token = "0x4002420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string relativeCardID;

			[Token(Token = "0x4002421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x4002422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x4002423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E99")]
			[Address(RVA = "0x3D74A08", Offset = "0x3D70A08", VA = "0x3D74A08", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E9A")]
			[Address(RVA = "0x3D74D04", Offset = "0x3D70D04", VA = "0x3D74D04", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000343")]
		[CompilerGenerated]
		private struct _003CJuggernautSkill_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4002424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JuggernautRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E9B")]
			[Address(RVA = "0x3D74D10", Offset = "0x3D70D10", VA = "0x3D74D10", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E9C")]
			[Address(RVA = "0x3D750BC", Offset = "0x3D710BC", VA = "0x3D750BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400240D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private GameObject res;

		[Token(Token = "0x400240E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private GlobalRoleInfo info;

		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x3D73C9C", Offset = "0x3D6FC9C", VA = "0x3D73C9C", Slot = "20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x3D73D80", Offset = "0x3D6FD80", VA = "0x3D73D80", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x3D73D9C", Offset = "0x3D6FD9C", VA = "0x3D73D9C")]
		[AsyncStateMachine(typeof(_003CJuggernautSkill_003Ed__4))]
		private void JuggernautSkill()
		{
		}

		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x3D73E28", Offset = "0x3D6FE28", VA = "0x3D73E28", Slot = "30")]
		[AsyncStateMachine(typeof(_003CAtkCallBack_003Ed__5))]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x3D73ECC", Offset = "0x3D6FECC", VA = "0x3D73ECC", Slot = "39")]
		protected override void OnRecycle()
		{
		}

		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x3D73F84", Offset = "0x3D6FF84", VA = "0x3D73F84")]
		public JuggernautRoleBehaviour()
		{
		}
	}
}
