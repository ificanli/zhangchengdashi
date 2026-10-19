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
	[Token(Token = "0x2000747")]
	public class BtnBuyAbilityStoneItem : BtnBuyAbilityStoneItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000749")]
		[CompilerGenerated]
		private struct _003CCheckAnimation_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x400394A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400394B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400394C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnBuyAbilityStoneItem _003C_003E4__this;

			[Token(Token = "0x60027D9")]
			[Address(RVA = "0x3FA9A88", Offset = "0x3FA5A88", VA = "0x3FA9A88", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60027DA")]
			[Address(RVA = "0x3FA9E88", Offset = "0x3FA5E88", VA = "0x3FA9E88", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200074A")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x400394D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400394E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400394F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnBuyAbilityStoneItem _003C_003E4__this;

			[Token(Token = "0x4003950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalShopInfo shopInfo;

			[Token(Token = "0x4003951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isMostExpensive;

			[Token(Token = "0x4003952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60027DB")]
			[Address(RVA = "0x3FA9E94", Offset = "0x3FA5E94", VA = "0x3FA9E94", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60027DC")]
			[Address(RVA = "0x3FAAD30", Offset = "0x3FA6D30", VA = "0x3FAAD30", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200074B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnBuyAbilityStoneItem _003C_003E4__this;

			[Token(Token = "0x4003957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60027DD")]
			[Address(RVA = "0x3FAAD3C", Offset = "0x3FA6D3C", VA = "0x3FAAD3C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60027DE")]
			[Address(RVA = "0x3FAAF1C", Offset = "0x3FA6F1C", VA = "0x3FAAF1C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200074C")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4003958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400395A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnBuyAbilityStoneItem _003C_003E4__this;

			[Token(Token = "0x60027DF")]
			[Address(RVA = "0x3FAAF28", Offset = "0x3FA6F28", VA = "0x3FAAF28", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60027E0")]
			[Address(RVA = "0x3FAB668", Offset = "0x3FA7668", VA = "0x3FAB668", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GlobalShopInfo shopInfo;

		[Token(Token = "0x4003945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string light;

		[Token(Token = "0x4003946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GameObject lightObj;

		[Token(Token = "0x4003947")]
		private const int AdRewardCount = 25;

		[Token(Token = "0x60027CC")]
		[Address(RVA = "0x3FA8EF8", Offset = "0x3FA4EF8", VA = "0x3FA8EF8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60027CD")]
		[Address(RVA = "0x3FA8F8C", Offset = "0x3FA4F8C", VA = "0x3FA8F8C")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__5))]
		public void Init(GlobalShopInfo shopInfo, bool isMostExpensive = false)
		{
		}

		[Token(Token = "0x60027CE")]
		[Address(RVA = "0x3FA9034", Offset = "0x3FA5034", VA = "0x3FA9034")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__6))]
		private void UpdateUI()
		{
		}

		[Token(Token = "0x60027CF")]
		[Address(RVA = "0x3FA90C0", Offset = "0x3FA50C0", VA = "0x3FA90C0")]
		[AsyncStateMachine(typeof(_003CCheckAnimation_003Ed__7))]
		private void CheckAnimation()
		{
		}

		[Token(Token = "0x60027D0")]
		[Address(RVA = "0x3FA914C", Offset = "0x3FA514C", VA = "0x3FA914C", Slot = "12")]
		protected override void OnButtonExtendBtnBuyAbilityStoneItemClicked()
		{
		}

		[Token(Token = "0x60027D1")]
		[Address(RVA = "0x3FA93C8", Offset = "0x3FA53C8", VA = "0x3FA93C8")]
		private void AdCallBack()
		{
		}

		[Token(Token = "0x60027D2")]
		[Address(RVA = "0x3FA9760", Offset = "0x3FA5760", VA = "0x3FA9760")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60027D3")]
		[Address(RVA = "0x3FA9834", Offset = "0x3FA5834", VA = "0x3FA9834")]
		private void TimeToZeroRefreshFreeResUI(object o)
		{
		}

		[Token(Token = "0x60027D4")]
		[Address(RVA = "0x3FA98C4", Offset = "0x3FA58C4", VA = "0x3FA98C4")]
		public BtnBuyAbilityStoneItem()
		{
		}
	}
}
