using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x2000027")]
	public class AstarColor : ISerializationCallbackReceiver
	{
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x10")]
		public Color _SolidColor;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x20")]
		public Color _UnwalkableNode;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x30")]
		public Color _BoundsHandles;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x40")]
		public Color _ConnectionLowLerp;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x50")]
		public Color _ConnectionHighLerp;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x60")]
		public Color _MeshEdgeColor;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x70")]
		public Color[] _AreaColors;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x0")]
		public static Color SolidColor;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x10")]
		public static Color UnwalkableNode;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x20")]
		public static Color BoundsHandles;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x30")]
		public static Color ConnectionLowLerp;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x40")]
		public static Color ConnectionHighLerp;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x50")]
		public static Color MeshEdgeColor;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x60")]
		private static Color[] AreaColors;

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x445CA38", Offset = "0x4458A38", VA = "0x445CA38")]
		public static int ColorHash()
		{
			return default;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x445CE00", Offset = "0x4458E00", VA = "0x445CE00")]
		public static Color GetAreaColor(uint area)
		{
			return default;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x445CF88", Offset = "0x4458F88", VA = "0x445CF88")]
		public static Color GetTagColor(uint tag)
		{
			return default;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x445D06C", Offset = "0x445906C", VA = "0x445D06C")]
		public void PushToStatic()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x445D168", Offset = "0x4459168", VA = "0x445D168", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x445D16C", Offset = "0x445916C", VA = "0x445D16C", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x445D204", Offset = "0x4459204", VA = "0x445D204")]
		public AstarColor()
		{
		}
	}
}
