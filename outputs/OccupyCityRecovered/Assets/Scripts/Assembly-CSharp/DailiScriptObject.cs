using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200001F")]
public class DailiScriptObject<T> : ScriptableObject where T : DailiScriptObject<T>
{
	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x0")]
	private static T _instance;

	[Token(Token = "0x4000096")]
	private const string SOFolder = "Assets/DailiConfig/Resources/";

	[Token(Token = "0x17000007")]
	public static T Instance
	{
		[Token(Token = "0x600007D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	public static string ResourcesPath
	{
		[Token(Token = "0x600007E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000009")]
	public static string SOPath
	{
		[Token(Token = "0x600007F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000080")]
	public DailiScriptObject()
	{
	}
}
