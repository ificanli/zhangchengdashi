using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TimeModuleO;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x20005DE")]
	public class UserLablePushPackManager : ManagerBase<UserLablePushPackManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005E3")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4003188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400318A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UserLablePushPackManager _003C_003E4__this;

			[Token(Token = "0x6001ED8")]
			[Address(RVA = "0x3EFE6EC", Offset = "0x3EFA6EC", VA = "0x3EFE6EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001ED9")]
			[Address(RVA = "0x3EFEB9C", Offset = "0x3EFAB9C", VA = "0x3EFEB9C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400317A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TimeManager.Timer specialOfferPackTimer;

		[Token(Token = "0x400317B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TimeManager.Timer elitePackTimer;

		[Token(Token = "0x400317C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hadInit;

		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x3EFD33C", Offset = "0x3EF933C", VA = "0x3EFD33C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__3))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0x3EFC744", Offset = "0x3EF8744", VA = "0x3EFC744")]
		public void CheckShowSpecialOfferPanel(object o)
		{
		}

		[Token(Token = "0x6001EC0")]
		[Address(RVA = "0x3EFD3C0", Offset = "0x3EF93C0", VA = "0x3EFD3C0")]
		private bool IsPlacementValue(string value)
		{
			return default;
		}

		[Token(Token = "0x6001EC1")]
		[Address(RVA = "0x3EFD578", Offset = "0x3EF9578", VA = "0x3EFD578")]
		private void ShowUserLabelGiftPackPanel(bool isCheat, [Optional] string placement)
		{
		}

		[Token(Token = "0x6001EC2")]
		[Address(RVA = "0x3EFD954", Offset = "0x3EF9954", VA = "0x3EFD954")]
		private void CheatCheckUnLockArenaAbout(object o)
		{
		}

		[Token(Token = "0x6001EC3")]
		[Address(RVA = "0x3EFD960", Offset = "0x3EF9960", VA = "0x3EFD960")]
		private void Update()
		{
		}

		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0x3EFDC40", Offset = "0x3EF9C40", VA = "0x3EFDC40")]
		private void BuySpecialOffer(object o)
		{
		}

		[Token(Token = "0x6001EC5")]
		[Address(RVA = "0x3EFDC44", Offset = "0x3EF9C44", VA = "0x3EFDC44")]
		private void BuyElitePack(object o)
		{
		}

		[Token(Token = "0x6001EC6")]
		[Address(RVA = "0x3EFDA00", Offset = "0x3EF9A00", VA = "0x3EFDA00")]
		private void SpecialOfferDisapperaCallBack()
		{
		}

		[Token(Token = "0x6001EC7")]
		[Address(RVA = "0x3EFDB20", Offset = "0x3EF9B20", VA = "0x3EFDB20")]
		private void ElitePackDisapperaCallBack()
		{
		}

		[Token(Token = "0x6001EC8")]
		[Address(RVA = "0x3EFDC48", Offset = "0x3EF9C48", VA = "0x3EFDC48")]
		public string GetSpecialOfferCutDown()
		{
			return null;
		}

		[Token(Token = "0x6001EC9")]
		[Address(RVA = "0x3EFDC60", Offset = "0x3EF9C60", VA = "0x3EFDC60")]
		public string GetElitePackCutDown()
		{
			return null;
		}

		[Token(Token = "0x6001ECA")]
		[Address(RVA = "0x3EFDC78", Offset = "0x3EF9C78", VA = "0x3EFDC78")]
		public void ShowSpecialOfferPanel([Optional] string placement)
		{
		}

		[Token(Token = "0x6001ECB")]
		[Address(RVA = "0x3EFDE8C", Offset = "0x3EF9E8C", VA = "0x3EFDE8C")]
		public void ShowElitePackPanel([Optional] string placement)
		{
		}

		[Token(Token = "0x6001ECC")]
		[Address(RVA = "0x3EFE0A0", Offset = "0x3EFA0A0", VA = "0x3EFE0A0")]
		public UserLablePushPackManager()
		{
		}
	}
}
