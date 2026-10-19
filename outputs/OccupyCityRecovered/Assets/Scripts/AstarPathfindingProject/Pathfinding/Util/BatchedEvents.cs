using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Profiling;

namespace Pathfinding.Util
{
	[Token(Token = "0x200029F")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/batchedevents.html")]
	public class BatchedEvents : VersionedMonoBehaviour
	{
		[Token(Token = "0x20002A0")]
		[Flags]
		public enum Event
		{
			[Token(Token = "0x4000BE8")]
			Update = 1,
			[Token(Token = "0x4000BE9")]
			LateUpdate = 2,
			[Token(Token = "0x4000BEA")]
			FixedUpdate = 4,
			[Token(Token = "0x4000BEB")]
			Custom = 8,
			[Token(Token = "0x4000BEC")]
			None = 0
		}

		[Token(Token = "0x20002A1")]
		private struct Archetype
		{
			[Token(Token = "0x4000BED")]
			[FieldOffset(Offset = "0x0")]
			public object[] objects;

			[Token(Token = "0x4000BEE")]
			[FieldOffset(Offset = "0x8")]
			public int objectCount;

			[Token(Token = "0x4000BEF")]
			[FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x4000BF0")]
			[FieldOffset(Offset = "0x18")]
			public TransformAccessArray transforms;

			[Token(Token = "0x4000BF1")]
			[FieldOffset(Offset = "0x20")]
			public int variant;

			[Token(Token = "0x4000BF2")]
			[FieldOffset(Offset = "0x24")]
			public int archetypeIndex;

			[Token(Token = "0x4000BF3")]
			[FieldOffset(Offset = "0x28")]
			public Event events;

			[Token(Token = "0x4000BF4")]
			[FieldOffset(Offset = "0x30")]
			public Action<object[], int, TransformAccessArray, Event> action;

			[Token(Token = "0x4000BF5")]
			[FieldOffset(Offset = "0x38")]
			public CustomSampler sampler;

			[Token(Token = "0x60010BA")]
			[Address(RVA = "0x4497404", Offset = "0x4493404", VA = "0x4497404")]
			public void Add(Component obj)
			{
			}

			[Token(Token = "0x60010BB")]
			[Address(RVA = "0x44976D0", Offset = "0x44936D0", VA = "0x44976D0")]
			public void Remove(int index)
			{
			}
		}

		[Token(Token = "0x4000BE1")]
		private const int ArchetypeOffset = 22;

		[Token(Token = "0x4000BE2")]
		private const int ArchetypeMask = 1069547520;

		[Token(Token = "0x4000BE3")]
		[FieldOffset(Offset = "0x0")]
		private static Archetype[] data;

		[Token(Token = "0x4000BE4")]
		[FieldOffset(Offset = "0x8")]
		private static BatchedEvents instance;

		[Token(Token = "0x4000BE5")]
		[FieldOffset(Offset = "0x10")]
		private static int isIteratingOverTypeIndex;

		[Token(Token = "0x4000BE6")]
		[FieldOffset(Offset = "0x14")]
		private static bool isIterating;

		[Token(Token = "0x60010A9")]
		[Address(RVA = "0x4496DDC", Offset = "0x4492DDC", VA = "0x4496DDC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60010AA")]
		[Address(RVA = "0x4496ED4", Offset = "0x4492ED4", VA = "0x4496ED4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60010AB")]
		[Address(RVA = "0x4496F88", Offset = "0x4492F88", VA = "0x4496F88")]
		private static void CreateInstance()
		{
		}

		[Token(Token = "0x60010AC")]
		public static T Find<T, K>(K key, Func<T, K, bool> predicate) where T : class, IEntityIndex
		{
			return null;
		}

		[Token(Token = "0x60010AD")]
		public static void Remove<T>(T obj) where T : IEntityIndex
		{
		}

		[Token(Token = "0x60010AE")]
		public static int GetComponents<T>(Event eventTypes, out TransformAccessArray transforms, out T[] components) where T : Component, IEntityIndex
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BatchedEvents.GetComponents RVA= Token=0x60010AE");
}

		[Token(Token = "0x60010AF")]
		public static bool Has<T>(T obj) where T : IEntityIndex
		{
			return default;
		}

		[Token(Token = "0x60010B0")]
		public static void Add<T>(T obj, Event eventTypes, Action<T[], int> action, int archetypeVariant = 0) where T : Component, IEntityIndex
		{
		}

		[Token(Token = "0x60010B1")]
		public static void Add<T>(T obj, Event eventTypes, Action<T[], int, TransformAccessArray, Event> action, int archetypeVariant = 0) where T : Component, IEntityIndex
		{
		}

		[Token(Token = "0x60010B2")]
		private static void Add<T>(T obj, Event eventTypes, Action<T[], int, TransformAccessArray, Event> action1, Action<T[], int> action2, int archetypeVariant = 0) where T : Component, IEntityIndex
		{
		}

		[Token(Token = "0x60010B3")]
		[Address(RVA = "0x4497094", Offset = "0x4493094", VA = "0x4497094")]
		private void Process(Event eventType, Type typeFilter)
		{
		}

		[Token(Token = "0x60010B4")]
		public static void ProcessEvent<T>(Event eventType)
		{
		}

		[Token(Token = "0x60010B5")]
		[Address(RVA = "0x449735C", Offset = "0x449335C", VA = "0x449735C")]
		private void Update()
		{
		}

		[Token(Token = "0x60010B6")]
		[Address(RVA = "0x4497368", Offset = "0x4493368", VA = "0x4497368")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60010B7")]
		[Address(RVA = "0x4497374", Offset = "0x4493374", VA = "0x4497374")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60010B8")]
		[Address(RVA = "0x4497380", Offset = "0x4493380", VA = "0x4497380")]
		public BatchedEvents()
		{
		}
	}
}
