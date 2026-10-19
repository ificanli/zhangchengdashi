using System;
using Il2CppDummyDll;

[Token(Token = "0x200008C")]
public static class JsonUtilityArrays
{
	[Serializable]
	[Token(Token = "0x200008D")]
	private class Wrapper<T>
	{
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x0")]
		public T[] Items;

		[Token(Token = "0x60002D5")]
		public Wrapper()
		{
		}
	}

	[Token(Token = "0x60002D2")]
	public static T[] FromJson<T>(string json)
	{
		return null;
	}

	[Token(Token = "0x60002D3")]
	public static string ToJson<T>(T[] array)
	{
		return null;
	}

	[Token(Token = "0x60002D4")]
	public static string ToJson<T>(T[] array, bool prettyPrint)
	{
		return null;
	}
}
