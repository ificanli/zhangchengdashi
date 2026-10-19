using Il2CppDummyDll;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000995")]
	public class MetaSwitchPanelComponents : UIPanel, IUIPanelComponents
	{
		[Token(Token = "0x40047C2")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform _metaSwitchPanelRect;

		[Token(Token = "0x40047C3")]
		[FieldOffset(Offset = "0x48")]
		private Image _bottomBackGroundImg;

		[Token(Token = "0x40047C4")]
		[FieldOffset(Offset = "0x50")]
		private GridLayoutGroup _bottomBackGroundGridLayOut;

		[Token(Token = "0x17000889")]
		protected RectTransform MetaSwitchPanelRect
		{
			[Token(Token = "0x60038C4")]
			[Address(RVA = "0x40FA4CC", Offset = "0x40F64CC", VA = "0x40FA4CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700088A")]
		protected Image BottomBackGroundImg
		{
			[Token(Token = "0x60038C5")]
			[Address(RVA = "0x40FAC3C", Offset = "0x40F6C3C", VA = "0x40FAC3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700088B")]
		protected GridLayoutGroup BottomBackGroundGridLayOut
		{
			[Token(Token = "0x60038C6")]
			[Address(RVA = "0x40FB680", Offset = "0x40F7680", VA = "0x40FB680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60038C7")]
		[Address(RVA = "0x40F9994", Offset = "0x40F5994", VA = "0x40F9994", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60038C8")]
		[Address(RVA = "0x40FB754", Offset = "0x40F7754", VA = "0x40FB754", Slot = "11")]
		protected override void BindButtonEvent()
		{
		}

		[Token(Token = "0x60038C9")]
		[Address(RVA = "0x40F9968", Offset = "0x40F5968", VA = "0x40F9968")]
		public MetaSwitchPanelComponents()
		{
		}
	}
}
