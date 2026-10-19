using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002D1")]
	public class HealToItemBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4002238")]
		[FieldOffset(Offset = "0x20")]
		private int healNum;

		[Token(Token = "0x4002239")]
		[FieldOffset(Offset = "0x24")]
		private float healPercent;

		[Token(Token = "0x400223A")]
		[FieldOffset(Offset = "0x28")]
		private bool usePercentHeal;

		[Token(Token = "0x400223B")]
		[FieldOffset(Offset = "0x29")]
		private bool isEnemy;

		[Token(Token = "0x400223C")]
		[FieldOffset(Offset = "0x30")]
		private List<RoleBehaviour> allTriggerRole;

		[Token(Token = "0x400223D")]
		[FieldOffset(Offset = "0x38")]
		private List<int> allTriggerRoleID;

		[Token(Token = "0x400223E")]
		[FieldOffset(Offset = "0x40")]
		private float jTime;

		[Token(Token = "0x400223F")]
		[FieldOffset(Offset = "0x44")]
		private float timeoffset;

		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x3D46DF8", Offset = "0x3D42DF8", VA = "0x3D46DF8")]
		public void Init(float num, bool isEnemy, float num2, bool usePercentHeal)
		{
		}

		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x3D46E4C", Offset = "0x3D42E4C", VA = "0x3D46E4C")]
		private float ConvertToPercent(float percentValue)
		{
			return default;
		}

		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x3D46E68", Offset = "0x3D42E68", VA = "0x3D46E68")]
		private float CalcEffScale(float x)
		{
			return default;
		}

		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x3D46E78", Offset = "0x3D42E78", VA = "0x3D46E78")]
		private void Update()
		{
		}

		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x3D4709C", Offset = "0x3D4309C", VA = "0x3D4709C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x3D47280", Offset = "0x3D43280", VA = "0x3D47280")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x3D473AC", Offset = "0x3D433AC", VA = "0x3D473AC")]
		public HealToItemBehaviour()
		{
		}
	}
}
