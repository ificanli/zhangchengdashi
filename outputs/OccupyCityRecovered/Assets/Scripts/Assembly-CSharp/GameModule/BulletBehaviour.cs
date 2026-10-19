using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace GameModule
{
	[Token(Token = "0x2000262")]
	public class BulletBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4001EEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected EntityBase _target;

		[Token(Token = "0x4001EEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected int attack;

		[Token(Token = "0x4001EF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		protected Vector3 _endPos;

		[Token(Token = "0x4001EF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool _isEffBullet;

		[Token(Token = "0x4001EF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected UnityAction callback;

		[Token(Token = "0x4001EF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected CardFettersType fettersType;

		[Token(Token = "0x4001EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected string id;

		[Token(Token = "0x4001EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected bool isBuild;

		[Token(Token = "0x4001EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		protected bool isLandBullet;

		[Token(Token = "0x4001EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		protected bool isEnemy;

		[Token(Token = "0x4001EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		protected bool isExcludeWall;

		[Token(Token = "0x4001EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected bool arrowToWall;

		[Token(Token = "0x4001EFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected EntityBase fireObj;

		[Token(Token = "0x4001EFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected bool isLand;

		[Token(Token = "0x4001EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected AtkWayType AtkWayType;

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x4384324", Offset = "0x4380324", VA = "0x4384324", Slot = "4")]
		public virtual void InitInfo(EntityBase obj, int atk, bool isEnemy, bool isEffBullet, [Optional] EntityBase fireObj, bool isLand = true, CardFettersType fettersType = CardFettersType.Null)
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x437F69C", Offset = "0x437B69C", VA = "0x437F69C")]
		public void AddCallBack(UnityAction action)
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x43845DC", Offset = "0x43805DC", VA = "0x43845DC")]
		public void InitID(string id)
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x43845E4", Offset = "0x43805E4", VA = "0x43845E4")]
		public void IsBuild(bool isBuild)
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x437F690", Offset = "0x437B690", VA = "0x437F690")]
		public void ExcludeWall()
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x43845F0", Offset = "0x43805F0", VA = "0x43845F0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x438463C", Offset = "0x438063C", VA = "0x438463C", Slot = "6")]
		protected virtual void BulletLogic()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x4384E0C", Offset = "0x4380E0C", VA = "0x4384E0C", Slot = "7")]
		protected virtual void Rebound()
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x4384F50", Offset = "0x4380F50", VA = "0x4384F50", Slot = "8")]
		protected virtual void BulletDamageLogic()
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x43851C4", Offset = "0x43811C4", VA = "0x43851C4", Slot = "9")]
		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x43854A4", Offset = "0x43814A4", VA = "0x43854A4", Slot = "10")]
		protected virtual void Clear()
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x4385610", Offset = "0x4381610", VA = "0x4385610")]
		public BulletBehaviour()
		{
		}
	}
}
