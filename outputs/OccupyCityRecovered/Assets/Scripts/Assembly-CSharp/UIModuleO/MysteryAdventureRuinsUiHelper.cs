using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x2000A32")]
	public static class MysteryAdventureRuinsUiHelper
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A33")]
		[CompilerGenerated]
		private struct _003CLoadAndCacheCardSpriteAsync_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4004BB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004BB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4004BB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int eventId;

			[Token(Token = "0x4004BB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003CF2")]
			[Address(RVA = "0x415371C", Offset = "0x414F71C", VA = "0x415371C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003CF3")]
			[Address(RVA = "0x4153CC4", Offset = "0x414FCC4", VA = "0x4153CC4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A34")]
		[CompilerGenerated]
		private struct _003CLoadCardSpriteInternalAsync_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4004BB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004BBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4004BBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int eventId;

			[Token(Token = "0x4004BBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string _003CspritePath_003E5__2;

			[Token(Token = "0x4004BBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003CF4")]
			[Address(RVA = "0x4153D1C", Offset = "0x414FD1C", VA = "0x4153D1C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003CF5")]
			[Address(RVA = "0x4154258", Offset = "0x4150258", VA = "0x4154258", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A35")]
		[CompilerGenerated]
		private struct _003CTryLoadRewardPreviewSpriteAsync_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4004BBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004BBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4004BC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string rewardRaw;

			[Token(Token = "0x4004BC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003CF6")]
			[Address(RVA = "0x41542B0", Offset = "0x41502B0", VA = "0x41542B0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003CF7")]
			[Address(RVA = "0x41549E4", Offset = "0x41509E4", VA = "0x41549E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A36")]
		[CompilerGenerated]
		private struct _003CTryLoadRewardPreviewSpriteFromAssetsAsync_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4004BC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004BC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4004BC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string rewardRaw;

			[Token(Token = "0x4004BC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private IGlobalAssetsInfo _003Cinfo_003E5__2;

			[Token(Token = "0x4004BC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003CF8")]
			[Address(RVA = "0x4154A3C", Offset = "0x4150A3C", VA = "0x4154A3C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003CF9")]
			[Address(RVA = "0x41550F8", Offset = "0x41510F8", VA = "0x41550F8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, Sprite> CardSpriteCache;

		[Token(Token = "0x4004BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<int, Task<Sprite>> CardSpriteLoadingTasks;

		[Token(Token = "0x4004BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int[] RuinsCardEventIds;

		[Token(Token = "0x6003CDC")]
		[Address(RVA = "0x414F3CC", Offset = "0x414B3CC", VA = "0x414F3CC")]
		public static UniTask PreloadAllCardSpritesAsync()
		{
			return default;
		}

		[Token(Token = "0x6003CDD")]
		[Address(RVA = "0x413FF04", Offset = "0x413BF04", VA = "0x413FF04")]
		public static UniTask PreloadCardSpriteAsync(int eventId)
		{
			return default;
		}

		[Token(Token = "0x6003CDE")]
		[Address(RVA = "0x414ECC8", Offset = "0x414ACC8", VA = "0x414ECC8")]
		public static UniTask<Sprite> EnsureCardSpriteLoadedAsync(int eventId)
		{
			return default;
		}

		[Token(Token = "0x6003CDF")]
		[Address(RVA = "0x414F558", Offset = "0x414B558", VA = "0x414F558")]
		[AsyncStateMachine(typeof(_003CLoadAndCacheCardSpriteAsync_003Ed__6))]
		private static UniTask<Sprite> LoadAndCacheCardSpriteAsync(int eventId)
		{
			return default;
		}

		[Token(Token = "0x6003CE0")]
		[Address(RVA = "0x414EBE4", Offset = "0x414ABE4", VA = "0x414EBE4")]
		public static bool TryGetCachedCardSprite(int eventId, out Sprite sprite)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventureRuinsUiHelper.TryGetCachedCardSprite RVA=0x414EBE4 Token=0x6003CE0");
}

		[Token(Token = "0x6003CE1")]
		[Address(RVA = "0x414F638", Offset = "0x414B638", VA = "0x414F638")]
		[AsyncStateMachine(typeof(_003CLoadCardSpriteInternalAsync_003Ed__8))]
		private static UniTask<Sprite> LoadCardSpriteInternalAsync(int eventId)
		{
			return default;
		}

		[Token(Token = "0x6003CE2")]
		[Address(RVA = "0x414F71C", Offset = "0x414B71C", VA = "0x414F71C")]
		public static string GetCardSpritePath(int eventId)
		{
			return null;
		}

		[Token(Token = "0x6003CE3")]
		[Address(RVA = "0x414F7EC", Offset = "0x414B7EC", VA = "0x414F7EC")]
		public static bool TryParseRuinsRewardRaw(string rewardRaw, out int itemType, out int itemId, out int count)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventureRuinsUiHelper.TryParseRuinsRewardRaw RVA=0x414F7EC Token=0x6003CE3");
}

		[Token(Token = "0x6003CE4")]
		[Address(RVA = "0x414F904", Offset = "0x414B904", VA = "0x414F904")]
		public static string GetRewardPreviewSpritePath(string rewardRaw)
		{
			return null;
		}

		[Token(Token = "0x6003CE5")]
		[Address(RVA = "0x414F2E0", Offset = "0x414B2E0", VA = "0x414F2E0")]
		[AsyncStateMachine(typeof(_003CTryLoadRewardPreviewSpriteAsync_003Ed__12))]
		public static UniTask<Sprite> TryLoadRewardPreviewSpriteAsync(string rewardRaw)
		{
			return default;
		}

		[Token(Token = "0x6003CE6")]
		[Address(RVA = "0x414FCEC", Offset = "0x414BCEC", VA = "0x414FCEC")]
		[AsyncStateMachine(typeof(_003CTryLoadRewardPreviewSpriteFromAssetsAsync_003Ed__13))]
		private static UniTask<Sprite> TryLoadRewardPreviewSpriteFromAssetsAsync(string rewardRaw)
		{
			return default;
		}

		[Token(Token = "0x6003CE7")]
		[Address(RVA = "0x414F9B0", Offset = "0x414B9B0", VA = "0x414F9B0")]
		private static bool TryResolveRewardPreviewAssetId(string rewardRaw, out string assetId)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventureRuinsUiHelper.TryResolveRewardPreviewAssetId RVA=0x414F9B0 Token=0x6003CE7");
}

		[Token(Token = "0x6003CE8")]
		[Address(RVA = "0x414FA88", Offset = "0x414BA88", VA = "0x414FA88")]
		private static string GetStaticIconPath(IGlobalAssetsInfo info)
		{
			return null;
		}

		[Token(Token = "0x6003CE9")]
		[Address(RVA = "0x414FDD0", Offset = "0x414BDD0", VA = "0x414FDD0")]
		private static string TakeFirstAssetPath(string path)
		{
			return null;
		}

		[Token(Token = "0x6003CEA")]
		[Address(RVA = "0x414E098", Offset = "0x414A098", VA = "0x414E098")]
		public static List<string> CollectOptionTexts(RuinsConfigConfig config, int rewardMultiplier = 1)
		{
			return null;
		}

		[Token(Token = "0x6003CEB")]
		[Address(RVA = "0x414FE28", Offset = "0x414BE28", VA = "0x414FE28")]
		private static string ScaleRoadsideDiceOptionText(string text, int multiplier)
		{
			return null;
		}

		[Token(Token = "0x6003CEC")]
		[Address(RVA = "0x414FF5C", Offset = "0x414BF5C", VA = "0x414FF5C")]
		private static void AppendOptionText(List<string> result, string text)
		{
		}

		[Token(Token = "0x6003CED")]
		[Address(RVA = "0x414E190", Offset = "0x414A190", VA = "0x414E190")]
		public static string FormatRandomRewardDescription(string template, string rewardRaw)
		{
			return null;
		}

		[Token(Token = "0x6003CEE")]
		[Address(RVA = "0x414E34C", Offset = "0x414A34C", VA = "0x414E34C")]
		public static string FormatBlackHoleDescription(string template, bool forward, int steps)
		{
			return null;
		}

		[Token(Token = "0x6003CEF")]
		[Address(RVA = "0x414E458", Offset = "0x414A458", VA = "0x414E458")]
		public static string BuildRewardPreviewCountText(string rewardRaw)
		{
			return null;
		}

		[Token(Token = "0x6003CF0")]
		[Address(RVA = "0x4150010", Offset = "0x414C010", VA = "0x4150010")]
		public static string BuildRewardPreviewText(string rewardRaw)
		{
			return null;
		}
	}
}
