using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.DemoAssets.TexturesDemo.Scripts
{
	[Token(Token = "0x2000004")]
	[CreateAssetMenu(fileName = "All1VfxDemoTextureCollection", menuName = "AllIn1Vfx/DemoTextureCollection")]
	public class All1VfxDemoTextureCollection : ScriptableObject
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		public string collectionName;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		public Texture[] demoTextureCollection;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x3CF24E4", Offset = "0x3CEE4E4", VA = "0x3CF24E4")]
		public All1VfxDemoTextureCollection()
		{
		}
	}
}
