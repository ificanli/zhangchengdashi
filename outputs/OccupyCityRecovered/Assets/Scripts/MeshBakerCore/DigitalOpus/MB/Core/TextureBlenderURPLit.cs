using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200013E")]
	public class TextureBlenderURPLit : TextureBlender
	{
		[Token(Token = "0x200013F")]
		private enum Prop
		{
			[Token(Token = "0x4000526")]
			doColor = 0,
			[Token(Token = "0x4000527")]
			doSpecular = 1,
			[Token(Token = "0x4000528")]
			doMetallic = 2,
			[Token(Token = "0x4000529")]
			doEmission = 3,
			[Token(Token = "0x400052A")]
			doBump = 4,
			[Token(Token = "0x400052B")]
			doNone = 5
		}

		[Token(Token = "0x2000140")]
		private enum WorkflowMode
		{
			[Token(Token = "0x400052D")]
			unknown = 0,
			[Token(Token = "0x400052E")]
			metallic = 1,
			[Token(Token = "0x400052F")]
			specular = 2
		}

		[Token(Token = "0x2000141")]
		private enum SmoothnessTextureChannel
		{
			[Token(Token = "0x4000531")]
			unknown = 0,
			[Token(Token = "0x4000532")]
			albedo = 1,
			[Token(Token = "0x4000533")]
			metallicSpecular = 2
		}

		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x0")]
		private static Color NeutralNormalMap;

		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x10")]
		private TextureBlenderMaterialPropertyCacheHelper sourceMaterialPropertyCache;

		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x18")]
		private WorkflowMode m_workflowMode;

		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0x1C")]
		private SmoothnessTextureChannel m_smoothnessTextureChannel;

		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0x20")]
		private Color m_tintColor;

		[Token(Token = "0x400050C")]
		[FieldOffset(Offset = "0x30")]
		private bool m_doScaleAlphaCutoff;

		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0x34")]
		private float m_alphaCutoff;

		[Token(Token = "0x400050E")]
		[FieldOffset(Offset = "0x38")]
		private float m_smoothness;

		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0x3C")]
		private Color m_specColor;

		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_hasSpecGlossMap;

		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x50")]
		private float m_metallic;

		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x54")]
		private bool m_hasMetallicGlossMap;

		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x58")]
		private float m_bumpScale;

		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_shaderDoesEmission;

		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x60")]
		private Color m_emissionColor;

		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x70")]
		private Prop propertyToDo;

		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x74")]
		private Color m_generatingTintedAtlaColor;

		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x84")]
		private float m_generatingTintedAtlasMetallic;

		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x88")]
		private Color m_generatingTintedAtlaSpecular;

		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x98")]
		private float m_generatingTintedAtlasMetallic_smoothness;

		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x9C")]
		private float m_generatingTintedAtlasSpecular_somoothness;

		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0xA0")]
		private float m_generatingTintedAtlaBumpScale;

		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0xA4")]
		private Color m_generatingTintedAtlaEmission;

		[Token(Token = "0x400051E")]
		private const float m_generatedAlphaCutoff = 0.5f;

		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0xB4")]
		private Color m_notGeneratingAtlasDefaultColor;

		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0xC4")]
		private float m_notGeneratingAtlasDefaultMetallic;

		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0xC8")]
		private float m_notGeneratingAtlasDefaultSmoothness_MetallicWorkflow;

		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0xCC")]
		private float m_notGeneratingAtlasDefaultSmoothness_SpecularWorkflow;

		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0xD0")]
		private Color m_notGeneratingAtlasDefaultSpecularColor;

		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0xE0")]
		private Color m_notGeneratingAtlasDefaultEmisionColor;

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x74BE668", Offset = "0x74BA668", VA = "0x74BE668", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x74BE7E4", Offset = "0x74BA7E4", VA = "0x74BE7E4")]
		private WorkflowMode _MapFloatToWorkflowMode(float workflowMode)
		{
			return default;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x74BE7F4", Offset = "0x74BA7F4", VA = "0x74BE7F4")]
		private float _MapWorkflowModeToFloat(WorkflowMode workflowMode)
		{
			return default;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x74BE808", Offset = "0x74BA808", VA = "0x74BE808")]
		private SmoothnessTextureChannel _MapFloatToTextureChannel(float texChannel)
		{
			return default;
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x74BE818", Offset = "0x74BA818", VA = "0x74BE818")]
		private float _MapTextureChannelToFloat(SmoothnessTextureChannel workflowMode)
		{
			return default;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x74BE82C", Offset = "0x74BA82C", VA = "0x74BE82C", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x74BEED4", Offset = "0x74BAED4", VA = "0x74BEED4", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default;
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x74BF094", Offset = "0x74BB094", VA = "0x74BF094", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default;
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x74BF5A8", Offset = "0x74BB5A8", VA = "0x74BF5A8", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x74BFC9C", Offset = "0x74BBC9C", VA = "0x74BFC9C", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x74C0318", Offset = "0x74BC318", VA = "0x74C0318")]
		public TextureBlenderURPLit()
		{
		}
	}
}
