using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew
{
	[Serializable]
	[Token(Token = "0x2000CC6")]
	public class ToleranceSphereJson
	{
		[Token(Token = "0x4005B91")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 worldPosition;

		[Token(Token = "0x4005B92")]
		[FieldOffset(Offset = "0x1C")]
		public float diameter;

		[Token(Token = "0x4005B93")]
		[FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x4005B94")]
		[FieldOffset(Offset = "0x30")]
		public float preservationStrength;

		[Token(Token = "0x4005B95")]
		[FieldOffset(Offset = "0x34")]
		public bool isHidden;

		[Token(Token = "0x600500D")]
		[Address(RVA = "0x42BC92C", Offset = "0x42B892C", VA = "0x42BC92C")]
		public ToleranceSphereJson(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}

		[Token(Token = "0x600500E")]
		[Address(RVA = "0x42BC9B0", Offset = "0x42B89B0", VA = "0x42BC9B0")]
		public ToleranceSphereJson(ToleranceSphere toleranceSphere)
		{
		}

		[Token(Token = "0x600500F")]
		[Address(RVA = "0x42BCAEC", Offset = "0x42B8AEC", VA = "0x42BCAEC")]
		public void SetProperties(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}

		[Token(Token = "0x6005010")]
		[Address(RVA = "0x42BCA44", Offset = "0x42B8A44", VA = "0x42BCA44")]
		public void DumpFromToleranceSphere(ToleranceSphere toleranceSphere)
		{
		}

		[Token(Token = "0x6005011")]
		[Address(RVA = "0x42BCB10", Offset = "0x42B8B10", VA = "0x42BCB10")]
		public void DumpToToleranceSphere(ref ToleranceSphere toleranceSphere)
		{
		}
	}
}
