using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000029")]
public class SingletonAnimation<T> : MonoBehaviour where T : MonoBehaviour
{
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x0")]
	private static T _instance;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x0")]
	private static object _lock;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x0")]
	private static bool applicationIsQuitting;

	[Token(Token = "0x1700000B")]
	public static T Instance
	{
		[Token(Token = "0x60000B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B9")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x60000BA")]
	public static bool IsDestroy()
	{
		return default;
	}

	[Token(Token = "0x60000BB")]
	public SingletonAnimation()
	{
	}
}
