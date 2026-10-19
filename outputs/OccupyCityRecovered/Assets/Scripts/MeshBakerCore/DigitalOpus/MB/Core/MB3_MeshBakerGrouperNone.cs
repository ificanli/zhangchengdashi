using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200012A")]
	public class MB3_MeshBakerGrouperNone : MB3_MeshBakerGrouperBehaviour
	{
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x74B45B4", Offset = "0x74B05B4", VA = "0x74B45B4", Slot = "4")]
		public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection, GrouperData d)
		{
			return null;
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x74B482C", Offset = "0x74B082C", VA = "0x74B482C", Slot = "5")]
		public override void DrawGizmos(Bounds sourceObjectBounds, GrouperData d)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x74B4830", Offset = "0x74B0830", VA = "0x74B4830", Slot = "6")]
		public override MB3_MeshBakerGrouper.ClusterType GetClusterType()
		{
			return default;
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x74B4838", Offset = "0x74B0838", VA = "0x74B4838")]
		public MB3_MeshBakerGrouperNone()
		{
		}
	}
}
