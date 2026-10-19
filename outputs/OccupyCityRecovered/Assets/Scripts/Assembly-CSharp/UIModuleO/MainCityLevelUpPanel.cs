using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200093F")]
	public class MainCityLevelUpPanel : MainCityLevelUpPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000941")]
		[CompilerGenerated]
		private struct _003CLoadUIRes_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x400454D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400454E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400454F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityLevelUpPanel _003C_003E4__this;

			[Token(Token = "0x4004550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4004551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60035CA")]
			[Address(RVA = "0x40BDF34", Offset = "0x40B9F34", VA = "0x40BDF34", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60035CB")]
			[Address(RVA = "0x40BE37C", Offset = "0x40BA37C", VA = "0x40BE37C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000942")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4004552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityLevelUpPanel _003C_003E4__this;

			[Token(Token = "0x4004555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4004556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60035CC")]
			[Address(RVA = "0x40BE388", Offset = "0x40BA388", VA = "0x40BE388", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60035CD")]
			[Address(RVA = "0x40BECD4", Offset = "0x40BACD4", VA = "0x40BECD4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000943")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4004557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainCityLevelUpPanel _003C_003E4__this;

			[Token(Token = "0x400455A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private RewardConfig _003CidleRewardConfig_003E5__2;

			[Token(Token = "0x400455B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap2;

			[Token(Token = "0x400455C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60035CE")]
			[Address(RVA = "0x40BECE0", Offset = "0x40BACE0", VA = "0x40BECE0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60035CF")]
			[Address(RVA = "0x40BFB94", Offset = "0x40BBB94", VA = "0x40BFB94", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004540")]
		private const int INITIAL_ADD_NUM_VALUE = 0;

		[Token(Token = "0x4004541")]
		private const int FIRST_REWARD_INDEX = 0;

		[Token(Token = "0x4004542")]
		private const int SECOND_REWARD_INDEX = 1;

		[Token(Token = "0x4004543")]
		private const int INTEGER_CHECK_MODULUS = 1;

		[Token(Token = "0x4004544")]
		private const int ICON_SPRITE_INDEX = 0;

		[Token(Token = "0x4004545")]
		private const string INTEGER_FORMAT = "0";

		[Token(Token = "0x4004546")]
		private const string DECIMAL_FORMAT = "0.##";

		[Token(Token = "0x4004547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private GlobalMainCityTitleInfo _config;

		[Token(Token = "0x4004548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private GlobalMainCityTitleInfo _lastConfig;

		[Token(Token = "0x4004549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Sequence _sq;

		[Token(Token = "0x400454A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Sequence _rotationSeq;

		[Token(Token = "0x400454B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool canClose;

		[Token(Token = "0x60035B2")]
		[Address(RVA = "0x40BCCCC", Offset = "0x40B8CCC", VA = "0x40BCCCC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__12))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60035B3")]
		[Address(RVA = "0x40BCD68", Offset = "0x40B8D68", VA = "0x40BCD68")]
		public void InitUI()
		{
		}

		[Token(Token = "0x60035B4")]
		[Address(RVA = "0x40BCE7C", Offset = "0x40B8E7C", VA = "0x40BCE7C")]
		public void UpdateData()
		{
		}

		[Token(Token = "0x60035B5")]
		[Address(RVA = "0x40BD02C", Offset = "0x40B902C", VA = "0x40BD02C")]
		[AsyncStateMachine(typeof(_003CLoadUIRes_003Ed__15))]
		public UniTask LoadUIRes()
		{
			return default;
		}

		[Token(Token = "0x60035B6")]
		[Address(RVA = "0x40BD0B8", Offset = "0x40B90B8", VA = "0x40BD0B8")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__16))]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x60035B7")]
		[Address(RVA = "0x40BD14C", Offset = "0x40B914C", VA = "0x40BD14C")]
		public void Anim()
		{
		}

		[Token(Token = "0x60035B8")]
		[Address(RVA = "0x40BDA60", Offset = "0x40B9A60", VA = "0x40BDA60", Slot = "12")]
		protected override void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x60035B9")]
		[Address(RVA = "0x40BDAC8", Offset = "0x40B9AC8", VA = "0x40BDAC8")]
		public MainCityLevelUpPanel()
		{
		}
	}
}
