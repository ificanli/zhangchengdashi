using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TimeModuleO;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A62")]
	public class NewMainCityItem : NewMainCityItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A64")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4004CCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004CCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004CCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NewMainCityItem _003C_003E4__this;

			[Token(Token = "0x4004CCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003E6B")]
			[Address(RVA = "0x416E0A4", Offset = "0x416A0A4", VA = "0x416E0A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003E6C")]
			[Address(RVA = "0x416E284", Offset = "0x416A284", VA = "0x416E284", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A65")]
		[CompilerGenerated]
		private struct _003CupdateProgress_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4004CCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004CD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004CD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public NewMainCityItem _003C_003E4__this;

			[Token(Token = "0x4004CD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4004CD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003E6D")]
			[Address(RVA = "0x416E290", Offset = "0x416A290", VA = "0x416E290", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003E6E")]
			[Address(RVA = "0x416F0B4", Offset = "0x416B0B4", VA = "0x416F0B4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004CC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TimeManager.Timer _timer;

		[Token(Token = "0x4004CC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float _nextIdleTextUpdateTime;

		[Token(Token = "0x6003E5D")]
		[Address(RVA = "0x416CACC", Offset = "0x4168ACC", VA = "0x416CACC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003E5E")]
		[Address(RVA = "0x416CCD4", Offset = "0x4168CD4", VA = "0x416CCD4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__3))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003E5F")]
		[Address(RVA = "0x416CD68", Offset = "0x4168D68", VA = "0x416CD68")]
		public void Init()
		{
		}

		[Token(Token = "0x6003E60")]
		[Address(RVA = "0x416CDE0", Offset = "0x4168DE0", VA = "0x416CDE0")]
		public void UpdateUI(object o)
		{
		}

		[Token(Token = "0x6003E61")]
		[Address(RVA = "0x416CF90", Offset = "0x4168F90", VA = "0x416CF90")]
		public void UpdateProperty()
		{
		}

		[Token(Token = "0x6003E62")]
		[Address(RVA = "0x416D738", Offset = "0x4169738", VA = "0x416D738")]
		[AsyncStateMachine(typeof(_003CupdateProgress_003Ed__7))]
		public void updateProgress()
		{
		}

		[Token(Token = "0x6003E63")]
		[Address(RVA = "0x416DC78", Offset = "0x4169C78", VA = "0x416DC78")]
		private void Update()
		{
		}

		[Token(Token = "0x6003E64")]
		[Address(RVA = "0x416DDC8", Offset = "0x4169DC8", VA = "0x416DDC8", Slot = "12")]
		protected override void OnButtonExtendCityPassClicked()
		{
		}

		[Token(Token = "0x6003E65")]
		[Address(RVA = "0x416DE38", Offset = "0x4169E38", VA = "0x416DE38", Slot = "13")]
		protected override void OnButtonExtendIdleInfosClicked()
		{
		}

		[Token(Token = "0x6003E66")]
		[Address(RVA = "0x416DF7C", Offset = "0x4169F7C", VA = "0x416DF7C")]
		public NewMainCityItem()
		{
		}
	}
}
