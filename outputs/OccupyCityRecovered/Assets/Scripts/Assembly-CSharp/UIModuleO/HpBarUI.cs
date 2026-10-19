using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000917")]
	public class HpBarUI : HpBarUIComponents, IHUDElement
	{
		[Token(Token = "0x17000745")]
		public Transform Target
		{
			[Token(Token = "0x6003485")]
			[Address(RVA = "0x40AA960", Offset = "0x40A6960", VA = "0x40AA960", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003486")]
			[Address(RVA = "0x40AA968", Offset = "0x40A6968", VA = "0x40AA968", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000746")]
		public float YOffset
		{
			[Token(Token = "0x6003487")]
			[Address(RVA = "0x40AA970", Offset = "0x40A6970", VA = "0x40AA970", Slot = "14")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x6003488")]
			[Address(RVA = "0x40AA978", Offset = "0x40A6978", VA = "0x40AA978", Slot = "15")]
			[CompilerGenerated]
			set;
		}

		[Token(Token = "0x17000747")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x6003489")]
			[Address(RVA = "0x40AA980", Offset = "0x40A6980", VA = "0x40AA980", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600348A")]
			[Address(RVA = "0x40AA988", Offset = "0x40A6988", VA = "0x40AA988", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000748")]
		public RectTransform CanvasRectTransform
		{
			[Token(Token = "0x600348B")]
			[Address(RVA = "0x40AA990", Offset = "0x40A6990", VA = "0x40AA990", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600348C")]
			[Address(RVA = "0x40AA998", Offset = "0x40A6998", VA = "0x40AA998", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600348D")]
		[Address(RVA = "0x40AA9A0", Offset = "0x40A69A0", VA = "0x40AA9A0", Slot = "20")]
		public void Init(Transform target, float yOffset)
		{
		}

		[Token(Token = "0x600348E")]
		[Address(RVA = "0x40AAA3C", Offset = "0x40A6A3C", VA = "0x40AAA3C")]
		public void UpdateInfo(string hpStr, float hpPercent)
		{
		}

		[Token(Token = "0x600348F")]
		[Address(RVA = "0x40AAC28", Offset = "0x40A6C28", VA = "0x40AAC28")]
		public void SetColor(Color color)
		{
		}

		[Token(Token = "0x6003490")]
		[Address(RVA = "0x40AAC7C", Offset = "0x40A6C7C", VA = "0x40AAC7C")]
		public void SetActive(bool isActive)
		{
		}

		[Token(Token = "0x6003491")]
		[Address(RVA = "0x40AACA4", Offset = "0x40A6CA4", VA = "0x40AACA4", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6003492")]
		[Address(RVA = "0x40AAD50", Offset = "0x40A6D50", VA = "0x40AAD50", Slot = "11")]
		protected override void BindButtonEvent()
		{
		}

		[Token(Token = "0x6003493")]
		[Address(RVA = "0x40AAD54", Offset = "0x40A6D54", VA = "0x40AAD54")]
		public HpBarUI()
		{
		}
	}
}
