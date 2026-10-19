using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace LocalizationModule
{
	[Token(Token = "0x20001C7")]
	public class LocalizeText : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001C8")]
		[CompilerGenerated]
		private struct _003COnLocalize_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4001B63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001B65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LocalizeText _003C_003E4__this;

			[Token(Token = "0x4001B66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_Text _003CtmpText_003E5__2;

			[Token(Token = "0x4001B67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Material>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x40801A4", Offset = "0x407C1A4", VA = "0x40801A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x40806B8", Offset = "0x407C6B8", VA = "0x40806B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001B61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FontStyle textKey;

		[Token(Token = "0x4001B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, string> FontMaterialPathDict;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x407FE40", Offset = "0x407BE40", VA = "0x407FE40")]
		[AsyncStateMachine(typeof(_003COnLocalize_003Ed__2))]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x407FED0", Offset = "0x407BED0", VA = "0x407FED0")]
		private string GetFullPath(Transform currentTransform)
		{
			return null;
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x407FFB0", Offset = "0x407BFB0", VA = "0x407FFB0")]
		public LocalizeText()
		{
		}
	}
}
