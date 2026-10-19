using System.Runtime.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000397")]
	public abstract class SubGameBuffBase
	{
		[Token(Token = "0x170000F7")]
		public int BuffId
		{
			[Token(Token = "0x600102B")]
			[Address(RVA = "0x3D9DA84", Offset = "0x3D99A84", VA = "0x3D9DA84")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x600102C")]
			[Address(RVA = "0x3D9DA8C", Offset = "0x3D99A8C", VA = "0x3D9DA8C")]
			[CompilerGenerated]
			protected set;
		}

		[Token(Token = "0x600102D")]
		[Address(RVA = "0x3D9DA94", Offset = "0x3D99A94", VA = "0x3D9DA94")]
		protected SubGameBuffBase(int buffId)
		{
		}

		[Token(Token = "0x600102E")]
		[Address(RVA = "0x3D9DABC", Offset = "0x3D99ABC", VA = "0x3D9DABC", Slot = "4")]
		public virtual void ModifyRoleProperty(bool isEnemy, RolePropertyTemp propertyTemp, CardFettersType fettersType, AtkWayType atkWayType, int cardLevel)
		{
		}

		[Token(Token = "0x600102F")]
		[Address(RVA = "0x3D9DAC0", Offset = "0x3D99AC0", VA = "0x3D9DAC0", Slot = "5")]
		public virtual int GetGoldCardOddBonus(int baseSssrWeight, bool isEnemyHex)
		{
			return default;
		}

		[Token(Token = "0x6001030")]
		[Address(RVA = "0x3D9DAC8", Offset = "0x3D99AC8", VA = "0x3D9DAC8", Slot = "6")]
		public virtual void ModifyArchitectureSpawnTime(ArchitecturePropertyTemp propertyTemp, bool isEnemy, RareLevel rareLevel, string architectureType)
		{
		}

		[Token(Token = "0x6001031")]
		[Address(RVA = "0x3D9DACC", Offset = "0x3D99ACC", VA = "0x3D9DACC", Slot = "7")]
		public virtual void ModifyGoldMineOutput(ref float outputBonus, bool isEnemy)
		{
		}

		[Token(Token = "0x6001032")]
		[Address(RVA = "0x3D9DAD0", Offset = "0x3D99AD0", VA = "0x3D9DAD0", Slot = "8")]
		public virtual void ModifyKillCoin(ref int coin, bool killedUnitIsEnemy)
		{
		}

		[Token(Token = "0x6001033")]
		[Address(RVA = "0x3D9DAD4", Offset = "0x3D99AD4", VA = "0x3D9DAD4", Slot = "9")]
		public virtual void OnFriendlyUnitDead(bool unitIsEnemy, Vector3 deadPosition)
		{
		}

		[Token(Token = "0x6001034")]
		[Address(RVA = "0x3D9DAD8", Offset = "0x3D99AD8", VA = "0x3D9DAD8", Slot = "10")]
		public virtual void OnHexOpened(bool isEnemyHex)
		{
		}

		[Token(Token = "0x6001035")]
		[Address(RVA = "0x3D9DADC", Offset = "0x3D99ADC", VA = "0x3D9DADC", Slot = "11")]
		public virtual void ModifyHexOpenPrice(ref int price, bool isEnemyHex)
		{
		}

		[Token(Token = "0x6001036")]
		[Address(RVA = "0x3D9DAE0", Offset = "0x3D99AE0", VA = "0x3D9DAE0", Slot = "12")]
		public virtual void OnCoinChanged(bool isEnemy, int coinAmount)
		{
		}

		[Token(Token = "0x6001037")]
		[Address(RVA = "0x3D9DAE4", Offset = "0x3D99AE4", VA = "0x3D9DAE4", Slot = "13")]
		public virtual void OnMainTowerDestroyed(bool towerIsEnemy)
		{
		}

		[Token(Token = "0x6001038")]
		[Address(RVA = "0x3D9DAE8", Offset = "0x3D99AE8", VA = "0x3D9DAE8", Slot = "14")]
		public virtual void ModifyCountDownTime(ref int countDownTime)
		{
		}

		[Token(Token = "0x6001039")]
		[Address(RVA = "0x3D9DAEC", Offset = "0x3D99AEC", VA = "0x3D9DAEC", Slot = "15")]
		public virtual void ModifyBattleTimeScale(ref float timeScale)
		{
		}

		[Token(Token = "0x600103A")]
		[Address(RVA = "0x3D9DAF0", Offset = "0x3D99AF0", VA = "0x3D9DAF0", Slot = "16")]
		public virtual float GetPropEffectScale()
		{
			return default;
		}

		[Token(Token = "0x600103B")]
		[Address(RVA = "0x3D9DAF8", Offset = "0x3D99AF8", VA = "0x3D9DAF8", Slot = "17")]
		public virtual void OnEmojiSent(bool senderIsEnemy)
		{
		}
	}
}
