using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x2000008")]
	[AddComponentMenu("")]
	public class LODBackupComponent : MonoBehaviour
	{
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Renderer[] originalRenderers;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public GameObject lodParentObject;

		[Token(Token = "0x17000001")]
		public Renderer[] OriginalRenderers
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x854F154", Offset = "0x854B154", VA = "0x854F154")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x854F15C", Offset = "0x854B15C", VA = "0x854F15C")]
			set
			{
			}
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x854F164", Offset = "0x854B164", VA = "0x854F164")]
		public LODBackupComponent()
		{
		}
	}
}
