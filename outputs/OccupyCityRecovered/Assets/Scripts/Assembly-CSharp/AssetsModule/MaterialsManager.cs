using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace AssetsModule
{
	[Token(Token = "0x2000645")]
	public class MaterialsManager : ManagerBase<MaterialsManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000646")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__54 : IAsyncStateMachine
		{
			[Token(Token = "0x4003348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400334A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MaterialsManager _003C_003E4__this;

			[Token(Token = "0x400334B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<Material>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002108")]
			[Address(RVA = "0x3F19340", Offset = "0x3F15340", VA = "0x3F19340", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002109")]
			[Address(RVA = "0x3F1E12C", Offset = "0x3F1A12C", VA = "0x3F1E12C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400331E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material BTestEnemyHexInside;

		[Token(Token = "0x400331F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material BTestEnemyHexOutside;

		[Token(Token = "0x4003320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material BTestPlayerHexInside;

		[Token(Token = "0x4003321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material BTestPlayerHexOutside;

		[Token(Token = "0x4003322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material SeasonBTestEnemyHexInside;

		[Token(Token = "0x4003323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material SeasonBTestEnemyHexOutside;

		[Token(Token = "0x4003324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material SeasonBTestPlayerHexInside;

		[Token(Token = "0x4003325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material SeasonBTestPlayerHexOutside;

		[Token(Token = "0x4003326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Material snowEnemy;

		[Token(Token = "0x4003327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Material snowPlayer;

		[Token(Token = "0x4003328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<string, Material> hexMatPlayerDic;

		[Token(Token = "0x4003329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<string, Material> hexMatEnemyDic;

		[Token(Token = "0x400332A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material EnemyHex01;

		[Token(Token = "0x400332B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Material PlayerHex01;

		[Token(Token = "0x400332C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material EnemyHex02;

		[Token(Token = "0x400332D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Material PlayerHex02;

		[Token(Token = "0x400332E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material EnemyHex03;

		[Token(Token = "0x400332F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material PlayerHex03;

		[Token(Token = "0x4003330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material EnemyHex04;

		[Token(Token = "0x4003331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material PlayerHex04;

		[Token(Token = "0x4003332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material EnemyHex05;

		[Token(Token = "0x4003333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material PlayerHex05;

		[Token(Token = "0x4003334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Material EnemyHex06;

		[Token(Token = "0x4003335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material PlayerHex06;

		[Token(Token = "0x4003336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Material EnemyHex07;

		[Token(Token = "0x4003337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material PlayerHex07;

		[Token(Token = "0x4003338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Material EnemyHex08;

		[Token(Token = "0x4003339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material PlayerHex08;

		[Token(Token = "0x400333A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Material EnemyHex09;

		[Token(Token = "0x400333B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Material PlayerHex09;

		[Token(Token = "0x400333C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Material EnemyHex10;

		[Token(Token = "0x400333D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Material PlayerHex10;

		[Token(Token = "0x400333E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Material EnemyHex11;

		[Token(Token = "0x400333F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Material PlayerHex11;

		[Token(Token = "0x4003340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Material EnemyHex12;

		[Token(Token = "0x4003341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Material PlayerHex12;

		[Token(Token = "0x4003342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Material PlayerHex13;

		[Token(Token = "0x4003343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Material EnemyHex13;

		[Token(Token = "0x4003344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Material PlayerHex14;

		[Token(Token = "0x4003345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Material EnemyHex14;

		[Token(Token = "0x4003346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Material PlayerHex15;

		[Token(Token = "0x4003347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Material EnemyHex15;

		[Token(Token = "0x170001CA")]
		public Material PlayerSkinMat
		{
			[Token(Token = "0x60020FC")]
			[Address(RVA = "0x3F18B9C", Offset = "0x3F14B9C", VA = "0x3F18B9C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020FD")]
			[Address(RVA = "0x3F18BA4", Offset = "0x3F14BA4", VA = "0x3F18BA4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001CB")]
		public Material EnemySkinMat
		{
			[Token(Token = "0x60020FE")]
			[Address(RVA = "0x3F18BAC", Offset = "0x3F14BAC", VA = "0x3F18BAC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020FF")]
			[Address(RVA = "0x3F18BB4", Offset = "0x3F14BB4", VA = "0x3F18BB4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001CC")]
		public Material EnemyHexMatRes
		{
			[Token(Token = "0x6002100")]
			[Address(RVA = "0x3F18BBC", Offset = "0x3F14BBC", VA = "0x3F18BBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CD")]
		public Material PlayerHexMatRes
		{
			[Token(Token = "0x6002101")]
			[Address(RVA = "0x3F18CE4", Offset = "0x3F14CE4", VA = "0x3F18CE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002102")]
		[Address(RVA = "0x3F18E0C", Offset = "0x3F14E0C", VA = "0x3F18E0C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__54))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6002103")]
		[Address(RVA = "0x3F18E9C", Offset = "0x3F14E9C", VA = "0x3F18E9C")]
		public Material GetHexMaterial(bool isEnemy, float zCoord, bool isSeasonBTest = false)
		{
			return null;
		}

		[Token(Token = "0x6002104")]
		[Address(RVA = "0x3F190E4", Offset = "0x3F150E4", VA = "0x3F190E4")]
		public Material GetHexMaterialByKey(bool isEnemy, string key, bool isSeasonBTest = false)
		{
			return null;
		}

		[Token(Token = "0x6002105")]
		[Address(RVA = "0x3F18FD0", Offset = "0x3F14FD0", VA = "0x3F18FD0")]
		private bool IsInsideRing(float zCoord)
		{
			return default;
		}

		[Token(Token = "0x6002106")]
		[Address(RVA = "0x3F191B8", Offset = "0x3F151B8", VA = "0x3F191B8")]
		private float ParseZFromKey(string key)
		{
			return default;
		}

		[Token(Token = "0x6002107")]
		[Address(RVA = "0x3F19298", Offset = "0x3F15298", VA = "0x3F19298")]
		public MaterialsManager()
		{
		}
	}
}
