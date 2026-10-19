using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace ToolModule
{
	[Token(Token = "0x2000193")]
	public abstract class DebugExtend
	{
		[Token(Token = "0x4001AB0")]
		[FieldOffset(Offset = "0x0")]
		private static bool _isEnableDebugOnOther;

		[Token(Token = "0x4001AB1")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string GreenColorString;

		[Token(Token = "0x4001AB2")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string RedColorString;

		[Token(Token = "0x4001AB3")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string YellowColorString;

		[Token(Token = "0x17000093")]
		public static bool IsEnableDebugOnOther
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x3F7D030", Offset = "0x3F79030", VA = "0x3F7D030")]
			get
			{
				return default;
			}
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x3F7D088", Offset = "0x3F79088", VA = "0x3F7D088")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		private static bool IsEnable
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x3F7D0E8", Offset = "0x3F790E8", VA = "0x3F7D0E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x3F7D140", Offset = "0x3F79140", VA = "0x3F7D140")]
		[Conditional("UNITY_EDITOR")]
		private static void Log(object message, Color color)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x3F7D30C", Offset = "0x3F7930C", VA = "0x3F7D30C")]
		[Conditional("UNITY_EDITOR")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x3F7D4BC", Offset = "0x3F794BC", VA = "0x3F7D4BC")]
		[Conditional("UNITY_EDITOR")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x3F7D66C", Offset = "0x3F7966C", VA = "0x3F7D66C")]
		[Conditional("UNITY_EDITOR")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x3F7D81C", Offset = "0x3F7981C", VA = "0x3F7D81C")]
		public static void LogCompare(object message)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x3F7D968", Offset = "0x3F79968", VA = "0x3F7D968")]
		public static void LogCompareError(object message)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x3F7DB14", Offset = "0x3F79B14", VA = "0x3F7DB14")]
		protected DebugExtend()
		{
		}
	}
}
