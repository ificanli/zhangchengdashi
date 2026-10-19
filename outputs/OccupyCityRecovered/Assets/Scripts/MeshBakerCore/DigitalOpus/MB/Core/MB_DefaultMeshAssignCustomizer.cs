using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000C1")]
	public class MB_DefaultMeshAssignCustomizer : ScriptableObject, IAssignToMeshCustomizer_SimpleAPI, IAssignToMeshCustomizer
	{
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x7484910", Offset = "0x7480910", VA = "0x7484910", Slot = "13")]
		public virtual void meshAssign_UV0(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x748492C", Offset = "0x748092C", VA = "0x748492C", Slot = "14")]
		public virtual void meshAssign_UV2(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x7484948", Offset = "0x7480948", VA = "0x7484948", Slot = "15")]
		public virtual void meshAssign_UV3(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x7484964", Offset = "0x7480964", VA = "0x7484964", Slot = "16")]
		public virtual void meshAssign_UV4(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x7484980", Offset = "0x7480980", VA = "0x7484980", Slot = "17")]
		public virtual void meshAssign_UV5(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x748499C", Offset = "0x748099C", VA = "0x748499C", Slot = "18")]
		public virtual void meshAssign_UV6(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x74849B8", Offset = "0x74809B8", VA = "0x74849B8", Slot = "19")]
		public virtual void meshAssign_UV7(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x74849D4", Offset = "0x74809D4", VA = "0x74849D4", Slot = "20")]
		public virtual void meshAssign_UV8(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x74849F0", Offset = "0x74809F0", VA = "0x74849F0", Slot = "21")]
		public virtual void meshAssign_colors(MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Color[] colors, float[] sliceIndexes)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x7484A0C", Offset = "0x7480A0C", VA = "0x7484A0C")]
		public static void DefaultDelegateAssignMeshColors(MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Color[] colors, float[] sliceIndexes)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x7484A28", Offset = "0x7480A28", VA = "0x7484A28")]
		public MB_DefaultMeshAssignCustomizer()
		{
		}
	}
}
