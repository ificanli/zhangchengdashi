using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000991")]
	public class MetaSwitchPanel : MetaSwitchPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000992")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x40047AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40047AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40047B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MetaSwitchPanel _003C_003E4__this;

			[Token(Token = "0x40047B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60038BE")]
			[Address(RVA = "0x40F99C0", Offset = "0x40F59C0", VA = "0x40F99C0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60038BF")]
			[Address(RVA = "0x40FA570", Offset = "0x40F6570", VA = "0x40FA570", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000993")]
		[CompilerGenerated]
		private struct _003CCreateDividerLines_003Ed__31 : IAsyncStateMachine
		{
			[Token(Token = "0x40047B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40047B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40047B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MetaSwitchPanel _003C_003E4__this;

			[Token(Token = "0x40047B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int buttonCount;

			[Token(Token = "0x40047B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float parentWidth;

			[Token(Token = "0x40047B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float unitWidth;

			[Token(Token = "0x40047B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int _003CdividerCount_003E5__2;

			[Token(Token = "0x40047B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x40047BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private GameObject _003CdividerObj_003E5__4;

			[Token(Token = "0x40047BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60038C0")]
			[Address(RVA = "0x40FA57C", Offset = "0x40F657C", VA = "0x40FA57C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60038C1")]
			[Address(RVA = "0x40FAD04", Offset = "0x40F6D04", VA = "0x40FAD04", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000994")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x40047BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40047BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40047BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MetaSwitchPanel _003C_003E4__this;

			[Token(Token = "0x40047BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40047C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<GlobalMetaModuleInfo> _003CmetaModuleInfos_003E5__2;

			[Token(Token = "0x40047C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60038C2")]
			[Address(RVA = "0x40FAD10", Offset = "0x40F6D10", VA = "0x40FAD10", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60038C3")]
			[Address(RVA = "0x40FB748", Offset = "0x40F7748", VA = "0x40FB748", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400479F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ShopPanel shopPanel;

		[Token(Token = "0x40047A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public HeroCardPanel heroCardPanel;

		[Token(Token = "0x40047A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public MainReadyPanel mainReadyPanel;

		[Token(Token = "0x40047A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UpgradeMainTowerPanel upgrademainPanel;

		[Token(Token = "0x40047A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public RankPanel rankPanel;

		[Token(Token = "0x40047A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public CanvasGroup overlayCanvasGroup;

		[Token(Token = "0x40047A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<MetaSwitchBtn> _metaSwitchBtnList;

		[Token(Token = "0x40047A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private MeatScrollRectPageController _meatScrollRectPageController;

		[Token(Token = "0x40047A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _overlaySuppressed;

		[Token(Token = "0x40047A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Sprite spiteRes;

		[Token(Token = "0x40047A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GameObject[] _panelGOs;

		[Token(Token = "0x40047AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Canvas[] _panelCanvases;

		[Token(Token = "0x40047AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GraphicRaycaster[] _panelRaycasters;

		[Token(Token = "0x40047AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<RectTransform> _dividerLines;

		[Token(Token = "0x40047AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Color _dividerLineColor;

		[Token(Token = "0x17000887")]
		public MeatScrollRectPageController MeatScrollRectPageController
		{
			[Token(Token = "0x60038A9")]
			[Address(RVA = "0x40F897C", Offset = "0x40F497C", VA = "0x40F897C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000888")]
		public bool IsOverlaySuppressed
		{
			[Token(Token = "0x60038AA")]
			[Address(RVA = "0x40F8984", Offset = "0x40F4984", VA = "0x40F8984")]
			get
			{
				return _overlaySuppressed;
			}
		}

		[Token(Token = "0x60038AB")]
		[Address(RVA = "0x40F898C", Offset = "0x40F498C", VA = "0x40F898C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__19))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60038AC")]
		[Address(RVA = "0x40F8A1C", Offset = "0x40F4A1C", VA = "0x40F8A1C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__20))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60038AD")]
		[Address(RVA = "0x40F8AB8", Offset = "0x40F4AB8", VA = "0x40F8AB8")]
		public void SwitchToMainCity()
		{
		}

		[Token(Token = "0x60038AE")]
		[Address(RVA = "0x40F8B2C", Offset = "0x40F4B2C", VA = "0x40F8B2C")]
		public void SetOverlaySuppressed(bool suppressed)
		{
		}

		[Token(Token = "0x60038AF")]
		[Address(RVA = "0x40F8BAC", Offset = "0x40F4BAC", VA = "0x40F8BAC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60038B0")]
		[Address(RVA = "0x40F8C28", Offset = "0x40F4C28", VA = "0x40F8C28")]
		private void Update()
		{
		}

		[Token(Token = "0x60038B1")]
		[Address(RVA = "0x40F8C2C", Offset = "0x40F4C2C", VA = "0x40F8C2C")]
		private void InitPanelCanvases()
		{
		}

		[Token(Token = "0x60038B2")]
		[Address(RVA = "0x40F8DA8", Offset = "0x40F4DA8", VA = "0x40F8DA8")]
		private void EnsurePanelCanvas(int index)
		{
		}

		[Token(Token = "0x60038B3")]
		[Address(RVA = "0x40F8F64", Offset = "0x40F4F64", VA = "0x40F8F64")]
		private void SetPanelRendering(int index, bool enabled)
		{
		}

		[Token(Token = "0x60038B4")]
		[Address(RVA = "0x40F9078", Offset = "0x40F5078", VA = "0x40F9078")]
		private void OnBeforePageChange()
		{
		}

		[Token(Token = "0x60038B5")]
		[Address(RVA = "0x40F90C8", Offset = "0x40F50C8", VA = "0x40F90C8")]
		private void OnPageChangeComplete(int pageIndex)
		{
		}

		[Token(Token = "0x60038B6")]
		[Address(RVA = "0x40F9120", Offset = "0x40F5120", VA = "0x40F9120")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60038B7")]
		[Address(RVA = "0x40F92C0", Offset = "0x40F52C0", VA = "0x40F92C0")]
		[AsyncStateMachine(typeof(_003CCreateDividerLines_003Ed__31))]
		private void CreateDividerLines(int buttonCount, float unitWidth, float parentWidth)
		{
		}

		[Token(Token = "0x60038B8")]
		[Address(RVA = "0x40F9378", Offset = "0x40F5378", VA = "0x40F9378")]
		private void ClearDividerLines()
		{
		}

		[Token(Token = "0x60038B9")]
		[Address(RVA = "0x40F95E4", Offset = "0x40F55E4", VA = "0x40F95E4", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x60038BA")]
		[Address(RVA = "0x40F96E8", Offset = "0x40F56E8", VA = "0x40F96E8")]
		private void UpdateDividerLinesVisibility(int selectedButtonIndex = -1)
		{
		}

		[Token(Token = "0x60038BB")]
		[Address(RVA = "0x40F98E4", Offset = "0x40F58E4", VA = "0x40F98E4")]
		public MetaSwitchPanel()
		{
		}
	}
}
