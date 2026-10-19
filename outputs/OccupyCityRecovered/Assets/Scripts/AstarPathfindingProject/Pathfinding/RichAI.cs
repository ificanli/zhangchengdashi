using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200001C")]
	[DisallowMultipleComponent]
	[UniqueComponent(tag = "ai")]
	[AddComponentMenu("Pathfinding/AI/RichAI (3D, for navmesh)")]
	public class RichAI : AIBase, IAstarAI
	{
		[Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class _003CTraverseOffMeshLinkFallback_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000100")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000101")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000102")]
			[FieldOffset(Offset = "0x20")]
			public RichAI _003C_003E4__this;

			[Token(Token = "0x4000103")]
			[FieldOffset(Offset = "0x28")]
			public RichSpecial link;

			[Token(Token = "0x4000104")]
			[FieldOffset(Offset = "0x30")]
			private float _003Cduration_003E5__2;

			[Token(Token = "0x4000105")]
			[FieldOffset(Offset = "0x34")]
			private float _003CstartTime_003E5__3;

			[Token(Token = "0x170000A8")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001F7")]
				[Address(RVA = "0x44572D0", Offset = "0x44532D0", VA = "0x44572D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000A9")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001F9")]
				[Address(RVA = "0x4457310", Offset = "0x4453310", VA = "0x4457310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x4456FF0", Offset = "0x4452FF0", VA = "0x4456FF0")]
			[DebuggerHidden]
			public _003CTraverseOffMeshLinkFallback_003Ed__80(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x4457018", Offset = "0x4453018", VA = "0x4457018", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x445701C", Offset = "0x445301C", VA = "0x445701C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x44572D0", Offset = "0x44532D0", VA = "0x44572D0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x44572D8", Offset = "0x44532D8", VA = "0x44572D8", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x4457310", Offset = "0x4453310", VA = "0x4457310", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class _003CTraverseSpecial_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000106")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000107")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000108")]
			[FieldOffset(Offset = "0x20")]
			public RichAI _003C_003E4__this;

			[Token(Token = "0x4000109")]
			[FieldOffset(Offset = "0x28")]
			public RichSpecial link;

			[Token(Token = "0x170000AA")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001FD")]
				[Address(RVA = "0x4457468", Offset = "0x4453468", VA = "0x4457468", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000AB")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001FF")]
				[Address(RVA = "0x44574A8", Offset = "0x44534A8", VA = "0x44574A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x4457318", Offset = "0x4453318", VA = "0x4457318")]
			[DebuggerHidden]
			public _003CTraverseSpecial_003Ed__79(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x4457340", Offset = "0x4453340", VA = "0x4457340", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x4457344", Offset = "0x4453344", VA = "0x4457344", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x4457468", Offset = "0x4453468", VA = "0x4457468", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x4457470", Offset = "0x4453470", VA = "0x4457470", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x44574A8", Offset = "0x44534A8", VA = "0x44574A8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x1AC")]
		public float acceleration;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x1B0")]
		public float rotationSpeed;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x1B4")]
		public float slowdownTime;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x1B8")]
		public float wallForce;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x1BC")]
		public float wallDist;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x1C0")]
		public bool funnelSimplification;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x1C1")]
		public bool slowWhenNotFacingTarget;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x1C2")]
		public bool preventMovingBackwards;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x1C8")]
		public Func<RichSpecial, IEnumerator> onTraverseOffMeshLink;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x1D0")]
		protected readonly RichPath richPath;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x1D8")]
		protected bool delayUpdatePath;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x1D9")]
		protected bool lastCorner;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x1DC")]
		private Vector2 rotationFilterState;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x1E4")]
		private Vector2 rotationFilterState2;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x1EC")]
		protected float distanceToSteeringTarget;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x1F0")]
		protected readonly List<Vector3> nextCorners;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x1F8")]
		protected readonly List<Vector3> wallBuffer;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly Color GizmoColorPath;

		[Token(Token = "0x17000096")]
		public bool traversingOffMeshLink
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x4454A8C", Offset = "0x4450A8C", VA = "0x4454A8C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x4454A94", Offset = "0x4450A94", VA = "0x4454A94")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public float remainingDistance
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x4454AA0", Offset = "0x4450AA0", VA = "0x4454AA0", Slot = "69")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000098")]
		public bool reachedEndOfPath
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x4454B40", Offset = "0x4450B40", VA = "0x4454B40", Slot = "71")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000099")]
		public override bool reachedDestination
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x4454BA4", Offset = "0x4450BA4", VA = "0x4454BA4", Slot = "31")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009A")]
		public bool hasPath
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x4454E04", Offset = "0x4450E04", VA = "0x4454E04", Slot = "81")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009B")]
		public bool pathPending
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x4454E2C", Offset = "0x4450E2C", VA = "0x4454E2C", Slot = "82")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009C")]
		public Vector3 steeringTarget
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x4454E4C", Offset = "0x4450E4C", VA = "0x4454E4C", Slot = "89")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x4454E5C", Offset = "0x4450E5C", VA = "0x4454E5C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700009D")]
float IAstarAI.radius
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x4454E6C", Offset = "0x4450E6C", VA = "0x4454E6C", Slot = "56")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_radius();
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x4454E74", Offset = "0x4450E74", VA = "0x4454E74", Slot = "57")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_radius(value);
			}
		}

		[Token(Token = "0x1700009E")]
