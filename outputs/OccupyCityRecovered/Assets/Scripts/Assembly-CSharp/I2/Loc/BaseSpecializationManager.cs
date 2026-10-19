using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D5B")]
	public class BaseSpecializationManager
	{
		[Token(Token = "0x4005F32")]
		[FieldOffset(Offset = "0x10")]
		public string[] mSpecializations;

		[Token(Token = "0x4005F33")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> mSpecializationsFallbacks;

		[Token(Token = "0x60052A2")]
		[Address(RVA = "0x4302FF4", Offset = "0x42FEFF4", VA = "0x4302FF4", Slot = "4")]
		public virtual void InitializeSpecializations()
		{
		}

		[Token(Token = "0x60052A3")]
		[Address(RVA = "0x43033D4", Offset = "0x42FF3D4", VA = "0x43033D4", Slot = "5")]
		public virtual string GetCurrentSpecialization()
		{
			return null;
		}

		[Token(Token = "0x60052A4")]
		[Address(RVA = "0x4303430", Offset = "0x42FF430", VA = "0x4303430")]
		private bool IsTouchInputSupported()
		{
			return default;
		}

		[Token(Token = "0x60052A5")]
		[Address(RVA = "0x4303438", Offset = "0x42FF438", VA = "0x4303438", Slot = "6")]
		public virtual string GetFallbackSpecialization(string specialization)
		{
			return null;
		}

		[Token(Token = "0x60052A6")]
		[Address(RVA = "0x43034E0", Offset = "0x42FF4E0", VA = "0x43034E0")]
		public BaseSpecializationManager()
		{
		}
	}
}
