using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000C7")]
	public interface MB_IMeshBakerSettings
	{
		[Token(Token = "0x1700007A")]
		bool doBlendShapes
		{
			[Token(Token = "0x60003EB")]
			get;
			[Token(Token = "0x60003EC")]
			set;
		}

		[Token(Token = "0x1700007B")]
		bool doCol
		{
			[Token(Token = "0x60003ED")]
			get;
			[Token(Token = "0x60003EE")]
			set;
		}

		[Token(Token = "0x1700007C")]
		bool doNorm
		{
			[Token(Token = "0x60003EF")]
			get;
			[Token(Token = "0x60003F0")]
			set;
		}

		[Token(Token = "0x1700007D")]
		bool doTan
		{
			[Token(Token = "0x60003F1")]
			get;
			[Token(Token = "0x60003F2")]
			set;
		}

		[Token(Token = "0x1700007E")]
		bool doUV
		{
			[Token(Token = "0x60003F3")]
			get;
			[Token(Token = "0x60003F4")]
			set;
		}

		[Token(Token = "0x1700007F")]
		bool doUV3
		{
			[Token(Token = "0x60003F5")]
			get;
			[Token(Token = "0x60003F6")]
			set;
		}

		[Token(Token = "0x17000080")]
		bool doUV4
		{
			[Token(Token = "0x60003F7")]
			get;
			[Token(Token = "0x60003F8")]
			set;
		}

		[Token(Token = "0x17000081")]
		bool doUV5
		{
			[Token(Token = "0x60003F9")]
			get;
			[Token(Token = "0x60003FA")]
			set;
		}

		[Token(Token = "0x17000082")]
		bool doUV6
		{
			[Token(Token = "0x60003FB")]
			get;
			[Token(Token = "0x60003FC")]
			set;
		}

		[Token(Token = "0x17000083")]
		bool doUV7
		{
			[Token(Token = "0x60003FD")]
			get;
			[Token(Token = "0x60003FE")]
			set;
		}

		[Token(Token = "0x17000084")]
		bool doUV8
		{
			[Token(Token = "0x60003FF")]
			get;
			[Token(Token = "0x6000400")]
			set;
		}

		[Token(Token = "0x17000085")]
		MB2_LightmapOptions lightmapOption
		{
			[Token(Token = "0x6000401")]
			get;
			[Token(Token = "0x6000402")]
			set;
		}

		[Token(Token = "0x17000086")]
		float uv2UnwrappingParamsHardAngle
		{
			[Token(Token = "0x6000403")]
			get;
			[Token(Token = "0x6000404")]
			set;
		}

		[Token(Token = "0x17000087")]
		float uv2UnwrappingParamsPackMargin
		{
			[Token(Token = "0x6000405")]
			get;
			[Token(Token = "0x6000406")]
			set;
		}

		[Token(Token = "0x17000088")]
		bool optimizeAfterBake
		{
			[Token(Token = "0x6000407")]
			get;
			[Token(Token = "0x6000408")]
			set;
		}

		[Token(Token = "0x17000089")]
		MB_MeshPivotLocation pivotLocationType
		{
			[Token(Token = "0x6000409")]
			get;
			[Token(Token = "0x600040A")]
			set;
		}

		[Token(Token = "0x1700008A")]
		Vector3 pivotLocation
		{
			[Token(Token = "0x600040B")]
			get;
			[Token(Token = "0x600040C")]
			set;
		}

		[Token(Token = "0x1700008B")]
		bool clearBuffersAfterBake
		{
			[Token(Token = "0x600040D")]
			get;
			[Token(Token = "0x600040E")]
			set;
		}

		[Token(Token = "0x1700008C")]
		MB_RenderType renderType
		{
			[Token(Token = "0x600040F")]
			get;
			[Token(Token = "0x6000410")]
			set;
		}

		[Token(Token = "0x1700008D")]
		bool smrNoExtraBonesWhenCombiningMeshRenderers
		{
			[Token(Token = "0x6000411")]
			get;
			[Token(Token = "0x6000412")]
			set;
		}

		[Token(Token = "0x1700008E")]
		bool smrMergeBlendShapesWithSameNames
		{
			[Token(Token = "0x6000413")]
			get;
			[Token(Token = "0x6000414")]
			set;
		}

		[Token(Token = "0x1700008F")]
		IAssignToMeshCustomizer assignToMeshCustomizer
		{
			[Token(Token = "0x6000415")]
			get;
			[Token(Token = "0x6000416")]
			set;
		}

		[Token(Token = "0x17000090")]
		MB_MeshCombineAPIType meshAPI
		{
			[Token(Token = "0x6000417")]
			get;
			[Token(Token = "0x6000418")]
			set;
		}
	}
}
