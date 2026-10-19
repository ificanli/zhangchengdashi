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
	[Token(Token = "0x20007D2")]
	public class CheatPanel_ButtonsComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007D3")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__100 : IAsyncStateMachine
		{
			[Token(Token = "0x4003C63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003C64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003C65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CheatPanel_ButtonsComponents _003C_003E4__this;

			[Token(Token = "0x4003C66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002B5F")]
			[Address(RVA = "0x3FEB70C", Offset = "0x3FE770C", VA = "0x3FEB70C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002B60")]
			[Address(RVA = "0x3FEB984", Offset = "0x3FE7984", VA = "0x3FEB984", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI _textMeshProUGUIText;

		[Token(Token = "0x4003C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Button _buttonButtonPrefab;

		[Token(Token = "0x4003C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformTogglePrefab;

		[Token(Token = "0x4003C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Toggle _toggleTogglePrefab;

		[Token(Token = "0x17000488")]
		public TextMeshProUGUI TextMeshProUGUIText
		{
			[Token(Token = "0x6002B53")]
			[Address(RVA = "0x3FEAC58", Offset = "0x3FE6C58", VA = "0x3FEAC58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000489")]
		public Button ButtonButtonPrefab
		{
			[Token(Token = "0x6002B54")]
			[Address(RVA = "0x3FEB1D4", Offset = "0x3FE71D4", VA = "0x3FEB1D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700048A")]
		public RectTransform RectTransformTogglePrefab
		{
			[Token(Token = "0x6002B55")]
			[Address(RVA = "0x3FEAF34", Offset = "0x3FE6F34", VA = "0x3FEAF34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700048B")]
		public Toggle ToggleTogglePrefab
		{
			[Token(Token = "0x6002B56")]
			[Address(RVA = "0x3FEB374", Offset = "0x3FE7374", VA = "0x3FEB374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B57")]
		[Address(RVA = "0x3FEB43C", Offset = "0x3FE743C", VA = "0x3FEB43C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002B58")]
		[Address(RVA = "0x3FEB530", Offset = "0x3FE7530", VA = "0x3FEB530", Slot = "12")]
		protected virtual void OnButtonButtonPrefabClicked()
		{
		}

		[Token(Token = "0x6002B59")]
		[Address(RVA = "0x3FEB59C", Offset = "0x3FE759C", VA = "0x3FEB59C", Slot = "13")]
		protected virtual void OnToggleTogglePrefabValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6002B5A")]
		[Address(RVA = "0x3FEB5A0", Offset = "0x3FE75A0", VA = "0x3FEB5A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002B5B")]
		[Address(RVA = "0x3FEB5BC", Offset = "0x3FE75BC", VA = "0x3FEB5BC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__100))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002B5C")]
		[Address(RVA = "0x3FEB650", Offset = "0x3FE7650", VA = "0x3FEB650", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002B5D")]
		[Address(RVA = "0x3FEB2A4", Offset = "0x3FE72A4", VA = "0x3FEB2A4")]
		public CheatPanel_ButtonsComponents()
		{
		}
	}
}
