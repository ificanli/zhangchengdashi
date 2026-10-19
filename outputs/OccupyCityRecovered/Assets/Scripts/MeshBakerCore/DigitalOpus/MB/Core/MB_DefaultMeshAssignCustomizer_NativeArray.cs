using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000CF")]
	public class MB_DefaultMeshAssignCustomizer_NativeArray : ScriptableObject, IAssignToMeshCustomizer_NativeArrays, IAssignToMeshCustomizer
	{
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x7487944", Offset = "0x7483944", VA = "0x7487944", Slot = "7")]
		public virtual int UVchannelWithExtraParameter()
		{
			return default;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x748794C", Offset = "0x748394C", VA = "0x748794C", Slot = "8")]
		public virtual void meshAssign_UV(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, NativeSlice<Vector3> outUVsInMesh, NativeSlice<float> sliceIndexes)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x7487950", Offset = "0x7483950", VA = "0x7487950", Slot = "9")]
		public virtual void meshAssign_colors(MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, NativeSlice<Color> outUVsInMesh, NativeSlice<float> sliceIndexes)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x7487954", Offset = "0x7483954", VA = "0x7487954")]
		public MB_DefaultMeshAssignCustomizer_NativeArray()
		{
		}
	}
}
