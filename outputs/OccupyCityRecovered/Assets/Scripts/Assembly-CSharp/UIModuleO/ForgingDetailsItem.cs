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
	[Token(Token = "0x200087B")]
	public class ForgingDetailsItem : ForgingDetailsItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200087C")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4004031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ForgingDetailsItem _003C_003E4__this;

			[Token(Token = "0x4004034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UserPropData artifactData;

			[Token(Token = "0x4004035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string traitId;

			[Token(Token = "0x4004036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int unlockLevel;

			[Token(Token = "0x4004037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool playUnlockEffect;

			[Token(Token = "0x4004038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
			private bool _003CshouldPlayUnlockEffect_003E5__2;

			[Token(Token = "0x4004039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400403A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private GlobalArtifactsForgeInfo _003CtraitConfig_003E5__3;

			[Token(Token = "0x400403B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6002FC1")]
			[Address(RVA = "0x403A868", Offset = "0x4036868", VA = "0x403A868", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002FC2")]
			[Address(RVA = "0x403BE70", Offset = "0x4037E70", VA = "0x403BE70", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200087D")]
		[CompilerGenerated]
		private struct _003COnButtonExtendRefreshClicked_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x400403C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400403D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400403E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ForgingDetailsItem _003C_003E4__this;

			[Token(Token = "0x400403F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002FC3")]
			[Address(RVA = "0x403BE7C", Offset = "0x4037E7C", VA = "0x403BE7C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002FC4")]
			[Address(RVA = "0x403C2D0", Offset = "0x40382D0", VA = "0x403C2D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200087E")]
		[CompilerGenerated]
		private struct _003CPlayUnlockRevealEffect_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4004040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ForgingDetailsItem _003C_003E4__this;

			[Token(Token = "0x4004043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003CtotalDelayMs_003E5__2;

			[Token(Token = "0x4004044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int _003CrevealDelayMs_003E5__3;

			[Token(Token = "0x4004045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002FC5")]
			[Address(RVA = "0x403C2DC", Offset = "0x40382DC", VA = "0x403C2DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002FC6")]
			[Address(RVA = "0x403CA94", Offset = "0x4038A94", VA = "0x403CA94", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200087F")]
		[CompilerGenerated]
		private struct _003CSetBackground_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4004046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string spritePath;

			[Token(Token = "0x4004049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ForgingDetailsItem _003C_003E4__this;

			[Token(Token = "0x400404A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002FC7")]
			[Address(RVA = "0x403CAA0", Offset = "0x4038AA0", VA = "0x403CAA0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002FC8")]
			[Address(RVA = "0x403CF4C", Offset = "0x4038F4C", VA = "0x403CF4C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UserPropData _userData;

		[Token(Token = "0x4004027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string _currentTraitId;

		[Token(Token = "0x4004028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _unlockLevel;

		[Token(Token = "0x4004029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Tween _unlockRevealTween;

		[Token(Token = "0x400402A")]
		private const string LockSpineIdleAnimation = "JT";

		[Token(Token = "0x400402B")]
		private const string LockSpineUnlockAnimation = "JS";

		[Token(Token = "0x400402C")]
		private const float UnlockAnimationFallbackDuration = 0.45f;

		[Token(Token = "0x400402D")]
		private const float UnlockRevealDuration = 0.22f;

		[Token(Token = "0x400402E")]
		private const float UnlockRevealStartScale = 0.86f;

		[Token(Token = "0x400402F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Color[] QualityTextColors;

		[Token(Token = "0x4004030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string[] QualityBgPaths;

		[Token(Token = "0x6002FB3")]
		[Address(RVA = "0x4039C8C", Offset = "0x4035C8C", VA = "0x4039C8C")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__11))]
		public UniTask Init(UserPropData artifactData, string traitId, int unlockLevel, bool playUnlockEffect = false)
		{
			return default;
		}

		[Token(Token = "0x6002FB4")]
		[Address(RVA = "0x4039D50", Offset = "0x4035D50", VA = "0x4039D50")]
		[AsyncStateMachine(typeof(_003CSetBackground_003Ed__12))]
		private UniTask SetBackground(string spritePath)
		{
			return default;
		}

		[Token(Token = "0x6002FB5")]
		[Address(RVA = "0x4039DE8", Offset = "0x4035DE8", VA = "0x4039DE8")]
		[AsyncStateMachine(typeof(_003CPlayUnlockRevealEffect_003Ed__13))]
		private UniTask PlayUnlockRevealEffect()
		{
			return default;
		}

		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0x4039E78", Offset = "0x4035E78", VA = "0x4039E78")]
		private void ShowUnlockContentWithRevealTween()
		{
		}

		[Token(Token = "0x6002FB7")]
		[Address(RVA = "0x403A0B4", Offset = "0x40360B4", VA = "0x403A0B4")]
		private void PlayLockSpineAnimation(string animationName, bool loop)
		{
		}

		[Token(Token = "0x6002FB8")]
		[Address(RVA = "0x403A3B0", Offset = "0x40363B0", VA = "0x403A3B0")]
		private float GetLockSpineAnimationDuration(string animationName, float fallbackDuration)
		{
			return default;
		}

		[Token(Token = "0x6002FB9")]
		[Address(RVA = "0x403A2CC", Offset = "0x40362CC", VA = "0x403A2CC")]
		private bool HasLockSpineAnimation(string animationName)
		{
			return default;
		}

		[Token(Token = "0x6002FBA")]
		[Address(RVA = "0x403A4A8", Offset = "0x40364A8", VA = "0x403A4A8")]
		private void ResetUnlockContentScale()
		{
		}

		[Token(Token = "0x6002FBB")]
		[Address(RVA = "0x403A08C", Offset = "0x403608C", VA = "0x403A08C")]
		private void StopUnlockRevealTween()
		{
		}

		[Token(Token = "0x6002FBC")]
		[Address(RVA = "0x403A57C", Offset = "0x403657C", VA = "0x403A57C", Slot = "12")]
		[AsyncStateMachine(typeof(_003COnButtonExtendRefreshClicked_003Ed__20))]
		protected override void OnButtonExtendRefreshClicked()
		{
		}

		[Token(Token = "0x6002FBD")]
		[Address(RVA = "0x403A608", Offset = "0x4036608", VA = "0x403A608")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002FBE")]
		[Address(RVA = "0x403A630", Offset = "0x4036630", VA = "0x403A630")]
		public ForgingDetailsItem()
		{
		}
	}
}
