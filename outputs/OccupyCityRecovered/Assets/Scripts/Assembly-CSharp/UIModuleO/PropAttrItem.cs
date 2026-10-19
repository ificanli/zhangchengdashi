using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200080A")]
	public class PropAttrItem : PropAttrItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200080B")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4003DAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003DAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003DAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropAttrItem _003C_003E4__this;

			[Token(Token = "0x4003DAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropManager.PropAttrType type;

			[Token(Token = "0x4003DAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003DB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002CE4")]
			[Address(RVA = "0x4005444", Offset = "0x4001444", VA = "0x4005444", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002CE5")]
			[Address(RVA = "0x4005A60", Offset = "0x4001A60", VA = "0x4005A60", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003DAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PropManager.PropAttrType _type;

		[Token(Token = "0x6002CE1")]
		[Address(RVA = "0x40051F0", Offset = "0x40011F0", VA = "0x40051F0")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public UniTask Init(PropManager.PropAttrType type)
		{
			return default;
		}

		[Token(Token = "0x6002CE2")]
		[Address(RVA = "0x4005290", Offset = "0x4001290", VA = "0x4005290")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6002CE3")]
		[Address(RVA = "0x4005434", Offset = "0x4001434", VA = "0x4005434")]
		public PropAttrItem()
		{
		}
	}
}
