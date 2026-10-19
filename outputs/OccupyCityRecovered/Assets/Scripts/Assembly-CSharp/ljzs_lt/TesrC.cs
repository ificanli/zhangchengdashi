using System.Runtime.CompilerServices;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Token(Token = "0x2000F4B")]
	public class TesrC : ControlBase<TesrC>, IControl
	{
		[Token(Token = "0x40069B5")]
		[FieldOffset(Offset = "0x14")]
		public int RedDotTest1Count;

		[Token(Token = "0x40069B6")]
		[FieldOffset(Offset = "0x18")]
		public int RedDotTest2Count;

		[Token(Token = "0x40069B7")]
		[FieldOffset(Offset = "0x1C")]
		private int Timer1;

		[Token(Token = "0x40069B8")]
		[FieldOffset(Offset = "0x20")]
		private int Timer2;

		[Token(Token = "0x40069B9")]
		[FieldOffset(Offset = "0x24")]
		private int Timer3;

		[Token(Token = "0x17000F73")]
		public bool ActiveUpdate
		{
			[Token(Token = "0x6005B76")]
			[Address(RVA = "0x439D36C", Offset = "0x439936C", VA = "0x439D36C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005B77")]
			[Address(RVA = "0x439D374", Offset = "0x4399374", VA = "0x439D374", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6005B78")]
		[Address(RVA = "0x439D380", Offset = "0x4399380", VA = "0x439D380", Slot = "6")]
		public void OnInit()
		{
		}

		[Token(Token = "0x6005B79")]
		[Address(RVA = "0x439D490", Offset = "0x4399490", VA = "0x439D490")]
		private void EverSce()
		{
		}

		[Token(Token = "0x6005B7A")]
		[Address(RVA = "0x439D4F8", Offset = "0x43994F8", VA = "0x439D4F8")]
		private void EverM()
		{
		}

		[Token(Token = "0x6005B7B")]
		[Address(RVA = "0x439D560", Offset = "0x4399560", VA = "0x439D560")]
		private void Complete()
		{
		}

		[Token(Token = "0x6005B7C")]
		[Address(RVA = "0x439D5C8", Offset = "0x43995C8", VA = "0x439D5C8")]
		private void EverySce()
		{
		}

		[Token(Token = "0x6005B7D")]
		[Address(RVA = "0x439D630", Offset = "0x4399630", VA = "0x439D630", Slot = "7")]
		public void Updata(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005B7E")]
		[Address(RVA = "0x439D768", Offset = "0x4399768", VA = "0x439D768", Slot = "8")]
		public void OnDispose()
		{
		}

		[Token(Token = "0x6005B7F")]
		[Address(RVA = "0x439D834", Offset = "0x4399834", VA = "0x439D834")]
		public TesrC()
		{
		}
	}
}
