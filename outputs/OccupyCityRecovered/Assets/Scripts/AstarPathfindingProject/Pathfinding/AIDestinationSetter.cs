using Il2CppDummyDll;
using Pathfinding.Util;
using Unity.Entities;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000010")]
	[UniqueComponent(tag = "ai.destination")]
	[AddComponentMenu("Pathfinding/AI/Behaviors/AIDestinationSetter")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/aidestinationsetter.html")]
	public class AIDestinationSetter : VersionedMonoBehaviour, IRuntimeBaker
	{
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x30")]
		public bool useRotation;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x38")]
		private IAstarAI ai;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x40")]
		private Entity entity;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x48")]
		private World world;

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x4447854", Offset = "0x4443854", VA = "0x4447854")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x4447C30", Offset = "0x4443C30", VA = "0x4447C30")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4447EE8", Offset = "0x4443EE8", VA = "0x4447EE8", Slot = "15")]
void IRuntimeBaker.OnCreatedEntity(World world, Entity entity)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x4447F7C", Offset = "0x4443F7C", VA = "0x4447F7C")]
		private static void OnUpdate(AIDestinationSetter[] components, int count)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x4447FD8", Offset = "0x4443FD8", VA = "0x4447FD8")]
		private void UpdateDestination()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x4448104", Offset = "0x4444104", VA = "0x4448104")]
		public AIDestinationSetter()
		{
		}
	}
}
