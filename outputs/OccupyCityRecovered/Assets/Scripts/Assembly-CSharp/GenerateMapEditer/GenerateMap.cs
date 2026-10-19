using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using TMPro;
using ToolModule;
using UnityEngine;
using UnityEngine.UI;

namespace GenerateMapEditer
{
	[Token(Token = "0x20001D2")]
	public class GenerateMap : ManagerBase<GenerateMap>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001D4")]
		[CompilerGenerated]
		private struct _003CCreatTile_003Ed__83 : IAsyncStateMachine
		{
			[Token(Token = "0x4001BD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001BDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<MapTileBehaviour> _003C_003Et__builder;

			[Token(Token = "0x4001BDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GenerateMap _003C_003E4__this;

			[Token(Token = "0x4001BDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 tilePosition;

			[Token(Token = "0x4001BDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000789")]
			[Address(RVA = "0x4087674", Offset = "0x4083674", VA = "0x4087674", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0x4088020", Offset = "0x4084020", VA = "0x4088020", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001D5")]
		[CompilerGenerated]
		private struct _003CCreateStart_003Ed__72 : IAsyncStateMachine
		{
			[Token(Token = "0x4001BDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001BDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001BE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GenerateMap _003C_003E4__this;

			[Token(Token = "0x4001BE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600078B")]
			[Address(RVA = "0x4088078", Offset = "0x4084078", VA = "0x4088078", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x40883A0", Offset = "0x40843A0", VA = "0x40883A0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001D6")]
		[CompilerGenerated]
		private struct _003CGenerateTiles_003Ed__78 : IAsyncStateMachine
		{
			[Token(Token = "0x4001BE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001BE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001BE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GenerateMap _003C_003E4__this;

			[Token(Token = "0x4001BE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pos;

			[Token(Token = "0x4001BE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<MapTileBehaviour>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x40883AC", Offset = "0x40843AC", VA = "0x40883AC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x408876C", Offset = "0x408476C", VA = "0x408876C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001D7")]
		[CompilerGenerated]
		private struct _003CGetAllPos_003Ed__74 : IAsyncStateMachine
		{
			[Token(Token = "0x4001BE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001BE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001BE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GenerateMap _003C_003E4__this;

			[Token(Token = "0x4001BEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x4088778", Offset = "0x4084778", VA = "0x4088778", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x4088E94", Offset = "0x4084E94", VA = "0x4088E94", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001D8")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__86 : IAsyncStateMachine
		{
			[Token(Token = "0x4001BEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001BEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x4088EA0", Offset = "0x4084EA0", VA = "0x4088EA0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x4088F54", Offset = "0x4084F54", VA = "0x4088F54", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001D9")]
		[CompilerGenerated]
		private struct _003CInitMap_003Ed__75 : IAsyncStateMachine
		{
			[Token(Token = "0x4001BED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001BEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001BEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GenerateMap _003C_003E4__this;

			[Token(Token = "0x4001BF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private List<Vector3>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x4001BF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x4088F60", Offset = "0x4084F60", VA = "0x4088F60", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x4089494", Offset = "0x4085494", VA = "0x4089494", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x4001B90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float tileSize;

		[Token(Token = "0x4001B91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float diagonalDistance;

		[Token(Token = "0x4001B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float mapMapSizeX;

		[Token(Token = "0x4001B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float mapMapSizeZ;

		[NonSerialized]
		[Token(Token = "0x4001B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string currentDraw;

		[NonSerialized]
		[Token(Token = "0x4001B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string currentDrawBuild;

		[Token(Token = "0x4001B96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Dictionary<string, MapTileBehaviour> tiles;

		[Token(Token = "0x4001B97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Dictionary<string, UserTileData> tilesData;

		[Token(Token = "0x4001B98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MapDataAsset mapDataAsset;

		[Token(Token = "0x4001B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI txtHexNum;

		[Token(Token = "0x4001B9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Vector3> willCreatTilePos;

		[Token(Token = "0x4001B9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<Vector3> allPos;

		[Token(Token = "0x4001B9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Material textMeshProOverlay;

		[Token(Token = "0x4001B9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string cityzenTypeCache;

		[Token(Token = "0x4001B9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string cityzenNumberCache;

		[Token(Token = "0x4001B9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string enemyTypeCache;

		[Token(Token = "0x4001BA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string enemyNumberCache;

		[Token(Token = "0x4001BA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<string> enemyCardsCache;

		[Token(Token = "0x4001BA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Text txtMountainNum;

		[Token(Token = "0x4001BA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Text txtLakeNum;

		[Token(Token = "0x4001BA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Text txtGrassNum;

		[Token(Token = "0x4001BA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Text txtEnemyNum;

		[Token(Token = "0x4001BA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Text txtCitizenNum;

		[Token(Token = "0x4001BA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Text txtForestNum;

		[Token(Token = "0x4001BA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Text txtGrassBuildNum;

		[Token(Token = "0x4001BA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Text txtAtkBuildNum;

		[Token(Token = "0x4001BAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Text txtHpBuildNum;

		[Token(Token = "0x4001BAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Text txtGoldBuildNum;

		[Token(Token = "0x4001BAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Text txtChurchNum;

		[Token(Token = "0x4001BAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Text txtTavernNum;

		[Token(Token = "0x4001BAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Text txtBarrackNum;

		[Token(Token = "0x4001BAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Text txtTrainingNum;

		[Token(Token = "0x4001BB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Text txtVegetableStoreNum;

		[Token(Token = "0x4001BB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Text txtAlchemyNum;

		[Token(Token = "0x4001BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Text txtMageTowerNum;

		[Token(Token = "0x4001BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public Text txtPotionsTowerNum;

		[Token(Token = "0x4001BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public Text txtFortNum;

		[Token(Token = "0x4001BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public Text txtKnightsNum;

		[Token(Token = "0x4001BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Text txtFoundryNum;

		[Token(Token = "0x4001BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public Text txtFarmNum;

		[Token(Token = "0x4001BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public Text txtExchangeNum;

		[Token(Token = "0x4001BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public Text txtFountainNum;

		[Token(Token = "0x4001BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public Text txtBazaarNum;

		[Token(Token = "0x4001BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public Text txtPastureNum;

		[Token(Token = "0x4001BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public int churchNum;

		[Token(Token = "0x4001BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public int tavernNum;

		[Token(Token = "0x4001BBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public int barrackNum;

		[Token(Token = "0x4001BBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public int trainingNum;

		[Token(Token = "0x4001BC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public int vegetableStoreNum;

		[Token(Token = "0x4001BC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public int alchemyNum;

		[Token(Token = "0x4001BC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public int mageTowerNum;

		[Token(Token = "0x4001BC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public int potionsTowerNum;

		[Token(Token = "0x4001BC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public int fortNum;

		[Token(Token = "0x4001BC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		public int knightsNum;

		[Token(Token = "0x4001BC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public int foundryNum;

		[Token(Token = "0x4001BC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		public int farmNum;

		[Token(Token = "0x4001BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public int exchangeNum;

		[Token(Token = "0x4001BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public int fountainNum;

		[Token(Token = "0x4001BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public int bazaarNum;

		[Token(Token = "0x4001BCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public int pastureNum;

		[Token(Token = "0x4001BCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public int mountainNum;

		[Token(Token = "0x4001BCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public int lakeNum;

		[Token(Token = "0x4001BCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public int grassNum;

		[Token(Token = "0x4001BCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public int enemyNum;

		[Token(Token = "0x4001BD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public int citizenNum;

		[Token(Token = "0x4001BD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public int forestNum;

		[Token(Token = "0x4001BD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public GameObject allData;

		[Token(Token = "0x4001BD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public int grassBuildNum;

		[Token(Token = "0x4001BD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public int AtkNum;

		[Token(Token = "0x4001BD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public int HpNum;

		[Token(Token = "0x4001BD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public int GoldNum;

		[Token(Token = "0x4001BD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public int hexNum;

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x40841D8", Offset = "0x40801D8", VA = "0x40841D8")]
		[AsyncStateMachine(typeof(_003CCreateStart_003Ed__72))]
		public void CreateStart()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x4084264", Offset = "0x4080264", VA = "0x4084264")]
		private void InitTileProgressData()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x4084650", Offset = "0x4080650", VA = "0x4084650")]
		[AsyncStateMachine(typeof(_003CGetAllPos_003Ed__74))]
		private UniTask GetAllPos()
		{
			return default;
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x40846DC", Offset = "0x40806DC", VA = "0x40846DC")]
		[AsyncStateMachine(typeof(_003CInitMap_003Ed__75))]
		private UniTask InitMap()
		{
			return default;
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x408476C", Offset = "0x408076C", VA = "0x408476C")]
		private string GetKeyToString(Vector3 ori)
		{
			return null;
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x4084A20", Offset = "0x4080A20", VA = "0x4084A20")]
		private Vector3 GetKey(Vector3 ori)
		{
			return default;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x4084C38", Offset = "0x4080C38", VA = "0x4084C38")]
		[AsyncStateMachine(typeof(_003CGenerateTiles_003Ed__78))]
		public UniTask GenerateTiles(Vector3 pos, bool unlock = false)
		{
			return default;
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x4084CEC", Offset = "0x4080CEC", VA = "0x4084CEC")]
		public void SetNear(MapTileBehaviour tileBehaviour)
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x40850E0", Offset = "0x40810E0", VA = "0x40850E0")]
		public void CheckChinUnLock()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x408613C", Offset = "0x408213C", VA = "0x408613C")]
		public void UpdateHexNum()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x4085000", Offset = "0x4081000", VA = "0x4085000")]
		private bool FindTile(Vector3 tilePosition, out MapTileBehaviour tileOut)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GenerateMap.FindTile RVA=0x4085000 Token=0x600077D");
}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x40865F8", Offset = "0x40825F8", VA = "0x40865F8")]
		[AsyncStateMachine(typeof(_003CCreatTile_003Ed__83))]
		private UniTask<MapTileBehaviour> CreatTile(Vector3 tilePosition, bool unlock = false)
		{
			return default;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x40866F4", Offset = "0x40826F4", VA = "0x40866F4")]
		private void AddWillCreatTilePos(Vector3 pos)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x408683C", Offset = "0x408283C", VA = "0x408683C")]
		[ContextMenu("把地图数据 输出到MapData,手动复制到飞书表格")]
		public void Save()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x4086DE4", Offset = "0x4082DE4", VA = "0x4086DE4", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__86))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x4086E64", Offset = "0x4082E64", VA = "0x4086E64")]
		public void ChangeDrawType(string drawType)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x4086E6C", Offset = "0x4082E6C", VA = "0x4086E6C")]
		public void ChangeDrawBuildType(string drawType)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x4086E74", Offset = "0x4082E74", VA = "0x4086E74")]
		public void ChangeIsHaveName()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x4087170", Offset = "0x4083170", VA = "0x4087170")]
		public void ShowTileLine()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x4087488", Offset = "0x4083488", VA = "0x4087488")]
		public GenerateMap()
		{
		}
	}
}
