using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200004F")]
	public interface GPUInstancerShaderBindingsExtension
	{
		[Token(Token = "0x60001A9")]
		Shader GetInstancedShader(List<ShaderInstance> shaderInstances, string shaderName);

		[Token(Token = "0x60001AA")]
		Material GetInstancedMaterial(List<ShaderInstance> shaderInstances, Material originalMaterial);

		[Token(Token = "0x60001AB")]
		bool ClearEmptyShaderInstances(List<ShaderInstance> shaderInstances);

		[Token(Token = "0x60001AC")]
		bool IsShadersInstancedVersionExists(List<ShaderInstance> shaderInstances, string shaderName);

		[Token(Token = "0x60001AD")]
		string GetExtensionCode();
	}
}
