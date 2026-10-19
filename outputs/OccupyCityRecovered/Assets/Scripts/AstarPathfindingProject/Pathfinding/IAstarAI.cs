using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200001B")]
	public interface IAstarAI
	{
		[Token(Token = "0x1700007E")]
		float radius
		{
			[Token(Token = "0x6000198")]
			get;
			[Token(Token = "0x6000199")]
			set;
		}

		[Token(Token = "0x1700007F")]
		float height
		{
			[Token(Token = "0x600019A")]
			get;
			[Token(Token = "0x600019B")]
			set;
		}

		[Token(Token = "0x17000080")]
		Vector3 position
		{
			[Token(Token = "0x600019C")]
			get;
		}

		[Token(Token = "0x17000081")]
		Quaternion rotation
		{
			[Token(Token = "0x600019D")]
			get;
			[Token(Token = "0x600019E")]
			set;
		}

		[Token(Token = "0x17000082")]
		float maxSpeed
		{
			[Token(Token = "0x600019F")]
			get;
			[Token(Token = "0x60001A0")]
			set;
		}

		[Token(Token = "0x17000083")]
		Vector3 velocity
		{
			[Token(Token = "0x60001A1")]
			get;
		}

		[Token(Token = "0x17000084")]
		Vector3 desiredVelocity
		{
			[Token(Token = "0x60001A2")]
			get;
		}

		[Token(Token = "0x17000085")]
		Vector3 desiredVelocityWithoutLocalAvoidance
		{
			[Token(Token = "0x60001A3")]
			get;
			[Token(Token = "0x60001A4")]
			set;
		}

		[Token(Token = "0x17000086")]
		float remainingDistance
		{
			[Token(Token = "0x60001A5")]
			get;
		}

		[Token(Token = "0x17000087")]
		bool reachedDestination
		{
			[Token(Token = "0x60001A6")]
			get;
		}

		[Token(Token = "0x17000088")]
		bool reachedEndOfPath
		{
			[Token(Token = "0x60001A7")]
			get;
		}

		[Token(Token = "0x17000089")]
		Vector3 endOfPath
		{
			[Token(Token = "0x60001A8")]
			get;
		}

		[Token(Token = "0x1700008A")]
		Vector3 destination
		{
			[Token(Token = "0x60001A9")]
			get;
			[Token(Token = "0x60001AA")]
			set;
		}

		[Token(Token = "0x1700008B")]
		bool canSearch
		{
			[Token(Token = "0x60001AB")]
			get;
			[Token(Token = "0x60001AC")]
			set;
		}

		[Token(Token = "0x1700008C")]
		bool simulateMovement
		{
			[Token(Token = "0x60001AD")]
			get;
			[Token(Token = "0x60001AE")]
			set;
		}

		[Token(Token = "0x1700008D")]
		[Obsolete("Renamed to simulateMovement")]
		bool canMove
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x445494C", Offset = "0x445094C", VA = "0x445494C", Slot = "23")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x44549E4", Offset = "0x44509E4", VA = "0x44549E4", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		bool hasPath
		{
			[Token(Token = "0x60001B1")]
			get;
		}

		[Token(Token = "0x1700008F")]
		bool pathPending
		{
			[Token(Token = "0x60001B2")]
			get;
		}

		[Token(Token = "0x17000090")]
		bool updatePosition
		{
			[Token(Token = "0x60001B3")]
			get;
			[Token(Token = "0x60001B4")]
			set;
		}

		[Token(Token = "0x17000091")]
		bool updateRotation
		{
			[Token(Token = "0x60001B5")]
			get;
			[Token(Token = "0x60001B6")]
			set;
		}

		[Token(Token = "0x17000092")]
		bool isStopped
		{
			[Token(Token = "0x60001B7")]
			get;
			[Token(Token = "0x60001B8")]
			set;
		}

		[Token(Token = "0x17000093")]
		Vector3 steeringTarget
		{
			[Token(Token = "0x60001B9")]
			get;
		}

		[Token(Token = "0x17000094")]
		Action onSearchPath
		{
			[Token(Token = "0x60001BA")]
			get;
			[Token(Token = "0x60001BB")]
			set;
		}

		[Token(Token = "0x17000095")]
		NativeMovementPlane movementPlane
		{
			[Token(Token = "0x60001BC")]
			get;
		}

		[Token(Token = "0x60001BD")]
		void GetRemainingPath(List<Vector3> buffer, out bool stale);

		[Token(Token = "0x60001BE")]
		void GetRemainingPath(List<Vector3> buffer, List<PathPartWithLinkInfo> partsBuffer, out bool stale);

		[Token(Token = "0x60001BF")]
		void SearchPath();

		[Token(Token = "0x60001C0")]
		void SetPath(Path path, bool updateDestinationFromPath = true);

		[Token(Token = "0x60001C1")]
		void Teleport(Vector3 newPosition, bool clearPath = true);

		[Token(Token = "0x60001C2")]
		void Move(Vector3 deltaPosition);

		[Token(Token = "0x60001C3")]
		void MovementUpdate(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation);

		[Token(Token = "0x60001C4")]
		void FinalizeMovement(Vector3 nextPosition, Quaternion nextRotation);
	}
}
