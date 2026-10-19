using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000804")]
	public class NewArtifactItem : NewArtifactItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000805")]
		[CompilerGenerated]
		private struct _003CGetArtifactQuality_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4003D8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int rareLevel;

			[Token(Token = "0x4003D8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002CC7")]
			[Address(RVA = "0x400342C", Offset = "0x3FFF42C", VA = "0x400342C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002CC8")]
			[Address(RVA = "0x4003D60", Offset = "0x3FFFD60", VA = "0x4003D60", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000806")]
		[CompilerGenerated]
		private struct _003CInitItem_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public NewArtifactItem _003C_003E4__this;

			[Token(Token = "0x4003D91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UserPropData data;

			[Token(Token = "0x4003D92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isSelected;

			[Token(Token = "0x4003D93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool playSwitchAnim;

			[Token(Token = "0x4003D94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private GlobalPropInfo _003Cinfo_003E5__2;

			[Token(Token = "0x4003D95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Sprite _003Cicon_003E5__3;

			[Token(Token = "0x4003D96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002CC9")]
			[Address(RVA = "0x4003DB8", Offset = "0x3FFFDB8", VA = "0x4003DB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002CCA")]
			[Address(RVA = "0x4004910", Offset = "0x4000910", VA = "0x4004910", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000807")]
		[CompilerGenerated]
		private struct _003COnButtonExtendQualityBgClicked_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public NewArtifactItem _003C_003E4__this;

			[Token(Token = "0x4003D9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002CCB")]
			[Address(RVA = "0x400491C", Offset = "0x400091C", VA = "0x400491C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002CCC")]
			[Address(RVA = "0x4004CC0", Offset = "0x4000CC0", VA = "0x4004CC0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003D87")]
		private const float SwitchAnimDuration = 0.8f;

		[Token(Token = "0x4003D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UserPropData userData;

		[Token(Token = "0x4003D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Tween _pitchOnTween;

		[Token(Token = "0x6002CBD")]
		[Address(RVA = "0x4002964", Offset = "0x3FFE964", VA = "0x4002964", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002CBE")]
		[Address(RVA = "0x400299C", Offset = "0x3FFE99C", VA = "0x400299C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002CBF")]
		[Address(RVA = "0x40029C4", Offset = "0x3FFE9C4", VA = "0x40029C4")]
		[AsyncStateMachine(typeof(_003CInitItem_003Ed__5))]
		public void InitItem(UserPropData data, bool isSelected = false, bool playSwitchAnim = false)
		{
		}

		[Token(Token = "0x6002CC0")]
		[Address(RVA = "0x4002A84", Offset = "0x3FFEA84", VA = "0x4002A84")]
		private void RefreshUpgradeProgress(UserPropData data, GlobalPropInfo info)
		{
		}

		[Token(Token = "0x6002CC1")]
		[Address(RVA = "0x4002E8C", Offset = "0x3FFEE8C", VA = "0x4002E8C")]
		private void RefreshPitchOnState(bool isSelected, bool playSwitchAnim)
		{
		}

		[Token(Token = "0x6002CC2")]
		[Address(RVA = "0x4003244", Offset = "0x3FFF244", VA = "0x4003244")]
		[AsyncStateMachine(typeof(_003CGetArtifactQuality_003Ed__8))]
		private UniTask<Sprite> GetArtifactQuality(int rareLevel)
		{
			return default;
		}

		[Token(Token = "0x6002CC3")]
		[Address(RVA = "0x4003318", Offset = "0x3FFF318", VA = "0x4003318", Slot = "12")]
		[AsyncStateMachine(typeof(_003COnButtonExtendQualityBgClicked_003Ed__9))]
		protected override void OnButtonExtendQualityBgClicked()
		{
		}

		[Token(Token = "0x6002CC4")]
		[Address(RVA = "0x40033A4", Offset = "0x3FFF3A4", VA = "0x40033A4")]
		public NewArtifactItem()
		{
		}
	}
}
