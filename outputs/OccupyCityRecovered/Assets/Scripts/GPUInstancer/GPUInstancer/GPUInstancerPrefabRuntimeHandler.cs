using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000075")]
	public class GPUInstancerPrefabRuntimeHandler : MonoBehaviour
	{
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public GPUInstancerPrefab gpuiPrefab;

		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x28")]
		private GPUInstancerPrefabManager _prefabManager;

		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<GPUInstancerPrefabPrototype, GPUInstancerPrefabManager> _managerDictionary;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x740909C", Offset = "0x740509C", VA = "0x740909C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x74093C0", Offset = "0x74053C0", VA = "0x74093C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x7409970", Offset = "0x7405970", VA = "0x7409970")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x74094C4", Offset = "0x74054C4", VA = "0x74094C4")]
		private GPUInstancerPrefabManager GetPrefabManager()
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x7409BDC", Offset = "0x7405BDC", VA = "0x7409BDC")]
		public GPUInstancerPrefabRuntimeHandler()
		{
		}
	}
}
