using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002D8")]
	public class NecroBookProp : PropBase
	{
		[Token(Token = "0x20002D9")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x4002261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NecroBookProp _003C_003E4__this;

			[Token(Token = "0x4002262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isEnemy;

			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0x3D4A8C8", Offset = "0x3D468C8", VA = "0x3D4A8C8")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}
		}

		[Token(Token = "0x20002DA")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass2_1
		{
			[Token(Token = "0x4002263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject rolePrefabRes;

			[Token(Token = "0x4002264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<Vector3> allPos;

			[Token(Token = "0x4002265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string roleId;

			[Token(Token = "0x4002266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int cardLevel;

			[Token(Token = "0x4002267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public RareLevel rare;

			[Token(Token = "0x4002268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public _003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x3D4A8D0", Offset = "0x3D468D0", VA = "0x3D4A8D0")]
			public _003C_003Ec__DisplayClass2_1()
			{
			}
		}

		[Token(Token = "0x20002DC")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass2_3
		{
			[Token(Token = "0x400226B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject rolePrefabRes;

			[Token(Token = "0x400226C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<Vector3> allPos;

			[Token(Token = "0x400226D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int CardLevel;

			[Token(Token = "0x400226E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public _003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals3;

			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0x3D4AD10", Offset = "0x3D46D10", VA = "0x3D4AD10")]
			public _003C_003Ec__DisplayClass2_3()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002DE")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4002271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public NecroBookProp _003C_003E4__this;

			[Token(Token = "0x4002274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x4002275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass2_1 _003C_003E8__1;

			[Token(Token = "0x4002276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private _003C_003Ec__DisplayClass2_3 _003C_003E8__2;

			[Token(Token = "0x4002277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 _003CbornPos_003E5__2;

			[Token(Token = "0x4002278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private GameObject _003CeffectRes_003E5__3;

			[Token(Token = "0x4002279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400227A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000CE0")]
			[Address(RVA = "0x3D4B164", Offset = "0x3D47164", VA = "0x3D4B164", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000CE1")]
			[Address(RVA = "0x3D4D28C", Offset = "0x3D4928C", VA = "0x3D4D28C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<RoleBehaviour> _bGroupSpawnedRoles;

		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x3D4A50C", Offset = "0x3D4650C", VA = "0x3D4A50C")]
		public NecroBookProp(string id)
		{
		}

		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x3D4A590", Offset = "0x3D46590", VA = "0x3D4A590", Slot = "4")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__2))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x3D4A634", Offset = "0x3D46634", VA = "0x3D4A634", Slot = "6")]
		protected override void GameEnd(object o)
		{
		}
	}
}
