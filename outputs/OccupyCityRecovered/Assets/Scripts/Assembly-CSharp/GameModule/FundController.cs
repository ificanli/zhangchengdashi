using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000498")]
	public class FundController : MonoBehaviour
	{
		[Token(Token = "0x4002B73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FundManager.FundType> allFundTypes;

		[Token(Token = "0x4002B74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<FundManager.FundType, Dictionary<int, FundManager.FundLevelData>> levelDataDict;

		[Token(Token = "0x4002B75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FundManager.FundType currentShowFundType;

		[Token(Token = "0x4002B76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _placement;

		[Token(Token = "0x4002B77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FundManager _fundManager;

		[Token(Token = "0x17000149")]
		public FundManager.FundType CurrentShowFundType
		{
			[Token(Token = "0x60016D7")]
			[Address(RVA = "0x3E4F4C0", Offset = "0x3E4B4C0", VA = "0x3E4F4C0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60016D8")]
		[Address(RVA = "0x3E4F4C8", Offset = "0x3E4B4C8", VA = "0x3E4F4C8")]
		public void Init(List<FundManager.FundType> allFundTypes, Dictionary<FundManager.FundType, Dictionary<int, FundManager.FundLevelData>> levelDataDict, FundManager fundManager, [Optional] string placement)
		{
		}

		[Token(Token = "0x60016D9")]
		[Address(RVA = "0x3E4F550", Offset = "0x3E4B550", VA = "0x3E4F550")]
		public void UpdatePanel()
		{
		}

		[Token(Token = "0x60016DA")]
		[Address(RVA = "0x3E4F5E0", Offset = "0x3E4B5E0", VA = "0x3E4F5E0")]
		public void ShowPassPanel(FundManager.FundType fundType)
		{
		}

		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x3E4F7E0", Offset = "0x3E4B7E0", VA = "0x3E4F7E0")]
		public FundManager.FundLevelData GetLevelData(FundManager.FundType fundType, int level)
		{
			return null;
		}

		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x3E4F880", Offset = "0x3E4B880", VA = "0x3E4F880")]
		public FundManager.FundLevelData GetMaxLevelData(FundManager.FundType fundType)
		{
			return null;
		}

		[Token(Token = "0x60016DD")]
		[Address(RVA = "0x3E4F8AC", Offset = "0x3E4B8AC", VA = "0x3E4F8AC")]
		public int GetMaxLevel(FundManager.FundType fundType)
		{
			return default;
		}

		[Token(Token = "0x60016DE")]
		[Address(RVA = "0x3E4F924", Offset = "0x3E4B924", VA = "0x3E4F924")]
		public FundController()
		{
		}
	}
}
