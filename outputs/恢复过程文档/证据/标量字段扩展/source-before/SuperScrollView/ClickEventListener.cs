using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SuperScrollView
{
	[Token(Token = "0x2000C5B")]
	public class ClickEventListener : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Token(Token = "0x400587A")]
		[FieldOffset(Offset = "0x20")]
		private Action<GameObject> mClickedHandler;

		[Token(Token = "0x400587B")]
		[FieldOffset(Offset = "0x28")]
		private Action<GameObject> mDoubleClickedHandler;

		[Token(Token = "0x400587C")]
		[FieldOffset(Offset = "0x30")]
		private Action<GameObject> mOnPointerDownHandler;

		[Token(Token = "0x400587D")]
		[FieldOffset(Offset = "0x38")]
		private Action<GameObject> mOnPointerUpHandler;

		[Token(Token = "0x400587E")]
		[FieldOffset(Offset = "0x40")]
		private bool mIsPressed;

		[Token(Token = "0x17000D8F")]
		public bool IsPressd
		{
			[Token(Token = "0x6004C72")]
			[Address(RVA = "0x4278248", Offset = "0x4274248", VA = "0x4278248")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004C71")]
		[Address(RVA = "0x4278188", Offset = "0x4274188", VA = "0x4278188")]
		public static ClickEventListener Get(GameObject obj)
		{
			return null;
		}

		[Token(Token = "0x6004C73")]
		[Address(RVA = "0x4278250", Offset = "0x4274250", VA = "0x4278250", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004C74")]
		[Address(RVA = "0x42782A4", Offset = "0x42742A4", VA = "0x42782A4")]
		public void SetClickEventHandler(Action<GameObject> handler)
		{
		}

		[Token(Token = "0x6004C75")]
		[Address(RVA = "0x42782AC", Offset = "0x42742AC", VA = "0x42782AC")]
		public void SetDoubleClickEventHandler(Action<GameObject> handler)
		{
		}

		[Token(Token = "0x6004C76")]
		[Address(RVA = "0x42782B4", Offset = "0x42742B4", VA = "0x42782B4")]
		public void SetPointerDownHandler(Action<GameObject> handler)
		{
		}

		[Token(Token = "0x6004C77")]
		[Address(RVA = "0x42782BC", Offset = "0x42742BC", VA = "0x42782BC")]
		public void SetPointerUpHandler(Action<GameObject> handler)
		{
		}

		[Token(Token = "0x6004C78")]
		[Address(RVA = "0x42782C4", Offset = "0x42742C4", VA = "0x42782C4", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004C79")]
		[Address(RVA = "0x4278304", Offset = "0x4274304", VA = "0x4278304", Slot = "6")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004C7A")]
		[Address(RVA = "0x4278340", Offset = "0x4274340", VA = "0x4278340")]
		public ClickEventListener()
		{
		}
	}
}
