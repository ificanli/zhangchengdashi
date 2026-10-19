using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000088")]
public class BoolOperator2 : StateMachineBehaviour
{
	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x18")]
	public string boolName;

	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x20")]
	public bool status;

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x3D22D04", Offset = "0x3D1ED04", VA = "0x3D22D04", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x3D22D34", Offset = "0x3D1ED34", VA = "0x3D22D34", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x3D22D64", Offset = "0x3D1ED64", VA = "0x3D22D64")]
	public BoolOperator2()
	{
	}
}
