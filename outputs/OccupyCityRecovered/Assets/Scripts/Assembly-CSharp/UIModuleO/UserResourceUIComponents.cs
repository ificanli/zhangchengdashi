using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000BF7")]
	public class UserResourceUIComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BF8")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__54 : IAsyncStateMachine
		{
			[Token(Token = "0x40056A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40056AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UserResourceUIComponents _003C_003E4__this;

			[Token(Token = "0x40056AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004A15")]
			[Address(RVA = "0x42540CC", Offset = "0x42500CC", VA = "0x42540CC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004A16")]
			[Address(RVA = "0x4254344", Offset = "0x4250344", VA = "0x4254344", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40056A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendUserResourceUI;

		[Token(Token = "0x40056A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformIconImg;

		[Token(Token = "0x40056A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUIValueText;

		[Token(Token = "0x17000CF0")]
		public ButtonExtend ButtonExtendUserResourceUI
		{
			[Token(Token = "0x6004A0B")]
			[Address(RVA = "0x4253E50", Offset = "0x424FE50", VA = "0x4253E50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CF1")]
		public RectTransform RectTransformIconImg
		{
			[Token(Token = "0x6004A0C")]
			[Address(RVA = "0x42531BC", Offset = "0x424F1BC", VA = "0x42531BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CF2")]
		public TextMeshProUGUI TextMeshProUGUIValueText
		{
			[Token(Token = "0x6004A0D")]
			[Address(RVA = "0x4253424", Offset = "0x424F424", VA = "0x4253424")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004A0E")]
		[Address(RVA = "0x4253EF4", Offset = "0x424FEF4", VA = "0x4253EF4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004A0F")]
		[Address(RVA = "0x4253AB4", Offset = "0x424FAB4", VA = "0x4253AB4", Slot = "12")]
		protected virtual void OnButtonExtendUserResourceUIClicked()
		{
		}

		[Token(Token = "0x6004A10")]
		[Address(RVA = "0x4253384", Offset = "0x424F384", VA = "0x4253384", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004A11")]
		[Address(RVA = "0x4253F7C", Offset = "0x424FF7C", VA = "0x4253F7C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__54))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004A12")]
		[Address(RVA = "0x4254010", Offset = "0x4250010", VA = "0x4254010", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004A13")]
		[Address(RVA = "0x4253BA0", Offset = "0x424FBA0", VA = "0x4253BA0")]
		public UserResourceUIComponents()
		{
		}
	}
}
