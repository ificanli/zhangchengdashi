using System;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x2000094")]
	public struct PathRequestSettings : IEquatable<PathRequestSettings>
	{
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x0")]
		public GraphMask graphMask;

		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x4")]
		public int traversableTags;

		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x8")]
		public float[] tagCostMultipliers;

		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("tagPenalties")]
		public uint[] tagEntryCosts;

		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x18")]
		public ITraversalProvider traversalProvider;

		[Token(Token = "0x17000101")]
		[Obsolete("Use tagEntryCosts or tagCostMultipliers instead")]
		public uint[] tagPenalties
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x450CA40", Offset = "0x4508A40", VA = "0x450CA40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x450CA48", Offset = "0x4508A48", VA = "0x450CA48")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public static PathRequestSettings Default
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x450CA50", Offset = "0x4508A50", VA = "0x450CA50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x450CB24", Offset = "0x4508B24", VA = "0x450CB24")]
		public NearestNodeConstraint ToNearestNodeConstraint()
		{
			return default;
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x450CC3C", Offset = "0x4508C3C", VA = "0x450CC3C")]
		public TraversalConstraint ToTraversalConstraint()
		{
			return default;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x450CCCC", Offset = "0x4508CCC", VA = "0x450CCCC")]
		public TraversalCosts ToTraversalCosts()
		{
			return default;
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x450CDF0", Offset = "0x4508DF0", VA = "0x450CDF0", Slot = "4")]
		public bool Equals(PathRequestSettings other)
		{
			return default;
		}
	}
}
