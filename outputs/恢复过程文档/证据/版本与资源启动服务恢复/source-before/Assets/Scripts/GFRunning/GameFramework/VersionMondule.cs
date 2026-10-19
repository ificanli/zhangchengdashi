using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameFramework.Resources;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace GameFramework
{
	[Token(Token = "0x20003EA")]
	public class VersionMondule : GameFrameModule
	{
		[Token(Token = "0x20003EB")]
		[CompilerGenerated]
		private sealed class _003CInit_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001CD0")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001CD1")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001CD2")]
			[FieldOffset(Offset = "0x20")]
			public VersionMondule _003C_003E4__this;

			[Token(Token = "0x4001CD3")]
			[FieldOffset(Offset = "0x28")]
			private GPAssetPackType _003CassetPackType_003E5__2;

			[Token(Token = "0x4001CD4")]
			[FieldOffset(Offset = "0x30")]
			private string _003CAssetPath_003E5__3;

			[Token(Token = "0x4001CD5")]
			[FieldOffset(Offset = "0x38")]
			private string _003Cpath_003E5__4;

			[Token(Token = "0x4001CD6")]
			[FieldOffset(Offset = "0x40")]
			private string _003Cstr_003E5__5;

			[Token(Token = "0x4001CD7")]
			[FieldOffset(Offset = "0x48")]
			private UnityWebRequest _003Crequest_003E5__6;

			[Token(Token = "0x1700116D")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60060EA")]
				[Address(RVA = "0x71ECC4C", Offset = "0x71E8C4C", VA = "0x71ECC4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700116E")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60060EC")]
				[Address(RVA = "0x71ECC8C", Offset = "0x71E8C8C", VA = "0x71ECC8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60060E7")]
			[Address(RVA = "0x71EB7D0", Offset = "0x71E77D0", VA = "0x71EB7D0")]
			[DebuggerHidden]
			public _003CInit_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60060E8")]
			[Address(RVA = "0x71EBBB0", Offset = "0x71E7BB0", VA = "0x71EBBB0", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60060E9")]
			[Address(RVA = "0x71EBBB4", Offset = "0x71E7BB4", VA = "0x71EBBB4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60060EA")]
			[Address(RVA = "0x71ECC4C", Offset = "0x71E8C4C", VA = "0x71ECC4C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60060EB")]
			[Address(RVA = "0x71ECC54", Offset = "0x71E8C54", VA = "0x71ECC54", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60060EC")]
			[Address(RVA = "0x71ECC8C", Offset = "0x71E8C8C", VA = "0x71ECC8C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20003EC")]
		[CompilerGenerated]
		private sealed class _003CLoadABFilePersistent_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001CD8")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001CD9")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001CDA")]
			[FieldOffset(Offset = "0x20")]
			public string path;

			[Token(Token = "0x4001CDB")]
			[FieldOffset(Offset = "0x28")]
			private UnityWebRequest _003Crequest_003E5__2;

			[Token(Token = "0x1700116F")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60060F0")]
				[Address(RVA = "0x71ECFC4", Offset = "0x71E8FC4", VA = "0x71ECFC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17001170")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60060F2")]
				[Address(RVA = "0x71ED004", Offset = "0x71E9004", VA = "0x71ED004", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60060ED")]
			[Address(RVA = "0x71EBA94", Offset = "0x71E7A94", VA = "0x71EBA94")]
			[DebuggerHidden]
			public _003CLoadABFilePersistent_003Ed__13(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60060EE")]
			[Address(RVA = "0x71ECC94", Offset = "0x71E8C94", VA = "0x71ECC94", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60060EF")]
			[Address(RVA = "0x71ECC98", Offset = "0x71E8C98", VA = "0x71ECC98", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60060F0")]
			[Address(RVA = "0x71ECFC4", Offset = "0x71E8FC4", VA = "0x71ECFC4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60060F1")]
			[Address(RVA = "0x71ECFCC", Offset = "0x71E8FCC", VA = "0x71ECFCC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60060F2")]
			[Address(RVA = "0x71ED004", Offset = "0x71E9004", VA = "0x71ED004", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20003ED")]
		[CompilerGenerated]
		private sealed class _003CLoadABFileStreaming_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001CDC")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001CDD")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001CDE")]
			[FieldOffset(Offset = "0x20")]
			public VersionMondule _003C_003E4__this;

			[Token(Token = "0x4001CDF")]
			[FieldOffset(Offset = "0x28")]
			private UnityWebRequest _003Crequest_003E5__2;

			[Token(Token = "0x17001171")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60060F6")]
				[Address(RVA = "0x71EDA48", Offset = "0x71E9A48", VA = "0x71EDA48", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17001172")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60060F8")]
				[Address(RVA = "0x71EDA88", Offset = "0x71E9A88", VA = "0x71EDA88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60060F3")]
			[Address(RVA = "0x71EB860", Offset = "0x71E7860", VA = "0x71EB860")]
			[DebuggerHidden]
			public _003CLoadABFileStreaming_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60060F4")]
			[Address(RVA = "0x71ED00C", Offset = "0x71E900C", VA = "0x71ED00C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60060F5")]
			[Address(RVA = "0x71ED010", Offset = "0x71E9010", VA = "0x71ED010", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60060F6")]
			[Address(RVA = "0x71EDA48", Offset = "0x71E9A48", VA = "0x71EDA48", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60060F7")]
			[Address(RVA = "0x71EDA50", Offset = "0x71E9A50", VA = "0x71EDA50", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60060F8")]
			[Address(RVA = "0x71EDA88", Offset = "0x71E9A88", VA = "0x71EDA88", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4001CCB")]
		[FieldOffset(Offset = "0x20")]
		private ABResInfo persistentABRes;

		[Token(Token = "0x4001CCC")]
		[FieldOffset(Offset = "0x28")]
		private ABResInfo streamingABRes;

		[Token(Token = "0x4001CCD")]
		[FieldOffset(Offset = "0x30")]
		internal IBundleServices CurrBundleServices;

		[Token(Token = "0x4001CCE")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, IBundleServices> cashABResInfo;

		[Token(Token = "0x4001CCF")]
		[FieldOffset(Offset = "0x38")]
		private string googleDeliveryRootPath;

		[Token(Token = "0x1700116C")]
		internal override int Priority
		{
			[Token(Token = "0x60060DA")]
			[Address(RVA = "0x71EB62C", Offset = "0x71E762C", VA = "0x71EB62C", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60060DB")]
		[Address(RVA = "0x71EB634", Offset = "0x71E7634", VA = "0x71EB634", Slot = "5")]
		internal override void Initialize(params object[] arg)
		{
		}

		[Token(Token = "0x60060DC")]
		[Address(RVA = "0x71EB730", Offset = "0x71E7730", VA = "0x71EB730")]
		private void InitForNewRes()
		{
		}

		[Token(Token = "0x60060DD")]
		[Address(RVA = "0x71EB770", Offset = "0x71E7770", VA = "0x71EB770")]
		[IteratorStateMachine(typeof(_003CInit_003Ed__9))]
		private IEnumerator Init()
		{
			return null;
		}

		[Token(Token = "0x60060DE")]
		[Address(RVA = "0x71EB7F8", Offset = "0x71E77F8", VA = "0x71EB7F8")]
		internal string GetGoogleDeliveryInfoForNewRes()
		{
			return null;
		}

		[Token(Token = "0x60060DF")]
		[Address(RVA = "0x71EB800", Offset = "0x71E7800", VA = "0x71EB800")]
		[IteratorStateMachine(typeof(_003CLoadABFileStreaming_003Ed__11))]
		private IEnumerator LoadABFileStreaming()
		{
			return null;
		}

		[Token(Token = "0x60060E0")]
		[Address(RVA = "0x71EB888", Offset = "0x71E7888", VA = "0x71EB888")]
		private void SetAssetBundleURL()
		{
		}

		[Token(Token = "0x60060E1")]
		[Address(RVA = "0x71EBA34", Offset = "0x71E7A34", VA = "0x71EBA34")]
		[IteratorStateMachine(typeof(_003CLoadABFilePersistent_003Ed__13))]
		private IEnumerator LoadABFilePersistent(string path)
		{
			return null;
		}

		[Token(Token = "0x60060E2")]
		[Address(RVA = "0x71EBABC", Offset = "0x71E7ABC", VA = "0x71EBABC", Slot = "9")]
		internal override void Shutdown()
		{
		}

		[Token(Token = "0x60060E3")]
		[Address(RVA = "0x71EBAC4", Offset = "0x71E7AC4", VA = "0x71EBAC4", Slot = "6")]
		internal override void Start()
		{
		}

		[Token(Token = "0x60060E4")]
		[Address(RVA = "0x71EBAC8", Offset = "0x71E7AC8", VA = "0x71EBAC8", Slot = "7")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x60060E5")]
		[Address(RVA = "0x71EBACC", Offset = "0x71E7ACC", VA = "0x71EBACC")]
		public VersionMondule()
		{
		}
	}
}
