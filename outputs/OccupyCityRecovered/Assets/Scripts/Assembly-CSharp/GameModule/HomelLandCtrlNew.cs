using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BadgeGraph;
using Cinemachine;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using MainTowerModule;
using TimeModuleO;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20004DD")]
	public class HomelLandCtrlNew : ManagerBase<HomelLandCtrlNew>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004E4")]
		[CompilerGenerated]
		private struct _003CBuildAnim_003Ed__80 : IAsyncStateMachine
		{
			[Token(Token = "0x4002CCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002CCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002CD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityTileBehaviour tile;

			[Token(Token = "0x4002CD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60018D1")]
			[Address(RVA = "0x3E81D64", Offset = "0x3E7DD64", VA = "0x3E81D64", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60018D2")]
			[Address(RVA = "0x3E824CC", Offset = "0x3E7E4CC", VA = "0x3E824CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004E5")]
		[CompilerGenerated]
		private struct _003CCreateBattleEventGo_003Ed__99 : IAsyncStateMachine
		{
			[Token(Token = "0x4002CD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002CD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002CD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRecycle;

			[Token(Token = "0x4002CD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HomelLandCtrlNew _003C_003E4__this;

			[Token(Token = "0x4002CD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MainCityTileBehaviour tile;

			[Token(Token = "0x4002CD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60018D3")]
			[Address(RVA = "0x3E824D8", Offset = "0x3E7E4D8", VA = "0x3E824D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60018D4")]
			[Address(RVA = "0x3E82C48", Offset = "0x3E7EC48", VA = "0x3E82C48", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004E6")]
		[CompilerGenerated]
		private struct _003CGenerate_003Ed__55 : IAsyncStateMachine
		{
			[Token(Token = "0x4002CD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002CD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002CDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HomelLandCtrlNew _003C_003E4__this;

			[Token(Token = "0x4002CDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002CDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60018D5")]
			[Address(RVA = "0x3E82C54", Offset = "0x3E7EC54", VA = "0x3E82C54", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60018D6")]
			[Address(RVA = "0x3E83910", Offset = "0x3E7F910", VA = "0x3E83910", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004E7")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__43 : IAsyncStateMachine
		{
			[Token(Token = "0x4002CDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002CDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002CDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HomelLandCtrlNew _003C_003E4__this;

			[Token(Token = "0x4002CE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60018D7")]
			[Address(RVA = "0x3E8391C", Offset = "0x3E7F91C", VA = "0x3E8391C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60018D8")]
			[Address(RVA = "0x3E876B0", Offset = "0x3E836B0", VA = "0x3E876B0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004E8")]
		[CompilerGenerated]
		private struct _003CInitMap_003Ed__57 : IAsyncStateMachine
		{
			[Token(Token = "0x4002CE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002CE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002CE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HomelLandCtrlNew _003C_003E4__this;

			[Token(Token = "0x4002CE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x4002CE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60018D9")]
			[Address(RVA = "0x3E876BC", Offset = "0x3E836BC", VA = "0x3E876BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60018DA")]
			[Address(RVA = "0x3E87BB0", Offset = "0x3E83BB0", VA = "0x3E87BB0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004E9")]
		[CompilerGenerated]
		private struct _003COnBattleEnd_003Ed__83 : IAsyncStateMachine
		{
			[Token(Token = "0x4002CE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002CE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002CE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isVectory;

			[Token(Token = "0x4002CE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HomelLandCtrlNew _003C_003E4__this;

			[Token(Token = "0x4002CEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60018DB")]
			[Address(RVA = "0x3E87BBC", Offset = "0x3E83BBC", VA = "0x3E87BBC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60018DC")]
			[Address(RVA = "0x3E881C0", Offset = "0x3E841C0", VA = "0x3E881C0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002C91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<UserTileData> UserTileDatas;

		[Token(Token = "0x4002C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<string, UserTileData> UserTileDataDic;

		[Token(Token = "0x4002C93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float hexSize;

		[Token(Token = "0x4002C94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float diagonalDistance;

		[Token(Token = "0x4002C95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly Dictionary<string, MainCityTileBehaviour> HexBehaviours;

		[Token(Token = "0x4002C96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<Vector3> _willCreatHexPos;

		[Token(Token = "0x4002C97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<Vector3> _allPos;

		[Token(Token = "0x4002C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject hexPrefab;

		[Token(Token = "0x4002C99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject mainTowerHexPrefab;

		[Token(Token = "0x4002C9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject _mainCityCameraController;

		[Token(Token = "0x4002C9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CameraControllerMoveBehaviour _mainCityCameraControllerBehaviour;

		[Token(Token = "0x4002C9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private CinemachineBrain _mainCameraCinemachineBrain;

		[Token(Token = "0x4002C9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CameraMoveBehaviour _mainCameraMoveBehaviour;

		[Token(Token = "0x4002C9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 _defaultCameraPos;

		[Token(Token = "0x4002C9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GameObject decorationObj;

		[Token(Token = "0x4002CA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GameObject homelandObjRoot;

		[Token(Token = "0x4002CA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool upgradeMainTowerPanelIsShow;

		[Token(Token = "0x4002CA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool _isUpgradeMainTowerPanelDoAniIng;

		[Token(Token = "0x4002CA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		private bool _isTileEvent;

		[Token(Token = "0x4002CA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private MainCityTileBehaviour _curClickTile;

		[Token(Token = "0x4002CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<GlobalMainCityHouseInfo> _orcFamilyList;

		[Token(Token = "0x4002CA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<GlobalMainCityHouseInfo> _humanFamilyList;

		[Token(Token = "0x4002CA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool _isCreateHex;

		[Token(Token = "0x4002CA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public int maxPopulation;

		[Token(Token = "0x4002CA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int boostAddMins;

		[Token(Token = "0x4002CAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public int boostCdHour;

		[Token(Token = "0x4002CAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int linkUnLockTileNum;

		[Token(Token = "0x4002CAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool isPanelShow;

		[Token(Token = "0x4002CAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
		private bool showReturnWoodPanel;

		[Token(Token = "0x4002CAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public GameObject _recycleGo;

		[Token(Token = "0x4002CAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Sequence _recycleGoSq;

		[Token(Token = "0x4002CB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool _recycleIsClosing;

		[Token(Token = "0x4002CB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Dictionary<string, int> idleRewardDic;

		[Token(Token = "0x4002CB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public ThrottleTrigger redDotThrottleTrigger;

		[Token(Token = "0x4002CB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private TimeManager.Timer _rewardTimer;

		[Token(Token = "0x4002CB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool _isInit;

		[Token(Token = "0x4002CB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private int _unLockTileNumContainChian;

		[Token(Token = "0x4002CB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3? _savedCameraPosition;

		[Token(Token = "0x4002CB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float? _savedCameraSize;

		[Token(Token = "0x4002CB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 _mouseDownPos;

		[Token(Token = "0x4002CB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 _mouseUpPos;

		[Token(Token = "0x4002CBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private List<Vector3> allInitPos;

		[Token(Token = "0x4002CBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private List<Vector3> willCreatInitHexPos;

		[Token(Token = "0x4002CBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private List<Vector3> setSpecialHexPos;

		[Token(Token = "0x1700014E")]
		public MainCityTileBehaviour CurrentClickTile
		{
			[Token(Token = "0x600187B")]
			[Address(RVA = "0x3E7A088", Offset = "0x3E76088", VA = "0x3E7A088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014F")]
		public bool IsCreateHex
		{
			[Token(Token = "0x600187C")]
			[Address(RVA = "0x3E7A090", Offset = "0x3E76090", VA = "0x3E7A090")]
			get
			{
				return _isCreateHex;
			}
		}

		[Token(Token = "0x600187D")]
		[Address(RVA = "0x3E7A098", Offset = "0x3E76098", VA = "0x3E7A098", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__43))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x600187E")]
		[Address(RVA = "0x3E7A134", Offset = "0x3E76134", VA = "0x3E7A134")]
		public static bool ContainsAnyElementHashSet(List<string> firstList, List<string> secondList)
		{
			return default;
		}

		[Token(Token = "0x600187F")]
		[Address(RVA = "0x3E7A330", Offset = "0x3E76330", VA = "0x3E7A330")]
		public void UpdateSoloTileTalent(string tileKey, bool triggerEvent = true)
		{
		}

		[Token(Token = "0x6001880")]
		[Address(RVA = "0x3E7A6F0", Offset = "0x3E766F0", VA = "0x3E7A6F0")]
		public void UpdateMainCityTalent()
		{
		}

		[Token(Token = "0x6001881")]
		[Address(RVA = "0x3E7ADB8", Offset = "0x3E76DB8", VA = "0x3E7ADB8")]
		public static float CalculateMaxX(int hexCount)
		{
			return default;
		}

		[Token(Token = "0x6001882")]
		[Address(RVA = "0x3E7ADE8", Offset = "0x3E76DE8", VA = "0x3E7ADE8")]
		public void InitInfo()
		{
		}

		[Token(Token = "0x6001883")]
		[Address(RVA = "0x3E7B13C", Offset = "0x3E7713C", VA = "0x3E7B13C")]
		private void Update()
		{
		}

		[Token(Token = "0x6001884")]
		[Address(RVA = "0x3E7BFB8", Offset = "0x3E77FB8", VA = "0x3E7BFB8")]
		private void UpgradeMainTowerHexSetActive(object o)
		{
		}

		[Token(Token = "0x6001885")]
		[Address(RVA = "0x3E7C0E4", Offset = "0x3E780E4", VA = "0x3E7C0E4")]
		private void OnUpgradeMainTowerPanelChangeActive(object o)
		{
		}

		[Token(Token = "0x6001886")]
		[Address(RVA = "0x3E7C384", Offset = "0x3E78384", VA = "0x3E7C384")]
		private void OnMainCityResourceRewardPanelChangeActive(object o)
		{
		}

		[Token(Token = "0x6001887")]
		[Address(RVA = "0x3E7C598", Offset = "0x3E78598", VA = "0x3E7C598")]
		[AsyncStateMachine(typeof(_003CGenerate_003Ed__55))]
		public UniTask Generate()
		{
			return default;
		}

		[Token(Token = "0x6001888")]
		[Address(RVA = "0x3E7C634", Offset = "0x3E78634", VA = "0x3E7C634")]
		public void Clear()
		{
		}

		[Token(Token = "0x6001889")]
		[Address(RVA = "0x3E7C758", Offset = "0x3E78758", VA = "0x3E7C758")]
		[AsyncStateMachine(typeof(_003CInitMap_003Ed__57))]
		private UniTask InitMap()
		{
			return default;
		}

		[Token(Token = "0x600188A")]
		[Address(RVA = "0x3E7C7F4", Offset = "0x3E787F4", VA = "0x3E7C7F4")]
		public void CreatNearHex(string key, bool isChinUnLock = false)
		{
		}

		[Token(Token = "0x600188B")]
		[Address(RVA = "0x3E7CCA8", Offset = "0x3E78CA8", VA = "0x3E7CCA8")]
		public List<Vector3> GetNearHex(string key, bool isMountainOrLake = false)
		{
			return null;
		}

		[Token(Token = "0x600188C")]
		[Address(RVA = "0x3E7D724", Offset = "0x3E79724", VA = "0x3E7D724")]
		private bool CheckNearHexNeedCreate(Vector3 hexPosition, bool isMountainOrLake = false)
		{
			return default;
		}

		[Token(Token = "0x600188D")]
		[Address(RVA = "0x3E7DABC", Offset = "0x3E79ABC", VA = "0x3E7DABC")]
		public void GetInitNearHex(ref List<Vector3> hexDataKey, string key)
		{
		}

		[Token(Token = "0x600188E")]
		[Address(RVA = "0x3E7DFEC", Offset = "0x3E79FEC", VA = "0x3E7DFEC")]
		public void GetAllPos(List<UserTileData> userHexData)
		{
		}

		[Token(Token = "0x600188F")]
		[Address(RVA = "0x3E7E228", Offset = "0x3E7A228", VA = "0x3E7E228")]
		public List<Vector3> GetInitOutsiedeHex(int count)
		{
			return null;
		}

		[Token(Token = "0x6001890")]
		[Address(RVA = "0x3E7D198", Offset = "0x3E79198", VA = "0x3E7D198")]
		private string GetKeyToString(Vector3 ori)
		{
			return null;
		}

		[Token(Token = "0x6001891")]
		[Address(RVA = "0x3E7D8A4", Offset = "0x3E798A4", VA = "0x3E7D8A4")]
		private Vector3 GetKey(Vector3 ori)
		{
			return default;
		}

		[Token(Token = "0x6001892")]
		[Address(RVA = "0x3E7E66C", Offset = "0x3E7A66C", VA = "0x3E7E66C")]
		public Vector3 GetPosByKey(string keys)
		{
			return default;
		}

		[Token(Token = "0x6001893")]
		[Address(RVA = "0x3E7D4E8", Offset = "0x3E794E8", VA = "0x3E7D4E8")]
		private void GenerateHexs(Vector3 pos, UserTileData data, bool isInit)
		{
		}

		[Token(Token = "0x6001894")]
		[Address(RVA = "0x3E7EB30", Offset = "0x3E7AB30", VA = "0x3E7EB30")]
		private void SetHexNear(MainCityTileBehaviour hexBehaviour)
		{
		}

		[Token(Token = "0x6001895")]
		[Address(RVA = "0x3E7D5B8", Offset = "0x3E795B8", VA = "0x3E7D5B8")]
		private bool FindHexByPos(Vector3 hexPosition, out MainCityTileBehaviour hexOut)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HomelLandCtrlNew.FindHexByPos RVA=0x3E7D5B8 Token=0x6001895");
}

		[Token(Token = "0x6001896")]
		[Address(RVA = "0x3E7E730", Offset = "0x3E7A730", VA = "0x3E7E730")]
		private MainCityTileBehaviour CreatHex(Vector3 hexPosition, UserTileData data, bool isInit)
		{
			return null;
		}

		[Token(Token = "0x6001897")]
		[Address(RVA = "0x3E7E544", Offset = "0x3E7A544", VA = "0x3E7E544")]
		private void AddWillCreatInitHexPosToList(Vector3 pos)
		{
		}

		[Token(Token = "0x6001898")]
		[Address(RVA = "0x3E7EE44", Offset = "0x3E7AE44", VA = "0x3E7EE44")]
		private void AddWillCreatHexPosToList(Vector3 pos)
		{
		}

		[Token(Token = "0x6001899")]
		[Address(RVA = "0x3E7EF6C", Offset = "0x3E7AF6C", VA = "0x3E7EF6C")]
		private void UpgradeMainTowerPanelBeginDoAni(object o)
		{
		}

		[Token(Token = "0x600189A")]
		[Address(RVA = "0x3E7EF78", Offset = "0x3E7AF78", VA = "0x3E7EF78")]
		private void UpgradeMainTowerPanelDoAniEnd(object o)
		{
		}

		[Token(Token = "0x600189B")]
		[Address(RVA = "0x3E7EF80", Offset = "0x3E7AF80", VA = "0x3E7EF80")]
		public string GetModelPath(string modelId, bool isHigh = false)
		{
			return null;
		}

		[Token(Token = "0x600189C")]
		[Address(RVA = "0x3E7BB3C", Offset = "0x3E77B3C", VA = "0x3E7BB3C")]
		public void TileUnLock(MainCityTileBehaviour tile, bool isChinUnLock = false, bool isCheat = false)
		{
		}

		[Token(Token = "0x600189D")]
		[Address(RVA = "0x3E7F0B8", Offset = "0x3E7B0B8", VA = "0x3E7F0B8")]
		[AsyncStateMachine(typeof(_003CBuildAnim_003Ed__80))]
		public UniTask BuildAnim(MainCityTileBehaviour tile)
		{
			return default;
		}

		[Token(Token = "0x600189E")]
		[Address(RVA = "0x3E7F150", Offset = "0x3E7B150", VA = "0x3E7F150")]
		public void TileChooseBattle(object parms)
		{
		}

		[Token(Token = "0x600189F")]
		[Address(RVA = "0x3E7F308", Offset = "0x3E7B308", VA = "0x3E7F308")]
		public void OnBattleEndDataUpdate(bool isVectory)
		{
		}

		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x3E7F3CC", Offset = "0x3E7B3CC", VA = "0x3E7F3CC")]
		[AsyncStateMachine(typeof(_003COnBattleEnd_003Ed__83))]
		public void OnBattleEnd(bool isVectory)
		{
		}

		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x3E7F0B4", Offset = "0x3E7B0B4", VA = "0x3E7F0B4")]
		public void MountainOrLakeFirstUnLock()
		{
		}

		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x3E7F470", Offset = "0x3E7B470", VA = "0x3E7F470")]
		public void TileChooseRun(object parms)
		{
		}

		[Token(Token = "0x60018A3")]
		[Address(RVA = "0x3E7F4E8", Offset = "0x3E7B4E8", VA = "0x3E7F4E8")]
		public void CheckReturnWood()
		{
		}

		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x3E7F770", Offset = "0x3E7B770", VA = "0x3E7F770")]
		public void UpdateMainCityCameraPosition(Vector3 vector3)
		{
		}

		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x3E7F818", Offset = "0x3E7B818", VA = "0x3E7F818")]
		public void SaveMainCityCameraParams()
		{
		}

		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x3E7F904", Offset = "0x3E7B904", VA = "0x3E7F904")]
		public void RestoreMainCityCameraParams()
		{
		}

		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x3E7FA54", Offset = "0x3E7BA54", VA = "0x3E7FA54")]
		public void CheckIdleReward()
		{
		}

		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x3E7FFD0", Offset = "0x3E7BFD0", VA = "0x3E7FFD0")]
		public void GetIdleReward(bool isAd)
		{
		}

		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x3E7AB8C", Offset = "0x3E76B8C", VA = "0x3E7AB8C")]
		public void ChechIdleTimerEndTime()
		{
		}

		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x3E80480", Offset = "0x3E7C480", VA = "0x3E80480")]
		private void CheckRedDot()
		{
		}

		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x3E7D698", Offset = "0x3E79698", VA = "0x3E7D698")]
		private void CheckLinkTileSaveData()
		{
		}

		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x3E8068C", Offset = "0x3E7C68C", VA = "0x3E8068C")]
		public void TileEventEnd(object o)
		{
		}

		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x3E80694", Offset = "0x3E7C694", VA = "0x3E80694")]
		public void MainCityPanelHide(object o)
		{
		}

		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x3E8069C", Offset = "0x3E7C69C", VA = "0x3E8069C")]
		public void MainCityPanelShow(object o)
		{
		}

		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x3E7C3FC", Offset = "0x3E783FC", VA = "0x3E7C3FC")]
		public void UpdateCostUI()
		{
		}

		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x3E806B4", Offset = "0x3E7C6B4", VA = "0x3E806B4")]
		[AsyncStateMachine(typeof(_003CCreateBattleEventGo_003Ed__99))]
		public void CreateBattleEventGo(MainCityTileBehaviour tile, bool isRecycle)
		{
		}

		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x3E7B7EC", Offset = "0x3E777EC", VA = "0x3E7B7EC")]
		public void BattleEventAnim(bool isClose = false)
		{
		}

		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x3E80760", Offset = "0x3E7C760", VA = "0x3E80760")]
		public void MainCityLevelUp(object o)
		{
		}

		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x3E80848", Offset = "0x3E7C848", VA = "0x3E80848")]
		public void UpdateCurClickTile(MainCityTileBehaviour curClickTile)
		{
		}

		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x3E80850", Offset = "0x3E7C850", VA = "0x3E80850")]
		public HomelLandCtrlNew()
		{
		}
	}
}
