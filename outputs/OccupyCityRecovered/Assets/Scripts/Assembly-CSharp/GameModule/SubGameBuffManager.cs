using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000398")]
	public class SubGameBuffManager
	{
		[Token(Token = "0x4002614")]
		[FieldOffset(Offset = "0x0")]
		private static SubGameBuffManager _instance;

		[Token(Token = "0x4002615")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<SubGameBuffBase> _activeBuffs;

		[Token(Token = "0x4002616")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<int> _activeBuffIds;

		[Token(Token = "0x4002617")]
		[FieldOffset(Offset = "0x20")]
		private bool _isActive;

		[Token(Token = "0x4002618")]
		[FieldOffset(Offset = "0x24")]
		private int _inflationPlayerOpenCount;

		[Token(Token = "0x4002619")]
		[FieldOffset(Offset = "0x28")]
		private int _inflationEnemyOpenCount;

		[Token(Token = "0x400261A")]
		[FieldOffset(Offset = "0x2C")]
		private float _battleTimeScaleBeforeBuff;

		[Token(Token = "0x400261B")]
		[FieldOffset(Offset = "0x30")]
		private bool _battleTimeScaleApplied;

		[Token(Token = "0x400261C")]
		[FieldOffset(Offset = "0x31")]
		private bool _emojiEventsRegistered;

		[Token(Token = "0x400261D")]
		[FieldOffset(Offset = "0x32")]
		private bool _hexOpenEventRegistered;

		[Token(Token = "0x400261E")]
		[FieldOffset(Offset = "0x33")]
		private bool _battleTimeScaleEventsRegistered;

		[Token(Token = "0x170000F8")]
		public static SubGameBuffManager Instance
		{
			[Token(Token = "0x600103C")]
			[Address(RVA = "0x3D912E8", Offset = "0x3D8D2E8", VA = "0x3D912E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F9")]
		public bool IsActive
		{
			[Token(Token = "0x600103D")]
			[Address(RVA = "0x3D9DBC8", Offset = "0x3D99BC8", VA = "0x3D9DBC8")]
			get
			{
				return _isActive;
			}
		}

		[Token(Token = "0x170000FA")]
		public int InflationPlayerOpenCount
		{
			[Token(Token = "0x600103E")]
			[Address(RVA = "0x3D9DBD0", Offset = "0x3D99BD0", VA = "0x3D9DBD0")]
			get
			{
				return _inflationPlayerOpenCount;
			}
		}

		[Token(Token = "0x170000FB")]
		public int InflationEnemyOpenCount
		{
			[Token(Token = "0x600103F")]
			[Address(RVA = "0x3D9DBD8", Offset = "0x3D99BD8", VA = "0x3D9DBD8")]
			get
			{
				return _inflationEnemyOpenCount;
			}
		}

		[Token(Token = "0x6001040")]
		[Address(RVA = "0x3D9DBE0", Offset = "0x3D99BE0", VA = "0x3D9DBE0")]
		public List<int> GetActiveBuffIds()
		{
			return null;
		}

		[Token(Token = "0x6001041")]
		[Address(RVA = "0x3D9DC5C", Offset = "0x3D99C5C", VA = "0x3D9DC5C")]
		public void Init(BattleContext battleContext)
		{
		}

		[Token(Token = "0x6001042")]
		[Address(RVA = "0x3D9E600", Offset = "0x3D9A600", VA = "0x3D9E600")]
		public void Reset()
		{
		}

		[Token(Token = "0x6001043")]
		[Address(RVA = "0x3D9DF08", Offset = "0x3D99F08", VA = "0x3D9DF08")]
		private void ResetInternal()
		{
		}

		[Token(Token = "0x6001044")]
		[Address(RVA = "0x3D9E0F0", Offset = "0x3D9A0F0", VA = "0x3D9E0F0")]
		private void RegisterEmojiEvents()
		{
		}

		[Token(Token = "0x6001045")]
		[Address(RVA = "0x3D9E818", Offset = "0x3D9A818", VA = "0x3D9E818")]
		private void UnregisterEmojiEvents()
		{
		}

		[Token(Token = "0x6001046")]
		[Address(RVA = "0x3D9E280", Offset = "0x3D9A280", VA = "0x3D9E280")]
		private void RegisterHexOpenEvent()
		{
		}

		[Token(Token = "0x6001047")]
		[Address(RVA = "0x3D9E9A4", Offset = "0x3D9A9A4", VA = "0x3D9E9A4")]
		private void UnregisterHexOpenEvent()
		{
		}

		[Token(Token = "0x6001048")]
		[Address(RVA = "0x3D9EABC", Offset = "0x3D9AABC", VA = "0x3D9EABC")]
		private void OnHasHexOpen(object o)
		{
		}

		[Token(Token = "0x6001049")]
		[Address(RVA = "0x3D9EC38", Offset = "0x3D9AC38", VA = "0x3D9EC38")]
		private void OnPlayerSendEmoji(object o)
		{
		}

		[Token(Token = "0x600104A")]
		[Address(RVA = "0x3D9ECF0", Offset = "0x3D9ACF0", VA = "0x3D9ECF0")]
		private void OnEnemySendEmoji(object o)
		{
		}

		[Token(Token = "0x600104B")]
		[Address(RVA = "0x3D9ECF8", Offset = "0x3D9ACF8", VA = "0x3D9ECF8")]
		public void ModifyRoleProperty(bool isEnemy, RolePropertyTemp propertyTemp, CardFettersType fettersType, AtkWayType atkWayType, int cardLevel)
		{
		}

		[Token(Token = "0x600104C")]
		[Address(RVA = "0x3D9EDD8", Offset = "0x3D9ADD8", VA = "0x3D9EDD8")]
		public int GetGoldCardOddBonus(int baseSssrWeight, bool isEnemyHex)
		{
			return default;
		}

		[Token(Token = "0x600104D")]
		[Address(RVA = "0x3D9EEB0", Offset = "0x3D9AEB0", VA = "0x3D9EEB0")]
		public void ModifyArchitectureSpawnTime(ArchitecturePropertyTemp propertyTemp, bool isEnemy, RareLevel rareLevel, string architectureType)
		{
		}

		[Token(Token = "0x600104E")]
		[Address(RVA = "0x3D9EF80", Offset = "0x3D9AF80", VA = "0x3D9EF80")]
		public void ModifyGoldMineOutput(ref float outputBonus, bool isEnemy)
		{
		}

		[Token(Token = "0x600104F")]
		[Address(RVA = "0x3D91430", Offset = "0x3D8D430", VA = "0x3D91430")]
		public void ModifyKillCoin(ref int coin, bool killedUnitIsEnemy)
		{
		}

		[Token(Token = "0x6001050")]
		[Address(RVA = "0x3D9135C", Offset = "0x3D8D35C", VA = "0x3D9135C")]
		public void OnFriendlyUnitDead(bool unitIsEnemy, Vector3 deadPosition)
		{
		}

		[Token(Token = "0x6001051")]
		[Address(RVA = "0x3D9F034", Offset = "0x3D9B034", VA = "0x3D9F034")]
		public void OnActiveHexOpened(bool openerIsEnemy)
		{
		}

		[Token(Token = "0x6001052")]
		[Address(RVA = "0x3D9F2A0", Offset = "0x3D9B2A0", VA = "0x3D9F2A0")]
		public void NotifyHexOwnershipChanged(HexBehaviour hex)
		{
		}

		[Token(Token = "0x6001053")]
		[Address(RVA = "0x3D9EB8C", Offset = "0x3D9AB8C", VA = "0x3D9EB8C")]
		public void OnHexOpened(bool isEnemyHex)
		{
		}

		[Token(Token = "0x6001054")]
		[Address(RVA = "0x3D9F094", Offset = "0x3D9B094", VA = "0x3D9F094")]
		public bool HasBuff(int buffId)
		{
			return default;
		}

		[Token(Token = "0x6001055")]
		[Address(RVA = "0x3D9F33C", Offset = "0x3D9B33C", VA = "0x3D9F33C")]
		public void ModifyHexOpenPrice(ref int price, bool isEnemyHex)
		{
		}

		[Token(Token = "0x6001056")]
		[Address(RVA = "0x3D9F3F0", Offset = "0x3D9B3F0", VA = "0x3D9F3F0")]
		public void OnCoinChanged(bool isEnemy, int coinAmount)
		{
		}

		[Token(Token = "0x6001057")]
		[Address(RVA = "0x3D9F4A4", Offset = "0x3D9B4A4", VA = "0x3D9F4A4")]
		public void OnMainTowerDestroyed(bool towerIsEnemy)
		{
		}

		[Token(Token = "0x6001058")]
		[Address(RVA = "0x3D9F554", Offset = "0x3D9B554", VA = "0x3D9F554")]
		public void ModifyCountDownTime(ref int countDownTime)
		{
		}

		[Token(Token = "0x6001059")]
		[Address(RVA = "0x3D9E39C", Offset = "0x3D9A39C", VA = "0x3D9E39C")]
		private void RegisterBattleTimeScaleEvents()
		{
		}

		[Token(Token = "0x600105A")]
		[Address(RVA = "0x3D9E68C", Offset = "0x3D9A68C", VA = "0x3D9E68C")]
		private void UnregisterBattleTimeScaleEvents()
		{
		}

		[Token(Token = "0x600105B")]
		[Address(RVA = "0x3D9F600", Offset = "0x3D9B600", VA = "0x3D9F600")]
		private void OnCloseMatchPanel(object o)
		{
		}

		[Token(Token = "0x600105C")]
		[Address(RVA = "0x3D9F77C", Offset = "0x3D9B77C", VA = "0x3D9F77C")]
		private void OnBattleGameEnd(object o)
		{
		}

		[Token(Token = "0x600105D")]
		[Address(RVA = "0x3D9F604", Offset = "0x3D9B604", VA = "0x3D9F604")]
		public void ApplyBattleTimeScale()
		{
		}

		[Token(Token = "0x600105E")]
		[Address(RVA = "0x3D9E604", Offset = "0x3D9A604", VA = "0x3D9E604")]
		private void RestoreBattleTimeScale()
		{
		}

		[Token(Token = "0x600105F")]
		[Address(RVA = "0x3D9F780", Offset = "0x3D9B780", VA = "0x3D9F780")]
		public float GetPropEffectScale()
		{
			return default;
		}

		[Token(Token = "0x6001060")]
		[Address(RVA = "0x3D9F834", Offset = "0x3D9B834", VA = "0x3D9F834")]
		public void ApplyPropEffectScale(ref float num1, ref float num2)
		{
		}

		[Token(Token = "0x6001061")]
		[Address(RVA = "0x3D9F8E0", Offset = "0x3D9B8E0", VA = "0x3D9F8E0")]
		public bool IsYouAreCryingActive()
		{
			return default;
		}

		[Token(Token = "0x6001062")]
		[Address(RVA = "0x3D9F8F8", Offset = "0x3D9B8F8", VA = "0x3D9F8F8")]
		public int GetAiEmojiIntervalSeconds()
		{
			return default;
		}

		[Token(Token = "0x6001063")]
		[Address(RVA = "0x3D9F930", Offset = "0x3D9B930", VA = "0x3D9F930")]
		public int GetAiEmojiSendChance()
		{
			return default;
		}

		[Token(Token = "0x6001064")]
		[Address(RVA = "0x3D9F968", Offset = "0x3D9B968", VA = "0x3D9F968")]
		public float GetAiEmojiCooldownSeconds()
		{
			return default;
		}

		[Token(Token = "0x6001065")]
		[Address(RVA = "0x3D9F988", Offset = "0x3D9B988", VA = "0x3D9F988")]
		public int GetAiEmojiReactionChance()
		{
			return default;
		}

		[Token(Token = "0x6001066")]
		[Address(RVA = "0x3D9F9C0", Offset = "0x3D9B9C0", VA = "0x3D9F9C0")]
		public float GetAiEmojiPlayerReplyDelaySeconds()
		{
			return default;
		}

		[Token(Token = "0x6001067")]
		[Address(RVA = "0x3D9EC40", Offset = "0x3D9AC40", VA = "0x3D9EC40")]
		private void OnEmojiSent(bool senderIsEnemy)
		{
		}

		[Token(Token = "0x6001068")]
		[Address(RVA = "0x3D9F138", Offset = "0x3D9B138", VA = "0x3D9F138")]
		private void RefreshInflationPricesForSide(bool forEnemySide)
		{
		}

		[Token(Token = "0x6001069")]
		[Address(RVA = "0x3D9F9F8", Offset = "0x3D9B9F8", VA = "0x3D9F9F8")]
		public static RoleBehaviour FindMaxCurrentHpRole(bool targetIsEnemy)
		{
			return null;
		}

		[Token(Token = "0x600106A")]
		[Address(RVA = "0x3D9DAFC", Offset = "0x3D99AFC", VA = "0x3D9DAFC")]
		public SubGameBuffManager()
		{
		}
	}
}
