using System;
using Il2CppDummyDll;
using Pathfinding.Util;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Properties;
using Unity.Transforms;
using UnityEngine;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20002EB")]
	public class AgentOffMeshLinkTraversalContext : ICloneable
	{
		[Token(Token = "0x20002EC")]
		public class AbortOffMeshLinkTraversal : Exception
		{
			[Token(Token = "0x60012A4")]
			[Address(RVA = "0x44B240C", Offset = "0x44AE40C", VA = "0x44B240C")]
			public AbortOffMeshLinkTraversal()
			{
			}
		}

		[Token(Token = "0x4000D80")]
		[FieldOffset(Offset = "0x10")]
		internal unsafe AgentOffMeshLinkTraversal* linkInfoPtr;

		[Token(Token = "0x4000D81")]
		[FieldOffset(Offset = "0x18")]
		internal unsafe MovementControl* movementControlPtr;

		[Token(Token = "0x4000D82")]
		[FieldOffset(Offset = "0x20")]
		internal unsafe MovementSettings* movementSettingsPtr;

		[Token(Token = "0x4000D83")]
		[FieldOffset(Offset = "0x28")]
		internal unsafe LocalTransform* transformPtr;

		[Token(Token = "0x4000D84")]
		[FieldOffset(Offset = "0x30")]
		internal unsafe AgentMovementPlane* movementPlanePtr;

		[Token(Token = "0x4000D85")]
		[FieldOffset(Offset = "0x38")]
		internal EnabledRefRW<AgentOffMeshLinkMovementDisabled> movementDisabled;

		[Token(Token = "0x4000D86")]
		[FieldOffset(Offset = "0x50")]
		internal EnabledRefRW<AgentOffMeshLinkLocalAvoidanceDisabled> localAvoidanceDisabled;

		[Token(Token = "0x4000D87")]
		[FieldOffset(Offset = "0x68")]
		public Entity entity;

		[Token(Token = "0x4000D88")]
		[FieldOffset(Offset = "0x70")]
		[DontCreateProperty]
		public ManagedState managedState;

		[Token(Token = "0x4000D89")]
		[FieldOffset(Offset = "0x78")]
		[DontCreateProperty]
		internal OffMeshLinks.OffMeshLinkConcrete concreteLink;

		[Token(Token = "0x4000D8A")]
		[FieldOffset(Offset = "0x80")]
		protected float backupRotationSmoothing;

		[Token(Token = "0x4000D8B")]
		[FieldOffset(Offset = "0x84")]
		public float deltaTime;

		[Token(Token = "0x4000D8C")]
		[FieldOffset(Offset = "0x88")]
		protected GameObject gameObjectCache;

		[Token(Token = "0x17000302")]
		public virtual GameObject gameObject
		{
			[Token(Token = "0x6001292")]
			[Address(RVA = "0x44B1E64", Offset = "0x44ADE64", VA = "0x44B1E64", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000303")]
		public unsafe ref LocalTransform transform
		{
			[Token(Token = "0x6001293")]
			[Address(RVA = "0x44B200C", Offset = "0x44AE00C", VA = "0x44B200C")]
			get
			{
				return ref *(LocalTransform*)null;
			}
		}

		[Token(Token = "0x17000304")]
		public unsafe ref MovementSettings movementSettings
		{
			[Token(Token = "0x6001294")]
			[Address(RVA = "0x44B2014", Offset = "0x44AE014", VA = "0x44B2014")]
			get
			{
				return ref *(MovementSettings*)null;
			}
		}

		[Token(Token = "0x17000305")]
		public unsafe ref MovementControl movementControl
		{
			[Token(Token = "0x6001295")]
			[Address(RVA = "0x44B201C", Offset = "0x44AE01C", VA = "0x44B201C")]
			get
			{
				return ref *(MovementControl*)null;
			}
		}

		[Token(Token = "0x17000306")]
		public OffMeshLinks.OffMeshLinkTracer link
		{
			[Token(Token = "0x6001296")]
			[Address(RVA = "0x44B2024", Offset = "0x44AE024", VA = "0x44B2024")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000307")]
		[Obsolete("Use the link property instead")]
		public AgentOffMeshLinkTraversal linkInfo
		{
			[Token(Token = "0x6001297")]
			[Address(RVA = "0x44B20D0", Offset = "0x44AE0D0", VA = "0x44B20D0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000308")]
		public unsafe ref NativeMovementPlane movementPlane
		{
			[Token(Token = "0x6001298")]
			[Address(RVA = "0x44B20E8", Offset = "0x44AE0E8", VA = "0x44B20E8")]
			get
			{
				return ref *(NativeMovementPlane*)null;
			}
		}

		[Token(Token = "0x17000309")]
		public bool enableBuiltInMovement
		{
			[Token(Token = "0x6001299")]
			[Address(RVA = "0x44B2100", Offset = "0x44AE100", VA = "0x44B2100")]
			get
			{
				return default;
			}
			[Token(Token = "0x600129A")]
			[Address(RVA = "0x44B2184", Offset = "0x44AE184", VA = "0x44B2184")]
			set
			{
			}
		}

		[Token(Token = "0x600129B")]
		[Address(RVA = "0x44B2218", Offset = "0x44AE218", VA = "0x44B2218")]
		public AgentOffMeshLinkTraversalContext(OffMeshLinks.OffMeshLinkConcrete link)
		{
		}

		[Token(Token = "0x600129C")]
		[Address(RVA = "0x44B2248", Offset = "0x44AE248", VA = "0x44B2248", Slot = "6")]
		public virtual void SetInternalData(Entity entity, ref LocalTransform transform, ref AgentMovementPlane movementPlane, ref MovementControl movementControl, ref MovementSettings movementSettings, ref AgentOffMeshLinkTraversal linkInfo, EnabledRefRW<AgentOffMeshLinkMovementDisabled> movementDisabled, EnabledRefRW<AgentOffMeshLinkLocalAvoidanceDisabled> localAvoidanceDisabled, ManagedState state, float deltaTime)
		{
		}

		[Token(Token = "0x600129D")]
		[Address(RVA = "0x44B2284", Offset = "0x44AE284", VA = "0x44B2284")]
		public void DisableLocalAvoidance()
		{
		}

		[Token(Token = "0x600129E")]
		[Address(RVA = "0x44B2304", Offset = "0x44AE304", VA = "0x44B2304")]
		public void DisableRotationSmoothing()
		{
		}

		[Token(Token = "0x600129F")]
		[Address(RVA = "0x44B2338", Offset = "0x44AE338", VA = "0x44B2338", Slot = "7")]
		public virtual void Restore()
		{
		}

		[Token(Token = "0x60012A0")]
		[Address(RVA = "0x44B2364", Offset = "0x44AE364", VA = "0x44B2364", Slot = "8")]
		public virtual void Teleport(float3 position)
		{
		}

		[Token(Token = "0x60012A1")]
		[Address(RVA = "0x44B2374", Offset = "0x44AE374", VA = "0x44B2374", Slot = "9")]
		public virtual void Abort(bool teleportToStart = true)
		{
		}

		[Token(Token = "0x60012A2")]
		[Address(RVA = "0x44B2464", Offset = "0x44AE464", VA = "0x44B2464", Slot = "10")]
		public virtual MovementTarget MoveTowards(float3 position, quaternion rotation, bool gravity, bool slowdown)
		{
			return default;
		}

		[Token(Token = "0x60012A3")]
		[Address(RVA = "0x44B2720", Offset = "0x44AE720", VA = "0x44B2720", Slot = "11")]
		public virtual object Clone()
		{
			return null;
		}
	}
}
