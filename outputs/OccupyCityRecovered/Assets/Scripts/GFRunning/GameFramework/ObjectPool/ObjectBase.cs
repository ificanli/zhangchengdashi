using System;
using Il2CppDummyDll;

namespace GameFramework.ObjectPool
{
	[Token(Token = "0x200045B")]
	public abstract class ObjectBase
	{
		[Token(Token = "0x4001E2E")]
		[FieldOffset(Offset = "0x10")]
		private readonly string g_0085eq_00BC_005E;

		[Token(Token = "0x4001E2F")]
		[FieldOffset(Offset = "0x18")]
		private readonly object _00A4lCsfo;

		[Token(Token = "0x4001E30")]
		[FieldOffset(Offset = "0x20")]
		private int Á_00B4ÂBj_00AE;

		[Token(Token = "0x4001E31")]
		[FieldOffset(Offset = "0x24")]
		private bool _0093º_00A1_00A3ºl;

		[Token(Token = "0x4001E32")]
		[FieldOffset(Offset = "0x28")]
		private int _00B9W_0088N_009AC;

		[Token(Token = "0x4001E33")]
		[FieldOffset(Offset = "0x30")]
		private DateTime _0099V_007B_00A3rt;

		[Token(Token = "0x170011AE")]
		public string Name
		{
			[Token(Token = "0x6006AD7")]
			[Address(RVA = "0x7282738", Offset = "0x727E738", VA = "0x7282738")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011AF")]
		public object Target
		{
			[Token(Token = "0x6006AD8")]
			[Address(RVA = "0x7282740", Offset = "0x727E740", VA = "0x7282740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011B0")]
		public virtual int HashCode
		{
			[Token(Token = "0x6006AD9")]
			[Address(RVA = "0x7282748", Offset = "0x727E748", VA = "0x7282748", Slot = "4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006ADA")]
			[Address(RVA = "0x728277C", Offset = "0x727E77C", VA = "0x728277C", Slot = "5")]
			protected set
			{
			}
		}

		[Token(Token = "0x170011B1")]
		public bool Locked
		{
			[Token(Token = "0x6006ADB")]
			[Address(RVA = "0x7282784", Offset = "0x727E784", VA = "0x7282784")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006ADC")]
			[Address(RVA = "0x728278C", Offset = "0x727E78C", VA = "0x728278C")]
			set
			{
			}
		}

		[Token(Token = "0x170011B2")]
		public int Priority
		{
			[Token(Token = "0x6006ADD")]
			[Address(RVA = "0x7282798", Offset = "0x727E798", VA = "0x7282798")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006ADE")]
			[Address(RVA = "0x72827A0", Offset = "0x727E7A0", VA = "0x72827A0")]
			set
			{
			}
		}

		[Token(Token = "0x170011B3")]
		public DateTime LastUseTime
		{
			[Token(Token = "0x6006ADF")]
			[Address(RVA = "0x72827A8", Offset = "0x727E7A8", VA = "0x72827A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006AE0")]
			[Address(RVA = "0x72827B0", Offset = "0x727E7B0", VA = "0x72827B0")]
			internal set
			{
				_0083_00A5zO_0081A(value);
			}
		}

		[Token(Token = "0x6006AD2")]
		[Address(RVA = "0x72825F0", Offset = "0x727E5F0", VA = "0x72825F0")]
		public ObjectBase(object f_005B_0098_00B6_008DÀ)
		{
		}

		[Token(Token = "0x6006AD3")]
		[Address(RVA = "0x727B4FC", Offset = "0x72774FC", VA = "0x727B4FC")]
		public ObjectBase(string _00AE_008C_009AiPJ, object f_005B_0098_00B6_008DÀ)
		{
		}

		[Token(Token = "0x6006AD4")]
		[Address(RVA = "0x7282720", Offset = "0x727E720", VA = "0x7282720")]
		public ObjectBase(string _00AE_008C_009AiPJ, object f_005B_0098_00B6_008DÀ, bool _009Ag_00A8B_005E_0096)
		{
		}

		[Token(Token = "0x6006AD5")]
		[Address(RVA = "0x728272C", Offset = "0x727E72C", VA = "0x728272C")]
		public ObjectBase(string _00AE_008C_009AiPJ, object f_005B_0098_00B6_008DÀ, int rVlHªB)
		{
		}

		[Token(Token = "0x6006AD6")]
		[Address(RVA = "0x7282604", Offset = "0x727E604", VA = "0x7282604")]
		public ObjectBase(string _00AE_008C_009AiPJ, object f_005B_0098_00B6_008DÀ, bool _009Ag_00A8B_005E_0096, int rVlHªB)
		{
		}

		[Token(Token = "0x6006AE0")]
		[Address(RVA = "0x72827B0", Offset = "0x727E7B0", VA = "0x72827B0")]
		internal void _0083_00A5zO_0081A(DateTime _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006AE1")]
		[Address(RVA = "0x72827B8", Offset = "0x727E7B8", VA = "0x72827B8", Slot = "6")]
		protected internal virtual void _00A2_0094_0087_00AE_0083_0060()
		{
		}

		[Token(Token = "0x6006AE2")]
		[Address(RVA = "0x72827BC", Offset = "0x727E7BC", VA = "0x72827BC", Slot = "7")]
		protected internal virtual void H_00AB_0087_009C_00A0_007D()
		{
		}

		[Token(Token = "0x6006AE3")]
		protected internal abstract void _00B0_0082Á_008AE_009C();
	}
}
