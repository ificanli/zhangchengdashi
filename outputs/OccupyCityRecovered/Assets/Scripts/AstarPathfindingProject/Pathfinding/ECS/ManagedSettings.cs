using System;
using Il2CppDummyDll;
using Unity.Entities;
using Unity.Properties;
using UnityEngine.Scripting;

namespace Pathfinding.ECS
{
	[Serializable]
	[Token(Token = "0x20002FB")]
	[TypeManager.TypeOverrides(true, true, true)]
	[GeneratePropertyBag]
	public class ManagedSettings : IComponentData, IQueryTypeParameter, ICloneable, IEquatable<ManagedSettings>
	{
		[NonSerialized]
		[Token(Token = "0x4000D9D")]
		[FieldOffset(Offset = "0x10")]
		public IOffMeshLinkHandler onTraverseOffMeshLink;

		[Token(Token = "0x4000D9E")]
		[FieldOffset(Offset = "0x18")]
		public PathRequestSettings pathfindingSettings;

		[Token(Token = "0x60012CC")]
		[Address(RVA = "0x44B4FD0", Offset = "0x44B0FD0", VA = "0x44B4FD0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Token(Token = "0x60012CD")]
		[Address(RVA = "0x44B4FD8", Offset = "0x44B0FD8", VA = "0x44B4FD8")]
		public ManagedSettings CloneAndSimplifyDefaults(bool simplify)
		{
			return null;
		}

		[Token(Token = "0x60012CE")]
		[Address(RVA = "0x44B51AC", Offset = "0x44B11AC", VA = "0x44B51AC", Slot = "5")]
		public bool Equals(ManagedSettings other)
		{
			return default;
		}

		[Token(Token = "0x60012CF")]
		[Address(RVA = "0x44B51A4", Offset = "0x44B11A4", VA = "0x44B51A4")]
		[Preserve]
		public ManagedSettings()
		{
		}
	}
}
