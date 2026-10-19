using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameFramework;
using GameFramework.Base;
using Il2CppDummyDll;
using YooAsset;

namespace ljzs_lt
{
	[Token(Token = "0x2000F46")]
	public class GameStartNewRes : IGameStart
	{
		[Token(Token = "0x2000F47")]
		[CompilerGenerated]
		private sealed class _003COpenLoadingUI_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40069A5")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40069A6")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40069A7")]
			[FieldOffset(Offset = "0x20")]
			public Action loadOver;

			[Token(Token = "0x17000F70")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005B61")]
				[Address(RVA = "0x439C82C", Offset = "0x439882C", VA = "0x439C82C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F71")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005B63")]
				[Address(RVA = "0x439C86C", Offset = "0x439886C", VA = "0x439C86C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005B5E")]
			[Address(RVA = "0x439C2D0", Offset = "0x43982D0", VA = "0x439C2D0")]
			[DebuggerHidden]
			public _003COpenLoadingUI_003Ed__1(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005B5F")]
			[Address(RVA = "0x439C78C", Offset = "0x439878C", VA = "0x439C78C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005B60")]
			[Address(RVA = "0x439C790", Offset = "0x4398790", VA = "0x439C790", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005B61")]
			[Address(RVA = "0x439C82C", Offset = "0x439882C", VA = "0x439C82C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005B62")]
			[Address(RVA = "0x439C834", Offset = "0x4398834", VA = "0x439C834", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005B63")]
			[Address(RVA = "0x439C86C", Offset = "0x439886C", VA = "0x439C86C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x6005B51")]
		[Address(RVA = "0x439C1E4", Offset = "0x43981E4", VA = "0x439C1E4", Slot = "4")]
		public override void InitPatchManager()
		{
		}

		[Token(Token = "0x6005B52")]
		[Address(RVA = "0x439C270", Offset = "0x4398270", VA = "0x439C270")]
		[IteratorStateMachine(typeof(_003COpenLoadingUI_003Ed__1))]
		private IEnumerator OpenLoadingUI(Action loadOver)
		{
			return null;
		}

		[Token(Token = "0x6005B53")]
		[Address(RVA = "0x439C2F8", Offset = "0x43982F8", VA = "0x439C2F8", Slot = "16")]
		public override bool GetIsOverrideConfigInit()
		{
			return default;
		}

		[Token(Token = "0x6005B54")]
		[Address(RVA = "0x439C300", Offset = "0x4398300", VA = "0x439C300", Slot = "17")]
		public override void OverrideConfigInit()
		{
		}

		[Token(Token = "0x6005B55")]
		[Address(RVA = "0x439C308", Offset = "0x4398308", VA = "0x439C308", Slot = "5")]
		public override void InitConfig_newRes()
		{
		}

		[Token(Token = "0x6005B56")]
		[Address(RVA = "0x439C330", Offset = "0x4398330", VA = "0x439C330", Slot = "11")]
		public override void SetLayerCollisionMatrix()
		{
		}

		[Token(Token = "0x6005B57")]
		[Address(RVA = "0x439C334", Offset = "0x4398334", VA = "0x439C334", Slot = "8")]
		public override void MnieGameProjectSetting()
		{
		}

		[Token(Token = "0x6005B58")]
		[Address(RVA = "0x439C338", Offset = "0x4398338", VA = "0x439C338", Slot = "9")]
		public override void RegisterProcedure()
		{
		}

		[Token(Token = "0x6005B59")]
		[Address(RVA = "0x439C5B8", Offset = "0x43985B8", VA = "0x439C5B8", Slot = "10")]
		public override void RegisterLogicCtr()
		{
		}

		[Token(Token = "0x6005B5A")]
		[Address(RVA = "0x439C674", Offset = "0x4398674", VA = "0x439C674", Slot = "7")]
		public override void StartGame()
		{
		}

		[Token(Token = "0x6005B5B")]
		[Address(RVA = "0x439C6FC", Offset = "0x43986FC", VA = "0x439C6FC", Slot = "15")]
		public override EPlayMode GetNewResLoadAppPlayMode()
		{
			return default;
		}

		[Token(Token = "0x6005B5C")]
		[Address(RVA = "0x439C77C", Offset = "0x439877C", VA = "0x439C77C", Slot = "14")]
		public override TeamType GetNewResLoadCDNTeamType()
		{
			return default;
		}

		[Token(Token = "0x6005B5D")]
		[Address(RVA = "0x439C784", Offset = "0x4398784", VA = "0x439C784")]
		public GameStartNewRes()
		{
		}
	}
}
