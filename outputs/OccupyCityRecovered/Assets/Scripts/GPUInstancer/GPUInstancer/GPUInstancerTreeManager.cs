using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000078")]
	[ExecuteInEditMode]
	public class GPUInstancerTreeManager : GPUInstancerTerrainManager
	{
		[Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class _003CReplaceUnityTrees_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000437")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000438")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000439")]
			[FieldOffset(Offset = "0x20")]
			public GPUInstancerTreeManager _003C_003E4__this;

			[Token(Token = "0x400043A")]
			[FieldOffset(Offset = "0x28")]
			private Vector4[] _003CtreeScales_003E5__2;

			[Token(Token = "0x400043B")]
			[FieldOffset(Offset = "0x30")]
			private int[] _003CinstanceCounts_003E5__3;

			[Token(Token = "0x400043C")]
			[FieldOffset(Offset = "0x38")]
			private List<Vector4> _003CtreeDataList_003E5__4;

			[Token(Token = "0x400043D")]
			[FieldOffset(Offset = "0x40")]
			private int _003CinstanceTotal_003E5__5;

			[Token(Token = "0x400043E")]
			[FieldOffset(Offset = "0x48")]
			private ComputeBuffer _003CtreeDataBuffer_003E5__6;

			[Token(Token = "0x400043F")]
			[FieldOffset(Offset = "0x50")]
			private ComputeBuffer _003CtreeScalesBuffer_003E5__7;

			[Token(Token = "0x4000440")]
			[FieldOffset(Offset = "0x58")]
			private ComputeBuffer _003CcounterBuffer_003E5__8;

			[Token(Token = "0x4000441")]
			[FieldOffset(Offset = "0x60")]
			private uint[] _003CemptyCounterData_003E5__9;

			[Token(Token = "0x4000442")]
			[FieldOffset(Offset = "0x68")]
			private int _003Ci_003E5__10;

			[Token(Token = "0x17000026")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000325")]
				[Address(RVA = "0x740B998", Offset = "0x7407998", VA = "0x740B998", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000027")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000327")]
				[Address(RVA = "0x740B9D8", Offset = "0x74079D8", VA = "0x740B9D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x740AB5C", Offset = "0x7406B5C", VA = "0x740AB5C")]
			[DebuggerHidden]
			public _003CReplaceUnityTrees_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000323")]
			[Address(RVA = "0x740AB94", Offset = "0x7406B94", VA = "0x740AB94", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x740AB98", Offset = "0x7406B98", VA = "0x740AB98", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x740B998", Offset = "0x7407998", VA = "0x740B998", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x740B9A0", Offset = "0x74079A0", VA = "0x740B9A0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x740B9D8", Offset = "0x74079D8", VA = "0x740B9D8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x0")]
		private static ComputeShader _treeInstantiationComputeShader;

		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0xF0")]
		public bool initializeWithCoroutine;

		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0xF1")]
		private bool _isCoroutineActive;

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x740A054", Offset = "0x7406054", VA = "0x740A054", Slot = "4")]
		public override void Awake()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x740A148", Offset = "0x7406148", VA = "0x740A148", Slot = "7")]
		public override void Update()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x740A23C", Offset = "0x740623C", VA = "0x740A23C", Slot = "12")]
		public override void ClearInstancingData()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x740A408", Offset = "0x7406408", VA = "0x740A408", Slot = "13")]
		public override void GeneratePrototypes(bool forceNew = false)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x740A56C", Offset = "0x740656C", VA = "0x740A56C", Slot = "14")]
		public override void InitializeRuntimeDataAndBuffers(bool forceNew = true)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x740A644", Offset = "0x7406644", VA = "0x740A644", Slot = "17")]
		public override void DeletePrototype(GPUInstancerPrototype prototype, bool removeSO = true)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x740A1DC", Offset = "0x74061DC", VA = "0x740A1DC")]
		[IteratorStateMachine(typeof(_003CReplaceUnityTrees_003Ed__9))]
		public IEnumerator ReplaceUnityTrees()
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x740AB84", Offset = "0x7406B84", VA = "0x740AB84")]
		public GPUInstancerTreeManager()
		{
		}
	}
}
