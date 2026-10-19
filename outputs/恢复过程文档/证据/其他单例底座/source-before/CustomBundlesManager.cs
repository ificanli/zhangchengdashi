using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using I2.Loc;
using Il2CppDummyDll;
using UnityEngine;

namespace LocalizationModule.Runtime
{
	[Token(Token = "0x20001CB")]
	public class CustomBundlesManager : RegisterBundlesManager
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001CC")]
		[CompilerGenerated]
		private struct _003CAddObjectToDict_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4001B6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001B6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string path;

			[Token(Token = "0x4001B6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CustomBundlesManager _003C_003E4__this;

			[Token(Token = "0x4001B70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<UnityEngine.Object>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x4081B14", Offset = "0x407DB14", VA = "0x4081B14", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x4081FD0", Offset = "0x407DFD0", VA = "0x4081FD0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001CD")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4001B71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001B73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomBundlesManager _003C_003E4__this;

			[Token(Token = "0x4001B74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x4081FDC", Offset = "0x407DFDC", VA = "0x4081FDC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x408246C", Offset = "0x407E46C", VA = "0x408246C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001CE")]
		[CompilerGenerated]
		private struct _003CPreload_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4001B75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001B77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomBundlesManager _003C_003E4__this;

			[Token(Token = "0x4001B78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private List<UniTask> _003CallWait_003E5__2;

			[Token(Token = "0x4001B79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4001B7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x4082478", Offset = "0x407E478", VA = "0x4082478", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x4082BD0", Offset = "0x407EBD0", VA = "0x4082BD0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001B68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CustomBundlesManager _instance;

		[Token(Token = "0x4001B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, UnityEngine.Object> _objectsDict;

		[Token(Token = "0x4001B6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _preloadTaskCompleted;

		[Token(Token = "0x4001B6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject _battleFPSControllerPrefab;

		[Token(Token = "0x1700009C")]
		public static CustomBundlesManager Instance
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x408159C", Offset = "0x407D59C", VA = "0x408159C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public bool PreloadTaskCompleted
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x4081948", Offset = "0x407D948", VA = "0x4081948")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x40816D8", Offset = "0x407D6D8", VA = "0x40816D8", Slot = "5")]
		public override UnityEngine.Object LoadFromBundle(string path, Type assetType)
		{
			return null;
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x4081950", Offset = "0x407D950", VA = "0x4081950")]
		[AsyncStateMachine(typeof(_003CPreload_003Ed__9))]
		public UniTask Preload()
		{
			return default;
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x40819E0", Offset = "0x407D9E0", VA = "0x40819E0")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__10))]
		public UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x4081A6C", Offset = "0x407DA6C", VA = "0x4081A6C")]
		[AsyncStateMachine(typeof(_003CAddObjectToDict_003Ed__11))]
		private UniTask AddObjectToDict(string path)
		{
			return default;
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x4081B04", Offset = "0x407DB04", VA = "0x4081B04")]
		public CustomBundlesManager()
		{
		}
	}
}
