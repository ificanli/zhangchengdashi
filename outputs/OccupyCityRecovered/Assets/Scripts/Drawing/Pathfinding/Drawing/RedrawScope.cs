using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x200002B")]
	public struct RedrawScope : IDisposable
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal GCHandle gizmos;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int id;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int idCounter;

		[Token(Token = "0x17000009")]
		public bool isValid
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x46DE484", Offset = "0x46DA484", VA = "0x46DE484")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x46DE494", Offset = "0x46DA494", VA = "0x46DE494")]
		internal RedrawScope(DrawingData gizmos, int id)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RedrawScope..ctor RVA=0x46DE494 Token=0x60001BA");
}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x46DE4B4", Offset = "0x46DA4B4", VA = "0x46DE4B4")]
		internal RedrawScope(DrawingData gizmos)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RedrawScope..ctor RVA=0x46DE4B4 Token=0x60001BB");
}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x46DE530", Offset = "0x46DA530", VA = "0x46DE530")]
		internal void Draw()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x46DE664", Offset = "0x46DA664", VA = "0x46DE664")]
		public void Rewind()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x46DE87C", Offset = "0x46DA87C", VA = "0x46DE87C")]
		internal void DrawUntilDispose(GameObject associatedGameObject)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x46DE7E0", Offset = "0x46DA7E0", VA = "0x46DE7E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
