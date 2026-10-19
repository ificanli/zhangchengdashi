using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x2000004")]
	[RequireComponent(typeof(Dropdown))]
	public class All1DemoDropdownScroller : MonoBehaviour
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int dropdownElementCount;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private KeyCode nextDropdownElementKey;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		private Dropdown dropdown;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x3CEED78", Offset = "0x3CEAD78", VA = "0x3CEED78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x3CEEDC8", Offset = "0x3CEADC8", VA = "0x3CEEDC8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x3CEEDF4", Offset = "0x3CEADF4", VA = "0x3CEEDF4")]
		private void NextDropdownElements()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x3CEEE34", Offset = "0x3CEAE34", VA = "0x3CEEE34")]
		public All1DemoDropdownScroller()
		{
		}
	}
}
