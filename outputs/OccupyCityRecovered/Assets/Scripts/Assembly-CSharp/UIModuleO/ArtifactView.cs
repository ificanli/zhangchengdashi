using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200080E")]
	public class ArtifactView : ArtifactViewComponents
	{
		[Token(Token = "0x2000810")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			[Token(Token = "0x4003DBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string selectedPropId;

			[Token(Token = "0x6002D0E")]
			[Address(RVA = "0x40079A4", Offset = "0x40039A4", VA = "0x40079A4")]
			public _003C_003Ec__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6002D0F")]
			[Address(RVA = "0x40079AC", Offset = "0x40039AC", VA = "0x40079AC")]
			internal bool _003CRefreshPropElementsAndTopUI_003Eb__0(UserPropData x)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000812")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003DC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003DC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003DC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArtifactView _003C_003E4__this;

			[Token(Token = "0x6002D12")]
			[Address(RVA = "0x40079FC", Offset = "0x40039FC", VA = "0x40079FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002D13")]
			[Address(RVA = "0x4007AE0", Offset = "0x4003AE0", VA = "0x4007AE0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000813")]
		[CompilerGenerated]
		private struct _003CRefreshPropElementsAndTopUI_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4003DC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003DC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003DC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactView _003C_003E4__this;

			[Token(Token = "0x4003DC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

			[Token(Token = "0x4003DC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<UserPropData> _003CpropDataList_003E5__2;

			[Token(Token = "0x4003DC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002D14")]
			[Address(RVA = "0x4007AEC", Offset = "0x4003AEC", VA = "0x4007AEC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002D15")]
			[Address(RVA = "0x40080A8", Offset = "0x40040A8", VA = "0x40080A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000814")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4003DCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003DCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003DCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactView _003C_003E4__this;

			[Token(Token = "0x4003DCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4003DCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002D16")]
			[Address(RVA = "0x40080B4", Offset = "0x40040B4", VA = "0x40080B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002D17")]
			[Address(RVA = "0x4008554", Offset = "0x4004554", VA = "0x4008554", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000815")]
		[CompilerGenerated]
		private struct _003CUpdatePropElements_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4003DCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003DD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003DD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<UserPropData> dataList;

			[Token(Token = "0x4003DD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ArtifactView _003C_003E4__this;

			[Token(Token = "0x4003DD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002D18")]
			[Address(RVA = "0x4008560", Offset = "0x4004560", VA = "0x4008560", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002D19")]
			[Address(RVA = "0x4008F98", Offset = "0x4004F98", VA = "0x4008F98", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000816")]
		[CompilerGenerated]
		private struct _003CUpdatePropTopUI_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x4003DD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003DD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003DD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object o;

			[Token(Token = "0x4003DD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ArtifactView _003C_003E4__this;

			[Token(Token = "0x4003DD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UserPropData _003CnowPropData_003E5__2;

			[Token(Token = "0x4003DD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private GlobalPropInfo _003CpropInfo_003E5__3;

			[Token(Token = "0x4003DDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Image _003C_003E7__wrap3;

			[Token(Token = "0x4003DDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002D1A")]
			[Address(RVA = "0x4008FA4", Offset = "0x4004FA4", VA = "0x4008FA4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002D1B")]
			[Address(RVA = "0x400B15C", Offset = "0x400715C", VA = "0x400B15C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003DB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private List<PropItem> _propItemList;

		[Token(Token = "0x4003DB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private GameObject _propItemPrefab;

		[Token(Token = "0x4003DBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string _nowPropId;

		[Token(Token = "0x4003DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _upgradeRequireCount;

		[Token(Token = "0x6002CF1")]
		[Address(RVA = "0x4005E4C", Offset = "0x4001E4C", VA = "0x4005E4C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__4))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002CF2")]
		[Address(RVA = "0x4005ED8", Offset = "0x4001ED8", VA = "0x4005ED8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002CF3")]
		[Address(RVA = "0x400617C", Offset = "0x400217C", VA = "0x400617C")]
		private void RegisterEvents()
		{
		}

		[Token(Token = "0x6002CF4")]
		[Address(RVA = "0x4005F0C", Offset = "0x4001F0C", VA = "0x4005F0C")]
		private void UnregisterEvents()
		{
		}

		[Token(Token = "0x6002CF5")]
		[Address(RVA = "0x4006324", Offset = "0x4002324", VA = "0x4006324", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__8))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002CF6")]
		[Address(RVA = "0x40063C0", Offset = "0x40023C0", VA = "0x40063C0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002CF7")]
		[Address(RVA = "0x40064AC", Offset = "0x40024AC", VA = "0x40064AC")]
		[AsyncStateMachine(typeof(_003CUpdatePropElements_003Ed__10))]
		public UniTask UpdatePropElements(List<UserPropData> dataList)
		{
			return default;
		}

		[Token(Token = "0x6002CF8")]
		[Address(RVA = "0x40064A8", Offset = "0x40024A8", VA = "0x40064A8")]
		public void ClearPropItems()
		{
		}

		[Token(Token = "0x6002CF9")]
		[Address(RVA = "0x4006544", Offset = "0x4002544", VA = "0x4006544")]
		public void RefreshAllPropUI()
		{
		}

		[Token(Token = "0x6002CFA")]
		[Address(RVA = "0x40066E0", Offset = "0x40026E0", VA = "0x40066E0")]
		private void OnUpdateCrystalNum(object o)
		{
		}

		[Token(Token = "0x6002CFB")]
		[Address(RVA = "0x4006830", Offset = "0x4002830", VA = "0x4006830")]
		private void OnUpdatePropUI(object o)
		{
		}

		[Token(Token = "0x6002CFC")]
		[Address(RVA = "0x40068C0", Offset = "0x40028C0", VA = "0x40068C0")]
		private void OnPropItemClick(object o)
		{
		}

		[Token(Token = "0x6002CFD")]
		[Address(RVA = "0x4006834", Offset = "0x4002834", VA = "0x4006834")]
		[AsyncStateMachine(typeof(_003CRefreshPropElementsAndTopUI_003Ed__16))]
		private UniTask RefreshPropElementsAndTopUI()
		{
			return default;
		}

		[Token(Token = "0x6002CFE")]
		[Address(RVA = "0x40068C4", Offset = "0x40028C4", VA = "0x40068C4")]
		[AsyncStateMachine(typeof(_003CUpdatePropTopUI_003Ed__17))]
		private void UpdatePropTopUI(object o)
		{
		}

		[Token(Token = "0x6002CFF")]
		[Address(RVA = "0x4006964", Offset = "0x4002964", VA = "0x4006964")]
		private void UpdateUpgradePropBtnActive()
		{
		}

		[Token(Token = "0x6002D00")]
		[Address(RVA = "0x4006B64", Offset = "0x4002B64", VA = "0x4006B64")]
		private void ShowUpgradeEffect(RareLevel rareLevel)
		{
		}

		[Token(Token = "0x6002D01")]
		[Address(RVA = "0x4006D04", Offset = "0x4002D04", VA = "0x4006D04", Slot = "12")]
		protected override void OnButtonExtendBtnUseClicked()
		{
		}

		[Token(Token = "0x6002D02")]
		[Address(RVA = "0x4006FA8", Offset = "0x4002FA8", VA = "0x4006FA8", Slot = "13")]
		protected override void OnButtonExtendBtnUpgradeClicked()
		{
		}

		[Token(Token = "0x6002D03")]
		[Address(RVA = "0x40075C8", Offset = "0x40035C8", VA = "0x40075C8", Slot = "15")]
		protected override void OnButtonExtendSummonBtnClicked()
		{
		}

		[Token(Token = "0x6002D04")]
		[Address(RVA = "0x4007688", Offset = "0x4003688", VA = "0x4007688")]
		public ArtifactView()
		{
		}
	}
}
