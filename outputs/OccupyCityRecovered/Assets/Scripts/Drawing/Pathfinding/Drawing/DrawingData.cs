using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;
using Pathfinding.Drawing.Text;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x200002C")]
	public class DrawingData
	{
		[Token(Token = "0x200002D")]
		public struct Hasher : IEquatable<Hasher>
		{
			[Token(Token = "0x40000A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ulong hash;

			[Token(Token = "0x1700000F")]
			public static Hasher NotSupplied
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x46E2548", Offset = "0x46DE548", VA = "0x46E2548")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000010")]
			public readonly ulong Hash
			{
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x46E2550", Offset = "0x46DE550", VA = "0x46E2550")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60001E9")]
			[Obsolete("Use the constructor instead")]
			public static Hasher Create<T>(T init)
			{
				return default;
			}

			[Token(Token = "0x60001EA")]
			public void Add<T>(T hash)
			{
			}

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x46E2558", Offset = "0x46DE558", VA = "0x46E2558", Slot = "2")]
			public override int GetHashCode()
			{
				return default;
			}

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x46E2560", Offset = "0x46DE560", VA = "0x46E2560", Slot = "4")]
			public bool Equals(Hasher other)
			{
				return default;
			}
		}

		[Token(Token = "0x200002E")]
		internal struct ProcessedBuilderData
		{
			[Token(Token = "0x200002F")]
			public enum Type
			{
				[Token(Token = "0x40000B2")]
				Invalid = 0,
				[Token(Token = "0x40000B3")]
				Static = 1,
				[Token(Token = "0x40000B4")]
				Dynamic = 2,
				[Token(Token = "0x40000B5")]
				Persistent = 3
			}

			[Token(Token = "0x2000030")]
			public struct CapturedState
			{
				[Token(Token = "0x40000B6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public Matrix4x4 matrix;

				[Token(Token = "0x40000B7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public Color color;
			}

			[Token(Token = "0x2000031")]
			public struct MeshBuffers
			{
				[Token(Token = "0x40000B8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public UnsafeAppendBuffer splitterOutput;

				[Token(Token = "0x40000B9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public UnsafeAppendBuffer vertices;

				[Token(Token = "0x40000BA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public UnsafeAppendBuffer triangles;

				[Token(Token = "0x40000BB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public UnsafeAppendBuffer solidVertices;

				[Token(Token = "0x40000BC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				public UnsafeAppendBuffer solidTriangles;

				[Token(Token = "0x40000BD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				public UnsafeAppendBuffer textVertices;

				[Token(Token = "0x40000BE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				public UnsafeAppendBuffer textTriangles;

				[Token(Token = "0x40000BF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
				public UnsafeAppendBuffer capturedState;

				[Token(Token = "0x40000C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
				public Bounds bounds;

				[Token(Token = "0x60001FB")]
				[Address(RVA = "0x46E26F8", Offset = "0x46DE6F8", VA = "0x46E26F8")]
				public MeshBuffers(Allocator allocator)
				{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DrawingData.ProcessedBuilderData.MeshBuffers..ctor RVA=0x46E26F8 Token=0x60001FB");
}

				[Token(Token = "0x60001FC")]
				[Address(RVA = "0x46E3B08", Offset = "0x46DFB08", VA = "0x46E3B08")]
				public void Dispose()
				{
				}

				[Token(Token = "0x60001FD")]
				[Address(RVA = "0x46E3B70", Offset = "0x46DFB70", VA = "0x46E3B70")]
				private static void DisposeIfLarge(ref UnsafeAppendBuffer ls)
				{
				}

				[Token(Token = "0x60001FE")]
				[Address(RVA = "0x46E39E0", Offset = "0x46DF9E0", VA = "0x46E39E0")]
				public void DisposeIfLarge()
				{
				}
			}

			[Token(Token = "0x40000A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Type type;

			[Token(Token = "0x40000AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public BuilderData.Meta meta;

			[Token(Token = "0x40000AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private bool submitted;

			[Token(Token = "0x40000AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public NativeArray<MeshBuffers> temporaryMeshBuffers;

			[Token(Token = "0x40000AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private JobHandle buildJob;

			[Token(Token = "0x40000AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private JobHandle splitterJob;

			[Token(Token = "0x40000AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public List<MeshWithType> meshes;

			[Token(Token = "0x40000B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int SubmittedJobs;

			[Token(Token = "0x17000011")]
			public bool isValid
			{
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x46E2570", Offset = "0x46DE570", VA = "0x46E2570")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000012")]
			public unsafe UnsafeAppendBuffer* splitterOutputPtr
			{
				[Token(Token = "0x60001EF")]
				[Address(RVA = "0x46E2580", Offset = "0x46DE580", VA = "0x46E2580")]
				get
				{
					//IL_0002: Expected I, but got O
					throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DrawingData.ProcessedBuilderData.splitterOutputPtr RVA=0x46E2580");
				}
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x46E25D4", Offset = "0x46DE5D4", VA = "0x46E25D4")]
			public void Init(Type type, BuilderData.Meta meta)
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x46E2900", Offset = "0x46DE900", VA = "0x46E2900")]
			public void SetSplitterJob(DrawingData gizmos, JobHandle splitterJob)
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x46E2E28", Offset = "0x46DEE28", VA = "0x46E2E28")]
			public void SchedulePersistFilter(int version, int lastTickVersion, float time, int sceneModeVersion)
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x46E2F58", Offset = "0x46DEF58", VA = "0x46E2F58")]
			public bool IsValidForCamera(Camera camera, bool allowGizmos, bool allowCameraDefault)
			{
				return default;
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x46E2FE4", Offset = "0x46DEFE4", VA = "0x46E2FE4")]
			public void Schedule(DrawingData gizmos, ref GeometryBuilder.CameraInfo cameraInfo)
			{
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x46E3064", Offset = "0x46DF064", VA = "0x46E3064")]
			public void BuildMeshes(DrawingData gizmos)
			{
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x46E349C", Offset = "0x46DF49C", VA = "0x46E349C")]
			public void CollectMeshes(List<RenderedMeshWithType> meshes)
			{
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x46E3710", Offset = "0x46DF710", VA = "0x46E3710")]
			private void PoolMeshes(DrawingData gizmos, bool includeCustom)
			{
			}

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x46E38A4", Offset = "0x46DF8A4", VA = "0x46E38A4")]
			public void PoolDynamicMeshes(DrawingData gizmos)
			{
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x46E38C4", Offset = "0x46DF8C4", VA = "0x46E38C4")]
			public void Release(DrawingData gizmos)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x46E3A28", Offset = "0x46DFA28", VA = "0x46E3A28")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x2000032")]
		internal struct SubmittedMesh
		{
			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Mesh mesh;

			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool temporary;
		}

		[Token(Token = "0x2000033")]
		[BurstCompile]
		internal struct BuilderData : IDisposable
		{
			[Token(Token = "0x2000034")]
			public enum State
			{
				[Token(Token = "0x40000D1")]
				Free = 0,
				[Token(Token = "0x40000D2")]
				Reserved = 1,
				[Token(Token = "0x40000D3")]
				Initialized = 2,
				[Token(Token = "0x40000D4")]
				WaitingForSplitter = 3,
				[Token(Token = "0x40000D5")]
				WaitingForUserDefinedJob = 4
			}

			[Token(Token = "0x2000035")]
			public struct Meta
			{
				[Token(Token = "0x40000D6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public Hasher hasher;

				[Token(Token = "0x40000D7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public RedrawScope redrawScope1;

				[Token(Token = "0x40000D8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public RedrawScope redrawScope2;

				[Token(Token = "0x40000D9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public int version;

				[Token(Token = "0x40000DA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				public bool isGizmos;

				[Token(Token = "0x40000DB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public int sceneModeVersion;

				[Token(Token = "0x40000DC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
				public int drawOrderIndex;

				[Token(Token = "0x40000DD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public Camera[] cameraTargets;
			}

			[Token(Token = "0x2000036")]
			public struct BitPackedMeta
			{
				[Token(Token = "0x40000DE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private uint flags;

				[Token(Token = "0x40000DF")]
				private const int UniqueIDBitshift = 17;

				[Token(Token = "0x40000E0")]
				private const int IsBuiltInFlagIndex = 16;

				[Token(Token = "0x40000E1")]
				private const int IndexMask = 65535;

				[Token(Token = "0x40000E2")]
				private const int MaxDataIndex = 65535;

				[Token(Token = "0x40000E3")]
				public const int UniqueIdMask = 32767;

				[Token(Token = "0x17000015")]
				public int dataIndex
				{
					[Token(Token = "0x6000210")]
					[Address(RVA = "0x46E53EC", Offset = "0x46E13EC", VA = "0x46E53EC")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000016")]
				public int uniqueID
				{
					[Token(Token = "0x6000211")]
					[Address(RVA = "0x46E53F4", Offset = "0x46E13F4", VA = "0x46E53F4")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000017")]
				public bool isBuiltInCommandBuilder
				{
					[Token(Token = "0x6000212")]
					[Address(RVA = "0x46E5400", Offset = "0x46E1400", VA = "0x46E5400")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x600020F")]
				[Address(RVA = "0x46E3DAC", Offset = "0x46DFDAC", VA = "0x46E3DAC")]
				public BitPackedMeta(int dataIndex, int uniqueID, bool isBuiltInCommandBuilder)
				{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DrawingData.BuilderData.BitPackedMeta..ctor RVA=0x46E3DAC Token=0x600020F");
}

				[Token(Token = "0x6000213")]
				[Address(RVA = "0x46E540C", Offset = "0x46E140C", VA = "0x46E540C")]
				public static bool operator ==(BitPackedMeta lhs, BitPackedMeta rhs)
				{
					return default;
				}

				[Token(Token = "0x6000214")]
				[Address(RVA = "0x46E5418", Offset = "0x46E1418", VA = "0x46E5418")]
				public static bool operator !=(BitPackedMeta lhs, BitPackedMeta rhs)
				{
					return default;
				}

				[Token(Token = "0x6000215")]
				[Address(RVA = "0x46E5424", Offset = "0x46E1424", VA = "0x46E5424", Slot = "0")]
				public override bool Equals(object obj)
				{
					return default;
				}

				[Token(Token = "0x6000216")]
				[Address(RVA = "0x46E549C", Offset = "0x46E149C", VA = "0x46E549C", Slot = "2")]
				public override int GetHashCode()
				{
					return default;
				}
			}

			[Token(Token = "0x2000037")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			private unsafe delegate bool AnyBuffersWrittenToDelegate(UnsafeAppendBuffer* buffers, int numBuffers);

			[Token(Token = "0x2000038")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			private unsafe delegate void ResetAllBuffersToDelegate(UnsafeAppendBuffer* buffers, int numBuffers);

			[Token(Token = "0x2000039")]
			public unsafe delegate bool AnyBuffersWrittenTo_000001EA_0024PostfixBurstDelegate(UnsafeAppendBuffer* buffers, int numBuffers);

			[Token(Token = "0x200003A")]
			internal static class AnyBuffersWrittenTo_000001EA_0024BurstDirectCall
			{
				[Token(Token = "0x40000E4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x40000E5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation;

				[Token(Token = "0x6000223")]
				[Address(RVA = "0x46E5798", Offset = "0x46E1798", VA = "0x46E5798")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
				}

				[Token(Token = "0x6000224")]
				[Address(RVA = "0x46E58B4", Offset = "0x46E18B4", VA = "0x46E58B4")]
				private static IntPtr GetFunctionPointer()
				{
					return default;
				}

				[Token(Token = "0x6000225")]
				[Address(RVA = "0x46E5910", Offset = "0x46E1910", VA = "0x46E5910")]
				public static void Constructor()
				{
				}

				[Token(Token = "0x6000226")]
				[Address(RVA = "0x46E59B8", Offset = "0x46E19B8", VA = "0x46E59B8")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x6000228")]
				[Address(RVA = "0x46E4090", Offset = "0x46E0090", VA = "0x46E4090")]
				public unsafe static bool Invoke(UnsafeAppendBuffer* buffers, int numBuffers)
				{
					return default;
				}
			}

			[Token(Token = "0x200003B")]
			public unsafe delegate void ResetAllBuffers_000001EB_0024PostfixBurstDelegate(UnsafeAppendBuffer* buffers, int numBuffers);

			[Token(Token = "0x200003C")]
			internal static class ResetAllBuffers_000001EB_0024BurstDirectCall
			{
				[Token(Token = "0x40000E6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x40000E7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation;

				[Token(Token = "0x600022D")]
				[Address(RVA = "0x46E5B14", Offset = "0x46E1B14", VA = "0x46E5B14")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
				}

				[Token(Token = "0x600022E")]
				[Address(RVA = "0x46E5C30", Offset = "0x46E1C30", VA = "0x46E5C30")]
				private static IntPtr GetFunctionPointer()
				{
					return default;
				}

				[Token(Token = "0x600022F")]
				[Address(RVA = "0x46E5C8C", Offset = "0x46E1C8C", VA = "0x46E5C8C")]
				public static void Constructor()
				{
				}

				[Token(Token = "0x6000230")]
				[Address(RVA = "0x46E5D34", Offset = "0x46E1D34", VA = "0x46E5D34")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x6000232")]
				[Address(RVA = "0x46E41A4", Offset = "0x46E01A4", VA = "0x46E41A4")]
				public unsafe static void Invoke(UnsafeAppendBuffer* buffers, int numBuffers)
				{
				}
			}

			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BitPackedMeta packedMeta;

			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<SubmittedMesh> meshes;

			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NativeArray<UnsafeAppendBuffer> commandBuffers;

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool preventDispose;

			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private JobHandle splitterJob;

			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private JobHandle disposeDependency;

			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private AllowedDelay disposeDependencyDelay;

			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private GCHandle disposeGCHandle;

			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Meta meta;

			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int UniqueIDCounter;

			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static readonly AnyBuffersWrittenToDelegate AnyBuffersWrittenToInvoke;

			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static readonly ResetAllBuffersToDelegate ResetAllBuffersToInvoke;

			[Token(Token = "0x17000013")]
			public State state
			{
				[Token(Token = "0x60001FF")]
				[Address(RVA = "0x46E3CAC", Offset = "0x46DFCAC", VA = "0x46E3CAC")]
				[CompilerGenerated]
				readonly get
				{
					return default;
				}
				[Token(Token = "0x6000200")]
				[Address(RVA = "0x46E3CB4", Offset = "0x46DFCB4", VA = "0x46E3CB4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000014")]
			public unsafe UnsafeAppendBuffer* bufferPtr
			{
				[Token(Token = "0x6000203")]
				[Address(RVA = "0x46E4048", Offset = "0x46E0048", VA = "0x46E4048")]
				get
				{
					//IL_0002: Expected I, but got O
					throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DrawingData.BuilderData.bufferPtr RVA=0x46E4048");
				}
			}

			[Token(Token = "0x6000201")]
			[Address(RVA = "0x46E3CBC", Offset = "0x46DFCBC", VA = "0x46E3CBC")]
			public void Reserve(int dataIndex, bool isBuiltInCommandBuilder)
			{
			}

			[Token(Token = "0x6000202")]
			[Address(RVA = "0x46E3E20", Offset = "0x46DFE20", VA = "0x46E3E20")]
			public void Init(Hasher hasher, RedrawScope frameRedrawScope, RedrawScope customRedrawScope, bool isGizmos, int drawOrderIndex, int sceneModeVersion)
			{
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0x46E3BE4", Offset = "0x46DFBE4", VA = "0x46E3BE4")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(AnyBuffersWrittenToDelegate))]
			private unsafe static bool AnyBuffersWrittenTo(UnsafeAppendBuffer* buffers, int numBuffers)
			{
				return default;
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x46E3C48", Offset = "0x46DFC48", VA = "0x46E3C48")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(AnyBuffersWrittenToDelegate))]
			private unsafe static void ResetAllBuffers(UnsafeAppendBuffer* buffers, int numBuffers)
			{
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x46E429C", Offset = "0x46E029C", VA = "0x46E429C")]
			public void SubmitWithDependency(GCHandle gcHandle, JobHandle dependency, AllowedDelay allowedDelay)
			{
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0x46E4320", Offset = "0x46E0320", VA = "0x46E4320")]
			public void Submit(DrawingData gizmos)
			{
			}

			[Token(Token = "0x6000208")]
			[Address(RVA = "0x46E4CB0", Offset = "0x46E0CB0", VA = "0x46E4CB0")]
			public void CheckJobDependency(DrawingData gizmos, bool allowBlocking)
			{
			}

			[Token(Token = "0x6000209")]
			[Address(RVA = "0x46E4798", Offset = "0x46E0798", VA = "0x46E4798")]
			public void Release()
			{
			}

			[Token(Token = "0x600020A")]
			[Address(RVA = "0x46E4D88", Offset = "0x46E0D88", VA = "0x46E4D88")]
			private void ClearData()
			{
			}

			[Token(Token = "0x600020B")]
			[Address(RVA = "0x46E4E7C", Offset = "0x46E0E7C", VA = "0x46E4E7C", Slot = "4")]
			public void Dispose()
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x46E5364", Offset = "0x46E1364", VA = "0x46E5364")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(AnyBuffersWrittenToDelegate))]
			public unsafe static bool AnyBuffersWrittenTo_0024BurstManaged(UnsafeAppendBuffer* buffers, int numBuffers)
			{
				return default;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x46E53B0", Offset = "0x46E13B0", VA = "0x46E53B0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(AnyBuffersWrittenToDelegate))]
			public unsafe static void ResetAllBuffers_0024BurstManaged(UnsafeAppendBuffer* buffers, int numBuffers)
			{
			}
		}

		[Token(Token = "0x200003D")]
		internal struct BuilderDataContainer : IDisposable
		{
			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private BuilderData[] data;

			[Token(Token = "0x17000018")]
			public int memoryUsage
			{
				[Token(Token = "0x6000233")]
				[Address(RVA = "0x46E5D3C", Offset = "0x46E1D3C", VA = "0x46E5D3C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000234")]
			[Address(RVA = "0x46E5DC4", Offset = "0x46E1DC4", VA = "0x46E5DC4")]
			public BuilderData.BitPackedMeta Reserve(bool isBuiltInCommandBuilder)
			{
				return default;
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0x46E5F38", Offset = "0x46E1F38", VA = "0x46E5F38")]
			public void Release(BuilderData.BitPackedMeta meta)
			{
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0x46E5FB8", Offset = "0x46E1FB8", VA = "0x46E5FB8")]
			public bool StillExists(BuilderData.BitPackedMeta meta)
			{
				return default;
			}

			[Token(Token = "0x6000237")]
			[Address(RVA = "0x46E6000", Offset = "0x46E2000", VA = "0x46E6000")]
			public unsafe ref BuilderData Get(BuilderData.BitPackedMeta meta)
			{
				throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DrawingData.BuilderDataContainer.Get RVA=0x46E6000");
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x46E6120", Offset = "0x46E2120", VA = "0x46E6120")]
			public void DisposeCommandBuildersWithJobDependencies(DrawingData gizmos)
			{
			}

			[Token(Token = "0x6000239")]
			[Address(RVA = "0x46E6230", Offset = "0x46E2230", VA = "0x46E6230")]
			public void ReleaseAllUnused()
			{
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x46E6304", Offset = "0x46E2304", VA = "0x46E6304", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x200003E")]
		internal struct ProcessedBuilderDataContainer
		{
			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ProcessedBuilderData[] data;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Dictionary<ulong, List<int>> hash2index;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Stack<int> freeSlots;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Stack<List<int>> freeLists;

			[Token(Token = "0x17000019")]
			public bool isEmpty
			{
				[Token(Token = "0x600023B")]
				[Address(RVA = "0x46E63B4", Offset = "0x46E23B4", VA = "0x46E63B4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700001A")]
			public int memoryUsage
			{
				[Token(Token = "0x600023C")]
				[Address(RVA = "0x46E6418", Offset = "0x46E2418", VA = "0x46E6418")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600023D")]
			[Address(RVA = "0x46E483C", Offset = "0x46E083C", VA = "0x46E483C")]
			public int Reserve(ProcessedBuilderData.Type type, BuilderData.Meta meta)
			{
				return default;
			}

			[Token(Token = "0x600023E")]
			[Address(RVA = "0x46E4C44", Offset = "0x46E0C44", VA = "0x46E4C44")]
			public unsafe ref ProcessedBuilderData Get(int index)
			{
				throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DrawingData.ProcessedBuilderDataContainer.Get RVA=0x46E4C44");
			}

			[Token(Token = "0x600023F")]
			[Address(RVA = "0x46E6660", Offset = "0x46E2660", VA = "0x46E6660")]
			private void Release(DrawingData gizmos, int i)
			{
			}

			[Token(Token = "0x6000240")]
			[Address(RVA = "0x46E67EC", Offset = "0x46E27EC", VA = "0x46E67EC")]
			public void SubmitMeshes(DrawingData gizmos, Camera camera, int versionThreshold, bool allowGizmos, bool allowCameraDefault)
			{
			}

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x46E6980", Offset = "0x46E2980", VA = "0x46E6980")]
			public void PoolDynamicMeshes(DrawingData gizmos)
			{
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0x46E6A0C", Offset = "0x46E2A0C", VA = "0x46E6A0C")]
			public void CollectMeshes(int versionThreshold, List<RenderedMeshWithType> meshes, Camera camera, bool allowGizmos, bool allowCameraDefault)
			{
			}

			[Token(Token = "0x6000243")]
			[Address(RVA = "0x46E6AE0", Offset = "0x46E2AE0", VA = "0x46E6AE0")]
			public void FilterOldPersistentCommands(int version, int lastTickVersion, float time, int sceneModeVersion)
			{
			}

			[Token(Token = "0x6000244")]
			[Address(RVA = "0x46E6B80", Offset = "0x46E2B80", VA = "0x46E6B80")]
			public bool SetVersion(Hasher hasher, int version)
			{
				return default;
			}

			[Token(Token = "0x6000245")]
			[Address(RVA = "0x46E6C84", Offset = "0x46E2C84", VA = "0x46E6C84")]
			public bool SetVersion(RedrawScope scope, int version)
			{
				return default;
			}

			[Token(Token = "0x6000246")]
			[Address(RVA = "0x46E6D08", Offset = "0x46E2D08", VA = "0x46E6D08")]
			public bool SetCustomScope(Hasher hasher, RedrawScope scope)
			{
				return default;
			}

			[Token(Token = "0x6000247")]
			[Address(RVA = "0x46E6E10", Offset = "0x46E2E10", VA = "0x46E6E10")]
			public void ReleaseDataOlderThan(DrawingData gizmos, int version)
			{
			}

			[Token(Token = "0x6000248")]
			[Address(RVA = "0x46E6E9C", Offset = "0x46E2E9C", VA = "0x46E6E9C")]
			public void ReleaseAllWithHash(DrawingData gizmos, Hasher hasher)
			{
			}

			[Token(Token = "0x6000249")]
			[Address(RVA = "0x46E6F28", Offset = "0x46E2F28", VA = "0x46E6F28")]
			public void Dispose(DrawingData gizmos)
			{
			}
		}

		[Token(Token = "0x200003F")]
		[Flags]
		internal enum MeshType
		{
			[Token(Token = "0x40000EE")]
			Solid = 1,
			[Token(Token = "0x40000EF")]
			Lines = 2,
			[Token(Token = "0x40000F0")]
			Text = 4,
			[Token(Token = "0x40000F1")]
			Custom = 8,
			[Token(Token = "0x40000F2")]
			Pool = 0x10,
			[Token(Token = "0x40000F3")]
			BaseType = Solid | Lines | Text
		}

		[Token(Token = "0x2000040")]
		internal struct MeshWithType
		{
			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Mesh mesh;

			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MeshType type;
		}

		[Token(Token = "0x2000041")]
		internal struct RenderedMeshWithType
		{
			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Mesh mesh;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MeshType type;

			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int drawingOrderIndex;

			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color color;

			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Matrix4x4 matrix;
		}

		[Token(Token = "0x2000042")]
		private struct Range
		{
			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int start;

			[Token(Token = "0x40000FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int end;
		}

		[Token(Token = "0x2000043")]
		public struct CommandBufferWrapper
		{
			[Token(Token = "0x40000FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CommandBuffer cmd;

			[Token(Token = "0x600024A")]
			[Address(RVA = "0x46E6FC0", Offset = "0x46E2FC0", VA = "0x46E6FC0")]
			public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
			{
			}
		}

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal BuilderDataContainer data;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal ProcessedBuilderDataContainer processedData;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<RenderedMeshWithType> meshes;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Mesh> cachedMeshes;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Mesh> stagingCachedMeshes;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int lastTimeLargestCachedMeshWasUsed;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal SDFLookupData fontData;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int currentDrawOrderIndex;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		internal int sceneModeVersion;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Material surfaceMaterial;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Material lineMaterial;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Material textMaterial;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DrawingSettings.Settings settings;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int lastTickVersion;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int lastTickVersion2;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Dictionary<int, GameObject> persistentRedrawScopes;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal GCHandle gizmosHandle;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public RedrawScope frameRedrawScope;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Dictionary<Camera, Range> cameraVersions;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly ProfilerMarker MarkerScheduleJobs;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly ProfilerMarker MarkerAwaitUserDependencies;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly ProfilerMarker MarkerSchedule;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static readonly ProfilerMarker MarkerBuild;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static readonly ProfilerMarker MarkerPool;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal static readonly ProfilerMarker MarkerRelease;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal static readonly ProfilerMarker MarkerBuildMeshes;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal static readonly ProfilerMarker MarkerCollectMeshes;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal static readonly ProfilerMarker MarkerSortMeshes;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal static readonly ProfilerMarker LeakTracking;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly Comparison<RenderedMeshWithType> meshSorter;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Plane[] frustrumPlanes;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private MaterialPropertyBlock customMaterialProperties;

		[Token(Token = "0x1700000A")]
		private int adjustedSceneModeVersion
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x46DEAE4", Offset = "0x46DAAE4", VA = "0x46DEAE4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000B")]
		private static float CurrentTime
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x46DEDBC", Offset = "0x46DADBC", VA = "0x46DEDBC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000C")]
		public DrawingSettings.Settings settingsRef
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x46DF240", Offset = "0x46DB240", VA = "0x46DF240")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public int version
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x46DF260", Offset = "0x46DB260", VA = "0x46DF260")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x46DF268", Offset = "0x46DB268", VA = "0x46DF268")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		private int totalMemoryUsage
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x46DF960", Offset = "0x46DB960", VA = "0x46DF960")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x46C6E68", Offset = "0x46C2E68", VA = "0x46C6E68")]
		internal int GetNextDrawOrderIndex()
		{
			return default;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x46DEB50", Offset = "0x46DAB50", VA = "0x46DEB50")]
		internal void PoolMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x46DEBF4", Offset = "0x46DABF4", VA = "0x46DEBF4")]
		private void SortPooledMeshes()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x46CCD3C", Offset = "0x46C8D3C", VA = "0x46CCD3C")]
		internal Mesh GetMesh(int desiredVertexCount)
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x46DECF0", Offset = "0x46DACF0", VA = "0x46DECF0")]
		internal void LoadFontDataIfNecessary()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x46DEE28", Offset = "0x46DAE28", VA = "0x46DEE28")]
		private static void UpdateTime()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x46DEECC", Offset = "0x46DAECC", VA = "0x46DEECC")]
		public CommandBuilder GetBuilder(bool renderInGame = false)
		{
			return default;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x46DEF90", Offset = "0x46DAF90", VA = "0x46DEF90")]
		internal CommandBuilder GetBuiltInBuilder(bool renderInGame = false)
		{
			return default;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x46DF058", Offset = "0x46DB058", VA = "0x46DF058")]
		public CommandBuilder GetBuilder(RedrawScope redrawScope, bool renderInGame = false)
		{
			return default;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x46DF12C", Offset = "0x46DB12C", VA = "0x46DF12C")]
		public CommandBuilder GetBuilder(Hasher hasher, [Optional] RedrawScope redrawScope, bool renderInGame = false)
		{
			return default;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x46DE768", Offset = "0x46DA768", VA = "0x46DE768")]
		public GameObject GetAssociatedGameObject(RedrawScope scope)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x46DF228", Offset = "0x46DB228", VA = "0x46DF228")]
		private void DiscardData(Hasher hasher)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x46DF270", Offset = "0x46DB270", VA = "0x46DF270")]
		internal void OnChangingPlayMode()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x46DF280", Offset = "0x46DB280", VA = "0x46DF280")]
		public bool Draw(Hasher hasher)
		{
			return default;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x46DF318", Offset = "0x46DB318", VA = "0x46DF318")]
		public bool Draw(Hasher hasher, RedrawScope scope)
		{
			return default;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x46DE5D8", Offset = "0x46DA5D8", VA = "0x46DE5D8")]
		internal void Draw(RedrawScope scope)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x46DE91C", Offset = "0x46DA91C", VA = "0x46DE91C")]
		internal void DrawUntilDisposed(RedrawScope scope, GameObject associatedGameObject)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x46DE9E0", Offset = "0x46DA9E0", VA = "0x46DE9E0")]
		internal void DisposeRedrawScope(RedrawScope scope)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x46DF414", Offset = "0x46DB414", VA = "0x46DF414")]
		private void RefreshRedrawScopes()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x46DF56C", Offset = "0x46DB56C", VA = "0x46DF56C")]
		private void CleanupOldCameras()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x46DF6FC", Offset = "0x46DB6FC", VA = "0x46DF6FC")]
		public void DisposeCommandBuildersWithJobDependencies()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x46DF70C", Offset = "0x46DB70C", VA = "0x46DF70C")]
		public void TickFramePreRender()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x46DF90C", Offset = "0x46DB90C", VA = "0x46DF90C")]
		public void PostRenderCleanup()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x46DF934", Offset = "0x46DB934", VA = "0x46DF934")]
		private static int MeshCompareByDrawingOrder(RenderedMeshWithType a, RenderedMeshWithType b)
		{
			return default;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x46DF998", Offset = "0x46DB998", VA = "0x46DF998")]
		private void LoadMaterials()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x46DFB24", Offset = "0x46DBB24", VA = "0x46DFB24")]
		public DrawingData()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x46DFD04", Offset = "0x46DBD04", VA = "0x46DFD04")]
		private static int CeilLog2(int x)
		{
			return default;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x46DFDC4", Offset = "0x46DBDC4", VA = "0x46DFDC4")]
		public void Render(Camera cam, bool allowGizmos, CommandBufferWrapper commandBuffer, bool allowCameraDefault)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x46E059C", Offset = "0x46DC59C", VA = "0x46E059C")]
		private static Bounds TransformBoundingBox(Matrix4x4 matrix, Bounds bounds)
		{
			return default;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x46E0A40", Offset = "0x46DCA40", VA = "0x46E0A40")]
		public void ClearData()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x46E0E3C", Offset = "0x46DCE3C", VA = "0x46E0E3C")]
		public static void Initialize_0024BuilderData_AnyBuffersWrittenTo_000001EA_0024BurstDirectCall()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x46E0E8C", Offset = "0x46DCE8C", VA = "0x46E0E8C")]
		public static void Initialize_0024BuilderData_ResetAllBuffers_000001EB_0024BurstDirectCall()
		{
		}
	}
}
