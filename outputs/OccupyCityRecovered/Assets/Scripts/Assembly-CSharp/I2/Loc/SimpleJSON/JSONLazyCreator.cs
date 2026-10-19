using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x2000DD3")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x40060F2")]
		[FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x40060F3")]
		[FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x17000E9D")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x60055D6")]
			[Address(RVA = "0x4335B80", Offset = "0x4331B80", VA = "0x4335B80", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055D7")]
			[Address(RVA = "0x4335BDC", Offset = "0x4331BDC", VA = "0x4335BDC", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000E9E")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x60055D8")]
			[Address(RVA = "0x4335C5C", Offset = "0x4331C5C", VA = "0x4335C5C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055D9")]
			[Address(RVA = "0x4335CC4", Offset = "0x4331CC4", VA = "0x4335CC4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000E9F")]
		public override int AsInt
		{
			[Token(Token = "0x60055E2")]
			[Address(RVA = "0x4335F24", Offset = "0x4331F24", VA = "0x4335F24", Slot = "18")]
			get
			{
				return default;
			}
			[Token(Token = "0x60055E3")]
			[Address(RVA = "0x4335FA0", Offset = "0x4331FA0", VA = "0x4335FA0", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000EA0")]
		public override float AsFloat
		{
			[Token(Token = "0x60055E4")]
			[Address(RVA = "0x4336020", Offset = "0x4332020", VA = "0x4336020", Slot = "20")]
			get
			{
				return default;
			}
			[Token(Token = "0x60055E5")]
			[Address(RVA = "0x433609C", Offset = "0x433209C", VA = "0x433609C", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000EA1")]
		public override double AsDouble
		{
			[Token(Token = "0x60055E6")]
			[Address(RVA = "0x433611C", Offset = "0x433211C", VA = "0x433611C", Slot = "22")]
			get
			{
				return default;
			}
			[Token(Token = "0x60055E7")]
			[Address(RVA = "0x4336198", Offset = "0x4332198", VA = "0x4336198", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000EA2")]
		public override bool AsBool
		{
			[Token(Token = "0x60055E8")]
			[Address(RVA = "0x4336218", Offset = "0x4332218", VA = "0x4336218", Slot = "24")]
			get
			{
				return default;
			}
			[Token(Token = "0x60055E9")]
			[Address(RVA = "0x4336294", Offset = "0x4332294", VA = "0x4336294", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000EA3")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x60055EA")]
			[Address(RVA = "0x4336314", Offset = "0x4332314", VA = "0x4336314", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EA4")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x60055EB")]
			[Address(RVA = "0x4336374", Offset = "0x4332374", VA = "0x4336374", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60055D3")]
		[Address(RVA = "0x4332DC0", Offset = "0x432EDC0", VA = "0x4332DC0")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x60055D4")]
		[Address(RVA = "0x4333ED8", Offset = "0x432FED8", VA = "0x4333ED8")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x60055D5")]
		[Address(RVA = "0x4335B2C", Offset = "0x4331B2C", VA = "0x4335B2C")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x60055DA")]
		[Address(RVA = "0x4335D4C", Offset = "0x4331D4C", VA = "0x4335D4C", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x60055DB")]
		[Address(RVA = "0x4335DCC", Offset = "0x4331DCC", VA = "0x4335DCC", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60055DC")]
		[Address(RVA = "0x4335E54", Offset = "0x4331E54", VA = "0x4335E54")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default;
		}

		[Token(Token = "0x60055DD")]
		[Address(RVA = "0x4335E6C", Offset = "0x4331E6C", VA = "0x4335E6C")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default;
		}

		[Token(Token = "0x60055DE")]
		[Address(RVA = "0x4335E84", Offset = "0x4331E84", VA = "0x4335E84", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x60055DF")]
		[Address(RVA = "0x4335E9C", Offset = "0x4331E9C", VA = "0x4335E9C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x60055E0")]
		[Address(RVA = "0x4335EA4", Offset = "0x4331EA4", VA = "0x4335EA4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60055E1")]
		[Address(RVA = "0x4335EE4", Offset = "0x4331EE4", VA = "0x4335EE4", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
}
