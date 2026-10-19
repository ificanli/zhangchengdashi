using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x2000005")]
	[RequireComponent(typeof(AllIn1MouseRotate))]
	public class All1DemoMouseLocker : MonoBehaviour
	{
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private KeyCode mouseLockerKey;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image lockButtonImage;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color lockButtonColor;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x40")]
		private AllIn1MouseRotate allIn1MouseRotate;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x48")]
		private AllIn1DemoScaleTween lockedTween;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x50")]
		private Text pausedButtonText;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x58")]
		private bool currentlyLocked;

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3CEEE44", Offset = "0x3CEAE44", VA = "0x3CEEE44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3CEEEF0", Offset = "0x3CEAEF0", VA = "0x3CEEEF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x3CEEF1C", Offset = "0x3CEAF1C", VA = "0x3CEEF1C")]
		public void DoMouseLockToggle()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x3CEF048", Offset = "0x3CEB048", VA = "0x3CEF048")]
		public All1DemoMouseLocker()
		{
		}
	}
}