float IAstarAI.height
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x4454E7C", Offset = "0x4450E7C", VA = "0x4454E7C", Slot = "58")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_height();
			}
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x4454E84", Offset = "0x4450E84", VA = "0x4454E84", Slot = "59")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_height(value);
			}
		}

		[Token(Token = "0x1700009F")]
float IAstarAI.maxSpeed
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x4454E8C", Offset = "0x4450E8C", VA = "0x4454E8C", Slot = "63")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_maxSpeed();
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x4454E94", Offset = "0x4450E94", VA = "0x4454E94", Slot = "64")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_maxSpeed(value);
			}
		}

		[Token(Token = "0x170000A0")]
bool IAstarAI.canSearch
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x4454E9C", Offset = "0x4450E9C", VA = "0x4454E9C", Slot = "75")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_canSearch();
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x4454EC0", Offset = "0x4450EC0", VA = "0x4454EC0", Slot = "76")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_canSearch(value);
			}
		}

		[Token(Token = "0x170000A1")]
bool IAstarAI.simulateMovement
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x4454EF4", Offset = "0x4450EF4", VA = "0x4454EF4", Slot = "77")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_simulateMovement();
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x4454EFC", Offset = "0x4450EFC", VA = "0x4454EFC", Slot = "78")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_simulateMovement(value);
			}
		}

		[Token(Token = "0x170000A2")]
