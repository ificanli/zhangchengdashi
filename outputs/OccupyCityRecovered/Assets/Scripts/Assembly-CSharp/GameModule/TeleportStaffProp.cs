using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002EB")]
	public class TeleportStaffProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002EE")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40022AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40022B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40022B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isEnemy;

			[Token(Token = "0x40022B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3? releasePos;

			[Token(Token = "0x40022B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public TeleportStaffProp _003C_003E4__this;

			[Token(Token = "0x40022B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<RoleBehaviour> target;

			[Token(Token = "0x40022B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private List<RoleBehaviour> _003CteleportedRoles_003E5__2;

			[Token(Token = "0x40022B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000D16")]
			[Address(RVA = "0x3D51FCC", Offset = "0x3D4DFCC", VA = "0x3D51FCC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000D17")]
			[Address(RVA = "0x3D531C4", Offset = "0x3D4F1C4", VA = "0x3D531C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40022A8")]
		private const float AtkSpeedBuffDuration = 5f;

		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x3D51B84", Offset = "0x3D4DB84", VA = "0x3D51B84")]
		public TeleportStaffProp(string id)
		{
		}

		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x3D51B8C", Offset = "0x3D4DB8C", VA = "0x3D51B8C", Slot = "4")]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x3D51BA4", Offset = "0x3D4DBA4", VA = "0x3D51BA4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__3))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target, Vector3? releasePos)
		{
		}
	}
}
