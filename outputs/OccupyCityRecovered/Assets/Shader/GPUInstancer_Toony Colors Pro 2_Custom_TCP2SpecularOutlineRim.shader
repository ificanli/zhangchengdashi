Shader "GPUInstancer/Toony Colors Pro 2/Custom/TCP2SpecularOutlineRim" {
	Properties {
		[Enum(Front, 2, Back, 1, Both, 0)] _Cull ("Render Face", Float) = 2
		[TCP2ToggleNoKeyword] _ZWrite ("Depth Write", Float) = 1
		[HideInInspector] _RenderingMode ("rendering mode", Float) = 0
		[HideInInspector] _SrcBlend ("blending source", Float) = 1
		[HideInInspector] _DstBlend ("blending destination", Float) = 0
		[TCP2Separator] [TCP2HeaderHelp(Base)] _BaseColor ("Color", Vector) = (1,1,1,1)
		[TCP2ColorNoAlpha] _HColor ("Highlight Color", Vector) = (0.75,0.75,0.75,1)
		[TCP2ColorNoAlpha] _SColor ("Shadow Color", Vector) = (0.2,0.2,0.2,1)
		_BaseMap ("Albedo", 2D) = "white" {}
		[TCP2Separator] [TCP2Header(Ramp Shading)] _RampThreshold ("Threshold", Range(0.01, 1)) = 0.5
		_RampSmoothing ("Smoothing", Range(0.001, 1)) = 0.5
		[TCP2Separator] [TCP2HeaderHelp(Specular)] [Toggle(TCP2_SPECULAR)] _UseSpecular ("Enable Specular", Float) = 0
		[TCP2ColorNoAlpha] _SpecularColor ("Specular Color", Vector) = (0.5,0.5,0.5,1)
		_SpecularRoughnessPBR ("Roughness", Range(0, 1)) = 0.5
		[TCP2Separator] [TCP2HeaderHelp(Rim Lighting)] [Toggle(TCP2_RIM_LIGHTING)] _UseRim ("Enable Rim Lighting", Float) = 0
		[TCP2ColorNoAlpha] [HDR] _RimColor ("Rim Color", Vector) = (0.8,0.8,0.8,0.5)
		_RimMinVert ("Rim Min", Range(0, 2)) = 0.5
		_RimMaxVert ("Rim Max", Range(0, 2)) = 1
		[TCP2Separator] [TCP2HeaderHelp(Outline)] _OutlineWidth ("Width", Range(0.1, 4)) = 1
		_OutlineColorVertex ("Color", Vector) = (0,0,0,1)
		[TCP2MaterialKeywordEnumNoPrefix(Regular, _, Vertex Colors, TCP2_COLORS_AS_NORMALS, Tangents, TCP2_TANGENT_AS_NORMALS, UV1, TCP2_UV1_AS_NORMALS, UV2, TCP2_UV2_AS_NORMALS, UV3, TCP2_UV3_AS_NORMALS, UV4, TCP2_UV4_AS_NORMALS)] _NormalsSource ("Outline Normals Source", Float) = 0
		[TCP2MaterialKeywordEnumNoPrefix(Full XYZ, TCP2_UV_NORMALS_FULL, Compressed XY, _, Compressed ZW, TCP2_UV_NORMALS_ZW)] _NormalsUVType ("UV Data Type", Float) = 0
		[TCP2Separator] [ToggleOff(_RECEIVE_SHADOWS_OFF)] _ReceiveShadowsOff ("Receive Shadows", Float) = 1
		[HideInInspector] __dummy__ ("unused", Float) = 0
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
	Fallback "Hidden/InternalErrorShader"
	//CustomEditor "ToonyColorsPro.ShaderGenerator.MaterialInspector_SG2"
}