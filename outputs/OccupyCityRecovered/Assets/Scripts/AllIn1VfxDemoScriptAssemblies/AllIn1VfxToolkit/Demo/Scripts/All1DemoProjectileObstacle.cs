using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x2000006")]
	public class All1DemoProjectileObstacle : MonoBehaviour
	{
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] projectileObstacles;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x28")]
		private Dropdown projectileObstacleDropdown;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3CEF058", Offset = "0x3CEB058", VA = "0x3CEF058")]
		private void Start()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3CEF0AC", Offset = "0x3CEB0AC", VA = "0x3CEF0AC")]
		public void DropdownValueChanged()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3CEF0C8", Offset = "0x3CEB0C8", VA = "0x3CEF0C8")]
		private void SetProjectileObstacleN(int nIndex)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3CEF134", Offset = "0x3CEB134", VA = "0x3CEF134")]
		public All1DemoProjectileObstacle()
		{
		}
	}
}
