using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000037")]
	public class ObjectReferenceField : InspectorField, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform referencePickerArea;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private PointerEventListener input;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private PointerEventListener inspectReferenceButton;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x98")]
		private Image inspectReferenceImage;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected Image background;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected Text referenceNameText;

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x4666C94", Offset = "0x4662C94", VA = "0x4666C94", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x4666DCC", Offset = "0x4662DCC", VA = "0x4666DCC", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x4666E60", Offset = "0x4662E60", VA = "0x4666E60")]
		private void ShowReferencePicker(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x46670F4", Offset = "0x46630F4", VA = "0x46670F4")]
		private void InspectReference(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x46671C0", Offset = "0x46631C0", VA = "0x46671C0", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x4667258", Offset = "0x4663258", VA = "0x4667258", Slot = "18")]
		protected virtual void OnReferenceChanged(UnityEngine.Object reference)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x466741C", Offset = "0x466341C", VA = "0x466741C", Slot = "17")]
		public void OnDrop(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x4667520", Offset = "0x4663520", VA = "0x4667520", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x4667798", Offset = "0x4663798", VA = "0x4667798", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x4667848", Offset = "0x4663848", VA = "0x4667848")]
		public ObjectReferenceField()
		{
		}
	}
}
