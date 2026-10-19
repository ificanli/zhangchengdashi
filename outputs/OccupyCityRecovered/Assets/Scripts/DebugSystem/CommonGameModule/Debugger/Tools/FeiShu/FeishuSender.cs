using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.Tools.FeiShu
{
	[Token(Token = "0x2000047")]
	public class FeishuSender : MonoBehaviour
	{
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x0")]
		private static FeishuSender _instance;

		[Token(Token = "0x1700002D")]
		public static FeishuSender Instance
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x46386DC", Offset = "0x46346DC", VA = "0x46386DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x4643364", Offset = "0x463F364", VA = "0x4643364")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x4643438", Offset = "0x463F438", VA = "0x4643438")]
		public FeishuSender()
		{
		}
	}
}
