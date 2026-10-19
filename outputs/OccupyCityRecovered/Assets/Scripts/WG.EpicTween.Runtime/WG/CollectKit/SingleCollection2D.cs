using Il2CppDummyDll;
using UnityEngine.UI;

namespace WG.CollectKit
{
	[Token(Token = "0x2000005")]
	public class SingleCollection2D : SingleCollection
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x60")]
		public Image image;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x68")]
		private bool _isTweenCompleted;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x69")]
		private bool _isCanInActive;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x854D0E8", Offset = "0x85490E8", VA = "0x854D0E8", Slot = "4")]
		public override void Active()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x854D240", Offset = "0x8549240", VA = "0x854D240", Slot = "6")]
		public override void HideRender()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x854D3A8", Offset = "0x85493A8", VA = "0x854D3A8", Slot = "7")]
		public override void InActive()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x854D3B4", Offset = "0x85493B4", VA = "0x854D3B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x854D3CC", Offset = "0x85493CC", VA = "0x854D3CC")]
		public SingleCollection2D()
		{
		}
	}
}
