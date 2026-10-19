using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000041")]
	public interface MBVersionInterface
	{
		[Token(Token = "0x6000124")]
		string version();

		[Token(Token = "0x6000125")]
		bool Is_2018_3_OrNewer();

		[Token(Token = "0x6000126")]
		bool Is_2017_1_OrNewer();

		[Token(Token = "0x6000127")]
		bool GetActive(GameObject go);

		[Token(Token = "0x6000128")]
		void SetActive(GameObject go, bool isActive);

		[Token(Token = "0x6000129")]
		void SetActiveRecursively(GameObject go, bool isActive);

		[Token(Token = "0x600012A")]
		UnityEngine.Object[] FindSceneObjectsOfType(Type t);

		[Token(Token = "0x600012B")]
		bool IsRunningAndMeshNotReadWriteable(Mesh m);

		[Token(Token = "0x600012C")]
		Vector2[] GetMeshUVChannel(int channel, Mesh m, MB2_LogLevel LOG_LEVEL);

		[Token(Token = "0x600012D")]
		void MeshClear(Mesh m, bool t);

		[Token(Token = "0x600012E")]
		void MeshAssignUVChannel(int channel, Mesh m, Vector2[] uvs);

		[Token(Token = "0x600012F")]
		Vector4 GetLightmapTilingOffset(Renderer r);

		[Token(Token = "0x6000130")]
		Transform[] GetBones(Renderer r, bool isSkinnedMeshWithBones);

		[Token(Token = "0x6000131")]
		void OptimizeMesh(Mesh m);

		[Token(Token = "0x6000132")]
		int GetBlendShapeFrameCount(Mesh m, int shapeIndex);

		[Token(Token = "0x6000133")]
		float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex);

		[Token(Token = "0x6000134")]
		void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts);

		[Token(Token = "0x6000135")]
		void ClearBlendShapes(Mesh m);

		[Token(Token = "0x6000136")]
		void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts);

		[Token(Token = "0x6000137")]
		int MaxMeshVertexCount();

		[Token(Token = "0x6000138")]
		void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles);

		[Token(Token = "0x6000139")]
		bool GraphicsUVStartsAtTop();

		[Token(Token = "0x600013A")]
		bool IsTextureReadable(Texture2D tex);

		[Token(Token = "0x600013B")]
		bool IsSwizzledNormalMapPlatform();

		[Token(Token = "0x600013C")]
		bool IsMaterialKeywordValid(Material mat, string keyword);

		[Token(Token = "0x600013D")]
		bool IsTexture_sRGBgammaCorrected(Texture2D tex, bool hint);

		[Token(Token = "0x600013E")]
		bool CollectPropertyNames(List<ShaderTextureProperty> texPropertyNames, ShaderTextureProperty[] shaderTexPropertyNames, List<ShaderTextureProperty> _customShaderPropNames, Material resultMaterial, MB2_LogLevel LOG_LEVEL);

		[Token(Token = "0x600013F")]
		void DoSpecialRenderPipeline_TexturePackerFastSetup(GameObject cameraGameObject);

		[Token(Token = "0x6000140")]
		ColorSpace GetProjectColorSpace();

		[Token(Token = "0x6000141")]
		MBVersion.PipelineType DetectPipeline();

		[Token(Token = "0x6000142")]
		string UnescapeURL(string url);

		[Token(Token = "0x6000143")]
		IEnumerator FindRuntimeMaterialsFromAddresses(MB2_TextureBakeResults textureBakeResult, MB2_TextureBakeResults.CoroutineResult isComplete);

		[Token(Token = "0x6000144")]
		float GetScaleInLightmap(MeshRenderer r);

		[Token(Token = "0x6000145")]
		bool IsAssetInProject(UnityEngine.Object target);
	}
}
