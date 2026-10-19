using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000024")]
	public class ColorField : InspectorField
	{
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform colorPickerArea;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private PointerEventListener inputColor;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x90")]
		private Image colorImg;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x98")]
		private bool isColor32;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x465CBCC", Offset = "0x4658BCC", VA = "0x465CBCC", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x465CC90", Offset = "0x4658C90", VA = "0x465CC90", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x465CD74", Offset = "0x4658D74", VA = "0x465CD74", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x465CE20", Offset = "0x4658E20", VA = "0x465CE20")]
		private void ShowColorPicker(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x465CFC0", Offset = "0x4658FC0", VA = "0x465CFC0")]
		private void OnColorChanged(Color32 color)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x465D0C8", Offset = "0x46590C8", VA = "0x465D0C8", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x465D130", Offset = "0x4659130", VA = "0x465D130", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x465D254", Offset = "0x4659254", VA = "0x465D254")]
		public ColorField()
		{
		}
	}
}
