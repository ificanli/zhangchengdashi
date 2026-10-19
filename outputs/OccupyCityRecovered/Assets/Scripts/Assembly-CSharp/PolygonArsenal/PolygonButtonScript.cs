using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace PolygonArsenal
{
	[Token(Token = "0x2000CA5")]
	public class PolygonButtonScript : MonoBehaviour
	{
		[Token(Token = "0x4005AC0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Button;

		[Token(Token = "0x4005AC1")]
		[FieldOffset(Offset = "0x28")]
		private Text MyButtonText;

		[Token(Token = "0x4005AC2")]
		[FieldOffset(Offset = "0x30")]
		private string projectileParticleName;

		[Token(Token = "0x4005AC3")]
		[FieldOffset(Offset = "0x38")]
		private PolygonFireProjectile effectScript;

		[Token(Token = "0x4005AC4")]
		[FieldOffset(Offset = "0x40")]
		private PolygonProjectileScript projectileScript;

		[Token(Token = "0x4005AC5")]
		[FieldOffset(Offset = "0x48")]
		public float buttonsX;

		[Token(Token = "0x4005AC6")]
		[FieldOffset(Offset = "0x4C")]
		public float buttonsY;

		[Token(Token = "0x4005AC7")]
		[FieldOffset(Offset = "0x50")]
		public float buttonsSizeX;

		[Token(Token = "0x4005AC8")]
		[FieldOffset(Offset = "0x54")]
		public float buttonsSizeY;

		[Token(Token = "0x4005AC9")]
		[FieldOffset(Offset = "0x58")]
		public float buttonsDistance;

		[Token(Token = "0x6004F4E")]
		[Address(RVA = "0x42B49FC", Offset = "0x42B09FC", VA = "0x42B49FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6004F4F")]
		[Address(RVA = "0x42B4B7C", Offset = "0x42B0B7C", VA = "0x42B4B7C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004F50")]
		[Address(RVA = "0x42B4AE4", Offset = "0x42B0AE4", VA = "0x42B4AE4")]
		public void getProjectileNames()
		{
		}

		[Token(Token = "0x6004F51")]
		[Address(RVA = "0x42B4BA8", Offset = "0x42B0BA8", VA = "0x42B4BA8")]
		public bool overButton()
		{
			return default;
		}

		[Token(Token = "0x6004F52")]
		[Address(RVA = "0x42B4C8C", Offset = "0x42B0C8C", VA = "0x42B4C8C")]
		public PolygonButtonScript()
		{
		}
	}
}
