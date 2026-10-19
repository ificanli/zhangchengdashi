using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000535")]
	public static class MysteryAdventureResourceRewardFly
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000536")]
		[CompilerGenerated]
		private struct _003CShowFlyRewardsAsync_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4002EB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002EB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002EB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string rewardRaw;

			[Token(Token = "0x4002EBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int buildId;

			[Token(Token = "0x4002EBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 startWorldPos;

			[Token(Token = "0x4002EBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<(string assetId, int count)> _003CflyEntries_003E5__2;

			[Token(Token = "0x4002EBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001B15")]
			[Address(RVA = "0x3EB2B3C", Offset = "0x3EAEB3C", VA = "0x3EB2B3C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001B16")]
			[Address(RVA = "0x3EB3800", Offset = "0x3EAF800", VA = "0x3EB3800", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002EB5")]
		private const float FlyDelaySeconds = 0.05f;

		[Token(Token = "0x4002EB6")]
		private const float FlyCompleteWaitSeconds = 1f;

		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x3EAEBE0", Offset = "0x3EAABE0", VA = "0x3EAEBE0")]
		public static bool ShouldFlyResourceReward(int buildId)
		{
			return default;
		}

		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x3EB27EC", Offset = "0x3EAE7EC", VA = "0x3EB27EC")]
		public static bool IsFlyResourceId(string assetId)
		{
			return default;
		}

		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x3EAEBF0", Offset = "0x3EAABF0", VA = "0x3EAEBF0")]
		[AsyncStateMachine(typeof(_003CShowFlyRewardsAsync_003Ed__4))]
		public static UniTask ShowFlyRewardsAsync(string rewardRaw, Vector3 startWorldPos, int buildId)
		{
			return default;
		}

		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x3EB2898", Offset = "0x3EAE898", VA = "0x3EB2898")]
		private static void SuppressResourceUiUpdates(bool allowUpdate)
		{
		}

		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x3EB29D8", Offset = "0x3EAE9D8", VA = "0x3EB29D8")]
		private static UniTask TryShowTokenRewardTipAsync(string assetId, int count)
		{
			return default;
		}
	}
}
