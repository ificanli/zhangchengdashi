using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x2000663")]
	public class WorldCupDailyTaskPageView : MonoBehaviour
	{
		[Token(Token = "0x40033E1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _content;

		[Token(Token = "0x40033E2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WorldCupDailyTaskItemView _itemTemplate;

		[Token(Token = "0x40033E3")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<WorldCupDailyTaskItemView> _items;

		[Token(Token = "0x40033E4")]
		[FieldOffset(Offset = "0x38")]
		private Action<WorldCupdailyTaskConfig> _onClaim;

		[Token(Token = "0x40033E5")]
		[FieldOffset(Offset = "0x40")]
		private Action<WorldCupdailyTaskConfig> _onGoto;

		[Token(Token = "0x40033E6")]
		[FieldOffset(Offset = "0x48")]
		private bool _initialized;

		[Token(Token = "0x600219C")]
		[Address(RVA = "0x3F2A144", Offset = "0x3F26144", VA = "0x3F2A144")]
		private void Awake()
		{
		}

		[Token(Token = "0x600219D")]
		[Address(RVA = "0x3F2A1D8", Offset = "0x3F261D8", VA = "0x3F2A1D8")]
		public void Initialize(Action<WorldCupdailyTaskConfig> onClaim, Action<WorldCupdailyTaskConfig> onGoto)
		{
		}

		[Token(Token = "0x600219E")]
		[Address(RVA = "0x3F2A1E8", Offset = "0x3F261E8", VA = "0x3F2A1E8")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600219F")]
		[Address(RVA = "0x3F2A4E0", Offset = "0x3F264E0", VA = "0x3F2A4E0")]
		private static List<WorldCupdailyTaskConfig> BuildSortedDailyTaskConfigs()
		{
			return null;
		}

		[Token(Token = "0x60021A0")]
		[Address(RVA = "0x3F2A7A0", Offset = "0x3F267A0", VA = "0x3F2A7A0")]
		private static int CompareDailyTaskDisplayOrder(WorldCupdailyTaskConfig a, WorldCupdailyTaskConfig b)
		{
			return default;
		}

		[Token(Token = "0x60021A1")]
		[Address(RVA = "0x3F2A808", Offset = "0x3F26808", VA = "0x3F2A808")]
		private static int GetDailyTaskDisplayOrder(WorldCupdailyTaskConfig config)
		{
			return default;
		}

		[Token(Token = "0x60021A2")]
		[Address(RVA = "0x3F2A8B0", Offset = "0x3F268B0", VA = "0x3F2A8B0")]
		public WorldCupDailyTaskPageView()
		{
		}
	}
}
