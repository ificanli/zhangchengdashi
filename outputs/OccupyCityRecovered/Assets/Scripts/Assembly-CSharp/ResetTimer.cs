using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000089")]
public class ResetTimer : StateMachineBehaviour
{
	[Token(Token = "0x400029C")]
	[FieldOffset(Offset = "0x18")]
	public string timerName;

	[Token(Token = "0x400029D")]
	[FieldOffset(Offset = "0x20")]
	private float time;

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x3D22D6C", Offset = "0x3D1ED6C", VA = "0x3D22D6C", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x3D22DB8", Offset = "0x3D1EDB8", VA = "0x3D22DB8", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x3D22DE4", Offset = "0x3D1EDE4", VA = "0x3D22DE4")]
	public ResetTimer()
	{
	}
}
