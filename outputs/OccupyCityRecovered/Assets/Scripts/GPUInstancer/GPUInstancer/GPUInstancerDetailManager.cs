using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200005D")]
	[ExecuteInEditMode]
	public class GPUInstancerDetailManager : GPUInstancerTerrainManager
	{
		[Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class _003CFillCellsDetailData_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GPUInstancerDetailManager _003C_003E4__this;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Terrain terrain;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000018")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000263")]
				[Address(RVA = "0x73F6BA4", Offset = "0x73F2BA4", VA = "0x73F6BA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000019")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000265")]
				[Address(RVA = "0x73F6BE4", Offset = "0x73F2BE4", VA = "0x73F6BE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000260")]
			[Address(RVA = "0x73F59F8", Offset = "0x73F19F8", VA = "0x73F59F8")]
			[DebuggerHidden]
			public _003CFillCellsDetailData_003Ed__37(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0x73F6690", Offset = "0x73F2690", VA = "0x73F6690", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000262")]
			[Address(RVA = "0x73F6694", Offset = "0x73F2694", VA = "0x73F6694", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x73F6BA4", Offset = "0x73F2BA4", VA = "0x73F6BA4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000264")]
			[Address(RVA = "0x73F6BAC", Offset = "0x73F2BAC", VA = "0x73F6BAC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x73F6BE4", Offset = "0x73F2BE4", VA = "0x73F6BE4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class _003CFillCellsDetailDataCoroutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector4 coord;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GPUInstancerDetailManager _003C_003E4__this;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003CstartX_003E5__2;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int _003CendX_003E5__3;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003CendZ_003E5__4;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int _003CdetailMapSize_003E5__5;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int _003CheightMapSize_003E5__6;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private int _003Cz_003E5__7;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int _003Cx_003E5__8;

			[Token(Token = "0x1700001A")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000269")]
				[Address(RVA = "0x73F70A4", Offset = "0x73F30A4", VA = "0x73F70A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700001B")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600026B")]
				[Address(RVA = "0x73F70E4", Offset = "0x73F30E4", VA = "0x73F70E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x73F6138", Offset = "0x73F2138", VA = "0x73F6138")]
			[DebuggerHidden]
			public _003CFillCellsDetailDataCoroutine_003Ed__39(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x73F6BEC", Offset = "0x73F2BEC", VA = "0x73F6BEC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0x73F6BF0", Offset = "0x73F2BF0", VA = "0x73F6BF0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000269")]
			[Address(RVA = "0x73F70A4", Offset = "0x73F30A4", VA = "0x73F70A4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0x73F70AC", Offset = "0x73F30AC", VA = "0x73F70AC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600026B")]
			[Address(RVA = "0x73F70E4", Offset = "0x73F30E4", VA = "0x73F70E4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class _003CGenerateVisibilityBufferFromActiveCellsCoroutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GPUInstancerDetailManager _003C_003E4__this;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<GPUInstancerRuntimeData> _003CruntimeDatas_003E5__2;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003CtotalCount_003E5__3;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int _003Clastbreak_003E5__4;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003Cr_003E5__5;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private GPUInstancerRuntimeData _003Crd_003E5__6;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int _003CstartIndex_003E5__7;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private int _003Cc_003E5__8;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private GPUInstancerDetailCell _003CdetailCell_003E5__9;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int _003Ci_003E5__10;

			[Token(Token = "0x1700001C")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600026F")]
				[Address(RVA = "0x73F7884", Offset = "0x73F3884", VA = "0x73F7884", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700001D")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000271")]
				[Address(RVA = "0x73F78C4", Offset = "0x73F38C4", VA = "0x73F78C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x73F53E8", Offset = "0x73F13E8", VA = "0x73F53E8")]
			[DebuggerHidden]
			public _003CGenerateVisibilityBufferFromActiveCellsCoroutine_003Ed__27(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0x73F70EC", Offset = "0x73F30EC", VA = "0x73F70EC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0x73F70F0", Offset = "0x73F30F0", VA = "0x73F70F0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0x73F7884", Offset = "0x73F3884", VA = "0x73F7884", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000270")]
			[Address(RVA = "0x73F788C", Offset = "0x73F388C", VA = "0x73F788C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000271")]
			[Address(RVA = "0x73F78C4", Offset = "0x73F38C4", VA = "0x73F78C4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class _003CMergeVisibilityBufferFromActiveCellsCoroutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GPUInstancerDetailManager _003C_003E4__this;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<GPUInstancerRuntimeData> _003CruntimeDatas_003E5__2;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003CdetailMapSize_003E5__3;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int _003CheightMapSize_003E5__4;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003CdetailResolution_003E5__5;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int _003CheightmapResolution_003E5__6;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 _003CterrainSize_003E5__7;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private ComputeBuffer _003CheightMapBuffer_003E5__8;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private ComputeBuffer _003CdetailMapBuffer_003E5__9;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private GPUInstancerDetailCell _003CheightMapCell_003E5__10;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int _003CgeneratedBuffers_003E5__11;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private List<GPUInstancerCell>.Enumerator _003C_003E7__wrap11;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private GPUInstancerDetailCell _003Ccell_003E5__13;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private int _003Cr_003E5__14;

			[Token(Token = "0x1700001E")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000276")]
				[Address(RVA = "0x73F87A0", Offset = "0x73F47A0", VA = "0x73F87A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700001F")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000278")]
				[Address(RVA = "0x73F87E0", Offset = "0x73F47E0", VA = "0x73F87E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000272")]
			[Address(RVA = "0x73F5410", Offset = "0x73F1410", VA = "0x73F5410")]
			[DebuggerHidden]
			public _003CMergeVisibilityBufferFromActiveCellsCoroutine_003Ed__28(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000273")]
			[Address(RVA = "0x73F78CC", Offset = "0x73F38CC", VA = "0x73F78CC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x73F78E8", Offset = "0x73F38E8", VA = "0x73F78E8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0x73F8750", Offset = "0x73F4750", VA = "0x73F8750")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6000276")]
			[Address(RVA = "0x73F87A0", Offset = "0x73F47A0", VA = "0x73F87A0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0x73F87A8", Offset = "0x73F47A8", VA = "0x73F87A8", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000278")]
			[Address(RVA = "0x73F87E0", Offset = "0x73F47E0", VA = "0x73F87E0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class _003CSetInstanceDataForDetailCells_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GPUInstancerSpatialPartitioningData<GPUInstancerCell> spData;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<GPUInstancerPrototype> prototypeList;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int detailMapSize;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int heightMapSize;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int detailResolution;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int heightmapResolution;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector3 terrainSize;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public GPUInstancerTerrainSettings terrainSettings;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public ComputeBuffer counterBuffer;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public int[] counterData;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Action callback;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int _003CtotalCreated_003E5__2;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private List<GPUInstancerCell>.Enumerator _003C_003E7__wrap2;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private GPUInstancerDetailCell _003Ccell_003E5__4;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private int _003Ci_003E5__5;

			[Token(Token = "0x17000020")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600027D")]
				[Address(RVA = "0x73F8F7C", Offset = "0x73F4F7C", VA = "0x73F8F7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000021")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600027F")]
				[Address(RVA = "0x73F8FBC", Offset = "0x73F4FBC", VA = "0x73F8FBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0x73F59D0", Offset = "0x73F19D0", VA = "0x73F59D0")]
			[DebuggerHidden]
			public _003CSetInstanceDataForDetailCells_003Ed__32(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600027A")]
			[Address(RVA = "0x73F87E8", Offset = "0x73F47E8", VA = "0x73F87E8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0x73F8804", Offset = "0x73F4804", VA = "0x73F8804", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600027C")]
			[Address(RVA = "0x73F8F2C", Offset = "0x73F4F2C", VA = "0x73F8F2C")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x600027D")]
			[Address(RVA = "0x73F8F7C", Offset = "0x73F4F7C", VA = "0x73F8F7C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600027E")]
			[Address(RVA = "0x73F8F84", Offset = "0x73F4F84", VA = "0x73F8F84", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600027F")]
			[Address(RVA = "0x73F8FBC", Offset = "0x73F4FBC", VA = "0x73F8FBC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int detailLayer;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool runInThreads;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ComputeShader _grassInstantiationComputeShader;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private ComputeBuffer _generatingVisibilityBuffer;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ComputeBuffer _managedBuffer;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Matrix4x4[] _managedData;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool _triggerEvent;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private ComputeBuffer counterBuffer;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int[] counterData;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float[,] threadHeightMapData;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public List<int[,]> threadDetailMapData;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public int threadHeightResolution;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public int threadDetailResolution;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x73F14A0", Offset = "0x73ED4A0", VA = "0x73F14A0", Slot = "4")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x73F1594", Offset = "0x73ED594", VA = "0x73F1594", Slot = "11")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x73F172C", Offset = "0x73ED72C", VA = "0x73F172C", Slot = "10")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x73F1734", Offset = "0x73ED734", VA = "0x73F1734", Slot = "12")]
		public override void ClearInstancingData()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x73F1834", Offset = "0x73ED834", VA = "0x73F1834", Slot = "13")]
		public override void GeneratePrototypes(bool forceNew = false)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x73F199C", Offset = "0x73ED99C", VA = "0x73F199C", Slot = "14")]
		public override void InitializeRuntimeDataAndBuffers(bool forceNew = true)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x73F1B04", Offset = "0x73EDB04", VA = "0x73F1B04", Slot = "16")]
		public override void UpdateSpatialPartitioningCells(GPUInstancerCameraData renderingCameraData)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x73F1E0C", Offset = "0x73EDE0C", VA = "0x73F1E0C", Slot = "17")]
		public override void DeletePrototype(GPUInstancerPrototype prototype, bool removeSO = true)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x73F23E8", Offset = "0x73EE3E8", VA = "0x73F23E8", Slot = "18")]
		public override void RemoveInstancesInsideBounds(Bounds bounds, float offset, [Optional] List<GPUInstancerPrototype> prototypeFilter)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x73F2D10", Offset = "0x73EED10", VA = "0x73F2D10", Slot = "19")]
		public override void RemoveInstancesInsideCollider(Collider collider, float offset, [Optional] List<GPUInstancerPrototype> prototypeFilter)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x73F39C4", Offset = "0x73EF9C4", VA = "0x73F39C4", Slot = "20")]
		public override void SetGlobalPositionOffset(Vector3 offsetPosition)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x73F4164", Offset = "0x73F0164", VA = "0x73F4164")]
		private static int FixBounds(int value, int max, int failValue)
		{
			return default;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x73F4170", Offset = "0x73F0170", VA = "0x73F4170")]
		public static Matrix4x4[] GetInstanceDataForDetailPrototype(GPUInstancerDetailPrototype detailPrototype, int[] detailMap, float[] heightMapData, int detailMapSize, int heightMapSize, int detailResolution, int heightResolution, Vector3 startPosition, Vector3 terrainSize, int instanceCount)
		{
			return null;
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x73F48B4", Offset = "0x73F08B4", VA = "0x73F48B4")]
		private static Matrix4x4[] GetInstanceDataForDetailPrototypeWithComputeShader(GPUInstancerDetailPrototype detailPrototype, int[] detailMap, float[] heightMapData, int detailMapSize, int heightMapSize, int detailResolution, int heightResolution, Vector3 startPosition, Vector3 terrainSize, int instanceCount, ComputeShader grassInstantiationComputeShader, GPUInstancerTerrainSettings terrainSettings, ComputeBuffer counterBuffer, int[] counterData)
		{
			return null;
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x73F504C", Offset = "0x73F104C", VA = "0x73F504C")]
		private static ComputeBuffer GetComputeBufferForDetailPrototypeWithComputeShader(GPUInstancerDetailPrototype detailPrototype, int detailMapSize, int heightMapSize, int detailResolution, int heightResolution, Vector3 startPosition, Vector3 terrainSize, int instanceCount, ComputeShader grassInstantiationComputeShader, GPUInstancerTerrainSettings terrainSettings, ComputeBuffer heightMapBuffer, ComputeBuffer detailMapBuffer, ComputeBuffer counterBuffer, int[] counterData)
		{
			return null;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x73F4BE0", Offset = "0x73F0BE0", VA = "0x73F4BE0")]
		private static void DispatchDetailComputeShader(ComputeShader grassComputeShader, int grassInstantiationComputeKernelId, ComputeBuffer visibilityBuffer, ComputeBuffer detailMapBuffer, ComputeBuffer heightMapBuffer, Vector4 detailAndHeightMapSize, Vector3 startPosition, Vector3 terrainSize, int detailResolution, int heightResolution, Vector4 detailScale, Texture healthyDryNoiseTexture, float noiseSpread, int instanceID, float detailDensity, ComputeBuffer counterBuffer, float terrainNormalEffect)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x73F1CB0", Offset = "0x73EDCB0", VA = "0x73F1CB0")]
		private void StartCoroutineAlt(IEnumerator routine)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x73F5260", Offset = "0x73F1260", VA = "0x73F5260", Slot = "15")]
		public override void InitializeSpatialPartitioning()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x73F1C50", Offset = "0x73EDC50", VA = "0x73F1C50")]
		[IteratorStateMachine(typeof(_003CGenerateVisibilityBufferFromActiveCellsCoroutine_003Ed__27))]
		private IEnumerator GenerateVisibilityBufferFromActiveCellsCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x73F1DAC", Offset = "0x73EDDAC", VA = "0x73F1DAC")]
		[IteratorStateMachine(typeof(_003CMergeVisibilityBufferFromActiveCellsCoroutine_003Ed__28))]
		private IEnumerator MergeVisibilityBufferFromActiveCellsCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x73F5330", Offset = "0x73F1330", VA = "0x73F5330")]
		private void GenerateCellsInstanceDataFromTerrain()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x73F54A4", Offset = "0x73F14A4", VA = "0x73F54A4")]
		public void FillCellsDetailDataCallBack()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x73F5838", Offset = "0x73F1838", VA = "0x73F5838")]
		private void SetInstanceDataForDetailCellsCallback()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x73F5760", Offset = "0x73F1760", VA = "0x73F5760")]
		[IteratorStateMachine(typeof(_003CSetInstanceDataForDetailCells_003Ed__32))]
		private static IEnumerator SetInstanceDataForDetailCells(GPUInstancerSpatialPartitioningData<GPUInstancerCell> spData, List<GPUInstancerPrototype> prototypeList, int detailMapSize, int heightMapSize, int detailResolution, int heightmapResolution, Vector3 terrainSize, ComputeBuffer counterBuffer, int[] counterData, GPUInstancerTerrainSettings terrainSettings, Action callback)
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x73F5438", Offset = "0x73F1438", VA = "0x73F5438")]
		[IteratorStateMachine(typeof(_003CFillCellsDetailData_003Ed__37))]
		public IEnumerator FillCellsDetailData(Terrain terrain)
		{
			return null;
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x73F5A20", Offset = "0x73F1A20", VA = "0x73F5A20")]
		public void FillCellsDetailDataThread(object parameter)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x73F60B0", Offset = "0x73F20B0", VA = "0x73F60B0")]
		[IteratorStateMachine(typeof(_003CFillCellsDetailDataCoroutine_003Ed__39))]
		public IEnumerator FillCellsDetailDataCoroutine(Vector4 coord)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x73F6160", Offset = "0x73F2160", VA = "0x73F6160")]
		public void SetDetailMapData(List<int[,]> detailMapData)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x73F6168", Offset = "0x73F2168", VA = "0x73F6168")]
		public int[,] GetDetailLayer(int layer)
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x73F64B4", Offset = "0x73F24B4", VA = "0x73F64B4")]
		public List<int[,]> GetDetailMapData()
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x73F6638", Offset = "0x73F2638", VA = "0x73F6638")]
		public GPUInstancerDetailManager()
		{
		}
	}
}
