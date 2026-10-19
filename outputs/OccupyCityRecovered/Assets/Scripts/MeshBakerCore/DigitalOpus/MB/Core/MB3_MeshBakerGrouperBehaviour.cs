using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000128")]
	public abstract class MB3_MeshBakerGrouperBehaviour
	{
		[Token(Token = "0x6000661")]
		public abstract Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection, GrouperData d);

		[Token(Token = "0x6000662")]
		public abstract void DrawGizmos(Bounds sourceObjectBounds, GrouperData d);

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x74B2FF4", Offset = "0x74AEFF4", VA = "0x74B2FF4")]
		public List<MB3_MeshBakerCommon> DoClustering(MB3_TextureBaker tb, MB3_MeshBakerGrouper grouper, GrouperData d)
		{
			return null;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x74B3F70", Offset = "0x74AFF70", VA = "0x74B3F70")]
		private Dictionary<int, List<Renderer>> GroupByLightmapIndex(List<Renderer> gaws)
		{
			return null;
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x74B41D8", Offset = "0x74B01D8", VA = "0x74B41D8")]
		private MB3_MeshBakerCommon AddMeshBaker(MB3_MeshBakerGrouper grouper, MB3_TextureBaker tb, string key, List<Renderer> gaws)
		{
			return null;
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x74B4538", Offset = "0x74B0538", VA = "0x74B4538", Slot = "6")]
		public virtual MB3_MeshBakerGrouper.ClusterType GetClusterType()
		{
			return default;
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x74B4540", Offset = "0x74B0540", VA = "0x74B4540")]
		protected MB3_MeshBakerGrouperBehaviour()
		{
		}
	}
}
