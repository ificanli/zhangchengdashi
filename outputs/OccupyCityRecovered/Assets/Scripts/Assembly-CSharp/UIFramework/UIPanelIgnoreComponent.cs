using Il2CppDummyDll;
using UnityEngine;

namespace UIFramework
{
	[Token(Token = "0x2000C50")]
	public class UIPanelIgnoreComponent : MonoBehaviour
	{
		[Token(Token = "0x4005858")]
		[FieldOffset(Offset = "0x20")]
		public bool IgnoreSelf;

		[Token(Token = "0x4005859")]
		[FieldOffset(Offset = "0x21")]
		public bool IgnoreChildren;

		[Token(Token = "0x6004C52")]
		[Address(RVA = "0x4275B64", Offset = "0x4271B64", VA = "0x4275B64")]
		public UIPanelIgnoreComponent()
		{
		}
	}
}
