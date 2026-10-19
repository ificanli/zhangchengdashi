using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000012")]
	public class AstroidGenerator : MonoBehaviour
	{
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 200000f)]
		public int count;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x28")]
		public List<GPUInstancerPrefab> asteroidObjects;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x30")]
		public GPUInstancerPrefabManager prefabManager;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x38")]
		public Transform centerTransform;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x40")]
		private List<GPUInstancerPrefab> asteroidInstances;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x48")]
		private int instantiatedCount;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 center;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 allocatedPos;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x64")]
		private Quaternion allocatedRot;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 allocatedLocalEulerRot;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 allocatedLocalScale;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x90")]
		private GPUInstancerPrefab allocatedGO;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x98")]
		private GameObject goParent;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0xA0")]
		private float allocatedLocalScaleFactor;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0xA4")]
		private int columnSize;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0xA8")]
		private int columnSpace;

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x73B18C4", Offset = "0x73AD8C4", VA = "0x73B18C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x73B2118", Offset = "0x73AE118", VA = "0x73B2118")]
		private void Start()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x73B21F8", Offset = "0x73AE1F8", VA = "0x73B21F8")]
		private void SetRandomPosInCircle(Vector3 center, int column, float radius)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x73B1DD4", Offset = "0x73ADDD4", VA = "0x73B1DD4")]
		private GPUInstancerPrefab InstantiateInCircle(Vector3 center, int column)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x73B22C0", Offset = "0x73AE2C0", VA = "0x73B22C0")]
		public AstroidGenerator()
		{
		}
	}
}
