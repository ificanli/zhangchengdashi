using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000ED")]
	public class MatsAndGOs
	{
		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x10")]
		public List<MatAndTransformToMerged> mats;

		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x18")]
		public List<GameObject> gos;

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x7494B98", Offset = "0x7490B98", VA = "0x7494B98")]
		public MatsAndGOs()
		{
		}
	}
}
