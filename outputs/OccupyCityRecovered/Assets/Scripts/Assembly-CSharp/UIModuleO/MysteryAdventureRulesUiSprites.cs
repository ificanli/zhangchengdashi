using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000A4E")]
	public class MysteryAdventureRulesUiSprites
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A4F")]
		[CompilerGenerated]
		private struct _003CLoad_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x4004C54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004C55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4004C56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string path;

			[Token(Token = "0x4004C57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003DC3")]
			[Address(RVA = "0x416176C", Offset = "0x415D76C", VA = "0x416176C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003DC4")]
			[Address(RVA = "0x4161C40", Offset = "0x415DC40", VA = "0x4161C40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A50")]
		[CompilerGenerated]
		private struct _003CLoadAll_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4004C58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004C59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite[]> _003C_003Et__builder;

			[Token(Token = "0x4004C5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string[] paths;

			[Token(Token = "0x4004C5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite[]>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003DC5")]
			[Address(RVA = "0x4161C98", Offset = "0x415DC98", VA = "0x4161C98", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003DC6")]
			[Address(RVA = "0x41621BC", Offset = "0x415E1BC", VA = "0x41621BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A51")]
		[CompilerGenerated]
		private struct _003CLoadAsync_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4004C5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004C5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<MysteryAdventureRulesUiSprites> _003C_003Et__builder;

			[Token(Token = "0x4004C5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string[] buildingIconPaths;

			[Token(Token = "0x4004C5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004C60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<(Sprite, Sprite, Sprite, Sprite[], Sprite[])>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003DC7")]
			[Address(RVA = "0x4162214", Offset = "0x415E214", VA = "0x4162214", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003DC8")]
			[Address(RVA = "0x4162D2C", Offset = "0x415ED2C", VA = "0x4162D2C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Sprite[] _banners;

		[Token(Token = "0x4004C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Sprite[] _buildingIcons;

		[Token(Token = "0x4004C51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MysteryAdventureRulesUiSprites _cached;

		[Token(Token = "0x4004C52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _loading;

		[Token(Token = "0x4004C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string[] _cachedBuildingIconPaths;

		[Token(Token = "0x17000950")]
		public Sprite PanelBg
		{
			[Token(Token = "0x6003DB6")]
			[Address(RVA = "0x41614D8", Offset = "0x415D4D8", VA = "0x41614D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DB7")]
			[Address(RVA = "0x41614E0", Offset = "0x415D4E0", VA = "0x41614E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000951")]
		public Sprite TabActive
		{
			[Token(Token = "0x6003DB8")]
			[Address(RVA = "0x41614E8", Offset = "0x415D4E8", VA = "0x41614E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DB9")]
			[Address(RVA = "0x41614F0", Offset = "0x415D4F0", VA = "0x41614F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000952")]
		public Sprite TabInactive
		{
			[Token(Token = "0x6003DBA")]
			[Address(RVA = "0x41614F8", Offset = "0x415D4F8", VA = "0x41614F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DBB")]
			[Address(RVA = "0x4161500", Offset = "0x415D500", VA = "0x4161500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6003DBC")]
		[Address(RVA = "0x415FADC", Offset = "0x415BADC", VA = "0x415FADC")]
		[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__16))]
		public static UniTask<MysteryAdventureRulesUiSprites> LoadAsync([Optional] string[] buildingIconPaths)
		{
			return default;
		}

		[Token(Token = "0x6003DBD")]
		[Address(RVA = "0x4161508", Offset = "0x415D508", VA = "0x4161508")]
		private static bool PathsEqual(string[] a, string[] b)
		{
			return default;
		}

		[Token(Token = "0x6003DBE")]
		[Address(RVA = "0x415EC08", Offset = "0x415AC08", VA = "0x415EC08")]
		public Sprite GetBanner(int bannerIndex)
		{
			return null;
		}

		[Token(Token = "0x6003DBF")]
		[Address(RVA = "0x415EC54", Offset = "0x415AC54", VA = "0x415EC54")]
		public Sprite GetBuildingIcon(int buildIndex)
		{
			return null;
		}

		[Token(Token = "0x6003DC0")]
		[Address(RVA = "0x41615BC", Offset = "0x415D5BC", VA = "0x41615BC")]
		[AsyncStateMachine(typeof(_003CLoadAll_003Ed__21))]
		private static UniTask<Sprite[]> LoadAll(string[] paths)
		{
			return default;
		}

		[Token(Token = "0x6003DC1")]
		[Address(RVA = "0x4161690", Offset = "0x415D690", VA = "0x4161690")]
		[AsyncStateMachine(typeof(_003CLoad_003Ed__22))]
		private static UniTask<Sprite> Load(string path)
		{
			return default;
		}

		[Token(Token = "0x6003DC2")]
		[Address(RVA = "0x4161764", Offset = "0x415D764", VA = "0x4161764")]
		public MysteryAdventureRulesUiSprites()
		{
		}
	}
}
