using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002F5")]
	public class YggdSeedBehaviour : MonoBehaviour
	{
		[Token(Token = "0x40022CE")]
		[FieldOffset(Offset = "0x20")]
		private float addNum;

		[Token(Token = "0x40022CF")]
		[FieldOffset(Offset = "0x24")]
		private bool isEnemy;

		[Token(Token = "0x40022D0")]
		[FieldOffset(Offset = "0x28")]
		private List<RoleBehaviour> allTriggerRole;

		[Token(Token = "0x40022D1")]
		[FieldOffset(Offset = "0x30")]
		private List<int> allTriggerRoleID;

		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x3D5695C", Offset = "0x3D5295C", VA = "0x3D5695C")]
		public void Init(float num, bool isEnemy, float num2)
		{
		}

		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x3D56A48", Offset = "0x3D52A48", VA = "0x3D56A48")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x3D56DE4", Offset = "0x3D52DE4", VA = "0x3D56DE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x3D570C8", Offset = "0x3D530C8", VA = "0x3D570C8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x3D57388", Offset = "0x3D53388", VA = "0x3D57388")]
		private void HasRoleDead(object o)
		{
		}

		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x3D57660", Offset = "0x3D53660", VA = "0x3D57660")]
		public YggdSeedBehaviour()
		{
		}
	}
}
