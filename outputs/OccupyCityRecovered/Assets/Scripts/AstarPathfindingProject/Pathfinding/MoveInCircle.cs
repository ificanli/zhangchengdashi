using Il2CppDummyDll;
using Unity.Entities;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000012")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/moveincircle.html")]
	[AddComponentMenu("Pathfinding/AI/Behaviors/MoveInCircle")]
	[UniqueComponent(tag = "ai.destination")]
	public class MoveInCircle : VersionedMonoBehaviour
	{
		[Token(Token = "0x2000013")]
		public struct DestinationMoveInCircle : IComponentData, IQueryTypeParameter, IEnableableComponent
		{
			[Token(Token = "0x4000074")]
			[FieldOffset(Offset = "0x0")]
			public Entity target;

			[Token(Token = "0x4000075")]
			[FieldOffset(Offset = "0x8")]
			public float radius;

			[Token(Token = "0x4000076")]
			[FieldOffset(Offset = "0xC")]
			public float offset;
		}

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x30")]
		public float radius;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x34")]
		public float offset;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x38")]
		private IAstarAI ai;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x4449138", Offset = "0x4445138", VA = "0x4449138")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x4449188", Offset = "0x4445188", VA = "0x4449188")]
		public static Vector3 CalculateDestination(Vector3 position, Vector3 target, Vector3 targetUp, float radius, float offset)
		{
			return default;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x4449320", Offset = "0x4445320", VA = "0x4449320")]
		private void Update()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x44494C0", Offset = "0x44454C0", VA = "0x44494C0", Slot = "6")]
		public override void DrawGizmos()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x44495A8", Offset = "0x44455A8", VA = "0x44495A8")]
		public MoveInCircle()
		{
		}
	}
}
