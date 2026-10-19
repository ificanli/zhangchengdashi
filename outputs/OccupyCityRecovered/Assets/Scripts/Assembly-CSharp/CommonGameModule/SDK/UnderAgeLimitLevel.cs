using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.SDK
{
	[Token(Token = "0x2000FD9")]
	public class UnderAgeLimitLevel : MonoBehaviour
	{
		[Token(Token = "0x4006C07")]
		[FieldOffset(Offset = "0x20")]
		[Header("适龄提醒按钮")]
		public Button m_button;

		[Token(Token = "0x4006C08")]
		[FieldOffset(Offset = "0x28")]
		[Header("适龄提醒按钮应该显示的图片")]
		public Sprite[] imgs;

		[Token(Token = "0x6005EED")]
		[Address(RVA = "0x43FFA80", Offset = "0x43FBA80", VA = "0x43FFA80")]
		private void Start()
		{
		}

		[Token(Token = "0x6005EEE")]
		[Address(RVA = "0x43FFD6C", Offset = "0x43FBD6C", VA = "0x43FFD6C")]
		public void OnClickBtn()
		{
		}

		[Token(Token = "0x6005EEF")]
		[Address(RVA = "0x43FFDC0", Offset = "0x43FBDC0", VA = "0x43FFDC0")]
		public UnderAgeLimitLevel()
		{
		}
	}
}
