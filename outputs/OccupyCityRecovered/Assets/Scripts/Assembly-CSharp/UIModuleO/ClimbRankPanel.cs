using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000ABD")]
	public class ClimbRankPanel : ClimbRankPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000ABF")]
		[CompilerGenerated]
		private struct _003CPlayerItemSmashAni_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int endIndex;

			[Token(Token = "0x4004F05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int playerNowIndex;

			[Token(Token = "0x4004F06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject player;

			[Token(Token = "0x4004F07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int beginIndex;

			[Token(Token = "0x4004F08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public ClimbRankPanel _003C_003E4__this;

			[Token(Token = "0x4004F09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60040F9")]
			[Address(RVA = "0x41B1C2C", Offset = "0x41ADC2C", VA = "0x41B1C2C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60040FA")]
			[Address(RVA = "0x41B2378", Offset = "0x41AE378", VA = "0x41B2378", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AC0")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ClimbRankPanel _003C_003E4__this;

			[Token(Token = "0x4004F0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4004F0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<GlobalDanInfo> _003CdanInfo_003E5__2;

			[Token(Token = "0x4004F0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003CdanNum_003E5__3;

			[Token(Token = "0x4004F10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int _003CplayerNoGetRewardIndex_003E5__4;

			[Token(Token = "0x4004F11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003CplayerNowIndex_003E5__5;

			[Token(Token = "0x4004F12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private bool _003CdanChange_003E5__6;

			[Token(Token = "0x4004F13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003CbeginIndex_003E5__7;

			[Token(Token = "0x4004F14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int _003CendIndex_003E5__8;

			[Token(Token = "0x4004F15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private bool _003CisSameIndex_003E5__9;

			[Token(Token = "0x4004F16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private GameObject _003Cplayer_003E5__10;

			[Token(Token = "0x4004F17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Image _003C_003E7__wrap10;

			[Token(Token = "0x4004F18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004F19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x4004F1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private UniTask.Awaiter _003C_003Eu__3;

			[Token(Token = "0x4004F1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__4;

			[Token(Token = "0x60040FB")]
			[Address(RVA = "0x41B2384", Offset = "0x41AE384", VA = "0x41B2384", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60040FC")]
			[Address(RVA = "0x41B5000", Offset = "0x41B1000", VA = "0x41B5000", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly List<GameObject> _allRankItem;

		[Token(Token = "0x4004EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _canClose;

		[Token(Token = "0x4004EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Tween _btnTw;

		[Token(Token = "0x4004EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Sequence sequence;

		[Token(Token = "0x60040ED")]
		[Address(RVA = "0x41B1388", Offset = "0x41AD388", VA = "0x41B1388", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60040EE")]
		[Address(RVA = "0x41B13C0", Offset = "0x41AD3C0", VA = "0x41B13C0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60040EF")]
		[Address(RVA = "0x41B145C", Offset = "0x41AD45C", VA = "0x41B145C")]
		private float GetYContentPos(float anchoredPositionY, int endIndex, int playerNowIndex)
		{
			return default;
		}

		[Token(Token = "0x60040F0")]
		[Address(RVA = "0x41B149C", Offset = "0x41AD49C", VA = "0x41B149C")]
		[AsyncStateMachine(typeof(_003CPlayerItemSmashAni_003Ed__6))]
		private void PlayerItemSmashAni(int endIndex, int playerNowIndex, int beginIndex, GameObject player)
		{
		}

		[Token(Token = "0x60040F1")]
		[Address(RVA = "0x41B155C", Offset = "0x41AD55C", VA = "0x41B155C")]
		private void ScrollNumber(int fromVal, int toVal, float dur, TextMeshProUGUI ui)
		{
		}

		[Token(Token = "0x60040F2")]
		[Address(RVA = "0x41B170C", Offset = "0x41AD70C", VA = "0x41B170C", Slot = "12")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x60040F3")]
		[Address(RVA = "0x41B17A8", Offset = "0x41AD7A8", VA = "0x41B17A8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60040F4")]
		[Address(RVA = "0x41B19E0", Offset = "0x41AD9E0", VA = "0x41B19E0")]
		public ClimbRankPanel()
		{
		}
	}
}
