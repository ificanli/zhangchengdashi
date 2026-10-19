using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200002F")]
	[CreateAssetMenu(fileName = "MeshAssignCustomizerNativeArrayPutSliceIdxInUV0_z", menuName = "Mesh Baker/Assign To Mesh Customizer/NativeArray API Put Slice Index In UV0.z", order = 1)]
	public class CustomizerNativeArrayPutSliceIndexInUV0_z : MB_DefaultMeshAssignCustomizer_NativeArray
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x7447348", Offset = "0x7443348", VA = "0x7447348", Slot = "7")]
		public override int UVchannelWithExtraParameter()
		{
			return default;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x7447350", Offset = "0x7443350", VA = "0x7447350", Slot = "8")]
		public override void meshAssign_UV(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, NativeSlice<Vector3> outUVsInMesh, NativeSlice<float> sliceIndexes)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x7447500", Offset = "0x7443500", VA = "0x7447500")]
		public CustomizerNativeArrayPutSliceIndexInUV0_z()
		{
		}
	}
}
