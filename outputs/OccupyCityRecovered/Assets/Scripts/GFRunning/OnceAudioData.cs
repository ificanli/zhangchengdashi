using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200002A")]
public class OnceAudioData
{
	[Token(Token = "0x200002B")]
	public class AudioList
	{
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x10")]
		public List<AudioInfo> AudioInfos;

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x707B998", Offset = "0x7077998", VA = "0x707B998")]
		public AudioList()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200002C")]
	public class AudioInfo
	{
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x18")]
		public string Length;

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x707B9A0", Offset = "0x70779A0", VA = "0x707B9A0")]
		public AudioInfo()
		{
		}
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x707B990", Offset = "0x7077990", VA = "0x707B990")]
	public OnceAudioData()
	{
	}
}
