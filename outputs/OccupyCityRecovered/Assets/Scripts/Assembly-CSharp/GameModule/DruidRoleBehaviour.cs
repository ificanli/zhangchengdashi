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
	[Token(Token = "0x200032D")]
	public class DruidRoleBehaviour : OrcsBehaviour
	{
		[Token(Token = "0x200032E")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x40023C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DruidRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 targetPos;

			[Token(Token = "0x6000E60")]
			[Address(RVA = "0x3D6FCA8", Offset = "0x3D6BCA8", VA = "0x3D6FCA8")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000E61")]
			[Address(RVA = "0x3D6FCB0", Offset = "0x3D6BCB0", VA = "0x3D6FCB0")]
			internal void _003CAtkCallBack_003Eb__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200032F")]
		[CompilerGenerated]
		private struct _003CAtkCallBack_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40023C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40023C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DruidRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

			[Token(Token = "0x40023C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int attackNum;

			[Token(Token = "0x40023CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<Vector3> _003CallPos_003E5__2;

			[Token(Token = "0x40023CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E62")]
			[Address(RVA = "0x3D6FFD0", Offset = "0x3D6BFD0", VA = "0x3D6FFD0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E63")]
			[Address(RVA = "0x3D70664", Offset = "0x3D6C664", VA = "0x3D70664", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000330")]
		[CompilerGenerated]
		private struct _003CDruidSkill_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40023CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40023CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DruidRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E64")]
			[Address(RVA = "0x3D70670", Offset = "0x3D6C670", VA = "0x3D70670", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E65")]
			[Address(RVA = "0x3D70A04", Offset = "0x3D6CA04", VA = "0x3D70A04", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000331")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x40023D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40023D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DruidRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalRoleInfo info;

			[Token(Token = "0x40023D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x40023D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int cardLevel;

			[Token(Token = "0x40023D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RareLevel rareLevel;

			[Token(Token = "0x40023D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string relativeCardID;

			[Token(Token = "0x40023D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x40023D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x40023DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E66")]
			[Address(RVA = "0x3D70A10", Offset = "0x3D6CA10", VA = "0x3D70A10", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E67")]
			[Address(RVA = "0x3D70D8C", Offset = "0x3D6CD8C", VA = "0x3D70D8C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40023C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private GameObject rolePrefabRes;

		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x3D6FA68", Offset = "0x3D6BA68", VA = "0x3D6FA68", Slot = "20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x3D6FB4C", Offset = "0x3D6BB4C", VA = "0x3D6FB4C", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x3D6FB68", Offset = "0x3D6BB68", VA = "0x3D6FB68")]
		[AsyncStateMachine(typeof(_003CDruidSkill_003Ed__3))]
		private void DruidSkill()
		{
		}

		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x3D6FBF4", Offset = "0x3D6BBF4", VA = "0x3D6FBF4", Slot = "30")]
		[AsyncStateMachine(typeof(_003CAtkCallBack_003Ed__4))]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x3D6FC94", Offset = "0x3D6BC94", VA = "0x3D6FC94")]
		public DruidRoleBehaviour()
		{
		}
	}
}
