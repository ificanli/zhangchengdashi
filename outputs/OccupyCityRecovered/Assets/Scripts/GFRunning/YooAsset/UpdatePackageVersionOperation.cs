using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x200011B")]
	public abstract class UpdatePackageVersionOperation : AsyncOperationBase
	{
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x40")]
		private string s_00BDPY_0092_0098;

		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x48")]
		private string V_0087EGpN;

		[Token(Token = "0x170000B5")]
		public string PackageVersion
		{
			[Token(Token = "0x6000EE7")]
			[Address(RVA = "0x73347B4", Offset = "0x73307B4", VA = "0x73347B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EE6")]
			[Address(RVA = "0x73347AC", Offset = "0x73307AC", VA = "0x73347AC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public string ResFolderName
		{
			[Token(Token = "0x6000EE9")]
			[Address(RVA = "0x73347C4", Offset = "0x73307C4", VA = "0x73347C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EE8")]
			[Address(RVA = "0x73347BC", Offset = "0x73307BC", VA = "0x73347BC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x73347CC", Offset = "0x73307CC", VA = "0x73347CC")]
		protected UpdatePackageVersionOperation()
		{
		}
	}
}
