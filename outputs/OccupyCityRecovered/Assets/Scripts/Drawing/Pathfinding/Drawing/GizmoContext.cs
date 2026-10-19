using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x2000045")]
	public static class GizmoContext
	{
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<Transform> selectedTransforms;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x8")]
		internal static bool drawingGizmos;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x9")]
		internal static bool dirty;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xC")]
		private static int selectionSizeInternal;

		[Token(Token = "0x1700001B")]
		public static int selectionSize
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x46E70A0", Offset = "0x46E30A0", VA = "0x46E70A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x46E70FC", Offset = "0x46E30FC", VA = "0x46E70FC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x46E7158", Offset = "0x46E3158", VA = "0x46E7158")]
		internal static void SetDirty()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x46E70F8", Offset = "0x46E30F8", VA = "0x46E70F8")]
		private static void Refresh()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x46E71B4", Offset = "0x46E31B4", VA = "0x46E71B4")]
		public static bool InSelection(Component c)
		{
			return default;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x46E7224", Offset = "0x46E3224", VA = "0x46E7224")]
		public static bool InSelection(Transform tr)
		{
			return default;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x46E736C", Offset = "0x46E336C", VA = "0x46E736C")]
		public static bool InActiveSelection(Component c)
		{
			return default;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x46E73D4", Offset = "0x46E33D4", VA = "0x46E73D4")]
		public static bool InActiveSelection(Transform tr)
		{
			return default;
		}
	}
}
