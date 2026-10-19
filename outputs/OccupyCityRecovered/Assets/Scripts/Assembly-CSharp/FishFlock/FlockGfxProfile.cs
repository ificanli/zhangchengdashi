using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace FishFlock
{
	[Token(Token = "0x2000DD8")]
	[CreateAssetMenu(fileName = "New FlockGfxProfile", menuName = "Fish Flock/Create Flock Gfx Profile")]
	public class FlockGfxProfile : ScriptableObject
	{
		[Token(Token = "0x4006101")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("The prefab that will be instantiated to manipulate the fishes. If you are using instancing this is not going to be used.")]
		public GameObject prefab;

		[Token(Token = "0x4006102")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Mesh to be drawn when using instancing.")]
		public Mesh mesh;

		[Token(Token = "0x4006103")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Instanced Material to be used to draw the fishes.")]
		public Material material;

		[Token(Token = "0x4006104")]
		[FieldOffset(Offset = "0x30")]
		public ShadowCastingMode shadowCasting;

		[Token(Token = "0x4006105")]
		[FieldOffset(Offset = "0x34")]
		public bool receiveShadows;

		[Token(Token = "0x60055ED")]
		[Address(RVA = "0x43363DC", Offset = "0x43323DC", VA = "0x43363DC")]
		public FlockGfxProfile()
		{
		}
	}
}
