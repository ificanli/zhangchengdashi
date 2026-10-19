using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000674")]
	internal sealed class WorldCupMultiplierController
	{
		[Token(Token = "0x400345C")]
		[FieldOffset(Offset = "0x10")]
		private readonly Func<bool> _isSelectionLocked;

		[Token(Token = "0x400345D")]
		[FieldOffset(Offset = "0x18")]
		private readonly Func<bool> _toastActivityEnded;

		[Token(Token = "0x400345E")]
		[FieldOffset(Offset = "0x20")]
		private WorldCupActivityPanelView _view;

		[Token(Token = "0x170001DD")]
		public int SelectedMultiplier
		{
			[Token(Token = "0x6002224")]
			[Address(RVA = "0x3F31B6C", Offset = "0x3F2DB6C", VA = "0x3F31B6C")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x6002225")]
			[Address(RVA = "0x3F31B74", Offset = "0x3F2DB74", VA = "0x3F31B74")]
			[CompilerGenerated]
			private set;
		}

		[Token(Token = "0x6002223")]
		[Address(RVA = "0x3F2C160", Offset = "0x3F28160", VA = "0x3F2C160")]
		public WorldCupMultiplierController(Func<bool> isSelectionLocked, Func<bool> toastActivityEnded)
		{
		}

		[Token(Token = "0x6002226")]
		[Address(RVA = "0x3F31B7C", Offset = "0x3F2DB7C", VA = "0x3F31B7C")]
		public void Initialize(WorldCupActivityPanelView view)
		{
		}

		[Token(Token = "0x6002227")]
		[Address(RVA = "0x3F2CEFC", Offset = "0x3F28EFC", VA = "0x3F2CEFC")]
		public void Bind()
		{
		}

		[Token(Token = "0x6002228")]
		[Address(RVA = "0x3F2C91C", Offset = "0x3F2891C", VA = "0x3F2C91C")]
		public void RefreshState()
		{
		}

		[Token(Token = "0x6002229")]
		[Address(RVA = "0x3F31D74", Offset = "0x3F2DD74", VA = "0x3F31D74")]
		public void RefreshButtons()
		{
		}

		[Token(Token = "0x600222A")]
		[Address(RVA = "0x3F31CC0", Offset = "0x3F2DCC0", VA = "0x3F31CC0")]
		public bool TryAutoDowngrade()
		{
			return default;
		}

		[Token(Token = "0x600222B")]
		[Address(RVA = "0x3F2DDF0", Offset = "0x3F29DF0", VA = "0x3F2DDF0")]
		public void EnsureLayout()
		{
		}

		[Token(Token = "0x600222C")]
		[Address(RVA = "0x3F31B84", Offset = "0x3F2DB84", VA = "0x3F31B84")]
		private void BindToggle(Toggle toggle, int multiplier)
		{
		}

		[Token(Token = "0x600222D")]
		[Address(RVA = "0x3F31EB4", Offset = "0x3F2DEB4", VA = "0x3F31EB4")]
		private void SetState(Toggle toggle, int multiplier, int football, bool selectionLocked)
		{
		}

		[Token(Token = "0x600222E")]
		[Address(RVA = "0x3F32080", Offset = "0x3F2E080", VA = "0x3F32080")]
		private void Select(int multiplier)
		{
		}
	}
}
