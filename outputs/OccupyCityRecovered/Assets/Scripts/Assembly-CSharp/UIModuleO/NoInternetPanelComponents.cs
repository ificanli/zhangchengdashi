using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A6A")]
	public class NoInternetPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A6B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__74 : IAsyncStateMachine
		{
			[Token(Token = "0x4004CF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004CF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004CF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NoInternetPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004CF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003E9C")]
			[Address(RVA = "0x4170300", Offset = "0x416C300", VA = "0x4170300", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003E9D")]
			[Address(RVA = "0x4170578", Offset = "0x416C578", VA = "0x4170578", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004CEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageBG;

		[Token(Token = "0x4004CF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgWifi;

		[Token(Token = "0x4004CF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformImgLoad;

		[Token(Token = "0x4004CF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgLoad;

		[Token(Token = "0x4004CF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtNoInternet;

		[Token(Token = "0x4004CF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtRetrying;

		[Token(Token = "0x17000980")]
		public Image ImageBG
		{
			[Token(Token = "0x6003E90")]
			[Address(RVA = "0x416FB04", Offset = "0x416BB04", VA = "0x416FB04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000981")]
		public Image ImageImgWifi
		{
			[Token(Token = "0x6003E91")]
			[Address(RVA = "0x416F7E4", Offset = "0x416B7E4", VA = "0x416F7E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000982")]
		public RectTransform RectTransformImgLoad
		{
			[Token(Token = "0x6003E92")]
			[Address(RVA = "0x416FD70", Offset = "0x416BD70", VA = "0x416FD70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000983")]
		public Image ImageImgLoad
		{
			[Token(Token = "0x6003E93")]
			[Address(RVA = "0x416F8AC", Offset = "0x416B8AC", VA = "0x416F8AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000984")]
		public TextMeshProUGUI TextMeshProUGUITxtNoInternet
		{
			[Token(Token = "0x6003E94")]
			[Address(RVA = "0x416F974", Offset = "0x416B974", VA = "0x416F974")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000985")]
		public TextMeshProUGUI TextMeshProUGUITxtRetrying
		{
			[Token(Token = "0x6003E95")]
			[Address(RVA = "0x416FA3C", Offset = "0x416BA3C", VA = "0x416FA3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003E96")]
		[Address(RVA = "0x41702EC", Offset = "0x416C2EC", VA = "0x41702EC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003E97")]
		[Address(RVA = "0x41702F0", Offset = "0x416C2F0", VA = "0x41702F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003E98")]
		[Address(RVA = "0x416FE4C", Offset = "0x416BE4C", VA = "0x416FE4C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__74))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003E99")]
		[Address(RVA = "0x416FBE4", Offset = "0x416BBE4", VA = "0x416FBE4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003E9A")]
		[Address(RVA = "0x416FE40", Offset = "0x416BE40", VA = "0x416FE40")]
		public NoInternetPanelComponents()
		{
		}
	}
}
