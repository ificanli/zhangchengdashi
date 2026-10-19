using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	[Token(Token = "0x2000009")]
	public struct SpiralOptions : IPlugOptions
	{
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x0")]
		public float depth;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x4")]
		public float frequency;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x8")]
		public float speed;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0xC")]
		public SpiralMode mode;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x10")]
		public bool snapping;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x14")]
		internal float unit;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x18")]
		internal Quaternion axisQ;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x46ADF08", Offset = "0x46A9F08", VA = "0x46ADF08", Slot = "4")]
		public void Reset()
		{
		}
	}
}
