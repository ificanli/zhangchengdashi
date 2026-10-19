using Il2CppDummyDll;
using UnityEngine;

namespace BadgeGraph.Demo
{
	[Token(Token = "0x2000E12")]
	public class GamePlayDemo : MonoBehaviour
	{
		[Token(Token = "0x4006220")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BadgeGraphScriptable m_BadgeGraphScriptable;

		[Token(Token = "0x4006221")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BadgeButton m_EventButton;

		[Token(Token = "0x4006222")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_EventPanel;

		[Token(Token = "0x4006223")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BadgeButton m_CardEventButton;

		[Token(Token = "0x4006224")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject m_CardEventPanel;

		[Token(Token = "0x4006225")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BadgeButton m_MailButton;

		[Token(Token = "0x4006226")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject m_MailPanel;

		[Token(Token = "0x4006227")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BadgeButton m_TaskButton;

		[Token(Token = "0x4006228")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject m_TaskPanel;

		[Token(Token = "0x60056CD")]
		[Address(RVA = "0x43412CC", Offset = "0x433D2CC", VA = "0x43412CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60056CE")]
		[Address(RVA = "0x43412D4", Offset = "0x433D2D4", VA = "0x43412D4")]
		private void OnEventButtonClick()
		{
		}

		[Token(Token = "0x60056CF")]
		[Address(RVA = "0x43412F4", Offset = "0x433D2F4", VA = "0x43412F4")]
		private void OnCardEventButtonClick()
		{
		}

		[Token(Token = "0x60056D0")]
		[Address(RVA = "0x4341314", Offset = "0x433D314", VA = "0x4341314")]
		private void OnMailButtonClick()
		{
		}

		[Token(Token = "0x60056D1")]
		[Address(RVA = "0x4341334", Offset = "0x433D334", VA = "0x4341334")]
		private void OnTaskButtonClick()
		{
		}

		[Token(Token = "0x60056D2")]
		[Address(RVA = "0x4341354", Offset = "0x433D354", VA = "0x4341354")]
		public GamePlayDemo()
		{
		}
	}
}
