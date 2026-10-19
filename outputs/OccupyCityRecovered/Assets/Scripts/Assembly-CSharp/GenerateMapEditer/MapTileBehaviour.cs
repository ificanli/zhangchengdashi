using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace GenerateMapEditer
{
	[Token(Token = "0x20001DA")]
	public class MapTileBehaviour : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001DC")]
		[CompilerGenerated]
		private struct _003CChangeTileBuild_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MapTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string buildId;

			[Token(Token = "0x4001C0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action onComplete;

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x408A338", Offset = "0x4086338", VA = "0x408A338", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x408B86C", Offset = "0x408786C", VA = "0x408B86C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001DD")]
		[CompilerGenerated]
		private struct _003CChangeTileType_003Ed__31 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string tileType;

			[Token(Token = "0x4001C13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MapTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action onComplete;

			[Token(Token = "0x4001C15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Transform _003Ctf_003E5__2;

			[Token(Token = "0x4001C16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private MeshRenderer _003C_003E7__wrap2;

			[Token(Token = "0x4001C17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Material>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x408B878", Offset = "0x4087878", VA = "0x408B878", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x408CCA0", Offset = "0x4088CA0", VA = "0x408CCA0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001DE")]
		[CompilerGenerated]
		private struct _003CCreatEnemy_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MapTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x408CCAC", Offset = "0x4088CAC", VA = "0x408CCAC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x408D364", Offset = "0x4089364", VA = "0x408D364", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001DF")]
		[CompilerGenerated]
		private struct _003CCreatModel_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MapTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x408D370", Offset = "0x4089370", VA = "0x408D370", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x408DA34", Offset = "0x4089A34", VA = "0x408DA34", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001E0")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MapTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string key;

			[Token(Token = "0x4001C24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string tileType;

			[Token(Token = "0x4001C25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<string> cards;

			[Token(Token = "0x4001C26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string buildId;

			[Token(Token = "0x4001C27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string enemyModelId;

			[Token(Token = "0x4001C28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string humanData;

			[Token(Token = "0x4001C29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x408DA40", Offset = "0x4089A40", VA = "0x408DA40", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x408E270", Offset = "0x408A270", VA = "0x408E270", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001E1")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MapTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalMapInfo tileInfo;

			[Token(Token = "0x4001C2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x408E27C", Offset = "0x408A27C", VA = "0x408E27C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x408E684", Offset = "0x408A684", VA = "0x408E684", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001BF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string key;

		[Token(Token = "0x4001BF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isCalced;

		[Token(Token = "0x4001BF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<string> enemyCards;

		[Token(Token = "0x4001BF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MapTileBehaviour leftUpTile;

		[Token(Token = "0x4001BF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MapTileBehaviour rightUpTile;

		[Token(Token = "0x4001BF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MapTileBehaviour upTile;

		[Token(Token = "0x4001BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MapTileBehaviour downTile;

		[Token(Token = "0x4001BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MapTileBehaviour leftDownTile;

		[Token(Token = "0x4001BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MapTileBehaviour rightDownTile;

		[Token(Token = "0x4001BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject buildModel;

		[Token(Token = "0x4001BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string tileType;

		[Token(Token = "0x4001BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform tweenTransform;

		[Token(Token = "0x4001BFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string humanType;

		[Token(Token = "0x4001BFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string humanNumber;

		[Token(Token = "0x4001C00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string buildModelId;

		[Token(Token = "0x4001C01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string enemyModelId;

		[Token(Token = "0x4001C02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string eventType;

		[Token(Token = "0x4001C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public List<GameObject> enemys;

		[Token(Token = "0x4001C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Transform enemyHumanPosParent;

		[Token(Token = "0x4001C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform buildPosParent;

		[Token(Token = "0x4001C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshPro typeText;

		[Token(Token = "0x4001C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshPro humanNumberText;

		[Token(Token = "0x4001C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform tileBaseModelTf;

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x4087F54", Offset = "0x4083F54", VA = "0x4087F54")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__23))]
		public UniTask Init(string key, string tileType, string humanData, List<string> cards, string buildId, string enemyModelId)
		{
			return default;
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x40894A0", Offset = "0x40854A0", VA = "0x40894A0")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__24))]
		public UniTask Init(GlobalMapInfo tileInfo)
		{
			return default;
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x408953C", Offset = "0x408553C", VA = "0x408953C")]
		private TextMeshPro CreatTextMeshPro()
		{
			return null;
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x40896F0", Offset = "0x40856F0", VA = "0x40896F0")]
		public void ChangeHumanData(string type, string number, string buildModelId, string enemyModelId, string eventType)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x40898F8", Offset = "0x40858F8", VA = "0x40898F8")]
		public void ClearAllEnemy()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x40897D8", Offset = "0x40857D8", VA = "0x40897D8")]
		[AsyncStateMachine(typeof(_003CCreatEnemy_003Ed__28))]
		public void CreatEnemy()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x4089A90", Offset = "0x4085A90", VA = "0x4089A90")]
		public string GetHumanPath()
		{
			return null;
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x4089D44", Offset = "0x4085D44", VA = "0x4089D44")]
		private string ToName(string str)
		{
			return null;
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x4089FDC", Offset = "0x4085FDC", VA = "0x4089FDC")]
		[AsyncStateMachine(typeof(_003CChangeTileType_003Ed__31))]
		public UniTask ChangeTileType(string tileType, [Optional] Action onComplete)
		{
			return default;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x4089868", Offset = "0x4085868", VA = "0x4089868")]
		[AsyncStateMachine(typeof(_003CCreatModel_003Ed__32))]
		private void CreatModel()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x408A084", Offset = "0x4086084", VA = "0x408A084")]
		[AsyncStateMachine(typeof(_003CChangeTileBuild_003Ed__33))]
		public UniTask ChangeTileBuild(string buildId, [Optional] Action onComplete)
		{
			return default;
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x4086FFC", Offset = "0x4082FFC", VA = "0x4086FFC")]
		public void SetShowName([Optional] bool? active)
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x408A11C", Offset = "0x408611C", VA = "0x408A11C")]
		private void SetAgeNumberATKActive(bool active)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x408A1DC", Offset = "0x40861DC", VA = "0x408A1DC")]
		public void ChangeEnemyCardData(List<string> cards)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x408A1E4", Offset = "0x40861E4", VA = "0x408A1E4")]
		public MapTileBehaviour()
		{
		}
	}
}
