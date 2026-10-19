using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000C4A")]
	public class UITextEffectManager : ManagerBase<UITextEffectManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C4B")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x400583D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400583E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400583F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UITextEffectManager _003C_003E4__this;

			[Token(Token = "0x4005840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004C28")]
			[Address(RVA = "0x427417C", Offset = "0x427017C", VA = "0x427417C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004C29")]
			[Address(RVA = "0x427473C", Offset = "0x427073C", VA = "0x427473C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform _textEffectPoolRect;

		[Token(Token = "0x400583A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform _cardEffectPoolRect;

		[Token(Token = "0x400583B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject textEffectPrefab;

		[Token(Token = "0x400583C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject cardEffectPrefab;

		[Token(Token = "0x6004C21")]
		[Address(RVA = "0x42734E0", Offset = "0x426F4E0", VA = "0x42734E0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__4))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6004C22")]
		[Address(RVA = "0x427357C", Offset = "0x426F57C", VA = "0x427357C")]
		public void PrewarmBattleTextEffects([Optional] Action<string, int, double> onItemPrewarmed)
		{
		}

		[Token(Token = "0x6004C23")]
		[Address(RVA = "0x42735B4", Offset = "0x426F5B4", VA = "0x42735B4")]
		private static void PrewarmBattleTextEffect(GameObject prefab, int count, Action<string, int, double> onItemPrewarmed)
		{
		}

		[Token(Token = "0x6004C24")]
		[Address(RVA = "0x42736E0", Offset = "0x426F6E0", VA = "0x42736E0")]
		private static double GetElapsedMilliseconds(long startTicks)
		{
			return default;
		}

		[Token(Token = "0x6004C25")]
		[Address(RVA = "0x4273760", Offset = "0x426F760", VA = "0x4273760")]
		public void ShowTextEffect(string text, Vector3 position, TextEffImgType imgType, float endScale = 1f, PositionType positionType = PositionType.WorldPosition)
		{
		}

		[Token(Token = "0x6004C26")]
		[Address(RVA = "0x4273B28", Offset = "0x426FB28", VA = "0x4273B28")]
		public void ShowCardUIEffect(RareLevel rareLevel, string id, Vector3 position)
		{
		}

		[Token(Token = "0x6004C27")]
		[Address(RVA = "0x4273D14", Offset = "0x426FD14", VA = "0x4273D14")]
		public UITextEffectManager()
		{
		}
	}
}
