using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200099F")]
	public class MultistageNewcomerPackagePanel_ToggleLevelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009A0")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__42 : IAsyncStateMachine
		{
			[Token(Token = "0x40047FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40047FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40047FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MultistageNewcomerPackagePanel_ToggleLevelComponents _003C_003E4__this;

			[Token(Token = "0x40047FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600391D")]
			[Address(RVA = "0x40FFA88", Offset = "0x40FBA88", VA = "0x40FFA88", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600391E")]
			[Address(RVA = "0x40FFD00", Offset = "0x40FBD00", VA = "0x40FFD00", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40047FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Toggle _toggleMultistageNewcomerPackagePanel_ToggleLevel;

		[Token(Token = "0x40047FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUIPriceText;

		[Token(Token = "0x170008A5")]
		public Toggle ToggleMultistageNewcomerPackagePanel_ToggleLevel
		{
			[Token(Token = "0x6003914")]
			[Address(RVA = "0x40FF7C4", Offset = "0x40FB7C4", VA = "0x40FF7C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A6")]
		public TextMeshProUGUI TextMeshProUGUIPriceText
		{
			[Token(Token = "0x6003915")]
			[Address(RVA = "0x40FF27C", Offset = "0x40FB27C", VA = "0x40FF27C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003916")]
		[Address(RVA = "0x40FF868", Offset = "0x40FB868", VA = "0x40FF868")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003917")]
		[Address(RVA = "0x40FF904", Offset = "0x40FB904", VA = "0x40FF904", Slot = "12")]
		protected virtual void OnToggleLevelValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6003918")]
		[Address(RVA = "0x40FF9B0", Offset = "0x40FB9B0", VA = "0x40FF9B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003919")]
		[Address(RVA = "0x40FF358", Offset = "0x40FB358", VA = "0x40FF358", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__42))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600391A")]
		[Address(RVA = "0x40FF9CC", Offset = "0x40FB9CC", VA = "0x40FF9CC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600391B")]
		[Address(RVA = "0x40FF34C", Offset = "0x40FB34C", VA = "0x40FF34C")]
		public MultistageNewcomerPackagePanel_ToggleLevelComponents()
		{
		}
	}
}
