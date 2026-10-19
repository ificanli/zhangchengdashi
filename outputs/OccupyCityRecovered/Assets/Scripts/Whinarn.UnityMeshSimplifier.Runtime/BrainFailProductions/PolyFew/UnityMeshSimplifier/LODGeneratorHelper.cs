using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x2000009")]
	[AddComponentMenu("Rendering/LOD Generator Helper")]
	public sealed class LODGeneratorHelper : MonoBehaviour
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The fade mode used by the created LOD group.")]
		[SerializeField]
		private LODFadeMode fadeMode;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("If the cross-fading should be animated by time.")]
		[SerializeField]
		private bool animateCrossFading;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x25")]
		[Tooltip("If the renderers under this game object and any children should be automatically collected.")]
		[SerializeField]
		private bool autoCollectRenderers;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("The simplification options.")]
		private SimplificationOptions simplificationOptions;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("The path within the project to save the generated assets. Leave this empty to use the default path.")]
		private string saveAssetsPath;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("The LOD levels.")]
		private LODLevel[] levels;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool isGenerated;

		[Token(Token = "0x17000002")]
		public LODFadeMode FadeMode
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x854F16C", Offset = "0x854B16C", VA = "0x854F16C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x854F174", Offset = "0x854B174", VA = "0x854F174")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public bool AnimateCrossFading
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x854F17C", Offset = "0x854B17C", VA = "0x854F17C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x854F184", Offset = "0x854B184", VA = "0x854F184")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public bool AutoCollectRenderers
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x854F190", Offset = "0x854B190", VA = "0x854F190")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x854F198", Offset = "0x854B198", VA = "0x854F198")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public SimplificationOptions SimplificationOptions
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x854F1A4", Offset = "0x854B1A4", VA = "0x854F1A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x854F1B4", Offset = "0x854B1B4", VA = "0x854F1B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public string SaveAssetsPath
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x854F1C4", Offset = "0x854B1C4", VA = "0x854F1C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x854F1CC", Offset = "0x854B1CC", VA = "0x854F1CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public LODLevel[] Levels
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x854F1D4", Offset = "0x854B1D4", VA = "0x854F1D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x854F1DC", Offset = "0x854B1DC", VA = "0x854F1DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool IsGenerated
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x854F1E4", Offset = "0x854B1E4", VA = "0x854F1E4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x854F1EC", Offset = "0x854B1EC", VA = "0x854F1EC")]
		private void Reset()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x854F4B4", Offset = "0x854B4B4", VA = "0x854F4B4")]
		public LODGeneratorHelper()
		{
		}
	}
}
