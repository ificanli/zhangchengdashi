using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200012B")]
	public class MB3_MeshBakerGrouperGrid : MB3_MeshBakerGrouperBehaviour
	{
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x74B4840", Offset = "0x74B0840", VA = "0x74B4840", Slot = "4")]
		public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection, GrouperData d)
		{
			return null;
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x74B4D70", Offset = "0x74B0D70", VA = "0x74B4D70", Slot = "5")]
		public override void DrawGizmos(Bounds sourceObjectBounds, GrouperData d)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x74B520C", Offset = "0x74B120C", VA = "0x74B520C", Slot = "6")]
		public override MB3_MeshBakerGrouper.ClusterType GetClusterType()
		{
			return default;
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x74B5214", Offset = "0x74B1214", VA = "0x74B5214")]
		public MB3_MeshBakerGrouperGrid()
		{
		}
	}
}
