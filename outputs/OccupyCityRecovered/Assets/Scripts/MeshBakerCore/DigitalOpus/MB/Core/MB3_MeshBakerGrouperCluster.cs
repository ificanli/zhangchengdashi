using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200012D")]
	public class MB3_MeshBakerGrouperCluster : MB3_MeshBakerGrouperBehaviour
	{
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x74B6484", Offset = "0x74B2484", VA = "0x74B6484", Slot = "4")]
		public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection, GrouperData d)
		{
			return null;
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x74B6798", Offset = "0x74B2798", VA = "0x74B6798")]
		public void BuildClusters(List<GameObject> gos, ProgressUpdateCancelableDelegate progFunc, GrouperData d)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x74B6C34", Offset = "0x74B2C34", VA = "0x74B6C34")]
		public void _BuildListOfClustersToDraw(ProgressUpdateCancelableDelegate progFunc, out float smallest, out float largest, GrouperData d)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshBakerGrouperCluster._BuildListOfClustersToDraw RVA=0x74B6C34 Token=0x600067A");
}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x74B74AC", Offset = "0x74B34AC", VA = "0x74B74AC", Slot = "5")]
		public override void DrawGizmos(Bounds sceneObjectBounds, GrouperData d)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x74B75E8", Offset = "0x74B35E8", VA = "0x74B75E8", Slot = "6")]
		public override MB3_MeshBakerGrouper.ClusterType GetClusterType()
		{
			return default;
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x74B75F0", Offset = "0x74B35F0", VA = "0x74B75F0")]
		public MB3_MeshBakerGrouperCluster()
		{
		}
	}
}
