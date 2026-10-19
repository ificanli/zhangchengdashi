using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000068")]
	public class GPUInstancerInstanceRemover : MonoBehaviour
	{
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x20")]
		public bool useBounds;

		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x28")]
		public List<Collider> selectedColliders;

		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x30")]
		public bool removeFromDetailManagers;

		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x31")]
		public bool removeFromTreeManagers;

		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x32")]
		public bool removeFromPrefabManagers;

		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x33")]
		public bool removeAtUpdate;

		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x34")]
		public float offset;

		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x38")]
		public bool onlyRemoveSelectedPrototypes;

		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x40")]
		public List<GPUInstancerPrototype> selectedPrototypes;

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x73FE224", Offset = "0x73FA224", VA = "0x73FE224")]
		private void Reset()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x73FE2C4", Offset = "0x73FA2C4", VA = "0x73FE2C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x73FE72C", Offset = "0x73FA72C", VA = "0x73FE72C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x73FE73C", Offset = "0x73FA73C", VA = "0x73FE73C")]
		public GPUInstancerInstanceRemover()
		{
		}
	}
}
