using Il2CppDummyDll;

namespace YYBTool
{
	[Token(Token = "0x2000650")]
	public class DeviceInfo
	{
		[Token(Token = "0x2000651")]
		public enum DeviceDPIType
		{
			[Token(Token = "0x4003379")]
			Wide = 0,
			[Token(Token = "0x400337A")]
			Normal = 1,
			[Token(Token = "0x400337B")]
			Narrow = 2,
			[Token(Token = "0x400337C")]
			SuperNarrow = 3,
			[Token(Token = "0x400337D")]
			SuperSuperNarrow = 4
		}

		[Token(Token = "0x170001CF")]
		public static DeviceDPIType CurrentDeviceDpi
		{
			[Token(Token = "0x600213E")]
			[Address(RVA = "0x3F2269C", Offset = "0x3F1E69C", VA = "0x3F2269C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D0")]
		public static bool IsEditor
		{
			[Token(Token = "0x600213F")]
			[Address(RVA = "0x3F22760", Offset = "0x3F1E760", VA = "0x3F22760")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6002140")]
		[Address(RVA = "0x3F22800", Offset = "0x3F1E800", VA = "0x3F22800")]
		public DeviceInfo()
		{
		}
	}
}
