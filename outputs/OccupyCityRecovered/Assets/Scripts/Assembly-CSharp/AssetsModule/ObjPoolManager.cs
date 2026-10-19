using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace AssetsModule
{
	[Token(Token = "0x2000647")]
	public class ObjPoolManager : ManagerBase<ObjPoolManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000649")]
		[CompilerGenerated]
		private struct _003CGetFromPool_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4003351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<GameObject> _003C_003Et__builder;

			[Token(Token = "0x4003353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string prefabPath;

			[Token(Token = "0x4003354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjPoolManager _003C_003E4__this;

			[Token(Token = "0x4003355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int initPoolSize;

			[Token(Token = "0x4003356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delayRecycleTime;

			[Token(Token = "0x4003357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool _003CsampleActive_003E5__2;

			[Token(Token = "0x4003358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private string _003CprefabName_003E5__3;

			[Token(Token = "0x4003359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002125")]
			[Address(RVA = "0x3F20D6C", Offset = "0x3F1CD6C", VA = "0x3F20D6C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002126")]
			[Address(RVA = "0x3F21230", Offset = "0x3F1D230", VA = "0x3F21230", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200064A")]
		[CompilerGenerated]
		private struct _003CGetFromPoolUI_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x400335A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400335B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<GameObject> _003C_003Et__builder;

			[Token(Token = "0x400335C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string prefabPath;

			[Token(Token = "0x400335D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjPoolManager _003C_003E4__this;

			[Token(Token = "0x400335E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int initPoolSize;

			[Token(Token = "0x400335F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delayRecycleTime;

			[Token(Token = "0x4003360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool _003CsampleActive_003E5__2;

			[Token(Token = "0x4003361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private string _003CprefabName_003E5__3;

			[Token(Token = "0x4003362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002127")]
			[Address(RVA = "0x3F21288", Offset = "0x3F1D288", VA = "0x3F21288", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002128")]
			[Address(RVA = "0x3F2174C", Offset = "0x3F1D74C", VA = "0x3F2174C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200064B")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4003363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ObjPoolManager _003C_003E4__this;

			[Token(Token = "0x6002129")]
			[Address(RVA = "0x3F217A4", Offset = "0x3F1D7A4", VA = "0x3F217A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600212A")]
			[Address(RVA = "0x3F21A10", Offset = "0x3F1DA10", VA = "0x3F21A10", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200064C")]
		[CompilerGenerated]
		private struct _003CPrewarm_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4003366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string prefabPath;

			[Token(Token = "0x4003369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int initialSize;

			[Token(Token = "0x400336A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjPoolManager _003C_003E4__this;

			[Token(Token = "0x400336B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool uiPool;

			[Token(Token = "0x400336C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600212B")]
			[Address(RVA = "0x3F21A1C", Offset = "0x3F1DA1C", VA = "0x3F21A1C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600212C")]
			[Address(RVA = "0x3F21E64", Offset = "0x3F1DE64", VA = "0x3F21E64", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400334C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, ObjPool> _objectPools;

		[Token(Token = "0x400334D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<string> _battlePersistentPoolNames;

		[Token(Token = "0x600210A")]
		[Address(RVA = "0x3F1F044", Offset = "0x3F1B044", VA = "0x3F1F044", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x600210B")]
		[Address(RVA = "0x3F1F0C8", Offset = "0x3F1B0C8", VA = "0x3F1F0C8")]
		public GameObject GetFromPool(GameObject prefab, float delayRecycleTime = -1f, bool active = true, int initPoolSize = 3)
		{
			return null;
		}

		[Token(Token = "0x600210C")]
		[Address(RVA = "0x3F1F518", Offset = "0x3F1B518", VA = "0x3F1F518")]
		public void DestroyPool(GameObject prefab)
		{
		}

		[Token(Token = "0x600210D")]
		[Address(RVA = "0x3F1F9C4", Offset = "0x3F1B9C4", VA = "0x3F1F9C4")]
		public void DestroyAllPools()
		{
		}

		[Token(Token = "0x600210E")]
		[Address(RVA = "0x3F1FBE0", Offset = "0x3F1BBE0", VA = "0x3F1FBE0")]
		public GameObject GetFromPoolUI(GameObject prefab, float delayRecycleTime = -1f, int initPoolSize = 3)
		{
			return null;
		}

		[Token(Token = "0x600210F")]
		[Address(RVA = "0x3F1FE70", Offset = "0x3F1BE70", VA = "0x3F1FE70")]
		[AsyncStateMachine(typeof(_003CGetFromPoolUI_003Ed__7))]
		public UniTask<GameObject> GetFromPoolUI(string prefabPath, float delayRecycleTime = -1f, int initPoolSize = 3)
		{
			return default;
		}

		[Token(Token = "0x6002110")]
		[Address(RVA = "0x3F1FF6C", Offset = "0x3F1BF6C", VA = "0x3F1FF6C")]
		[AsyncStateMachine(typeof(_003CGetFromPool_003Ed__8))]
		public UniTask<GameObject> GetFromPool(string prefabPath, float delayRecycleTime = -1f, int initPoolSize = 3)
		{
			return default;
		}

		[Token(Token = "0x6002111")]
		[Address(RVA = "0x3F20068", Offset = "0x3F1C068", VA = "0x3F20068")]
		public void Recycle(GameObject poolObject)
		{
		}

		[Token(Token = "0x6002112")]
		[Address(RVA = "0x3F1F63C", Offset = "0x3F1B63C", VA = "0x3F1F63C")]
		public bool HasPool(string prefabName)
		{
			return default;
		}

		[Token(Token = "0x6002113")]
		[Address(RVA = "0x3F201D0", Offset = "0x3F1C1D0", VA = "0x3F201D0")]
		public void SetBattlePersistentPools(HashSet<string> poolNames)
		{
		}

		[Token(Token = "0x6002114")]
		[Address(RVA = "0x3F2035C", Offset = "0x3F1C35C", VA = "0x3F2035C")]
		public void MarkBattlePersistentPool(GameObject prefab)
		{
		}

		[Token(Token = "0x6002115")]
		[Address(RVA = "0x3F2045C", Offset = "0x3F1C45C", VA = "0x3F2045C")]
		public void MarkBattlePersistentPool(string prefabPath)
		{
		}

		[Token(Token = "0x6002116")]
		[Address(RVA = "0x3F205D4", Offset = "0x3F1C5D4", VA = "0x3F205D4")]
		public bool IsBattlePersistentPool(GameObject prefab)
		{
			return default;
		}

		[Token(Token = "0x6002117")]
		[Address(RVA = "0x3F1F69C", Offset = "0x3F1B69C", VA = "0x3F1F69C")]
		public bool IsBattlePersistentPool(string poolName)
		{
			return default;
		}

		[Token(Token = "0x6002118")]
		[Address(RVA = "0x3F20674", Offset = "0x3F1C674", VA = "0x3F20674")]
		public List<string> GetBattlePersistentPoolNames()
		{
			return null;
		}

		[Token(Token = "0x6002119")]
		public bool HasBattlePersistentPoolWithComponent<T>() where T : Component
		{
			return default;
		}

		[Token(Token = "0x600211A")]
		[Address(RVA = "0x3F207E4", Offset = "0x3F1C7E4", VA = "0x3F207E4")]
		public void Prewarm(GameObject prefab, int initialSize, bool uiPool = false)
		{
		}

		[Token(Token = "0x600211B")]
		[Address(RVA = "0x3F20B94", Offset = "0x3F1CB94", VA = "0x3F20B94")]
		[AsyncStateMachine(typeof(_003CPrewarm_003Ed__19))]
		public UniTask Prewarm(string prefabPath, int initialSize, bool uiPool = false)
		{
			return default;
		}

		[Token(Token = "0x600211C")]
		[Address(RVA = "0x3F1F27C", Offset = "0x3F1B27C", VA = "0x3F1F27C")]
		public void CreatePool(GameObject prefab, int initialSize = 3)
		{
		}

		[Token(Token = "0x600211D")]
		[Address(RVA = "0x3F1FC5C", Offset = "0x3F1BC5C", VA = "0x3F1FC5C")]
		public void CreatePoolUI(GameObject prefab, int initialSize = 1)
		{
		}

		[Token(Token = "0x600211E")]
		[Address(RVA = "0x3F1FD94", Offset = "0x3F1BD94", VA = "0x3F1FD94")]
		public GameObject GetObjectFromPool(string prefabName, float delayRecycleTime = -1f, bool active = true)
		{
			return null;
		}

		[Token(Token = "0x600211F")]
		[Address(RVA = "0x3F20520", Offset = "0x3F1C520", VA = "0x3F20520")]
		public static string GetPoolNameFromPath(string prefabPath)
		{
			return null;
		}

		[Token(Token = "0x6002120")]
		[Address(RVA = "0x3F20C50", Offset = "0x3F1CC50", VA = "0x3F20C50")]
		public ObjPoolManager()
		{
		}
	}
}
