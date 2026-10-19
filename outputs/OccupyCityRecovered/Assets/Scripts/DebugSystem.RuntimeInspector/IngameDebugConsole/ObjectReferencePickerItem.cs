using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000064")]
	public class ObjectReferencePickerItem : RecycledListItem
	{
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image background;

		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RawImage texturePreview;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x48")]
		private LayoutElement texturePreviewLayoutElement;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text referenceNameText;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x60")]
		private int m_skinVersion;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x68")]
		private UISkin m_skin;

		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isSelected;

		[Token(Token = "0x170000AC")]
		public object Reference
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x4673110", Offset = "0x466F110", VA = "0x4673110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x4673118", Offset = "0x466F118", VA = "0x4673118")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public UISkin Skin
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x4673120", Offset = "0x466F120", VA = "0x4673120")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x46725A8", Offset = "0x466E5A8", VA = "0x46725A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public bool IsSelected
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x4673128", Offset = "0x466F128", VA = "0x4673128")]
			get
			{
				return default;
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x4672988", Offset = "0x466E988", VA = "0x4672988")]
			set
			{
			}
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x4673130", Offset = "0x466F130", VA = "0x4673130")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x4672834", Offset = "0x466E834", VA = "0x4672834")]
		public void SetContent(object reference, string displayName)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x4673204", Offset = "0x466F204", VA = "0x4673204")]
		public ObjectReferencePickerItem()
		{
		}
	}
}
