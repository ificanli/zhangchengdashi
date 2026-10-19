using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002B1")]
	public class StoneWallBehaviour : EntityBase
	{
		[Token(Token = "0x4002151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int hp;

		[Token(Token = "0x4002152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int maxHp;

		[Token(Token = "0x4002153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public WallType WallType;

		[Token(Token = "0x4002154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public HexBehaviour _parentHex;

		[Token(Token = "0x4002155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GraphUpdateScene _uc;

		[Token(Token = "0x4002156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Tweener tw;

		[Token(Token = "0x4002157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _tempDamageReflectRatio;

		[Token(Token = "0x4002158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hadApply;

		[Token(Token = "0x170000D6")]
		public GraphUpdateScene uc
		{
			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x443F98C", Offset = "0x443B98C", VA = "0x443F98C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x443F994", Offset = "0x443B994", VA = "0x443F994")]
		private bool ShouldSkipGraphUpdateScene()
		{
			return default;
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x443F99C", Offset = "0x443B99C", VA = "0x443F99C")]
		private void ApplyGraphUpdateScene()
		{
		}

		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x443FA2C", Offset = "0x443BA2C", VA = "0x443FA2C")]
		private void ClearGraphTag()
		{
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x443FAD4", Offset = "0x443BAD4", VA = "0x443FAD4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x443FBC8", Offset = "0x443BBC8", VA = "0x443FBC8")]
		public void InitInfo(int hp, WallType type, bool isEnemy, HexBehaviour parentHex)
		{
		}

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x443FCF8", Offset = "0x443BCF8", VA = "0x443FCF8", Slot = "4")]
		public override void Wound(int damage, string id, [Optional][DefaultParameterValue(false)] bool isBuild, [Optional] EntityBase target, [Optional][DefaultParameterValue(false)] bool isLandRole, [Optional][DefaultParameterValue((AtkWayType)0)] AtkWayType atkWayType, [Optional][DefaultParameterValue((CardFettersType)4)] CardFettersType fetterType, [Optional] Object linkAttackObj)
		{
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x4440618", Offset = "0x443C618", VA = "0x4440618")]
		public void AddTempDamageReflect(float ratio)
		{
		}

		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x4440628", Offset = "0x443C628", VA = "0x4440628")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x44402E4", Offset = "0x443C2E4", VA = "0x44402E4")]
		private void UpdateHpUI()
		{
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x4440630", Offset = "0x443C630", VA = "0x4440630")]
		public void UIHide()
		{
		}

		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x4440640", Offset = "0x443C640", VA = "0x4440640")]
		[ContextMenu("111")]
		public void ChangeTagToOne()
		{
		}

		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x44406FC", Offset = "0x443C6FC", VA = "0x44406FC")]
		public void ChangeIsEnemy(bool isEnemy)
		{
		}

		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x4440708", Offset = "0x443C708", VA = "0x4440708")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x4440748", Offset = "0x443C748", VA = "0x4440748")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x444074C", Offset = "0x443C74C", VA = "0x444074C")]
		public StoneWallBehaviour()
		{
		}
	}
}
