using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000022")]
	public class ShieldImpact : MonoBehaviour
	{
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x20")]
		private float impactTime;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x28")]
		private Material impactMat;

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x73B6AAC", Offset = "0x73B2AAC", VA = "0x73B6AAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x73B6B3C", Offset = "0x73B2B3C", VA = "0x73B6B3C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x73B6BD8", Offset = "0x73B2BD8", VA = "0x73B6BD8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x73B6D28", Offset = "0x73B2D28", VA = "0x73B6D28")]
		public ShieldImpact()
		{
		}
	}
}
