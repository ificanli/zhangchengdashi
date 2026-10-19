using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002DB")]
	[ExecuteInEditMode]
	[AddComponentMenu("Pathfinding/Local Avoidance/RVO Simulator")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/rvosimulator.html")]
	public class RVOSimulator : VersionedMonoBehaviour
	{
		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Desired FPS for rvo simulation. It is usually not necessary to run a crowd simulation at a very high fps.\nUsually 10-30 fps is enough, but can be increased for better quality.\nThe rvo simulation will never run at a higher fps than the game")]
		public int desiredSimulationFPS;

		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Number of RVO worker threads. If set to None, no multithreading will be used.")]
		[Obsolete("The number of worker threads is now set by the unity job system", true)]
		public ThreadCount workerThreads;

		[Token(Token = "0x4000D3C")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Calculate local avoidance in between frames.\nThis can increase jitter in the agents' movement so use it only if you really need the performance boost. It will also reduce the responsiveness of the agents to the commands you send to them.")]
		[Obsolete("Double buffering has been removed")]
		public bool doubleBuffering;

		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x31")]
		public bool hardCollisions;

		[Token(Token = "0x4000D3E")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 0.2f)]
		[Tooltip("Bias agents to pass each other on the right side.\nIf the desired velocity of an agent puts it on a collision course with another agent or an obstacle its desired velocity will be rotated this number of radians (1 radian is approximately 57°) to the right. This helps to break up symmetries and makes it possible to resolve some situations much faster.\n\nWhen many agents have the same goal this can however have the side effect that the group clustered around the target point may as a whole start to spin around the target point.")]
		public float symmetryBreakingBias;

		[Token(Token = "0x4000D3F")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Determines if the XY (2D) or XZ (3D) plane is used for movement")]
		public MovementPlane movementPlane;

		[Token(Token = "0x4000D40")]
		[FieldOffset(Offset = "0x3C")]
		public bool useNavmeshAsObstacle;

		[Token(Token = "0x4000D41")]
		[FieldOffset(Offset = "0x3D")]
		public bool drawQuadtree;

		[Token(Token = "0x4000D42")]
		[FieldOffset(Offset = "0x40")]
		private SimulatorBurst simulatorBurst;

		[Token(Token = "0x170002C5")]
		public static RVOSimulator active
		{
			[Token(Token = "0x6001202")]
			[Address(RVA = "0x44A7420", Offset = "0x44A3420", VA = "0x44A7420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001203")]
			[Address(RVA = "0x44A7468", Offset = "0x44A3468", VA = "0x44A7468")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6001204")]
		[Address(RVA = "0x44A6024", Offset = "0x44A2024", VA = "0x44A6024")]
		public SimulatorBurst GetSimulator()
		{
			return null;
		}

		[Token(Token = "0x6001205")]
		[Address(RVA = "0x44A74B4", Offset = "0x44A34B4", VA = "0x44A74B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6001206")]
		[Address(RVA = "0x44A7670", Offset = "0x44A3670", VA = "0x44A7670")]
		private void Update()
		{
		}

		[Token(Token = "0x6001207")]
		[Address(RVA = "0x44A772C", Offset = "0x44A372C", VA = "0x44A772C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6001208")]
		[Address(RVA = "0x44A7804", Offset = "0x44A3804", VA = "0x44A7804", Slot = "6")]
		public override void DrawGizmos()
		{
		}

		[Token(Token = "0x6001209")]
		[Address(RVA = "0x44A7808", Offset = "0x44A3808", VA = "0x44A7808")]
		public RVOSimulator()
		{
		}
	}
}
