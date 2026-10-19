using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x20009CB")]
	public class MysteryAdventureDailyTaskPageView : MonoBehaviour
	{
		[Token(Token = "0x40048FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _content;

		[Token(Token = "0x40048FD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MysteryAdventureDailyTaskItemView _itemTemplate;

		[Token(Token = "0x40048FE")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<MysteryAdventureDailyTaskItemView> _items;

		[Token(Token = "0x40048FF")]
		[FieldOffset(Offset = "0x38")]
		private Action<DailyTaskConfig> _onClaim;

		[Token(Token = "0x4004900")]
		[FieldOffset(Offset = "0x40")]
		private Action<DailyTaskConfig> _onGoto;

		[Token(Token = "0x4004901")]
		[FieldOffset(Offset = "0x48")]
		private bool _initialized;

		[Token(Token = "0x170008E5")]
		public RectTransform Content
		{
			[Token(Token = "0x6003A4E")]
			[Address(RVA = "0x4113834", Offset = "0x410F834", VA = "0x4113834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008E6")]
		public MysteryAdventureDailyTaskItemView ItemTemplate
		{
			[Token(Token = "0x6003A4F")]
			[Address(RVA = "0x411383C", Offset = "0x410F83C", VA = "0x411383C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003A50")]
		[Address(RVA = "0x4113844", Offset = "0x410F844", VA = "0x4113844")]
		public void Initialize(Action<DailyTaskConfig> onClaim, Action<DailyTaskConfig> onGoto)
		{
		}

		[Token(Token = "0x6003A51")]
		[Address(RVA = "0x4113854", Offset = "0x410F854", VA = "0x4113854")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6003A52")]
		[Address(RVA = "0x4113B44", Offset = "0x410FB44", VA = "0x4113B44")]
		private static List<DailyTaskConfig> BuildSortedDailyTaskConfigs()
		{
			return null;
		}

		[Token(Token = "0x6003A53")]
		[Address(RVA = "0x4113E04", Offset = "0x410FE04", VA = "0x4113E04")]
		private static int CompareDailyTaskDisplayOrder(DailyTaskConfig a, DailyTaskConfig b)
		{
			return default;
		}

		[Token(Token = "0x6003A54")]
		[Address(RVA = "0x4113E6C", Offset = "0x410FE6C", VA = "0x4113E6C")]
		private static int GetDailyTaskDisplayOrder(DailyTaskConfig config)
		{
			return default;
		}

		[Token(Token = "0x6003A55")]
		[Address(RVA = "0x4113F14", Offset = "0x410FF14", VA = "0x4113F14")]
		internal void BindContent(RectTransform content)
		{
		}

		[Token(Token = "0x6003A56")]
		[Address(RVA = "0x4113F1C", Offset = "0x410FF1C", VA = "0x4113F1C")]
		internal void BindItemTemplate(MysteryAdventureDailyTaskItemView template)
		{
		}

		[Token(Token = "0x6003A57")]
		[Address(RVA = "0x4113F24", Offset = "0x410FF24", VA = "0x4113F24")]
		public MysteryAdventureDailyTaskPageView()
		{
		}
	}
}
