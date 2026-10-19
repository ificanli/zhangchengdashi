using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000EC")]
	public class MatAndTransformToMerged
	{
		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x10")]
		public Material mat;

		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x78")]
		public string objName;

		[Token(Token = "0x170000B3")]
		public DRect obUVRectIfTilingSame
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x7494778", Offset = "0x7490778", VA = "0x7494778")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x7494784", Offset = "0x7490784", VA = "0x7494784")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public DRect samplingRectMatAndUVTiling
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x7494790", Offset = "0x7490790", VA = "0x7494790")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x749479C", Offset = "0x749079C", VA = "0x749479C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public DRect materialTiling
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x74947A8", Offset = "0x74907A8", VA = "0x74947A8")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x74947B4", Offset = "0x74907B4", VA = "0x74947B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x74947C0", Offset = "0x74907C0", VA = "0x74947C0")]
		public MatAndTransformToMerged(DRect obUVrect, bool fixOutOfBoundsUVs)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x7494880", Offset = "0x7490880", VA = "0x7494880")]
		public MatAndTransformToMerged(DRect obUVrect, bool fixOutOfBoundsUVs, Material m)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x7494820", Offset = "0x7490820", VA = "0x7494820")]
		private void _init(DRect obUVrect, bool fixOutOfBoundsUVs, Material m)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x74948E4", Offset = "0x74908E4", VA = "0x74948E4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x74949C8", Offset = "0x74909C8", VA = "0x74949C8", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x7494A48", Offset = "0x7490A48", VA = "0x7494A48")]
		public string GetMaterialName()
		{
			return null;
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x7494B14", Offset = "0x7490B14", VA = "0x7494B14")]
		public void AssignInitialValuesForMaterialTilingAndSamplingRectMatAndUVTiling(bool allTexturesUseSameMatTiling, DRect matTiling)
		{
		}
	}
}
