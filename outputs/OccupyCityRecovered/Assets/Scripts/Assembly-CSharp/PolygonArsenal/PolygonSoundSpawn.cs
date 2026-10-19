using Il2CppDummyDll;
using UnityEngine;

namespace PolygonArsenal
{
	[Token(Token = "0x2000CB3")]
	public class PolygonSoundSpawn : MonoBehaviour
	{
		[Token(Token = "0x4005B24")]
		[FieldOffset(Offset = "0x20")]
		public GameObject prefabSound;

		[Token(Token = "0x4005B25")]
		[FieldOffset(Offset = "0x28")]
		public bool destroyWhenDone;

		[Token(Token = "0x4005B26")]
		[FieldOffset(Offset = "0x29")]
		public bool soundPrefabIsChild;

		[Token(Token = "0x4005B27")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0.01f, 10f)]
		public float pitchRandomMultiplier;

		[Token(Token = "0x6004FC0")]
		[Address(RVA = "0x42B9E64", Offset = "0x42B5E64", VA = "0x42B9E64")]
		private void Start()
		{
		}

		[Token(Token = "0x6004FC1")]
		[Address(RVA = "0x42BA0B4", Offset = "0x42B60B4", VA = "0x42BA0B4")]
		public PolygonSoundSpawn()
		{
		}
	}
}
