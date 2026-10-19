using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200006C")]
	public class GPUInstancerPrefab : MonoBehaviour
	{
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public GPUInstancerPrefabPrototype prefabPrototype;

		[NonSerialized]
		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x28")]
		public int gpuInstancerID;

		[NonSerialized]
		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x2C")]
		public PrefabInstancingState state;

		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, object> variationDataList;

		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x38")]
		protected bool _isTransformSet;

		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x40")]
		protected Transform _instanceTransform;

		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x48")]
		protected bool _isMatrixSet;

		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x4C")]
		protected Matrix4x4 _localToWorldMatrix;

		[Token(Token = "0x60002BB")]
		public virtual void AddVariation<T>(string bufferName, T value)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x74005FC", Offset = "0x73FC5FC", VA = "0x74005FC", Slot = "5")]
		public virtual Transform GetInstanceTransform(bool forceNew = false)
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x7400640", Offset = "0x73FC640", VA = "0x7400640", Slot = "6")]
		public virtual Matrix4x4 GetLocalToWorldMatrix(bool forceNew = false)
		{
			return default;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x74006DC", Offset = "0x73FC6DC", VA = "0x74006DC", Slot = "7")]
		public virtual void SetupPrefabInstance(GPUInstancerRuntimeData runtimeData, bool forceNew = false)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x74006E0", Offset = "0x73FC6E0", VA = "0x74006E0")]
		public GPUInstancerPrefab()
		{
		}
	}
}
