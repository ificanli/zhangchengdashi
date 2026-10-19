using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20003D2")]
	public class FollowBehaviour : MonoBehaviour
	{
		[Token(Token = "0x40026B9")]
		[FieldOffset(Offset = "0x20")]
		private Transform followTransform;

		[Token(Token = "0x6001133")]
		[Address(RVA = "0x3DAD640", Offset = "0x3DA9640", VA = "0x3DAD640")]
		public void InitInfo(Transform follow)
		{
		}

		[Token(Token = "0x6001134")]
		[Address(RVA = "0x3DAD648", Offset = "0x3DA9648", VA = "0x3DAD648")]
		private void Update()
		{
		}

		[Token(Token = "0x6001135")]
		[Address(RVA = "0x3DAD72C", Offset = "0x3DA972C", VA = "0x3DAD72C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6001136")]
		[Address(RVA = "0x3DAD734", Offset = "0x3DA9734", VA = "0x3DAD734")]
		public FollowBehaviour()
		{
		}
	}
}
