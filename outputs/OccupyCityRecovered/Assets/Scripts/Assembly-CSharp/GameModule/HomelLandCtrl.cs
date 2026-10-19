using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BadgeGraph;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20004C9")]
	public class HomelLandCtrl : ManagerBase<HomelLandCtrl>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004CA")]
		[CompilerGenerated]
		private struct _003CCreatCitizen_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x4002C1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002C1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002C20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isOpenHexCreat;

			[Token(Token = "0x4002C21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 creatPos;

			[Token(Token = "0x4002C22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public HomelLandCtrl _003C_003E4__this;

			[Token(Token = "0x4002C23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 _003CbornPos_003E5__2;

			[Token(Token = "0x4002C24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private List<OutsiderHexBehaviour> _003CuserDataList_003E5__3;

			[Token(Token = "0x4002C25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002C26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int _003Ci_003E5__4;

			[Token(Token = "0x600180E")]
			[Address(RVA = "0x3E6D4BC", Offset = "0x3E694BC", VA = "0x3E6D4BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600180F")]
			[Address(RVA = "0x3E6E224", Offset = "0x3E6A224", VA = "0x3E6E224", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004CB")]
		[CompilerGenerated]
		private struct _003CGenerate_003Ed__31 : IAsyncStateMachine
		{
			[Token(Token = "0x4002C27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002C28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002C29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HomelLandCtrl _003C_003E4__this;

			[Token(Token = "0x6001810")]
			[Address(RVA = "0x3E6E230", Offset = "0x3E6A230", VA = "0x3E6E230", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001811")]
			[Address(RVA = "0x3E6E458", Offset = "0x3E6A458", VA = "0x3E6E458", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004CC")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4002C2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002C2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002C2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HomelLandCtrl _003C_003E4__this;

			[Token(Token = "0x4002C2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001812")]
			[Address(RVA = "0x3E6E464", Offset = "0x3E6A464", VA = "0x3E6E464", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001813")]
			[Address(RVA = "0x3E716EC", Offset = "0x3E6D6EC", VA = "0x3E716EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004CD")]
		[CompilerGenerated]
		private struct _003CInitInfoAndCreatMap_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x4002C2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002C2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002C30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HomelLandCtrl _003C_003E4__this;

			[Token(Token = "0x4002C31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002C32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6001814")]
			[Address(RVA = "0x3E716F8", Offset = "0x3E6D6F8", VA = "0x3E716F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001815")]
			[Address(RVA = "0x3E71DDC", Offset = "0x3E6DDDC", VA = "0x3E71DDC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004CE")]
		[CompilerGenerated]
		private struct _003CInitMap_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x4002C33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002C34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002C35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HomelLandCtrl _003C_003E4__this;

			[Token(Token = "0x6001816")]
			[Address(RVA = "0x3E71DE8", Offset = "0x3E6DDE8", VA = "0x3E71DE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001817")]
			[Address(RVA = "0x3E71FA4", Offset = "0x3E6DFA4", VA = "0x3E71FA4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<UserOutsiderHexData> UserOutsiderHexDatas;

		[Token(Token = "0x4002C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<string, UserOutsiderHexData> UserOutsiderHexDataDic;

		[Token(Token = "0x4002C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float hexSize;

		[Token(Token = "0x4002C09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float diagonalDistance;

		[Token(Token = "0x4002C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly Dictionary<string, OutsiderHexBehaviour> HexBehaviours;

		[Token(Token = "0x4002C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<Vector3> _willCreatHexPos;

		[Token(Token = "0x4002C0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<Vector3> _allPos;

		[Token(Token = "0x4002C0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject hexPrefab;

		[Token(Token = "0x4002C0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject mainTowerHexPrefab;

		[Token(Token = "0x4002C0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<Vector3> allBornPos;

		[Token(Token = "0x4002C10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject decorationObj;

		[Token(Token = "0x4002C11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject homelandObjRoot;

		[Token(Token = "0x4002C12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject hexParent;

		[Token(Token = "0x4002C13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GameObject citizenParent;

		[Token(Token = "0x4002C14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool upgradeMainTowerPanelIsShow;

		[Token(Token = "0x4002C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool _isUpgradeMainTowerPanelDoAniIng;

		[Token(Token = "0x4002C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly string[] citizenPath;

		[Token(Token = "0x4002C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<CitizenBehaviour> allOutSiderRole;

		[Token(Token = "0x4002C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public ThrottleTrigger redDotThrottleTrigger;

		[Token(Token = "0x4002C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 _mouseDownPos;

		[Token(Token = "0x4002C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Vector3 _mouseUpPos;

		[Token(Token = "0x4002C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<Vector3> allInitPos;

		[Token(Token = "0x4002C1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<Vector3> willCreatInitHexPos;

		[Token(Token = "0x4002C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<Vector3> setSpecialHexPos;

		[Token(Token = "0x60017EF")]
		[Address(RVA = "0x3E686CC", Offset = "0x3E646CC", VA = "0x3E686CC", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__19))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60017F0")]
		[Address(RVA = "0x3E6875C", Offset = "0x3E6475C", VA = "0x3E6875C")]
		private void CheckRedDot()
		{
		}

		[Token(Token = "0x60017F1")]
		[Address(RVA = "0x3E68B8C", Offset = "0x3E64B8C", VA = "0x3E68B8C")]
		public int[] DivideIntoThreeParts(int number)
		{
			return null;
		}

		[Token(Token = "0x60017F2")]
		[Address(RVA = "0x3E68CA4", Offset = "0x3E64CA4", VA = "0x3E68CA4")]
		public static float CalculateMaxX(int hexCount)
		{
			return default;
		}

		[Token(Token = "0x60017F3")]
		[Address(RVA = "0x3E68CD4", Offset = "0x3E64CD4", VA = "0x3E68CD4")]
		[AsyncStateMachine(typeof(_003CInitInfoAndCreatMap_003Ed__23))]
		public void InitInfoAndCreatMap()
		{
		}

		[Token(Token = "0x60017F4")]
		[Address(RVA = "0x3E68D64", Offset = "0x3E64D64", VA = "0x3E68D64")]
		private void Update()
		{
		}

		[Token(Token = "0x60017F5")]
		[Address(RVA = "0x3E6968C", Offset = "0x3E6568C", VA = "0x3E6968C")]
		public Transform GetPathFindingTarget()
		{
			return null;
		}

		[Token(Token = "0x60017F6")]
		[Address(RVA = "0x3E69908", Offset = "0x3E65908", VA = "0x3E69908")]
		[AsyncStateMachine(typeof(_003CCreatCitizen_003Ed__28))]
		public void CreatCitizen([Optional][DefaultParameterValue(false)] bool isOpenHexCreat, [Optional] Vector3 creatPos)
		{
		}

		[Token(Token = "0x60017F7")]
		[Address(RVA = "0x3E699D8", Offset = "0x3E659D8", VA = "0x3E699D8")]
		private void UpgradeMainTowerHexSetActive(object o)
		{
		}

		[Token(Token = "0x60017F8")]
		[Address(RVA = "0x3E69B04", Offset = "0x3E65B04", VA = "0x3E69B04")]
		private void OnUpgradeMainTowerPanelChangeActive(object o)
		{
		}

		[Token(Token = "0x60017F9")]
		[Address(RVA = "0x3E69E2C", Offset = "0x3E65E2C", VA = "0x3E69E2C")]
		[AsyncStateMachine(typeof(_003CGenerate_003Ed__31))]
		public void Generate()
		{
		}

		[Token(Token = "0x60017FA")]
		[Address(RVA = "0x3E69EB8", Offset = "0x3E65EB8", VA = "0x3E69EB8")]
		public void Clear()
		{
		}

		[Token(Token = "0x60017FB")]
		[Address(RVA = "0x3E69FDC", Offset = "0x3E65FDC", VA = "0x3E69FDC")]
		[AsyncStateMachine(typeof(_003CInitMap_003Ed__33))]
		private void InitMap()
		{
		}

		[Token(Token = "0x60017FC")]
		[Address(RVA = "0x3E6A068", Offset = "0x3E66068", VA = "0x3E6A068")]
		public void CreatNearHex(string key)
		{
		}

		[Token(Token = "0x60017FD")]
		[Address(RVA = "0x3E6AAEC", Offset = "0x3E66AEC", VA = "0x3E6AAEC")]
		public List<Vector3> GetNearHex(string key)
		{
			return null;
		}

		[Token(Token = "0x60017FE")]
		[Address(RVA = "0x3E6B67C", Offset = "0x3E6767C", VA = "0x3E6B67C")]
		public void GetInitNearHex(ref List<Vector3> hexDataKey, string key)
		{
		}

		[Token(Token = "0x60017FF")]
		[Address(RVA = "0x3E6BBAC", Offset = "0x3E67BAC", VA = "0x3E6BBAC")]
		public void GetAllPos(List<UserOutsiderHexData> userHexData)
		{
		}

		[Token(Token = "0x6001800")]
		[Address(RVA = "0x3E6BDE8", Offset = "0x3E67DE8", VA = "0x3E6BDE8")]
		private void GetAllPos()
		{
		}

		[Token(Token = "0x6001801")]
		[Address(RVA = "0x3E6C294", Offset = "0x3E68294", VA = "0x3E6C294")]
		public List<Vector3> GetInitOutsiedeHex(int count)
		{
			return null;
		}

		[Token(Token = "0x6001802")]
		[Address(RVA = "0x3E6B114", Offset = "0x3E67114", VA = "0x3E6B114")]
		private string GetKeyToString(Vector3 ori)
		{
			return null;
		}

		[Token(Token = "0x6001803")]
		[Address(RVA = "0x3E6B464", Offset = "0x3E67464", VA = "0x3E6B464")]
		private Vector3 GetKey(Vector3 ori)
		{
			return default;
		}

		[Token(Token = "0x6001804")]
		[Address(RVA = "0x3E6B040", Offset = "0x3E67040", VA = "0x3E6B040")]
		private void GenerateHexs(Vector3 pos, UserOutsiderHexData data, bool isInit)
		{
		}

		[Token(Token = "0x6001805")]
		[Address(RVA = "0x3E6CAA4", Offset = "0x3E68AA4", VA = "0x3E6CAA4")]
		private void SetHexNear(OutsiderHexBehaviour hexBehaviour)
		{
		}

		[Token(Token = "0x6001806")]
		[Address(RVA = "0x3E6CDB8", Offset = "0x3E68DB8", VA = "0x3E6CDB8")]
		private bool FindHexByPos(Vector3 hexPosition, out OutsiderHexBehaviour hexOut)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HomelLandCtrl.FindHexByPos RVA=0x3E6CDB8 Token=0x6001806");
}

		[Token(Token = "0x6001807")]
		[Address(RVA = "0x3E6C6D8", Offset = "0x3E686D8", VA = "0x3E6C6D8")]
		private OutsiderHexBehaviour CreatHex(Vector3 hexPosition, UserOutsiderHexData data, bool isInit)
		{
			return null;
		}

		[Token(Token = "0x6001808")]
		[Address(RVA = "0x3E6C5B0", Offset = "0x3E685B0", VA = "0x3E6C5B0")]
		private void AddWillCreatInitHexPosToList(Vector3 pos)
		{
		}

		[Token(Token = "0x6001809")]
		[Address(RVA = "0x3E6C16C", Offset = "0x3E6816C", VA = "0x3E6C16C")]
		private void AddWillCreatHexPosToList(Vector3 pos)
		{
		}

		[Token(Token = "0x600180A")]
		[Address(RVA = "0x3E6D20C", Offset = "0x3E6920C", VA = "0x3E6D20C")]
		private void UpgradeMainTowerPanelBeginDoAni(object o)
		{
		}

		[Token(Token = "0x600180B")]
		[Address(RVA = "0x3E6D218", Offset = "0x3E69218", VA = "0x3E6D218")]
		private void UpgradeMainTowerPanelDoAniEnd(object o)
		{
		}

		[Token(Token = "0x600180C")]
		[Address(RVA = "0x3E6D220", Offset = "0x3E69220", VA = "0x3E6D220")]
		public HomelLandCtrl()
		{
		}
	}
}
