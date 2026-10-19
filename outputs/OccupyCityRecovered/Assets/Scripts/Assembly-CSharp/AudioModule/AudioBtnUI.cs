using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace AudioModule
{
	[Token(Token = "0x200062E")]
	public class AudioBtnUI : MonoBehaviour
	{
		[Token(Token = "0x200062F")]
		public enum AudioType
		{
			[Token(Token = "0x400329E")]
			Bgm = 0,
			[Token(Token = "0x400329F")]
			Sfx = 1
		}

		[Token(Token = "0x4003299")]
		[FieldOffset(Offset = "0x20")]
		public AudioType audioType;

		[Token(Token = "0x400329A")]
		[FieldOffset(Offset = "0x28")]
		public Sprite switchOnSprite;

		[Token(Token = "0x400329B")]
		[FieldOffset(Offset = "0x30")]
		public Sprite switchOffSprite;

		[Token(Token = "0x400329C")]
		[FieldOffset(Offset = "0x38")]
		private Image _image;

		[Token(Token = "0x60020B4")]
		[Address(RVA = "0x3F12628", Offset = "0x3F0E628", VA = "0x3F12628")]
		private void Awake()
		{
		}

		[Token(Token = "0x60020B5")]
		[Address(RVA = "0x3F12810", Offset = "0x3F0E810", VA = "0x3F12810")]
		private void UpdateState(bool isEnable)
		{
		}

		[Token(Token = "0x60020B6")]
		[Address(RVA = "0x3F12844", Offset = "0x3F0E844", VA = "0x3F12844")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60020B7")]
		[Address(RVA = "0x3F128D8", Offset = "0x3F0E8D8", VA = "0x3F128D8")]
		public AudioBtnUI()
		{
		}
	}
}
