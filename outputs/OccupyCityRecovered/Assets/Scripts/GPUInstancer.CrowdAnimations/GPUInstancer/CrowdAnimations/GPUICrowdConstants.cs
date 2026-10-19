using Il2CppDummyDll;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x2000025")]
	public static class GPUICrowdConstants
	{
		[Token(Token = "0x2000026")]
		public static class CrowdKernelPoperties
		{
			[Token(Token = "0x400010F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int ANIMATION_DATA;

			[Token(Token = "0x4000110")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int ANIMATION_BUFFER;

			[Token(Token = "0x4000111")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int ANIMATION_TEXTURE;

			[Token(Token = "0x4000112")]
			[FieldOffset(Offset = "0xC")]
			public static readonly int ANIMATION_TEXTURE_SIZE_X;

			[Token(Token = "0x4000113")]
			[FieldOffset(Offset = "0x10")]
			public static readonly int TOTAL_NUMBER_OF_FRAMES;

			[Token(Token = "0x4000114")]
			[FieldOffset(Offset = "0x14")]
			public static readonly int TOTAL_NUMBER_OF_BONES;

			[Token(Token = "0x4000115")]
			[FieldOffset(Offset = "0x18")]
			public static readonly int INSTANCE_COUNT;

			[Token(Token = "0x4000116")]
			[FieldOffset(Offset = "0x1C")]
			public static readonly int DELTA_TIME;

			[Token(Token = "0x4000117")]
			[FieldOffset(Offset = "0x20")]
			public static readonly int CURRENT_TIME;

			[Token(Token = "0x4000118")]
			[FieldOffset(Offset = "0x24")]
			public static readonly int FRAME_RATE;

			[Token(Token = "0x4000119")]
			[FieldOffset(Offset = "0x28")]
			public static readonly int CROWD_ANIMATOR_CONTROLLER;

			[Token(Token = "0x400011A")]
			[FieldOffset(Offset = "0x2C")]
			public static readonly int BINDPOSE_OFFSET;

			[Token(Token = "0x400011B")]
			[FieldOffset(Offset = "0x30")]
			public static readonly int ASYNC_BONE_UPDATE_DATA;

			[Token(Token = "0x400011C")]
			[FieldOffset(Offset = "0x34")]
			public static readonly int ASYNC_BONE_UPDATE_FILTER;

			[Token(Token = "0x400011D")]
			[FieldOffset(Offset = "0x38")]
			public static readonly int BONE_FILTER_COUNT;

			[Token(Token = "0x400011E")]
			[FieldOffset(Offset = "0x3C")]
			public static readonly int CHILD_INSTANCE_DATA;

			[Token(Token = "0x400011F")]
			[FieldOffset(Offset = "0x40")]
			public static readonly int PARENT_INSTANCE_DATA;

			[Token(Token = "0x4000120")]
			[FieldOffset(Offset = "0x44")]
			public static readonly int ANIMATION_BUFFER_TEXTURE;
		}

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x0")]
		private static GPUICrowdSettings _gpuiCrowdSettings;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x8")]
		public static readonly float LATEST_REBAKE_VERSION;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string GPUI_EXTENSION_CODE;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string COMPUTE_SKINNED_MESH_BAKE_PATH;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string COMPUTE_ANIMATION_TO_TEXTURE_KERNEL;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string COMPUTE_ANIMATION_TEXTURE_TO_BUFFER_KERNEL;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string COMPUTE_SKINNED_MESH_ANIMATE_PATH;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string COMPUTE_ANIMATE_BONES_KERNEL;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string COMPUTE_ANIMATE_BONES_LERPED_KERNEL;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string COMPUTE_FIX_WEIGHTS_KERNEL;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x50")]
		public static readonly string COMPUTE_CROWD_ANIMATOR_PATH;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x58")]
		public static readonly string COMPUTE_CROWD_ANIMATOR_KERNEL;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x60")]
		public static readonly string COMPUTE_ASYNC_BONE_UPDATE;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x68")]
		public static readonly string COMPUTE_ASYNC_BONE_UPDATE_KERNEL;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x70")]
		public static readonly string COMPUTE_OPTIONAL_RENDERER_BUFFER_COPY;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x78")]
		public static readonly string COMPUTE_OPTIONAL_RENDERER_BUFFER_COPY_KERNEL;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x80")]
		public static readonly string COMPUTE_ANIMATION_BUFFER_TO_TEXTURE;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x88")]
		public static readonly string COMPUTE_ANIMATION_BUFFER_TO_TEXTURE_KERNEL;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x90")]
		public static readonly string KEYWORD_GPUI_CA_BINDPOSEOFFSET;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x98")]
		public static readonly string SHADER_UNITY_AUTODESK_INTERACTIVE;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly string SHADER_UNITY_HDRP_LIT;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly string SHADER_UNITY_LWRP_LIT;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly string SHADER_UNITY_URP_LIT;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly string SHADER_GPUI_CROWD_STANDARD;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly string SHADER_GPUI_CROWD_STANDARD_SPECULAR;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly string SHADER_GPUI_CROWD_AUTODESK_INTERACTIVE;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly string SHADER_GPUI_CROWD_HDRP_LIT;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xD8")]
		public static readonly string SHADER_GPUI_CROWD_URP_LIT;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly string SHADER_GPUI_CROWD_URP_LIT_SPECULAR;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xE8")]
		public static readonly string SHADER_GPUI_CROWD_LWRP_LIT;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly string SHADER_GPUI_CROWD_ERROR;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0xF8")]
		public static readonly string DEFAULT_PATH_GUID;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x100")]
		public static readonly string RESOURCES_PATH;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x108")]
		public static readonly string SHADERS_PATH;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x110")]
		public static readonly string GPUI_SETTINGS_DEFAULT_NAME;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x118")]
		public static readonly string PROTOTYPES_ANIMATION_TEXTURES_PATH;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x120")]
		public static readonly string PROTOTYPES_CROWD_PATH;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x128")]
		public static readonly string PROTOTYPES_CROWD__ANIMATION_DATA_PATH;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x130")]
		private static string _defaultPath;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x138")]
		public static readonly string ERROR_GPUI_Dependency;

		[Token(Token = "0x17000006")]
		public static GPUICrowdSettings gpuiCrowdSettings
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x73CA654", Offset = "0x73C6654", VA = "0x73CA654")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x73CA930", Offset = "0x73C6930", VA = "0x73CA930")]
			set
			{
			}
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x73CA98C", Offset = "0x73C698C", VA = "0x73CA98C")]
		public static string GetDefaultPath()
		{
			return null;
		}
	}
}
