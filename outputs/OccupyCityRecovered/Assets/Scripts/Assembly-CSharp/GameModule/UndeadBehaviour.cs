using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000391")]
	public class UndeadBehaviour : RoleBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000392")]
		[CompilerGenerated]
		private struct _003CDeadCallBack_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4002604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UndeadBehaviour _003C_003E4__this;

			[Token(Token = "0x4002607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public DeadType deadType;

			[Token(Token = "0x4002608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600101E")]
			[Address(RVA = "0x3D9CBB4", Offset = "0x3D98BB4", VA = "0x3D9CBB4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600101F")]
			[Address(RVA = "0x3D9D07C", Offset = "0x3D9907C", VA = "0x3D9D07C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		protected bool CanRevival;

		[Token(Token = "0x6001016")]
		[Address(RVA = "0x3D99C40", Offset = "0x3D95C40", VA = "0x3D99C40", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6001017")]
		[Address(RVA = "0x3D98998", Offset = "0x3D94998", VA = "0x3D98998", Slot = "30")]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6001018")]
		[Address(RVA = "0x3D9C7EC", Offset = "0x3D987EC", VA = "0x3D9C7EC", Slot = "24")]
		protected override void Dead(DeadType deadType = DeadType.Common)
		{
		}

		[Token(Token = "0x6001019")]
		[Address(RVA = "0x3D9C99C", Offset = "0x3D9899C", VA = "0x3D9C99C", Slot = "27")]
		[AsyncStateMachine(typeof(_003CDeadCallBack_003Ed__4))]
		protected override void DeadCallBack(DeadType deadType = DeadType.Common)
		{
		}

		[Token(Token = "0x600101A")]
		[Address(RVA = "0x3D9CA3C", Offset = "0x3D98A3C", VA = "0x3D9CA3C")]
		private void RevivalCallBack()
		{
		}

		[Token(Token = "0x600101B")]
		[Address(RVA = "0x3D9C6F0", Offset = "0x3D986F0", VA = "0x3D9C6F0")]
		private void UndeadCardFettersInit()
		{
		}

		[Token(Token = "0x600101C")]
		[Address(RVA = "0x3D9898C", Offset = "0x3D9498C", VA = "0x3D9898C")]
		public UndeadBehaviour()
		{
		}
	}
}
