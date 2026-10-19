using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit
{
	[Token(Token = "0x2000015")]
	public class AllIn1VfxScrollShaderProperty : MonoBehaviour
	{
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string numericPropertyName;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float scrollSpeed;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x2C")]
		[Header("There are 3 modifiers, just pick 1")]
		[Space]
		[SerializeField]
		private bool backAndForth;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float maxValue;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x34")]
		private float iniValue;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x38")]
		private bool goingUp;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		[Space]
		private bool applyModulo;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float modulo;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x40")]
		[Space]
		[SerializeField]
		private bool stopAtValue;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float stopValue;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x48")]
		[Space]
		[SerializeField]
		[Header("If missing uses an instance of the currently used Material")]
		private Material mat;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x50")]
		private Material originalMat;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x58")]
		private bool restoreMaterialOnDisable;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x5C")]
		private int propertyShaderID;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x60")]
		private float currValue;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x64")]
		private bool isValid;

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x3CEDE2C", Offset = "0x3CE9E2C", VA = "0x3CEDE2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x3CEE10C", Offset = "0x3CEA10C", VA = "0x3CEE10C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x3CEE2DC", Offset = "0x3CEA2DC", VA = "0x3CEE2DC")]
		private void FlipGoingUp()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x3CEE078", Offset = "0x3CEA078", VA = "0x3CEE078")]
		private void DestroyComponentAndLogError(string logError)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x3CEE2F8", Offset = "0x3CEA2F8", VA = "0x3CEE2F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3CEE32C", Offset = "0x3CEA32C", VA = "0x3CEE32C")]
		public AllIn1VfxScrollShaderProperty()
		{
		}
	}
}
