using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20003D1")]
	public class DecorationAnimationBehaviour : MonoBehaviour
	{
		[Token(Token = "0x40026B5")]
		[FieldOffset(Offset = "0x20")]
		private bool ro;

		[Token(Token = "0x40026B6")]
		[FieldOffset(Offset = "0x24")]
		private float ftime;

		[Token(Token = "0x40026B7")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 moveDir;

		[Token(Token = "0x40026B8")]
		[FieldOffset(Offset = "0x34")]
		public MoveType moveType;

		[Token(Token = "0x6001130")]
		[Address(RVA = "0x3DAD4D0", Offset = "0x3DA94D0", VA = "0x3DAD4D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6001131")]
		[Address(RVA = "0x3DAD594", Offset = "0x3DA9594", VA = "0x3DAD594")]
		private void Update()
		{
		}

		[Token(Token = "0x6001132")]
		[Address(RVA = "0x3DAD638", Offset = "0x3DA9638", VA = "0x3DAD638")]
		public DecorationAnimationBehaviour()
		{
		}
	}
}
