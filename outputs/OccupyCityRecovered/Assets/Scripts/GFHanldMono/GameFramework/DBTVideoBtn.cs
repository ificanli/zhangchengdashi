using System;
using System.Runtime.CompilerServices;
using GameFramework.SDK;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GameFramework
{
	[Token(Token = "0x2000016")]
	[Obsolete("此类已经过时，请使用UIVideoBtn/ModelVideoBtn", false)]
	public class DBTVideoBtn : Button
	{
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x108")]
		private BtnState state;

		[Token(Token = "0x17000015")]
		public ButtonClickedEvent TSonClick
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x706A2FC", Offset = "0x70662FC", VA = "0x706A2FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x706A304", Offset = "0x7066304", VA = "0x706A304")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x706A30C", Offset = "0x706630C", VA = "0x706A30C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x706A370", Offset = "0x7066370", VA = "0x706A370")]
		public void SetButtonState(BtnState btnState)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x706A378", Offset = "0x7066378", VA = "0x706A378", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x706A3A8", Offset = "0x70663A8", VA = "0x706A3A8", Slot = "41")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x706A3D8", Offset = "0x70663D8", VA = "0x706A3D8", Slot = "42")]
		public override void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x706A460", Offset = "0x7066460", VA = "0x706A460")]
		public DBTVideoBtn()
		{
		}
	}
}
