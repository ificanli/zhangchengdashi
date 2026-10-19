using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000284")]
	public class GenerateHexBehaviour : MonoBehaviour
	{
		[Token(Token = "0x2000285")]
		private static class SeasonPVPConfig
		{
			[Token(Token = "0x4002009")]
			public const string PolygonMapId = "PolygonArena_0808";

			[Token(Token = "0x400200A")]
			public const string DecorationPath_A = "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SceneDecoration/SeasonPVP/SeasonDecoration_1.prefab";

			[Token(Token = "0x400200B")]
			public const string DecorationPath_B = "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SceneDecoration/SeasonPVP/SeasonDecoration_B.prefab";

			[Token(Token = "0x400200C")]
			public const int BTest_MapSizeX = 16;

			[Token(Token = "0x400200D")]
			public const int BTest_MapSizeZ = 28;

			[Token(Token = "0x400200E")]
			public const float BTest_CameraLimitLeft = 25f;

			[Token(Token = "0x400200F")]
			public const float BTest_CameraLimitRight = -25f;

			[Token(Token = "0x4002010")]
			public const float BTest_CameraLimitDown = 25f;

			[Token(Token = "0x4002011")]
			public const float BTest_CameraLimitUp = -40f;

			[Token(Token = "0x4002012")]
			public const int BTest_CameraAnimNum1 = 65;

			[Token(Token = "0x4002013")]
			public const int BTest_CameraAnimNum2 = 51;

			[Token(Token = "0x4002014")]
			public const string BTest_PlayerMainTowerKey = "0_0_-12";

			[Token(Token = "0x4002015")]
			public const string BTest_EnemyMainTowerKey = "0_0_12";

			[Token(Token = "0x4002016")]
			public const float BTest_GroundScaleX = 3.25f;

			[Token(Token = "0x4002017")]
			public const float BTest_GroundScaleZ = 5.5f;
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000287")]
		[CompilerGenerated]
		private struct _003CGenerate_003Ed__43 : IAsyncStateMachine
		{
			[Token(Token = "0x400201C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400201D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400201E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GenerateHexBehaviour _003C_003E4__this;

			[Token(Token = "0x400201F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameType gameType;

			[Token(Token = "0x4002020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GlobalPolygonArenaInfo _003CpolygonInfo_003E5__2;

			[Token(Token = "0x4002021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private string[] _003CdecorationInfo_003E5__3;

			[Token(Token = "0x4002022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int _003Cindex_003E5__4;

			[Token(Token = "0x6000B35")]
			[Address(RVA = "0x4416AC4", Offset = "0x4412AC4", VA = "0x4416AC4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000B36")]
			[Address(RVA = "0x44192EC", Offset = "0x44152EC", VA = "0x44192EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000288")]
		[CompilerGenerated]
		private struct _003CInitMap_003Ed__47 : IAsyncStateMachine
		{
			[Token(Token = "0x4002024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GenerateHexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameType gameType;

			[Token(Token = "0x4002028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string _003Cid_003E5__2;

			[Token(Token = "0x4002029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GlobalArenaInfo _003CarenaInfo_003E5__3;

			[Token(Token = "0x400202A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<Vector3> _003CplayerMainTowerNearHexPos_003E5__4;

			[Token(Token = "0x400202B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<Vector3> _003CenemyMainTowerNearHexPos_003E5__5;

			[Token(Token = "0x400202C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int[] _003CplayerRandomNum_003E5__6;

			[Token(Token = "0x400202D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int[] _003CenemyRandomNum_003E5__7;

			[Token(Token = "0x400202E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private float _003ConFrameCreatCount_003E5__8;

			[Token(Token = "0x400202F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private GameObject _003CgroundObj_003E5__9;

			[Token(Token = "0x4002030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private int _003CcurIndex_003E5__10;

			[Token(Token = "0x4002032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private int _003Ccount_003E5__11;

			[Token(Token = "0x4002033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private bool _003ChasSoldier_003E5__12;

			[Token(Token = "0x4002034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x4002035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool _003CisFromPlayer_003E5__13;

			[Token(Token = "0x4002036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
			private bool _003ChasSoldier_003E5__14;

			[Token(Token = "0x4002037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__3;

			[Token(Token = "0x4002038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private UniTask<Material>.Awaiter _003C_003Eu__4;

			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x44192F8", Offset = "0x44152F8", VA = "0x44192F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000B38")]
			[Address(RVA = "0x441CAC0", Offset = "0x4418AC0", VA = "0x441CAC0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000289")]
		[CompilerGenerated]
		private struct _003CLoadBTestHexPrefabs_003Ed__60 : IAsyncStateMachine
		{
			[Token(Token = "0x4002039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400203A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400203B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GenerateHexBehaviour _003C_003E4__this;

			[Token(Token = "0x400203C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x441CACC", Offset = "0x4418ACC", VA = "0x441CACC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x441D428", Offset = "0x4419428", VA = "0x441D428", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200028A")]
		[CompilerGenerated]
		private struct _003CLoadDecoration_003Ed__38 : IAsyncStateMachine
		{
			[Token(Token = "0x400203D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400203E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400203F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MapGenerateConfig config;

			[Token(Token = "0x4002040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GenerateHexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string[] arenaDecorationInfo;

			[Token(Token = "0x4002042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string polygonDecorationPath;

			[Token(Token = "0x4002043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int mapTypeIndex;

			[Token(Token = "0x4002044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x441D434", Offset = "0x4419434", VA = "0x441D434", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x441DD6C", Offset = "0x4419D6C", VA = "0x441DD6C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200028B")]
		[CompilerGenerated]
		private struct _003CLoadGround_003Ed__52 : IAsyncStateMachine
		{
			[Token(Token = "0x4002045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GenerateHexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameType gameType;

			[Token(Token = "0x4002049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0x441DD78", Offset = "0x4419D78", VA = "0x441DD78", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0x441F68C", Offset = "0x441B68C", VA = "0x441F68C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200028C")]
		[CompilerGenerated]
		private struct _003CLoadHexPrefabs_003Ed__36 : IAsyncStateMachine
		{
			[Token(Token = "0x400204A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400204B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400204C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MapGenerateConfig config;

			[Token(Token = "0x400204D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GenerateHexBehaviour _003C_003E4__this;

			[Token(Token = "0x400204E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string[] _003ChexPrefabPath_003E5__2;

			[Token(Token = "0x400204F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0x441F698", Offset = "0x441B698", VA = "0x441F698", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x4420114", Offset = "0x441C114", VA = "0x4420114", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200028D")]
		[CompilerGenerated]
		private struct _003CLoadSeasonBTestHexPrefabs_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x4002051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GenerateHexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x4420120", Offset = "0x441C120", VA = "0x4420120", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x4420A7C", Offset = "0x441CA7C", VA = "0x4420A7C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001FE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hexSize;

		[Token(Token = "0x4001FE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float diagonalDistance;

		[Token(Token = "0x4001FE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float mapMapSizeX;

		[Token(Token = "0x4001FE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float mapMapSizeZ;

		[Token(Token = "0x4001FEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly Dictionary<string, HexBehaviour> HexBehaviours;

		[Token(Token = "0x4001FEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<Vector3> _willCreatHexPos;

		[Token(Token = "0x4001FEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Vector3> _allPos;

		[Token(Token = "0x4001FED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject hexPrefab;

		[Token(Token = "0x4001FEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject hexEnemyPrefab;

		[Token(Token = "0x4001FEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject bTestHexPlayerInside;

		[Token(Token = "0x4001FF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject bTestHexPlayerOutside;

		[Token(Token = "0x4001FF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject bTestHexEnemyInside;

		[Token(Token = "0x4001FF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject bTestHexEnemyOutside;

		[Token(Token = "0x4001FF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject seasonBTestHexPlayerInside;

		[Token(Token = "0x4001FF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GameObject seasonBTestHexPlayerOutside;

		[Token(Token = "0x4001FF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GameObject seasonBTestHexEnemyInside;

		[Token(Token = "0x4001FF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GameObject seasonBTestHexEnemyOutside;

		[Token(Token = "0x4001FF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<Vector3> allBornPos;

		[Token(Token = "0x4001FF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly List<Vector3> _bridgeMapCullPos;

		[Token(Token = "0x4001FF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly List<Vector3> _bridgeMapBridgePos;

		[Token(Token = "0x4001FFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly List<Vector3> _polygonMapCullPos;

		[Token(Token = "0x4001FFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private MapType _mapType;

		[Token(Token = "0x4001FFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GameObject res;

		[Token(Token = "0x4001FFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool loadGroundResEnd;

		[Token(Token = "0x4001FFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material defaultMaterial;

		[Token(Token = "0x4001FFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material _seasonBTestSkyboxMaterial;

		[Token(Token = "0x4002000")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string polygonMapId;

		[Token(Token = "0x4002001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private MapGenerateConfig _currentConfig;

		[Token(Token = "0x4002002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<Vector3> _specialPlayerPos;

		[Token(Token = "0x4002003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<Vector3> _specialEnemyPos;

		[Token(Token = "0x4002004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private GameObject decorationObj;

		[Token(Token = "0x4002005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool isResourcesGame;

		[Token(Token = "0x4002006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private GameObject snowEffect;

		[Token(Token = "0x4002007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<Vector3> setSpecialHexPos;

		[Token(Token = "0x4002008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float excludingSize;

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x4411A0C", Offset = "0x440DA0C", VA = "0x4411A0C")]
		private void Awake()
		{
			EventModule.EventManager.Instance.StartListening("HasHexDestroy", HasHexDestroy);
			    EventModule.EventManager.Instance.StartListening("OnGameOver", GameEnd);
			    defaultMaterial = RenderSettings.skybox;
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x4411B58", Offset = "0x440DB58", VA = "0x4411B58")]
		private void HasHexDestroy(object o)
		{
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x4411B5C", Offset = "0x440DB5C", VA = "0x4411B5C")]
		private bool ShouldUseArena5Config()
		{
			return default;
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x4411D04", Offset = "0x440DD04", VA = "0x4411D04")]
		private MapGenerateConfig GetMapGenerateConfig(GameType gameType)
		{
			return null;
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x4411F4C", Offset = "0x440DF4C", VA = "0x4411F4C")]
		private string[] GetHexPrefabPaths(MapGenerateConfig config)
		{
			return DataManager.Instance.GlobalInfo.arenaInfoDic[config.ArenaIdForAssets].arenaHexPrefabPath.Split(';');
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x4411FE8", Offset = "0x440DFE8", VA = "0x4411FE8")]
		private string[] GetGroundPrefabPaths(MapGenerateConfig config)
		{
			return DataManager.Instance.GlobalInfo.arenaInfoDic[config.ArenaIdForAssets].arenaGroundPrefabPath.Split(';');
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x4412084", Offset = "0x440E084", VA = "0x4412084")]
		[AsyncStateMachine(typeof(_003CLoadHexPrefabs_003Ed__36))]
		private async UniTask LoadHexPrefabs(MapGenerateConfig config)
		{
			if (config.IsSeasonPVP_BTest)
			    {
			        await LoadSeasonBTestHexPrefabs();
			    }
			    else if (SDKModule.ABTestManager.Instance.WeeklyClashImprove02IsBTest)
			    {
			        await LoadBTestHexPrefabs();
			    }
			    else
			    {
			        string[] hexPrefabPath = GetHexPrefabPaths(config);
			        hexPrefab = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(hexPrefabPath[0]);
			        hexEnemyPrefab = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(hexPrefabPath[1]);
			    }
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x4412124", Offset = "0x440E124", VA = "0x4412124")]
		[AsyncStateMachine(typeof(_003CLoadSeasonBTestHexPrefabs_003Ed__37))]
		private async UniTask LoadSeasonBTestHexPrefabs()
		{
			seasonBTestHexPlayerInside = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Hex/SeasonBTest_PlayerHex_InSide.prefab");
			    seasonBTestHexPlayerOutside = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Hex/SeasonBTest_PlayerHex_OutSide.prefab");
			    seasonBTestHexEnemyInside = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Hex/SeasonBTest_EnemyHex_InSide.prefab");
			    seasonBTestHexEnemyOutside = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Hex/SeasonBTest_EnemyHex_OutSide.prefab");
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x44121B4", Offset = "0x440E1B4", VA = "0x44121B4")]
		[AsyncStateMachine(typeof(_003CLoadDecoration_003Ed__38))]
		private UniTask LoadDecoration(MapGenerateConfig config, string[] arenaDecorationInfo, int mapTypeIndex, string polygonDecorationPath)
		{
			return default;
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x4412270", Offset = "0x440E270", VA = "0x4412270")]
		private void OnDestroy()
		{
			EventModule.EventManager.Instance.StopListening("HasHexDestroy", HasHexDestroy);
			    EventModule.EventManager.Instance.StopListening("OnGameOver", GameEnd);
			    ReleaseReferences();
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x4412478", Offset = "0x440E478", VA = "0x4412478")]
		private string GetArenaIdForAssets(GameType gameType)
		{
			return null;
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x441258C", Offset = "0x440E58C", VA = "0x441258C")]
		[AsyncStateMachine(typeof(_003CGenerate_003Ed__43))]
		[ContextMenu("Generate")]
		public void Generate(GameType gameType)
		{
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x441262C", Offset = "0x440E62C", VA = "0x441262C")]
		[ContextMenu("Clear")]
		public void Clear()
		{
			while (transform.childCount > 0) UnityEngine.Object.DestroyImmediate(transform.GetChild(0).gameObject);
			ReleaseReferences();
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x44123B4", Offset = "0x440E3B4", VA = "0x44123B4")]
		public void ReleaseReferences()
		{
			_willCreatHexPos.Clear();
			HexBehaviours.Clear();
			_allPos.Clear();
			allBornPos.Clear();
			HexManager.Clear();
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x44126F0", Offset = "0x440E6F0", VA = "0x44126F0")]
		[AsyncStateMachine(typeof(_003CInitMap_003Ed__47))]
		private UniTask InitMap(GameType gameType)
		{
			return default;
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x4412790", Offset = "0x440E790", VA = "0x4412790")]
		private void GameEnd(object o)
		{
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x44129AC", Offset = "0x440E9AC", VA = "0x44129AC")]
		private int[] GetFourRandomMainTowerNearHexPos()
		{
			return null;
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x4412B18", Offset = "0x440EB18", VA = "0x4412B18")]
		private void Shuffle(List<int> list)
		{
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x4412C0C", Offset = "0x440EC0C", VA = "0x4412C0C")]
		[AsyncStateMachine(typeof(_003CLoadGround_003Ed__52))]
		public UniTask LoadGround(GameType gameType)
		{
			return default;
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x4412CA8", Offset = "0x440ECA8", VA = "0x4412CA8")]
		private void GetAllPos()
		{
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x4413DC4", Offset = "0x440FDC4", VA = "0x4413DC4")]
		private string GetKeyToString(Vector3 ori)
		{
			Vector3 key = GetKey(ori);
			return key.x.ToString(System.Globalization.CultureInfo.InvariantCulture) + "_" +
			    key.y.ToString(System.Globalization.CultureInfo.InvariantCulture) + "_" +
			    key.z.ToString(System.Globalization.CultureInfo.InvariantCulture);
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x4413984", Offset = "0x440F984", VA = "0x4413984")]
		private Vector3 GetKey(Vector3 ori)
		{
			return new Vector3(Normalize(ori.x), Normalize(ori.y), Normalize(ori.z));
			float Normalize(float value)
			{
			    if (Mathf.Abs(value) < 0.000001f) return 0f;
			    float scaled = value * 100f;
			    double integer = System.Math.Truncate((double)scaled);
			    double fraction = (double)scaled - integer;
			    float rounded;
			    if (fraction == 0.5 || fraction == -0.5)
			    {
			        rounded = (float)integer;
			        if (((long)integer & 1) != 0) rounded += scaled >= 0f ? 1f : -1f;
			    }
			    else rounded = scaled >= 0f ? (float)System.Math.Floor((float)(scaled + 0.5f)) : (float)System.Math.Ceiling((float)(scaled - 0.5f));
			    return rounded / 100f;
			}
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x4414114", Offset = "0x4410114", VA = "0x4414114")]
		private void GenerateHexs(Vector3 pos, bool setGoldMine = false, bool isNoGoldCard = false, bool setOneStar = false, bool setUnchart = false, bool setDefense = false, bool setSoldier = false)
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x441504C", Offset = "0x441104C", VA = "0x441504C")]
		private void SetHexNear(HexBehaviour hexBehaviour)
		{
			HexBehaviour neighbor;
			if (!hexBehaviour.leftUpHexBehaviour && FindHexByPos(hexBehaviour.transform.position + new Vector3(-diagonalDistance, 0f, hexSize), out neighbor))
			{ neighbor.rightDownHexBehaviour = hexBehaviour; hexBehaviour.leftUpHexBehaviour = neighbor; }
			if (!hexBehaviour.upHexBehaviour && FindHexByPos(hexBehaviour.transform.position + new Vector3(0f, 0f, hexSize + hexSize), out neighbor))
			{ neighbor.downHexBehaviour = hexBehaviour; hexBehaviour.upHexBehaviour = neighbor; }
			if (!hexBehaviour.rightUpHexBehaviour && FindHexByPos(hexBehaviour.transform.position + new Vector3(diagonalDistance, 0f, hexSize), out neighbor))
			{ neighbor.leftDownHexBehaviour = hexBehaviour; hexBehaviour.rightUpHexBehaviour = neighbor; }
			if (!hexBehaviour.rightDownHexBehaviour && FindHexByPos(hexBehaviour.transform.position + new Vector3(diagonalDistance, 0f, -hexSize), out neighbor))
			{ neighbor.leftUpHexBehaviour = hexBehaviour; hexBehaviour.rightDownHexBehaviour = neighbor; }
			if (!hexBehaviour.downHexBehaviour && FindHexByPos(hexBehaviour.transform.position + new Vector3(0f, 0f, -(hexSize + hexSize)), out neighbor))
			{ neighbor.upHexBehaviour = hexBehaviour; hexBehaviour.downHexBehaviour = neighbor; }
			if (!hexBehaviour.leftDownHexBehaviour && FindHexByPos(hexBehaviour.transform.position + new Vector3(-diagonalDistance, 0f, -hexSize), out neighbor))
			{ neighbor.rightUpHexBehaviour = hexBehaviour; hexBehaviour.leftDownHexBehaviour = neighbor; }
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x4415360", Offset = "0x4411360", VA = "0x4415360")]
		private bool FindHexByPos(Vector3 hexPosition, out HexBehaviour hexOut)
		{
			return HexBehaviours.TryGetValue(GetKeyToString(hexPosition), out hexOut) && hexOut != null;
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x4415440", Offset = "0x4411440", VA = "0x4415440")]
		[AsyncStateMachine(typeof(_003CLoadBTestHexPrefabs_003Ed__60))]
		private async UniTask LoadBTestHexPrefabs()
		{
			bTestHexPlayerInside = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Hex/BTestHex_Player_InSide.prefab");
			    bTestHexPlayerOutside = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Hex/BTestHex_Player_OutSide.prefab");
			    bTestHexEnemyInside = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Hex/BTestHex_Enemy_InSide.prefab");
			    bTestHexEnemyOutside = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Hex/BTestHex_Enemy_OutSide.prefab");
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x44154D0", Offset = "0x44114D0", VA = "0x44154D0")]
		private GameObject GetBTestHexPrefab(bool isEnemy, float zCoord)
		{
			bool inside = IsInsideRing(zCoord);
			return isEnemy ? (inside ? bTestHexEnemyInside : bTestHexEnemyOutside) : (inside ? bTestHexPlayerInside : bTestHexPlayerOutside);
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x4415630", Offset = "0x4411630", VA = "0x4415630")]
		private GameObject GetSeasonBTestHexPrefab(bool isEnemy, float zCoord)
		{
			bool inside = IsInsideRing(zCoord);
			return isEnemy ? (inside ? seasonBTestHexEnemyInside : seasonBTestHexEnemyOutside) : (inside ? seasonBTestHexPlayerInside : seasonBTestHexPlayerOutside);
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x441551C", Offset = "0x441151C", VA = "0x441551C")]
		private bool IsInsideRing(float zCoord)
		{
			int row = Mathf.RoundToInt(zCoord);
			int remainder = unchecked(4 - row) % 3;
			if (remainder < 0) remainder += 3;
			return remainder == 2;
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x44142CC", Offset = "0x44102CC", VA = "0x44142CC")]
		private HexBehaviour CreatHex(Vector3 hexPosition, bool setGoldMine = false, bool isNoGoldCard = false, bool setOneStar = false, bool setUnchart = false, bool setDefense = false, bool setSoldier = false)
		{
			return null;
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x4415988", Offset = "0x4411988", VA = "0x4415988")]
		private HexBehaviour CreatHexFixed(Vector3 hexPosition, TrainingHexConfig config)
		{
			return null;
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x4413B9C", Offset = "0x440FB9C", VA = "0x4413B9C")]
		private void AddWillCreatHexPosToList(Vector3 pos)
		{
			if (_allPos.Contains(pos)) return;
			if (_willCreatHexPos.Contains(pos) || Mathf.Abs(pos.x) > mapMapSizeX || Mathf.Abs(pos.z) > mapMapSizeZ) return;
			if (_mapType == MapType.RectangleMap || _mapType == MapType.BridgeMap || _mapType == MapType.PolygonMap)
			{
			    if (pos.z == excludingSize) return;
			}
			else if (_mapType == MapType.CircleMap)
			{
			    if (Vector3.Distance(transform.position, pos) >= excludingSize + diagonalDistance * 0.5f) return;
			}
			_willCreatHexPos.Add(pos);
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x4415DC8", Offset = "0x4411DC8", VA = "0x4415DC8")]
		public GenerateHexBehaviour()
		{
			hexSize = 1f;
			mapMapSizeX = 10f;
			mapMapSizeZ = 18f;
			HexBehaviours = new Dictionary<string, HexBehaviour>();
			_willCreatHexPos = new List<Vector3>();
			_allPos = new List<Vector3>();
			allBornPos = new List<Vector3>();
			_bridgeMapCullPos = new List<Vector3>();
			_bridgeMapBridgePos = new List<Vector3>
			{
			    new Vector3(-3.46f,0.0f,2.0f),
			    new Vector3(-3.46f,0.0f,0.0f),
			    new Vector3(-3.46f,0.0f,-2.0f),
			    new Vector3(-5.19f,0.0f,3.0f),
			    new Vector3(-3.46f,0.0f,4.0f),
			    new Vector3(-5.19f,0.0f,1.0f),
			    new Vector3(-5.19f,0.0f,-1.0f),
			    new Vector3(-5.19f,0.0f,-3.0f),
			    new Vector3(-6.92f,0.0f,4.0f),
			    new Vector3(-6.92f,0.0f,2.0f),
			    new Vector3(-6.92f,0.0f,0.0f),
			    new Vector3(-6.92f,0.0f,-2.0f),
			    new Vector3(3.46f,0.0f,4.0f),
			    new Vector3(3.46f,0.0f,2.0f),
			    new Vector3(3.46f,0.0f,0.0f),
			    new Vector3(3.46f,0.0f,-2.0f),
			    new Vector3(5.19f,0.0f,3.0f),
			    new Vector3(5.19f,0.0f,1.0f),
			    new Vector3(5.19f,0.0f,-1.0f),
			    new Vector3(5.19f,0.0f,-3.0f),
			    new Vector3(6.92f,0.0f,4.0f),
			    new Vector3(6.92f,0.0f,2.0f),
			    new Vector3(6.92f,0.0f,0.0f),
			    new Vector3(6.92f,0.0f,-2.0f)
			};
			_polygonMapCullPos = new List<Vector3>();
			_specialPlayerPos = new List<Vector3>();
			_specialEnemyPos = new List<Vector3>();
		}
	}
}
