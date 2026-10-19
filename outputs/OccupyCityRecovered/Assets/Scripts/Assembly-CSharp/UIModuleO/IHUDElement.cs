using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000C45")]
	public interface IHUDElement
	{
		[Token(Token = "0x17000D84")]
		Transform Target
		{
			[Token(Token = "0x6004C0A")]
			get;
			[Token(Token = "0x6004C0B")]
			set;
		}

		[Token(Token = "0x17000D85")]
		float YOffset
		{
			[Token(Token = "0x6004C0C")]
			get;
			[Token(Token = "0x6004C0D")]
			set;
		}

		[Token(Token = "0x17000D86")]
		RectTransform RectTransform
		{
			[Token(Token = "0x6004C0E")]
			get;
			[Token(Token = "0x6004C0F")]
			set;
		}

		[Token(Token = "0x17000D87")]
		RectTransform CanvasRectTransform
		{
			[Token(Token = "0x6004C10")]
			get;
			[Token(Token = "0x6004C11")]
			set;
		}

		[Token(Token = "0x6004C12")]
		void Init(Transform target, float yOffset);
	}
}
