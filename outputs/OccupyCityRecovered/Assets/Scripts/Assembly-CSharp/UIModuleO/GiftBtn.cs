using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20008DD")]
	public class GiftBtn : GiftBtnComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008DE")]
		[CompilerGenerated]
		private struct _003CUpdateIcon_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4004320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GiftBtn _003C_003E4__this;

			[Token(Token = "0x4004323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string path;

			[Token(Token = "0x4004324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4004325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003301")]
			[Address(RVA = "0x4092644", Offset = "0x408E644", VA = "0x4092644", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003302")]
			[Address(RVA = "0x4092A08", Offset = "0x408EA08", VA = "0x4092A08", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008DF")]
		[CompilerGenerated]
		private struct _003CUpdateSpine_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4004326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GiftBtn _003C_003E4__this;

			[Token(Token = "0x4004329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string path;

			[Token(Token = "0x400432A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private SkeletonGraphic _003C_003E7__wrap1;

			[Token(Token = "0x400432B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003303")]
			[Address(RVA = "0x4092A14", Offset = "0x408EA14", VA = "0x4092A14", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003304")]
			[Address(RVA = "0x4092E08", Offset = "0x408EE08", VA = "0x4092E08", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x170006C1")]
		public bool ShowCutDowning
		{
			[Token(Token = "0x60032F7")]
			[Address(RVA = "0x4091EC4", Offset = "0x408DEC4", VA = "0x4091EC4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60032F8")]
		[Address(RVA = "0x4091FB4", Offset = "0x408DFB4", VA = "0x4091FB4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60032F9")]
		[Address(RVA = "0x409201C", Offset = "0x408E01C", VA = "0x409201C", Slot = "5")]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60032FA")]
		[Address(RVA = "0x40920B4", Offset = "0x408E0B4", VA = "0x40920B4")]
		public void UpdateName(string getLocalization)
		{
		}

		[Token(Token = "0x60032FB")]
		[Address(RVA = "0x40922C4", Offset = "0x408E2C4", VA = "0x40922C4")]
		[AsyncStateMachine(typeof(_003CUpdateIcon_003Ed__5))]
		public void UpdateIcon(string path)
		{
		}

		[Token(Token = "0x60032FC")]
		[Address(RVA = "0x4092364", Offset = "0x408E364", VA = "0x4092364")]
		public void UpdateIconBG(Sprite sprite)
		{
		}

		[Token(Token = "0x60032FD")]
		[Address(RVA = "0x4092450", Offset = "0x408E450", VA = "0x4092450")]
		[AsyncStateMachine(typeof(_003CUpdateSpine_003Ed__7))]
		public void UpdateSpine(string path)
		{
		}

		[Token(Token = "0x60032FE")]
		[Address(RVA = "0x40924F0", Offset = "0x408E4F0", VA = "0x40924F0")]
		public void UpdateCutDown(string timeStr)
		{
		}

		[Token(Token = "0x60032FF")]
		[Address(RVA = "0x4091FF4", Offset = "0x408DFF4", VA = "0x4091FF4")]
		public void HideCutDown()
		{
		}

		[Token(Token = "0x6003300")]
		[Address(RVA = "0x4092634", Offset = "0x408E634", VA = "0x4092634")]
		public GiftBtn()
		{
		}
	}
}
