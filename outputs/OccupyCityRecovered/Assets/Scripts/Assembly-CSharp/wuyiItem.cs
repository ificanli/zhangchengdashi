using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000042")]
public class wuyiItem : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct _003CInit_003Ed__4 : IAsyncStateMachine
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public wuyiItem _003C_003E4__this;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int day;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public WuyiSign.SignState signState;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x3D070D8", Offset = "0x3D030D8", VA = "0x3D070D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x3D073D8", Offset = "0x3D033D8", VA = "0x3D073D8", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject ClaimedObj;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI dayText;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform reward;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Tween _tween;

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x3D0702C", Offset = "0x3D0302C", VA = "0x3D0702C")]
	[AsyncStateMachine(typeof(_003CInit_003Ed__4))]
	public void Init(int day, WuyiSign.SignState signState)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x3D070D0", Offset = "0x3D030D0", VA = "0x3D070D0")]
	public wuyiItem()
	{
	}
}
