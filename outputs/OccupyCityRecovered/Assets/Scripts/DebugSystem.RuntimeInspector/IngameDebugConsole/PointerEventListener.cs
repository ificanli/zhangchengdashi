using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000065")]
	public class PointerEventListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler
	{
		[Token(Token = "0x2000066")]
		public delegate void PointerEvent(PointerEventData eventData);

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private PointerEvent m_PointerDown;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		private PointerEvent m_PointerUp;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x30")]
		[CompilerGenerated]
		private PointerEvent m_PointerClick;

		[Token(Token = "0x14000002")]
		public event PointerEvent PointerDown
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x466C628", Offset = "0x4668628", VA = "0x466C628")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x4673214", Offset = "0x466F214", VA = "0x4673214")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event PointerEvent PointerUp
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x466C6C4", Offset = "0x46686C4", VA = "0x466C6C4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x46732B0", Offset = "0x466F2B0", VA = "0x46732B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event PointerEvent PointerClick
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x46630A0", Offset = "0x465F0A0", VA = "0x46630A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x467334C", Offset = "0x466F34C", VA = "0x467334C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x46733E8", Offset = "0x466F3E8", VA = "0x46733E8", Slot = "4")]
void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x4673404", Offset = "0x466F404", VA = "0x4673404", Slot = "5")]
void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x4673420", Offset = "0x466F420", VA = "0x4673420", Slot = "6")]
void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x467343C", Offset = "0x466F43C", VA = "0x467343C")]
		public PointerEventListener()
		{
		}
	}
}
