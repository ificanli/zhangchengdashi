using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

[Token(Token = "0x2000003")]
public static class RenderPipelineChecker
{
	[Token(Token = "0x4000003")]
	private const string HDRP_PACKAGE = "HDRenderPipelineAsset";

	[Token(Token = "0x4000004")]
	private const string URP_PACKAGE = "UniversalRenderPipelineAsset";

	[Token(Token = "0x17000003")]
	public static bool IsHDRP
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3CEB48C", Offset = "0x3CE748C", VA = "0x3CEB48C")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3CEB4D4", Offset = "0x3CE74D4", VA = "0x3CEB4D4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public static bool IsURP
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x3CEB524", Offset = "0x3CE7524", VA = "0x3CEB524")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x3CEB56C", Offset = "0x3CE756C", VA = "0x3CEB56C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public static bool IsStandardRP
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3CEB5BC", Offset = "0x3CE75BC", VA = "0x3CEB5BC")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3CEB604", Offset = "0x3CE7604", VA = "0x3CEB604")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x3CEB654", Offset = "0x3CE7654", VA = "0x3CEB654")]
	public static void RefreshData()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x3CEB7A8", Offset = "0x3CE77A8", VA = "0x3CEB7A8")]
	public static bool DoesTypeExist(string className)
	{
		return default;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3CEBB1C", Offset = "0x3CE7B1C", VA = "0x3CEBB1C")]
	public static IEnumerable<Type> GetTypesSafe(Assembly assembly)
	{
		return null;
	}
}
