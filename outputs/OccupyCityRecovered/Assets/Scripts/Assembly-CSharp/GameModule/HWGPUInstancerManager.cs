using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GPUInstancer;
using GPUInstancer.CrowdAnimations;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200044A")]
	public class HWGPUInstancerManager : ManagerBase<HWGPUInstancerManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200044B")]
		[CompilerGenerated]
		private struct _003CAddInstance_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject _rolePrefabRes;

			[Token(Token = "0x4002A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HWGPUInstancerManager _003C_003E4__this;

			[Token(Token = "0x4002A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60014D6")]
			[Address(RVA = "0x3E08278", Offset = "0x3E04278", VA = "0x3E08278", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60014D7")]
			[Address(RVA = "0x3E08C8C", Offset = "0x3E04C8C", VA = "0x3E08C8C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200044C")]
		[CompilerGenerated]
		private struct _003CCreatCrowdManager_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HWGPUInstancerManager _003C_003E4__this;

			[Token(Token = "0x4002A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<GPUInstancerPrefabPrototype, GameObject> instancerPrefabPrototypes;

			[Token(Token = "0x4002A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60014D8")]
			[Address(RVA = "0x3E08C98", Offset = "0x3E04C98", VA = "0x3E08C98", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60014D9")]
			[Address(RVA = "0x3E0A07C", Offset = "0x3E0607C", VA = "0x3E0A07C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200044D")]
		[CompilerGenerated]
		private struct _003CCreatPrefabManager_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HWGPUInstancerManager _003C_003E4__this;

			[Token(Token = "0x4002A40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<GPUInstancerPrefabPrototype, GameObject> instancerPrefabPrototypes;

			[Token(Token = "0x4002A41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60014DA")]
			[Address(RVA = "0x3E0A088", Offset = "0x3E06088", VA = "0x3E0A088", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60014DB")]
			[Address(RVA = "0x3E0AC74", Offset = "0x3E06C74", VA = "0x3E0AC74", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200044E")]
		[CompilerGenerated]
		private struct _003CGameInit_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HWGPUInstancerManager _003C_003E4__this;

			[Token(Token = "0x4002A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private HashSet<string> _003CbuildingPaths_003E5__2;

			[Token(Token = "0x4002A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<GPUInstancerPrefabPrototype, GameObject> _003Croles_003E5__3;

			[Token(Token = "0x4002A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<GPUInstancerPrefabPrototype, GameObject> _003Cprefabs_003E5__4;

			[Token(Token = "0x4002A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Dictionary<GPUInstancerPrefabPrototype, GameObject>>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60014DC")]
			[Address(RVA = "0x3E0AC80", Offset = "0x3E06C80", VA = "0x3E0AC80", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60014DD")]
			[Address(RVA = "0x3E0BB68", Offset = "0x3E07B68", VA = "0x3E0BB68", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200044F")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x60014DE")]
			[Address(RVA = "0x3E0BB74", Offset = "0x3E07B74", VA = "0x3E0BB74", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60014DF")]
			[Address(RVA = "0x3E0BC28", Offset = "0x3E07C28", VA = "0x3E0BC28", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000450")]
		[CompilerGenerated]
		private struct _003CLoadAllGPUIPrefabs_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Dictionary<GPUInstancerPrefabPrototype, GameObject>> _003C_003Et__builder;

			[Token(Token = "0x4002A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HashSet<string> paths;

			[Token(Token = "0x4002A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HWGPUInstancerManager _003C_003E4__this;

			[Token(Token = "0x4002A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<GPUInstancerPrefabPrototype, GameObject> _003Cresults_003E5__2;

			[Token(Token = "0x4002A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject[]>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60014E0")]
			[Address(RVA = "0x3E0BC34", Offset = "0x3E07C34", VA = "0x3E0BC34", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60014E1")]
			[Address(RVA = "0x3E0C454", Offset = "0x3E08454", VA = "0x3E0C454", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000451")]
		[CompilerGenerated]
		private struct _003CLoadGPUIPrefab_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<GameObject> _003C_003Et__builder;

			[Token(Token = "0x4002A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string path;

			[Token(Token = "0x4002A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60014E2")]
			[Address(RVA = "0x3E0C4AC", Offset = "0x3E084AC", VA = "0x3E0C4AC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60014E3")]
			[Address(RVA = "0x3E0C888", Offset = "0x3E08888", VA = "0x3E0C888", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool gameInitComplete;

		[Token(Token = "0x4002A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GPUICrowdManager _gpuiCrowdManager;

		[Token(Token = "0x4002A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GPUInstancerPrefabManager _gpuiPrefabManager;

		[Token(Token = "0x4002A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, GameObject> crowdManagerPrefabInstantiate;

		[Token(Token = "0x4002A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, GameObject> prefabManagerPrefabInstantiate;

		[Token(Token = "0x4002A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<GPUInstancerPrefabPrototype> currentGPUInstancerCrowdPrototypes;

		[Token(Token = "0x4002A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool hadGetGPUInstancerSupported;

		[Token(Token = "0x4002A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool GPUInstancerSupported;

		[Token(Token = "0x1700013C")]
		public bool IsDestroying
		{
			[Token(Token = "0x60014C2")]
			[Address(RVA = "0x3E06570", Offset = "0x3E02570", VA = "0x3E06570")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x60014C3")]
			[Address(RVA = "0x3E06578", Offset = "0x3E02578", VA = "0x3E06578")]
			[CompilerGenerated]
			private set;
		}

		[Token(Token = "0x1700013D")]
		public bool IsCrowdManagerAlive
		{
			[Token(Token = "0x60014C4")]
			[Address(RVA = "0x3E06584", Offset = "0x3E02584", VA = "0x3E06584")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x3E065E4", Offset = "0x3E025E4", VA = "0x3E065E4", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__11))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x3E06664", Offset = "0x3E02664", VA = "0x3E06664")]
		[AsyncStateMachine(typeof(_003CCreatCrowdManager_003Ed__13))]
		public UniTask CreatCrowdManager([Optional] Dictionary<GPUInstancerPrefabPrototype, GameObject> instancerPrefabPrototypes)
		{
			return default;
		}

		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x3E06700", Offset = "0x3E02700", VA = "0x3E06700")]
		[AsyncStateMachine(typeof(_003CCreatPrefabManager_003Ed__14))]
		public UniTask CreatPrefabManager([Optional] Dictionary<GPUInstancerPrefabPrototype, GameObject> instancerPrefabPrototypes)
		{
			return default;
		}

		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x3DFBE38", Offset = "0x3DF7E38", VA = "0x3DFBE38")]
		public void DestroyCrowdManager()
		{
		}

		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x3E06D8C", Offset = "0x3E02D8C", VA = "0x3E06D8C")]
		public void RemovePrefabManager()
		{
		}

		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x3E06B40", Offset = "0x3E02B40", VA = "0x3E06B40")]
		private void SetRegisteredPrefabStateNone(GPUInstancerPrefabManager prefabManager)
		{
		}

		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x3E03280", Offset = "0x3DFF280", VA = "0x3E03280")]
		[AsyncStateMachine(typeof(_003CAddInstance_003Ed__18))]
		public void AddInstance(GameObject _rolePrefabRes)
		{
		}

		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x3E0712C", Offset = "0x3E0312C", VA = "0x3E0712C")]
		public void ChangeMaterial(GPUInstancerPrototype gPUInstancerPrototype, Material material)
		{
		}

		[Token(Token = "0x60014CD")]
		[Address(RVA = "0x3E04D88", Offset = "0x3E00D88", VA = "0x3E04D88")]
		[AsyncStateMachine(typeof(_003CGameInit_003Ed__20))]
		public UniTask GameInit()
		{
			return default;
		}

		[Token(Token = "0x60014CE")]
		[Address(RVA = "0x3E0717C", Offset = "0x3E0317C", VA = "0x3E0717C")]
		private void CollectPaths(List<GlobalHeroCardInfo> cardInfos, bool isUser, HashSet<string> rolePaths, HashSet<string> buildingPaths)
		{
		}

		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x3E07590", Offset = "0x3E03590", VA = "0x3E07590")]
		[AsyncStateMachine(typeof(_003CLoadAllGPUIPrefabs_003Ed__22))]
		private UniTask<Dictionary<GPUInstancerPrefabPrototype, GameObject>> LoadAllGPUIPrefabs(HashSet<string> paths)
		{
			return default;
		}

		[Token(Token = "0x60014D0")]
		[Address(RVA = "0x3E0766C", Offset = "0x3E0366C", VA = "0x3E0766C")]
		[AsyncStateMachine(typeof(_003CLoadGPUIPrefab_003Ed__23))]
		private UniTask<GameObject> LoadGPUIPrefab(string path)
		{
			return default;
		}

		[Token(Token = "0x60014D1")]
		[Address(RVA = "0x3E0679C", Offset = "0x3E0279C", VA = "0x3E0679C")]
		public static bool IsGPUInstancerSupported()
		{
			return default;
		}

		[Token(Token = "0x60014D2")]
		[Address(RVA = "0x3E07740", Offset = "0x3E03740", VA = "0x3E07740")]
		public static bool IsProblematicGPU()
		{
			return default;
		}

		[Token(Token = "0x60014D3")]
		[Address(RVA = "0x3E0783C", Offset = "0x3E0383C", VA = "0x3E0783C")]
		private static bool IsDeviceInCrashList()
		{
			return default;
		}

		[Token(Token = "0x60014D4")]
		[Address(RVA = "0x3E08128", Offset = "0x3E04128", VA = "0x3E08128")]
		public HWGPUInstancerManager()
		{
		}
	}
}
