using System.Runtime.CompilerServices;
using GameFramework;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000F90")]
	public class CustomTransmitterControl : ControlBase<CustomTransmitterControl>, IControl
	{
		[Token(Token = "0x4006B22")]
		[FieldOffset(Offset = "0x10")]
		public CustomTransmitter CustomTransmitter;

		[Token(Token = "0x4006B23")]
		[FieldOffset(Offset = "0x0")]
		private static string url;

		[Token(Token = "0x17000F9A")]
		public bool ActiveUpdate
		{
			[Token(Token = "0x6005D57")]
			[Address(RVA = "0x43B8D3C", Offset = "0x43B4D3C", VA = "0x43B8D3C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005D58")]
			[Address(RVA = "0x43B8D44", Offset = "0x43B4D44", VA = "0x43B8D44", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6005D52")]
		[Address(RVA = "0x43B704C", Offset = "0x43B304C", VA = "0x43B704C")]
		public void InitTransmitter(string baseUrl)
		{
		}

		[Token(Token = "0x6005D53")]
		[Address(RVA = "0x43B8C50", Offset = "0x43B4C50", VA = "0x43B8C50")]
		public static string GetUrl()
		{
			return null;
		}

		[Token(Token = "0x6005D54")]
		[Address(RVA = "0x43B8D30", Offset = "0x43B4D30", VA = "0x43B8D30", Slot = "6")]
		public void OnInit()
		{
		}

		[Token(Token = "0x6005D55")]
		[Address(RVA = "0x43B8D34", Offset = "0x43B4D34", VA = "0x43B8D34", Slot = "7")]
		public void Updata(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005D56")]
		[Address(RVA = "0x43B8D38", Offset = "0x43B4D38", VA = "0x43B8D38", Slot = "8")]
		public void OnDispose()
		{
		}

		[Token(Token = "0x6005D59")]
		[Address(RVA = "0x43B8D50", Offset = "0x43B4D50", VA = "0x43B8D50")]
		public CustomTransmitterControl()
		{
		}
	}
}
