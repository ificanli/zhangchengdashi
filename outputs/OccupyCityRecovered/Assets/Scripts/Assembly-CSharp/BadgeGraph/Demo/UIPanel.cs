using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace BadgeGraph.Demo
{
	[Token(Token = "0x2000E13")]
	public class UIPanel : MonoBehaviour
	{
		[Token(Token = "0x4006229")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button m_CloseButton;

		[Token(Token = "0x60056D3")]
		[Address(RVA = "0x434135C", Offset = "0x433D35C", VA = "0x434135C")]
		private void Start()
		{
		}

		[Token(Token = "0x60056D4")]
		[Address(RVA = "0x43413EC", Offset = "0x433D3EC", VA = "0x43413EC")]
		private void OnCloseButtonClick()
		{
		}

		[Token(Token = "0x60056D5")]
		[Address(RVA = "0x4341410", Offset = "0x433D410", VA = "0x4341410")]
		public UIPanel()
		{
		}
	}
}
