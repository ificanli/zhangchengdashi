using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace SDKModule
{
	[Token(Token = "0x2000183")]
	public class AdButtonManager : ManagerBase<AdButtonManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000184")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4001A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001A80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AdButtonManager _003C_003E4__this;

			[Token(Token = "0x4001A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x3F7718C", Offset = "0x3F7318C", VA = "0x3F7718C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x3F779A8", Offset = "0x3F739A8", VA = "0x3F779A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<AdButtonExtend> _adButtons;

		[Token(Token = "0x4001A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Sprite _iconAdSprite;

		[Token(Token = "0x4001A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Sprite _iconAdCouponsSprite;

		[Token(Token = "0x4001A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Sprite _iconFreeSprite;

		[Token(Token = "0x4001A7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _isNeedWatchAds;

		[Token(Token = "0x4001A7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool _btnInteractable;

		[Token(Token = "0x4001A7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Sprite _adIcon;

		[Token(Token = "0x17000091")]
		private bool IsRemoveRewardAd
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x3F76CDC", Offset = "0x3F72CDC", VA = "0x3F76CDC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x3F76CE4", Offset = "0x3F72CE4", VA = "0x3F76CE4", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__9))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x3F76D74", Offset = "0x3F72D74", VA = "0x3F76D74")]
		public void RegisterButtonToButtonEvents(AdButtonExtend button)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x3F76EA0", Offset = "0x3F72EA0", VA = "0x3F76EA0")]
		public void UnRegisterButtonToButtonEvents(AdButtonExtend button)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x3F76F30", Offset = "0x3F72F30", VA = "0x3F76F30")]
		private void Update()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x3F76F34", Offset = "0x3F72F34", VA = "0x3F76F34")]
		private void OnVideoCouponsNumberChanged(string s)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x3F76F88", Offset = "0x3F72F88", VA = "0x3F76F88")]
		private void ToUpdateIcon(Sprite adSprite)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x3F770EC", Offset = "0x3F730EC", VA = "0x3F770EC")]
		public bool IsRewardedAvailable()
		{
			return default;
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x3F770F4", Offset = "0x3F730F4", VA = "0x3F770F4")]
		public AdButtonManager()
		{
		}
	}
}
