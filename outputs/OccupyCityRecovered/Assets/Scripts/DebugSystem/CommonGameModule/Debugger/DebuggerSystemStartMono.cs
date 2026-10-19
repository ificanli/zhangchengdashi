using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger
{
	[Token(Token = "0x2000009")]
	public class DebuggerSystemStartMono : MonoBehaviour
	{
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		private DebuggerSystemUGUI _debuggerSystemUGUI;

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x46300E4", Offset = "0x462C0E4", VA = "0x46300E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x4630580", Offset = "0x462C580", VA = "0x4630580")]
		private void Start()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x46306CC", Offset = "0x462C6CC", VA = "0x46306CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x4630748", Offset = "0x462C748", VA = "0x4630748")]
		public DebuggerSystemStartMono()
		{
		}
	}
}
