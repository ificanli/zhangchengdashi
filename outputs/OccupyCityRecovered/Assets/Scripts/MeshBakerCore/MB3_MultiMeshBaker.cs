using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000023")]
public class MB3_MultiMeshBaker : MB3_MeshBakerCommon
{
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected MB3_MultiMeshCombiner _meshCombiner;

	[Token(Token = "0x1700000A")]
	public override MB3_MeshCombiner meshCombiner
	{
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x74435F8", Offset = "0x743F5F8", VA = "0x74435F8", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x7442F0C", Offset = "0x743EF0C", VA = "0x7442F0C")]
	public void PrintTimings()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x7443600", Offset = "0x743F600", VA = "0x7443600", Slot = "14")]
	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource)
	{
		return default;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x744379C", Offset = "0x743F79C", VA = "0x744379C", Slot = "15")]
	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOs, bool disableRendererInSource)
	{
		return default;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x7443938", Offset = "0x743F938", VA = "0x7443938")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x7443958", Offset = "0x743F958", VA = "0x7443958")]
	public MB3_MultiMeshBaker()
	{
	}
}
