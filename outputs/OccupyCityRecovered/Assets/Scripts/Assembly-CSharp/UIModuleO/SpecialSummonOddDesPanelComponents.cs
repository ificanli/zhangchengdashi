using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000B82")]
	public class SpecialSummonOddDesPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B83")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__91 : IAsyncStateMachine
		{
			[Token(Token = "0x40053D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40053D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40053D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SpecialSummonOddDesPanelComponents _003C_003E4__this;

			[Token(Token = "0x40053D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600469F")]
			[Address(RVA = "0x42174EC", Offset = "0x42134EC", VA = "0x42174EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60046A0")]
			[Address(RVA = "0x4217764", Offset = "0x4213764", VA = "0x4217764", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40053CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBg;

		[Token(Token = "0x40053CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgWeightBg;

		[Token(Token = "0x40053D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SpecialSummonProbabilityItem _specialSummonProbabilityItemProbabilityItem;

		[Token(Token = "0x40053D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x17000BEB")]
		public ButtonExtend ButtonExtendBg
		{
			[Token(Token = "0x6004693")]
			[Address(RVA = "0x42170CC", Offset = "0x42130CC", VA = "0x42170CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BEC")]
		public RectTransform RectTransformImgWeightBg
		{
			[Token(Token = "0x6004694")]
			[Address(RVA = "0x4216F68", Offset = "0x4212F68", VA = "0x4216F68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BED")]
		public SpecialSummonProbabilityItem SpecialSummonProbabilityItemProbabilityItem
		{
			[Token(Token = "0x6004695")]
			[Address(RVA = "0x4216EA0", Offset = "0x4212EA0", VA = "0x4216EA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BEE")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6004696")]
			[Address(RVA = "0x4217194", Offset = "0x4213194", VA = "0x4217194")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004697")]
		[Address(RVA = "0x421725C", Offset = "0x421325C", VA = "0x421725C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004698")]
		[Address(RVA = "0x4217330", Offset = "0x4213330", VA = "0x4217330", Slot = "12")]
		protected virtual void OnButtonExtendBgClicked()
		{
		}

		[Token(Token = "0x6004699")]
		[Address(RVA = "0x4217050", Offset = "0x4213050", VA = "0x4217050", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x600469A")]
		[Address(RVA = "0x4216E84", Offset = "0x4212E84", VA = "0x4216E84", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600469B")]
		[Address(RVA = "0x421739C", Offset = "0x421339C", VA = "0x421739C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__91))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600469C")]
		[Address(RVA = "0x4217430", Offset = "0x4213430", VA = "0x4217430", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600469D")]
		[Address(RVA = "0x42170C4", Offset = "0x42130C4", VA = "0x42170C4")]
		public SpecialSummonOddDesPanelComponents()
		{
		}
	}
}
