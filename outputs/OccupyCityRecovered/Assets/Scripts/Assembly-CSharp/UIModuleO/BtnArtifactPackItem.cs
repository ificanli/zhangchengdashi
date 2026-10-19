using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000738")]
	public class BtnArtifactPackItem : BtnArtifactPackItemComponents
	{
		[Token(Token = "0x200073A")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x40038F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string[] infos;

			[Token(Token = "0x600277D")]
			[Address(RVA = "0x3FA2D08", Offset = "0x3F9ED08", VA = "0x3FA2D08")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600277E")]
			[Address(RVA = "0x3FA2D10", Offset = "0x3F9ED10", VA = "0x3FA2D10")]
			internal bool _003CUpdateUI_003Eb__1(GlobalAssetInfo x)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200073B")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40038F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40038F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40038F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnArtifactPackItem _003C_003E4__this;

			[Token(Token = "0x40038F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalShopInfo info;

			[Token(Token = "0x600277F")]
			[Address(RVA = "0x3FA2D70", Offset = "0x3F9ED70", VA = "0x3FA2D70", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002780")]
			[Address(RVA = "0x3FA3454", Offset = "0x3F9F454", VA = "0x3FA3454", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200073C")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40038F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40038F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40038FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnArtifactPackItem _003C_003E4__this;

			[Token(Token = "0x40038FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

			[Token(Token = "0x40038FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string[] _003CrewardConfig_003E5__2;

			[Token(Token = "0x40038FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003Cindex_003E5__3;

			[Token(Token = "0x40038FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int _003Cindex2_003E5__4;

			[Token(Token = "0x40038FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4003900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private int _003Ci_003E5__5;

			[Token(Token = "0x4003901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private GameObject _003Cgo_003E5__6;

			[Token(Token = "0x4003902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private string _003Cid_003E5__7;

			[Token(Token = "0x4003903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private string _003CnumStr_003E5__8;

			[Token(Token = "0x4003904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private GlobalPropInfo _003CconfigInfo_003E5__9;

			[Token(Token = "0x4003905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Image _003C_003E7__wrap9;

			[Token(Token = "0x4003906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6002781")]
			[Address(RVA = "0x3FA3460", Offset = "0x3F9F460", VA = "0x3FA3460", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002782")]
			[Address(RVA = "0x3FA5818", Offset = "0x3FA1818", VA = "0x3FA5818", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40038E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GlobalShopInfo _info;

		[Token(Token = "0x40038EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject res;

		[Token(Token = "0x40038EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<GameObject> itemList;

		[Token(Token = "0x40038EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<GameObject> resGoList;

		[Token(Token = "0x40038ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string IAPID;

		[Token(Token = "0x40038EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool InitStartEvevt;

		[Token(Token = "0x40038EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TimeManager.Timer toMondayTimer;

		[Token(Token = "0x40038F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float cooldown;

		[Token(Token = "0x40038F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private float timecount;

		[Token(Token = "0x600276E")]
		[Address(RVA = "0x3FA1BF8", Offset = "0x3F9DBF8", VA = "0x3FA1BF8")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__6))]
		public void Init(GlobalShopInfo info)
		{
		}

		[Token(Token = "0x600276F")]
		[Address(RVA = "0x3FA1C94", Offset = "0x3F9DC94", VA = "0x3FA1C94")]
		private void BindDisplayInfo(GlobalShopInfo info)
		{
		}

		[Token(Token = "0x6002770")]
		[Address(RVA = "0x3FA1F30", Offset = "0x3F9DF30", VA = "0x3FA1F30")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__8))]
		public void UpdateUI(string rewards)
		{
		}

		[Token(Token = "0x6002771")]
		[Address(RVA = "0x3FA22E8", Offset = "0x3F9E2E8", VA = "0x3FA22E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6002772")]
		[Address(RVA = "0x3FA22F0", Offset = "0x3F9E2F0", VA = "0x3FA22F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6002773")]
		[Address(RVA = "0x3FA24C4", Offset = "0x3F9E4C4", VA = "0x3FA24C4")]
		private void TimeToMonDayZero(object o)
		{
		}

		[Token(Token = "0x6002774")]
		[Address(RVA = "0x3FA24C8", Offset = "0x3F9E4C8", VA = "0x3FA24C8")]
		private void RefreshDisplayTier(object o)
		{
		}

		[Token(Token = "0x6002775")]
		[Address(RVA = "0x3FA2550", Offset = "0x3F9E550", VA = "0x3FA2550")]
		private void RefreshArtifactItem(object o)
		{
		}

		[Token(Token = "0x6002776")]
		[Address(RVA = "0x3FA2568", Offset = "0x3F9E568", VA = "0x3FA2568")]
		private void RefreshBuyCount()
		{
		}

		[Token(Token = "0x6002777")]
		[Address(RVA = "0x3FA1FC0", Offset = "0x3F9DFC0", VA = "0x3FA1FC0")]
		private void UpdateBuyPackCountUI()
		{
		}

		[Token(Token = "0x6002778")]
		[Address(RVA = "0x3FA290C", Offset = "0x3F9E90C", VA = "0x3FA290C", Slot = "12")]
		protected override void OnButtonExtendBtnArtifactPackItemClicked()
		{
		}

		[Token(Token = "0x6002779")]
		[Address(RVA = "0x3FA2C14", Offset = "0x3F9EC14", VA = "0x3FA2C14")]
		public BtnArtifactPackItem()
		{
		}
	}
}
