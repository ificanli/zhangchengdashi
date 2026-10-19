using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200012B")]
	[ExecuteAlways]
	public abstract class NavmeshClipper : VersionedMonoBehaviour
	{
		[Token(Token = "0x4000667")]
		[FieldOffset(Offset = "0x0")]
		private static Action<NavmeshClipper> OnEnableCallback;

		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0x8")]
		private static Action<NavmeshClipper> OnDisableCallback;

		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<NavmeshClipper> all;

		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x28")]
		private int listIndex;

		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x2C")]
		public GraphMask graphMask;

		[Token(Token = "0x170001CA")]
		public static List<NavmeshClipper> allEnabled
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x455A960", Offset = "0x4556960", VA = "0x455A960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x455A600", Offset = "0x4556600", VA = "0x455A600")]
		internal static void RefreshEnabledList()
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x455A6E0", Offset = "0x45566E0", VA = "0x455A6E0")]
		public static void AddEnableCallback(Action<NavmeshClipper> onEnable, Action<NavmeshClipper> onDisable)
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x455A820", Offset = "0x4556820", VA = "0x455A820")]
		public static void RemoveEnableCallback(Action<NavmeshClipper> onEnable, Action<NavmeshClipper> onDisable)
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x455A9B8", Offset = "0x45569B8", VA = "0x455A9B8", Slot = "15")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x455AAF0", Offset = "0x4556AF0", VA = "0x455AAF0", Slot = "16")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60009E0")]
		public abstract void NotifyUpdated(GridLookup<NavmeshClipper>.Root previousState);

		[Token(Token = "0x60009E1")]
		public abstract Bounds GetBounds(GraphTransform transform, float radiusMargin);

		[Token(Token = "0x60009E2")]
		public abstract bool RequiresUpdate(GridLookup<NavmeshClipper>.Root previousState);

		[Token(Token = "0x60009E3")]
		public abstract void ForceUpdate();

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x455A584", Offset = "0x4556584", VA = "0x455A584")]
		protected NavmeshClipper()
		{
		}
	}
}
