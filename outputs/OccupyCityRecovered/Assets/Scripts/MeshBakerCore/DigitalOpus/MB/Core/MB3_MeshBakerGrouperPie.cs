using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200012C")]
	public class MB3_MeshBakerGrouperPie : MB3_MeshBakerGrouperBehaviour
	{
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x74B521C", Offset = "0x74B121C", VA = "0x74B521C", Slot = "4")]
		public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection, GrouperData d)
		{
			return null;
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x74B5B88", Offset = "0x74B1B88", VA = "0x74B5B88", Slot = "5")]
		public override void DrawGizmos(Bounds sourceObjectBounds, GrouperData d)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x74B6458", Offset = "0x74B2458", VA = "0x74B6458")]
		private static int MaxIndexInVector3(Vector3 v)
		{
			return default;
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x74B6124", Offset = "0x74B2124", VA = "0x74B6124")]
		public static void DrawCircle(Vector3 axis, Vector3 center, float radius, int subdiv)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x74B6474", Offset = "0x74B2474", VA = "0x74B6474", Slot = "6")]
		public override MB3_MeshBakerGrouper.ClusterType GetClusterType()
		{
			return default;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x74B647C", Offset = "0x74B247C", VA = "0x74B647C")]
		public MB3_MeshBakerGrouperPie()
		{
		}
	}
}
