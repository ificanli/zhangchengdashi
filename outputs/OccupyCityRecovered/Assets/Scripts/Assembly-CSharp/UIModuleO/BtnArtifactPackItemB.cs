using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;

namespace UIModuleO
{
	[Token(Token = "0x200073D")]
	public class BtnArtifactPackItemB : BtnArtifactPackItemBComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000740")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x400390E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400390F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GlobalShopInfo info;

			[Token(Token = "0x4003911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BtnArtifactPackItemB _003C_003E4__this;

			[Token(Token = "0x6002796")]
			[Address(RVA = "0x3FA6D84", Offset = "0x3FA2D84", VA = "0x3FA6D84", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002797")]
			[Address(RVA = "0x3FA7604", Offset = "0x3FA3604", VA = "0x3FA7604", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000741")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4003912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnArtifactPackItemB _003C_003E4__this;

			[Token(Token = "0x4003915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002798")]
			[Address(RVA = "0x3FA7610", Offset = "0x3FA3610", VA = "0x3FA7610", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002799")]
			[Address(RVA = "0x3FA77F0", Offset = "0x3FA37F0", VA = "0x3FA77F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000742")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4003916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnArtifactPackItemB _003C_003E4__this;

			[Token(Token = "0x4003919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string[] _003CrewardConfig_003E5__2;

			[Token(Token = "0x400391A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<RewardItemUI> _003CrewardItemUIs_003E5__3;

			[Token(Token = "0x400391B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003Cindex_003E5__4;

			[Token(Token = "0x400391C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int _003Ci_003E5__5;

			[Token(Token = "0x400391D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600279A")]
			[Address(RVA = "0x3FA77FC", Offset = "0x3FA37FC", VA = "0x3FA77FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600279B")]
			[Address(RVA = "0x3FA8548", Offset = "0x3FA4548", VA = "0x3FA8548", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GlobalShopInfo _info;

		[Token(Token = "0x4003908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string IAPID;

		[Token(Token = "0x4003909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool InitStartEvevt;

		[Token(Token = "0x400390A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TimeManager.Timer toMondayTimer;

		[Token(Token = "0x6002783")]
		[Address(RVA = "0x3FA5824", Offset = "0x3FA1824", VA = "0x3FA5824")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__4))]
		public void Init(GlobalShopInfo info)
		{
		}

		[Token(Token = "0x6002784")]
		[Address(RVA = "0x3FA58C0", Offset = "0x3FA18C0", VA = "0x3FA58C0")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__5))]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x6002785")]
		[Address(RVA = "0x3FA5950", Offset = "0x3FA1950", VA = "0x3FA5950")]
		private void Update()
		{
		}

		[Token(Token = "0x6002786")]
		[Address(RVA = "0x3FA5AF4", Offset = "0x3FA1AF4", VA = "0x3FA5AF4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__7))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002787")]
		[Address(RVA = "0x3FA5B88", Offset = "0x3FA1B88", VA = "0x3FA5B88")]
		private void RefreshArtifactItem(object o)
		{
		}

		[Token(Token = "0x6002788")]
		[Address(RVA = "0x3FA5BA0", Offset = "0x3FA1BA0", VA = "0x3FA5BA0")]
		private void RefreshBuyCount()
		{
		}

		[Token(Token = "0x6002789")]
		[Address(RVA = "0x3FA600C", Offset = "0x3FA200C", VA = "0x3FA600C")]
		private void TimeToMonDayZero(object o)
		{
		}

		[Token(Token = "0x600278A")]
		[Address(RVA = "0x3FA5CEC", Offset = "0x3FA1CEC", VA = "0x3FA5CEC")]
		private void UpdateBuyPackCountUI()
		{
		}

		[Token(Token = "0x600278B")]
		[Address(RVA = "0x3FA6268", Offset = "0x3FA2268", VA = "0x3FA6268")]
		private string[] ParseRewardStringToArray(string rewards)
		{
			return null;
		}

		[Token(Token = "0x600278C")]
		[Address(RVA = "0x3FA647C", Offset = "0x3FA247C", VA = "0x3FA647C")]
		private string[] BuildArtifactPackRewardArray(Dictionary<string, int> packConfig, string rewards)
		{
			return null;
		}

		[Token(Token = "0x600278D")]
		[Address(RVA = "0x3FA68D8", Offset = "0x3FA28D8", VA = "0x3FA68D8", Slot = "12")]
		protected override void OnButtonExtendBtnArtifactPackItemBClicked()
		{
		}

		[Token(Token = "0x600278E")]
		[Address(RVA = "0x3FA6BCC", Offset = "0x3FA2BCC", VA = "0x3FA6BCC")]
		public BtnArtifactPackItemB()
		{
		}
	}
}
