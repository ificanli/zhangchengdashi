using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000A12")]
	internal static class MysteryAdventurePanelAnimationHelper
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A13")]
		[CompilerGenerated]
		private struct _003CPlayAnimatorStateAsync_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4004AB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004AB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004AB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Animator animator;

			[Token(Token = "0x4004AB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string stateName;

			[Token(Token = "0x4004AB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float speedMultiplier;

			[Token(Token = "0x4004AB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C16")]
			[Address(RVA = "0x4143674", Offset = "0x413F674", VA = "0x4143674", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C17")]
			[Address(RVA = "0x4143B2C", Offset = "0x413FB2C", VA = "0x4143B2C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A14")]
		[CompilerGenerated]
		private struct _003CPlayLegacyClipAsync_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4004AB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004AB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004ABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Animation animation;

			[Token(Token = "0x4004ABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x4004ABC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float speedMultiplier;

			[Token(Token = "0x4004ABD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C18")]
			[Address(RVA = "0x4143B38", Offset = "0x413FB38", VA = "0x4143B38", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C19")]
			[Address(RVA = "0x414405C", Offset = "0x414005C", VA = "0x414405C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A15")]
		[CompilerGenerated]
		private struct _003CPlayRuinsRpsOutcomeAsync_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4004ABE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004ABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004AC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureRpsOutcome outcome;

			[Token(Token = "0x4004AC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject root;

			[Token(Token = "0x4004AC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float speedMultiplier;

			[Token(Token = "0x4004AC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Animator animator;

			[Token(Token = "0x4004AC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C1A")]
			[Address(RVA = "0x4144068", Offset = "0x4140068", VA = "0x4144068", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C1B")]
			[Address(RVA = "0x41446CC", Offset = "0x41406CC", VA = "0x41446CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A16")]
		[CompilerGenerated]
		private struct _003CPlayShowAsync_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4004AC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004AC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004AC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject root;

			[Token(Token = "0x4004AC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float speedMultiplier;

			[Token(Token = "0x4004AC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string preferredClipName;

			[Token(Token = "0x4004ACA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C1C")]
			[Address(RVA = "0x41446D8", Offset = "0x41406D8", VA = "0x41446D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C1D")]
			[Address(RVA = "0x4144F38", Offset = "0x4140F38", VA = "0x4144F38", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A17")]
		[CompilerGenerated]
		private struct _003CWaitForAnimatorAsync_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4004ACB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004ACC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004ACD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Animator animator;

			[Token(Token = "0x4004ACE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float speedMultiplier;

			[Token(Token = "0x4004ACF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float _003Cdeadline_003E5__2;

			[Token(Token = "0x4004AD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004AD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003C1E")]
			[Address(RVA = "0x4144F44", Offset = "0x4140F44", VA = "0x4144F44", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C1F")]
			[Address(RVA = "0x4145690", Offset = "0x4141690", VA = "0x4145690", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A18")]
		[CompilerGenerated]
		private struct _003CWaitForLegacyAnimationAsync_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4004AD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004AD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Animation animation;

			[Token(Token = "0x4004AD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x4004AD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float speedMultiplier;

			[Token(Token = "0x4004AD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float _003Cdeadline_003E5__2;

			[Token(Token = "0x4004AD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004AD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003C20")]
			[Address(RVA = "0x414569C", Offset = "0x414169C", VA = "0x414569C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C21")]
			[Address(RVA = "0x4145C70", Offset = "0x4141C70", VA = "0x4145C70", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004AB1")]
		private const float MinWaitSeconds = 0.05f;

		[Token(Token = "0x6003C08")]
		[Address(RVA = "0x41424A4", Offset = "0x413E4A4", VA = "0x41424A4")]
		public static void ApplySpeedToAll(GameObject root, float speedMultiplier)
		{
		}

		[Token(Token = "0x6003C09")]
		[Address(RVA = "0x4142944", Offset = "0x413E944", VA = "0x4142944")]
		public static bool HasPanelAnimation(GameObject root)
		{
			return default;
		}

		[Token(Token = "0x6003C0A")]
		[Address(RVA = "0x4142A60", Offset = "0x413EA60", VA = "0x4142A60")]
		[AsyncStateMachine(typeof(_003CPlayShowAsync_003Ed__3))]
		public static UniTask PlayShowAsync(GameObject root, float speedMultiplier, [Optional] string preferredClipName)
		{
			return default;
		}

		[Token(Token = "0x6003C0B")]
		[Address(RVA = "0x4142B0C", Offset = "0x413EB0C", VA = "0x4142B0C")]
		[AsyncStateMachine(typeof(_003CPlayAnimatorStateAsync_003Ed__4))]
		public static UniTask PlayAnimatorStateAsync(Animator animator, string stateName, float speedMultiplier)
		{
			return default;
		}

		[Token(Token = "0x6003C0C")]
		[Address(RVA = "0x4142BB4", Offset = "0x413EBB4", VA = "0x4142BB4")]
		[AsyncStateMachine(typeof(_003CPlayLegacyClipAsync_003Ed__5))]
		public static UniTask PlayLegacyClipAsync(Animation animation, string clipName, float speedMultiplier)
		{
			return default;
		}

		[Token(Token = "0x6003C0D")]
		[Address(RVA = "0x4142C5C", Offset = "0x413EC5C", VA = "0x4142C5C")]
		public static string GetRuinsRpsOutcomeClipName(MysteryAdventureRpsOutcome outcome)
		{
			return null;
		}

		[Token(Token = "0x6003C0E")]
		[Address(RVA = "0x4142CE0", Offset = "0x413ECE0", VA = "0x4142CE0")]
		public static void StopAllLegacyAnimations(GameObject root)
		{
		}

		[Token(Token = "0x6003C0F")]
		[Address(RVA = "0x4142DFC", Offset = "0x413EDFC", VA = "0x4142DFC")]
		[AsyncStateMachine(typeof(_003CPlayRuinsRpsOutcomeAsync_003Ed__8))]
		public static UniTask PlayRuinsRpsOutcomeAsync(GameObject root, Animator animator, MysteryAdventureRpsOutcome outcome, float speedMultiplier)
		{
			return default;
		}

		[Token(Token = "0x6003C10")]
		[Address(RVA = "0x4142EB4", Offset = "0x413EEB4", VA = "0x4142EB4")]
		public static Animation FindLegacyAnimationWithClip(GameObject root, string clipName)
		{
			return null;
		}

		[Token(Token = "0x6003C11")]
		[Address(RVA = "0x4142648", Offset = "0x413E648", VA = "0x4142648")]
		private static void ApplyLegacyAnimationSpeed(Animation animation, float speed)
		{
		}

		[Token(Token = "0x6003C12")]
		[Address(RVA = "0x4143000", Offset = "0x413F000", VA = "0x4143000")]
		private static string ResolveLegacyClipName(Animation animation, string preferredClipName)
		{
			return null;
		}

		[Token(Token = "0x6003C13")]
		[Address(RVA = "0x414336C", Offset = "0x413F36C", VA = "0x414336C")]
		private static string ResolveAnimatorStateName(Animator animator, string preferredClipName)
		{
			return null;
		}

		[Token(Token = "0x6003C14")]
		[Address(RVA = "0x414352C", Offset = "0x413F52C", VA = "0x414352C")]
		[AsyncStateMachine(typeof(_003CWaitForLegacyAnimationAsync_003Ed__13))]
		private static UniTask WaitForLegacyAnimationAsync(Animation animation, string clipName, float speedMultiplier)
		{
			return default;
		}

		[Token(Token = "0x6003C15")]
		[Address(RVA = "0x41435D8", Offset = "0x413F5D8", VA = "0x41435D8")]
		[AsyncStateMachine(typeof(_003CWaitForAnimatorAsync_003Ed__14))]
		private static UniTask WaitForAnimatorAsync(Animator animator, float speedMultiplier)
		{
			return default;
		}
	}
}
