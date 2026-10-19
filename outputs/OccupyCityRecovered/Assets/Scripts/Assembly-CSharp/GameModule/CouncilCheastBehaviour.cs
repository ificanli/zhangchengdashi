using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20003CE")]
	public class CouncilCheastBehaviour : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003CF")]
		[CompilerGenerated]
		private struct _003CTriggerEvent_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40026AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40026AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40026AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CouncilCheastBehaviour _003C_003E4__this;

			[Token(Token = "0x40026B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x40026B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600112E")]
			[Address(RVA = "0x3DAC990", Offset = "0x3DA8990", VA = "0x3DAC990", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600112F")]
			[Address(RVA = "0x3DAD4C4", Offset = "0x3DA94C4", VA = "0x3DAD4C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40026A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int coinNum;

		[Token(Token = "0x40026A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform cheastLid;

		[Token(Token = "0x40026AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator cheast;

		[Token(Token = "0x40026AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator gaizi;

		[Token(Token = "0x40026AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isEnemy;

		[Token(Token = "0x6001129")]
		[Address(RVA = "0x3DAC81C", Offset = "0x3DA881C", VA = "0x3DAC81C")]
		public void InitInfo(CouncilBoxType boxType)
		{
		}

		[Token(Token = "0x600112A")]
		[Address(RVA = "0x3DAC8DC", Offset = "0x3DA88DC", VA = "0x3DAC8DC")]
		public void CheastScaleCallBack()
		{
		}

		[Token(Token = "0x600112B")]
		[Address(RVA = "0x3DAC8E0", Offset = "0x3DA88E0", VA = "0x3DAC8E0")]
		public void CheastGaiRotationCallBack()
		{
		}

		[Token(Token = "0x600112C")]
		[Address(RVA = "0x3DAC8E4", Offset = "0x3DA88E4", VA = "0x3DAC8E4")]
		[AsyncStateMachine(typeof(_003CTriggerEvent_003Ed__8))]
		public void TriggerEvent(bool isEnemy)
		{
		}

		[Token(Token = "0x600112D")]
		[Address(RVA = "0x3DAC988", Offset = "0x3DA8988", VA = "0x3DAC988")]
		public CouncilCheastBehaviour()
		{
		}
	}
}
