using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000A3F")]
	public static class MysteryAdventureRuinsRpsHelper
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A40")]
		[CompilerGenerated]
		private struct _003CLoadAndCacheSpriteAsync_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4004C07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004C08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4004C09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string spritePath;

			[Token(Token = "0x4004C0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003D51")]
			[Address(RVA = "0x4159428", Offset = "0x4155428", VA = "0x4159428", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003D52")]
			[Address(RVA = "0x41599CC", Offset = "0x41559CC", VA = "0x41599CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A41")]
		[CompilerGenerated]
		private struct _003CLoadSpriteInternalAsync_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4004C0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004C0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4004C0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string spritePath;

			[Token(Token = "0x4004C0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003D53")]
			[Address(RVA = "0x4159A24", Offset = "0x4155A24", VA = "0x4159A24", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003D54")]
			[Address(RVA = "0x4159EC8", Offset = "0x4155EC8", VA = "0x4159EC8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004C00")]
		public const float RevealDelaySeconds = 1f;

		[Token(Token = "0x4004C01")]
		public const float ResultDisplayDelaySeconds = 2f;

		[Token(Token = "0x4004C02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, Sprite> SpriteCache;

		[Token(Token = "0x4004C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, Task<Sprite>> SpriteLoadingTasks;

		[Token(Token = "0x4004C04")]
		public const int ChoiceRock = 0;

		[Token(Token = "0x4004C05")]
		public const int ChoiceScissors = 1;

		[Token(Token = "0x4004C06")]
		public const int ChoicePaper = 2;

		[Token(Token = "0x6003D46")]
		[Address(RVA = "0x41581EC", Offset = "0x41541EC", VA = "0x41581EC")]
		public static float GetDelaySeconds(float baseSeconds, bool skipAnimation)
		{
			return default;
		}

		[Token(Token = "0x6003D47")]
		[Address(RVA = "0x4158138", Offset = "0x4154138", VA = "0x4158138")]
		public static float GetSpeedMultiplier(bool skipAnimation)
		{
			return default;
		}

		[Token(Token = "0x6003D48")]
		[Address(RVA = "0x41580EC", Offset = "0x41540EC", VA = "0x41580EC")]
		public static MysteryAdventureRpsOutcome Compare(int playerChoice, int opponentChoice)
		{
			return default;
		}

		[Token(Token = "0x6003D49")]
		[Address(RVA = "0x4158E90", Offset = "0x4154E90", VA = "0x4158E90")]
		public static int RollOpponentChoice()
		{
			return default;
		}

		[Token(Token = "0x6003D4A")]
		[Address(RVA = "0x4158C60", Offset = "0x4154C60", VA = "0x4158C60")]
		public static string GetChoiceIconPath(int choiceIndex)
		{
			return null;
		}

		[Token(Token = "0x6003D4B")]
		[Address(RVA = "0x4158BEC", Offset = "0x4154BEC", VA = "0x4158BEC")]
		public static string GetTitleSpritePath(MysteryAdventureRpsOutcome outcome)
		{
			return null;
		}

		[Token(Token = "0x6003D4C")]
		[Address(RVA = "0x4158EA0", Offset = "0x4154EA0", VA = "0x4158EA0")]
		public static UniTask PreloadGameplaySpritesAsync()
		{
			return default;
		}

		[Token(Token = "0x6003D4D")]
		[Address(RVA = "0x4156C6C", Offset = "0x4152C6C", VA = "0x4156C6C")]
		public static UniTask<Sprite> LoadSpriteAsync(string spritePath)
		{
			return default;
		}

		[Token(Token = "0x6003D4E")]
		[Address(RVA = "0x41591A4", Offset = "0x41551A4", VA = "0x41591A4")]
		[AsyncStateMachine(typeof(_003CLoadAndCacheSpriteAsync_003Ed__15))]
		private static UniTask<Sprite> LoadAndCacheSpriteAsync(string spritePath)
		{
			return default;
		}

		[Token(Token = "0x6003D4F")]
		[Address(RVA = "0x4159278", Offset = "0x4155278", VA = "0x4159278")]
		[AsyncStateMachine(typeof(_003CLoadSpriteInternalAsync_003Ed__16))]
		private static UniTask<Sprite> LoadSpriteInternalAsync(string spritePath)
		{
			return default;
		}
	}
}
