using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000011")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/aipathalignedtosurface.html")]
	public class AIPathAlignedToSurface : AIPath
	{
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Mesh, int> scratchDictionary;

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x444810C", Offset = "0x444410C", VA = "0x444810C", Slot = "38")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x44482FC", Offset = "0x44442FC", VA = "0x44482FC", Slot = "51")]
		protected override void ApplyGravity(float deltaTime)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x444839C", Offset = "0x444439C", VA = "0x444839C")]
		public static void UpdateMovementPlanes(AIPathAlignedToSurface[] components, int count)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x4448E04", Offset = "0x4444E04", VA = "0x4448E04")]
		private void SetInterpolatedNormal(Vector3 normal)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x4449004", Offset = "0x4445004", VA = "0x4449004", Slot = "102")]
		protected override void UpdateMovementPlane()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x4449008", Offset = "0x4445008", VA = "0x4449008")]
		public AIPathAlignedToSurface()
		{
		}
	}
}
