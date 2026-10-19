using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000067")]
	public abstract class PopupBase : MonoBehaviour
	{
		[Token(Token = "0x40001F2")]
		private const float POINTER_VALIDATE_INTERVAL = 5f;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayoutElement borderLayoutElement;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image background;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Text label;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform rectTransform;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform canvasTransform;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x48")]
		private Camera worldCamera;

		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x50")]
		protected PointerEventData pointer;

		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x58")]
		private float nextPointerValidation;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x5C")]
		private int m_skinVersion;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x60")]
		private UISkin m_skin;

		[Token(Token = "0x170000AF")]
		public UISkin Skin
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x4673484", Offset = "0x466F484", VA = "0x4673484")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x467348C", Offset = "0x466F48C", VA = "0x467348C")]
			set
			{
			}
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x467365C", Offset = "0x466F65C", VA = "0x467365C")]
		public void Initialize(Canvas canvas)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x466DF6C", Offset = "0x4669F6C", VA = "0x466DF6C")]
		protected void SetPointer(PointerEventData pointer)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x466E008", Offset = "0x466A008", VA = "0x466E008")]
		protected void RepositionSelf()
		{
		}

		[Token(Token = "0x6000376")]
		protected abstract void DestroySelf();

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x46737F0", Offset = "0x466F7F0", VA = "0x46737F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x466E0CC", Offset = "0x466A0CC", VA = "0x466E0CC")]
		protected PopupBase()
		{
		}
	}
}
