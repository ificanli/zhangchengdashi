using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200001A")]
public class LTPlayerprefs : MonoBehaviour
{
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x3D024B4", Offset = "0x3CFE4B4", VA = "0x3D024B4")]
	public static bool HasKey(string key)
	{
		return default;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x3D024BC", Offset = "0x3CFE4BC", VA = "0x3D024BC")]
	public static void SetInt(string key, int value)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x3D024C4", Offset = "0x3CFE4C4", VA = "0x3D024C4")]
	public static int GetInt(string key)
	{
		return default;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x3D024CC", Offset = "0x3CFE4CC", VA = "0x3D024CC")]
	public static int GetInt(string key, int defaultValue)
	{
		return default;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x3D024D4", Offset = "0x3CFE4D4", VA = "0x3D024D4")]
	public static void SetString(string key, string value)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x3D024DC", Offset = "0x3CFE4DC", VA = "0x3D024DC")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x3D024E4", Offset = "0x3CFE4E4", VA = "0x3D024E4")]
	public static string GetString(string key, string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x3D024EC", Offset = "0x3CFE4EC", VA = "0x3D024EC")]
	public static void SetFloat(string key, float value)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x3D024F4", Offset = "0x3CFE4F4", VA = "0x3D024F4")]
	public static float GetFloat(string key)
	{
		return default;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x3D024FC", Offset = "0x3CFE4FC", VA = "0x3D024FC")]
	public static float GetFloat(string key, float defaultValue)
	{
		return default;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x3D02504", Offset = "0x3CFE504", VA = "0x3D02504")]
	public LTPlayerprefs()
	{
	}
}
