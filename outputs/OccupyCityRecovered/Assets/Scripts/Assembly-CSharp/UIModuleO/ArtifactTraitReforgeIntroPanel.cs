using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20006E2")]
	public class ArtifactTraitReforgeIntroPanel : ArtifactTraitReforgeIntroPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006E3")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4003700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactTraitReforgeIntroPanel _003C_003E4__this;

			[Token(Token = "0x4003703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4003704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002524")]
			[Address(RVA = "0x3F67DDC", Offset = "0x3F63DDC", VA = "0x3F67DDC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002525")]
			[Address(RVA = "0x3F681EC", Offset = "0x3F641EC", VA = "0x3F681EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40036FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float[] QualityWeights;

		[Token(Token = "0x6002518")]
		[Address(RVA = "0x3F65FE4", Offset = "0x3F61FE4", VA = "0x3F65FE4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002519")]
		[Address(RVA = "0x3F660FC", Offset = "0x3F620FC", VA = "0x3F660FC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600251A")]
		[Address(RVA = "0x3F66198", Offset = "0x3F62198", VA = "0x3F66198")]
		private void RefreshView()
		{
		}

		[Token(Token = "0x600251B")]
		[Address(RVA = "0x3F6627C", Offset = "0x3F6227C", VA = "0x3F6627C")]
		private void SetLineGroup_Level10(float[] valueArray)
		{
		}

		[Token(Token = "0x600251C")]
		[Address(RVA = "0x3F666AC", Offset = "0x3F626AC", VA = "0x3F666AC")]
		private void SetLineGroup_Level20(float[] valueArray)
		{
		}

		[Token(Token = "0x600251D")]
		[Address(RVA = "0x3F66ADC", Offset = "0x3F62ADC", VA = "0x3F66ADC")]
		private void SetLineGroup_Level30(float[] valueArray)
		{
		}

		[Token(Token = "0x600251E")]
		[Address(RVA = "0x3F67AC4", Offset = "0x3F63AC4", VA = "0x3F67AC4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600251F")]
		[Address(RVA = "0x3F67B88", Offset = "0x3F63B88", VA = "0x3F67B88", Slot = "13")]
		protected override void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6002520")]
		[Address(RVA = "0x3F67C14", Offset = "0x3F63C14", VA = "0x3F67C14", Slot = "12")]
		protected override void OnButtonExtendBackgroundClicked()
		{
		}

		[Token(Token = "0x6002521")]
		[Address(RVA = "0x3F67CA0", Offset = "0x3F63CA0", VA = "0x3F67CA0")]
		public ArtifactTraitReforgeIntroPanel()
		{
		}
	}
}
