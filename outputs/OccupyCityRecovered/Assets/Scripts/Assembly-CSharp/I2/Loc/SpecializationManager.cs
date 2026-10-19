using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D5C")]
	public class SpecializationManager : BaseSpecializationManager
	{
		[Token(Token = "0x4005F34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SpecializationManager Singleton;

		[Token(Token = "0x60052A7")]
		[Address(RVA = "0x43034E8", Offset = "0x42FF4E8", VA = "0x43034E8")]
		private SpecializationManager()
		{
		}

		[Token(Token = "0x60052A8")]
		[Address(RVA = "0x430350C", Offset = "0x42FF50C", VA = "0x430350C")]
		public static string GetSpecializedText(string text, [Optional] string specialization)
		{
			return null;
		}

		[Token(Token = "0x60052A9")]
		[Address(RVA = "0x430370C", Offset = "0x42FF70C", VA = "0x430370C")]
		public static string SetSpecializedText(string text, string newText, string specialization)
		{
			return null;
		}

		[Token(Token = "0x60052AA")]
		[Address(RVA = "0x4303A94", Offset = "0x42FFA94", VA = "0x4303A94")]
		public static string SetSpecializedText(Dictionary<string, string> specializations)
		{
			return null;
		}

		[Token(Token = "0x60052AB")]
		[Address(RVA = "0x430382C", Offset = "0x42FF82C", VA = "0x430382C")]
		public static Dictionary<string, string> GetSpecializations(string text, [Optional] Dictionary<string, string> buffer)
		{
			return null;
		}

		[Token(Token = "0x60052AC")]
		[Address(RVA = "0x4303D68", Offset = "0x42FFD68", VA = "0x4303D68")]
		public static void AppendSpecializations(string text, [Optional] List<string> list)
		{
		}
	}
}
