using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000996")]
	public class MultistageNewcomerPackagePanel : MultistageNewcomerPackagePanelComponents
	{
		[Token(Token = "0x2000997")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x40047C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MultistageNewcomerPackagePanelData data;

			[Token(Token = "0x60038DC")]
			[Address(RVA = "0x40FD074", Offset = "0x40F9074", VA = "0x40FD074")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60038DD")]
			[Address(RVA = "0x40FD07C", Offset = "0x40F907C", VA = "0x40FD07C")]
			internal bool _003CRefreshView_003Eb__0(MultistageNewcomerPackageData x)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000998")]
		[CompilerGenerated]
		private struct _003CRefreshView_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40047C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40047CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40047CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MultistageNewcomerPackagePanel _003C_003E4__this;

			[Token(Token = "0x40047CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

			[Token(Token = "0x40047CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<MultistageNewcomerPackagePanelData> _003CallData_003E5__2;

			[Token(Token = "0x40047CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private MultistageNewcomerPackageData _003CuserData_003E5__3;

			[Token(Token = "0x40047CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Image _003C_003E7__wrap3;

			[Token(Token = "0x40047D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60038DE")]
			[Address(RVA = "0x40FD0A4", Offset = "0x40F90A4", VA = "0x40FD0A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60038DF")]
			[Address(RVA = "0x40FE41C", Offset = "0x40FA41C", VA = "0x40FE41C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000999")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40047D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40047D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40047D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MultistageNewcomerPackagePanel _003C_003E4__this;

			[Token(Token = "0x40047D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60038E0")]
			[Address(RVA = "0x40FE428", Offset = "0x40FA428", VA = "0x40FE428", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60038E1")]
			[Address(RVA = "0x40FE7B0", Offset = "0x40FA7B0", VA = "0x40FE7B0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40047C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int index;

		[Token(Token = "0x40047C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _placement;

		[Token(Token = "0x40047C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly Dictionary<string, string> _amountSprites;

		[Token(Token = "0x60038CA")]
		[Address(RVA = "0x40FB758", Offset = "0x40F7758", VA = "0x40FB758", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60038CB")]
		[Address(RVA = "0x40FBB68", Offset = "0x40F7B68", VA = "0x40FBB68")]
		private void InitPackageToggleLevel(int packageIndex, MultistageNewcomerPackagePanel_ToggleLevel toggleLevel)
		{
		}

		[Token(Token = "0x60038CC")]
		[Address(RVA = "0x40FBF2C", Offset = "0x40F7F2C", VA = "0x40FBF2C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60038CD")]
		[Address(RVA = "0x40FBFC0", Offset = "0x40F7FC0", VA = "0x40FBFC0")]
		private void SetCurrentPackageIndex(int tempIndex)
		{
		}

		[Token(Token = "0x60038CE")]
		[Address(RVA = "0x40FC4C0", Offset = "0x40F84C0", VA = "0x40FC4C0")]
		private void DataRefreshView()
		{
		}

		[Token(Token = "0x60038CF")]
		[Address(RVA = "0x40FC51C", Offset = "0x40F851C", VA = "0x40FC51C")]
		[AsyncStateMachine(typeof(_003CRefreshView_003Ed__8))]
		private void RefreshView()
		{
		}

		[Token(Token = "0x60038D0")]
		[Address(RVA = "0x40FC5B0", Offset = "0x40F85B0", VA = "0x40FC5B0", Slot = "15")]
		protected override void OnButtonExtendClaimBtnClicked()
		{
		}

		[Token(Token = "0x60038D1")]
		[Address(RVA = "0x40FC678", Offset = "0x40F8678", VA = "0x40FC678", Slot = "16")]
		protected override void OnToggleLevel1ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x60038D2")]
		[Address(RVA = "0x40FC830", Offset = "0x40F8830", VA = "0x40FC830", Slot = "17")]
		protected override void OnToggleLevel2ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x60038D3")]
		[Address(RVA = "0x40FC928", Offset = "0x40F8928", VA = "0x40FC928", Slot = "18")]
		protected override void OnToggleLevel3ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x60038D4")]
		[Address(RVA = "0x40FCA20", Offset = "0x40F8A20", VA = "0x40FCA20", Slot = "19")]
		protected override void OnToggleLevel4ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x60038D5")]
		[Address(RVA = "0x40FCB18", Offset = "0x40F8B18", VA = "0x40FCB18", Slot = "13")]
		protected override void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x60038D6")]
		[Address(RVA = "0x40FCBA4", Offset = "0x40F8BA4", VA = "0x40FCBA4", Slot = "12")]
		protected override void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x60038D7")]
		[Address(RVA = "0x40FCC30", Offset = "0x40F8C30", VA = "0x40FCC30", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60038D8")]
		[Address(RVA = "0x40FCCF4", Offset = "0x40F8CF4", VA = "0x40FCCF4", Slot = "7")]
		protected override void OnHideAnimationComplete()
		{
		}

		[Token(Token = "0x60038D9")]
		[Address(RVA = "0x40FCEC0", Offset = "0x40F8EC0", VA = "0x40FCEC0")]
		public MultistageNewcomerPackagePanel()
		{
		}
	}
}
