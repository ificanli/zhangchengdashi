using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace StylizedWater
{
	[Token(Token = "0x2000004")]
	public class CausticsFeature : ScriptableRendererFeature
	{
		[Serializable]
		[Token(Token = "0x2000005")]
		public class CausticsSettings
		{
			[Token(Token = "0x2000006")]
			public enum DebugMode
			{
				[Token(Token = "0x4000022")]
				Disabled = 0,
				[Token(Token = "0x4000023")]
				Caustics = 1,
				[Token(Token = "0x4000024")]
				Mask = 2
			}

			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x10")]
			[Range(0f, 3f)]
			[Header("Visuals")]
			public float strength;

			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x14")]
			[Range(0f, 1f)]
			public float rgbSplit;

			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float shadowMask;

			[Token(Token = "0x4000019")]
			[FieldOffset(Offset = "0x20")]
			[Header("Movement")]
			public Texture2D texture;

			[Token(Token = "0x400001A")]
			[FieldOffset(Offset = "0x28")]
			[Range(0.1f, 10f)]
			public float scale;

			[Token(Token = "0x400001B")]
			[FieldOffset(Offset = "0x2C")]
			[Range(0f, 0.3f)]
			public float speed;

			[Token(Token = "0x400001C")]
			[FieldOffset(Offset = "0x30")]
			[Header("Depth")]
			public float waterLevel;

			[Token(Token = "0x400001D")]
			[FieldOffset(Offset = "0x34")]
			public Vector2 depth;

			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0x3C")]
			[Range(0f, 1f)]
			public float fade;

			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x40")]
			[Header("Rendering")]
			public RenderPassEvent renderPassEvent;

			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x44")]
			public DebugMode debug;

			[Token(Token = "0x6000007")]
			[Address(RVA = "0x78F512C", Offset = "0x78F112C", VA = "0x78F512C")]
			public CausticsSettings()
			{
			}
		}

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		public CausticsSettings settings;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		private CausticsPass causticsPass;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private Shader causticsShader;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x38")]
		private Material causticsMaterial;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int SrcBlend;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int DstBlend;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int causticsTextureID;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int causticsStrengthID;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int causticsScaleID;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int causticsSpeedID;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int causticsSplitID;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int shadowMaskID;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int causticsFadeID;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int waterLevelID;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int causticsStartID;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int causticsEndID;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x78F4ABC", Offset = "0x78F0ABC", VA = "0x78F4ABC", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x78F5070", Offset = "0x78F1070", VA = "0x78F5070", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x78F5094", Offset = "0x78F1094", VA = "0x78F5094")]
		public CausticsFeature()
		{
		}
	}
}
