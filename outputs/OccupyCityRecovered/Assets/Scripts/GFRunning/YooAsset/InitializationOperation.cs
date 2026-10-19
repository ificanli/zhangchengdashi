using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x20000EC")]
	public abstract class InitializationOperation : AsyncOperationBase
	{
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x40")]
		private string s_00BDPY_0092_0098;

		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x48")]
		private string p_009E_007F_0081n_00A4;

		[Token(Token = "0x170000A7")]
		public string PackageVersion
		{
			[Token(Token = "0x6000CC8")]
			[Address(RVA = "0x7327B10", Offset = "0x7323B10", VA = "0x7327B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x7327B08", Offset = "0x7323B08", VA = "0x7327B08")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public string PackageVerDesc
		{
			[Token(Token = "0x6000CCA")]
			[Address(RVA = "0x7327B20", Offset = "0x7323B20", VA = "0x7327B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x7327B18", Offset = "0x7323B18", VA = "0x7327B18")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x7327B28", Offset = "0x7323B28", VA = "0x7327B28")]
		protected InitializationOperation()
		{
		}
	}
}
