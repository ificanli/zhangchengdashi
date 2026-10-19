using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace GameModule
{
	[Token(Token = "0x2000247")]
	public class GameEventArgs
	{
		[Token(Token = "0x4001E4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool IsRole;

		[Token(Token = "0x4001E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EntityBase Source;

		[Token(Token = "0x4001E51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EntityBase EnemyTarget;

		[Token(Token = "0x4001E52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<RoleBehaviour> TeamMateTargetList;

		[Token(Token = "0x4001E53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float ValueNumber;

		[Token(Token = "0x4001E54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float ValueNumber2;

		[Token(Token = "0x4001E55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityAction CallBack;

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x4295848", Offset = "0x4291848", VA = "0x4295848")]
		public GameEventArgs(EntityBase source, EntityBase enemyTarget, List<RoleBehaviour> teamMateTargetList, float value1, [Optional][DefaultParameterValue(0f)] float value2, [Optional][DefaultParameterValue(false)] bool isRole, [Optional] UnityAction callBack)
		{
		}
	}
}
