using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GPUInstancer
{
	[Token(Token = "0x2000007")]
	public class AddRemoveInstances : MonoBehaviour
	{
		[Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class _003CAddExtraInstancesAtRuntime_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400007A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400007B")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400007C")]
			[FieldOffset(Offset = "0x20")]
			public AddRemoveInstances _003C_003E4__this;

			[Token(Token = "0x400007D")]
			[FieldOffset(Offset = "0x28")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000001")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600002B")]
				[Address(RVA = "0x73AF0BC", Offset = "0x73AB0BC", VA = "0x73AF0BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000002")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600002D")]
				[Address(RVA = "0x73AF0FC", Offset = "0x73AB0FC", VA = "0x73AF0FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000028")]
			[Address(RVA = "0x73AEB00", Offset = "0x73AAB00", VA = "0x73AEB00")]
			[DebuggerHidden]
			public _003CAddExtraInstancesAtRuntime_003Ed__16(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x73AEC74", Offset = "0x73AAC74", VA = "0x73AEC74", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600002A")]
			[Address(RVA = "0x73AEC78", Offset = "0x73AAC78", VA = "0x73AEC78", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600002B")]
			[Address(RVA = "0x73AF0BC", Offset = "0x73AB0BC", VA = "0x73AF0BC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600002C")]
			[Address(RVA = "0x73AF0C4", Offset = "0x73AB0C4", VA = "0x73AF0C4", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600002D")]
			[Address(RVA = "0x73AF0FC", Offset = "0x73AB0FC", VA = "0x73AF0FC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class _003CAddInstancesAtRuntime_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400007E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400007F")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000080")]
			[FieldOffset(Offset = "0x20")]
			public AddRemoveInstances _003C_003E4__this;

			[Token(Token = "0x4000081")]
			[FieldOffset(Offset = "0x28")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000003")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000031")]
				[Address(RVA = "0x73AF390", Offset = "0x73AB390", VA = "0x73AF390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000004")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000033")]
				[Address(RVA = "0x73AF3D0", Offset = "0x73AB3D0", VA = "0x73AF3D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x73AEAB0", Offset = "0x73AAAB0", VA = "0x73AEAB0")]
			[DebuggerHidden]
			public _003CAddInstancesAtRuntime_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600002F")]
			[Address(RVA = "0x73AF104", Offset = "0x73AB104", VA = "0x73AF104", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000030")]
			[Address(RVA = "0x73AF108", Offset = "0x73AB108", VA = "0x73AF108", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000031")]
			[Address(RVA = "0x73AF390", Offset = "0x73AB390", VA = "0x73AF390", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000032")]
			[Address(RVA = "0x73AF398", Offset = "0x73AB398", VA = "0x73AF398", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000033")]
			[Address(RVA = "0x73AF3D0", Offset = "0x73AB3D0", VA = "0x73AF3D0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class _003CRemoveExtraInstancesAtRuntime_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000082")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000083")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000084")]
			[FieldOffset(Offset = "0x20")]
			public AddRemoveInstances _003C_003E4__this;

			[Token(Token = "0x4000085")]
			[FieldOffset(Offset = "0x28")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000005")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000037")]
				[Address(RVA = "0x73AF660", Offset = "0x73AB660", VA = "0x73AF660", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000006")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000039")]
				[Address(RVA = "0x73AF6A0", Offset = "0x73AB6A0", VA = "0x73AF6A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0x73AEB28", Offset = "0x73AAB28", VA = "0x73AEB28")]
			[DebuggerHidden]
			public _003CRemoveExtraInstancesAtRuntime_003Ed__17(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0x73AF3D8", Offset = "0x73AB3D8", VA = "0x73AF3D8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x73AF3DC", Offset = "0x73AB3DC", VA = "0x73AF3DC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0x73AF660", Offset = "0x73AB660", VA = "0x73AF660", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0x73AF668", Offset = "0x73AB668", VA = "0x73AF668", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000039")]
			[Address(RVA = "0x73AF6A0", Offset = "0x73AB6A0", VA = "0x73AF6A0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class _003CRemoveInstancesAtRuntime_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000086")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000087")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000088")]
			[FieldOffset(Offset = "0x20")]
			public AddRemoveInstances _003C_003E4__this;

			[Token(Token = "0x4000089")]
			[FieldOffset(Offset = "0x28")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000007")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600003D")]
				[Address(RVA = "0x73AF8FC", Offset = "0x73AB8FC", VA = "0x73AF8FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000008")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600003F")]
				[Address(RVA = "0x73AF93C", Offset = "0x73AB93C", VA = "0x73AF93C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0x73AEAD8", Offset = "0x73AAAD8", VA = "0x73AEAD8")]
			[DebuggerHidden]
			public _003CRemoveInstancesAtRuntime_003Ed__15(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0x73AF6A8", Offset = "0x73AB6A8", VA = "0x73AF6A8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x73AF6AC", Offset = "0x73AB6AC", VA = "0x73AF6AC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600003D")]
			[Address(RVA = "0x73AF8FC", Offset = "0x73AB8FC", VA = "0x73AF8FC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x73AF904", Offset = "0x73AB904", VA = "0x73AF904", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600003F")]
			[Address(RVA = "0x73AF93C", Offset = "0x73AB93C", VA = "0x73AF93C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x20")]
		public GPUInstancerPrefab prefab;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x28")]
		public GPUInstancerPrefabManager prefabManager;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x30")]
		private Transform parentTransform;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x38")]
		private int instanceCount;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x40")]
		private List<GPUInstancerPrefab> instancesList;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x48")]
		private List<GPUInstancerPrefab> extraInstancesList;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x50")]
		private Toggle addRemoveInstantlyToggle;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x58")]
		private Canvas guiCanvas;

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x73AE5B4", Offset = "0x73AA5B4", VA = "0x73AE5B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x73AE688", Offset = "0x73AA688", VA = "0x73AE688")]
		private void Start()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x73AE790", Offset = "0x73AA790", VA = "0x73AE790")]
		public void AddInstances()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x73AE918", Offset = "0x73AA918", VA = "0x73AE918")]
		public void RemoveInstances()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x73AE9A0", Offset = "0x73AA9A0", VA = "0x73AE9A0")]
		public void AddExtraInstances()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x73AEA28", Offset = "0x73AAA28", VA = "0x73AEA28")]
		public void RemoveExtraInstances()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x73AE8B8", Offset = "0x73AA8B8", VA = "0x73AE8B8")]
		[IteratorStateMachine(typeof(_003CAddInstancesAtRuntime_003Ed__14))]
		private IEnumerator AddInstancesAtRuntime()
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x73AE940", Offset = "0x73AA940", VA = "0x73AE940")]
		[IteratorStateMachine(typeof(_003CRemoveInstancesAtRuntime_003Ed__15))]
		private IEnumerator RemoveInstancesAtRuntime()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x73AE9C8", Offset = "0x73AA9C8", VA = "0x73AE9C8")]
		[IteratorStateMachine(typeof(_003CAddExtraInstancesAtRuntime_003Ed__16))]
		private IEnumerator AddExtraInstancesAtRuntime()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x73AEA50", Offset = "0x73AAA50", VA = "0x73AEA50")]
		[IteratorStateMachine(typeof(_003CRemoveExtraInstancesAtRuntime_003Ed__17))]
		private IEnumerator RemoveExtraInstancesAtRuntime()
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x73AE7B8", Offset = "0x73AA7B8", VA = "0x73AE7B8")]
		private void LockAllButtons()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x73AEB50", Offset = "0x73AAB50", VA = "0x73AEB50")]
		private void EnableButton(string buttonName)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x73AEBE0", Offset = "0x73AABE0", VA = "0x73AEBE0")]
		public AddRemoveInstances()
		{
		}
	}
}
