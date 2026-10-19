Shader "Custom/SimpleGlass_Lite" {
	Properties {
		_Color ("Glass Color Tint", Vector) = (0.4,0.2,0.8,1)
		_Opacity ("Opacity", Range(0, 1)) = 0.25
		_Refraction ("Refraction", Range(0, 2)) = 1.05
		_Smoothness ("Smoothness", Range(0, 1)) = 0.95
		_Metallic ("Metallic", Range(0, 1)) = 0
		_FresnelPow ("Fresnel Power", Range(0.1, 8)) = 2.5
		_FresnelColor ("Fresnel Color", Vector) = (1,0.5,0.8,1)
		_FresnelStr ("Fresnel Strength", Range(0, 4)) = 1.5
		_RefractionStr ("Refraction Tint", Range(0, 1)) = 0.6
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
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

			float4 _Color;

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return _Color; // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Universal Render Pipeline/FallbackError"
}