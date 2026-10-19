using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000696")]
	public class TogglerHandler : MonoBehaviour
	{
		[Token(Token = "0x4003513")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _onRoot;

		[Token(Token = "0x4003514")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _offRoot;

		[Token(Token = "0x4003515")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Toggle _toggle;

		[Token(Token = "0x60022DD")]
		[Address(RVA = "0x3F3EFB4", Offset = "0x3F3AFB4", VA = "0x3F3EFB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60022DE")]
		[Address(RVA = "0x3F3F1E0", Offset = "0x3F3B1E0", VA = "0x3F3F1E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60022DF")]
		[Address(RVA = "0x3F3F108", Offset = "0x3F3B108", VA = "0x3F3F108")]
		public void SetOn(bool isOn)
		{
		}

		[Token(Token = "0x60022E0")]
		[Address(RVA = "0x3F3F2CC", Offset = "0x3F3B2CC", VA = "0x3F3F2CC")]
		public TogglerHandler()
		{
		}
	}
}
