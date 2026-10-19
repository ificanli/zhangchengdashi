Shader "Definitive Stylized Water URP" {
	Properties {
		_DepthGradient1 ("DepthGradient1", Vector) = (0.1098039,0.5960785,0.6196079,1)
		_DepthGradient2 ("DepthGradient2", Vector) = (0.05882353,0.1960784,0.4627451,1)
		_DepthGradient3 ("DepthGradient3", Vector) = (0,0.0625,0.25,1)
		_GradientPosition1 ("GradientPosition1", Float) = 1.6
		_GradientPosition2 ("GradientPosition2", Float) = 2
		_FresnelColor ("FresnelColor", Vector) = (0.5764706,0.6980392,0.8000001,1)
		_FresnelExp ("FresnelExp", Range(0, 10)) = 10
		_Roughness ("Roughness", Range(0.01, 1)) = 0.6357628
		_LightColorIntensity ("LightColorIntensity", Range(0, 1)) = 0.7759457
		_SpecularIntensity ("SpecularIntensity", Range(0, 1)) = 1
		_FoamColor ("FoamColor", Vector) = (0.854902,0.9921569,1,1)
		_MainFoamScale ("Main Foam Scale", Float) = 40
		_MainFoamIntensity ("Main Foam Intensity", Range(0, 10)) = 3.84466
		_MainFoamSpeed ("Main Foam Speed", Float) = 0.1
		_MainFoamOpacity ("Main Foam Opacity", Range(0, 1)) = 0.8737864
		_SecondaryFoamScale ("Secondary Foam Scale", Float) = 40
		_SecondaryFoamIntensity ("Secondary Foam Intensity", Range(0, 10)) = 2.330097
		_SecondaryFoamOpacity ("Secondary Foam Opacity", Range(0, 1)) = 0.6310679
		[MaterialToggle] _SecondaryFoamAlwaysVisible ("Secondary Foam Always Visible", Float) = 1
		_TurbulenceDistortionIntesity ("Turbulence Distortion Intesity", Range(0, 6)) = 0.8155341
		_TurbulenceScale ("Turbulence Scale", Float) = 10
		_WaveDistortionIntensity ("WaveDistortion Intensity", Range(0, 4)) = 0.592233
		_WavesDirection ("Waves Direction", Range(0, 360)) = 0
		_WavesAmplitude ("Waves Amplitude", Range(0, 10)) = 4.980582
		_WavesSpeed ("Waves Speed", Float) = 1
		_WavesIntensity ("Waves Intensity", Float) = 2
		[MaterialToggle] _VertexOffset ("Vertex Offset", Float) = 0
		_OpacityDepth ("OpacityDepth", Float) = 5
		_Opacity ("Opacity", Range(0, 1)) = 0.7378641
		_RefractionIntensity ("Refraction Intensity", Float) = 1
		_DistortionTexture ("DistortionTexture", 2D) = "white" {}
		_FoamTexture ("FoamTexture", 2D) = "white" {}
		_ReflectionTex ("ReflectionTex", 2D) = "white" {}
		[HideInInspector] _Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
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
	//CustomEditor "CustomMaterialInspectorURP"
}