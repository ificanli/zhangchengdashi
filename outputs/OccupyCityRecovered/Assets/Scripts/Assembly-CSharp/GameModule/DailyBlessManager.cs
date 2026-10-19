using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x2000494")]
	public class DailyBlessManager : ManagerBase<DailyBlessManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000496")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4002B6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002B6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002B6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DailyBlessManager _003C_003E4__this;

			[Token(Token = "0x60016CE")]
			[Address(RVA = "0x3E4EB9C", Offset = "0x3E4AB9C", VA = "0x3E4EB9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60016CF")]
			[Address(RVA = "0x3E4F0A8", Offset = "0x3E4B0A8", VA = "0x3E4F0A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002B3E")]
		public const int GoldWeight = 1;

		[Token(Token = "0x4002B3F")]
		public const int PurpleWeight = 2;

		[Token(Token = "0x4002B40")]
		public const int BlueWeight = 4;

		[Token(Token = "0x4002B41")]
		public const int GreenWeight = 6;

		[Token(Token = "0x4002B42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int PlayerCostCoinNumber;

		[Token(Token = "0x4002B43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int EnemyCostCoinNumber;

		[Token(Token = "0x4002B44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int SuperSummonNumber;

		[Token(Token = "0x4002B45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool NowPlayerSuperSummon;

		[Token(Token = "0x4002B46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool NowEnemySuperSummon;

		[Token(Token = "0x4002B47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, BlessBase> allBlessHandleClass;

		[Token(Token = "0x4002B48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Dictionary<string, Func<string, BlessBase>> blessCreators;

		[Token(Token = "0x6001692")]
		[Address(RVA = "0x3E4ACD0", Offset = "0x3E46CD0", VA = "0x3E4ACD0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__10))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001693")]
		[Address(RVA = "0x3E4AD54", Offset = "0x3E46D54", VA = "0x3E4AD54")]
		public void RefreshDailyBless()
		{
		}

		[Token(Token = "0x6001694")]
		[Address(RVA = "0x3E4AE98", Offset = "0x3E46E98", VA = "0x3E4AE98")]
		public string GetRandomBlessId([Optional] List<string> excludeId)
		{
			return null;
		}

		[Token(Token = "0x6001695")]
		[Address(RVA = "0x3E4B138", Offset = "0x3E47138", VA = "0x3E4B138")]
		public void ChooseDayBless(GlobalBlessInfo info, int index)
		{
		}

		[Token(Token = "0x6001696")]
		[Address(RVA = "0x3E4B480", Offset = "0x3E47480", VA = "0x3E4B480")]
		private (bool, string) GetPlayerBlessId()
		{
			return default;
		}

		[Token(Token = "0x6001697")]
		[Address(RVA = "0x3E4B574", Offset = "0x3E47574", VA = "0x3E4B574")]
		private bool ShouldApplyDailyBless()
		{
			return default;
		}

		[Token(Token = "0x6001698")]
		[Address(RVA = "0x3E4B634", Offset = "0x3E47634", VA = "0x3E4B634")]
		public void RoleUnitNumberHandle(bool isEnemy, RolePropertyTemp propertyTemp, CardFettersType fettersType, AtkWayType atkWayType)
		{
		}

		[Token(Token = "0x6001699")]
		[Address(RVA = "0x3E4B858", Offset = "0x3E47858", VA = "0x3E4B858")]
		private void RoleUnitNumberLogic(string id, CardFettersType fettersType, AtkWayType atkWayType, RolePropertyTemp propertyTemp)
		{
		}

		[Token(Token = "0x600169A")]
		[Address(RVA = "0x3E4BA88", Offset = "0x3E47A88", VA = "0x3E4BA88")]
		public int GoldCardOddHandle(bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600169B")]
		[Address(RVA = "0x3E4BB3C", Offset = "0x3E47B3C", VA = "0x3E4BB3C")]
		private int GoldCardOddLogic(string id)
		{
			return default;
		}

		[Token(Token = "0x600169C")]
		[Address(RVA = "0x3E4BC40", Offset = "0x3E47C40", VA = "0x3E4BC40")]
		public float GoldMineOutPutHandle(bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600169D")]
		[Address(RVA = "0x3E4BD04", Offset = "0x3E47D04", VA = "0x3E4BD04")]
		private float GoldMineOutPutLogic(string id)
		{
			return default;
		}

		[Token(Token = "0x600169E")]
		[Address(RVA = "0x3E4BDE0", Offset = "0x3E47DE0", VA = "0x3E4BDE0")]
		public int KillUnitCoinHandle(bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600169F")]
		[Address(RVA = "0x3E4BE98", Offset = "0x3E47E98", VA = "0x3E4BE98")]
		private int KillUnitCoinLogic(string id)
		{
			return default;
		}

		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x3E4BF90", Offset = "0x3E47F90", VA = "0x3E4BF90")]
		private void PlayerCostCoin(object o)
		{
		}

		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x3E4C054", Offset = "0x3E48054", VA = "0x3E4C054")]
		private void EnemyCostCoin(object o)
		{
		}

		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x3E4C148", Offset = "0x3E48148", VA = "0x3E4C148")]
		private void OnGameOver(object o)
		{
		}

		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x3E4C150", Offset = "0x3E48150", VA = "0x3E4C150")]
		public void ShowDailyBlessPanel()
		{
		}

		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x3E4B718", Offset = "0x3E47718", VA = "0x3E4B718")]
		public bool IsBTest()
		{
			return default;
		}

		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x3E4B9A8", Offset = "0x3E479A8", VA = "0x3E4B9A8")]
		public BlessBase CreateBless(string id)
		{
			return null;
		}

		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x3E4C2BC", Offset = "0x3E482BC", VA = "0x3E4C2BC")]
		private static float GetBlessValue(string id)
		{
			return default;
		}

		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x3E4B78C", Offset = "0x3E4778C", VA = "0x3E4B78C")]
		private static BlessType GetBlessType(string id)
		{
			return default;
		}

		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x3E4C348", Offset = "0x3E48348", VA = "0x3E4C348")]
		public DailyBlessManager()
		{
		}
	}
}
