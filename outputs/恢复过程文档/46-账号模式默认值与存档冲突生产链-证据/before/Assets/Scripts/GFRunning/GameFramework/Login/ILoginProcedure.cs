using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace GameFramework.Login
{
	[Token(Token = "0x20004EC")]
	public abstract class ILoginProcedure
	{
		[Token(Token = "0x4002009")]
		[FieldOffset(Offset = "0x0")]
		private static AccountType _00ACI_008A_00B9b_0098;

		[Token(Token = "0x400200A")]
		[FieldOffset(Offset = "0x4")]
		private static bool C_009C_0090_00BB_00ACi;

		[Token(Token = "0x400200B")]
		[FieldOffset(Offset = "0x10")]
		internal bool _00A7TQ_008A_008Dt;

		[Token(Token = "0x400200C")]
		[FieldOffset(Offset = "0x11")]
		private readonly bool FWIO_008Cª;

		[Token(Token = "0x1700125E")]
		public static AccountType accountType
		{
			[Token(Token = "0x60074DF")]
			[Address(RVA = "0x7301010", Offset = "0x72FD010", VA = "0x7301010")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60074E0")]
			[Address(RVA = "0x7301068", Offset = "0x72FD068", VA = "0x7301068")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700125F")]
		public static bool IsLoginInvalid
		{
			[Token(Token = "0x60074E1")]
			[Address(RVA = "0x73010C4", Offset = "0x72FD0C4", VA = "0x73010C4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60074E2")]
			[Address(RVA = "0x730111C", Offset = "0x72FD11C", VA = "0x730111C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001260")]
		protected bool IsLogining
		{
			[Token(Token = "0x60074E3")]
			[Address(RVA = "0x730117C", Offset = "0x72FD17C", VA = "0x730117C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60074E4")]
			[Address(RVA = "0x7301184", Offset = "0x72FD184", VA = "0x7301184")]
			set
			{
			}
		}

		[Token(Token = "0x17001261")]
		private bool _0092Y_00B1_0082Á_00A5
		{
			[Token(Token = "0x60074E9")]
			[Address(RVA = "0x7301200", Offset = "0x72FD200", VA = "0x7301200")]
			get
			{
				return Âh_00B2ITe();
			}
		}

		[Token(Token = "0x60074E5")]
		[Address(RVA = "0x73011F0", Offset = "0x72FD1F0", VA = "0x73011F0", Slot = "4")]
		[Obsolete("请使用LoginInvalid带设备ID参数的接口")]
		public virtual void LoginInvalid()
		{
		}

		[Token(Token = "0x60074E6")]
		[Address(RVA = "0x73011F4", Offset = "0x72FD1F4", VA = "0x73011F4", Slot = "5")]
		public virtual void SdkLoginOutCallBack()
		{
		}

		[Token(Token = "0x60074E7")]
		[Address(RVA = "0x73011F8", Offset = "0x72FD1F8", VA = "0x73011F8", Slot = "6")]
		public virtual void SdkLoginExitCallBack()
		{
		}

		[Token(Token = "0x60074E8")]
		[Address(RVA = "0x73011FC", Offset = "0x72FD1FC", VA = "0x73011FC", Slot = "7")]
		public virtual void LoginInvalid(int _00B8_009E_00B8r_007Co)
		{
		}

		[Token(Token = "0x60074E9")]
		[Address(RVA = "0x7301200", Offset = "0x72FD200", VA = "0x7301200")]
		private bool Âh_00B2ITe()
		{
			return default;
		}

		[Token(Token = "0x60074EA")]
		public abstract void Init(string _008DG_007B_005D_009Fz, string _008D_00AEmoÂ_00A2 = "");

		[Token(Token = "0x60074EB")]
		public abstract void loginCallback(int _0081E_008BwW_00A4, string _005EkW_0091_0093T);

		[Token(Token = "0x60074EC")]
		[Address(RVA = "0x7301208", Offset = "0x72FD208", VA = "0x7301208", Slot = "10")]
		public virtual void loginCallback3p0(int _0081E_008BwW_00A4, LoginUserData _005EkW_0091_0093T)
		{
		}

		[Token(Token = "0x60074ED")]
		[Address(RVA = "0x730120C", Offset = "0x72FD20C", VA = "0x730120C")]
		protected ILoginProcedure()
		{
		}
	}
}
