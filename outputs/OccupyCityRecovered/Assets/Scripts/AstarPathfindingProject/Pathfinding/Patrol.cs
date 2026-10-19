using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000014")]
	[AddComponentMenu("Pathfinding/AI/Behaviors/Patrol")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/patrol.html")]
	[UniqueComponent(tag = "ai.destination")]
	public class Patrol : VersionedMonoBehaviour
	{
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x28")]
		public Transform[] targets;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x30")]
		public float delay;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x34")]
		public bool updateDestinationEveryFrame;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x38")]
		private int index;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x40")]
		private IAstarAI agent;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x48")]
		private float switchTime;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x44495BC", Offset = "0x44455BC", VA = "0x44495BC", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x4449618", Offset = "0x4445618", VA = "0x4449618")]
		private void Update()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x4449990", Offset = "0x4445990", VA = "0x4449990")]
		public Patrol()
		{
		}
	}
}
