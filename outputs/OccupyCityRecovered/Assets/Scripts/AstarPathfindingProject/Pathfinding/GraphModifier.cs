using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000075")]
	[ExecuteInEditMode]
	public abstract class GraphModifier : VersionedMonoBehaviour
	{
		[Token(Token = "0x2000076")]
		public enum EventType
		{
			[Token(Token = "0x40002A5")]
			PostScan = 1,
			[Token(Token = "0x40002A6")]
			PreScan = 2,
			[Token(Token = "0x40002A7")]
			LatePostScan = 4,
			[Token(Token = "0x40002A8")]
			PreUpdate = 8,
			[Token(Token = "0x40002A9")]
			PostUpdate = 0x10,
			[Token(Token = "0x40002AA")]
			PostCacheLoad = 0x20,
			[Token(Token = "0x40002AB")]
			PostUpdateBeforeAreaRecalculation = 0x40,
			[Token(Token = "0x40002AC")]
			PostGraphLoad = 0x80
		}

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x0")]
		private static GraphModifier root;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x28")]
		private GraphModifier prev;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x30")]
		private GraphModifier next;

		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		protected ulong uniqueID;

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x8")]
		protected static Dictionary<ulong, GraphModifier> usedIDs;

		[Token(Token = "0x6000438")]
		protected static List<T> GetModifiersOfType<T>() where T : GraphModifier
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x44FDEC8", Offset = "0x44F9EC8", VA = "0x44FDEC8")]
		public static void FindAllModifiers()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x44FDFF4", Offset = "0x44F9FF4", VA = "0x44FDFF4")]
		public static void TriggerEvent(EventType type)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x44FE488", Offset = "0x44FA488", VA = "0x44FE488", Slot = "15")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x44FE834", Offset = "0x44FA834", VA = "0x44FE834", Slot = "16")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x44FE838", Offset = "0x44FA838", VA = "0x44FE838", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x44FE708", Offset = "0x44FA708", VA = "0x44FE708")]
		private void ConfigureUniqueID()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x44FE638", Offset = "0x44FA638", VA = "0x44FE638")]
		private void AddToLinkedList()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x44FE4A8", Offset = "0x44FA4A8", VA = "0x44FE4A8")]
		private void RemoveFromLinkedList()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x44FE854", Offset = "0x44FA854", VA = "0x44FE854", Slot = "17")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x44FE8D4", Offset = "0x44FA8D4", VA = "0x44FE8D4", Slot = "18")]
		public virtual void OnPostScan()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x44FE8D8", Offset = "0x44FA8D8", VA = "0x44FE8D8", Slot = "19")]
		public virtual void OnPreScan()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x44FE8DC", Offset = "0x44FA8DC", VA = "0x44FE8DC", Slot = "20")]
		public virtual void OnLatePostScan()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x44FE8E0", Offset = "0x44FA8E0", VA = "0x44FE8E0", Slot = "21")]
		public virtual void OnPostCacheLoad()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x44FE8E4", Offset = "0x44FA8E4", VA = "0x44FE8E4", Slot = "22")]
		public virtual void OnPostGraphLoad()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x44FE8E8", Offset = "0x44FA8E8", VA = "0x44FE8E8", Slot = "23")]
		public virtual void OnGraphsPreUpdate()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x44FE8EC", Offset = "0x44FA8EC", VA = "0x44FE8EC", Slot = "24")]
		public virtual void OnGraphsPostUpdate()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x44FE8F0", Offset = "0x44FA8F0", VA = "0x44FE8F0", Slot = "25")]
		public virtual void OnGraphsPostUpdateBeforeAreaRecalculation()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x44FE8F4", Offset = "0x44FA8F4", VA = "0x44FE8F4", Slot = "13")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x44F86AC", Offset = "0x44F46AC", VA = "0x44F86AC")]
		protected GraphModifier()
		{
		}
	}
}
