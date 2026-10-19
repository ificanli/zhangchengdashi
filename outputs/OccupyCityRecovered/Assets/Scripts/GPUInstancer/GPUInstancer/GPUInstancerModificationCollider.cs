using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200006B")]
	public class GPUInstancerModificationCollider : MonoBehaviour
	{
		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x20")]
		public GPUInstancerPrefabManager prefabManager;

		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x28")]
		private List<GPUInstancerPrefab> _enteredInstances;

		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x30")]
		private Collider _collider;

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x73FFE30", Offset = "0x73FBE30", VA = "0x73FFE30")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x73FFFCC", Offset = "0x73FBFCC", VA = "0x73FFFCC")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x7400338", Offset = "0x73FC338", VA = "0x7400338")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x74001C4", Offset = "0x73FC1C4", VA = "0x74001C4")]
		public bool IsInsideCollider(GPUInstancerPrefab prefabInstance)
		{
			return default;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x7400508", Offset = "0x73FC508", VA = "0x7400508")]
		public void AddEnteredInstance(GPUInstancerPrefab prefabInstance)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x74005AC", Offset = "0x73FC5AC", VA = "0x74005AC")]
		public int GetEnteredInstanceCount()
		{
			return default;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x74005F4", Offset = "0x73FC5F4", VA = "0x74005F4")]
		public GPUInstancerModificationCollider()
		{
		}
	}
}
