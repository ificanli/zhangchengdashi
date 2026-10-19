using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200050D")]
	public static class MysteryAdventureDiceRewardFly
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200050E")]
		[CompilerGenerated]
		private struct _003CShowFlyDiceAsync_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4002DAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002DAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002DAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int grantCount;

			[Token(Token = "0x4002DAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 startWorldPos;

			[Token(Token = "0x4002DAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003CactualGranted_003E5__2;

			[Token(Token = "0x4002DAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60019B5")]
			[Address(RVA = "0x3E981AC", Offset = "0x3E941AC", VA = "0x3E981AC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60019B6")]
			[Address(RVA = "0x3E98E64", Offset = "0x3E94E64", VA = "0x3E98E64", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002DA8")]
		private const float FlyDelaySeconds = 0.05f;

		[Token(Token = "0x4002DA9")]
		private const float FlyCompleteWaitSeconds = 1f;

		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x3E97E28", Offset = "0x3E93E28", VA = "0x3E97E28")]
		public static bool IsDiceBoxAssetId(string assetId)
		{
			return default;
		}

		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x3E97E74", Offset = "0x3E93E74", VA = "0x3E97E74")]
		public static int ExtractDiceGrantCount(string rewardRaw)
		{
			return default;
		}

		[Token(Token = "0x60019B2")]
		[Address(RVA = "0x3E97F70", Offset = "0x3E93F70", VA = "0x3E97F70")]
		public static bool IsOnlyDiceBoxReward(string rewardRaw)
		{
			return default;
		}

		[Token(Token = "0x60019B3")]
		[Address(RVA = "0x3E98050", Offset = "0x3E94050", VA = "0x3E98050")]
		[AsyncStateMachine(typeof(_003CShowFlyDiceAsync_003Ed__5))]
		public static UniTask ShowFlyDiceAsync(int grantCount, Vector3 startWorldPos)
		{
			return default;
		}

		[Token(Token = "0x60019B4")]
		[Address(RVA = "0x3E98100", Offset = "0x3E94100", VA = "0x3E98100")]
		private static void SuppressDiceUiUpdates(bool allowUpdate)
		{
		}
	}
}
