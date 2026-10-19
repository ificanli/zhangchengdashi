using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine.UI;

namespace GameModule
{
	[Token(Token = "0x20005BB")]
	public class SkinManager : ManagerBase<SkinManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005C0")]
		[CompilerGenerated]
		private struct _003CFixSeasonPassLevel10BannerAsync_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40030F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40030F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40030F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001DF0")]
			[Address(RVA = "0x3EEEC78", Offset = "0x3EEAC78", VA = "0x3EEEC78", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001DF1")]
			[Address(RVA = "0x3EEF554", Offset = "0x3EEB554", VA = "0x3EEF554", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005C1")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x40030F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40030F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40030F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SkinManager _003C_003E4__this;

			[Token(Token = "0x6001DF2")]
			[Address(RVA = "0x3EEF560", Offset = "0x3EEB560", VA = "0x3EEF560", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001DF3")]
			[Address(RVA = "0x3EEF748", Offset = "0x3EEB748", VA = "0x3EEF748", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005C2")]
		[CompilerGenerated]
		private struct _003CLoadBanner_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40030F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40030FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40030FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Image image;

			[Token(Token = "0x40030FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001DF4")]
			[Address(RVA = "0x3EEF754", Offset = "0x3EEB754", VA = "0x3EEF754", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001DF5")]
			[Address(RVA = "0x3EEFBDC", Offset = "0x3EEBBDC", VA = "0x3EEFBDC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005C3")]
		[CompilerGenerated]
		private struct _003CLoadEnemyBanner_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40030FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40030FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40030FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Image image;

			[Token(Token = "0x4003100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001DF6")]
			[Address(RVA = "0x3EEFBE8", Offset = "0x3EEBBE8", VA = "0x3EEFBE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001DF7")]
			[Address(RVA = "0x3EF01E4", Offset = "0x3EEC1E4", VA = "0x3EF01E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6001DD9")]
		[Address(RVA = "0x3EECBB4", Offset = "0x3EE8BB4", VA = "0x3EECBB4", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001DDA")]
		[Address(RVA = "0x3EECC38", Offset = "0x3EE8C38", VA = "0x3EECC38")]
		private void InitPlayerSkinData()
		{
		}

		[Token(Token = "0x6001DDB")]
		[Address(RVA = "0x3EED3E0", Offset = "0x3EE93E0", VA = "0x3EED3E0")]
		public void MonthPassBanner(bool isHadMonthPass)
		{
		}

		[Token(Token = "0x6001DDC")]
		[Address(RVA = "0x3EED800", Offset = "0x3EE9800", VA = "0x3EED800")]
		[AsyncStateMachine(typeof(_003CLoadEnemyBanner_003Ed__3))]
		public void LoadEnemyBanner(Image image)
		{
		}

		[Token(Token = "0x6001DDD")]
		[Address(RVA = "0x3EED890", Offset = "0x3EE9890", VA = "0x3EED890")]
		[AsyncStateMachine(typeof(_003CLoadBanner_003Ed__4))]
		public void LoadBanner(Image image)
		{
		}

		[Token(Token = "0x6001DDE")]
		[Address(RVA = "0x3EED050", Offset = "0x3EE9050", VA = "0x3EED050")]
		private void FixLostBannerSkins()
		{
		}

		[Token(Token = "0x6001DDF")]
		[Address(RVA = "0x3EED928", Offset = "0x3EE9928", VA = "0x3EED928")]
		[AsyncStateMachine(typeof(_003CFixSeasonPassLevel10BannerAsync_003Ed__6))]
		private UniTask FixSeasonPassLevel10BannerAsync()
		{
			return default;
		}

		[Token(Token = "0x6001DE0")]
		[Address(RVA = "0x3EED9AC", Offset = "0x3EE99AC", VA = "0x3EED9AC")]
		private void InitPlayerExpressionData()
		{
		}

		[Token(Token = "0x6001DE1")]
		[Address(RVA = "0x3EEE14C", Offset = "0x3EEA14C", VA = "0x3EEE14C")]
		private void InitPlayerBubbleData()
		{
		}

		[Token(Token = "0x6001DE2")]
		[Address(RVA = "0x3EEE5A8", Offset = "0x3EEA5A8", VA = "0x3EEE5A8")]
		public void GMGetExpression()
		{
		}

		[Token(Token = "0x6001DE3")]
		[Address(RVA = "0x3EEE9D4", Offset = "0x3EEA9D4", VA = "0x3EEE9D4")]
		public SkinManager()
		{
		}
	}
}
