using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000004")]
public class Hovl_DemoLasers : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x20")]
	public GameObject FirePoint;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x28")]
	public Camera Cam;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x30")]
	public float MaxLength;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x38")]
	public GameObject[] Prefabs;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x40")]
	private Ray RayMouse;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 direction;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x64")]
	private Quaternion rotation;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x74")]
	[Header("GUI")]
	private float windowDpi;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x78")]
	private int Prefab;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x80")]
	private GameObject Instance;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x88")]
	private Hovl_Laser LaserScript;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x90")]
	private Hovl_Laser2 LaserScript2;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x98")]
	private float buttonSaver;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x3CFC340", Offset = "0x3CF8340", VA = "0x3CFC340")]
	private void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x3CFC3F0", Offset = "0x3CF83F0", VA = "0x3CFC3F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3CFCB54", Offset = "0x3CF8B54", VA = "0x3CFCB54")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x3CFC3AC", Offset = "0x3CF83AC", VA = "0x3CFC3AC")]
	private void Counter(int count)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x3CFCA84", Offset = "0x3CF8A84", VA = "0x3CFCA84")]
	private void RotateToMouseDirection(GameObject obj, Vector3 destination)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x3CFCC2C", Offset = "0x3CF8C2C", VA = "0x3CFCC2C")]
	public Hovl_DemoLasers()
	{
	}
}
