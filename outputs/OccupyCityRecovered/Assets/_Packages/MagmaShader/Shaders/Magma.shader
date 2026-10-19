Shader "Shader Graphs/Magma" {
	Properties {
		[NoScaleOffset] _FlowMap ("FlowMap", 2D) = "white" {}
		_FlowMapTiling ("FlowMapTiling", Float) = 1
		_FlowMapSpeed ("FlowMapSpeed", Float) = 0.5
		_FlowMapStrength ("FlowMapStrength", Float) = 1
		[NoScaleOffset] _ForegroundTexture ("ForegroundTexture", 2D) = "white" {}
		[HDR] _ForegroundTextureColor ("ForegroundTextureColor", Vector) = (0.8666667,0.6170942,0.1019608,0)
		_ForegroundTextureTiling ("ForegroundTextureTiling", Float) = 1
		_ForegroundTextureSpeed ("ForegroundTextureSpeed", Float) = 0
		[NoScaleOffset] _MiddlegroundTexture ("MiddlegroundTexture", 2D) = "white" {}
		[HDR] _MiddleGroundTextureColor ("MiddleGroundTextureColor", Vector) = (0.9622642,0.1711865,0,1)
		[HDR] _MiddlegroundTextureColor2 ("MiddlegroundTextureColor2", Vector) = (0.8980392,0.0715861,0.05490194,1)
		_MiddlegroundTextureTiling ("MiddlegroundTextureTiling", Float) = 1
		_MiddlegroundTextureStrenght ("MiddlegroundTextureStrenght", Float) = 1
		[NoScaleOffset] _BackgroundTexture ("BackgroundTexture", 2D) = "white" {}
		[HDR] _BackgroundColor ("BackgroundColor", Vector) = (0.254717,0,0,0)
		_BackgroundTextureTiling ("BackgroundTextureTiling", Float) = 1
		_BackgroundTextureSpeed ("BackgroundTextureSpeed", Float) = 0.03
		[NoScaleOffset] _HeightMapTexture ("HeightMapTexture", 2D) = "white" {}
		[HDR] _HeightColor ("HeightColor", Vector) = (0.95,0.6016666,0,0)
		_HeightColorPosition ("HeightColorStrength", Float) = 0.88
		_HeightMapTiling ("HeightMapTiling", Float) = 0.04
		_HeightMapStrength ("HeightMapStrength", Float) = 1
		_HeightTextureSpeed ("HeightTextureSpeed", Float) = 0.01
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}