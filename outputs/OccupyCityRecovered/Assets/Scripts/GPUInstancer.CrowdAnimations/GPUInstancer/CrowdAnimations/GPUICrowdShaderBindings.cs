using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x200002E")]
	public class GPUICrowdShaderBindings : GPUInstancerShaderBindingsExtension
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static readonly List<string> _crowdStandardUnityShaders;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly List<string> _crowdStandardUnityShadersGPUI;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static readonly List<string> _crowdExtraGPUIShaders;

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x73CF00C", Offset = "0x73CB00C", VA = "0x73CF00C", Slot = "4")]
		public Shader GetInstancedShader(List<ShaderInstance> shaderInstances, string shaderName)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x73CF014", Offset = "0x73CB014", VA = "0x73CF014")]
		public Shader GetInstancedShader(List<ShaderInstance> shaderInstances, string shaderName, [Optional] string[] keywords)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x73CF784", Offset = "0x73CB784", VA = "0x73CF784", Slot = "5")]
		public Material GetInstancedMaterial(List<ShaderInstance> shaderInstances, Material originalMaterial)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x73CFA10", Offset = "0x73CBA10", VA = "0x73CFA10", Slot = "6")]
		public bool ClearEmptyShaderInstances(List<ShaderInstance> shaderInstances)
		{
			return default;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x73CFA18", Offset = "0x73CBA18", VA = "0x73CFA18", Slot = "7")]
		public bool IsShadersInstancedVersionExists(List<ShaderInstance> shaderInstances, string shaderName)
		{
			return default;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x73CFF1C", Offset = "0x73CBF1C", VA = "0x73CFF1C", Slot = "9")]
		public virtual bool IsOriginalShaderInstanced(List<ShaderInstance> shaderInstances, string shaderName)
		{
			return default;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x73D0144", Offset = "0x73CC144", VA = "0x73D0144", Slot = "8")]
		public string GetExtensionCode()
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x73D019C", Offset = "0x73CC19C", VA = "0x73D019C")]
		public GPUICrowdShaderBindings()
		{
		}
	}
}
