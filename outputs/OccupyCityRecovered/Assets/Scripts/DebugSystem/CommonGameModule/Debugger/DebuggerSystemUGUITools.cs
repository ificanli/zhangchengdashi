using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger
{
	[Token(Token = "0x2000010")]
	public static class DebuggerSystemUGUITools
	{
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x0")]
		public static string GetUACBuildIDAssemblyName;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x8")]
		public static string GetUACBuildIDTypeName;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x10")]
		public static string GetUACBuildIDMethodName;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x18")]
		private static string m_XYXDefineSymbol;

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x46314A0", Offset = "0x462D4A0", VA = "0x46314A0")]
		public static void InitUI(object obj, Transform root)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x46340B4", Offset = "0x46300B4", VA = "0x46340B4")]
		private static object GetUIObjByPath(UIPathAttribute pathAttribute, Transform root, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		private static T GetChildUI<T>(Transform root, string path) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x46341F8", Offset = "0x46301F8", VA = "0x46341F8")]
		private static Component GetChildUI(Transform root, string path, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x4634548", Offset = "0x4630548", VA = "0x4634548")]
		private static GameObject GetResourcesObj(string path)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x463464C", Offset = "0x463064C", VA = "0x463464C")]
		public static object GetResourcesObjComponent(string path, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x46347F0", Offset = "0x46307F0", VA = "0x46347F0")]
		private static string GetXYXDefineSymbol()
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x4635234", Offset = "0x4631234", VA = "0x4635234")]
		public static string GetPlatform()
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x46352EC", Offset = "0x46312EC", VA = "0x46352EC")]
		public static string GetPlatformRuntime()
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x46353A4", Offset = "0x46313A4", VA = "0x46353A4")]
		public static string GetAppBuildVersion()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x46353FC", Offset = "0x46313FC", VA = "0x46353FC")]
		public static string GetUacBuildID()
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x4635598", Offset = "0x4631598", VA = "0x4635598")]
		public static string GFGetUacBuildID()
		{
			return null;
		}
	}
}
