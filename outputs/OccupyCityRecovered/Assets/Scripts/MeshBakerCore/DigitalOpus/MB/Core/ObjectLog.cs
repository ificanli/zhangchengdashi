using Il2CppDummyDll;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000040")]
	public class ObjectLog
	{
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x10")]
		private int pos;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x18")]
		private string[] logMessages;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x74480A4", Offset = "0x74440A4", VA = "0x74480A4")]
		private void _CacheLogMessage(string msg)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x74480FC", Offset = "0x74440FC", VA = "0x74480FC")]
		public ObjectLog(short bufferSize)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x7448164", Offset = "0x7444164", VA = "0x7448164")]
		public void Log(MB2_LogLevel l, string msg, MB2_LogLevel currentThreshold)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x7448198", Offset = "0x7444198", VA = "0x7448198")]
		public void Error(string msg, params object[] args)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x74481BC", Offset = "0x74441BC", VA = "0x74481BC")]
		public void Warn(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x74481E0", Offset = "0x74441E0", VA = "0x74481E0")]
		public void Info(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x7448204", Offset = "0x7444204", VA = "0x7448204")]
		public void LogDebug(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x7448228", Offset = "0x7444228", VA = "0x7448228")]
		public void Trace(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x744824C", Offset = "0x744424C", VA = "0x744824C")]
		public string Dump()
		{
			return null;
		}
	}
}
