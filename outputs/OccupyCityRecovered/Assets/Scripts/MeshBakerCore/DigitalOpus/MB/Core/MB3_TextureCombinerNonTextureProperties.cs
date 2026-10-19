using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000F3")]
	public class MB3_TextureCombinerNonTextureProperties
	{
		[Token(Token = "0x20000F4")]
		public interface MaterialProperty
		{
			[Token(Token = "0x170000BC")]
			string PropertyName
			{
				[Token(Token = "0x600054A")]
				get;
				[Token(Token = "0x600054B")]
				set;
			}

			[Token(Token = "0x600054C")]
			MaterialPropertyValueAveraged GetAverageCalculator();

			[Token(Token = "0x600054D")]
			object GetDefaultValue();
		}

		[Token(Token = "0x20000F5")]
		public class MaterialPropertyFloat : MaterialProperty
		{
			[Token(Token = "0x400039F")]
			[FieldOffset(Offset = "0x18")]
			private MaterialPropertyValueAveragedFloat _averageCalc;

			[Token(Token = "0x40003A0")]
			[FieldOffset(Offset = "0x20")]
			private float _defaultValue;

			[Token(Token = "0x170000BD")]
			public string PropertyName
			{
				[Token(Token = "0x600054E")]
				[Address(RVA = "0x749A6C4", Offset = "0x74966C4", VA = "0x749A6C4", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600054F")]
				[Address(RVA = "0x749A6CC", Offset = "0x74966CC", VA = "0x749A6CC", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x74996B0", Offset = "0x74956B0", VA = "0x74996B0")]
			public MaterialPropertyFloat(string name, float defValue)
			{
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x749A6DC", Offset = "0x74966DC", VA = "0x749A6DC", Slot = "6")]
			public MaterialPropertyValueAveraged GetAverageCalculator()
			{
				return null;
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x749A6E4", Offset = "0x74966E4", VA = "0x749A6E4", Slot = "7")]
			public object GetDefaultValue()
			{
				return null;
			}
		}

		[Token(Token = "0x20000F6")]
		public class MaterialPropertyColor : MaterialProperty
		{
			[Token(Token = "0x40003A2")]
			[FieldOffset(Offset = "0x18")]
			private MaterialPropertyValueAveragedColor _averageCalc;

			[Token(Token = "0x40003A3")]
			[FieldOffset(Offset = "0x20")]
			private Color _defaultValue;

			[Token(Token = "0x170000BE")]
			public string PropertyName
			{
				[Token(Token = "0x6000553")]
				[Address(RVA = "0x749A740", Offset = "0x7496740", VA = "0x749A740", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000554")]
				[Address(RVA = "0x749A748", Offset = "0x7496748", VA = "0x749A748", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0x7499618", Offset = "0x7495618", VA = "0x7499618")]
			public MaterialPropertyColor(string name, Color defaultVal)
			{
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0x749A758", Offset = "0x7496758", VA = "0x749A758", Slot = "6")]
			public MaterialPropertyValueAveraged GetAverageCalculator()
			{
				return null;
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x749A760", Offset = "0x7496760", VA = "0x749A760", Slot = "7")]
			public object GetDefaultValue()
			{
				return null;
			}
		}

		[Token(Token = "0x20000F7")]
		public interface MaterialPropertyValueAveraged
		{
			[Token(Token = "0x6000558")]
			void TryGetPropValueFromMaterialAndBlendIntoAverage(Material mat, MaterialProperty property);

			[Token(Token = "0x6000559")]
			object GetAverage();

			[Token(Token = "0x600055A")]
			int NumValues();

			[Token(Token = "0x600055B")]
			void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property);
		}

		[Token(Token = "0x20000F8")]
		public class MaterialPropertyValueAveragedFloat : MaterialPropertyValueAveraged
		{
			[Token(Token = "0x40003A4")]
			[FieldOffset(Offset = "0x10")]
			public float averageVal;

			[Token(Token = "0x40003A5")]
			[FieldOffset(Offset = "0x14")]
			public int numValues;

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x749A7BC", Offset = "0x74967BC", VA = "0x749A7BC", Slot = "4")]
			public void TryGetPropValueFromMaterialAndBlendIntoAverage(Material mat, MaterialProperty property)
			{
			}

			[Token(Token = "0x600055D")]
			[Address(RVA = "0x749A918", Offset = "0x7496918", VA = "0x749A918", Slot = "5")]
			public object GetAverage()
			{
				return null;
			}

			[Token(Token = "0x600055E")]
			[Address(RVA = "0x749A974", Offset = "0x7496974", VA = "0x749A974", Slot = "6")]
			public int NumValues()
			{
				return default;
			}

			[Token(Token = "0x600055F")]
			[Address(RVA = "0x749A97C", Offset = "0x749697C", VA = "0x749A97C", Slot = "7")]
			public void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property)
			{
			}

			[Token(Token = "0x6000560")]
			[Address(RVA = "0x749A6D4", Offset = "0x74966D4", VA = "0x749A6D4")]
			public MaterialPropertyValueAveragedFloat()
			{
			}
		}

		[Token(Token = "0x20000F9")]
		public class MaterialPropertyValueAveragedColor : MaterialPropertyValueAveraged
		{
			[Token(Token = "0x40003A6")]
			[FieldOffset(Offset = "0x10")]
			public Color averageVal;

			[Token(Token = "0x40003A7")]
			[FieldOffset(Offset = "0x20")]
			public int numValues;

			[Token(Token = "0x6000561")]
			[Address(RVA = "0x749AB68", Offset = "0x7496B68", VA = "0x749AB68", Slot = "4")]
			public void TryGetPropValueFromMaterialAndBlendIntoAverage(Material mat, MaterialProperty property)
			{
			}

			[Token(Token = "0x6000562")]
			[Address(RVA = "0x749ACD4", Offset = "0x7496CD4", VA = "0x749ACD4", Slot = "5")]
			public object GetAverage()
			{
				return null;
			}

			[Token(Token = "0x6000563")]
			[Address(RVA = "0x749AD30", Offset = "0x7496D30", VA = "0x749AD30", Slot = "6")]
			public int NumValues()
			{
				return default;
			}

			[Token(Token = "0x6000564")]
			[Address(RVA = "0x749AD38", Offset = "0x7496D38", VA = "0x749AD38", Slot = "7")]
			public void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property)
			{
			}

			[Token(Token = "0x6000565")]
			[Address(RVA = "0x749A750", Offset = "0x7496750", VA = "0x749A750")]
			public MaterialPropertyValueAveragedColor()
			{
			}
		}

		[Token(Token = "0x20000FA")]
		public struct TexPropertyNameColorPair
		{
			[Token(Token = "0x40003A8")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x40003A9")]
			[FieldOffset(Offset = "0x8")]
			public Color color;

			[Token(Token = "0x6000566")]
			[Address(RVA = "0x7499608", Offset = "0x7495608", VA = "0x7499608")]
			public TexPropertyNameColorPair(string nm, Color col)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_TextureCombinerNonTextureProperties.TexPropertyNameColorPair..ctor RVA=0x7499608 Token=0x6000566");
}
		}

		[Token(Token = "0x20000FB")]
		private interface NonTextureProperties
		{
			[Token(Token = "0x6000567")]
			bool NonTexturePropertiesAreEqual(Material a, Material b);

			[Token(Token = "0x6000568")]
			Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName);

			[Token(Token = "0x6000569")]
			void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, MB2_EditorMethodsInterface editorMethods);

			[Token(Token = "0x600056A")]
			Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty);

			[Token(Token = "0x600056B")]
			Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty);
		}

		[Token(Token = "0x20000FC")]
		private class NonTexturePropertiesDontBlendProps : NonTextureProperties
		{
			[Token(Token = "0x40003AA")]
			[FieldOffset(Offset = "0x10")]
			private MB3_TextureCombinerNonTextureProperties _textureProperties;

			[Token(Token = "0x600056C")]
			[Address(RVA = "0x7499730", Offset = "0x7495730", VA = "0x7499730")]
			public NonTexturePropertiesDontBlendProps(MB3_TextureCombinerNonTextureProperties textureProperties)
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0x749AF48", Offset = "0x7496F48", VA = "0x749AF48", Slot = "4")]
			public bool NonTexturePropertiesAreEqual(Material a, Material b)
			{
				return default;
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0x749AF50", Offset = "0x7496F50", VA = "0x749AF50", Slot = "5")]
			public Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
			{
				return null;
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x749AFC4", Offset = "0x7496FC4", VA = "0x749AFC4", Slot = "6")]
			public void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, MB2_EditorMethodsInterface editorMethods)
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x749B27C", Offset = "0x749727C", VA = "0x749B27C", Slot = "8")]
			public Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
			{
				return default;
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0x749B290", Offset = "0x7497290", VA = "0x749B290", Slot = "7")]
			public Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty)
			{
				return default;
			}
		}

		[Token(Token = "0x20000FD")]
		private class NonTexturePropertiesBlendProps : NonTextureProperties
		{
			[Token(Token = "0x40003AB")]
			[FieldOffset(Offset = "0x10")]
			private MB3_TextureCombinerNonTextureProperties _textureProperties;

			[Token(Token = "0x40003AC")]
			[FieldOffset(Offset = "0x18")]
			private TextureBlender resultMaterialTextureBlender;

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x749A340", Offset = "0x7496340", VA = "0x749A340")]
			public NonTexturePropertiesBlendProps(MB3_TextureCombinerNonTextureProperties textureProperties, TextureBlender resultMats)
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x749B3A0", Offset = "0x74973A0", VA = "0x749B3A0", Slot = "4")]
			public bool NonTexturePropertiesAreEqual(Material a, Material b)
			{
				return default;
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x749B45C", Offset = "0x749745C", VA = "0x749B45C", Slot = "5")]
			public Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
			{
				return null;
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x749B7F4", Offset = "0x74977F4", VA = "0x749B7F4", Slot = "6")]
			public void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, MB2_EditorMethodsInterface editorMethods)
			{
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0x749BA0C", Offset = "0x7497A0C", VA = "0x749BA0C", Slot = "8")]
			public Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
			{
				return default;
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0x749BB84", Offset = "0x7497B84", VA = "0x749BB84", Slot = "7")]
			public Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty)
			{
				return default;
			}
		}

		[Token(Token = "0x4000396")]
		[FieldOffset(Offset = "0x10")]
		private TexPropertyNameColorPair[] defaultTextureProperty2DefaultColorMap;

		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x18")]
		private MaterialProperty[] _nonTextureProperties;

		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x20")]
		private MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x24")]
		private bool _considerNonTextureProperties;

		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x28")]
		private TextureBlender resultMaterialTextureBlender;

		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x30")]
		private TextureBlender[] textureBlenders;

		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, Color> textureProperty2DefaultColorMap;

		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x40")]
		private NonTextureProperties _nonTexturePropertiesBlender;

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x7499040", Offset = "0x7495040", VA = "0x7499040")]
		public MB3_TextureCombinerNonTextureProperties(MB2_LogLevel ll, bool considerNonTextureProps)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x7499758", Offset = "0x7495758", VA = "0x7499758")]
		internal void CollectAverageValuesOfNonTextureProperties(Material resultMaterial, Material mat)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x74933F0", Offset = "0x748F3F0", VA = "0x74933F0")]
		internal void LoadTextureBlendersIfNeeded(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x749A1D4", Offset = "0x74961D4", VA = "0x749A1D4")]
		private static bool InterfaceFilter(Type typeObj, object criteriaObj)
		{
			return default;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x7499FBC", Offset = "0x7495FBC", VA = "0x7499FBC")]
		private void FindBestTextureBlender(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x749993C", Offset = "0x749593C", VA = "0x749993C")]
		private void LoadTextureBlenders()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x7494FFC", Offset = "0x7490FFC", VA = "0x7494FFC")]
		internal bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default;
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x749A36C", Offset = "0x749636C", VA = "0x749A36C")]
		internal Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
		{
			return null;
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x749A430", Offset = "0x7496430", VA = "0x749A430")]
		internal void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x749A54C", Offset = "0x749654C", VA = "0x749A54C")]
		internal Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
		{
			return default;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x749A608", Offset = "0x7496608", VA = "0x749A608")]
		internal Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty)
		{
			return default;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x749A224", Offset = "0x7496224", VA = "0x749A224")]
		private TextureBlender FindMatchingTextureBlender(string shaderName)
		{
			return null;
		}
	}
}
