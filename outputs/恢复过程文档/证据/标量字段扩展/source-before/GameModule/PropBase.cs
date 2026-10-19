using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000240")]
	public abstract class PropBase
	{
		[Token(Token = "0x4001E37")]
		[FieldOffset(Offset = "0x10")]
		protected string propId;

		[Token(Token = "0x4001E38")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		[Token(Token = "0x4001E39")]
		[FieldOffset(Offset = "0x1C")]
		protected float num1;

		[Token(Token = "0x4001E3A")]
		[FieldOffset(Offset = "0x20")]
		protected float num2;

		[Token(Token = "0x4001E3B")]
		[FieldOffset(Offset = "0x28")]
		protected GlobalPropInfo info;

		[Token(Token = "0x4001E3C")]
		[FieldOffset(Offset = "0x30")]
		protected bool isEnemy;

		[Token(Token = "0x4001E3D")]
		[FieldOffset(Offset = "0x31")]
		protected bool gameEnd;

		[Token(Token = "0x170000BB")]
		public float ConfigNum1
		{
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x4294C3C", Offset = "0x4290C3C", VA = "0x4294C3C")]
			get
			{
				return num1;
			}
		}

		[Token(Token = "0x170000BC")]
		public float ConfigNum2
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x4294C44", Offset = "0x4290C44", VA = "0x4294C44")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60009A9")]
		public abstract void Use(bool isEnemy, List<RoleBehaviour> target);

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x4294C4C", Offset = "0x4290C4C", VA = "0x4294C4C", Slot = "5")]
		public virtual void Use(bool isEnemy, List<RoleBehaviour> target, Vector3? releasePos)
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x4294C5C", Offset = "0x4290C5C", VA = "0x4294C5C")]
		public PropBase()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x4294C64", Offset = "0x4290C64", VA = "0x4294C64")]
		public PropBase(string id)
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x4294D84", Offset = "0x4290D84", VA = "0x4294D84")]
		public void InitLevel(bool isEnemy)
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x4295274", Offset = "0x4291274", VA = "0x4295274")]
		protected (Vector3, bool) GetBornPosition(bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x4295404", Offset = "0x4291404", VA = "0x4295404", Slot = "6")]
		protected virtual void GameEnd(object o)
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x42954C4", Offset = "0x42914C4", VA = "0x42954C4")]
		internal static void RefreshRoleSnapshot(List<RoleBehaviour> source, List<RoleBehaviour> snapshot)
		{
		}
	}
}
