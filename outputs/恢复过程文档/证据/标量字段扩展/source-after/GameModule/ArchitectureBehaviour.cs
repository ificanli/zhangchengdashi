using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using DataModule;
using Il2CppDummyDll;
using Pathfinding;
using UIModuleO;
using UnityEngine;
using UnityEngine.Events;

namespace GameModule
{
	[Token(Token = "0x2000248")]
	public class ArchitectureBehaviour : EntityBase
	{
		[Token(Token = "0x4001E56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ArchitecturePropertyTemp PropertyTemp;

		[Token(Token = "0x4001E57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected float FrontTime;

		[Token(Token = "0x4001E58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityAction _hexCallBack;

		[Token(Token = "0x4001E59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _defenceRatio;

		[Token(Token = "0x4001E5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected float _offsetRatio;

		[Token(Token = "0x4001E5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _tempDamageReflectRatio;

		[Token(Token = "0x4001E5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected int CardLevel;

		[Token(Token = "0x4001E5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected RareLevel RareLevel;

		[Token(Token = "0x4001E5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected SpawnTimeProgressUI ProgressUI;

		[Token(Token = "0x4001E5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _bornScale;

		[Token(Token = "0x4001E60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected HexBehaviour hex;

		[Token(Token = "0x4001E61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public CardFettersType CardFettersType;

		[Token(Token = "0x4001E62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public AtkWayType AtkWayType;

		[Token(Token = "0x4001E63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GraphUpdateScene uc;

		[Token(Token = "0x4001E64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool InitEnd;

		[Token(Token = "0x4001E65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float _logicTime;

		[Token(Token = "0x4001E66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _lastRealTime;

		[Token(Token = "0x4001E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _humanFetter6LastGoldTime;

		[Token(Token = "0x4001E68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private MeshRenderer meshRenderer;

		[Token(Token = "0x4001E69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private MaterialPropertyBlock propertyBlock;

		[Token(Token = "0x4001E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public CardTalentTreeData TalentTreeData;

		[Token(Token = "0x4001E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected List<TalentBase> allTalent;

		[Token(Token = "0x4001E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected List<TalentBase> allTalent2;

		[Token(Token = "0x4001E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private StringBuilder _textBuilder;

		[Token(Token = "0x4001E6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected float calcTime;

		[Token(Token = "0x170000C1")]
		protected float LogicTime
		{
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x42958B0", Offset = "0x42918B0", VA = "0x42958B0")]
			get
			{
				return _logicTime;
			}
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x42958B8", Offset = "0x42918B8", VA = "0x42958B8", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x4295A80", Offset = "0x4291A80", VA = "0x4295A80", Slot = "8")]
		public virtual void Init(HexBehaviour hex, GlobalArchitectureInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] UnityAction callBack, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x4296220", Offset = "0x4292220", VA = "0x4296220", Slot = "9")]
		protected virtual void InitTalent()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x4296024", Offset = "0x4292024", VA = "0x4296024")]
		private void InitGraphUpdateScene(bool isEnemyBuild)
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x42965E4", Offset = "0x42925E4", VA = "0x42965E4")]
		private bool ShouldSkipGraphUpdateScene()
		{
			return default;
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x4296140", Offset = "0x4292140", VA = "0x4296140")]
		protected void OnInitTalentTrigger()
		{
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x42965EC", Offset = "0x42925EC", VA = "0x42965EC")]
		public void SetDarkenColor(Color color)
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x4295E64", Offset = "0x4291E64", VA = "0x4295E64")]
		private void FetterChangeCreatSpeed()
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x42969EC", Offset = "0x42929EC", VA = "0x42969EC", Slot = "5")]
		public override void MyUpdate()
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x42970EC", Offset = "0x42930EC", VA = "0x42970EC", Slot = "10")]
		protected virtual bool ShouldPerformLogic()
		{
			return default;
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x42970F4", Offset = "0x42930F4", VA = "0x42970F4", Slot = "4")]
		public override void Wound(int damage, string id, [Optional][DefaultParameterValue(false)] bool isBuild, [Optional] EntityBase target, [Optional][DefaultParameterValue(false)] bool isLandRole, [Optional][DefaultParameterValue(0)] AtkWayType atkWayType, [Optional][DefaultParameterValue(4)] CardFettersType fetterType, [Optional] Object linkAttackObj)
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x4297610", Offset = "0x4293610", VA = "0x4297610", Slot = "11")]
		protected virtual void WoundPuiiHpLogic(int num, string id, bool isBuild, EntityBase target)
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x4297E24", Offset = "0x4293E24", VA = "0x4297E24")]
		public void AddTempDamageReflect(float ratio)
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x4297E34", Offset = "0x4293E34", VA = "0x4297E34", Slot = "12")]
		protected virtual void Dead()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x429894C", Offset = "0x429494C", VA = "0x429894C", Slot = "13")]
		protected virtual void PerformLogic()
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x4298950", Offset = "0x4294950", VA = "0x4298950")]
		private void ChangeRatio(object o)
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x429873C", Offset = "0x429473C", VA = "0x429873C")]
		public void UIHide()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x4298A94", Offset = "0x4294A94", VA = "0x4298A94")]
		private int GetRareLevelValue(RareLevel rareLevel)
		{
			return default;
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x4298AAC", Offset = "0x4294AAC", VA = "0x4298AAC", Slot = "14")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x4298D3C", Offset = "0x4294D3C", VA = "0x4298D3C")]
		public ArchitectureBehaviour()
		{
		}
	}
}
