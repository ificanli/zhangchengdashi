using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200004B")]
	public class GPUInstancerShaderBindings : ScriptableObject
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<ShaderInstance> shaderInstances;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<string> _standardUnityShaders;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<string> _standardUnityShadersGPUI;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly List<string> _extraGPUIShaders;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GPUInstancerShaderBindingsExtension> shaderBindingsExtensions;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x73DF604", Offset = "0x73DB604", VA = "0x73DF604", Slot = "4")]
		public virtual bool HasExtension(string extensionCode)
		{
			return default;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x73DF6F8", Offset = "0x73DB6F8", VA = "0x73DF6F8", Slot = "5")]
		public virtual void AddExtension(GPUInstancerShaderBindingsExtension extension)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x73DF898", Offset = "0x73DB898", VA = "0x73DF898", Slot = "6")]
		public virtual GPUInstancerShaderBindingsExtension GetExtension(string extensionCode)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x73DFB14", Offset = "0x73DBB14", VA = "0x73DFB14", Slot = "7")]
		public virtual Shader GetInstancedShader(string shaderName, [Optional] string extensionCode)
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x73DFFB4", Offset = "0x73DBFB4", VA = "0x73DFFB4", Slot = "8")]
		public virtual Material GetInstancedMaterial(Material originalMaterial, [Optional] string extensionCode)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x73E02E8", Offset = "0x73DC2E8", VA = "0x73E02E8", Slot = "9")]
		public virtual void ResetShaderInstances()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x73E0394", Offset = "0x73DC394", VA = "0x73E0394", Slot = "10")]
		public virtual void ClearEmptyShaderInstances()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x73E0398", Offset = "0x73DC398", VA = "0x73E0398", Slot = "11")]
		public virtual void AddShaderInstance(string name, Shader instancedShader, [Optional][DefaultParameterValue(false)] bool isOriginalInstanced, [Optional] string extensionCode)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x73E0594", Offset = "0x73DC594", VA = "0x73E0594", Slot = "12")]
		public virtual bool IsShadersInstancedVersionExists(string shaderName, [Optional] string extensionCode)
		{
			return default;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x73E08BC", Offset = "0x73DC8BC", VA = "0x73E08BC", Slot = "13")]
		public virtual bool IsOriginalShaderInstanced(string shaderName)
		{
			return default;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x73E0AE4", Offset = "0x73DCAE4", VA = "0x73E0AE4")]
		public GPUInstancerShaderBindings()
		{
		}
	}
}
