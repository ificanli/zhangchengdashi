using Il2CppDummyDll;
using UnityEngine;

namespace ToonyColorsPro.Demo
{
	[Token(Token = "0x2000010")]
	public class TCP2_Demo : MonoBehaviour
	{
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x20")]
		public Material[] AffectedMaterials;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D[] RampTextures;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x30")]
		public GUISkin GuiSkin;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x38")]
		public Light DirLight;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Robot;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Ethan;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x50")]
		private bool mUnityShader;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x51")]
		private bool mShaderSpecular;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x52")]
		private bool mShaderBump;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x53")]
		private bool mShaderReflection;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x54")]
		private bool mShaderRim;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x55")]
		private bool mShaderRimOutline;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x56")]
		private bool mShaderOutline;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x58")]
		private float mRimMin;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x5C")]
		private float mRimMax;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x60")]
		private bool mRampTextureFlag;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x68")]
		private Texture2D mRampTexture;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x70")]
		private float mRampSmoothing;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x74")]
		private float mLightRotationX;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x78")]
		private float mLightRotationY;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x7C")]
		private bool mViewRobot;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x7D")]
		private bool mRobotOutlineNormals;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x80")]
		private TCP2_Demo_View DemoView;

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x7D66D38", Offset = "0x7D62D38", VA = "0x7D66D38")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x7D672BC", Offset = "0x7D632BC", VA = "0x7D672BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x7D673E8", Offset = "0x7D633E8", VA = "0x7D673E8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x7D68FA0", Offset = "0x7D64FA0", VA = "0x7D68FA0")]
		private void UnityDiffuseShader()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x7D66DAC", Offset = "0x7D62DAC", VA = "0x7D66DAC")]
		private void UpdateShader()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x7D68DD4", Offset = "0x7D64DD4", VA = "0x7D68DD4")]
		private void RimOutlineColor()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x7D672D4", Offset = "0x7D632D4", VA = "0x7D672D4")]
		private void RestoreRimColors()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x7D690B0", Offset = "0x7D650B0", VA = "0x7D690B0")]
		private void ToggleKeyword(Material m, bool enabled, string keyword)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x7D68E74", Offset = "0x7D64E74", VA = "0x7D68E74")]
		private void PrevRamp()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x7D68F08", Offset = "0x7D64F08", VA = "0x7D68F08")]
		private void NextRamp()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x7D690D8", Offset = "0x7D650D8", VA = "0x7D690D8")]
		public TCP2_Demo()
		{
		}
	}
}
