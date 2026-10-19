using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger
{
	[Token(Token = "0x200000F")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class UIPathAttribute : PropertyAttribute
	{
		[Token(Token = "0x17000010")]
		public UIPathType PathType
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x4634074", Offset = "0x4630074", VA = "0x4634074")]
			[CompilerGenerated]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000011")]
		public string Path
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x463407C", Offset = "0x463007C", VA = "0x463407C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x4634084", Offset = "0x4630084", VA = "0x4634084")]
		public UIPathAttribute(UIPathType pathType, string path)
		{
		}
	}
}
