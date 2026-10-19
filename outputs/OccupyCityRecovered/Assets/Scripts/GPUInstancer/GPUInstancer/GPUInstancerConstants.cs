using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000032")]
	public static class GPUInstancerConstants
	{
		[Token(Token = "0x2000033")]
		public static class BufferToTextureKernelPoperties
		{
			[Token(Token = "0x4000262")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int TRANSFORMATION_MATRIX_TEXTURE;

			[Token(Token = "0x4000263")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int LOD_DATA_TEXTURE;
		}

		[Token(Token = "0x2000034")]
		public static class VisibilityKernelPoperties
		{
			[Token(Token = "0x4000264")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int TRANSFORMATION_MATRIX_BUFFER;

			[Token(Token = "0x4000265")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int INSTANCE_LOD_BUFFER;

			[Token(Token = "0x4000266")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int[] TRANSFORMATION_MATRIX_APPEND_BUFFERS;

			[Token(Token = "0x4000267")]
			[FieldOffset(Offset = "0x10")]
			public static readonly int INSTANCE_DATA_BUFFER;

			[Token(Token = "0x4000268")]
			[FieldOffset(Offset = "0x14")]
			public static readonly int RENDERER_TRANSFORM_OFFSET;

			[Token(Token = "0x4000269")]
			[FieldOffset(Offset = "0x18")]
			public static readonly int BUFFER_PARAMETER_MVP_MATRIX;

			[Token(Token = "0x400026A")]
			[FieldOffset(Offset = "0x1C")]
			public static readonly int BUFFER_PARAMETER_MVP_MATRIX2;

			[Token(Token = "0x400026B")]
			[FieldOffset(Offset = "0x20")]
			public static readonly int BUFFER_PARAMETER_BOUNDS_CENTER;

			[Token(Token = "0x400026C")]
			[FieldOffset(Offset = "0x24")]
			public static readonly int BUFFER_PARAMETER_BOUNDS_EXTENTS;

			[Token(Token = "0x400026D")]
			[FieldOffset(Offset = "0x28")]
			public static readonly int BUFFER_PARAMETER_FRUSTUM_CULL_SWITCH;

			[Token(Token = "0x400026E")]
			[FieldOffset(Offset = "0x2C")]
			public static readonly int BUFFER_PARAMETER_HIERARCHICAL_Z_TEXTURE_SIZE;

			[Token(Token = "0x400026F")]
			[FieldOffset(Offset = "0x30")]
			public static readonly int BUFFER_PARAMETER_FRUSTUM_OFFSET;

			[Token(Token = "0x4000270")]
			[FieldOffset(Offset = "0x34")]
			public static readonly int BUFFER_PARAMETER_MIN_VIEW_DISTANCE;

			[Token(Token = "0x4000271")]
			[FieldOffset(Offset = "0x38")]
			public static readonly int BUFFER_PARAMETER_MAX_VIEW_DISTANCE;

			[Token(Token = "0x4000272")]
			[FieldOffset(Offset = "0x3C")]
			public static readonly int BUFFER_PARAMETER_CAMERA_POSITION;

			[Token(Token = "0x4000273")]
			[FieldOffset(Offset = "0x40")]
			public static readonly int BUFFER_PARAMETER_BUFFER_SIZE;

			[Token(Token = "0x4000274")]
			[FieldOffset(Offset = "0x44")]
			public static readonly int BUFFER_PARAMETER_OCCLUSION_OFFSET;

			[Token(Token = "0x4000275")]
			[FieldOffset(Offset = "0x48")]
			public static readonly int BUFFER_PARAMETER_OCCLUSION_ACCURACY;

			[Token(Token = "0x4000276")]
			[FieldOffset(Offset = "0x4C")]
			public static readonly int BUFFER_PARAMETER_SHADOW_DISTANCE;

			[Token(Token = "0x4000277")]
			[FieldOffset(Offset = "0x50")]
			public static readonly int BUFFER_PARAMETER_LOD_SIZES;

			[Token(Token = "0x4000278")]
			[FieldOffset(Offset = "0x54")]
			public static readonly int BUFFER_PARAMETER_LOD_SHIFT;

			[Token(Token = "0x4000279")]
			[FieldOffset(Offset = "0x58")]
			public static readonly int BUFFER_PARAMETER_LOD_APPEND_INDEX;

			[Token(Token = "0x400027A")]
			[FieldOffset(Offset = "0x5C")]
			public static readonly int BUFFER_PARAMETER_LOD_COUNT;

			[Token(Token = "0x400027B")]
			[FieldOffset(Offset = "0x60")]
			public static readonly int BUFFER_PARAMETER_LOD_LEVEL;

			[Token(Token = "0x400027C")]
			[FieldOffset(Offset = "0x64")]
			public static readonly int BUFFER_PARAMETER_HALF_ANGLE;

			[Token(Token = "0x400027D")]
			[FieldOffset(Offset = "0x68")]
			public static readonly int BUFFER_PARAMETER_ANIMATE_CROSS_FADE;

			[Token(Token = "0x400027E")]
			[FieldOffset(Offset = "0x6C")]
			public static readonly int BUFFER_PARAMETER_DELTA_TIME;

			[Token(Token = "0x400027F")]
			[FieldOffset(Offset = "0x70")]
			public static readonly int BUFFER_PARAMETER_FADE_LEVEL_MULTIPLIER;

			[Token(Token = "0x4000280")]
			[FieldOffset(Offset = "0x74")]
			public static readonly int BUFFER_PARAMETER_OCCLUSION_CULL_SWITCH;

			[Token(Token = "0x4000281")]
			[FieldOffset(Offset = "0x78")]
			public static readonly int BUFFER_PARAMETER_HIERARCHICAL_Z_TEXTURE_MAP;

			[Token(Token = "0x4000282")]
			[FieldOffset(Offset = "0x7C")]
			public static readonly int BUFFER_PARAMETER_MIN_CULLING_DISTANCE;

			[Token(Token = "0x4000283")]
			[FieldOffset(Offset = "0x80")]
			public static readonly int BUFFER_PARAMETER_SHADOW_LOD_MAP;

			[Token(Token = "0x4000284")]
			[FieldOffset(Offset = "0x84")]
			public static readonly int BUFFER_PARAMETER_CULL_SHADOW;

			[Token(Token = "0x4000285")]
			[FieldOffset(Offset = "0x88")]
			public static readonly int ARGS_BUFFER;

			[Token(Token = "0x4000286")]
			[FieldOffset(Offset = "0x8C")]
			public static readonly int COUNT;

			[Token(Token = "0x4000287")]
			[FieldOffset(Offset = "0x90")]
			public static readonly int MAX_TEXTURE_SIZE;

			[Token(Token = "0x4000288")]
			[FieldOffset(Offset = "0x94")]
			public static readonly int UNITY_RENDERING_LAYER;

			[Token(Token = "0x4000289")]
			[FieldOffset(Offset = "0x98")]
			public static readonly int ARGS_BUFFER_INDEX;
		}

		[Token(Token = "0x2000035")]
		public static class SetDataKernelProperties
		{
			[Token(Token = "0x400028A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int BUFFER_PARAMETER_MANAGED_BUFFER_DATA;

			[Token(Token = "0x400028B")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int BUFFER_PARAMETER_COMPUTE_BUFFER_START_INDEX;

			[Token(Token = "0x400028C")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int BUFFER_PARAMETER_COUNT;

			[Token(Token = "0x400028D")]
			[FieldOffset(Offset = "0xC")]
			public static readonly int BUFFER_PARAMETER_DATA_TO_SET;
		}

		[Token(Token = "0x2000036")]
		public static class CopyTextureKernelProperties
		{
			[Token(Token = "0x400028E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int SOURCE_TEXTURE;

			[Token(Token = "0x400028F")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int SOURCE_TEXTURE_ARRAY;

			[Token(Token = "0x4000290")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int DESTINATION_TEXTURE;

			[Token(Token = "0x4000291")]
			[FieldOffset(Offset = "0xC")]
			public static readonly int OFFSET_X;

			[Token(Token = "0x4000292")]
			[FieldOffset(Offset = "0x10")]
			public static readonly int SOURCE_SIZE_X;

			[Token(Token = "0x4000293")]
			[FieldOffset(Offset = "0x14")]
			public static readonly int SOURCE_SIZE_Y;

			[Token(Token = "0x4000294")]
			[FieldOffset(Offset = "0x18")]
			public static readonly int DESTINATION_SIZE_X;

			[Token(Token = "0x4000295")]
			[FieldOffset(Offset = "0x1C")]
			public static readonly int DESTINATION_SIZE_Y;

			[Token(Token = "0x4000296")]
			[FieldOffset(Offset = "0x20")]
			public static readonly int REVERSE_Z;

			[Token(Token = "0x4000297")]
			[FieldOffset(Offset = "0x24")]
			public static readonly int TEXTURE_ARRAY_INDEX;
		}

		[Token(Token = "0x2000037")]
		public static class GrassKernelProperties
		{
			[Token(Token = "0x4000298")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int DETAIL_MAP_DATA_BUFFER;

			[Token(Token = "0x4000299")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int HEIGHT_MAP_DATA_BUFFER;

			[Token(Token = "0x400029A")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int COUNTER_BUFFER;

			[Token(Token = "0x400029B")]
			[FieldOffset(Offset = "0xC")]
			public static readonly int TERRAIN_DETAIL_RESOLUTION_DATA;

			[Token(Token = "0x400029C")]
			[FieldOffset(Offset = "0x10")]
			public static readonly int TERRAIN_HEIGHT_RESOLUTION_DATA;

			[Token(Token = "0x400029D")]
			[FieldOffset(Offset = "0x14")]
			public static readonly int GRASS_START_POSITION_DATA;

			[Token(Token = "0x400029E")]
			[FieldOffset(Offset = "0x18")]
			public static readonly int TERRAIN_SIZE_DATA;

			[Token(Token = "0x400029F")]
			[FieldOffset(Offset = "0x1C")]
			public static readonly int DETAIL_SCALE_DATA;

			[Token(Token = "0x40002A0")]
			[FieldOffset(Offset = "0x20")]
			public static readonly int DETAIL_AND_HEIGHT_MAP_SIZE_DATA;

			[Token(Token = "0x40002A1")]
			[FieldOffset(Offset = "0x24")]
			public static readonly int HEALTHY_DRY_NOISE_TEXTURE;

			[Token(Token = "0x40002A2")]
			[FieldOffset(Offset = "0x28")]
			public static readonly int NOISE_SPREAD;

			[Token(Token = "0x40002A3")]
			[FieldOffset(Offset = "0x2C")]
			public static readonly int DETAIL_UNIQUE_VALUE;

			[Token(Token = "0x40002A4")]
			[FieldOffset(Offset = "0x30")]
			public static readonly int DETAIL_DENSITY;

			[Token(Token = "0x40002A5")]
			[FieldOffset(Offset = "0x34")]
			public static readonly int TERRAIN_NORMAL_EFFECT;
		}

		[Token(Token = "0x2000038")]
		public static class TreeKernelProperties
		{
			[Token(Token = "0x40002A6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int TREE_DATA;

			[Token(Token = "0x40002A7")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int TREE_SCALES;

			[Token(Token = "0x40002A8")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int TERRAIN_POSITION;

			[Token(Token = "0x40002A9")]
			[FieldOffset(Offset = "0xC")]
			public static readonly int IS_APPLY_ROTATION;

			[Token(Token = "0x40002AA")]
			[FieldOffset(Offset = "0x10")]
			public static readonly int IS_APPLY_TERRAIN_HEIGHT;

			[Token(Token = "0x40002AB")]
			[FieldOffset(Offset = "0x14")]
			public static readonly int PROTOTYPE_INDEX;
		}

		[Token(Token = "0x2000039")]
		public static class RuntimeModificationKernelProperties
		{
			[Token(Token = "0x40002AC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int BUFFER_PARAMETER_POSITION_OFFSET;

			[Token(Token = "0x40002AD")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int BUFFER_PARAMETER_MATRIX_OFFSET;

			[Token(Token = "0x40002AE")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int BUFFER_PARAMETER_MODIFIER_TRANSFORM;

			[Token(Token = "0x40002AF")]
			[FieldOffset(Offset = "0xC")]
			public static readonly int BUFFER_PARAMETER_MODIFIER_RADIUS;

			[Token(Token = "0x40002B0")]
			[FieldOffset(Offset = "0x10")]
			public static readonly int BUFFER_PARAMETER_MODIFIER_HEIGHT;

			[Token(Token = "0x40002B1")]
			[FieldOffset(Offset = "0x14")]
			public static readonly int BUFFER_PARAMETER_MODIFIER_AXIS;
		}

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x0")]
		private static GPUInstancerSettings _gpuiSettings;

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Matrix4x4 zeroMatrix;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x48")]
		public static readonly int STRIDE_SIZE_MATRIX4X4;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly int STRIDE_SIZE_BOOL;

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x50")]
		public static readonly int STRIDE_SIZE_INT;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x54")]
		public static readonly int STRIDE_SIZE_FLOAT;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x58")]
		public static readonly int STRIDE_SIZE_FLOAT4;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x5C")]
		public static float COMPUTE_SHADER_THREAD_COUNT;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x60")]
		public static float COMPUTE_SHADER_THREAD_COUNT_2D;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x64")]
		public static int COMPUTE_MAX_LOD_BUFFER;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x68")]
		public static int TEXTURE_MAX_SIZE;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x6C")]
		public static bool DETAIL_STORE_INSTANCE_DATA;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x6D")]
		public static bool ENABLE_VULKAN_CRASH_FIX;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x70")]
		public static readonly string GUID_COMPUTE_PLATFORM_DEFINES;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x78")]
		public static readonly string GUID_CGINC_PLATFORM_DEPENDENT;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x80")]
		public static readonly string[] CAMERA_COMPUTE_KERNELS;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x88")]
		public static readonly string[] VISIBILITY_COMPUTE_KERNELS;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x90")]
		public static readonly string CAMERA_COMPUTE_RESOURCE_PATH;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x98")]
		public static readonly string CAMERA_VR_COMPUTE_RESOURCE_PATH;

		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly string VISIBILITY_COMPUTE_RESOURCE_PATH;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly string VISIBILITY_COMPUTE_RESOURCE_PATH_VULKAN;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly string BUFFER_TO_TEXTURE_COMPUTE_RESOURCE_PATH;

		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly string BUFFER_TO_TEXTURE_KERNEL;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly string BUFFER_TO_TEXTURE_CROSSFADE_KERNEL;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly string ARGS_BUFFER_COMPUTE_RESOURCE_PATH;

		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly string ARGS_BUFFER_DOUBLE_INSTANCE_COUNT_KERNEL;

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0xD8")]
		public static readonly int BUFFER_COROUTINE_STEP_NUMBER;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0xDC")]
		public static int DETAIL_BUFFER_MERGE_FRAME_LIMIT;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly string COMPUTE_SET_DATA_PARTIAL_RESOURCE_PATH;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0xE8")]
		public static readonly string COMPUTE_SET_DATA_PARTIAL_KERNEL;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly string COMPUTE_SET_DATA_SINGLE_KERNEL;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0xF8")]
		public static ComputeShader computeBufferSetDataPartial;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x100")]
		public static int computeBufferSetDataPartialKernelId;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x104")]
		public static int computeBufferSetDataSingleKernelId;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x108")]
		public static readonly string COMPUTE_BILLBOARD_RESOURCE_PATH;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x110")]
		public static readonly string COMPUTE_BILLBOARD_DILATION_KERNEL;

		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x118")]
		public static readonly string COMPUTE_TEXTURE_UTILS_PATH;

		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x120")]
		public static readonly string COMPUTE_COPY_TEXTURE_KERNEL;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x128")]
		public static ComputeShader computeTextureUtils;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x130")]
		public static int computeTextureUtilsCopyTextureId;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x138")]
		public static readonly string GRASS_INSTANTIATION_KERNEL;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x140")]
		public static readonly string GRASS_INSTANTIATION_RESOURCE_PATH;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x148")]
		public static readonly string TREE_INSTANTIATION_KERNEL;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x150")]
		public static readonly string TREE_INSTANTIATION_RESOURCE_PATH;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x158")]
		public static readonly string COMPUTE_RUNTIME_MODIFICATION_RESOURCE_PATH;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x160")]
		public static readonly string COMPUTE_TRANSFORM_OFFSET_KERNEL;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x168")]
		public static readonly string COMPUTE_REMOVE_INSIDE_BOUNDS_KERNEL;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x170")]
		public static readonly string COMPUTE_REMOVE_INSIDE_BOX_KERNEL;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x178")]
		public static readonly string COMPUTE_REMOVE_INSIDE_SPHERE_KERNEL;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x180")]
		public static readonly string COMPUTE_REMOVE_INSIDE_CAPSULE_KERNEL;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x188")]
		public static readonly string COMPUTE_MATRIX_OFFSET_KERNEL;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x190")]
		public static ComputeShader computeRuntimeModification;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x198")]
		public static int computeBufferTransformOffsetId;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x19C")]
		public static int computeRemoveInsideBoundsId;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x1A0")]
		public static int computeRemoveInsideBoxId;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x1A4")]
		public static int computeRemoveInsideSphereId;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x1A8")]
		public static int computeRemoveInsideCapsuleId;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x1AC")]
		public static int computeBufferMatrixOffsetId;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x1B0")]
		public static readonly string SHADER_UNITY_STANDARD;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x1B8")]
		public static readonly string SHADER_UNITY_STANDARD_SPECULAR;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x1C0")]
		public static readonly string SHADER_UNITY_STANDARD_ROUGHNESS;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x1C8")]
		public static readonly string SHADER_UNITY_VERTEXLIT;

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x1D0")]
		public static readonly string SHADER_UNITY_SPEED_TREE;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x1D8")]
		public static readonly string SHADER_UNITY_SPEED_TREE_URP;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x1E0")]
		public static readonly string SHADER_UNITY_SPEED_TREE_8;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x1E8")]
		public static readonly string SHADER_UNITY_SPEED_TREE_8_URP;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x1F0")]
		public static readonly string SHADER_UNITY_TREE_CREATOR_BARK;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x1F8")]
		public static readonly string SHADER_UNITY_TREE_CREATOR_BARK_OPTIMIZED;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x200")]
		public static readonly string SHADER_UNITY_TREE_CREATOR_LEAVES;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x208")]
		public static readonly string SHADER_UNITY_TREE_CREATOR_LEAVES_OPTIMIZED;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x210")]
		public static readonly string SHADER_UNITY_TREE_CREATOR_LEAVES_FAST;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x218")]
		public static readonly string SHADER_UNITY_TREE_CREATOR_LEAVES_FAST_OPTIMIZED;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x220")]
		public static readonly string SHADER_UNITY_TREE_SOFT_OCCLUSION_BARK;

		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x228")]
		public static readonly string SHADER_UNITY_TREE_SOFT_OCCLUSION_LEAVES;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x230")]
		public static readonly string SHADER_UNITY_INTERNAL_ERROR;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x238")]
		public static readonly string SHADER_GPUI_STANDARD;

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x240")]
		public static readonly string SHADER_GPUI_STANDARD_SPECULAR;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x248")]
		public static readonly string SHADER_GPUI_STANDARD_ROUGHNESS;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x250")]
		public static readonly string SHADER_GPUI_VERTEXLIT;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x258")]
		public static readonly string SHADER_GPUI_FOLIAGE;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x260")]
		public static readonly string SHADER_GPUI_FOLIAGE_LWRP;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x268")]
		public static readonly string SHADER_GPUI_FOLIAGE_HDRP;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x270")]
		public static readonly string SHADER_GPUI_FOLIAGE_URP;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x278")]
		public static readonly string SHADER_GPUI_SHADOWS_ONLY;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x280")]
		public static readonly string SHADER_GPUI_HIZ_OCCLUSION_DEBUGGER;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x288")]
		public static readonly string SHADER_GPUI_SPEED_TREE;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x290")]
		public static readonly string SHADER_GPUI_SPEED_TREE_8;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x298")]
		public static readonly string SHADER_GPUI_TREE_PROXY;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x2A0")]
		public static readonly string SHADER_GPUI_TREE_CREATOR_BARK;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x2A8")]
		public static readonly string SHADER_GPUI_TREE_CREATOR_BARK_OPTIMIZED;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x2B0")]
		public static readonly string SHADER_GPUI_TREE_CREATOR_LEAVES;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x2B8")]
		public static readonly string SHADER_GPUI_TREE_CREATOR_LEAVES_OPTIMIZED;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x2C0")]
		public static readonly string SHADER_GPUI_TREE_CREATOR_LEAVES_FAST;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x2C8")]
		public static readonly string SHADER_GPUI_TREE_CREATOR_LEAVES_FAST_OPTIMIZED;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x2D0")]
		public static readonly string SHADER_GPUI_TREE_SOFT_OCCLUSION_BARK;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x2D8")]
		public static readonly string SHADER_GPUI_TREE_SOFT_OCCLUSION_LEAVES;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x2E0")]
		public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_TREE;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x2E8")]
		public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_TREECREATOR;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x2F0")]
		public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_SOFTOCCLUSION;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x2F8")]
		public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_STANDARD;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x300")]
		public static readonly string SHADER_GPUI_BILLBOARD_ALBEDO_BAKER;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x308")]
		public static readonly string SHADER_GPUI_BILLBOARD_NORMAL_BAKER;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x310")]
		public static readonly string SHADER_GPUI_ERROR;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x318")]
		public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_URP;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x320")]
		public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_HDRP;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x328")]
		public static readonly string KEYWORD_LOD_FADE;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x330")]
		public static readonly string DEFAULT_PATH_GUID;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x338")]
		public static readonly string RESOURCES_PATH;

		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x340")]
		public static readonly string SETTINGS_PATH;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x348")]
		public static readonly string SHADERS_PATH;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x350")]
		public static readonly string EDITOR_TEXTURES_PATH;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x358")]
		public static readonly string NOISE_TEXTURES_PATH;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x360")]
		public static readonly string GPUI_SETTINGS_DEFAULT_NAME;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x368")]
		public static readonly string SHADER_BINDINGS_DEFAULT_NAME;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x370")]
		public static readonly string BILLBOARD_ATLAS_BINDINGS_DEFAULT_NAME;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x378")]
		public static readonly string SHADER_VARIANT_COLLECTION_DEFAULT_NAME;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x380")]
		public static readonly string PROTOTYPES_TERRAIN_PATH;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x388")]
		public static readonly string PROTOTYPES_PREFAB_PATH;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x390")]
		public static readonly string PROTOTYPES_BILLBOARD_TEXTURES_PATH;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x398")]
		public static readonly string PROTOTYPES_SHADERS_PATH;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x3A0")]
		public static readonly string PROTOTYPES_SERIALIZED_PATH;

		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x3A8")]
		public static readonly string FOLIAGE_SHADER_LWRP_PACKAGE_PATH;

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x3B0")]
		public static readonly string FOLIAGE_SHADER_URP_PACKAGE_PATH;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x3B8")]
		public static readonly string FOLIAGE_SHADER_HDRP_PACKAGE_PATH;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x3C0")]
		public static readonly string FOLIAGE_SHADER_HDRP_TEMPLATE_MATERIAL_PATH;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x3C8")]
		public static readonly string BILLBOARD_SHADER_HDRP_TEMPLATE_MATERIAL_PATH;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x3D0")]
		private static string _defaultPath;

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x3D8")]
		public static readonly string DEFAULT_HEALTHY_DRY_NOISE;

		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x3E0")]
		public static readonly string DEFAULT_WIND_WAVE_NOISE;

		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x3E8")]
		public static readonly string TEXT_PREFAB_TYPE_WARNING_TITLE;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x3F0")]
		public static readonly string TEXT_PREFAB_TYPE_WARNING;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x3F8")]
		public static readonly string TEXT_TREE_PREFAB_TYPE_WARNING;

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x400")]
		public static readonly string TEXT_PREFAB_TYPE_WARNING_3D;

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x408")]
		public static readonly string TEXT_OK;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x410")]
		public static readonly string TEXT_deleteConfirmation;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x418")]
		public static readonly string TEXT_deleteBillboard;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x420")]
		public static readonly string TEXT_keepTextures;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x428")]
		public static readonly string TEXT_delete;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x430")]
		public static readonly string ERRORTEXT_cameraNotFound;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x438")]
		public static readonly int DEBUG_INFO_SIZE;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x440")]
		public static readonly string ERRORTEXT_shaderGraph;

		[Token(Token = "0x17000015")]
		public static GPUInstancerSettings gpuiSettings
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x73D8DF0", Offset = "0x73D4DF0", VA = "0x73D8DF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x73D9000", Offset = "0x73D5000", VA = "0x73D9000")]
			set
			{
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x73D905C", Offset = "0x73D505C", VA = "0x73D905C")]
		public static void SetupComputeSetDataPartial()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x73D91C0", Offset = "0x73D51C0", VA = "0x73D91C0")]
		public static void SetupComputeTextureUtils()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x73D9300", Offset = "0x73D5300", VA = "0x73D9300")]
		public static void SetupComputeRuntimeModification()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x73D94F4", Offset = "0x73D54F4", VA = "0x73D94F4")]
		public static string GetDefaultPath()
		{
			return null;
		}
	}
}
