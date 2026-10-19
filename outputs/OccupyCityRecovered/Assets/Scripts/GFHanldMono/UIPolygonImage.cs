using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000009")]
[RequireComponent(typeof(PolygonCollider2D))]
public class UIPolygonImage : Image
{
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x110")]
	private PolygonCollider2D areaPolygon;

	[Token(Token = "0x1700000A")]
	private PolygonCollider2D Polygon
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x7067D08", Offset = "0x7063D08", VA = "0x7067D08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x7067CA4", Offset = "0x7063CA4", VA = "0x7067CA4")]
	protected UIPolygonImage()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x7067D9C", Offset = "0x7063D9C", VA = "0x7067D9C", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x7067DB4", Offset = "0x7063DB4", VA = "0x7067DB4", Slot = "88")]
	public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
	{
		return default;
	}
}
