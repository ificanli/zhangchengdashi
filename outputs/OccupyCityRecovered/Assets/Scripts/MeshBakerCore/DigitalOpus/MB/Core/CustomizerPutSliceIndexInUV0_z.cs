using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000030")]
	[CreateAssetMenu(fileName = "MeshAssignCustomizerSimpleAPIPutSliceIdxInUV0_z", menuName = "Mesh Baker/Assign To Mesh Customizer/Simple API Put Slice Index In UV0.z", order = 1)]
	public class CustomizerPutSliceIndexInUV0_z : MB_DefaultMeshAssignCustomizer
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x7447508", Offset = "0x7443508", VA = "0x7447508", Slot = "13")]
		public override void meshAssign_UV0(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x7447710", Offset = "0x7443710", VA = "0x7447710")]
		public CustomizerPutSliceIndexInUV0_z()
		{
		}
	}
}
