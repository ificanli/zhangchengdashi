using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger
{
	[Token(Token = "0x2000007")]
	public class DebuggerSystemIniter : MonoBehaviour
	{
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		private static Action m_OnCreateDebuggerSystem;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x8")]
		[CompilerGenerated]
		private static Action m_OnDestroyDebuggerSystem;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		public bool recreate;

		[Token(Token = "0x14000001")]
		public static event Action OnCreateDebuggerSystem
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x462FADC", Offset = "0x462BADC", VA = "0x462FADC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x462FB94", Offset = "0x462BB94", VA = "0x462FB94")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event Action OnDestroyDebuggerSystem
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x462FC4C", Offset = "0x462BC4C", VA = "0x462FC4C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x462FD08", Offset = "0x462BD08", VA = "0x462FD08")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x462FDC4", Offset = "0x462BDC4", VA = "0x462FDC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x46300D4", Offset = "0x462C0D4", VA = "0x46300D4")]
		public DebuggerSystemIniter()
		{
		}
	}
}
