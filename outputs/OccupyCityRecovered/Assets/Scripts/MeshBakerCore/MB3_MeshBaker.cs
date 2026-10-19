using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200001A")]
public class MB3_MeshBaker : MB3_MeshBakerCommon
{
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected MB3_MeshCombinerSingle _meshCombiner;

	[Token(Token = "0x17000004")]
	public override MB3_MeshCombiner meshCombiner
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x743F5E8", Offset = "0x743B5E8", VA = "0x743F5E8", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x743ED20", Offset = "0x743AD20", VA = "0x743ED20")]
	public void PrintTimings()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x743F5F0", Offset = "0x743B5F0", VA = "0x743F5F0")]
	public void BuildSceneMeshObject()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x743F614", Offset = "0x743B614", VA = "0x743F614", Slot = "27")]
	public virtual bool ShowHide(GameObject[] gos, GameObject[] deleteGOs)
	{
		return default;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x743F630", Offset = "0x743B630", VA = "0x743F630", Slot = "28")]
	public virtual void ApplyShowHide()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x743F654", Offset = "0x743B654", VA = "0x743F654", Slot = "14")]
	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource)
	{
		return default;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x743F758", Offset = "0x743B758", VA = "0x743F758", Slot = "15")]
	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
	{
		return default;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x743F804", Offset = "0x743B804", VA = "0x743F804")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x743F868", Offset = "0x743B868", VA = "0x743F868")]
	public MB3_MeshBaker()
	{
	}
}
