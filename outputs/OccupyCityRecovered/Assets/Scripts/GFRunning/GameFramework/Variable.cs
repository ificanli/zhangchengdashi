using System;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x2000341")]
	public abstract class Variable<T> : Variable
	{
		[Token(Token = "0x40019C0")]
		[FieldOffset(Offset = "0x0")]
		private T _0083Q_00B6oY_00B4;

		[Token(Token = "0x170010DA")]
		public override Type Type
		{
			[Token(Token = "0x6005711")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010DB")]
		public T Value
		{
			[Token(Token = "0x6005712")]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Variable.Value.get RVA= Token=0x6005712");
}
			[Token(Token = "0x6005713")]
			set
			{
			}
		}

		[Token(Token = "0x600570F")]
		protected Variable()
		{
		}

		[Token(Token = "0x6005710")]
		protected Variable(T _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6005714")]
		public override object GetValue()
		{
			return null;
		}

		[Token(Token = "0x6005715")]
		public override void SetValue(object _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6005716")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005717")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000342")]
	public abstract class Variable
	{
		[Token(Token = "0x170010DC")]
		public abstract Type Type
		{
			[Token(Token = "0x6005719")]
			get;
		}

		[Token(Token = "0x6005718")]
		[Address(RVA = "0x71656B8", Offset = "0x71616B8", VA = "0x71656B8")]
		protected Variable()
		{
		}

		[Token(Token = "0x600571A")]
		public abstract object GetValue();

		[Token(Token = "0x600571B")]
		public abstract void SetValue(object _00A3_0092T_007E_00ABc);

		[Token(Token = "0x600571C")]
		public abstract void Reset();
	}
}
