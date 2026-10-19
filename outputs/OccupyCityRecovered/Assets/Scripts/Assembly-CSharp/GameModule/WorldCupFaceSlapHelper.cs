using System;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000604")]
	public class WorldCupFaceSlapHelper
	{
		[Token(Token = "0x4003223")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_loginFaceSlapShownThisSession;

		[Token(Token = "0x4003224")]
		[FieldOffset(Offset = "0x10")]
		private readonly Func<bool> _isGmTestMode;

		[Token(Token = "0x4003225")]
		[FieldOffset(Offset = "0x18")]
		private readonly Func<WorldCupActivityPhase> _getCurrentPhase;

		[Token(Token = "0x4003226")]
		[FieldOffset(Offset = "0x20")]
		private readonly Func<bool> _shouldShowEntryButton;

		[Token(Token = "0x4003227")]
		[FieldOffset(Offset = "0x28")]
		private readonly Func<PlayerWorldCupActivityData> _getData;

		[Token(Token = "0x4003228")]
		[FieldOffset(Offset = "0x30")]
		private readonly Func<UniTask> _showPanel;

		[Token(Token = "0x600200F")]
		[Address(RVA = "0x3F059F8", Offset = "0x3F019F8", VA = "0x3F059F8")]
		public WorldCupFaceSlapHelper(Func<bool> isGmTestMode, Func<WorldCupActivityPhase> getCurrentPhase, Func<bool> shouldShowEntryButton, Func<PlayerWorldCupActivityData> getData, Func<UniTask> showPanel)
		{
		}

		[Token(Token = "0x6002010")]
		[Address(RVA = "0x3F06E5C", Offset = "0x3F02E5C", VA = "0x3F06E5C")]
		public void TryEnqueueLoginFaceSlapPopup()
		{
		}

		[Token(Token = "0x6002011")]
		[Address(RVA = "0x3F0D2E0", Offset = "0x3F092E0", VA = "0x3F0D2E0")]
		public bool ShouldShowLoginFaceSlap()
		{
			return default;
		}

		[Token(Token = "0x6002012")]
		[Address(RVA = "0x3F0D3C8", Offset = "0x3F093C8", VA = "0x3F0D3C8")]
		private static string GetFaceSlapDateKey()
		{
			return null;
		}
	}
}
