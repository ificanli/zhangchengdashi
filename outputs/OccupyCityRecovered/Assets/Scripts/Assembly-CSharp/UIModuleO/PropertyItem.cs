using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20007B2")]
	public class PropertyItem : PropertyItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007B3")]
		[CompilerGenerated]
		private struct _003CInitInfo_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PropertyIconType propertyIconType;

			[Token(Token = "0x4003B8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PropertyItem _003C_003E4__this;

			[Token(Token = "0x4003B90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public UserHeroCardData data;

			[Token(Token = "0x4003B91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003B92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002A89")]
			[Address(RVA = "0x3FD7D5C", Offset = "0x3FD3D5C", VA = "0x3FD7D5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A8A")]
			[Address(RVA = "0x3FDB054", Offset = "0x3FD7054", VA = "0x3FDB054", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007B4")]
		[CompilerGenerated]
		private struct _003CInitResources_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PropertyItem _003C_003E4__this;

			[Token(Token = "0x4003B96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UserHeroCardData data;

			[Token(Token = "0x4003B97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003B98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002A8B")]
			[Address(RVA = "0x3FDB060", Offset = "0x3FD7060", VA = "0x3FDB060", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A8C")]
			[Address(RVA = "0x3FDB784", Offset = "0x3FD7784", VA = "0x3FDB784", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6002A86")]
		[Address(RVA = "0x3FD7C08", Offset = "0x3FD3C08", VA = "0x3FD7C08")]
		[AsyncStateMachine(typeof(_003CInitInfo_003Ed__0))]
		public void InitInfo(PropertyIconType propertyIconType, UserHeroCardData data, bool showUplevelText = true)
		{
		}

		[Token(Token = "0x6002A87")]
		[Address(RVA = "0x3FD7CAC", Offset = "0x3FD3CAC", VA = "0x3FD7CAC")]
		[AsyncStateMachine(typeof(_003CInitResources_003Ed__1))]
		public void InitResources(UserHeroCardData data)
		{
		}

		[Token(Token = "0x6002A88")]
		[Address(RVA = "0x3FD7D4C", Offset = "0x3FD3D4C", VA = "0x3FD7D4C")]
		public PropertyItem()
		{
		}
	}
}
