using Il2CppDummyDll;
using Pathfinding.PID;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000300")]
	public struct MovementState : IComponentData, IQueryTypeParameter
	{
		[Token(Token = "0x4000DBD")]
		[FieldOffset(Offset = "0x0")]
		public PIDMovement.PersistentState followerState;

		[Token(Token = "0x4000DBE")]
		[FieldOffset(Offset = "0x4")]
		public float3 nextCorner;

		[Token(Token = "0x4000DBF")]
		[FieldOffset(Offset = "0x10")]
		public float3 endOfPath;

		[Token(Token = "0x4000DC0")]
		[FieldOffset(Offset = "0x1C")]
		public float3 closestOnNavmesh;

		[Token(Token = "0x4000DC1")]
		[FieldOffset(Offset = "0x28")]
		public float3 positionOffset;

		[Token(Token = "0x4000DC2")]
		[FieldOffset(Offset = "0x34")]
		public int hierarchicalNodeIndex;

		[Token(Token = "0x4000DC3")]
		[FieldOffset(Offset = "0x38")]
		public float remainingDistanceToEndOfPart;

		[Token(Token = "0x4000DC4")]
		[FieldOffset(Offset = "0x3C")]
		public float rotationOffset;

		[Token(Token = "0x4000DC5")]
		[FieldOffset(Offset = "0x40")]
		public float rotationOffset2;

		[Token(Token = "0x4000DC6")]
		[FieldOffset(Offset = "0x44")]
		public ushort pathTracerVersion;

		[Token(Token = "0x4000DC7")]
		[FieldOffset(Offset = "0x46")]
		private ushort flags;

		[Token(Token = "0x4000DC8")]
		private const int ReachedDestinationFlag = 1;

		[Token(Token = "0x4000DC9")]
		private const int reachedDestinationAndOrientationFlag = 2;

		[Token(Token = "0x4000DCA")]
		private const int ReachedEndOfPathFlag = 4;

		[Token(Token = "0x4000DCB")]
		private const int reachedEndOfPathAndOrientationFlag = 8;

		[Token(Token = "0x4000DCC")]
		private const int ReachedEndOfPartFlag = 16;

		[Token(Token = "0x4000DCD")]
		private const int TraversingLastPartFlag = 32;

		[Token(Token = "0x4000DCE")]
		private const int HasValidEndPointFlag = 64;

		[Token(Token = "0x4000DCF")]
		private const int GraphIndexOffsetInFlags = 8;

		[Token(Token = "0x4000DD0")]
		private const ushort GraphIndexMaskInFlags = 65280;

		[Token(Token = "0x1700030F")]
		public bool reachedDestination
		{
			[Token(Token = "0x60012DE")]
			[Address(RVA = "0x44B59B4", Offset = "0x44B19B4", VA = "0x44B59B4")]
			[IgnoredByDeepProfiler]
			get
			{
				return default;
			}
			[Token(Token = "0x60012DF")]
			[Address(RVA = "0x44B59C0", Offset = "0x44B19C0", VA = "0x44B59C0")]
			[IgnoredByDeepProfiler]
			set
			{
			}
		}

		[Token(Token = "0x17000310")]
		public bool reachedDestinationAndOrientation
		{
			[Token(Token = "0x60012E0")]
			[Address(RVA = "0x44B59D0", Offset = "0x44B19D0", VA = "0x44B59D0")]
			[IgnoredByDeepProfiler]
			get
			{
				return default;
			}
			[Token(Token = "0x60012E1")]
			[Address(RVA = "0x44B59DC", Offset = "0x44B19DC", VA = "0x44B59DC")]
			[IgnoredByDeepProfiler]
			set
			{
			}
		}

		[Token(Token = "0x17000311")]
		public bool reachedEndOfPath
		{
			[Token(Token = "0x60012E2")]
			[Address(RVA = "0x44B59FC", Offset = "0x44B19FC", VA = "0x44B59FC")]
			[IgnoredByDeepProfiler]
			get
			{
				return default;
			}
			[Token(Token = "0x60012E3")]
			[Address(RVA = "0x44B5A08", Offset = "0x44B1A08", VA = "0x44B5A08")]
			[IgnoredByDeepProfiler]
			set
			{
			}
		}

		[Token(Token = "0x17000312")]
		public bool reachedEndOfPathAndOrientation
		{
			[Token(Token = "0x60012E4")]
			[Address(RVA = "0x44B5A28", Offset = "0x44B1A28", VA = "0x44B5A28")]
			[IgnoredByDeepProfiler]
			get
			{
				return default;
			}
			[Token(Token = "0x60012E5")]
			[Address(RVA = "0x44B5A34", Offset = "0x44B1A34", VA = "0x44B5A34")]
			[IgnoredByDeepProfiler]
			set
			{
			}
		}

		[Token(Token = "0x17000313")]
		public bool reachedEndOfPart
		{
			[Token(Token = "0x60012E6")]
			[Address(RVA = "0x44B5A54", Offset = "0x44B1A54", VA = "0x44B5A54")]
			[IgnoredByDeepProfiler]
			get
			{
				return default;
			}
			[Token(Token = "0x60012E7")]
			[Address(RVA = "0x44B5A60", Offset = "0x44B1A60", VA = "0x44B5A60")]
			[IgnoredByDeepProfiler]
			set
			{
			}
		}

		[Token(Token = "0x17000314")]
		public bool traversingLastPart
		{
			[Token(Token = "0x60012E8")]
			[Address(RVA = "0x44B5A80", Offset = "0x44B1A80", VA = "0x44B5A80")]
			[IgnoredByDeepProfiler]
			get
			{
				return default;
			}
			[Token(Token = "0x60012E9")]
			[Address(RVA = "0x44B5A8C", Offset = "0x44B1A8C", VA = "0x44B5A8C")]
			[IgnoredByDeepProfiler]
			set
			{
			}
		}

		[Token(Token = "0x17000315")]
		public bool hasValidEndPoint
		{
			[Token(Token = "0x60012EA")]
			[Address(RVA = "0x44B5AAC", Offset = "0x44B1AAC", VA = "0x44B5AAC")]
			[IgnoredByDeepProfiler]
			get
			{
				return default;
			}
			[Token(Token = "0x60012EB")]
			[Address(RVA = "0x44B5AB8", Offset = "0x44B1AB8", VA = "0x44B5AB8")]
			[IgnoredByDeepProfiler]
			set
			{
			}
		}

		[Token(Token = "0x17000316")]
		public uint graphIndex
		{
			[Token(Token = "0x60012EC")]
			[Address(RVA = "0x44B5AD8", Offset = "0x44B1AD8", VA = "0x44B5AD8")]
			[IgnoredByDeepProfiler]
			get
			{
				return default;
			}
			[Token(Token = "0x60012ED")]
			[Address(RVA = "0x44B5AE0", Offset = "0x44B1AE0", VA = "0x44B5AE0")]
			[IgnoredByDeepProfiler]
			internal set
			{
			}
		}

		[Token(Token = "0x17000317")]
		public bool isOnValidNode
		{
			[Token(Token = "0x60012EE")]
			[Address(RVA = "0x44B5AE8", Offset = "0x44B1AE8", VA = "0x44B5AE8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60012EF")]
		[Address(RVA = "0x44B5AF8", Offset = "0x44B1AF8", VA = "0x44B5AF8")]
		public MovementState(Vector3 agentPosition)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MovementState..ctor RVA=0x44B5AF8 Token=0x60012EF");
}

		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x44B5B0C", Offset = "0x44B1B0C", VA = "0x44B5B0C")]
		public void SetPathIsEmpty(Vector3 agentPosition)
		{
		}
	}
}
