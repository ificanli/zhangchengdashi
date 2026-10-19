using Il2CppDummyDll;
using UnityEngine;

namespace FishFlock
{
	[Token(Token = "0x2000DDD")]
	public class FlockPredator : MonoBehaviour
	{
		[Token(Token = "0x400614B")]
		[FieldOffset(Offset = "0x20")]
		public float fleeRadius;

		[Token(Token = "0x400614C")]
		[FieldOffset(Offset = "0x24")]
		public bool drawGizmos;

		[Token(Token = "0x6005603")]
		[Address(RVA = "0x4339C1C", Offset = "0x4335C1C", VA = "0x4339C1C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6005604")]
		[Address(RVA = "0x4339C6C", Offset = "0x4335C6C", VA = "0x4339C6C")]
		public FlockPredator()
		{
		}
	}
}
