using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x20003AC")]
	public static class TimeHelper
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003AD")]
		private struct DV_0083_00A8_005Dx : IAsyncStateMachine
		{
			[Token(Token = "0x4001BC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001BC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001BC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float sec;

			[Token(Token = "0x4001BC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action act;

			[Token(Token = "0x4001BC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6005D3C")]
			[Address(RVA = "0x71C2618", Offset = "0x71BE618", VA = "0x71C2618", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005D3D")]
			[Address(RVA = "0x71C2830", Offset = "0x71BE830", VA = "0x71C2830", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001BBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int[] _00B3_0090_009B_0090_009F_00AB;

		[Token(Token = "0x17001131")]
		private static DateTime ª_00ADi_007E_00A0_008B
		{
			[Token(Token = "0x6005D29")]
			[Address(RVA = "0x71C1028", Offset = "0x71BD028", VA = "0x71C1028")]
			get
			{
				return _00B9HGUAV();
			}
		}

		[Token(Token = "0x6005D29")]
		[Address(RVA = "0x71C1028", Offset = "0x71BD028", VA = "0x71C1028")]
		private static DateTime _00B9HGUAV()
		{
			return default;
		}

		[Token(Token = "0x6005D2A")]
		[Address(RVA = "0x71C1080", Offset = "0x71BD080", VA = "0x71C1080")]
		[AsyncStateMachine(typeof(global::GameFramework.TimeHelper.DV_0083_00A8_005Dx))]
		public static void Delay(float _00BFq_00BF_007C_00AFJ, Action _008AÀrwV_0098)
		{
		}

		[Token(Token = "0x6005D2B")]
		[Address(RVA = "0x71C111C", Offset = "0x71BD11C", VA = "0x71C111C")]
		[Obsolete("时间戳存储推荐使用long，ToTimestampLong")]
		public static int ToTimestamp(this DateTime _00A9_008ETG_0095_00B7)
		{
			return default;
		}

		[Token(Token = "0x6005D2C")]
		[Address(RVA = "0x71C1240", Offset = "0x71BD240", VA = "0x71C1240")]
		[Obsolete("时间戳存储推荐使用long")]
		public static DateTime ToDateTime(this int _0060_00BB_00A7uQD)
		{
			return default;
		}

		[Token(Token = "0x6005D2D")]
		[Address(RVA = "0x71C1314", Offset = "0x71BD314", VA = "0x71C1314")]
		[Obsolete("时间戳存储推荐使用long")]
		public static string ToDateTimeString(this int _0060_00BB_00A7uQD)
		{
			return null;
		}

		[Token(Token = "0x6005D2E")]
		[Address(RVA = "0x71C13FC", Offset = "0x71BD3FC", VA = "0x71C13FC")]
		[Obsolete("时间戳存储推荐使用long")]
		public static string ToLongTimeString(this int _0060_00BB_00A7uQD)
		{
			return null;
		}

		[Token(Token = "0x6005D2F")]
		[Address(RVA = "0x71C14FC", Offset = "0x71BD4FC", VA = "0x71C14FC")]
		[Obsolete("时间戳存储推荐使用long")]
		public static string ToHHMMSS(this int _00BFq_00BF_007C_00AFJ)
		{
			return null;
		}

		[Token(Token = "0x6005D30")]
		[Address(RVA = "0x71C167C", Offset = "0x71BD67C", VA = "0x71C167C")]
		[Obsolete("时间戳存储推荐使用long")]
		public static string ToDDHHMMSS(this int _00BFq_00BF_007C_00AFJ)
		{
			return null;
		}

		[Token(Token = "0x6005D31")]
		[Address(RVA = "0x71C1A58", Offset = "0x71BDA58", VA = "0x71C1A58")]
		[Obsolete("时间戳存储推荐使用long")]
		public static int[] ToDDHHMMSSByArray(this int _00BFq_00BF_007C_00AFJ)
		{
			return null;
		}

		[Token(Token = "0x6005D32")]
		[Address(RVA = "0x71C1BF4", Offset = "0x71BDBF4", VA = "0x71C1BF4")]
		[Obsolete("时间戳存储推荐使用long")]
		public static string MSecondToString(this int M_009F_0080_00A4A_00A4)
		{
			return null;
		}

		[Token(Token = "0x6005D33")]
		[Address(RVA = "0x71C1DD8", Offset = "0x71BDDD8", VA = "0x71C1DD8")]
		[Obsolete("时间戳存储推荐使用long")]
		public static string ToMMSS(this int[] _00A9_008ETG_0095_00B7)
		{
			return null;
		}

		[Token(Token = "0x6005D34")]
		[Address(RVA = "0x71C1EB4", Offset = "0x71BDEB4", VA = "0x71C1EB4")]
		public static long ToTimestampLong(this DateTime _00A9_008ETG_0095_00B7)
		{
			return default;
		}

		[Token(Token = "0x6005D35")]
		[Address(RVA = "0x71C1FD8", Offset = "0x71BDFD8", VA = "0x71C1FD8")]
		public static DateTime ToDateTime(this long _0060_00BB_00A7uQD)
		{
			return default;
		}

		[Token(Token = "0x6005D36")]
		[Address(RVA = "0x71C20AC", Offset = "0x71BE0AC", VA = "0x71C20AC")]
		public static string ToDateTimeString(this long _0060_00BB_00A7uQD)
		{
			return null;
		}

		[Token(Token = "0x6005D37")]
		[Address(RVA = "0x71C2194", Offset = "0x71BE194", VA = "0x71C2194")]
		public static string ToLongTimeString(this long _0060_00BB_00A7uQD)
		{
			return null;
		}

		[Token(Token = "0x6005D38")]
		[Address(RVA = "0x71C2294", Offset = "0x71BE294", VA = "0x71C2294")]
		public static string ToSDKNotificationData(float _005E_0060_0092x_005B_008D = 0f, float _0090_00B3_00A5AlW = 0f, float _0088_008CL_00B4CT = 0f, float F_00A9_00A3hªM = 0f)
		{
			return null;
		}

		[Token(Token = "0x6005D39")]
		[Address(RVA = "0x71C2478", Offset = "0x71BE478", VA = "0x71C2478")]
		public static string ToSDKNotificationFixedData(int B_0091_00B3_0089_00AC_00AC = 0, int ª_005B_0091_00A0_0098V = 0, int _0080_009D_0086t_00ABR = 0, int I_00AE_00AB_00A8Âv = 0)
		{
			return null;
		}

		[Token(Token = "0x6005D3A")]
		[Address(RVA = "0x71C2404", Offset = "0x71BE404", VA = "0x71C2404")]
		public static string ToSDKNotificationformat(this DateTime _00ADº_009Bjz_005E)
		{
			return null;
		}
	}
}
