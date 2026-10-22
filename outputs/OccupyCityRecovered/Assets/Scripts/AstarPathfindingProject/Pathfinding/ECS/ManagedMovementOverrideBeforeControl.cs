using System;
using Il2CppDummyDll;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20002F8")]
	public class ManagedMovementOverrideBeforeControl : ManagedMovementOverride<BeforeControlDelegate>, ICloneable
	{
		[Token(Token = "0x60012C6")]
		[Address(RVA = "0x44B4E08", Offset = "0x44B0E08", VA = "0x44B4E08", Slot = "4")]
		public object Clone()
		{
            return new ManagedMovementOverrideBeforeControl();
        }

		[Token(Token = "0x60012C7")]
		[Address(RVA = "0x44B4E58", Offset = "0x44B0E58", VA = "0x44B4E58")]
		public ManagedMovementOverrideBeforeControl()
		{
		}
	}
}
