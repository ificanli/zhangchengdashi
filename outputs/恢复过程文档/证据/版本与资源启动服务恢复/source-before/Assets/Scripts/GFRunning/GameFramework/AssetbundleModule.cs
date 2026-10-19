using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AssetBundles;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;

namespace GameFramework
{
	[Token(Token = "0x20002FF")]
	[Obsolete("此类已经过时，请使用ResourcesModule加载资源", false)]
	public class AssetbundleModule : GameFrameModule
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000300")]
		[CompilerGenerated]
		private struct _003CLoadAsset_003Ed__16<T> : IAsyncStateMachine where T : UnityEngine.Object
		{
			[Token(Token = "0x400187A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400187B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x400187C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetBundleName;

			[Token(Token = "0x400187D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AssetbundleModule _003C_003E4__this;

			[Token(Token = "0x400187E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetName;

			[Token(Token = "0x400187F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<T> _003C_003Eu__1;

			[Token(Token = "0x600537F")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005380")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000301")]
		[CompilerGenerated]
		private sealed class _003CLoadManifest_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AssetbundleModule _003C_003E4__this;

			[Token(Token = "0x170010BC")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005384")]
				[Address(RVA = "0x713C778", Offset = "0x7138778", VA = "0x713C778", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170010BD")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005386")]
				[Address(RVA = "0x713C7B8", Offset = "0x71387B8", VA = "0x713C7B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005381")]
			[Address(RVA = "0x713B6C0", Offset = "0x71376C0", VA = "0x713B6C0")]
			[DebuggerHidden]
			public _003CLoadManifest_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005382")]
			[Address(RVA = "0x713C470", Offset = "0x7138470", VA = "0x713C470", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005383")]
			[Address(RVA = "0x713C474", Offset = "0x7138474", VA = "0x713C474", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005384")]
			[Address(RVA = "0x713C778", Offset = "0x7138778", VA = "0x713C778", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005385")]
			[Address(RVA = "0x713C780", Offset = "0x7138780", VA = "0x713C780", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005386")]
			[Address(RVA = "0x713C7B8", Offset = "0x71387B8", VA = "0x713C7B8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000302")]
		[CompilerGenerated]
		private struct _003CLoadMaterial_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x4001883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<Material> _003C_003Et__builder;

			[Token(Token = "0x4001885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string assetBundleName;

			[Token(Token = "0x4001886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AssetbundleModule _003C_003E4__this;

			[Token(Token = "0x4001887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<Material> _003C_003Eu__1;

			[Token(Token = "0x6005387")]
			[Address(RVA = "0x713C7C0", Offset = "0x71387C0", VA = "0x713C7C0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005388")]
			[Address(RVA = "0x713CAA8", Offset = "0x7138AA8", VA = "0x713CAA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000303")]
		[CompilerGenerated]
		private struct _003CLoadPrefab_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4001888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> _003C_003Et__builder;

			[Token(Token = "0x400188A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string assetName;

			[Token(Token = "0x400188B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string assetBundleName;

			[Token(Token = "0x400188C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AssetbundleModule _003C_003E4__this;

			[Token(Token = "0x400188D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<GameObject> _003C_003Eu__1;

			[Token(Token = "0x6005389")]
			[Address(RVA = "0x713CB24", Offset = "0x7138B24", VA = "0x713CB24", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600538A")]
			[Address(RVA = "0x713CFD8", Offset = "0x7138FD8", VA = "0x713CFD8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000304")]
		[CompilerGenerated]
		private struct _003CLoadScene_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x400188E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400188F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sceneName;

			[Token(Token = "0x4001891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AssetbundleModule _003C_003E4__this;

			[Token(Token = "0x4001892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isAdditive;

			[Token(Token = "0x4001893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<float> cbProgress;

			[Token(Token = "0x4001894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x600538B")]
			[Address(RVA = "0x713D054", Offset = "0x7139054", VA = "0x713D054", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600538C")]
			[Address(RVA = "0x713D33C", Offset = "0x713933C", VA = "0x713D33C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000305")]
		[CompilerGenerated]
		private struct _003CLoadSpriteAtlas_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4001895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<SpriteAtlas> _003C_003Et__builder;

			[Token(Token = "0x4001897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string assetBundleName;

			[Token(Token = "0x4001898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AssetbundleModule _003C_003E4__this;

			[Token(Token = "0x4001899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<SpriteAtlas> _003C_003Eu__1;

			[Token(Token = "0x600538D")]
			[Address(RVA = "0x713D3A4", Offset = "0x71393A4", VA = "0x713D3A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600538E")]
			[Address(RVA = "0x713D68C", Offset = "0x713968C", VA = "0x713D68C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000306")]
		[CompilerGenerated]
		private struct _003CSynLoadAsset_003Ed__17<T> : IAsyncStateMachine where T : UnityEngine.Object
		{
			[Token(Token = "0x400189A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400189B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400189C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetBundleName;

			[Token(Token = "0x400189D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AssetbundleModule _003C_003E4__this;

			[Token(Token = "0x400189E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetName;

			[Token(Token = "0x400189F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> result;

			[Token(Token = "0x40018A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<T> _003C_003Eu__1;

			[Token(Token = "0x600538F")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005390")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000307")]
		[CompilerGenerated]
		private struct _003CSynLoadPrefab_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x40018A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40018A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40018A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string assetName;

			[Token(Token = "0x40018A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string assetBundleName;

			[Token(Token = "0x40018A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AssetbundleModule _003C_003E4__this;

			[Token(Token = "0x40018A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<GameObject> result;

			[Token(Token = "0x40018A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<GameObject> _003C_003Eu__1;

			[Token(Token = "0x6005391")]
			[Address(RVA = "0x713D708", Offset = "0x7139708", VA = "0x713D708", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005392")]
			[Address(RVA = "0x713DB6C", Offset = "0x7139B6C", VA = "0x713DB6C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000308")]
		[CompilerGenerated]
		private struct _003C_LoadAsset_003Ed__26<T> : IAsyncStateMachine where T : UnityEngine.Object
		{
			[Token(Token = "0x40018A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40018A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x40018AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetBundleName;

			[Token(Token = "0x40018AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetName;

			[Token(Token = "0x40018AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private AssetBundleLoadAssetOperation _003Crequest_003E5__2;

			[Token(Token = "0x40018AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6005393")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005394")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000309")]
		[CompilerGenerated]
		private struct _003C_LoadScene_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x40018AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40018AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40018B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sceneAssetBundle;

			[Token(Token = "0x40018B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string levelName;

			[Token(Token = "0x40018B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isAdditive;

			[Token(Token = "0x40018B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AssetbundleModule _003C_003E4__this;

			[Token(Token = "0x40018B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<float> cbProgress;

			[Token(Token = "0x40018B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float _003CstartTime_003E5__2;

			[Token(Token = "0x40018B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private AssetBundleLoadOperation _003Crequest_003E5__3;

			[Token(Token = "0x40018B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6005395")]
			[Address(RVA = "0x713DB78", Offset = "0x7139B78", VA = "0x713DB78", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005396")]
			[Address(RVA = "0x713E0FC", Offset = "0x713A0FC", VA = "0x713E0FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200030A")]
		[CompilerGenerated]
		private struct _003C_LoadScene_003Ed__29 : IAsyncStateMachine
		{
			[Token(Token = "0x40018B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40018B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40018BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string sceneAssetBundle;

			[Token(Token = "0x40018BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string levelName;

			[Token(Token = "0x40018BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isAdditive;

			[Token(Token = "0x40018BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public AssetbundleModule _003C_003E4__this;

			[Token(Token = "0x40018BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action<float> cbProgress;

			[Token(Token = "0x40018BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Action<string> complete;

			[Token(Token = "0x40018C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private float _003CstartTime_003E5__2;

			[Token(Token = "0x40018C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private AssetBundleLoadOperation _003Crequest_003E5__3;

			[Token(Token = "0x40018C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6005397")]
			[Address(RVA = "0x713E164", Offset = "0x713A164", VA = "0x713E164", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005398")]
			[Address(RVA = "0x713E6E0", Offset = "0x713A6E0", VA = "0x713E6E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, Sprite> dicSprites;

		[Token(Token = "0x4001877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, Texture2D> dicTexture2D;

		[Token(Token = "0x4001878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, UnityEngine.Object> LoadAssetList;

		[Token(Token = "0x4001879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForEndOfFrame waitFrame;

		[Token(Token = "0x170010BB")]
		internal override int Priority
		{
			[Token(Token = "0x6005365")]
			[Address(RVA = "0x713B4E4", Offset = "0x71374E4", VA = "0x713B4E4", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005366")]
		[Address(RVA = "0x713B4EC", Offset = "0x71374EC", VA = "0x713B4EC", Slot = "5")]
		internal override void Initialize(params object[] Arg)
		{
		}

		[Token(Token = "0x6005367")]
		[Address(RVA = "0x713B660", Offset = "0x7137660", VA = "0x713B660")]
		[IteratorStateMachine(typeof(_003CLoadManifest_003Ed__6))]
		private IEnumerator LoadManifest()
		{
			return null;
		}

		[Token(Token = "0x6005368")]
		[Address(RVA = "0x713B6E8", Offset = "0x71376E8", VA = "0x713B6E8", Slot = "6")]
		internal override void Start()
		{
		}

		[Token(Token = "0x6005369")]
		[Address(RVA = "0x713B6EC", Offset = "0x71376EC", VA = "0x713B6EC")]
		public Sprite GetSprite(string Spname)
		{
			return null;
		}

		[Token(Token = "0x600536A")]
		[Address(RVA = "0x713B75C", Offset = "0x713775C", VA = "0x713B75C")]
		public void AddSprite(string Spname, Sprite sprite)
		{
		}

		[Token(Token = "0x600536B")]
		[Address(RVA = "0x713B828", Offset = "0x7137828", VA = "0x713B828")]
		public Texture2D GetTexture2D(string Spname)
		{
			return null;
		}

		[Token(Token = "0x600536C")]
		[Address(RVA = "0x713B898", Offset = "0x7137898", VA = "0x713B898")]
		public void AddGetTexture2D(string Spname, Texture2D sprite)
		{
		}

		[Token(Token = "0x600536D")]
		[Address(RVA = "0x713B964", Offset = "0x7137964", VA = "0x713B964", Slot = "7")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x600536E")]
		[Address(RVA = "0x713B968", Offset = "0x7137968", VA = "0x713B968", Slot = "9")]
		internal override void Shutdown()
		{
		}

		[Token(Token = "0x600536F")]
		[Address(RVA = "0x713BA34", Offset = "0x7137A34", VA = "0x713BA34")]
		private UnityEngine.Object FindLoadAssetList(string AssetName)
		{
			return null;
		}

		[Token(Token = "0x6005370")]
		[Address(RVA = "0x713BAA4", Offset = "0x7137AA4", VA = "0x713BAA4")]
		private void SaveLoadAssetList(string AssetName, UnityEngine.Object uObject)
		{
		}

		[Token(Token = "0x6005371")]
		[AsyncStateMachine(typeof(_003CLoadAsset_003Ed__16<>))]
		[Obsolete("此类已经过时，请使用ResourcesModule加载资源", false)]
		public Task<T> LoadAsset<T>(string assetBundleName, string assetName) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005372")]
		[AsyncStateMachine(typeof(_003CSynLoadAsset_003Ed__17<>))]
		[Obsolete("此类已经过时，请使用ResourcesModule加载资源", false)]
		public void SynLoadAsset<T>(string assetBundleName, string assetName, Action<T> result) where T : UnityEngine.Object
		{
		}

		[Token(Token = "0x6005373")]
		[Address(RVA = "0x713BB70", Offset = "0x7137B70", VA = "0x713BB70")]
		[Obsolete("此类已经过时，请使用ResourcesModule加载资源", false)]
		[AsyncStateMachine(typeof(_003CLoadPrefab_003Ed__18))]
		public Task<GameObject> LoadPrefab(string assetBundleName, [Optional] string assetName)
		{
			return null;
		}

		[Token(Token = "0x6005374")]
		[Address(RVA = "0x713BC68", Offset = "0x7137C68", VA = "0x713BC68")]
		[Obsolete("此类已经过时，请使用ResourcesModule加载资源", false)]
		[AsyncStateMachine(typeof(_003CSynLoadPrefab_003Ed__19))]
		public void SynLoadPrefab(string assetBundleName, Action<GameObject> result, [Optional] string assetName)
		{
		}

		[Token(Token = "0x6005375")]
		[Address(RVA = "0x713BD18", Offset = "0x7137D18", VA = "0x713BD18")]
		[AsyncStateMachine(typeof(_003CLoadSpriteAtlas_003Ed__20))]
		public Task<SpriteAtlas> LoadSpriteAtlas(string assetBundleName)
		{
			return null;
		}

		[Token(Token = "0x6005376")]
		[Address(RVA = "0x71378A0", Offset = "0x71338A0", VA = "0x71378A0")]
		public void SynLoadSpriteAtlas(string assetBundleName, Action<SpriteAtlas> result)
		{
		}

		[Token(Token = "0x6005377")]
		[Address(RVA = "0x713BE04", Offset = "0x7137E04", VA = "0x713BE04")]
		[AsyncStateMachine(typeof(_003CLoadMaterial_003Ed__22))]
		public Task<Material> LoadMaterial(string assetBundleName)
		{
			return null;
		}

		[Token(Token = "0x6005378")]
		[Address(RVA = "0x713BEF0", Offset = "0x7137EF0", VA = "0x713BEF0")]
		public void SynLoadMaterial(string assetBundleName, Action<Material> result)
		{
		}

		[Token(Token = "0x6005379")]
		[Address(RVA = "0x713BFDC", Offset = "0x7137FDC", VA = "0x713BFDC")]
		[Obsolete("此类已经过时，请使用ResourcesModule加载资源", false)]
		[AsyncStateMachine(typeof(_003CLoadScene_003Ed__24))]
		public Task LoadScene(string sceneName, [Optional][DefaultParameterValue(false)] bool isAdditive, [Optional] Action<float> cbProgress)
		{
			return null;
		}

		[Token(Token = "0x600537A")]
		[Address(RVA = "0x713C0CC", Offset = "0x71380CC", VA = "0x713C0CC")]
		[Obsolete("此类已经过时，请使用ResourcesModule加载资源", false)]
		public void SynLoadScene(string sceneName, [Optional][DefaultParameterValue(false)] bool isAdditive, [Optional] Action<string> complete, [Optional] Action<float> cbProgress)
		{
		}

		[Token(Token = "0x600537B")]
		[AsyncStateMachine(typeof(_003C_LoadAsset_003Ed__26<>))]
		internal Task<T> _LoadAsset<T>(string assetBundleName, string assetName, bool isWait = false) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600537C")]
		[Address(RVA = "0x713C2D4", Offset = "0x71382D4", VA = "0x713C2D4")]
		[AsyncStateMachine(typeof(_003C_LoadScene_003Ed__28))]
		private Task _LoadScene(string sceneAssetBundle, string levelName, bool isAdditive, Action<float> cbProgress)
		{
			return null;
		}

		[Token(Token = "0x600537D")]
		[Address(RVA = "0x713C204", Offset = "0x7138204", VA = "0x713C204")]
		[AsyncStateMachine(typeof(_003C_LoadScene_003Ed__29))]
		private void _LoadScene(string sceneAssetBundle, string levelName, bool isAdditive, Action<float> cbProgress, Action<string> complete)
		{
		}

		[Token(Token = "0x600537E")]
		[Address(RVA = "0x713C3C8", Offset = "0x71383C8", VA = "0x713C3C8")]
		public AssetbundleModule()
		{
		}
	}
}
