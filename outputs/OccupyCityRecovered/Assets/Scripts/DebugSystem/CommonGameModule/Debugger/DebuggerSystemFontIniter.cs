using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace CommonGameModule.Debugger
{
	[Token(Token = "0x2000015")]
	public static class DebuggerSystemFontIniter
	{
		[Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class _003CLoadAssetBundle_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400004B")]
			[FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x400004C")]
			[FieldOffset(Offset = "0x28")]
			public Action<Font> callback;

			[Token(Token = "0x400004D")]
			[FieldOffset(Offset = "0x30")]
			public string assetName;

			[Token(Token = "0x400004E")]
			[FieldOffset(Offset = "0x38")]
			private UnityWebRequest _003Cuwr_003E5__2;

			[Token(Token = "0x17000016")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000071")]
				[Address(RVA = "0x4636D84", Offset = "0x4632D84", VA = "0x4636D84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000017")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000073")]
				[Address(RVA = "0x4636DC4", Offset = "0x4632DC4", VA = "0x4636DC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600006D")]
			[Address(RVA = "0x4636428", Offset = "0x4632428", VA = "0x4636428")]
			[DebuggerHidden]
			public _003CLoadAssetBundle_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600006E")]
			[Address(RVA = "0x46367F4", Offset = "0x46327F4", VA = "0x46367F4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600006F")]
			[Address(RVA = "0x4636810", Offset = "0x4632810", VA = "0x4636810", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0x4636CD4", Offset = "0x4632CD4", VA = "0x4636CD4")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6000071")]
			[Address(RVA = "0x4636D84", Offset = "0x4632D84", VA = "0x4636D84", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000072")]
			[Address(RVA = "0x4636D8C", Offset = "0x4632D8C", VA = "0x4636D8C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000073")]
			[Address(RVA = "0x4636DC4", Offset = "0x4632DC4", VA = "0x4636DC4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000047")]
		private const string FontPathFormat = "{0}/app-3/Test/GFCode/WebGL/DebugSystem/{1}.unity3d";

		[Token(Token = "0x4000048")]
		private const string FontName = "alibaba-puhuiti-bold-3500.ttf";

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x463628C", Offset = "0x463228C", VA = "0x463628C")]
		public static void OnFirstShowFullWindow()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x46363B4", Offset = "0x46323B4", VA = "0x46363B4")]
		[IteratorStateMachine(typeof(_003CLoadAssetBundle_003Ed__3))]
		private static IEnumerator LoadAssetBundle(string url, string assetName, Action<Font> callback)
		{
			return null;
		}
	}
}
