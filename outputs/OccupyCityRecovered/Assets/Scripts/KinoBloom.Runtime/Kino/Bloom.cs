using Il2CppDummyDll;
using UnityEngine;

namespace Kino
{
	[Token(Token = "0x2000004")]
	[ImageEffectAllowedInSceneView]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class Bloom : MonoBehaviour
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Filters out pixels under this level of brightness.")]
		[SerializeField]
		private float _threshold;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("Makes transition between under/over-threshold gradual.")]
		private float _softKnee;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(1f, 7f)]
		[Tooltip("Changes extent of veiling effects\nin a screen resolution-independent fashion.")]
		private float _radius;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Blend factor of the result image.")]
		[SerializeField]
		private float _intensity;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Controls filter quality and buffer resolution.")]
		private bool _highQuality;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x31")]
		[Tooltip("Reduces flashing noise with an additional filter.")]
		[SerializeField]
		private bool _antiFlicker;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private Shader _shader;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x40")]
		private Material _material;

		[Token(Token = "0x400000E")]
		private const int kMaxIterations = 16;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture[] _blurBuffer1;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x50")]
		private RenderTexture[] _blurBuffer2;

		[Token(Token = "0x17000001")]
		public float thresholdGamma
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x740BB24", Offset = "0x7407B24", VA = "0x740BB24")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x740BB34", Offset = "0x7407B34", VA = "0x740BB34")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float thresholdLinear
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x740BB3C", Offset = "0x7407B3C", VA = "0x740BB3C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x740BB58", Offset = "0x7407B58", VA = "0x740BB58")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float softKnee
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x740BB7C", Offset = "0x7407B7C", VA = "0x740BB7C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x740BB84", Offset = "0x7407B84", VA = "0x740BB84")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public float radius
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x740BB8C", Offset = "0x7407B8C", VA = "0x740BB8C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x740BB94", Offset = "0x7407B94", VA = "0x740BB94")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float intensity
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x740BB9C", Offset = "0x7407B9C", VA = "0x740BB9C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x740BBAC", Offset = "0x7407BAC", VA = "0x740BBAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public bool highQuality
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x740BBB4", Offset = "0x7407BB4", VA = "0x740BBB4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x740BBBC", Offset = "0x7407BBC", VA = "0x740BBBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool antiFlicker
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x740BBC8", Offset = "0x7407BC8", VA = "0x740BBC8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x740BBD0", Offset = "0x7407BD0", VA = "0x740BBD0")]
			set
			{
			}
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x740BB74", Offset = "0x7407B74", VA = "0x740BB74")]
		private float LinearToGamma(float x)
		{
			return default;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x740BB50", Offset = "0x7407B50", VA = "0x740BB50")]
		private float GammaToLinear(float x)
		{
			return default;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x740BBDC", Offset = "0x7407BDC", VA = "0x740BBDC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x740BCB0", Offset = "0x7407CB0", VA = "0x740BCB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x740BD0C", Offset = "0x7407D0C", VA = "0x740BD0C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x740C468", Offset = "0x7408468", VA = "0x740C468")]
		public Bloom()
		{
		}
	}
}
