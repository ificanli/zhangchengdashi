using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002E1")]
	public class SacrDaggerProp : PropBase
	{
		[Token(Token = "0x4002287")]
		private const float BlastRadius = 3f;

		[Token(Token = "0x4002288")]
		private const float SelectRadius = 8f;

		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x3D4E024", Offset = "0x3D4A024", VA = "0x3D4E024")]
		public SacrDaggerProp(string id)
		{
		}

		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x3D4E02C", Offset = "0x3D4A02C", VA = "0x3D4E02C", Slot = "4")]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0x3D4E044", Offset = "0x3D4A044", VA = "0x3D4E044", Slot = "5")]
		public override void Use(bool isEnemy, List<RoleBehaviour> target, Vector3? releasePos)
		{
		}
	}
}
