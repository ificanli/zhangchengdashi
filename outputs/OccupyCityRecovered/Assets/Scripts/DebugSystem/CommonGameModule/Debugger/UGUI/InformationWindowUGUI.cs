using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200006B")]
	public class InformationWindowUGUI
	{
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[UIPath(UIPathType.UGUI, "TextTitle")]
		private Text m_Title;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x18")]
		[UIPath(UIPathType.UGUI, "Scroll View/Viewport/Content/TextFirst")]
		[SerializeField]
		private Text m_TextFirst;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[UIPath(UIPathType.UGUI, "Scroll View/Viewport/Content/TextSecond")]
		private Text m_TextSecond;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[UIPath(UIPathType.UGUI, "Scroll View/Viewport/Content/TextThird")]
		private Text m_TextThird;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[UIPath(UIPathType.UGUI, "Scroll View/Viewport/Content")]
		private RectTransform m_Content;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x38")]
		[UIPath(UIPathType.UGUI, "Scroll View")]
		[SerializeField]
		private RectTransform m_ScrollView;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[UIPath(UIPathType.UGUI, "GameObject/Button")]
		private Button m_BtnPrefab;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x48")]
		private readonly Text[] _texts;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x50")]
		private HorizontalOrVerticalLayoutGroup m_LayoutGroup;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x58")]
		private List<Button> m_Btns;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x60")]
		private float m_Space;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x68")]
		private readonly Transform _root;

		[Token(Token = "0x1700006A")]
		public int TextCount
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x4686A40", Offset = "0x4682A40", VA = "0x4686A40")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006B")]
		public Transform transform
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x4686A5C", Offset = "0x4682A5C", VA = "0x4686A5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public GameObject gameObject
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x4686A64", Offset = "0x4682A64", VA = "0x4686A64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x4686A80", Offset = "0x4682A80", VA = "0x4686A80")]
		public InformationWindowUGUI(Transform transform)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x4686BC8", Offset = "0x4682BC8", VA = "0x4686BC8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x4686C9C", Offset = "0x4682C9C", VA = "0x4686C9C")]
		public void SetTitle(string title)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x4686CF4", Offset = "0x4682CF4", VA = "0x4686CF4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x4686E84", Offset = "0x4682E84", VA = "0x4686E84")]
		public void SetText(StringBuilder[] stringBuilders)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x46870E8", Offset = "0x46830E8", VA = "0x46870E8")]
		public Button AddButton(string name, UnityAction onClick)
		{
			return null;
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x4687484", Offset = "0x4683484", VA = "0x4687484")]
		public Button GetBtn(int index)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x46874DC", Offset = "0x46834DC", VA = "0x46874DC")]
		public void OnRefreshSize(Vector2 size, bool portrait)
		{
		}
	}
}
