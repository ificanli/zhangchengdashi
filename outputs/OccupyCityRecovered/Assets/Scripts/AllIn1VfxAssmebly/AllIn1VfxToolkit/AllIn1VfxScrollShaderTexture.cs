using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit
{
	[Token(Token = "0x2000016")]
	public class AllIn1VfxScrollShaderTexture : MonoBehaviour
	{
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string texturePropertyName;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 scrollSpeed;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("True changes tex offset, false to change tex scale")]
		[Space]
		private bool textureOffset;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x31")]
		[Header("There are 3 modifiers, just pick 1")]
		[Space]
		[SerializeField]
		private bool backAndForth;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector2 maxValue;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 iniValue;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x44")]
		private bool goingUpX;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x45")]
		private bool goingUpY;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x46")]
		[Space]
		[SerializeField]
		private bool applyModulo;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 modulo;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x50")]
		[Space]
		[SerializeField]
		private bool stopAtValue;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector2 stopValue;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x60")]
		[Space]
		[SerializeField]
		[Header("If missing uses an instance of the currently used Material")]
		private Material mat;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x68")]
		private Material originalMat;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x70")]
		private bool restoreMaterialOnDisable;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x74")]
		private int propertyShaderID;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 currValue;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x80")]
		private bool isValid;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x3CEE394", Offset = "0x3CEA394", VA = "0x3CEE394")]
		private void Start()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x3CEE6D4", Offset = "0x3CEA6D4", VA = "0x3CEE6D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x3CEE960", Offset = "0x3CEA960", VA = "0x3CEE960")]
		private void FlipGoingUp(bool isXComponent)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x3CEE640", Offset = "0x3CEA640", VA = "0x3CEE640")]
		private void DestroyComponentAndLogError(string logError)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x3CEE998", Offset = "0x3CEA998", VA = "0x3CEE998")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x3CEE9CC", Offset = "0x3CEA9CC", VA = "0x3CEE9CC")]
		public AllIn1VfxScrollShaderTexture()
		{
		}
	}
}
