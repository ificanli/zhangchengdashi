using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20007FB")]
	public class ArtifactStarLevelUI : ArtifactStarLevelUIComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007FC")]
		[CompilerGenerated]
		private struct _003CPlayStarUpgradeAnim_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int oldLevel;

			[Token(Token = "0x4003D69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ArtifactStarLevelUI _003C_003E4__this;

			[Token(Token = "0x4003D6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003CupgradeImg_003E5__2;

			[Token(Token = "0x4003D6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6002C9F")]
			[Address(RVA = "0x4000CBC", Offset = "0x3FFCCBC", VA = "0x4000CBC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002CA0")]
			[Address(RVA = "0x4001200", Offset = "0x3FFD200", VA = "0x4001200", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003D61")]
		private const int StarCount = 5;

		[Token(Token = "0x4003D62")]
		public const int SlotsPerStar = 6;

		[Token(Token = "0x4003D63")]
		private const int MaxLevel = 30;

		[Token(Token = "0x4003D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Sequence _nextTierSeq;

		[Token(Token = "0x4003D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _nextTierImg;

		[Token(Token = "0x6002C97")]
		[Address(RVA = "0x40004D4", Offset = "0x3FFC4D4", VA = "0x40004D4")]
		public void SetStarLevel(int level, bool showNextTier)
		{
		}

		[Token(Token = "0x6002C98")]
		[Address(RVA = "0x400085C", Offset = "0x3FFC85C", VA = "0x400085C")]
		private Image GetCurrentLevelImage(int starIndex, int slotIndex)
		{
			return null;
		}

		[Token(Token = "0x6002C99")]
		[Address(RVA = "0x400094C", Offset = "0x3FFC94C", VA = "0x400094C")]
		private Image GetNextLevelImage(int starIndex, int slotIndex)
		{
			return null;
		}

		[Token(Token = "0x6002C9A")]
		[Address(RVA = "0x4000A3C", Offset = "0x3FFCA3C", VA = "0x4000A3C")]
		private void StopNextTierTween()
		{
		}

		[Token(Token = "0x6002C9B")]
		[Address(RVA = "0x4000B18", Offset = "0x3FFCB18", VA = "0x4000B18")]
		private Image GetStarUpgradeImage(int starIndex, int slotIndex)
		{
			return null;
		}

		[Token(Token = "0x6002C9C")]
		[Address(RVA = "0x4000C08", Offset = "0x3FFCC08", VA = "0x4000C08")]
		[AsyncStateMachine(typeof(_003CPlayStarUpgradeAnim_003Ed__10))]
		public UniTask PlayStarUpgradeAnim(int oldLevel)
		{
			return default;
		}

		[Token(Token = "0x6002C9D")]
		[Address(RVA = "0x4000CA8", Offset = "0x3FFCCA8", VA = "0x4000CA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002C9E")]
		[Address(RVA = "0x4000CAC", Offset = "0x3FFCCAC", VA = "0x4000CAC")]
		public ArtifactStarLevelUI()
		{
		}
	}
}
