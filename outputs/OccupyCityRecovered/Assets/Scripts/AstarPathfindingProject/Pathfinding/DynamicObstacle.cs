using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000149")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/dynamicobstacle.html")]
	[AddComponentMenu("Pathfinding/Dynamic Obstacle")]
	public class DynamicObstacle : GraphModifier, DynamicGridObstacle
	{
		[Token(Token = "0x40006E6")]
		[FieldOffset(Offset = "0x40")]
		private Collider coll;

		[Token(Token = "0x40006E7")]
		[FieldOffset(Offset = "0x48")]
		private Collider2D coll2D;

		[Token(Token = "0x40006E8")]
		[FieldOffset(Offset = "0x50")]
		private Transform tr;

		[Token(Token = "0x40006E9")]
		[FieldOffset(Offset = "0x58")]
		public float updateError;

		[Token(Token = "0x40006EA")]
		[FieldOffset(Offset = "0x5C")]
		public float checkTime;

		[Token(Token = "0x40006EB")]
		[FieldOffset(Offset = "0x60")]
		private Bounds prevBounds;

		[Token(Token = "0x40006EC")]
		[FieldOffset(Offset = "0x78")]
		private Quaternion prevRotation;

		[Token(Token = "0x40006ED")]
		[FieldOffset(Offset = "0x88")]
		private bool prevEnabled;

		[Token(Token = "0x40006EE")]
		[FieldOffset(Offset = "0x8C")]
		private float lastCheckTime;

		[Token(Token = "0x40006EF")]
		[FieldOffset(Offset = "0x90")]
		private Queue<GraphUpdateObject> pendingGraphUpdates;

		[Token(Token = "0x170001D7")]
		private Bounds bounds
		{
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x4565854", Offset = "0x4561854", VA = "0x4565854")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D8")]
		private bool colliderEnabled
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x4565980", Offset = "0x4561980", VA = "0x4565980")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D9")]
float DynamicGridObstacle.updateError
		{
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x45668B8", Offset = "0x45628B8", VA = "0x45668B8", Slot = "28")]
			get
			{
				return Pathfinding_002EDynamicGridObstacle_002Eget_updateError();
			}
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x45668C0", Offset = "0x45628C0", VA = "0x45668C0", Slot = "29")]
			set
			{
				Pathfinding_002EDynamicGridObstacle_002Eset_updateError(value);
			}
		}

		[Token(Token = "0x170001DA")]
float DynamicGridObstacle.checkTime
		{
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x45668C8", Offset = "0x45628C8", VA = "0x45668C8", Slot = "30")]
			get
			{
				return Pathfinding_002EDynamicGridObstacle_002Eget_checkTime();
			}
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x45668D0", Offset = "0x45628D0", VA = "0x45668D0", Slot = "31")]
			set
			{
				Pathfinding_002EDynamicGridObstacle_002Eset_checkTime(value);
			}
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x4565A10", Offset = "0x4561A10", VA = "0x4565A10", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x4565C10", Offset = "0x4561C10", VA = "0x4565C10", Slot = "18")]
		public override void OnPostScan()
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x4565CC0", Offset = "0x4561CC0", VA = "0x4565CC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x45666A0", Offset = "0x45626A0", VA = "0x45666A0", Slot = "16")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x45661D8", Offset = "0x45621D8", VA = "0x45661D8", Slot = "32")]
		public void DoUpdateGraphs()
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x4566838", Offset = "0x4562838", VA = "0x4566838")]
		private static float BoundsVolume(Bounds b)
		{
			return default;
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x45668B8", Offset = "0x45628B8", VA = "0x45668B8", Slot = "28")]
		private float Pathfinding_002EDynamicGridObstacle_002Eget_updateError()
		{
			return default;
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x45668C0", Offset = "0x45628C0", VA = "0x45668C0", Slot = "29")]
		private void Pathfinding_002EDynamicGridObstacle_002Eset_updateError(float value)
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x45668C8", Offset = "0x45628C8", VA = "0x45668C8", Slot = "30")]
		private float Pathfinding_002EDynamicGridObstacle_002Eget_checkTime()
		{
			return default;
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x45668D0", Offset = "0x45628D0", VA = "0x45668D0", Slot = "31")]
		private void Pathfinding_002EDynamicGridObstacle_002Eset_checkTime(float value)
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x45668D8", Offset = "0x45628D8", VA = "0x45668D8")]
		public DynamicObstacle()
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x4566990", Offset = "0x4562990", VA = "0x4566990", Slot = "26")]
		private bool Pathfinding_002EDynamicGridObstacle_002Eget_enabled()
		{
			return default;
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x4566998", Offset = "0x4562998", VA = "0x4566998", Slot = "27")]
		private void Pathfinding_002EDynamicGridObstacle_002Eset_enabled(bool value)
		{
		}
	}
}
