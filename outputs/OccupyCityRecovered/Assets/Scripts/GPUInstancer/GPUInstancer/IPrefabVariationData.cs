using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000073")]
	public interface IPrefabVariationData
	{
		[Token(Token = "0x60002F7")]
		void InitializeBufferAndArray(int count, bool setDefaults = true);

		[Token(Token = "0x60002F8")]
		void SetInstanceData(GPUInstancerPrefab prefabInstance);

		[Token(Token = "0x60002F9")]
		void SetBufferData(int managedBufferStartIndex, int computeBufferStartIndex, int count);

		[Token(Token = "0x60002FA")]
		void SetVariation(GPUInstancerRenderer gpuiRenderer);

		[Token(Token = "0x60002FB")]
		void SetNewBufferSize(int newCount);

		[Token(Token = "0x60002FC")]
		GPUInstancerPrefabPrototype GetPrototype();

		[Token(Token = "0x60002FD")]
		string GetBufferName();

		[Token(Token = "0x60002FE")]
		ComputeBuffer GetBuffer();

		[Token(Token = "0x60002FF")]
		void ReleaseBuffer();
	}
}
