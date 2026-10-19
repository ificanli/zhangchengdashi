using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000053")]
	public class NumberHandlers
	{
		[Token(Token = "0x2000054")]
		private class IntHandler : INumberHandler
		{
			[Token(Token = "0x17000091")]
			public float MinValue
			{
				[Token(Token = "0x60002DB")]
				[Address(RVA = "0x466F420", Offset = "0x466B420", VA = "0x466F420", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000092")]
			public float MaxValue
			{
				[Token(Token = "0x60002DC")]
				[Address(RVA = "0x466F42C", Offset = "0x466B42C", VA = "0x466F42C", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x466F438", Offset = "0x466B438", VA = "0x466F438", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NumberHandlers.IntHandler.TryParse RVA=0x466F438 Token=0x60002DD");
}

			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x466F4F0", Offset = "0x466B4F0", VA = "0x466F4F0", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default;
			}

			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x466F59C", Offset = "0x466B59C", VA = "0x466F59C", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return null;
			}

			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x466F614", Offset = "0x466B614", VA = "0x466F614", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				return default;
			}

			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x466F688", Offset = "0x466B688", VA = "0x466F688", Slot = "10")]
			public string ToString(object value)
			{
				return null;
			}

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x466F328", Offset = "0x466B328", VA = "0x466F328")]
			public IntHandler()
			{
			}
		}

		[Token(Token = "0x2000055")]
		private class UIntHandler : INumberHandler
		{
			[Token(Token = "0x17000093")]
			public float MinValue
			{
				[Token(Token = "0x60002E3")]
				[Address(RVA = "0x466F740", Offset = "0x466B740", VA = "0x466F740", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000094")]
			public float MaxValue
			{
				[Token(Token = "0x60002E4")]
				[Address(RVA = "0x466F748", Offset = "0x466B748", VA = "0x466F748", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x466F754", Offset = "0x466B754", VA = "0x466F754", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NumberHandlers.UIntHandler.TryParse RVA=0x466F754 Token=0x60002E5");
}

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x466F80C", Offset = "0x466B80C", VA = "0x466F80C", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default;
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x466F8B8", Offset = "0x466B8B8", VA = "0x466F8B8", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return null;
			}

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x466F928", Offset = "0x466B928", VA = "0x466F928", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				return default;
			}

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x466F99C", Offset = "0x466B99C", VA = "0x466F99C", Slot = "10")]
			public string ToString(object value)
			{
				return null;
			}

			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x466F360", Offset = "0x466B360", VA = "0x466F360")]
			public UIntHandler()
			{
			}
		}

		[Token(Token = "0x2000056")]
		private class LongHandler : INumberHandler
		{
			[Token(Token = "0x17000095")]
			public float MinValue
			{
				[Token(Token = "0x60002EB")]
				[Address(RVA = "0x466FA54", Offset = "0x466BA54", VA = "0x466FA54", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000096")]
			public float MaxValue
			{
				[Token(Token = "0x60002EC")]
				[Address(RVA = "0x466FA60", Offset = "0x466BA60", VA = "0x466FA60", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x466FA6C", Offset = "0x466BA6C", VA = "0x466FA6C", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NumberHandlers.LongHandler.TryParse RVA=0x466FA6C Token=0x60002ED");
}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x466FB2C", Offset = "0x466BB2C", VA = "0x466FB2C", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default;
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x466FBD8", Offset = "0x466BBD8", VA = "0x466FBD8", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return null;
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x466FC50", Offset = "0x466BC50", VA = "0x466FC50", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				return default;
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x466FCC4", Offset = "0x466BCC4", VA = "0x466FCC4", Slot = "10")]
			public string ToString(object value)
			{
				return null;
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x466F338", Offset = "0x466B338", VA = "0x466F338")]
			public LongHandler()
			{
			}
		}

		[Token(Token = "0x2000057")]
		private class ULongHandler : INumberHandler
		{
			[Token(Token = "0x17000097")]
			public float MinValue
			{
				[Token(Token = "0x60002F3")]
				[Address(RVA = "0x466FD7C", Offset = "0x466BD7C", VA = "0x466FD7C", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000098")]
			public float MaxValue
			{
				[Token(Token = "0x60002F4")]
				[Address(RVA = "0x466FD84", Offset = "0x466BD84", VA = "0x466FD84", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x466FD90", Offset = "0x466BD90", VA = "0x466FD90", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NumberHandlers.ULongHandler.TryParse RVA=0x466FD90 Token=0x60002F5");
}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x466FE50", Offset = "0x466BE50", VA = "0x466FE50", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default;
			}

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x466FEFC", Offset = "0x466BEFC", VA = "0x466FEFC", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return null;
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x466FF6C", Offset = "0x466BF6C", VA = "0x466FF6C", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				return default;
			}

			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x466FFE4", Offset = "0x466BFE4", VA = "0x466FFE4", Slot = "10")]
			public string ToString(object value)
			{
				return null;
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x466F368", Offset = "0x466B368", VA = "0x466F368")]
			public ULongHandler()
			{
			}
		}

		[Token(Token = "0x2000058")]
		private class ByteHandler : INumberHandler
		{
			[Token(Token = "0x17000099")]
			public float MinValue
			{
				[Token(Token = "0x60002FB")]
				[Address(RVA = "0x467009C", Offset = "0x466C09C", VA = "0x467009C", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700009A")]
			public float MaxValue
			{
				[Token(Token = "0x60002FC")]
				[Address(RVA = "0x46700A4", Offset = "0x466C0A4", VA = "0x46700A4", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x46700B0", Offset = "0x466C0B0", VA = "0x46700B0", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NumberHandlers.ByteHandler.TryParse RVA=0x46700B0 Token=0x60002FD");
}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x4670168", Offset = "0x466C168", VA = "0x4670168", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default;
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x4670214", Offset = "0x466C214", VA = "0x4670214", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return null;
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x4670280", Offset = "0x466C280", VA = "0x4670280", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				return default;
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x46702F4", Offset = "0x466C2F4", VA = "0x46702F4", Slot = "10")]
			public string ToString(object value)
			{
				return null;
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x466F348", Offset = "0x466B348", VA = "0x466F348")]
			public ByteHandler()
			{
			}
		}

		[Token(Token = "0x2000059")]
		private class SByteHandler : INumberHandler
		{
			[Token(Token = "0x1700009B")]
			public float MinValue
			{
				[Token(Token = "0x6000303")]
				[Address(RVA = "0x46703AC", Offset = "0x466C3AC", VA = "0x46703AC", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700009C")]
			public float MaxValue
			{
				[Token(Token = "0x6000304")]
				[Address(RVA = "0x46703B8", Offset = "0x466C3B8", VA = "0x46703B8", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x46703C4", Offset = "0x466C3C4", VA = "0x46703C4", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NumberHandlers.SByteHandler.TryParse RVA=0x46703C4 Token=0x6000305");
}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x467047C", Offset = "0x466C47C", VA = "0x467047C", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default;
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x4670528", Offset = "0x466C528", VA = "0x4670528", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return null;
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x467059C", Offset = "0x466C59C", VA = "0x467059C", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				return default;
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x4670610", Offset = "0x466C610", VA = "0x4670610", Slot = "10")]
			public string ToString(object value)
			{
				return null;
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x466F370", Offset = "0x466B370", VA = "0x466F370")]
			public SByteHandler()
			{
			}
		}

		[Token(Token = "0x200005A")]
		private class ShortHandler : INumberHandler
		{
			[Token(Token = "0x1700009D")]
			public float MinValue
			{
				[Token(Token = "0x600030B")]
				[Address(RVA = "0x46706C8", Offset = "0x466C6C8", VA = "0x46706C8", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700009E")]
			public float MaxValue
			{
				[Token(Token = "0x600030C")]
				[Address(RVA = "0x46706D4", Offset = "0x466C6D4", VA = "0x46706D4", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x46706E0", Offset = "0x466C6E0", VA = "0x46706E0", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NumberHandlers.ShortHandler.TryParse RVA=0x46706E0 Token=0x600030D");
}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x4670798", Offset = "0x466C798", VA = "0x4670798", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default;
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x4670844", Offset = "0x466C844", VA = "0x4670844", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return null;
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x46708B8", Offset = "0x466C8B8", VA = "0x46708B8", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				return default;
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x467092C", Offset = "0x466C92C", VA = "0x467092C", Slot = "10")]
			public string ToString(object value)
			{
				return null;
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x466F358", Offset = "0x466B358", VA = "0x466F358")]
			public ShortHandler()
			{
			}
		}

		[Token(Token = "0x200005B")]
		private class UShortHandler : INumberHandler
		{
			[Token(Token = "0x1700009F")]
			public float MinValue
			{
				[Token(Token = "0x6000313")]
				[Address(RVA = "0x46709E4", Offset = "0x466C9E4", VA = "0x46709E4", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000A0")]
			public float MaxValue
			{
				[Token(Token = "0x6000314")]
				[Address(RVA = "0x46709EC", Offset = "0x466C9EC", VA = "0x46709EC", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x46709F8", Offset = "0x466C9F8", VA = "0x46709F8", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NumberHandlers.UShortHandler.TryParse RVA=0x46709F8 Token=0x6000315");
}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x4670AB0", Offset = "0x466CAB0", VA = "0x4670AB0", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default;
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x4670B5C", Offset = "0x466CB5C", VA = "0x4670B5C", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return null;
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x4670BC8", Offset = "0x466CBC8", VA = "0x4670BC8", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				return default;
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x4670C3C", Offset = "0x466CC3C", VA = "0x4670C3C", Slot = "10")]
			public string ToString(object value)
			{
				return null;
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x466F378", Offset = "0x466B378", VA = "0x466F378")]
			public UShortHandler()
			{
			}
		}

		[Token(Token = "0x200005C")]
		private class CharHandler : INumberHandler
		{
			[Token(Token = "0x170000A1")]
			public float MinValue
			{
				[Token(Token = "0x600031B")]
				[Address(RVA = "0x4670CF4", Offset = "0x466CCF4", VA = "0x4670CF4", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000A2")]
			public float MaxValue
			{
				[Token(Token = "0x600031C")]
				[Address(RVA = "0x4670CFC", Offset = "0x466CCFC", VA = "0x4670CFC", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x4670D08", Offset = "0x466CD08", VA = "0x4670D08", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NumberHandlers.CharHandler.TryParse RVA=0x4670D08 Token=0x600031D");
}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x4670D9C", Offset = "0x466CD9C", VA = "0x4670D9C", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default;
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x4670E48", Offset = "0x466CE48", VA = "0x4670E48", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return null;
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x4670EB4", Offset = "0x466CEB4", VA = "0x4670EB4", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				return default;
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x4670F28", Offset = "0x466CF28", VA = "0x4670F28", Slot = "10")]
			public string ToString(object value)
			{
				return null;
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x466F350", Offset = "0x466B350", VA = "0x466F350")]
			public CharHandler()
			{
			}
		}

		[Token(Token = "0x200005D")]
		private class FloatHandler : INumberHandler
		{
			[Token(Token = "0x170000A3")]
			public float MinValue
			{
				[Token(Token = "0x6000323")]
				[Address(RVA = "0x4671000", Offset = "0x466D000", VA = "0x4671000", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000A4")]
			public float MaxValue
			{
				[Token(Token = "0x6000324")]
				[Address(RVA = "0x467100C", Offset = "0x466D00C", VA = "0x467100C", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x4671018", Offset = "0x466D018", VA = "0x4671018", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NumberHandlers.FloatHandler.TryParse RVA=0x4671018 Token=0x6000325");
}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x46710D0", Offset = "0x466D0D0", VA = "0x46710D0", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default;
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x4671184", Offset = "0x466D184", VA = "0x4671184", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return null;
			}

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x46711E4", Offset = "0x466D1E4", VA = "0x46711E4", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				return default;
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x4671254", Offset = "0x466D254", VA = "0x4671254", Slot = "10")]
			public string ToString(object value)
			{
				return null;
			}

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x466F330", Offset = "0x466B330", VA = "0x466F330")]
			public FloatHandler()
			{
			}
		}

		[Token(Token = "0x200005E")]
		private class DoubleHandler : INumberHandler
		{
			[Token(Token = "0x170000A5")]
			public float MinValue
			{
				[Token(Token = "0x600032B")]
				[Address(RVA = "0x467130C", Offset = "0x466D30C", VA = "0x467130C", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000A6")]
			public float MaxValue
			{
				[Token(Token = "0x600032C")]
				[Address(RVA = "0x4671318", Offset = "0x466D318", VA = "0x4671318", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x4671324", Offset = "0x466D324", VA = "0x4671324", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NumberHandlers.DoubleHandler.TryParse RVA=0x4671324 Token=0x600032D");
}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x46713E4", Offset = "0x466D3E4", VA = "0x46713E4", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default;
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x4671498", Offset = "0x466D498", VA = "0x4671498", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return null;
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0x46714FC", Offset = "0x466D4FC", VA = "0x46714FC", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				return default;
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x4671570", Offset = "0x466D570", VA = "0x4671570", Slot = "10")]
			public string ToString(object value)
			{
				return null;
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x466F340", Offset = "0x466B340", VA = "0x466F340")]
			public DoubleHandler()
			{
			}
		}

		[Token(Token = "0x200005F")]
		private class DecimalHandler : INumberHandler
		{
			[Token(Token = "0x170000A7")]
			public float MinValue
			{
				[Token(Token = "0x6000333")]
				[Address(RVA = "0x4671628", Offset = "0x466D628", VA = "0x4671628", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000A8")]
			public float MaxValue
			{
				[Token(Token = "0x6000334")]
				[Address(RVA = "0x4671634", Offset = "0x466D634", VA = "0x4671634", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x4671640", Offset = "0x466D640", VA = "0x4671640", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NumberHandlers.DecimalHandler.TryParse RVA=0x4671640 Token=0x6000335");
}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x4671734", Offset = "0x466D734", VA = "0x4671734", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default;
			}

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x4671800", Offset = "0x466D800", VA = "0x4671800", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return null;
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x46718A0", Offset = "0x466D8A0", VA = "0x46718A0", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				return default;
			}

			[Token(Token = "0x6000339")]
			[Address(RVA = "0x467192C", Offset = "0x466D92C", VA = "0x467192C", Slot = "10")]
			public string ToString(object value)
			{
				return null;
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0x466F380", Offset = "0x466B380", VA = "0x466F380")]
			public DecimalHandler()
			{
			}
		}

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, INumberHandler> handlers;

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x4664150", Offset = "0x4660150", VA = "0x4664150")]
		public static INumberHandler Get(Type type)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x466F388", Offset = "0x466B388", VA = "0x466F388")]
		public NumberHandlers()
		{
		}
	}
}
