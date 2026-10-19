using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000923")]
	public class ImgIAPArtifactCardItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000924")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__137 : IAsyncStateMachine
		{
			[Token(Token = "0x4004490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ImgIAPArtifactCardItemComponents _003C_003E4__this;

			[Token(Token = "0x4004493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60034D8")]
			[Address(RVA = "0x40ADB6C", Offset = "0x40A9B6C", VA = "0x40ADB6C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60034D9")]
			[Address(RVA = "0x40ADDE4", Offset = "0x40A9DE4", VA = "0x40ADDE4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400448B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageImgBg;

		[Token(Token = "0x400448C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgCardIcon;

		[Token(Token = "0x400448D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgProgress;

		[Token(Token = "0x400448E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtProgress;

		[Token(Token = "0x400448F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtNum;

		[Token(Token = "0x17000751")]
		public Image ImageImgBg
		{
			[Token(Token = "0x60034CD")]
			[Address(RVA = "0x40AD93C", Offset = "0x40A993C", VA = "0x40AD93C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000752")]
		public Image ImageImgCardIcon
		{
			[Token(Token = "0x60034CE")]
			[Address(RVA = "0x40AD874", Offset = "0x40A9874", VA = "0x40AD874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000753")]
		public Image ImageImgProgress
		{
			[Token(Token = "0x60034CF")]
			[Address(RVA = "0x40AD7AC", Offset = "0x40A97AC", VA = "0x40AD7AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000754")]
		public TextMeshProUGUI TextMeshProUGUITxtProgress
		{
			[Token(Token = "0x60034D0")]
			[Address(RVA = "0x40AD6E4", Offset = "0x40A96E4", VA = "0x40AD6E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000755")]
		public TextMeshProUGUI TextMeshProUGUITxtNum
		{
			[Token(Token = "0x60034D1")]
			[Address(RVA = "0x40AD61C", Offset = "0x40A961C", VA = "0x40AD61C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60034D2")]
		[Address(RVA = "0x40ADA10", Offset = "0x40A9A10", VA = "0x40ADA10")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60034D3")]
		[Address(RVA = "0x40ADA14", Offset = "0x40A9A14", VA = "0x40ADA14", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60034D4")]
		[Address(RVA = "0x40ADA1C", Offset = "0x40A9A1C", VA = "0x40ADA1C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__137))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60034D5")]
		[Address(RVA = "0x40ADAB0", Offset = "0x40A9AB0", VA = "0x40ADAB0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60034D6")]
		[Address(RVA = "0x40ACAD0", Offset = "0x40A8AD0", VA = "0x40ACAD0")]
		public ImgIAPArtifactCardItemComponents()
		{
		}
	}
}
