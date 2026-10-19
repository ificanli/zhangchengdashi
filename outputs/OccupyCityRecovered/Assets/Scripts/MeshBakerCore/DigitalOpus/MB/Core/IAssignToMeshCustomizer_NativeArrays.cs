using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000C4")]
	public interface IAssignToMeshCustomizer_NativeArrays : IAssignToMeshCustomizer
	{
		[Token(Token = "0x60003E6")]
		int UVchannelWithExtraParameter();

		[Token(Token = "0x60003E7")]
		void meshAssign_UV(int channel_0_to_7, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, NativeSlice<Vector3> outUVsInMesh, NativeSlice<float> sliceIndexes);

		[Token(Token = "0x60003E8")]
		void meshAssign_colors(MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, NativeSlice<Color> outUVsInMesh, NativeSlice<float> sliceIndexes);
	}
}