NativeMovementPlane IAstarAI.movementPlane
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x4454F08", Offset = "0x4450F08", VA = "0x4454F08", Slot = "92")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_movementPlane();
			}
		}

		[Token(Token = "0x170000A3")]
		public bool approachingPartEndpoint
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x4454F50", Offset = "0x4450F50", VA = "0x4454F50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A4")]
		public bool approachingPathEndpoint
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x4454B70", Offset = "0x4450B70", VA = "0x4454B70")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A5")]
		public override Vector3 endOfPath
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x4454FB0", Offset = "0x4450FB0", VA = "0x4454FB0", Slot = "30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A6")]
		public override Quaternion rotation
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x4455008", Offset = "0x4451008", VA = "0x4455008", Slot = "18")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x445500C", Offset = "0x445100C", VA = "0x445500C", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		protected override bool shouldRecalculatePath
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x44552B4", Offset = "0x44512B4", VA = "0x44552B4", Slot = "36")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x4454E6C", Offset = "0x4450E6C", VA = "0x4454E6C", Slot = "56")]
		private float Pathfinding_002EIAstarAI_002Eget_radius()
		{
			return default;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x4454E74", Offset = "0x4450E74", VA = "0x4454E74", Slot = "57")]
		private void Pathfinding_002EIAstarAI_002Eset_radius(float value)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x4454E7C", Offset = "0x4450E7C", VA = "0x4454E7C", Slot = "58")]
		private float Pathfinding_002EIAstarAI_002Eget_height()
		{
			return default;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x4454E84", Offset = "0x4450E84", VA = "0x4454E84", Slot = "59")]
		private void Pathfinding_002EIAstarAI_002Eset_height(float value)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x4454E8C", Offset = "0x4450E8C", VA = "0x4454E8C", Slot = "63")]
		private float Pathfinding_002EIAstarAI_002Eget_maxSpeed()
		{
			return default;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x4454E94", Offset = "0x4450E94", VA = "0x4454E94", Slot = "64")]
		private void Pathfinding_002EIAstarAI_002Eset_maxSpeed(float value)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x4454E9C", Offset = "0x4450E9C", VA = "0x4454E9C", Slot = "75")]
		private bool Pathfinding_002EIAstarAI_002Eget_canSearch()
		{
			return default;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x4454EC0", Offset = "0x4450EC0", VA = "0x4454EC0", Slot = "76")]
		private void Pathfinding_002EIAstarAI_002Eset_canSearch(bool value)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x4454EF4", Offset = "0x4450EF4", VA = "0x4454EF4", Slot = "77")]
		private bool Pathfinding_002EIAstarAI_002Eget_simulateMovement()
		{
			return default;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x4454EFC", Offset = "0x4450EFC", VA = "0x4454EFC", Slot = "78")]
		private void Pathfinding_002EIAstarAI_002Eset_simulateMovement(bool value)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x4454F08", Offset = "0x4450F08", VA = "0x4454F08", Slot = "92")]
		private NativeMovementPlane Pathfinding_002EIAstarAI_002Eget_movementPlane()
		{
			return default;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x445506C", Offset = "0x445106C", VA = "0x445506C", Slot = "41")]
		public override void Teleport(Vector3 newPosition, bool clearPath = true)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x44550A0", Offset = "0x44510A0", VA = "0x44550A0", Slot = "101")]
		protected virtual Vector3 ClampPositionToGraph(Vector3 newPosition)
		{
			return default;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x4455240", Offset = "0x4451240", VA = "0x4455240", Slot = "42")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x44552E0", Offset = "0x44512E0", VA = "0x44552E0", Slot = "46")]
		public override void SearchPath()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x44552F8", Offset = "0x44512F8", VA = "0x44552F8", Slot = "48")]
		protected override void OnPathComplete(Path p)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x445564C", Offset = "0x445164C", VA = "0x445564C", Slot = "49")]
		protected override void ClearPath()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x44555D0", Offset = "0x44515D0", VA = "0x44555D0")]
		protected void NextPart()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x4455680", Offset = "0x4451680", VA = "0x4455680", Slot = "93")]
		public void GetRemainingPath(List<Vector3> buffer, out bool stale)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RichAI.GetRemainingPath RVA=0x4455680 Token=0x60001E6");
}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x44556B0", Offset = "0x44516B0", VA = "0x44556B0", Slot = "94")]
		public void GetRemainingPath(List<Vector3> buffer, List<PathPartWithLinkInfo> partsBuffer, out bool stale)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RichAI.GetRemainingPath RVA=0x44556B0 Token=0x60001E7");
}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x44556D8", Offset = "0x44516D8", VA = "0x44556D8", Slot = "102")]
		protected virtual void OnTargetReached()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x44556DC", Offset = "0x44516DC", VA = "0x44556DC", Slot = "103")]
		protected virtual Vector3 UpdateTarget(RichFunnel fn)
		{
			return default;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x44557BC", Offset = "0x44517BC", VA = "0x44557BC", Slot = "44")]
		protected override void MovementUpdateInternal(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RichAI.MovementUpdateInternal RVA=0x44557BC Token=0x60001EA");
}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x4455B74", Offset = "0x4451B74", VA = "0x4455B74")]
		private void TraverseFunnel(RichFunnel fn, float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RichAI.TraverseFunnel RVA=0x4455B74 Token=0x60001EB");
}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x445617C", Offset = "0x445217C", VA = "0x445617C")]
		private void FinalMovement(Vector3 position3D, float deltaTime, float distanceToEndOfPath, float speedLimitFactor, out Vector3 nextPosition, out Quaternion nextRotation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RichAI.FinalMovement RVA=0x445617C Token=0x60001EC");
}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x44569E0", Offset = "0x44529E0", VA = "0x44569E0", Slot = "54")]
		protected override Vector3 ClampToNavmesh(Vector3 position, out bool positionChanged)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RichAI.ClampToNavmesh RVA=0x44569E0 Token=0x60001ED");
}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x4456600", Offset = "0x4452600", VA = "0x4456600")]
		private Vector2 CalculateWallForce(Vector2 position, float elevation, Vector2 directionToTarget)
		{
			return default;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x4456C18", Offset = "0x4452C18", VA = "0x4456C18", Slot = "104")]
		[IteratorStateMachine(typeof(_003CTraverseSpecial_003Ed__79))]
		protected virtual IEnumerator TraverseSpecial(RichSpecial link)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x4456C8C", Offset = "0x4452C8C", VA = "0x4456C8C")]
		[IteratorStateMachine(typeof(_003CTraverseOffMeshLinkFallback_003Ed__80))]
		protected IEnumerator TraverseOffMeshLinkFallback(RichSpecial link)
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x4456D00", Offset = "0x4452D00", VA = "0x4456D00", Slot = "6")]
		public override void DrawGizmos()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x4456E90", Offset = "0x4452E90", VA = "0x4456E90")]
		public RichAI()
		{
		}
	}
}
