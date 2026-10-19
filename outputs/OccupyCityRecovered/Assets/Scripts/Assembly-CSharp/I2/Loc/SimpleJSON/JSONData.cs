using System.IO;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x2000DD2")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x40060F1")]
		[FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x17000E9C")]
		public override string Value
		{
			[Token(Token = "0x60055C9")]
			[Address(RVA = "0x43356A0", Offset = "0x43316A0", VA = "0x43356A0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055CA")]
			[Address(RVA = "0x43356A8", Offset = "0x43316A8", VA = "0x43356A8", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60055CB")]
		[Address(RVA = "0x43356B0", Offset = "0x43316B0", VA = "0x43356B0")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x60055CC")]
		[Address(RVA = "0x43356D8", Offset = "0x43316D8", VA = "0x43356D8")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x60055CD")]
		[Address(RVA = "0x4335710", Offset = "0x4331710", VA = "0x4335710")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x60055CE")]
		[Address(RVA = "0x4335748", Offset = "0x4331748", VA = "0x4335748")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x60055CF")]
		[Address(RVA = "0x4335780", Offset = "0x4331780", VA = "0x4335780")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x60055D0")]
		[Address(RVA = "0x43357B8", Offset = "0x43317B8", VA = "0x43357B8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60055D1")]
		[Address(RVA = "0x4335814", Offset = "0x4331814", VA = "0x4335814", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60055D2")]
		[Address(RVA = "0x4335870", Offset = "0x4331870", VA = "0x4335870", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
}
