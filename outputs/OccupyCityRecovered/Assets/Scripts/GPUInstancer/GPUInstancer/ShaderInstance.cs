using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Serializable]
	[Token(Token = "0x200004E")]
	public class ShaderInstance
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader instancedShader;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string modifiedDate;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isOriginalInstanced;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string extensionCode;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x73E0498", Offset = "0x73DC498", VA = "0x73E0498")]
		public ShaderInstance(string name, Shader instancedShader, bool isOriginalInstanced, [Optional] string extensionCode)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x73E1C00", Offset = "0x73DDC00", VA = "0x73E1C00", Slot = "4")]
		public virtual void Regenerate()
		{
		}
	}
}
