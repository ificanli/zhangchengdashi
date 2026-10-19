using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000033")]
	public class ReadOptions
	{
		[Token(Token = "0x17000087")]
		public EventHandler<ReadProgressEventArgs> ReadProgress
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x78590FC", Offset = "0x78550FC", VA = "0x78590FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x7859104", Offset = "0x7855104", VA = "0x7859104")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public TextWriter StatusMessageWriter
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x785910C", Offset = "0x785510C", VA = "0x785910C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x7859114", Offset = "0x7855114", VA = "0x7859114")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public Encoding Encoding
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x785911C", Offset = "0x785511C", VA = "0x785911C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x7859124", Offset = "0x7855124", VA = "0x7859124")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x78590F4", Offset = "0x78550F4", VA = "0x78590F4")]
		public ReadOptions()
		{
		}
	}
}
