using System.Collections;
using Il2CppDummyDll;

namespace AssetBundles
{
	[Token(Token = "0x200019D")]
	public abstract class AssetBundleLoadOperation : IEnumerator
	{
		[Token(Token = "0x170000D8")]
		public object Current
		{
			[Token(Token = "0x60013A6")]
			[Address(RVA = "0x736169C", Offset = "0x735D69C", VA = "0x736169C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x73616A4", Offset = "0x735D6A4", VA = "0x73616A4", Slot = "4")]
		public bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x73616C4", Offset = "0x735D6C4", VA = "0x73616C4", Slot = "6")]
		public void Reset()
		{
		}

		[Token(Token = "0x60013A9")]
		public abstract bool Update();

		[Token(Token = "0x60013AA")]
		public abstract bool IsDone();

		[Token(Token = "0x60013AB")]
		public abstract float Progress();

		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x73616C8", Offset = "0x735D6C8", VA = "0x73616C8")]
		protected AssetBundleLoadOperation()
		{
		}
	}
}
