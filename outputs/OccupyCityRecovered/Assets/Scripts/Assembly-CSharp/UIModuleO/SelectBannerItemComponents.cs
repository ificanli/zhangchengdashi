using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B07")]
	public class SelectBannerItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B08")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x40050BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40050BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40050BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SelectBannerItemComponents _003C_003E4__this;

			[Token(Token = "0x40050BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60042D1")]
			[Address(RVA = "0x41D3A50", Offset = "0x41CFA50", VA = "0x41D3A50", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60042D2")]
			[Address(RVA = "0x41D3CC8", Offset = "0x41CFCC8", VA = "0x41D3CC8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40050B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendSelectBannerItem;

		[Token(Token = "0x40050B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageBannerIcon;

		[Token(Token = "0x40050BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imagePitchon;

		[Token(Token = "0x17000AC7")]
		public ButtonExtend ButtonExtendSelectBannerItem
		{
			[Token(Token = "0x60042C7")]
			[Address(RVA = "0x41D37B8", Offset = "0x41CF7B8", VA = "0x41D37B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AC8")]
		public Image ImageBannerIcon
		{
			[Token(Token = "0x60042C8")]
			[Address(RVA = "0x41D36E4", Offset = "0x41CF6E4", VA = "0x41D36E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AC9")]
		public Image ImagePitchon
		{
			[Token(Token = "0x60042C9")]
			[Address(RVA = "0x41D361C", Offset = "0x41CF61C", VA = "0x41D361C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60042CA")]
		[Address(RVA = "0x41D385C", Offset = "0x41CF85C", VA = "0x41D385C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60042CB")]
		[Address(RVA = "0x41D30C0", Offset = "0x41CF0C0", VA = "0x41D30C0", Slot = "12")]
		protected virtual void OnButtonExtendSelectBannerItemClicked()
		{
		}

		[Token(Token = "0x60042CC")]
		[Address(RVA = "0x41D38E4", Offset = "0x41CF8E4", VA = "0x41D38E4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60042CD")]
		[Address(RVA = "0x41D3900", Offset = "0x41CF900", VA = "0x41D3900", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__33))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60042CE")]
		[Address(RVA = "0x41D3994", Offset = "0x41CF994", VA = "0x41D3994", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60042CF")]
		[Address(RVA = "0x41D3134", Offset = "0x41CF134", VA = "0x41D3134")]
		public SelectBannerItemComponents()
		{
		}
	}
}
