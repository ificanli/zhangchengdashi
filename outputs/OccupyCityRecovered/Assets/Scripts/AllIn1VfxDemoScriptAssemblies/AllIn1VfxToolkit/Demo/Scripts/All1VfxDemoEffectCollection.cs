using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x2000009")]
	[CreateAssetMenu(fileName = "All1VfxDemoEffectCollection", menuName = "AllIn1Vfx/DemoEffectCollection")]
	public class All1VfxDemoEffectCollection : ScriptableObject
	{
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x18")]
		public All1VfxDemoEffect[] demoEffectCollection;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x3CEF2F8", Offset = "0x3CEB2F8", VA = "0x3CEF2F8")]
		public All1VfxDemoEffectCollection()
		{
		}
	}
}
