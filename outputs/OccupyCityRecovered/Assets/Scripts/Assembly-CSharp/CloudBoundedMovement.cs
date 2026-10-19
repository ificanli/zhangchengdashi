using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000C2")]
public class CloudBoundedMovement : MonoBehaviour
{
	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0x20")]
	[Header("移动限制")]
	public Vector2 horizontalBounds;

	[Token(Token = "0x40003FB")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 verticalBounds;

	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0x30")]
	[Header("移动参数")]
	public float minSpeed;

	[Token(Token = "0x40003FD")]
	[FieldOffset(Offset = "0x34")]
	public float maxSpeed;

	[Token(Token = "0x40003FE")]
	[FieldOffset(Offset = "0x38")]
	public float directionChangeInterval;

	[Token(Token = "0x40003FF")]
	[FieldOffset(Offset = "0x3C")]
	public float smoothness;

	[Token(Token = "0x4000400")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 initialPosition;

	[Token(Token = "0x4000401")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 targetPosition;

	[Token(Token = "0x4000402")]
	[FieldOffset(Offset = "0x50")]
	private Vector2 currentVelocity;

	[Token(Token = "0x4000403")]
	[FieldOffset(Offset = "0x58")]
	private float directionChangeTimer;

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x3E3A380", Offset = "0x3E36380", VA = "0x3E3A380")]
	private void Start()
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x3E3A418", Offset = "0x3E36418", VA = "0x3E3A418")]
	private void Update()
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x3E3A3C8", Offset = "0x3E363C8", VA = "0x3E3A3C8")]
	private void SetRandomTarget()
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x3E3A588", Offset = "0x3E36588", VA = "0x3E3A588")]
	private void ClampPosition()
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x3E3A62C", Offset = "0x3E3662C", VA = "0x3E3A62C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x3E3A744", Offset = "0x3E36744", VA = "0x3E3A744")]
	public CloudBoundedMovement()
	{
	}
}
