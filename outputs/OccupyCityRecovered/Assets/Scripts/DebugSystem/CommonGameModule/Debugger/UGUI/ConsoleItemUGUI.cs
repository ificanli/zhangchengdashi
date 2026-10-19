using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000052")]
	public class ConsoleItemUGUI : DynamicScrollItemBase<ConsoleWindowUGUI.Log, ConsoleWindowUGUI.LogItemViewSetting>, IPointerClickHandler, IEventSystemHandler
	{
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[UIPath(UIPathType.UGUI, "Type")]
		private Image m_TypeIcon;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x20")]
		[UIPath(UIPathType.UGUI, "Bg")]
		[SerializeField]
		private Image m_Bg;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x28")]
		[UIPath(UIPathType.UGUI, "Content")]
		[SerializeField]
		private Text m_Text;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[UIPath(UIPathType.UGUI, "ExtendInfoBar/TextShowTime")]
		private Text m_TextShowTime;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x38")]
		[UIPath(UIPathType.UGUI, "ExtendInfoBar/TextShowScene")]
		[SerializeField]
		private Text m_TextShowScene;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x40")]
		[UIPath(UIPathType.UGUI, "ExtendInfoBar/TextShowFps")]
		[SerializeField]
		private Text m_TextShowFps;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x48")]
		[UIPath(UIPathType.UGUI, "Image/TextCount")]
		[SerializeField]
		private Text m_TextCollapse;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x50")]
		[UIPath(UIPathType.UGUI, "ExtendInfoBar")]
		[SerializeField]
		private HorizontalOrVerticalLayoutGroup layoutGroup;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x60")]
		private ConsoleWindowUGUI.LogItemViewSetting m_ViewSetting;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x68")]
		private ConsoleWindowUGUI.Log m_Log;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x70")]
		private int extendInfoStage;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x0")]
		private static List<RectTransform> tmpExtendInfoTf;

		[Token(Token = "0x4000118")]
		private const int MAX_ACTIVE_ITEM_COUNT = 1;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x8")]
		private static List<ConsoleItemUGUI> waitActiveItemList;

		[Token(Token = "0x17000036")]
		public int ItemIndex
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x4644C54", Offset = "0x4640C54", VA = "0x4644C54")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x4644C5C", Offset = "0x4640C5C", VA = "0x4644C5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public override int Index
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x4644C64", Offset = "0x4640C64", VA = "0x4644C64", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x4644C6C", Offset = "0x4640C6C", VA = "0x4644C6C", Slot = "4")]
		protected override void AfterBindTransform()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x4644D4C", Offset = "0x4640D4C", VA = "0x4644D4C", Slot = "6")]
		public override void Init(Transform parent)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x4644DE8", Offset = "0x4640DE8", VA = "0x4644DE8", Slot = "7")]
		public override void Refresh(ConsoleWindowUGUI.Log data, int index, ConsoleWindowUGUI.LogItemViewSetting viewSetting)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x4645688", Offset = "0x4641688", VA = "0x4645688")]
		private static void SetText(Text text, string targetStr)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x46456EC", Offset = "0x46416EC", VA = "0x46456EC")]
		private void RefreshExtendInfoPos()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x464594C", Offset = "0x464194C", VA = "0x464594C", Slot = "8")]
		public override void SetActive(bool active)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x46459B4", Offset = "0x46419B4", VA = "0x46459B4", Slot = "9")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x46459D4", Offset = "0x46419D4", VA = "0x46459D4")]
		public static void UpdateWaitActiveItem()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x4645B14", Offset = "0x4641B14", VA = "0x4645B14")]
		public ConsoleItemUGUI()
		{
		}
	}
}
