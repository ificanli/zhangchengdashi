using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x200008B")]
[ExecuteAlways]
public class VolumetricFire : MonoBehaviour
{
	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x20")]
	private Mesh mesh;

	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x28")]
	private Material material;

	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x30")]
	[Tooltip("Controls the number of additional meshes to render in front of and behind the original mesh")]
	[SerializeField]
	[Range(1f, 20f)]
	private int thickness;

	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0x34")]
	[Tooltip("Controls the total distance between the frontmost mesh and the backmost mesh")]
	[SerializeField]
	[Range(0.01f, 1f)]
	private float spread;

	[Token(Token = "0x40002A5")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool billboard;

	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x40")]
	private MaterialPropertyBlock materialPropertyBlock;

	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x48")]
	private int internalCount;

	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x4C")]
	private float randomStatic;

	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x50")]
	private Collider boundaryCollider;

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x3D22E70", Offset = "0x3D1EE70", VA = "0x3D22E70")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x3D22F80", Offset = "0x3D1EF80", VA = "0x3D22F80")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x3D23024", Offset = "0x3D1F024", VA = "0x3D23024")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x3D230C8", Offset = "0x3D1F0C8", VA = "0x3D230C8")]
	private static bool IsVisible(Camera camera, Bounds bounds)
	{
		return default;
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x3D23108", Offset = "0x3D1F108", VA = "0x3D23108")]
	private void RenderFlames(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x3D23204", Offset = "0x3D1F204", VA = "0x3D23204")]
	private void SetupMaterialPropertyBlock(float item)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x3D232D4", Offset = "0x3D1F2D4", VA = "0x3D232D4")]
	private void CreateItem(float spacing, float item, Camera camera)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x3D236E4", Offset = "0x3D1F6E4", VA = "0x3D236E4")]
	public VolumetricFire()
	{
	}
}
