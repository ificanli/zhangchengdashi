using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.ECS.RVO;
using Unity.Entities;
using Unity.Properties;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

namespace Pathfinding.ECS
{
	[Serializable]
	[Token(Token = "0x20002FC")]
	[TypeManager.TypeOverrides(true, true, true)]
	public class ManagedState : IComponentData, IQueryTypeParameter, IDisposable, ICloneable
	{
		[Token(Token = "0x4000D9F")]
		[FieldOffset(Offset = "0x10")]
		public PathTracer pathTracer;

		[Token(Token = "0x4000DA0")]
		[FieldOffset(Offset = "0x100")]
		[FormerlySerializedAs("rvoAgent")]
		[Obsolete("Use FollowerEntity.rvoSettings or the RVOAgent ECS component instead", false)]
		[DontCreateProperty]
		public RVOAgent rvoSettings;

		[NonSerialized]
		[Token(Token = "0x4000DA1")]
		[FieldOffset(Offset = "0x128")]
		[DontCreateProperty]
		[Obsolete("Use ManagedSettings.onTraverseOffMeshLink instead", false)]
		public IOffMeshLinkHandler onTraverseOffMeshLink;

		[Token(Token = "0x4000DA2")]
		[FieldOffset(Offset = "0x130")]
		[Obsolete("Use ManagedSettings.pathfindingSettings instead", false)]
		[DontCreateProperty]
		public PathRequestSettings pathfindingSettings;

		[Token(Token = "0x4000DA3")]
		[FieldOffset(Offset = "0x150")]
		[FormerlySerializedAs("rvoEnabled")]
		[Obsolete("Use FollowerEntity.enableLocalAvoidance or remove/add the RVOAgent ECS component instead", false)]
		[DontCreateProperty]
		public bool enableLocalAvoidance;

		[Token(Token = "0x4000DA4")]
		[FieldOffset(Offset = "0x151")]
		[Obsolete("Use FollowerEntity.enableGravity or toggle the enabled state of the GravityState ECS component instead", false)]
		[DontCreateProperty]
		public bool enableGravity;

		[Token(Token = "0x1700030B")]
		[Obsolete("Use FollowerEntity.autoRepath, or the Pathfinding.ECS.AutoRepathPolicy component instead", true)]
		public Pathfinding.AutoRepathPolicy autoRepath
		{
			[Token(Token = "0x60012D0")]
			[Address(RVA = "0x44B520C", Offset = "0x44B120C", VA = "0x44B520C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700030C")]
		public Path pendingPath
		{
			[Token(Token = "0x60012D1")]
			[Address(RVA = "0x44B5214", Offset = "0x44B1214", VA = "0x44B5214")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012D2")]
			[Address(RVA = "0x44B521C", Offset = "0x44B121C", VA = "0x44B521C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700030D")]
		public Path activePath
		{
			[Token(Token = "0x60012D3")]
			[Address(RVA = "0x44B5224", Offset = "0x44B1224", VA = "0x44B5224")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012D4")]
			[Address(RVA = "0x44B522C", Offset = "0x44B122C", VA = "0x44B522C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60012D5")]
		[Address(RVA = "0x44B5234", Offset = "0x44B1234", VA = "0x44B5234")]
		public static void SetPath(Path path, ManagedState state, in AgentMovementPlane movementPlane, ref DestinationPoint destination)
		{
		}

		[Token(Token = "0x60012D6")]
		[Address(RVA = "0x44B5634", Offset = "0x44B1634", VA = "0x44B5634")]
		public void ClearPath()
		{
		}

		[Token(Token = "0x60012D7")]
		[Address(RVA = "0x44B55C0", Offset = "0x44B15C0", VA = "0x44B55C0")]
		public void CancelCurrentPathRequest()
		{
		}

		[Token(Token = "0x60012D8")]
		[Address(RVA = "0x44B56B0", Offset = "0x44B16B0", VA = "0x44B56B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60012D9")]
		[Address(RVA = "0x44B5774", Offset = "0x44B1774", VA = "0x44B5774")]
		public void PopNextLinkFromPath()
		{
		}

		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x44B5864", Offset = "0x44B1864", VA = "0x44B5864", Slot = "5")]
object System.ICloneable.Clone()
		{
			return null;
		}

		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x44B592C", Offset = "0x44B192C", VA = "0x44B592C")]
		[Preserve]
		public ManagedState()
		{
		}
	}
}
