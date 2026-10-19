using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.Utils
{
	[Token(Token = "0x2000DFE")]
	public class NPCController : MonoBehaviour
	{
		[Token(Token = "0x40061C3")]
		[FieldOffset(Offset = "0x20")]
		private float timeToChangeDirection;

		[Token(Token = "0x40061C4")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 direction;

		[Token(Token = "0x6005671")]
		[Address(RVA = "0x433CE44", Offset = "0x4338E44", VA = "0x433CE44")]
		public void Start()
		{
		}

		[Token(Token = "0x6005672")]
		[Address(RVA = "0x433CEC8", Offset = "0x4338EC8", VA = "0x433CEC8")]
		public void Update()
		{
		}

		[Token(Token = "0x6005673")]
		[Address(RVA = "0x433CE48", Offset = "0x4338E48", VA = "0x433CE48")]
		private void ChangeDirection()
		{
		}

		[Token(Token = "0x6005674")]
		[Address(RVA = "0x433CF28", Offset = "0x4338F28", VA = "0x433CF28")]
		public NPCController()
		{
		}
	}
}
