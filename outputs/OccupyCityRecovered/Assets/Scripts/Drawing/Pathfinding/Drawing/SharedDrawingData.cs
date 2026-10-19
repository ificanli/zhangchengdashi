using Il2CppDummyDll;
using Unity.Burst;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x2000029")]
	public static class SharedDrawingData
	{
		[Token(Token = "0x200002A")]
		private class BurstTimeKey
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x46DE47C", Offset = "0x46DA47C", VA = "0x46DE47C")]
			public BurstTimeKey()
			{
			}
		}

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SharedStatic<float> BurstTime;
	}
}
