using Il2CppDummyDll;

namespace Pathfinding.ECS
{
	[Token(Token = "0x200030D")]
	internal static class EntityAccessHelper
	{
		[Token(Token = "0x4000DDB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int GlobalSystemVersionOffset =
            Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetFieldOffset(
                typeof(Unity.Entities.ComponentTypeHandle<int>).GetField("m_GlobalSystemVersion",
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic));
	}
}
