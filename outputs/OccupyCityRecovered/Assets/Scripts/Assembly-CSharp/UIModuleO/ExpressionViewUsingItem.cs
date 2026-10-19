using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000833")]
	public class ExpressionViewUsingItem : ExpressionViewUsingItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000834")]
		[CompilerGenerated]
		private struct _003CInitExpression_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003E79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ExpressionViewUsingItem _003C_003E4__this;

			[Token(Token = "0x4003E7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int Index;

			[Token(Token = "0x4003E7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GlobalExpression expressionInfo;

			[Token(Token = "0x4003E7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ExpressionView expressionView;

			[Token(Token = "0x4003E7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Spine.Unity.SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002DE9")]
			[Address(RVA = "0x40149D4", Offset = "0x40109D4", VA = "0x40149D4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002DEA")]
			[Address(RVA = "0x4015090", Offset = "0x4011090", VA = "0x4015090", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003E73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _index;

		[Token(Token = "0x4003E74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GlobalExpression _expressionInfo;

		[Token(Token = "0x4003E75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ExpressionView _expressionView;

		[Token(Token = "0x4003E76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string _animationName;

		[Token(Token = "0x6002DE5")]
		[Address(RVA = "0x400FC78", Offset = "0x400BC78", VA = "0x400FC78")]
		[AsyncStateMachine(typeof(_003CInitExpression_003Ed__4))]
		public UniTask InitExpression(int Index, GlobalExpression expressionInfo, ExpressionView expressionView)
		{
			return default;
		}

		[Token(Token = "0x6002DE6")]
		[Address(RVA = "0x4014718", Offset = "0x4010718", VA = "0x4014718", Slot = "12")]
		protected override void OnButtonUsingItemButtonClicked()
		{
		}

		[Token(Token = "0x6002DE7")]
		[Address(RVA = "0x40147BC", Offset = "0x40107BC", VA = "0x40147BC")]
		private void PlaySpineAnimation()
		{
		}

		[Token(Token = "0x6002DE8")]
		[Address(RVA = "0x40149C4", Offset = "0x40109C4", VA = "0x40149C4")]
		public ExpressionViewUsingItem()
		{
		}
	}
}
