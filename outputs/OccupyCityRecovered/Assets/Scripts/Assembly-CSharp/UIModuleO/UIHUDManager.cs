using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000C46")]
	public class UIHUDManager : ManagerBase<UIHUDManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C47")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x400582D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400582E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400582F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIHUDManager _003C_003E4__this;

			[Token(Token = "0x4005830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004C1F")]
			[Address(RVA = "0x4272EB8", Offset = "0x426EEB8", VA = "0x4272EB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004C20")]
			[Address(RVA = "0x42734D4", Offset = "0x426F4D4", VA = "0x42734D4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<IHUDElement> _hudElements;

		[Token(Token = "0x400582A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject hpBarPrefab;

		[Token(Token = "0x400582B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject progressUIPrefab;

		[Token(Token = "0x400582C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform _hudRoot;

		[Token(Token = "0x6004C13")]
		[Address(RVA = "0x4272354", Offset = "0x426E354", VA = "0x4272354", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__4))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6004C14")]
		[Address(RVA = "0x42723E4", Offset = "0x426E3E4", VA = "0x42723E4")]
		private RectTransform CreateHudRoot()
		{
			return null;
		}

		[Token(Token = "0x6004C15")]
		[Address(RVA = "0x42724DC", Offset = "0x426E4DC", VA = "0x42724DC")]
		public HpBarUI GetHpBarHUD(GameObject target, float yOffset)
		{
			return null;
		}

		[Token(Token = "0x6004C16")]
		[Address(RVA = "0x4272580", Offset = "0x426E580", VA = "0x4272580")]
		public void RecycleHealthBatHUD(HpBarUI healthBar)
		{
		}

		[Token(Token = "0x6004C17")]
		[Address(RVA = "0x427266C", Offset = "0x426E66C", VA = "0x427266C")]
		public SpawnTimeProgressUI GetProgressHUD(GameObject target, float yOffset)
		{
			return null;
		}

		[Token(Token = "0x6004C18")]
		[Address(RVA = "0x4272710", Offset = "0x426E710", VA = "0x4272710")]
		public void RecycleProgressHUD(SpawnTimeProgressUI progressUI)
		{
		}

		[Token(Token = "0x6004C19")]
		private T InitHUDComponent<T>(GameObject hudGo, GameObject target, float yOffset) where T : MonoBehaviour, IHUDElement
		{
			return null;
		}

		[Token(Token = "0x6004C1A")]
		[Address(RVA = "0x4272828", Offset = "0x426E828", VA = "0x4272828")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6004C1B")]
		[Address(RVA = "0x427282C", Offset = "0x426E82C", VA = "0x427282C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6004C1C")]
		[Address(RVA = "0x4272884", Offset = "0x426E884", VA = "0x4272884")]
		private void UpdateHUDPositions()
		{
		}

		[Token(Token = "0x6004C1D")]
		[Address(RVA = "0x4272CD8", Offset = "0x426ECD8", VA = "0x4272CD8")]
		public void Clear()
		{
		}

		[Token(Token = "0x6004C1E")]
		[Address(RVA = "0x4272E70", Offset = "0x426EE70", VA = "0x4272E70")]
		public UIHUDManager()
		{
		}
	}
}
