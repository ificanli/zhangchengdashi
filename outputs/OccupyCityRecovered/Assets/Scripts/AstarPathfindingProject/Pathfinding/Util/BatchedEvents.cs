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
                int previousCount = objectCount;
                objectCount = unchecked(previousCount + 1);
                if (objects == null)
                {
                    int mask = previousCount;
                    mask |= mask >> 1; mask |= mask >> 2; mask |= mask >> 4; mask |= mask >> 8; mask |= mask >> 16;
                    objects = (object[])Array.CreateInstance(type, unchecked(mask + 1));
                }
                if (objectCount > objects.Length)
                {
                    int mask = unchecked(objectCount - 1);
                    mask |= mask >> 1; mask |= mask >> 2; mask |= mask >> 4; mask |= mask >> 8; mask |= mask >> 16;
                    Array expanded = Array.CreateInstance(type, unchecked(mask + 1));
                    objects.CopyTo(expanded, 0);
                    objects = (object[])expanded;
                }
                objects[unchecked(objectCount - 1)] = obj;
                if (!transforms.isCreated) transforms = new TransformAccessArray(16, -1);
                transforms.Add(obj.transform);
                ((IEntityIndex)obj).EntityIndex = unchecked(objectCount - 1) | (archetypeIndex << 22);
            }

			[Token(Token = "0x60010BB")]
			[Address(RVA = "0x44976D0", Offset = "0x44936D0", VA = "0x44976D0")]
			public void Remove(int index)
			{
                objectCount = unchecked(objectCount - 1);
                ((IEntityIndex)objects[objectCount]).EntityIndex = index | (archetypeIndex << 22);
                ((IEntityIndex)objects[index]).EntityIndex = 0;
                objects[index] = objects[objectCount];
                objects[objectCount] = null;
                transforms.RemoveAtSwapBack(index);
                if (objectCount == 0) transforms.Dispose();
            }
		}

		[Token(Token = "0x4000BE1")]
		private const int ArchetypeOffset = 22;

		[Token(Token = "0x4000BE2")]
		private const int ArchetypeMask = 1069547520;

		[Token(Token = "0x4000BE3")]
		[FieldOffset(Offset = "0x0")]
		private static Archetype[] data = new Archetype[0];

		[Token(Token = "0x4000BE4")]
		[FieldOffset(Offset = "0x8")]
		private static BatchedEvents instance;

		[Token(Token = "0x4000BE5")]
		[FieldOffset(Offset = "0x10")]
		private static int isIteratingOverTypeIndex = -1;

		[Token(Token = "0x4000BE6")]
		[FieldOffset(Offset = "0x14")]
		private static bool isIterating = false;

		[Token(Token = "0x60010A9")]
		[Address(RVA = "0x4496DDC", Offset = "0x4492DDC", VA = "0x4496DDC")]
		private void OnEnable()
		{
            if (instance == null) instance = this;
            _ = instance != this;
        }

		[Token(Token = "0x60010AA")]
		[Address(RVA = "0x4496ED4", Offset = "0x4492ED4", VA = "0x4496ED4")]
		private void OnDisable()
		{
            if (instance == this) instance = null;
        }

		[Token(Token = "0x60010AB")]
		[Address(RVA = "0x4496F88", Offset = "0x4492F88", VA = "0x4496F88")]
		private static void CreateInstance()
		{
            GameObject helper = new GameObject("Batch Helper");
            helper.hideFlags = (HideFlags)63;
            instance = helper.AddComponent<BatchedEvents>();
            UnityEngine.Object.DontDestroyOnLoad(helper);
        }

		[Token(Token = "0x60010AC")]
		public static T Find<T, K>(K key, Func<T, K, bool> predicate) where T : class, IEntityIndex
		{
            Type type = typeof(T);
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].type == type)
                {
                    T[] objects = data[i].objects as T[];
                    for (int j = 0; j < data[i].objectCount; j++)
                    {
                        if (predicate(objects[j], key)) return objects[j];
                    }
                }
            }
            return null;
        }

		[Token(Token = "0x60010AD")]
		public static void Remove<T>(T obj) where T : IEntityIndex
		{
            int entityIndex = obj.EntityIndex;
            if (entityIndex == 0) return;
            int typeIndex = ((entityIndex >> 22) & 255) - 1;
            if (isIterating && isIteratingOverTypeIndex == typeIndex)
                throw new Exception("Cannot add or remove entities during an event (Update/LateUpdate/...) that this helper initiated");
            data[typeIndex].Remove(entityIndex & ~ArchetypeMask);
        }

		[Token(Token = "0x60010AE")]
		public static int GetComponents<T>(Event eventTypes, out TransformAccessArray transforms, out T[] components) where T : Component, IEntityIndex
		{
            if (instance == null) CreateInstance();
            int variant = unchecked((int)eventTypes * 12582917);
            if (isIterating && isIteratingOverTypeIndex == variant)
                throw new Exception("Cannot add or remove entities during an event (Update/LateUpdate/...) that this helper initiated");
            Type type = typeof(T);
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].type == type && data[i].variant == variant)
                {
                    transforms = data[i].transforms;
                    components = data[i].objects as T[];
                    return data[i].objectCount;
                }
            }
            transforms = default;
            components = null;
            return 0;
        }

		[Token(Token = "0x60010AF")]
		public static bool Has<T>(T obj) where T : IEntityIndex
		{ return obj.EntityIndex != 0; }

		[Token(Token = "0x60010B0")]
		public static void Add<T>(T obj, Event eventTypes, Action<T[], int> action, int archetypeVariant = 0) where T : Component, IEntityIndex
		{ Add(obj, eventTypes, null, action, archetypeVariant); }

		[Token(Token = "0x60010B1")]
		public static void Add<T>(T obj, Event eventTypes, Action<T[], int, TransformAccessArray, Event> action, int archetypeVariant = 0) where T : Component, IEntityIndex
		{ Add(obj, eventTypes, action, null, archetypeVariant); }

		[Token(Token = "0x60010B2")]
		private static void Add<T>(T obj, Event eventTypes, Action<T[], int, TransformAccessArray, Event> action1, Action<T[], int> action2, int archetypeVariant = 0) where T : Component, IEntityIndex
		{
            if (obj.EntityIndex != 0)
                throw new ArgumentException("This object is already registered. Call Remove before adding the object again.");
            if (instance == null) CreateInstance();
            int variant = unchecked((int)eventTypes * 12582917);
            if (isIterating && isIteratingOverTypeIndex == variant)
                throw new Exception("Cannot add or remove entities during an event (Update/LateUpdate/...) that this helper initiated");
            Type type = obj.GetType();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].type == type && data[i].variant == variant)
                {
                    data[i].Add(obj);
                    return;
                }
            }
            var closure = new _003C_003Ec__DisplayClass17_0<T>();
            Memory.Realloc(ref data, unchecked(data.Length + 1));
            closure.ac1 = action1;
            closure.ac2 = action2;
            var callback1 = new Action<object[], int, TransformAccessArray, Event>(closure._003CAdd_003Eb__0);
            var callback2 = new Action<object[], int, TransformAccessArray, Event>(closure._003CAdd_003Eb__1);
            int length = data.Length;
            Action<object[], int, TransformAccessArray, Event> callback = closure.ac1 != null ? callback1 : callback2;
            CustomSampler sampler = CustomSampler.Create(type.Name, false);
            data[unchecked(length - 1)] = new Archetype
            {
                objects = null,
                objectCount = 0,
                type = type,
                transforms = default,
                variant = variant,
                archetypeIndex = length,
                events = eventTypes,
                action = callback,
                sampler = sampler
            };
            data[unchecked(data.Length - 1)].Add(obj);
        }

		[Token(Token = "0x60010B3")]
		[Address(RVA = "0x4497094", Offset = "0x4493094", VA = "0x4497094")]
		private void Process(Event eventType, Type typeFilter)
		{
            isIterating = true;
            try
            {
                for (int i = 0; i < data.Length; i++)
                {
                    ref Archetype archetype = ref data[i];
                    if (archetype.objectCount >= 1 && (archetype.events & eventType) != 0 &&
                        (typeFilter == null || typeFilter == archetype.type))
                    {
                        isIteratingOverTypeIndex = archetype.variant;
                        archetype.action(archetype.objects, archetype.objectCount, archetype.transforms, eventType);
                    }
                }
            }
            finally
            {
                isIterating = false;
            }
        }

		[Token(Token = "0x60010B4")]
		public static void ProcessEvent<T>(Event eventType)
		{
            instance?.Process(eventType, typeof(T));
        }

		[Token(Token = "0x60010B5")]
		[Address(RVA = "0x449735C", Offset = "0x449335C", VA = "0x449735C")]
		private void Update()
		{ Process(Event.Update, null); }

		[Token(Token = "0x60010B6")]
		[Address(RVA = "0x4497368", Offset = "0x4493368", VA = "0x4497368")]
		private void LateUpdate()
		{ Process(Event.LateUpdate, null); }

		[Token(Token = "0x60010B7")]
		[Address(RVA = "0x4497374", Offset = "0x4493374", VA = "0x4497374")]
		private void FixedUpdate()
		{ Process(Event.FixedUpdate, null); }

		[Token(Token = "0x60010B8")]
		[Address(RVA = "0x4497380", Offset = "0x4493380", VA = "0x4497380")]
		public BatchedEvents()
		{
		}
	        [Token(Token = "0x20002A2")]
        [System.Runtime.CompilerServices.CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass17_0<T> where T : Component, IEntityIndex
        {
            [Token(Token = "0x4000BF6")]
            [FieldOffset(Offset = "0x0")]
            public Action<T[], int, TransformAccessArray, Event> ac1;
            [Token(Token = "0x4000BF7")]
            [FieldOffset(Offset = "0x0")]
            public Action<T[], int> ac2;
            [Token(Token = "0x60010BC")]
            public _003C_003Ec__DisplayClass17_0() { }
            [Token(Token = "0x60010BD")]
            internal void _003CAdd_003Eb__0(object[] objs, int count, TransformAccessArray tr, Event ev)
            {
                Action<T[], int, TransformAccessArray, Event> callback = ac1;
                if (callback is null) throw new NullReferenceException();
                callback((T[])objs, count, tr, ev);
            }
            [Token(Token = "0x60010BE")]
            internal void _003CAdd_003Eb__1(object[] objs, int count, TransformAccessArray tr, Event ev)
            {
                Action<T[], int> callback = ac2;
                if (callback is null) throw new NullReferenceException();
                callback((T[])objs, count);
            }
        }
}
}
