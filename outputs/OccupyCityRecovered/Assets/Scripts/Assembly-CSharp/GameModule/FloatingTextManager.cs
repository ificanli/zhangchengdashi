using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UIModuleO;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000274")]
	public class FloatingTextManager : ManagerBase<FloatingTextManager>
	{
		[Token(Token = "0x2000275")]
		public class ActiveText
		{
			[Token(Token = "0x4001F87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string text;

			[Token(Token = "0x4001F88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Color color;

			[Token(Token = "0x4001F89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 worldPos;

			[Token(Token = "0x4001F8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 screenPos;

			[Token(Token = "0x4001F8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector3 anchorPos;

			[Token(Token = "0x4001F8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float startTime;

			[Token(Token = "0x4001F8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float currentAlpha;

			[Token(Token = "0x4001F8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float currentScale;

			[Token(Token = "0x4001F8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<Vector2> allUV;

			[Token(Token = "0x4001F90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform target;

			[Token(Token = "0x4001F91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public bool haveBg;

			[Token(Token = "0x4001F92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Color? backgroundColor;

			[Token(Token = "0x4001F93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Color? progressColor;

			[Token(Token = "0x4001F94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public float progress;

			[Token(Token = "0x4001F95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public float ghostProgress;

			[Token(Token = "0x4001F96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public float lastHitTime;

			[Token(Token = "0x4001F97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public float ghostDelayUntil;

			[Token(Token = "0x4001F98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			public float ghostVelocity;

			[Token(Token = "0x4001F99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Vector3 offset;

			[Token(Token = "0x4001F9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			public Vector3 baseOffset;

			[Token(Token = "0x4001F9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public Vector3 randomSpreadDir;

			[Token(Token = "0x4001F9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			public bool stayFollowerTarget;

			[Token(Token = "0x4001F9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
			public bool single;

			[Token(Token = "0x4001F9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public float deathTime;

			[Token(Token = "0x4001F9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			public bool isHeal;

			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x438DD04", Offset = "0x4389D04", VA = "0x438DD04")]
			public ActiveText()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000276")]
		[CompilerGenerated]
		private struct _003CGetFloatingTextPanelAsync_003Ed__30 : IAsyncStateMachine
		{
			[Token(Token = "0x4001FA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001FA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001FA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FloatingTextManager _003C_003E4__this;

			[Token(Token = "0x4001FA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<UIFramework.UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x438EAF8", Offset = "0x438AAF8", VA = "0x438EAF8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x438EF80", Offset = "0x438AF80", VA = "0x438EF80", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000277")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x4001FA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001FA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001FA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FloatingTextManager _003C_003E4__this;

			[Token(Token = "0x4001FA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<(FloatingTextFontConfig, FloatingTextConfig, FloatingTextConfig, Material, Material)>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x438EF8C", Offset = "0x438AF8C", VA = "0x438EF8C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x438F7FC", Offset = "0x438B7FC", VA = "0x438F7FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000278")]
		[CompilerGenerated]
		private struct _003CPrewarmForBattle_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4001FA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001FA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001FAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FloatingTextManager _003C_003E4__this;

			[Token(Token = "0x4001FAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<string, int, double> onItemPrewarmed;

			[Token(Token = "0x4001FAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x440DF7C", Offset = "0x4409F7C", VA = "0x440DF7C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x440E610", Offset = "0x440A610", VA = "0x440E610", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001F7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FloatingTextFontConfig floatingTextFontConfig;

		[Token(Token = "0x4001F7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FloatingTextConfig floatingTextConfig;

		[Token(Token = "0x4001F7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FloatingTextConfig floatingTextBgConfig;

		[Token(Token = "0x4001F7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool hideDamageText2;

		[Token(Token = "0x4001F7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool hideHpText2;

		[Token(Token = "0x4001F7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<ActiveText> damageTexts;

		[Token(Token = "0x4001F80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<ActiveText> hps;

		[Token(Token = "0x4001F81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private FloatingTextPanel _cachedFloatingTextPanel;

		[Token(Token = "0x4001F82")]
		public const int BattleDamageTextCapacity = 50;

		[Token(Token = "0x4001F83")]
		public const int BattleHpCapacity = 50;

		[Token(Token = "0x4001F84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Material textMaterial;

		[Token(Token = "0x4001F85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Material bgMaterial;

		[Token(Token = "0x4001F86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float updateInter;

		[Token(Token = "0x170000C6")]
		public bool hideDamageText
		{
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x438D7B0", Offset = "0x43897B0", VA = "0x438D7B0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000C7")]
		public bool hideHpText
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x438D7B8", Offset = "0x43897B8", VA = "0x438D7B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x438D84C", Offset = "0x438984C", VA = "0x438D84C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__17))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x438D8E0", Offset = "0x43898E0", VA = "0x438D8E0")]
		[AsyncStateMachine(typeof(_003CPrewarmForBattle_003Ed__18))]
		public UniTask PrewarmForBattle([Optional] Action<string, int, double> onItemPrewarmed)
		{
			return default;
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x438D988", Offset = "0x4389988", VA = "0x438D988")]
		private static double GetElapsedMilliseconds(long startTicks)
		{
			return default;
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x437FB44", Offset = "0x437BB44", VA = "0x437FB44")]
		public Color GetProgressColor(bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x437FB04", Offset = "0x437BB04", VA = "0x437FB04")]
		public Color GetBackgroundColor()
		{
			return default;
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x437D2C8", Offset = "0x43792C8", VA = "0x437D2C8")]
		public Color GetDamageTextColor(bool isEnemy, bool isHeal)
		{
			return default;
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x437D314", Offset = "0x4379314", VA = "0x437D314")]
		public void ShowDamageText(string text, Transform target, [Optional][DefaultParameterValue(false)] bool stayFollowerTarget, [Optional] Color? color, [Optional] Vector3? offset, [Optional][DefaultParameterValue(false)] bool haveBg, [Optional][DefaultParameterValue(false)] bool single, [Optional][DefaultParameterValue(1f)] float progress, [Optional] Color? bgColor, [Optional] Color? progColor)
		{
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x438DBF4", Offset = "0x4389BF4", VA = "0x438DBF4")]
		private void UpdateTextUVs(ActiveText activeText)
		{
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x438DA08", Offset = "0x4389A08", VA = "0x438DA08")]
		private bool IsPositionOnScreen(Vector3 worldPosition)
		{
			return default;
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x437FBA0", Offset = "0x437BBA0", VA = "0x437FBA0")]
		public void UpdateHp(Transform target, float progress, string text, Vector3? offset, [Optional] Color? color, [Optional] Color? bgColor, [Optional] Color? progressColor)
		{
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x438DD88", Offset = "0x4389D88", VA = "0x438DD88")]
		public void RemoveTextByTarget(Transform target)
		{
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x438DF14", Offset = "0x4389F14", VA = "0x438DF14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x438E5F0", Offset = "0x438A5F0", VA = "0x438E5F0")]
		[AsyncStateMachine(typeof(_003CGetFloatingTextPanelAsync_003Ed__30))]
		private UniTask GetFloatingTextPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x438E680", Offset = "0x438A680", VA = "0x438E680")]
		private void UpdateFloatingTextPanel()
		{
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x438E858", Offset = "0x438A858", VA = "0x438E858")]
		public void CleanAllDamageText()
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x438E0C0", Offset = "0x438A0C0", VA = "0x438E0C0")]
		private void UpdateActiveTexts(List<ActiveText> activeTexts)
		{
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x438DB20", Offset = "0x4389B20", VA = "0x438DB20")]
		private void ApplyHpProgressChange(ActiveText activeText, float newProgress)
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x438E930", Offset = "0x438A930", VA = "0x438E930")]
		private void UpdateGhostProgress(ActiveText text, float currentTime, FloatingTextConfig config)
		{
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x438EA40", Offset = "0x438AA40", VA = "0x438EA40")]
		public FloatingTextManager()
		{
		}
	}
}
