using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000CF")]
public class SpecialSummonGiftRewardItem : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct _003CInit_003Ed__4 : IAsyncStateMachine
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RewardConfigSingle data;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpecialSummonGiftRewardItem _003C_003E4__this;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UniTask<Sprite>.Awaiter _003C_003Eu__1;

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x3E407A4", Offset = "0x3E3C7A4", VA = "0x3E407A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x3E40FF4", Offset = "0x3E3CFF4", VA = "0x3E40FF4", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image rewardBg;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject sssrEff;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image rewardIcon;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TextMeshProUGUI rewardNum;

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x3E406F8", Offset = "0x3E3C6F8", VA = "0x3E406F8")]
	[AsyncStateMachine(typeof(_003CInit_003Ed__4))]
	public UniTask Init(RewardConfigSingle data)
	{
		return default;
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x3E4079C", Offset = "0x3E3C79C", VA = "0x3E4079C")]
	public SpecialSummonGiftRewardItem()
	{
	}
}
