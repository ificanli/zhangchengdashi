using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x200000E")]
	public class ZipErrorEventArgs : ZipProgressEventArgs
	{
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x40")]
		private Exception _exc;

		[Token(Token = "0x1700000B")]
		public Exception Exception
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x7839580", Offset = "0x7835580", VA = "0x7839580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		public string FileName
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x7839588", Offset = "0x7835588", VA = "0x7839588")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x78394FC", Offset = "0x78354FC", VA = "0x78394FC")]
		private ZipErrorEventArgs()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x7839500", Offset = "0x7835500", VA = "0x7839500")]
		internal static ZipErrorEventArgs Saving(string archiveName, ZipEntry entry, Exception exception)
		{
			return null;
		}
	}
}
