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
	[Token(Token = "0x20003ED")]
	public class EquipCardInfoManager : ManagerBase<EquipCardInfoManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003F8")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__50 : IAsyncStateMachine
		{
			[Token(Token = "0x400282E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400282F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public EquipCardInfoManager _003C_003E4__this;

			[Token(Token = "0x60012A0")]
			[Address(RVA = "0x3DD1734", Offset = "0x3DCD734", VA = "0x3DD1734", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60012A1")]
			[Address(RVA = "0x3DD1B10", Offset = "0x3DCDB10", VA = "0x3DD1B10", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GlobalHeroCardInfo> _cardInfoList;

		[Token(Token = "0x4002811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<GlobalHeroCardInfo> _cardRInfoList;

		[Token(Token = "0x4002812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<GlobalHeroCardInfo> _cardSrInfoList;

		[Token(Token = "0x4002813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GlobalHeroCardInfo> _cardSsrInfoList;

		[Token(Token = "0x4002814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<GlobalHeroCardInfo> _cardSssrInfoList;

		[Token(Token = "0x4002815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<GlobalHeroCardInfo> _cardRNoGoldMineInfoList;

		[Token(Token = "0x4002816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _orcsCount;

		[Token(Token = "0x4002817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _unDeadCount;

		[Token(Token = "0x4002818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _terranCount;

		[Token(Token = "0x4002819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _meleeCount;

		[Token(Token = "0x400281A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _remoteCount;

		[Token(Token = "0x400281B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _machineCount;

		[Token(Token = "0x170000FF")]
		public bool IsOneRCard
		{
			[Token(Token = "0x600125D")]
			[Address(RVA = "0x3DCE2D0", Offset = "0x3DCA2D0", VA = "0x3DCE2D0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000100")]
		public bool IsOneSrCard
		{
			[Token(Token = "0x600125E")]
			[Address(RVA = "0x3DCE320", Offset = "0x3DCA320", VA = "0x3DCE320")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000101")]
		public bool IsOneSsrCard
		{
			[Token(Token = "0x600125F")]
			[Address(RVA = "0x3DCE370", Offset = "0x3DCA370", VA = "0x3DCE370")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000102")]
		public bool IsOneSssrCard
		{
			[Token(Token = "0x6001260")]
			[Address(RVA = "0x3DCE3C0", Offset = "0x3DCA3C0", VA = "0x3DCE3C0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000103")]
		public int OrcsCount
		{
			[Token(Token = "0x6001261")]
			[Address(RVA = "0x3DCE410", Offset = "0x3DCA410", VA = "0x3DCE410")]
			get
			{
				return _orcsCount;
			}
		}

		[Token(Token = "0x17000104")]
		public int UnDeadCount
		{
			[Token(Token = "0x6001262")]
			[Address(RVA = "0x3DCE418", Offset = "0x3DCA418", VA = "0x3DCE418")]
			get
			{
				return _unDeadCount;
			}
		}

		[Token(Token = "0x17000105")]
		public int TerranCount
		{
			[Token(Token = "0x6001263")]
			[Address(RVA = "0x3DCE420", Offset = "0x3DCA420", VA = "0x3DCE420")]
			get
			{
				return _terranCount;
			}
		}

		[Token(Token = "0x17000106")]
		public int MeleeCount
		{
			[Token(Token = "0x6001264")]
			[Address(RVA = "0x3DCE428", Offset = "0x3DCA428", VA = "0x3DCE428")]
			get
			{
				return _meleeCount;
			}
		}

		[Token(Token = "0x17000107")]
		public int RemoteCount
		{
			[Token(Token = "0x6001265")]
			[Address(RVA = "0x3DCE430", Offset = "0x3DCA430", VA = "0x3DCE430")]
			get
			{
				return _remoteCount;
			}
		}

		[Token(Token = "0x17000108")]
		public int MachineCount
		{
			[Token(Token = "0x6001266")]
			[Address(RVA = "0x3DCE438", Offset = "0x3DCA438", VA = "0x3DCE438")]
			get
			{
				return _machineCount;
			}
		}

		[Token(Token = "0x17000109")]
		public int OrcsFetterLevel
		{
			[Token(Token = "0x6001267")]
			[Address(RVA = "0x3DCE440", Offset = "0x3DCA440", VA = "0x3DCE440")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010A")]
		public int UndeadFetterLevel
		{
			[Token(Token = "0x6001268")]
			[Address(RVA = "0x3DCE470", Offset = "0x3DCA470", VA = "0x3DCE470")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010B")]
		public int TerranFetterLevel
		{
			[Token(Token = "0x6001269")]
			[Address(RVA = "0x3DCE4A0", Offset = "0x3DCA4A0", VA = "0x3DCE4A0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010C")]
		public int MachineFetterLevel
		{
			[Token(Token = "0x600126A")]
			[Address(RVA = "0x3DCE4D0", Offset = "0x3DCA4D0", VA = "0x3DCE4D0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010D")]
		public int MeleeFetterLevel
		{
			[Token(Token = "0x600126B")]
			[Address(RVA = "0x3DCE500", Offset = "0x3DCA500", VA = "0x3DCE500")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010E")]
		public int RemoteFetterLevel
		{
			[Token(Token = "0x600126C")]
			[Address(RVA = "0x3DCE530", Offset = "0x3DCA530", VA = "0x3DCE530")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010F")]
		public bool EqipDefenseArrowTowerCard
		{
			[Token(Token = "0x600126D")]
			[Address(RVA = "0x3DCE560", Offset = "0x3DCA560", VA = "0x3DCE560")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000110")]
		public bool EqipDefenseCatapultsCard
		{
			[Token(Token = "0x600126E")]
			[Address(RVA = "0x3DCE66C", Offset = "0x3DCA66C", VA = "0x3DCE66C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000111")]
		public bool EqipDefenseCard
		{
			[Token(Token = "0x600126F")]
			[Address(RVA = "0x3DCE778", Offset = "0x3DCA778", VA = "0x3DCE778")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001270")]
		[Address(RVA = "0x3DCE7B0", Offset = "0x3DCA7B0", VA = "0x3DCE7B0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__50))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001271")]
		[Address(RVA = "0x3DCE834", Offset = "0x3DCA834", VA = "0x3DCE834")]
		public Dictionary<CardFettersType, int> GetFetterEnableConfig()
		{
			return null;
		}

		[Token(Token = "0x6001272")]
		[Address(RVA = "0x3DCE958", Offset = "0x3DCA958", VA = "0x3DCE958")]
		public Dictionary<AtkWayType, int> GetAtkWayTypeEnableConfig()
		{
			return null;
		}

		[Token(Token = "0x6001273")]
		[Address(RVA = "0x3DCEA2C", Offset = "0x3DCAA2C", VA = "0x3DCEA2C")]
		private void CardEquip(object o)
		{
		}

		[Token(Token = "0x6001274")]
		[Address(RVA = "0x3DCF1FC", Offset = "0x3DCB1FC", VA = "0x3DCF1FC")]
		public (GlobalArchitectureInfo, string) RandomRArchitectureLevelInfo(bool isMirror, HexType hexType, bool isInit)
		{
			return default;
		}

		[Token(Token = "0x6001275")]
		[Address(RVA = "0x3DCF918", Offset = "0x3DCB918", VA = "0x3DCF918")]
		public (GlobalArchitectureInfo, string) RandomSRArchitectureLevelInfo(bool isMirror, HexType hexType, bool isInit)
		{
			return default;
		}

		[Token(Token = "0x6001276")]
		[Address(RVA = "0x3DCFAEC", Offset = "0x3DCBAEC", VA = "0x3DCFAEC")]
		public (GlobalArchitectureInfo, string) RandomSSRArchitectureLevelInfo(bool isMirror, HexType hexType, bool isInit)
		{
			return default;
		}

		[Token(Token = "0x6001277")]
		[Address(RVA = "0x3DCFCC0", Offset = "0x3DCBCC0", VA = "0x3DCFCC0")]
		public (GlobalArchitectureInfo, string) RandomSSSRArchitectureLevelInfo(bool isMirror, HexType hexType, bool isInit)
		{
			return default;
		}

		[Token(Token = "0x6001278")]
		[Address(RVA = "0x3DCFE94", Offset = "0x3DCBE94", VA = "0x3DCFE94")]
		public (GlobalArchitectureInfo, string) RandomSSSRArchitectureLevelInfoByFetters(CardFettersType fettersType, bool isMirror, HexType hexType, bool isInit)
		{
			return default;
		}

		[Token(Token = "0x6001279")]
		[Address(RVA = "0x3DCF5B8", Offset = "0x3DCB5B8", VA = "0x3DCF5B8")]
		private string GetAICardDeckByHexType(HexType type, RareLevel rare, bool isInit)
		{
			return null;
		}

		[Token(Token = "0x600127A")]
		[Address(RVA = "0x3DD021C", Offset = "0x3DCC21C", VA = "0x3DD021C")]
		public (GlobalArchitectureInfo, string) RandomRArchitectureLevelInfoAndNoGoldMine()
		{
			return default;
		}

		[Token(Token = "0x600127B")]
		[Address(RVA = "0x3DD0474", Offset = "0x3DCC474", VA = "0x3DD0474")]
		public (GlobalArchitectureInfo, string) RandomSRArchitectureLevelInfoAndNoDef()
		{
			return default;
		}

		[Token(Token = "0x600127C")]
		[Address(RVA = "0x3DD06CC", Offset = "0x3DCC6CC", VA = "0x3DD06CC")]
		public (GlobalArchitectureInfo, string, string) RandomBarracksArchitectureInfo()
		{
			return default;
		}

		[Token(Token = "0x600127D")]
		[Address(RVA = "0x3DD0974", Offset = "0x3DCC974", VA = "0x3DD0974")]
		public (GlobalArchitectureInfo, string) GetGoldMineInfo()
		{
			return default;
		}

		[Token(Token = "0x600127E")]
		[Address(RVA = "0x3DD0AE4", Offset = "0x3DCCAE4", VA = "0x3DD0AE4")]
		public (GlobalArchitectureInfo, string) GetSkeletonInfo()
		{
			return default;
		}

		[Token(Token = "0x600127F")]
		[Address(RVA = "0x3DD0C54", Offset = "0x3DCCC54", VA = "0x3DD0C54")]
		public (GlobalArchitectureInfo, string) GetAxeWarriorsInfo()
		{
			return default;
		}

		[Token(Token = "0x6001280")]
		[Address(RVA = "0x3DD0DC4", Offset = "0x3DCCDC4", VA = "0x3DD0DC4")]
		public (GlobalArchitectureInfo, string) GetDragonKnightInfo()
		{
			return default;
		}

		[Token(Token = "0x6001281")]
		[Address(RVA = "0x3DD0F34", Offset = "0x3DCCF34", VA = "0x3DD0F34")]
		public (GlobalArchitectureInfo, string) GetArrowTowerInfo()
		{
			return default;
		}

		[Token(Token = "0x6001282")]
		[Address(RVA = "0x3DD10A4", Offset = "0x3DCD0A4", VA = "0x3DD10A4")]
		public (GlobalArchitectureInfo, string) GetCatapultsInfo()
		{
			return default;
		}

		[Token(Token = "0x6001283")]
		[Address(RVA = "0x3DD1214", Offset = "0x3DCD214", VA = "0x3DD1214")]
		public EquipCardInfoManager()
		{
		}
	}
}
