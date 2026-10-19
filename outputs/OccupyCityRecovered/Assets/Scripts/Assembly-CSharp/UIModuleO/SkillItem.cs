using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20008CA")]
	public class SkillItem : SkillItemComponents, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
	{
		[Token(Token = "0x20008CB")]
		private enum DragIndicatorMode
		{
			[Token(Token = "0x40042B5")]
			FullscreenLighting = 0,
			[Token(Token = "0x40042B6")]
			LegacyWorldCircle = 1
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008CC")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__38 : IAsyncStateMachine
		{
			[Token(Token = "0x40042B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40042B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40042B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SkillItem _003C_003E4__this;

			[Token(Token = "0x40042BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalPropInfo info;

			[Token(Token = "0x40042BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40042BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600328A")]
			[Address(RVA = "0x407262C", Offset = "0x406E62C", VA = "0x407262C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600328B")]
			[Address(RVA = "0x4072C0C", Offset = "0x406EC0C", VA = "0x4072C0C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008CD")]
		[CompilerGenerated]
		private struct _003CInitEnemy_003Ed__39 : IAsyncStateMachine
		{
			[Token(Token = "0x40042BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40042BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40042BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SkillItem _003C_003E4__this;

			[Token(Token = "0x40042C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalPropInfo info;

			[Token(Token = "0x40042C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40042C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600328C")]
			[Address(RVA = "0x4072C18", Offset = "0x406EC18", VA = "0x4072C18", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600328D")]
			[Address(RVA = "0x407330C", Offset = "0x406F30C", VA = "0x407330C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008CE")]
		[CompilerGenerated]
		private struct _003COnButtonExtendSkillItemClicked_003Ed__67 : IAsyncStateMachine
		{
			[Token(Token = "0x40042C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40042C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40042C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SkillItem _003C_003E4__this;

			[Token(Token = "0x600328E")]
			[Address(RVA = "0x4073318", Offset = "0x406F318", VA = "0x4073318", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600328F")]
			[Address(RVA = "0x4073B10", Offset = "0x406FB10", VA = "0x4073B10", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float unlockTime;

		[Token(Token = "0x4004293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float nowRequireCollTime;

		[Token(Token = "0x4004294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool isLock;

		[Token(Token = "0x4004295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string propID;

		[Token(Token = "0x4004296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int canusedCount;

		[Token(Token = "0x4004297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int usedCount;

		[Token(Token = "0x4004298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int chargeCount;

		[Token(Token = "0x4004299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int[] propCharge;

		[Token(Token = "0x400429A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool useFlipCharge;

		[Token(Token = "0x400429B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		private bool subscribedFlipEvent;

		[Token(Token = "0x400429C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
		private bool subscribedGameEndEvent;

		[Token(Token = "0x400429D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int flipCount;

		[Token(Token = "0x400429E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool hasPlayedFullChargeFx;

		[Token(Token = "0x400429F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool isDragging;

		[Token(Token = "0x40042A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
		private bool hasShownIndicator;

		[Token(Token = "0x40042A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector2 pointerDownScreenPos;

		[Token(Token = "0x40042A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector2 currentEdgePanDir;

		[Token(Token = "0x40042A3")]
		private const float DragThreshold = 15f;

		[Token(Token = "0x40042A4")]
		private const float EdgeScrollTriggerPercent = 0.1f;

		[Token(Token = "0x40042A5")]
		private const string SkillChargeEffectPath = "Assets/_Res/Addressable/EffectsBundle/Effects/SkillChargeEffect.prefab";

		[Token(Token = "0x40042A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool triggerFromDragRelease;

		[Token(Token = "0x40042A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		private bool isEnemyDisplay;

		[Token(Token = "0x40042A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 lastDragWorldPos;

		[Token(Token = "0x40042A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool hasLastDragWorldPos;

		[Token(Token = "0x40042AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector2 lastDragScreenPos;

		[Token(Token = "0x40042AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool hasLastDragScreenPos;

		[Token(Token = "0x40042AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Camera lastDragEventCamera;

		[Token(Token = "0x40042AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private GamePanel cachedGamePanel;

		[Token(Token = "0x40042AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private CameraMoveBehaviour cachedCameraMoveBehaviour;

		[Token(Token = "0x40042AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private CameraControllerMoveBehaviour cachedCameraControllerMoveBehaviour;

		[Token(Token = "0x40042B0")]
		private const float LegacyWorldIndicatorRadius = 3f;

		[Token(Token = "0x40042B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float cachedReleaseRange;

		[Token(Token = "0x40042B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private bool hasCachedReleaseRange;

		[Token(Token = "0x40042B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x135")]
		private bool releaseRangeIsFullscreen;

		[Token(Token = "0x17000698")]
		private IReadOnlyList<int> FlipChargeThresholds
		{
			[Token(Token = "0x6003257")]
			[Address(RVA = "0x406E35C", Offset = "0x406A35C", VA = "0x406E35C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003258")]
		[Address(RVA = "0x406E3AC", Offset = "0x406A3AC", VA = "0x406E3AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6003259")]
		[Address(RVA = "0x40641CC", Offset = "0x40601CC", VA = "0x40641CC")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__38))]
		public void Init(GlobalPropInfo info)
		{
		}

		[Token(Token = "0x600325A")]
		[Address(RVA = "0x4064334", Offset = "0x4060334", VA = "0x4064334")]
		[AsyncStateMachine(typeof(_003CInitEnemy_003Ed__39))]
		public void InitEnemy(GlobalPropInfo info)
		{
		}

		[Token(Token = "0x600325B")]
		[Address(RVA = "0x406E850", Offset = "0x406A850", VA = "0x406E850")]
		private void InitFlipCharge()
		{
		}

		[Token(Token = "0x600325C")]
		[Address(RVA = "0x406EDDC", Offset = "0x406ADDC", VA = "0x406EDDC")]
		private void InitTimeCharge()
		{
		}

		[Token(Token = "0x600325D")]
		[Address(RVA = "0x406EDA4", Offset = "0x406ADA4", VA = "0x406EDA4")]
		private void ShowCanUseCountUI()
		{
		}

		[Token(Token = "0x600325E")]
		[Address(RVA = "0x406F0A4", Offset = "0x406B0A4", VA = "0x406F0A4")]
		private void Update()
		{
		}

		[Token(Token = "0x600325F")]
		[Address(RVA = "0x406F0E8", Offset = "0x406B0E8", VA = "0x406F0E8")]
		private void RefreshEnemyDisplay()
		{
		}

		[Token(Token = "0x6003260")]
		[Address(RVA = "0x406FAB8", Offset = "0x406BAB8", VA = "0x406FAB8")]
		private void RefreshEnemyFlipChargeDisplay()
		{
		}

		[Token(Token = "0x6003261")]
		[Address(RVA = "0x406FF44", Offset = "0x406BF44", VA = "0x406FF44")]
		private void RefreshEnemyTimeChargeDisplay()
		{
		}

		[Token(Token = "0x6003262")]
		[Address(RVA = "0x406F36C", Offset = "0x406B36C", VA = "0x406F36C")]
		private void UpdateEdgeCameraPanForDrag()
		{
		}

		[Token(Token = "0x6003263")]
		[Address(RVA = "0x407033C", Offset = "0x406C33C", VA = "0x407033C")]
		private void UpdateEdgePanDirectionFromCurrentPointer()
		{
		}

		[Token(Token = "0x6003264")]
		[Address(RVA = "0x406F794", Offset = "0x406B794", VA = "0x406F794")]
		private void UpdateTimeCharge()
		{
		}

		[Token(Token = "0x6003265")]
		[Address(RVA = "0x406F634", Offset = "0x406B634", VA = "0x406F634")]
		private void RefreshSkillIndicatorDuringCameraPan()
		{
		}

		[Token(Token = "0x6003266")]
		[Address(RVA = "0x406F05C", Offset = "0x406B05C", VA = "0x406F05C")]
		private void UpdateUseCountUI()
		{
		}

		[Token(Token = "0x6003267")]
		[Address(RVA = "0x407094C", Offset = "0x406C94C", VA = "0x407094C")]
		public void CheatAddPropUseCount(int addCount = 1)
		{
		}

		[Token(Token = "0x6003268")]
		[Address(RVA = "0x4070AD8", Offset = "0x406CAD8", VA = "0x4070AD8")]
		private void OnHexOpen(object o)
		{
		}

		[Token(Token = "0x6003269")]
		[Address(RVA = "0x4070DA4", Offset = "0x406CDA4", VA = "0x4070DA4")]
		private void HandleFlipCharge(int totalFlips, bool canPlayFx)
		{
		}

		[Token(Token = "0x600326A")]
		[Address(RVA = "0x40715E8", Offset = "0x406D5E8", VA = "0x40715E8")]
		private void PlayChargeOnceFx()
		{
		}

		[Token(Token = "0x600326B")]
		[Address(RVA = "0x40715EC", Offset = "0x406D5EC", VA = "0x40715EC")]
		private void PlayExplodeFx()
		{
		}

		[Token(Token = "0x600326C")]
		[Address(RVA = "0x40701F4", Offset = "0x406C1F4", VA = "0x40701F4")]
		private void RefreshChargeFx()
		{
		}

		[Token(Token = "0x600326D")]
		[Address(RVA = "0x406F9CC", Offset = "0x406B9CC", VA = "0x406F9CC")]
		private void StopAllFx()
		{
		}

		[Token(Token = "0x600326E")]
		[Address(RVA = "0x4071880", Offset = "0x406D880", VA = "0x4071880", Slot = "13")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600326F")]
		[Address(RVA = "0x4071A4C", Offset = "0x406DA4C", VA = "0x4071A4C", Slot = "14")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6003270")]
		[Address(RVA = "0x4071E10", Offset = "0x406DE10", VA = "0x4071E10", Slot = "15")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6003271")]
		[Address(RVA = "0x40704DC", Offset = "0x406C4DC", VA = "0x40704DC")]
		private bool TryGetWorldPosition(Vector2 screenPos, out Vector3 worldPos)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SkillItem.TryGetWorldPosition RVA=0x40704DC Token=0x6003271");
}

		[Token(Token = "0x6003272")]
		[Address(RVA = "0x4071CC8", Offset = "0x406DCC8", VA = "0x4071CC8")]
		private void UpdateEdgePanDirection(Vector2 screenPos)
		{
		}

		[Token(Token = "0x6003273")]
		[Address(RVA = "0x40703C0", Offset = "0x406C3C0", VA = "0x40703C0")]
		private Vector2 GetEdgeDirection(Vector2 screenPos)
		{
			return default;
		}

		[Token(Token = "0x6003274")]
		[Address(RVA = "0x4071920", Offset = "0x406D920", VA = "0x4071920")]
		private void SetNativeCameraDragLock(bool isLocked)
		{
		}

		[Token(Token = "0x6003275")]
		[Address(RVA = "0x407071C", Offset = "0x406C71C", VA = "0x407071C")]
		private bool IsDragReleaseValid(Vector2 screenPos, Camera eventCamera)
		{
			return default;
		}

		[Token(Token = "0x6003276")]
		[Address(RVA = "0x4072018", Offset = "0x406E018", VA = "0x4072018", Slot = "12")]
		[AsyncStateMachine(typeof(_003COnButtonExtendSkillItemClicked_003Ed__67))]
		protected override void OnButtonExtendSkillItemClicked()
		{
		}

		[Token(Token = "0x6003277")]
		[Address(RVA = "0x40720A4", Offset = "0x406E0A4", VA = "0x40720A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6003278")]
		[Address(RVA = "0x40722E8", Offset = "0x406E2E8", VA = "0x40722E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6003279")]
		[Address(RVA = "0x4072370", Offset = "0x406E370", VA = "0x4072370")]
		private void OnBattleEndHideIndicator(object o)
		{
		}

		[Token(Token = "0x600327A")]
		[Address(RVA = "0x40722EC", Offset = "0x406E2EC", VA = "0x40722EC")]
		private void ResetDragIndicatorState()
		{
		}

		[Token(Token = "0x600327B")]
		[Address(RVA = "0x407144C", Offset = "0x406D44C", VA = "0x407144C")]
		private bool CanPlayChargeEffect()
		{
			return default;
		}

		[Token(Token = "0x600327C")]
		[Address(RVA = "0x4072374", Offset = "0x406E374", VA = "0x4072374")]
		private DragIndicatorMode GetDragIndicatorMode()
		{
			return default;
		}

		[Token(Token = "0x600327D")]
		[Address(RVA = "0x4072394", Offset = "0x406E394", VA = "0x4072394")]
		private float GetLegacyIndicatorRadius()
		{
			return default;
		}

		[Token(Token = "0x600327E")]
		[Address(RVA = "0x40723B4", Offset = "0x406E3B4", VA = "0x40723B4")]
		private void CacheReleaseRangeFromInfo(GlobalPropInfo info)
		{
		}

		[Token(Token = "0x600327F")]
		[Address(RVA = "0x4071D28", Offset = "0x406DD28", VA = "0x4071D28")]
		private void ShowDragIndicator(Vector3 worldPos, bool isValidRelease)
		{
		}

		[Token(Token = "0x6003280")]
		[Address(RVA = "0x40707B8", Offset = "0x406C7B8", VA = "0x40707B8")]
		private void UpdateDragIndicator(Vector3 worldPos, bool isValidRelease)
		{
		}

		[Token(Token = "0x6003281")]
		[Address(RVA = "0x4071F90", Offset = "0x406DF90", VA = "0x4071F90")]
		private void HideDragIndicator()
		{
		}

		[Token(Token = "0x6003282")]
		[Address(RVA = "0x40724D4", Offset = "0x406E4D4", VA = "0x40724D4")]
		public SkillItem()
		{
		}
	}
}
