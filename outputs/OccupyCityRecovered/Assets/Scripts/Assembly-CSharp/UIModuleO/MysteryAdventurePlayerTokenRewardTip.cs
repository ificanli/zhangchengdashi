using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A2C")]
	public class MysteryAdventurePlayerTokenRewardTip : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A2D")]
		[CompilerGenerated]
		private struct _003CLoadResourceIconAsync_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4004B95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004B96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4004B97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string assetId;

			[Token(Token = "0x4004B98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003CC7")]
			[Address(RVA = "0x414C660", Offset = "0x4148660", VA = "0x414C660", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003CC8")]
			[Address(RVA = "0x414CC08", Offset = "0x4148C08", VA = "0x414CC08", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A2E")]
		[CompilerGenerated]
		private struct _003CShowAsync_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4004B99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004B9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004B9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string assetId;

			[Token(Token = "0x4004B9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int count;

			[Token(Token = "0x4004B9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MysteryAdventurePlayerTokenRewardTip _003C_003E4__this;

			[Token(Token = "0x4004B9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004B9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x4004BA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__3;

			[Token(Token = "0x6003CC9")]
			[Address(RVA = "0x414CC60", Offset = "0x4148C60", VA = "0x414CC60", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003CCA")]
			[Address(RVA = "0x414D888", Offset = "0x4149888", VA = "0x414D888", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004B8C")]
		private const float PopInDuration = 0.25f;

		[Token(Token = "0x4004B8D")]
		private const float PopOutDuration = 0.15f;

		[Token(Token = "0x4004B8E")]
		private const float HoldDuration = 0.85f;

		[Token(Token = "0x4004B8F")]
		private const float PopOvershootScale = 1.15f;

		[Token(Token = "0x4004B90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _root;

		[Token(Token = "0x4004B91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _iconImage;

		[Token(Token = "0x4004B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _amountText;

		[Token(Token = "0x4004B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _initialized;

		[Token(Token = "0x4004B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isPlaying;

		[Token(Token = "0x6003CBF")]
		[Address(RVA = "0x4140440", Offset = "0x413C440", VA = "0x4140440")]
		public static MysteryAdventurePlayerTokenRewardTip GetOrCreate(RectTransform playerToken)
		{
			return null;
		}

		[Token(Token = "0x6003CC0")]
		[Address(RVA = "0x414C218", Offset = "0x4148218", VA = "0x414C218")]
		public void EnsureInitialized()
		{
		}

		[Token(Token = "0x6003CC1")]
		[Address(RVA = "0x4140558", Offset = "0x413C558", VA = "0x4140558")]
		[AsyncStateMachine(typeof(_003CShowAsync_003Ed__11))]
		public UniTask ShowAsync(string assetId, int count)
		{
			return default;
		}

		[Token(Token = "0x6003CC2")]
		[Address(RVA = "0x414C330", Offset = "0x4148330", VA = "0x414C330")]
		private void RefreshLayout()
		{
		}

		[Token(Token = "0x6003CC3")]
		[Address(RVA = "0x414C420", Offset = "0x4148420", VA = "0x414C420")]
		[AsyncStateMachine(typeof(_003CLoadResourceIconAsync_003Ed__13))]
		private static UniTask<Sprite> LoadResourceIconAsync(string assetId)
		{
			return default;
		}

		[Token(Token = "0x6003CC4")]
		[Address(RVA = "0x414C4F4", Offset = "0x41484F4", VA = "0x414C4F4")]
		private static bool TryGetTokenRewardIconPath(string assetId, out string spritePath)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventurePlayerTokenRewardTip.TryGetTokenRewardIconPath RVA=0x414C4F4 Token=0x6003CC4");
}

		[Token(Token = "0x6003CC5")]
		[Address(RVA = "0x414C640", Offset = "0x4148640", VA = "0x414C640")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6003CC6")]
		[Address(RVA = "0x414C658", Offset = "0x4148658", VA = "0x414C658")]
		public MysteryAdventurePlayerTokenRewardTip()
		{
		}
	}
}
