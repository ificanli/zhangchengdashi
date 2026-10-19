using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000074")]
	public class PrefabVariationData<T> : IPrefabVariationData
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GPUInstancerPrefabPrototype prototype;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string bufferName;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ComputeBuffer variationBuffer;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] dataArray;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T defaultValue;

		[Token(Token = "0x6000300")]
		public PrefabVariationData(GPUInstancerPrefabPrototype prototype, string bufferName, [Optional] T defaultValue)
		{
		}

		[Token(Token = "0x6000301")]
		public void InitializeBufferAndArray(int count, bool setDefaults = true)
		{
		}

		[Token(Token = "0x6000302")]
		public void SetArrayAndInitializeBuffer(T[] dataArray)
		{
		}

		[Token(Token = "0x6000303")]
		public void SetArrayAndInitializeBuffer<K>(NativeArray<K> dataArray) where K : struct
		{
		}

		[Token(Token = "0x6000304")]
		public void SetInstanceData(GPUInstancerPrefab prefabInstance)
		{
		}

		[Token(Token = "0x6000305")]
		public void SetBufferData(int managedBufferStartIndex, int computeBufferStartIndex, int count)
		{
		}

		[Token(Token = "0x6000306")]
		public void SetVariation(GPUInstancerRenderer gpuiRenderer)
		{
		}

		[Token(Token = "0x6000307")]
		public void SetNewBufferSize(int newCount)
		{
		}

		[Token(Token = "0x6000308")]
		public GPUInstancerPrefabPrototype GetPrototype()
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		public ComputeBuffer GetBuffer()
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		public string GetBufferName()
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		public void ReleaseBuffer()
		{
		}
	}
}
