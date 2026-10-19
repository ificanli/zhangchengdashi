using Boxophobic.StyledGUI;
using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.Utils
{
	[Token(Token = "0x2000DFF")]
	[ExecuteInEditMode]
	public class SceneSwitch : StyledMonoBehaviour
	{
		[Token(Token = "0x40061C5")]
		[FieldOffset(Offset = "0x20")]
		[StyledBanner("Switch")]
		public bool styledBanner;

		[Token(Token = "0x40061C6")]
		[FieldOffset(Offset = "0x28")]
		public GameObject setupStandard;

		[Token(Token = "0x40061C7")]
		[FieldOffset(Offset = "0x30")]
		public GameObject setupUniversal;

		[Token(Token = "0x40061C8")]
		[FieldOffset(Offset = "0x38")]
		public GameObject setupHD;

		[Token(Token = "0x40061C9")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public GameObject objectStandard;

		[Token(Token = "0x40061CA")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public GameObject objectUniversal;

		[Token(Token = "0x40061CB")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public GameObject objectHD;

		[Token(Token = "0x40061CC")]
		[FieldOffset(Offset = "0x58")]
		[Space(10f)]
		public bool setRenderSettings;

		[Token(Token = "0x40061CD")]
		[FieldOffset(Offset = "0x60")]
		[Space(10f)]
		public Material skyboxMaterial;

		[Token(Token = "0x40061CE")]
		[FieldOffset(Offset = "0x68")]
		[Range(0f, 8f)]
		public float skyboxAmbient;

		[Token(Token = "0x40061CF")]
		[FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float skyboxReflection;

		[Token(Token = "0x40061D0")]
		[FieldOffset(Offset = "0x70")]
		[StyledSpace(5)]
		public bool styledSpace;

		[Token(Token = "0x6005675")]
		[Address(RVA = "0x433CF30", Offset = "0x4338F30", VA = "0x433CF30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005676")]
		[Address(RVA = "0x433D3F0", Offset = "0x43393F0", VA = "0x433D3F0")]
		public SceneSwitch()
		{
		}
	}
}
