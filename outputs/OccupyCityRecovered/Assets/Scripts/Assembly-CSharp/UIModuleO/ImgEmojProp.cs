using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20008C4")]
	public class ImgEmojProp : ImgEmojPropComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008C6")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x400427D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400427E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400427F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ImgEmojProp _003C_003E4__this;

			[Token(Token = "0x4004280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int id;

			[Token(Token = "0x4004281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool isEnemy;

			[Token(Token = "0x4004282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4004283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003246")]
			[Address(RVA = "0x406CD5C", Offset = "0x4068D5C", VA = "0x406CD5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003247")]
			[Address(RVA = "0x406D910", Offset = "0x4069910", VA = "0x406D910", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008C7")]
		[CompilerGenerated]
		private struct _003CInitSpineEmoji_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4004284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int id;

			[Token(Token = "0x4004287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ImgEmojProp _003C_003E4__this;

			[Token(Token = "0x4004288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Spine.Unity.SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003248")]
			[Address(RVA = "0x406D91C", Offset = "0x406991C", VA = "0x406D91C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003249")]
			[Address(RVA = "0x406DF70", Offset = "0x4069F70", VA = "0x406DF70", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400427B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float continueTime;

		[Token(Token = "0x6003240")]
		[Address(RVA = "0x406CBA0", Offset = "0x4068BA0", VA = "0x406CBA0")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public void Init(int id, bool isEnemy)
		{
		}

		[Token(Token = "0x6003241")]
		[Address(RVA = "0x406CC50", Offset = "0x4068C50", VA = "0x406CC50")]
		[AsyncStateMachine(typeof(_003CInitSpineEmoji_003Ed__2))]
		private void InitSpineEmoji(int id, bool isEnemy)
		{
		}

		[Token(Token = "0x6003242")]
		[Address(RVA = "0x406CCF0", Offset = "0x4068CF0", VA = "0x406CCF0")]
		public ImgEmojProp()
		{
		}
	}
}
