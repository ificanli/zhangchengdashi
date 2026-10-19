using System;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	[Token(Token = "0x200001B")]
	internal class TimeCriterion : SelectionCriterion
	{
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x14")]
		internal ComparisonOperator Operator;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x18")]
		internal WhichTime Which;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x20")]
		internal DateTime Time;

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x7839B04", Offset = "0x7835B04", VA = "0x7839B04")]
		public TimeCriterion()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x7839B0C", Offset = "0x7835B0C", VA = "0x7839B0C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x7839CA4", Offset = "0x7835CA4", VA = "0x7839CA4", Slot = "6")]
		internal override bool Evaluate(string filename)
		{
			return default;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x7839E00", Offset = "0x7835E00", VA = "0x7839E00")]
		private bool _Evaluate(DateTime x)
		{
			return default;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x7839FD4", Offset = "0x7835FD4", VA = "0x7839FD4", Slot = "7")]
		internal override bool Evaluate(ZipEntry entry)
		{
			return default;
		}
	}
}
