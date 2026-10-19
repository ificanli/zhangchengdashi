using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000344")]
	public class MachineBehaviour : RoleBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000345")]
		[CompilerGenerated]
		private struct _003CAtkCallBack_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x400242A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400242B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400242C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MachineBehaviour _003C_003E4__this;

			[Token(Token = "0x400242D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int attackNum;

			[Token(Token = "0x400242E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000EA2")]
			[Address(RVA = "0x3D751D8", Offset = "0x3D711D8", VA = "0x3D751D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000EA3")]
			[Address(RVA = "0x3D7562C", Offset = "0x3D7162C", VA = "0x3D7562C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private bool canAddDamage;

		[Token(Token = "0x4002429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject dan;

		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0x3D68C94", Offset = "0x3D64C94", VA = "0x3D68C94", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x3D71D20", Offset = "0x3D6DD20", VA = "0x3D71D20", Slot = "30")]
		[AsyncStateMachine(typeof(_003CAtkCallBack_003Ed__3))]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0x3D750C8", Offset = "0x3D710C8", VA = "0x3D750C8")]
		private void MachineCardFettersInit()
		{
		}

		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0x3D68D14", Offset = "0x3D64D14", VA = "0x3D68D14")]
		public MachineBehaviour()
		{
		}
	}
}
