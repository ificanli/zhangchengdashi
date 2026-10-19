using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000771")]
	public class BtnHumanPackItem : BtnHumanPackItemComponents
	{
		[Token(Token = "0x2000772")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4003A2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GlobalShopInfo info;

			[Token(Token = "0x4003A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnHumanPackItem _003C_003E4__this;

			[Token(Token = "0x60028DE")]
			[Address(RVA = "0x3FB9AEC", Offset = "0x3FB5AEC", VA = "0x3FB9AEC")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60028DF")]
			[Address(RVA = "0x3FB9AF4", Offset = "0x3FB5AF4", VA = "0x3FB9AF4")]
			internal bool _003CInit_003Eb__0(GlobalIAPInfo x)
			{
				return default;
			}

			[Token(Token = "0x60028E0")]
			[Address(RVA = "0x3FB9B1C", Offset = "0x3FB5B1C", VA = "0x3FB9B1C")]
			internal bool _003CInit_003Eb__1(GlobalIAPInfo x)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000773")]
		[CompilerGenerated]
		private struct _003CInCardItem_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnHumanPackItem _003C_003E4__this;

			[Token(Token = "0x4003A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isArtifact;

			[Token(Token = "0x4003A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60028E1")]
			[Address(RVA = "0x3FB9B4C", Offset = "0x3FB5B4C", VA = "0x3FB9B4C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60028E2")]
			[Address(RVA = "0x3FBA778", Offset = "0x3FB6778", VA = "0x3FBA778", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000774")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GlobalShopInfo info;

			[Token(Token = "0x4003A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BtnHumanPackItem _003C_003E4__this;

			[Token(Token = "0x4003A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

			[Token(Token = "0x4003A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4003A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60028E3")]
			[Address(RVA = "0x3FBA784", Offset = "0x3FB6784", VA = "0x3FBA784", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60028E4")]
			[Address(RVA = "0x3FBCC40", Offset = "0x3FB8C40", VA = "0x3FBCC40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GlobalShopInfo _info;

		[Token(Token = "0x4003A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string IAPID;

		[Token(Token = "0x4003A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TimeManager.Timer newBieTimer;

		[Token(Token = "0x4003A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private GameObject res;

		[Token(Token = "0x4003A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<GameObject> itemList;

		[Token(Token = "0x4003A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Tween lightTween;

		[Token(Token = "0x4003A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool InitStartEvevt;

		[Token(Token = "0x4003A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TimeManager.Timer toMondayTimer;

		[Token(Token = "0x4003A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float cooldown;

		[Token(Token = "0x4003A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private float timecount;

		[Token(Token = "0x60028D2")]
		[Address(RVA = "0x3FB8B8C", Offset = "0x3FB4B8C", VA = "0x3FB8B8C")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__7))]
		public void Init(GlobalShopInfo info)
		{
		}

		[Token(Token = "0x60028D3")]
		[Address(RVA = "0x3FB8C30", Offset = "0x3FB4C30", VA = "0x3FB8C30")]
		private void Update()
		{
		}

		[Token(Token = "0x60028D4")]
		[Address(RVA = "0x3FB8E04", Offset = "0x3FB4E04", VA = "0x3FB8E04")]
		private void RefreshBuyCount()
		{
		}

		[Token(Token = "0x60028D5")]
		[Address(RVA = "0x3FB9270", Offset = "0x3FB5270", VA = "0x3FB9270")]
		private void TimeToMonDayZero(object o)
		{
		}

		[Token(Token = "0x60028D6")]
		[Address(RVA = "0x3FB8F50", Offset = "0x3FB4F50", VA = "0x3FB8F50")]
		private void UpdateBuyPackCountUI()
		{
		}

		[Token(Token = "0x60028D7")]
		[Address(RVA = "0x3FB94CC", Offset = "0x3FB54CC", VA = "0x3FB94CC")]
		[AsyncStateMachine(typeof(_003CInCardItem_003Ed__15))]
		private void InCardItem(bool isArtifact = false)
		{
		}

		[Token(Token = "0x60028D8")]
		[Address(RVA = "0x3FB9574", Offset = "0x3FB5574", VA = "0x3FB9574")]
		private void RefreshItem(object o)
		{
		}

		[Token(Token = "0x60028D9")]
		[Address(RVA = "0x3FB9590", Offset = "0x3FB5590", VA = "0x3FB9590", Slot = "12")]
		protected override void OnButtonExtendBtnHumanPackItemClicked()
		{
		}

		[Token(Token = "0x60028DA")]
		[Address(RVA = "0x3FB9884", Offset = "0x3FB5884", VA = "0x3FB9884")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60028DB")]
		[Address(RVA = "0x3FB9A10", Offset = "0x3FB5A10", VA = "0x3FB9A10")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60028DC")]
		[Address(RVA = "0x3FB9A38", Offset = "0x3FB5A38", VA = "0x3FB9A38")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60028DD")]
		[Address(RVA = "0x3FB9A60", Offset = "0x3FB5A60", VA = "0x3FB9A60")]
		public BtnHumanPackItem()
		{
		}
	}
}
